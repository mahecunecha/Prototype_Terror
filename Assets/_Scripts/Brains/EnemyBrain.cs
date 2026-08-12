using UnityEngine;
using UnityEngine.AI; // Acceso al sistema de navegación
using UnityEngine.SceneManagement; // Importado para reiniciar la escena
using _Scripts.Systems;     // Acceso al corazón de datos (ScriptableObject)
using _Scripts.Interfaces;   // Acceso al contrato IEstado
using _Scripts.States;       // Acceso a las lógicas de estado (Rastreo, Sigilo...)

namespace _Scripts.Brains
{
    /* * * CLASE: EnemyBrain
     * DESCRIPCIÓN: Actúa como el "Cuerpo" y "Contexto" de la IA (Hardware). 
     * No decide qué hacer por sí mismo, sino que delega esa tarea a un objeto IEstado.
     * Mantiene vivo el cronómetro de 60s para el enfriamiento.
     * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
    public class EnemyBrain : MonoBehaviour
    {
        [Header("Referencias de Datos")]
        [Tooltip("El archivo de datos (SO) que compartimos con el jugador y el sistema")]
        [SerializeField] private IntuicionSystem data;
        public IntuicionSystem Data => data; // Propiedad pública para los Estados
        
        [Header("Configuración de Movimiento y Navegación")]
        [Tooltip("Agente de navegación del enemigo")]
        [SerializeField] private NavMeshAgent agent;
        public NavMeshAgent Agent => agent; // Propiedad pública para los Estados

        [Tooltip("Velocidad de traslación física base.")]
        [SerializeField] private float velocidadBase = 3.5f;
        
        [Tooltip("Puntos de patrulla para el movimiento perpetuo.")]
        [SerializeField] private Transform[] waypoints; 
        public Transform[] Waypoints => waypoints; // Propiedad pública para los Estados
        

        [Header("Instintos Base")]
        [Tooltip("Transform del jugador para el Olfato")]
        [SerializeField] private Transform transformJugador;
        [Tooltip("Distancia a la que el enemigo mata instantáneamente")]
        [SerializeField] private float distanciaOlfato = 1.5f;

        /* LÓGICA DE MÁQUINA DE ESTADOS e OPTIMIZACIÓN (CACHING) */
        private IEstado _estadoActual; 
        
        // Cacheamos las instancias de los estados para evitar asignaciones de memoria (GC Allocations)
        private IEstado _estadoRastreo;
        private IEstado _estadoSigilo;
        private IEstado _estadoPersecucion;
        private IEstado _estadoSedDeSangre;

        [Header("Reloj de Recuperación")]
        // Contador de segundos para llegar al minuto de enfriamiento
        private float _cronometroSesentaSeg = 0f;
        
        // Guardamos el nivel de fase actual (1, 2, 3...) para pasárselo al SO en el Tick
        private int _nivelMiedoActual = 1;

        /* * *
         * MÉTODO: Start
         * Se ejecuta al nacer. Configuramos los estados cacheando referencias y el estado inicial.
         */
        private void Start()
        {
            if (!data) return; // Si no hay datos sal de la función.
            
            // Verificación y asignación automática de componentes obligatorios
            if (!agent) agent = GetComponent<NavMeshAgent>();
            if (!agent) Debug.LogError("EnemyBrain: Falta el componente NavMeshAgent.");
            if (!transformJugador) Debug.LogError("EnemyBrain: Falta asignar el Transform del Jugador para el Olfato.");

            // Suscripción al SO
            data.OnSubirFase += HandleSubirFase;
            data.OnBajarFase += HandleBajarFase;
                
            // OPTIMIZACIÓN: Instanciamos los estados una sola vez en el inicio
            _estadoRastreo = new EstadoRastreo(this);
            _estadoSigilo = new EstadoSigilo(this);
            _estadoPersecucion = new EstadoPersecucion(this);
            _estadoSedDeSangre = new EstadoSedDeSangre(this);
            
            // ESTADO INICIAL: Iniciamos usando la referencia cacheada
            CambiarEstado(_estadoRastreo);
        }

        /* * *
         * MÉTODO: Update
         * Ejecución por frame. Mantenemos el pulso de los relojes y la máquina de estados.
         */
        private void Update()
        {
            if (!data) return;

            // 1. CONDICIÓN GLOBAL (OLFATO): Instinto base primario
            if (transformJugador != null && Vector3.Distance(transform.position, transformJugador.position) <= distanciaOlfato)
            {
                EjecutarMuertePorOlfato();
                return;
            }

            // 2. Manejamos el tiempo para el enfriamiento de 60s
            ManejarCronometroRecuperacion();
            
            // 3. EJECUCIÓN DEL ESTADO: El estado controla la lógica en este frame
            _estadoActual?.Ejecutar(); 
        }

        private void EjecutarMuertePorOlfato()
        {
            Debug.Log("<color=red>¡JUGADOR ASESINADO POR OLFATO! Reiniciando escena...</color>");
            
            // Detenemos el movimiento físico inmediatamente
            if (agent != null && agent.isOnNavMesh)
            {
                agent.isStopped = true;
            }

            // Reiniciamos la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        /* * *
         * MÉTODO: ActualizarVelocidad
         * Función pública para que los ESTADOS puedan cambiar la velocidad del NavMeshAgent.
         */
        public void ActualizarVelocidad(float nuevaVelocidad)
        {
            velocidadBase = nuevaVelocidad;
            if (agent != null)
            {
                agent.speed = nuevaVelocidad;
            }
        }

        /* * *
         * MÉTODO: MoverHacia
         * Función pública para que los ESTADOS ordenen el destino al NavMeshAgent.
         */
        public void MoverHacia(Vector3 destino)
        {
            if (agent != null && agent.isOnNavMesh)
            {
                agent.SetDestination(destino);
            }
        }

        /* * *
         * MÉTODO: CambiarEstado
         * Transición limpia de estados reutilizando referencias existentes.
         */
        public void CambiarEstado(IEstado nuevoEstado)
        {
            _estadoActual?.Salir();
            _estadoActual = nuevoEstado;
            _estadoActual.Entrar();
        }

        /* * *
         * MÉTODO: ManejarCronometroRecuperacion
         * Controla el enfriamiento por Ticks.
         */
        private void ManejarCronometroRecuperacion()
        {
            _cronometroSesentaSeg += Time.deltaTime;

            if (_cronometroSesentaSeg >= 60f)
            {
                data.EjecutarTickDeRecuperacion(_nivelMiedoActual);
                _cronometroSesentaSeg = 0f;
            }
        }

        // --- MANEJADORES DE EVENTOS ---

        private void HandleSubirFase()
        {
            _nivelMiedoActual = Mathf.Clamp(_nivelMiedoActual + 1, 1, 4);
            Debug.Log($"<color=orange>RADIO: El enemigo subió al Nivel {_nivelMiedoActual}</color>");
            ActualizarEstadoPorNivel();
        }

        private void HandleBajarFase()
        {
            _nivelMiedoActual = Mathf.Clamp(_nivelMiedoActual - 1, 1, 4);
            Debug.Log($"<color=cyan>RADIO: El enemigo bajó al Nivel {_nivelMiedoActual}</color>");
            ActualizarEstadoPorNivel();
        }

        private void ActualizarEstadoPorNivel()
        {
            switch (_nivelMiedoActual)
            {
                case 1:
                    CambiarEstado(_estadoRastreo);
                    break;
                case 2:
                    CambiarEstado(_estadoSigilo);
                    break;
                case 3:
                    CambiarEstado(_estadoPersecucion);
                    break;
                case 4:
                    CambiarEstado(_estadoSedDeSangre);
                    break;
            }
        }

        /* * *
         * MÉTODO DE LIMPIEZA: OnDestroy
         * Se ejecuta si matamos al enemigo o cambiamos de escena.
         * Desconecta los cables de radio para no causar errores de memoria.
         */
        private void OnDestroy()
        {
            if (data != null)
            {
                data.OnSubirFase -= HandleSubirFase;
                data.OnBajarFase -= HandleBajarFase;
            }
        }
    }
}
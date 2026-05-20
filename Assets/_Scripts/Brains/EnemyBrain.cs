using UnityEngine;
using _Scripts.Systems;      // Acceso al corazón de datos (ScriptableObject)
using _Scripts.Interfaces;   // Acceso al contrato IEstado
using _Scripts.States;       // Acceso a las lógicas de estado (Rastreo, Sigilo...)

namespace _Scripts.Brains
{
    /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
     * CLASE: EnemyBrain
     * DESCRIPCIÓN: Actúa como el "Cuerpo" y "Contexto" de la IA. 
     * No decide qué hacer por sí mismo, sino que delega esa tarea a un objeto IEstado.
     * Mantiene vivo el cronómetro de 60s para el enfriamiento de la intuición.
     * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
    public class EnemyBrain : MonoBehaviour
    {
        [Header("Referencias de Datos")]
        [Tooltip("El archivo de datos (SO) que compartimos con el jugador y el sistema")]
        [SerializeField] private IntuicionSystem data;
        
        [Header("Configuración de Movimiento")]
        [Tooltip("Velocidad de traslación física. Los estados la modificarán.")]
        [SerializeField] private float velocidadBase = 3.5f;
        
        [Tooltip("Puntos de patrulla para el movimiento perpetuo.")]
        [SerializeField] private Transform[] waypoints; 
        
        // Índice interno para saber a qué punto de la lista 'waypoints' nos dirigimos
        private int _indexWaypointActual = 0;
        
        /* --- LÓGICA DE MÁQUINA DE ESTADOS ---
         * Aquí guardamos el estado actual (Rastreo, Persecución, etc.) */
        private IEstado _estadoActual; 

        [Header("Reloj de Recuperación")]
        // Contador de segundos para llegar al minuto de enfriamiento
        private float _cronometroSesentaSeg = 0f;
        
        // Guardamos el nivel de fase actual (1, 2, 3...) para pasárselo al SO en el Tick
        private int _nivelMiedoActual = 1;

        /* * *
         * MÉTODO: Start
         * Se ejecuta al nacer. Configuramos la radio y el estado inicial.
         */
        private void Start()
        {
            // Cláusula de salvaguarda: Si no hay datos, sal de la función ahora mismo.
            if (!data) return; 

            // SUSCRIPCIÓN (La Radio): Le decimos al SO que nos avise si hay cambios de fase
            data.OnSubirFase += HandleSubirFase;
            data.OnBajarFase += HandleBajarFase;
                
            // ESTADO INICIAL: Siempre empezamos buscando (Rastreo)
            // 'this' le pasa esta misma cápsula/cerebro al estado para que pueda controlarlo
            CambiarEstado(new EstadoRastreo(this));
        }

        /* * *
         * MÉTODO: Update
         * Ejecución por frame. Mantenemos el pulso de los relojes y la máquina de estados.
         */
        private void Update()
        {
            // Protección: Si el SO desaparece por error, no hacemos nada
            if (!data) return;

            // 1. EL RELOJ: Manejamos el tiempo para el enfriamiento de 60s
            ManejarCronometroRecuperacion();
            
            // 2. EJECUCIÓN DEL ESTADO: Le decimos al estado actual: "Haz lo tuyo en este frame"
            // El símbolo '?' asegura que no explote si la variable de estado está vacía
            _estadoActual?.Ejecutar(); 

            // 3. MOVIMIENTO: El cuerpo siempre se está desplazando hacia un objetivo
            ManejarMovimientoPerpetuo();
        }

        /* * *
         * MÉTODO PÚBLICO: ActualizarVelocidad
         * Función para que los ESTADOS (como EstadoRastreo) puedan cambiar
         * la velocidad de este cuerpo desde afuera sin hacer variables públicas.
         */
        public void ActualizarVelocidad(float nuevaVelocidad)
        {
            velocidadBase = nuevaVelocidad;
        }

        /* * *
         * MÉTODO PÚBLICO: CambiarEstado
         * El "Interruptor" principal de la IA. Hace transiciones limpias.
         */
        public void CambiarEstado(IEstado nuevoEstado)
        {
            // Primero: Le decimos al estado viejo que limpie sus cosas (animaciones, sonidos)
            _estadoActual?.Salir();

            // Segundo: Intercambiamos la lógica al nuevo estado
            _estadoActual = nuevoEstado;

            // Tercero: Le decimos al nuevo estado que inicie (Entrar)
            _estadoActual.Entrar();
        }

        /* * *
         * LÓGICA PRIVADA: ManejarCronometroRecuperacion
         * Controla el enfriamiento por Ticks. Ahorra CPU.
         */
        private void ManejarCronometroRecuperacion()
        {
            // Acumulamos el tiempo real pasado desde el último frame
            _cronometroSesentaSeg += Time.deltaTime;

            // Si llegamos al umbral de 60 segundos (1 minuto)
            if (_cronometroSesentaSeg >= 60f)
            {
                // Llamamos al SO para que aplique la fórmula matemática de enfriamiento
                data.EjecutarTickDeRecuperacion(_nivelMiedoActual);
                
                // Reseteamos el reloj
                _cronometroSesentaSeg = 0f;
            }
        }

        /* * *
         * LÓGICA PRIVADA: ManejarMovimientoPerpetuo
         * Define la brújula del enemigo (Hacia dónde debe caminar hoy).
         */
        private void ManejarMovimientoPerpetuo()
        {
            // Si el diseñador de niveles olvidó poner waypoints, el enemigo se queda quieto
            if (waypoints == null || waypoints.Length == 0) return;

            Vector3 destino;

            // PRIORIDAD 1: LA INTUICIÓN
            // Si la intuición es mayor al 20%, ignora los waypoints y ve directo al sonido
            if (data.IntuicionActual > 0.2f)
            {
                destino = data.posicionSospechosa;
            }
            // PRIORIDAD 2: PATRULLA NORMAL
            else
            {
                destino = waypoints[_indexWaypointActual].position;

                // Si estamos muy cerca del waypoint actual, saltamos al siguiente
                if (Vector3.Distance(transform.position, destino) < 0.5f)
                {
                    // El operador '%' crea un bucle infinito (0,1,2 -> 0,1,2...)
                    _indexWaypointActual = (_indexWaypointActual + 1) % waypoints.Length;
                }
            }

            // APLICACIÓN FÍSICA: Movemos el cuerpo hacia el destino calculado
            transform.position = Vector3.MoveTowards(transform.position, destino, velocidadBase * Time.deltaTime);
            
            // ROTACIÓN: Hacemos que el enemigo mire hacia donde camina, ignorando el eje Y para que no vuelque
            transform.LookAt(new Vector3(destino.x, transform.position.y, destino.z));
        }

        // --- MANEJADORES DE EVENTOS (LA RADIO) ---

        // Se dispara automáticamente cuando el vaso (IntuicionSystem) llega a 1.0
        private void HandleSubirFase()
        {
            _nivelMiedoActual++;
            Debug.Log($"<color=orange>RADIO: El enemigo subió al Nivel {_nivelMiedoActual}</color>");
            
            // Tarea para el programador de IA:
            // if (_nivelMiedoActual == 2) CambiarEstado(new EstadoSigilo(this));
            // if (_nivelMiedoActual == 3) CambiarEstado(new EstadoPersecucion(this));
        }

        // Se dispara cuando la intuición baja a 0.0 tras un enfriamiento
        // ReSharper disable Unity.PerformanceAnalysis
        private void HandleBajarFase()
        {
            // Aseguramos que el nivel nunca sea menor a 1
            _nivelMiedoActual = Mathf.Max(1, _nivelMiedoActual - 1);
            
            // Si bajamos al nivel 1, forzamos al enemigo a volver al Rastreo ciego
            if(_nivelMiedoActual == 1) CambiarEstado(new EstadoRastreo(this));
            
            Debug.Log($"<color=cyan>RADIO: El enemigo bajó al Nivel {_nivelMiedoActual}</color>");
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
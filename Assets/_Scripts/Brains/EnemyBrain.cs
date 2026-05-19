using UnityEngine;
using _Scripts.Systems;     // Acceso al corazón de datos (ScriptableObject)
using _Scripts.Interfaces;   // Acceso al contrato IEstado
using _Scripts.States;       // Acceso a las lógicas de estado (Rastreo, Sigilo...)

namespace _Scripts.Brains
{
    /* * * CLASE: EnemyBrain
     * DESCRIPCIÓN: Actúa como el "Cuerpo" y "Contexto" de la IA. 
     * No decide qué hacer por sí mismo, sino que delega esa tarea a un objeto IEstado.
     * Mantiene vivo el cronómetro de 60s para el enfriamiento.
     */
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

        
        /*  LÓGICA DE MÁQUINA DE ESTADOS 
         Aquí guardamos el estado actual (Rastreo, Persecución, etc.)*/
        private IEstado _estadoActual; 

        [Header("Reloj de Recuperación")]
        // Contador de segundos para llegar al minuto de enfriamiento
        private float _cronometroSesentaSeg = 0f;
        
        // Guardamos el nivel de fase actual (1, 2, 3...) para pasárselo al SO en el Tick
        private int _nivelMiedoActual = 1;

        /* *
         * MÉTODO: Start
         * Se ejecuta al nacer. Configuramos la radio y el estado inicial.
         */
        private void Start()
        {
            /*
             // CÓDIGO ANIDADO (Indeseado)
                   if (data != null) {
                       // Todo el código vive "atrapado" dentro de llaves
                       data.OnSubirFase += HandleSubirFase;
                   }
             */
            //CODIGO PLANO (Profesional)
            if (!data) return; // Sino hay datos sal de la funcion ahora mismo.
            // El resto del código respira libre, sin estar dentro de un if
            // SUSCRIPCIÓN (La Radio): Le decimos al SO que nos avise si hay cambios de fase
            data.OnSubirFase += HandleSubirFase;
            data.OnBajarFase += HandleBajarFase;
                
            // ESTADO INICIAL: Siempre empezamos buscando (Rastreo)
            // 'this' le pasa este mismo cerebro al estado para que pueda controlarlo
            CambiarEstado(new EstadoRastreo(this));
        }

        /* *
         * MÉTODO: Update
         * Ejecución por frame. Mantenemos el pulso de los relojes y el estado.
         */
        private void Update()
        {
            /* if (data == null): Es una comparación explícita.
              if (!data): Es la forma abreviada de Unity. Internamente,
             Unity hace una comprobación más profunda que un simple null de C#.
             Verifica si el objeto "nativo" (el que vive en el motor) sigue vivo.*/
            // Protección: Si no hay datos, no hacemos nada (Evita errores en consola)
            if (!data) return;

            // 1. Manejamos el tiempo para el enfriamiento de 60s
            ManejarCronometroRecuperacion();
            
            // 2. EJECUCIÓN DEL ESTADO: Le decimos al estado actual: "Haz lo tuyo en este frame"
            // El símbolo '?' asegura que no explote si no hay un estado asignado
            _estadoActual?.Ejecutar(); 

            // 3. MOVIMIENTO: El cuerpo siempre se está desplazando
            ManejarMovimientoPerpetuo();
        }

        /* *
         * MÉTODO: ActualizarVelocidad
         * Función pública para que los ESTADOS (como EstadoRastreo) puedan cambiar
         * la velocidad de este cuerpo sin tocar variables privadas.
         */
        public void ActualizarVelocidad(float nuevaVelocidad)
        {
            velocidadBase = nuevaVelocidad;
        }

        /* *
         * MÉTODO: CambiarEstado
         * El "Cerebro" de la arquitectura. Se encarga de hacer la transición limpia.
         */
        public void CambiarEstado(IEstado nuevoEstado)
        {
            // Primero: Le decimos al estado viejo que limpie sus cosas (animaciones, sonidos)
            _estadoActual?.Salir();

            // Segundo: Intercambiamos la lógica
            _estadoActual = nuevoEstado;

            // Tercero: Le decimos al nuevo estado que se prepare (Entrar)
            _estadoActual.Entrar();
        }

        /* *
         * MÉTODO: ManejarCronometroRecuperacion
         * Controla el enfriamiento por Ticks. Ahorra CPU al no calcular enfriamiento por frame.
         */
        // ReSharper disable Unity.PerformanceAnalysis
        private void ManejarCronometroRecuperacion()
        {
            // Acumulamos el tiempo real pasado desde el último frame
            _cronometroSesentaSeg += Time.deltaTime;

            // Si llegamos al umbral de 60 segundos diseñado...
            if (_cronometroSesentaSeg >= 60f)
            {
                // Llamamos al SO para que aplique la fórmula (1/3 * 1/miedo)
                data.EjecutarTickDeRecuperacion(_nivelMiedoActual);
                
                // Reseteamos el reloj para el próximo minuto
                _cronometroSesentaSeg = 0f;
            }
        }

        /* *
         * MÉTODO: ManejarMovimientoPerpetuo
         * Define hacia dónde se mueve la cápsula.
         */
        private void ManejarMovimientoPerpetuo()
        {
            // Protección: Si no asignaste waypoints en Unity, el enemigo se queda quieto
            if (waypoints == null || waypoints.Length == 0) return;

            Vector3 destino;

            // Lógica de Prioridad:
            // Si la intuición es > 0.2 (20%), vamos a la posición del ruido.
            // Si no, seguimos la ruta de patrulla normal.
            if (data.IntuicionActual > 0.2f)
            {
                destino = data.posicionSospechosa;
            }
            else
            {
                destino = waypoints[_indexWaypointActual].position;

                // Si estamos muy cerca del waypoint actual, saltamos al siguiente en la lista
                if (Vector3.Distance(transform.position, destino) < 0.5f)
                {
                    // El operador '%' hace que al llegar al final de la lista, vuelva al 0 (Bucle)
                    _indexWaypointActual = (_indexWaypointActual + 1) % waypoints.Length;
                }
            }

            // APLICACIÓN FÍSICA: Movemos el objeto hacia el destino calculado
            transform.position = Vector3.MoveTowards(transform.position, destino, velocidadBase * Time.deltaTime);
            
            // Hacemos que el enemigo siempre mire hacia donde camina (excepto en el eje Y para no rotar raro)
            transform.LookAt(new Vector3(destino.x, transform.position.y, destino.z));
        }

        // --- MANEJADORES DE EVENTOS (LA RADIO) ---

        // Se dispara cuando la intuición llega a 1.0
        private void HandleSubirFase()
        {
            _nivelMiedoActual++;
            Debug.Log($"<color=orange>RADIO: El enemigo subió al Nivel {_nivelMiedoActual}</color>");
            // Nota: Aquí el cerebro decidirá qué nuevo estado instanciar en el futuro
        }

        // Se dispara cuando la intuición baja a 0.0 tras un Tick
        private void HandleBajarFase()
        {
            // Aseguramos que el nivel nunca sea menor a 1
            _nivelMiedoActual = Mathf.Max(1, _nivelMiedoActual - 1);
            
            // Si bajamos al nivel base, nos forzamos a volver a Rastreo
            if(_nivelMiedoActual == 1) CambiarEstado(new EstadoRastreo(this));
            
            Debug.Log($"<color=cyan>RADIO: El enemigo bajó al Nivel {_nivelMiedoActual}</color>");
        }

        /* *
         * MÉTODO: OnDestroy
         * Limpieza de memoria. Evita que la "Radio" intente hablar con un objeto muerto.
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
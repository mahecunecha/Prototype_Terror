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
        private int indexWaypointActual = 0;

        // --- LÓGICA DE ESTADOS ---
        private IEstado _estadoActual; // El "canal" de radio que suena ahora

        [Header("Reloj de Recuperación")]
        private float cronometroSesentaSeg = 0f;
        private int nivelMiedoActual = 1;

        /* *
         * MÉTODO: Start
         * Se ejecuta al nacer. Configuramos la radio y el estado inicial.
         */
        private void Start()
        {
            if (data != null)
            {
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
            if (data is null) return;

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

        // ReSharper disable Unity.PerformanceAnalysis
        private void ManejarCronometroRecuperacion()
        {
            cronometroSesentaSeg += Time.deltaTime;
            if (cronometroSesentaSeg >= 60f)
            {
                data.EjecutarTickDeRecuperacion(nivelMiedoActual);
                cronometroSesentaSeg = 0f;
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

            transform.position = Vector3.MoveTowards(transform.position, destino, velocidadBase * Time.deltaTime);
            
            // Hacemos que el enemigo siempre mire hacia donde camina (excepto en el eje Y para no rotar raro)
            transform.LookAt(new Vector3(destino.x, transform.position.y, destino.z));
        }

        // --- MANEJADORES DE EVENTOS (LA RADIO) ---

        // Se dispara cuando la intuición llega a 1.0
        private void HandleSubirFase()
        {
            nivelMiedoActual++;
            // Aquí más adelante crearemos: CambiarEstado(new EstadoSigilo(this));
            Debug.Log($"Subiendo a fase {nivelMiedoActual}");
        }

        // Se dispara cuando la intuición baja a 0.0 tras un Tick
        private void HandleBajarFase()
        {
            nivelMiedoActual = Mathf.Max(1, nivelMiedoActual - 1);
            if(nivelMiedoActual == 1) CambiarEstado(new EstadoRastreo(this));
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
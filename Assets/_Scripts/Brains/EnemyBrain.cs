using UnityEngine;
using _Scripts.Systems;
using _Scripts.Interfaces;
using _Scripts.States; // Para poder ver los scripts de estados

namespace _Scripts.Brains
{
    public class EnemyBrain : MonoBehaviour
    {
        [Header("Referencias de Datos")]
        [SerializeField] private IntuicionSystem data;
        
        [Header("Configuración de Movimiento")]
        [SerializeField] private float velocidadBase = 3.5f;
        [SerializeField] private Transform[] waypoints; 
        private int indexWaypointActual = 0;

        // --- LÓGICA DE ESTADOS ---
        private IEstado _estadoActual; // El "canal" de radio que suena ahora

        [Header("Reloj de Recuperación")]
        private float cronometroSesentaSeg = 0f;
        private int nivelMiedoActual = 1;

        private void Start()
        {
            if (data != null)
            {
                data.OnSubirFase += HandleSubirFase;
                data.OnBajarFase += HandleBajarFase;
                
                // INICIALIZACIÓN: Arrancamos con el "juguete" de Rastreo
                CambiarEstado(new EstadoRastreo(this));
            }
        }

        private void Update()
        {
            if (data is null) return;

            ManejarCronometroRecuperacion();
            
            // EJECUCIÓN DEL ESTADO: Aquí es donde el estado toma el control
            _estadoActual?.Ejecutar(); 

            ManejarMovimientoPerpetuo();
        }

        // Este es el método que usa el EstadoRastreo para controlarnos
        public void ActualizarVelocidad(float nuevaVelocidad)
        {
            velocidadBase = nuevaVelocidad;
        }

        // El "Cambiador de Canales" profesional
        public void CambiarEstado(IEstado nuevoEstado)
        {
            // 1. Salimos del estado viejo (si existe)
            _estadoActual?.Salir();

            // 2. Cambiamos la pieza
            _estadoActual = nuevoEstado;

            // 3. Entramos al nuevo estado
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

        private void ManejarMovimientoPerpetuo()
        {
            if (waypoints == null || waypoints.Length == 0) return;

            Vector3 destino = data.IntuicionActual > 0.2f ? 
                             data.posicionSospechosa : 
                             waypoints[indexWaypointActual].position;

            if (Vector3.Distance(transform.position, destino) < 0.5f)
            {
                indexWaypointActual = (indexWaypointActual + 1) % waypoints.Length;
            }

            transform.position = Vector3.MoveTowards(transform.position, destino, velocidadBase * Time.deltaTime);
            transform.LookAt(new Vector3(destino.x, transform.position.y, destino.z));
        }

        private void HandleSubirFase()
        {
            nivelMiedoActual++;
            // Aquí más adelante crearemos: CambiarEstado(new EstadoSigilo(this));
            Debug.Log($"Subiendo a fase {nivelMiedoActual}");
        }

        private void HandleBajarFase()
        {
            nivelMiedoActual = Mathf.Max(1, nivelMiedoActual - 1);
            if(nivelMiedoActual == 1) CambiarEstado(new EstadoRastreo(this));
        }

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
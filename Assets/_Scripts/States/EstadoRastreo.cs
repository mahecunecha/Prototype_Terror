using UnityEngine;
using _Scripts.Interfaces;
using _Scripts.Brains;

namespace _Scripts.States
{
    /* * ESTADO: RASTREO (FASE 1)
     * El enemigo patrulla tranquilamente entre waypoints usando NavMeshAgent.
     * Es el estado más "ciego" y lento.
     */
    public class EstadoRastreo : IEstado
    {
        private readonly EnemyBrain _brain;
        private readonly float _velocidadRastreo = 2.5f;
        
        private int _indexWaypointActual = 0;
        private Vector3 _ultimoDestinoAsignado;
        private bool _iniciando = true;

        // El constructor nos permite recibir la referencia del cerebro
        public EstadoRastreo(EnemyBrain brain)
        {
            _brain = brain;
        }

        public void Entrar()
        {
            Debug.Log("<color=green>Enemigo entrando en fase de RASTREO.</color>");
            _brain.ActualizarVelocidad(_velocidadRastreo);
            _ultimoDestinoAsignado = Vector3.zero;
            _iniciando = true;
        }

        public void Ejecutar()
        {
            // 1. Aseguramos que la velocidad actual del agente sea la de rastreo
            _brain.ActualizarVelocidad(_velocidadRastreo);

            Vector3 destinoObjetivo;
            bool esSospecha = _brain.Data.IntuicionActual > 0.2f;

            if (esSospecha)
            {
                // Si la intuición es alta, vamos a investigar la posición sospechosa
                destinoObjetivo = _brain.Data.posicionSospechosa;
            }
            else
            {
                // Si no, volvemos a la patrulla normal
                if (_brain.Waypoints == null || _brain.Waypoints.Length == 0) return;
                destinoObjetivo = _brain.Waypoints[_indexWaypointActual].position;
            }

            // 2. OPTIMIZACIÓN CRÍTICA: Solo llamamos a SetDestination si el destino ha cambiado.
            // Si llamamos a SetDestination en cada frame (Update), el agente recalcula la ruta infinitamente y se queda quieto.
            if (_iniciando || Vector3.Distance(_ultimoDestinoAsignado, destinoObjetivo) > 0.1f)
            {
                _brain.MoverHacia(destinoObjetivo);
                _ultimoDestinoAsignado = destinoObjetivo;
                _iniciando = false;
            }

            // 3. CAMBIO DE WAYPOINT: Si estamos patrullando y llegamos físicamente cerca del punto, avanzamos
            if (!esSospecha)
            {
                float distanciaFisica = Vector3.Distance(_brain.transform.position, destinoObjetivo);
                if (distanciaFisica < 0.8f)
                {
                    _indexWaypointActual = (_indexWaypointActual + 1) % _brain.Waypoints.Length;
                }
            }
        }

        public void Exit() // Cumple la interfaz si requiere Salir en español
        {
            Salir();
        }

        public void Salir()
        {
            Debug.Log("Saliendo de RASTREO: El enemigo ha cambiado de estado.");
        }
    }
}
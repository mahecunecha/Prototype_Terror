using UnityEngine;
using UnityEngine.AI;
using _Scripts.Interfaces;
using _Scripts.Brains;

namespace _Scripts.States
{
    public class EstadoSigilo : IEstado
    {
        private readonly EnemyBrain _brain;

        // 1. Variables de Clase y Sub-estados
        public enum SubFaseSigilo { Acercamiento, Escaneo, MicroPatrulla }
        private SubFaseSigilo _subFaseActual;

        private readonly float _velocidadSigilo = 5.0f;
        
        private float _temporizadorEscaneo = 0f;
        private Vector3[] _puntosMicroPatrulla = new Vector3[3];
        private int _indexPatrulla = 0;

        public EstadoSigilo(EnemyBrain brain)
        {
            _brain = brain;
        }

        public void Entrar()
        {
            // 2. Método Entrar()
            Debug.Log("<color=orange>Enemigo entrando en fase de SIGILO.</color>");
            _brain.ActualizarVelocidad(_velocidadSigilo);
            _subFaseActual = SubFaseSigilo.Acercamiento;
            _brain.MoverHacia(_brain.Data.posicionSospechosa);
            
            _temporizadorEscaneo = 0f;
        }

        public void Ejecutar()
        {
            // 3. Método Ejecutar() (El motor lógico)
            switch (_subFaseActual)
            {
                case SubFaseSigilo.Acercamiento:
                    float distanciaAlOrigen = Vector3.Distance(_brain.transform.position, _brain.Data.posicionSospechosa);
                    if (distanciaAlOrigen < 0.5f)
                    {
                        _subFaseActual = SubFaseSigilo.Escaneo;
                        _brain.ActualizarVelocidad(0f);
                        _brain.MoverHacia(_brain.transform.position); // Detener el movimiento actual
                    }
                    break;

                case SubFaseSigilo.Escaneo:
                    _temporizadorEscaneo += Time.deltaTime;
                    if (_temporizadorEscaneo > 2.5f)
                    {
                        GenerarPuntosDePatrulla();
                        _subFaseActual = SubFaseSigilo.MicroPatrulla;
                        _brain.ActualizarVelocidad(_velocidadSigilo);
                        _indexPatrulla = 0;
                        _brain.MoverHacia(_puntosMicroPatrulla[_indexPatrulla]);
                    }
                    break;

                case SubFaseSigilo.MicroPatrulla:
                    float distanciaAlPunto = Vector3.Distance(_brain.transform.position, _puntosMicroPatrulla[_indexPatrulla]);
                    if (distanciaAlPunto < 0.5f)
                    {
                        _indexPatrulla = (_indexPatrulla + 1) % _puntosMicroPatrulla.Length;
                        _brain.MoverHacia(_puntosMicroPatrulla[_indexPatrulla]);
                    }
                    break;
            }
        }

        private void GenerarPuntosDePatrulla()
        {
            for (int i = 0; i < 3; i++)
            {
                Vector3 direccionAleatoria = Random.insideUnitSphere * 4.0f;
                direccionAleatoria += _brain.Data.posicionSospechosa;
                
                NavMeshHit hit;
                // Intentamos buscar un punto válido en el NavMesh cerca del punto aleatorio
                if (NavMesh.SamplePosition(direccionAleatoria, out hit, 4.0f, NavMesh.AllAreas))
                {
                    _puntosMicroPatrulla[i] = hit.position;
                }
                else
                {
                    // Si falla, usamos el centro como respaldo
                    _puntosMicroPatrulla[i] = _brain.Data.posicionSospechosa;
                }
            }
        }

        public void Salir()
        {
            // 4. Método Salir()
            Debug.Log("Abandonando la búsqueda sigilosa.");
            _temporizadorEscaneo = 0f; // Reseteamos por precaución
            _indexPatrulla = 0;
        }
    }
}

using UnityEngine;
using UnityEngine.AI;
using _Scripts.Interfaces;
using _Scripts.Brains;
using _Scripts.Systems;

namespace _Scripts.States
{
    public class EstadoSigilo : IEstado
    {
        private readonly EnemyBrain _brain;

        private enum SubFaseSigilo { Intercepcion, SiguiendoRastro, Escaneo, MicroPatrulla }
        private SubFaseSigilo _subFaseActual;

        private Vector3 _destinoActual;
        private float _temporizadorEscaneo = 0f;
        private Vector3[] _puntosMicroPatrulla = new Vector3[3];
        private int _indexPatrulla = 0;

        private const float VelocidadSigilo = 5.0f;
        private const float VelocidadIntercepcion = 10.0f;

        public EstadoSigilo(EnemyBrain brain)
        {
            _brain = brain;
        }

        public void Entrar()
        {
            Debug.Log("<color=orange>Enemigo entrando en fase de SIGILO.</color>");

            if (GestorRastro.Instance.TryObtenerMigaja(out _destinoActual))
            {
                float distancia = Vector3.Distance(_destinoActual, _brain.puntoSalida.position);
                Debug.Log($"<color=yellow>[SIGILO]</color> Evaluando migaja en {_destinoActual}. Distancia a Salida: {distancia}m.");

                if (distancia < 15.0f)
                {
                    Debug.Log("<color=red>[INTERCEPCIÓN]</color> ¡Jugador cerca de la meta! Corriendo a Emboscada.");
                    _subFaseActual = SubFaseSigilo.Intercepcion;
                    _brain.ActualizarVelocidad(VelocidadIntercepcion);
                    _brain.MoverHacia(_brain.puntoEmboscada.position);
                }
                else
                {
                    Debug.Log("<color=green>[SABUESO]</color> Rastro lejos de la salida. Caminando a la migaja.");
                    _subFaseActual = SubFaseSigilo.SiguiendoRastro;
                    _brain.ActualizarVelocidad(VelocidadSigilo);
                    _brain.MoverHacia(_destinoActual);
                }
            }
            else
            {
                Debug.Log("<color=grey>[SIGILO]</color> No hay migajas en memoria. Entrando a Escaneo (Stop & Scan).");
                _subFaseActual = SubFaseSigilo.Escaneo;
                _brain.ActualizarVelocidad(0f);
                _temporizadorEscaneo = 0f;
            }
        }

        public void Ejecutar()
        {
            switch (_subFaseActual)
            {
                case SubFaseSigilo.Intercepcion:
                    if (Vector3.Distance(_brain.transform.position, _brain.puntoEmboscada.position) < 0.5f)
                    {
                        _brain.ActualizarVelocidad(0f);
                    }
                    break;

                case SubFaseSigilo.SiguiendoRastro:
                    if (Vector3.Distance(_brain.transform.position, _destinoActual) < 0.5f)
                    {
                        if (GestorRastro.Instance.TryObtenerMigaja(out _destinoActual))
                        {
                            _brain.MoverHacia(_destinoActual);
                        }
                        else
                        {
                            _subFaseActual = SubFaseSigilo.Escaneo;
                            _temporizadorEscaneo = 0f;
                            _brain.ActualizarVelocidad(0f);
                        }
                    }
                    break;

                case SubFaseSigilo.Escaneo:
                    _temporizadorEscaneo += Time.deltaTime;
                    if (_temporizadorEscaneo > 2.5f)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Vector3 direccionAleatoria = Random.insideUnitSphere * 4.0f;
                            direccionAleatoria += _brain.transform.position;
                            
                            NavMeshHit hit;
                            if (NavMesh.SamplePosition(direccionAleatoria, out hit, 4.0f, NavMesh.AllAreas))
                            {
                                _puntosMicroPatrulla[i] = hit.position;
                            }
                            else
                            {
                                _puntosMicroPatrulla[i] = _brain.transform.position;
                            }
                        }

                        _subFaseActual = SubFaseSigilo.MicroPatrulla;
                        _brain.ActualizarVelocidad(VelocidadSigilo);
                        _indexPatrulla = 0;
                        _brain.MoverHacia(_puntosMicroPatrulla[_indexPatrulla]);
                    }
                    break;

                case SubFaseSigilo.MicroPatrulla:
                    if (Vector3.Distance(_brain.transform.position, _puntosMicroPatrulla[_indexPatrulla]) < 0.5f)
                    {
                        _indexPatrulla = (_indexPatrulla + 1) % 3;
                        _brain.MoverHacia(_puntosMicroPatrulla[_indexPatrulla]);
                    }
                    break;
            }
        }

        public void Salir()
        {
            Debug.Log("Abortando el Sigilo. Limpiando variables internas del rastreo.");
            _temporizadorEscaneo = 0f;
            _indexPatrulla = 0;
            _destinoActual = Vector3.zero;
        }
    }
}

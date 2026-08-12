using UnityEngine;
using System.Collections.Generic;

namespace _Scripts.Systems
{
    public class GestorRastro : MonoBehaviour
    {
        public static GestorRastro Instance { get; private set; }

        [SerializeField] private Transform jugador;
        [SerializeField] private float intervaloGuardado = 3.0f;
        [SerializeField] private float distanciaMinima = 1.5f;

        private Queue<Vector3> _migajas = new Queue<Vector3>();
        private const int LimiteMigajas = 3;

        private float _temporizador = 0f;
        private Vector3 _ultimaPosicion;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
        }

        private void Start()
        {
            if (jugador != null)
            {
                _ultimaPosicion = jugador.position;
            }
        }

        private void Update()
        {
            _temporizador += Time.deltaTime;

            if (_temporizador >= intervaloGuardado && jugador != null)
            {
                float distancia = Vector3.Distance(jugador.position, _ultimaPosicion);

                if (distancia > distanciaMinima)
                {
                    _migajas.Enqueue(jugador.position);
                    Debug.Log($"<color=cyan>[RASTRO]</color> Migaja guardada en {jugador.position}. Total en cola: {_migajas.Count}");
                    _ultimaPosicion = jugador.position;
                    _temporizador = 0f;

                    if (_migajas.Count > LimiteMigajas)
                    {
                        _migajas.Dequeue();
                    }
                }
            }
        }

        public bool TryObtenerMigaja(out Vector3 migaja)
        {
            if (_migajas.Count > 0)
            {
                migaja = _migajas.Dequeue();
                return true;
            }

            migaja = Vector3.zero;
            return false;
        }
    }
}

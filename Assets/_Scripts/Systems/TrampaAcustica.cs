using UnityEngine;
using System.Collections;
using _Scripts.Enums;

namespace _Scripts.Systems
{
    [RequireComponent(typeof(AudioSource))]
    public class TrampaAcustica : MonoBehaviour
    {
        public IntuicionSystem dataIntuicion;
        [Range(0f, 1f)] public float volumenAlerta = 0.3f;
        public PerfilAcustico perfilAcustico = PerfilAcustico.GraveFisico;
        public float tiempoApagado = 4.0f;

        private AudioSource _audioSource;
        private bool _jugadorPresente = false;
        private Coroutine _rutinaApagado;

        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
            _audioSource.playOnAwake = false;
            _audioSource.loop = true;
            _audioSource.spatialBlend = 1.0f;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                _jugadorPresente = true;

                if (_rutinaApagado != null)
                {
                    StopCoroutine(_rutinaApagado);
                    _rutinaApagado = null;
                }

                if (!_audioSource.isPlaying)
                {
                    _audioSource.Play();
                }

                if (dataIntuicion != null)
                {
                    GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
                    if (enemy != null)
                    {
                        float distanciaAlMonstruo = Vector3.Distance(transform.position, enemy.transform.position);
                        dataIntuicion.ModificarIntuicion(volumenAlerta, distanciaAlMonstruo, perfilAcustico, transform.position);
                    }
                }
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                _jugadorPresente = false;
                if (_rutinaApagado != null)
                {
                    StopCoroutine(_rutinaApagado);
                }
                _rutinaApagado = StartCoroutine(RutinaApagarAudio());
            }
        }

        private IEnumerator RutinaApagarAudio()
        {
            yield return new WaitForSeconds(tiempoApagado);
            
            if (!_jugadorPresente && _audioSource.isPlaying)
            {
                _audioSource.Stop();
            }
            _rutinaApagado = null;
        }
    }
}

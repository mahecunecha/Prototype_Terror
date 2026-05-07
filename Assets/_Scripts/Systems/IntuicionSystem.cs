using UnityEngine;
using System; // Necesario para usar los "Eventos" (La Radio)

/* * ESTE ES EL CORAZÓN DE DATOS ACTUALIZADO.
 * Ahora funciona con escalas de 0.0 a 1.0 por cada fase.
 * Incluye la "Radio" (Eventos) para avisar al enemigo sin gastar CPU.
 */

namespace _Scripts.Systems
{
    [CreateAssetMenu(fileName = "NuevaIntuicion", menuName = "Sistema/Intuicion Data")]
    public class IntuicionSystem : ScriptableObject
    {
        [Header("Datos de la Fase (Escala 0.0 a 1.0)")]
        [Tooltip("El medidor de peligro de la fase actual")]
        [SerializeField] private float intuicionActual = 0f;
        public float IntuicionActual => intuicionActual;

        [Header("Memoria de Posición")]
        [Tooltip("Última posición global donde el jugador hizo ruido")]
        public Vector3 posicionSospechosa;

        // EVENTOS ("La Radio"): Avisan al enemigo cuando debe cambiar de fase
        // El EnemyBrain se "sintonizará" a estos eventos más adelante.
        public event Action OnSubirFase;
        public event Action OnBajarFase;

        /* * MÉTODO PARA SUBIR (Pulso de Percepción)
         * Se llama cuando hay luz o sonido.
         * 'distancia' ayuda a que la luz sea más débil si el jugador está lejos.
         */
        public void ModificarIntuicion(float valorASumar, float distancia = 1f)
        {
            // REGLA DE LUZ/DISTANCIA: A más distancia, el impacto es menor
            float incrementoFinal = valorASumar / Mathf.Max(distancia, 0.1f);

            // REGLA DEL 75% (Zona de Gracia): En el tramo final de la fase, sube 3 veces más lento
            if (intuicionActual >= 0.75f && incrementoFinal > 0)
            {
                intuicionActual += (incrementoFinal / 3f);
            }
            else
            {
                intuicionActual += incrementoFinal;
            }

            // REGLA DE CASCADA (SUBIDA): Si llega a 1, salta al siguiente nivel de miedo
            if (intuicionActual >= 1.0f)
            {
                intuicionActual = 0f; // Reseteamos para el nuevo reto
                OnSubirFase?.Invoke(); // "Gritamos" por la radio que subimos de fase
            }
        }

        /* * TICK DE RECUPERACIÓN (Cada 60 segundos)
         * Solo se ejecuta cuando el cronómetro del EnemyBrain llega al minuto.
         * 'miedoLevel' es el número de la fase actual (1, 2, 3...)
         */
        public void EjecutarTickDeRecuperacion(int miedoLevel)
        {
            // TU FÓRMULA: Reducción = Valor * (1/3 * 1/Miedo)
            // Esto hace que en niveles altos sea casi imposible calmar al enemigo.
            float factorEnfriamiento = (1f / 3f) * (1f / miedoLevel);
            float cantidadARestar = intuicionActual * factorEnfriamiento;

            intuicionActual -= cantidadARestar;

            // REGLA DE CASCADA (BAJADA): Si llega a 0, el enemigo se calma y baja de fase
            if (intuicionActual <= 0f)
            {
                // TU REGALO: Al bajar de fase, le damos un 0.3 de margen (Empieza en 0.7)
                // Así el jugador tiene un respiro pero el enemigo no se olvida del todo.
                intuicionActual = 0.7f; 
                OnBajarFase?.Invoke(); // "Gritamos" por la radio que el peligro bajó
            }

            // Mantenemos el número siempre entre 0 y 1 por seguridad
            intuicionActual = Mathf.Clamp01(intuicionActual);
        }
    }
}
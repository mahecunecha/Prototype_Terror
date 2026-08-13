using UnityEngine;
using System; // Necesario para usar los "Eventos" (La Radio)

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DICCIONARIO ACÚSTICO
 * Lo definimos aquí para que cualquier objeto del juego pueda
 * "etiquetar" su ruido antes de enviarlo al sistema.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
namespace _Scripts.Enums
{
    public enum PerfilAcustico
    {
        AgudoVocal, // Gritos, susurros, cristales rotos (Se ahogan rápido con la distancia)
        GraveFisico // Pasos pesados, muebles cayendo (Viajan lejos por el suelo/estructura)
    }
}

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * EL CORAZÓN DE DATOS (SISTEMA DE INTUICIÓN)
 * Actúa como un Analizador de Frecuencias Básico. Recibe paquetes 
 * de sonido, calcula su impacto real y alerta al enemigo.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
namespace _Scripts.Systems
{
    [CreateAssetMenu(fileName = "NuevaIntuicion", menuName = "Sistema/Intuicion Data")]
    public class IntuicionSystem : ScriptableObject
    {
        [Header("Atenuación Acústica (Pilar 3)")]
        [SerializeField] private float distanciaMaximaAudicion = 25f;
        [SerializeField] private AnimationCurve curvaAtenuacion = AnimationCurve.Linear(0f, 1f, 1f, 0f);

        [Header("Datos de la Fase (Escala 0.0 a 1.0)")]
        [Tooltip("El medidor de peligro de la fase actual")]
        [SerializeField] private float intuicionActual = 0f;
        public float IntuicionActual => intuicionActual;

        [Header("Memoria de Posición")]
        [Tooltip("Última posición global donde se originó un ruido válido")]
        public Vector3 posicionSospechosa;

        // EVENTOS ("La Radio"): Avisan al enemigo cuando debe cambiar de fase
        public event Action OnSubirFase;
        public event Action OnBajarFase;

        /* * *
         * MÉTODO PARA SUBIR: LA PUERTA DE ENTRADA DEL RUIDO
         * Recibe el "Paquete de Sonido" (Volumen, Distancia y Tipo) y 
         * decide cuánto asusta realmente al monstruo.
         */
        // ReSharper disable Unity.PerformanceAnalysis
        public void ModificarIntuicion(float volumen, float distancia, _Scripts.Enums.PerfilAcustico perfil, Vector3 origenRuido)
        {
            float perfilAcustico = (perfil == _Scripts.Enums.PerfilAcustico.AgudoVocal) ? 0.5f : 1.5f;

            // 1. Normalizamos la distancia (0 es al lado del enemigo, 1 es en el límite máximo de audición)
            float distanciaNormalizada = Mathf.Clamp01(distancia / distanciaMaximaAudicion);

            // 2. Evaluamos la curva para obtener el porcentaje de sonido que sobrevive al viaje
            float multiplicadorDistancia = curvaAtenuacion.Evaluate(distanciaNormalizada);

            // 3. Calculamos el incremento final usando el volumen base, la curva y el perfil
            float incrementoFinal = volumen * multiplicadorDistancia * perfilAcustico;

            // FILTRO DE RECEPCIÓN: ¿El sonido llegó con suficiente fuerza?
            if (incrementoFinal > 0.05f)
            {
                // El monstruo lo escuchó. Guardamos el origen del ruido.
                posicionSospechosa = origenRuido;

                // 2. REGLA DEL 75% (Zona de Gracia)
                // Si el monstruo ya está muy alterado (>0.75), los ruidos le afectan 3 veces menos.
                // Así le damos al jugador una micro-oportunidad de escapar antes de pasar a Persecución.
                if (intuicionActual >= 0.75f)
                {
                    intuicionActual += (incrementoFinal / 3f);
                }
                else
                {
                    intuicionActual += incrementoFinal;
                }
            }
            else
            {
                // El sonido se disipó antes de llegar. No hacemos nada.
                return;
            }

            // 3. REGLA DE CASCADA (SUBIDA)
            // Si el vaso se derrama, gritamos por la radio para que el EnemyBrain suba de fase.
            if (!(intuicionActual >= 1.0f)) return;
            intuicionActual = 0f; // Vaciamos el vaso para el nuevo nivel
            OnSubirFase?.Invoke(); // El '?' asegura que no haya error si nadie escucha
        }

        /* * *
         * TICK DE RECUPERACIÓN (Llamado por el EnemyBrain cada 60s)
         * Reduce el miedo con el tiempo. Es más difícil calmarlo en niveles altos.
         */
        public void EjecutarTickDeRecuperacion(int miedoLevel)
        {
            // FÓRMULA: Reducción = Intuición Actual * (1/3 * 1/Miedo)
            float factorEnfriamiento = (1f / 3f) * (1f / miedoLevel);
            float cantidadARestar = intuicionActual * factorEnfriamiento;

            intuicionActual -= cantidadARestar;

            // REGLA DE CASCADA (BAJADA)
            if (intuicionActual <= 0f)
            {
                // REGALO AL JUGADOR: Si el monstruo se calma y baja de fase, 
                // la nueva fase empieza en 0.7 (70%) en lugar de 1.0. No se olvida de ti del todo.
                intuicionActual = 0.7f; 
                OnBajarFase?.Invoke(); 
            }

            // Mantenemos el número entre 0.0 y 1.0 por seguridad del motor
            intuicionActual = Mathf.Clamp01(intuicionActual);
        }
    }
}
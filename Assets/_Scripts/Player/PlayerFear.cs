// -----------------------------------------------------------------------------
//  PlayerFear.cs
//  Se suscribe a la "radio" del IntuicionSystem y ajusta el movimiento del
//  jugador basándose en los niveles de miedo del enemigo.
//  Este script DEBE estar adjunto al mismo GameObject que tiene el PlayerController 
//  (por ejemplo, la cápsula del jugador).
// -----------------------------------------------------------------------------
using UnityEngine;

namespace _Scripts.Player
{
    // Garantiza de forma segura que el GameObject tenga un PlayerController.
    // Si no existe, Unity lo añadirá automáticamente para evitar errores de referencia nula en tiempo de ejecución.
    [RequireComponent(typeof(PlayerController))]
    public class PlayerFear : MonoBehaviour
    {
        [Header("Intuicion System (Data Asset)")]
        [Tooltip("Asigna aquí el ScriptableObject de IntuicionSystem que utiliza el EnemyBrain.")]
        [SerializeField] private _Scripts.Systems.IntuicionSystem intuicionSystem;

        // Referencia interna al controlador de movimiento del jugador.
        private PlayerController playerController;
        
        // Nivel de miedo actual del jugador. Rango: 0 (calma total) hasta 4 (terror absoluto).
        private int fearLevel = 0; 
        
        // Límite máximo del nivel de miedo. Corresponde a un factor de 0.8 (80% de penalización de velocidad).
        private const int MaxFearLevel = 4; 

        /// <summary>
        /// Awake se ejecuta al cargar la instancia del script, antes de que empiece el juego.
        /// Ideal para inicializar y capturar componentes internos de forma optimizada sin usar GameObject.Find.
        /// </summary>
        private void Awake()
        {
            // Cacheamos el componente PlayerController que está en este mismo objeto.
            playerController = GetComponent<PlayerController>();
        }

        /// <summary>
        /// Se activa automáticamente cada vez que el objeto se habilita en la escena.
        /// Aquí nos "sintonizamos" a la radio del sistema de intuición (Eventos).
        /// </summary>
        private void OnEnable()
        {
            // Verificación de seguridad por si olvidaste arrastrar el ScriptableObject en el Inspector.
            if (intuicionSystem != null)
            {
                // Nos suscribimos a los eventos. Cuando la IA suba o baje de fase,
                // este script se enterará inmediatamente de forma asíncrona.
                intuicionSystem.OnSubirFase += HandleSubirFase;
                intuicionSystem.OnBajarFase += HandleBajarFase;
            }
        }

        /// <summary>
        /// Se activa automáticamente cuando el objeto se deshabilita o se destruye.
        /// CRUCIAL: Siempre hay que desvincular los eventos para evitar fugas de memoria (Memory Leaks).
        /// </summary>
        private void OnDisable()
        {
            if (intuicionSystem != null)
            {
                // Nos desuscribimos de los eventos para limpiar las referencias en memoria.
                intuicionSystem.OnSubirFase -= HandleSubirFase;
                intuicionSystem.OnBajarFase -= HandleBajarFase;
            }
        }

        /// <summary>
        /// Método manejador que se ejecuta automáticamente cuando el sistema avisa que el enemigo subió de fase.
        /// </summary>
        private void HandleSubirFase()
        {
            // Incrementamos el miedo en 1, pero usamos Mathf.Clamp para asegurar 
            // que matemáticamente nunca supere el MaxFearLevel (4) ni baje de 0.
            fearLevel = Mathf.Clamp(fearLevel + 1, 0, MaxFearLevel);
            
            // Recalculamos y aplicamos el peso del terror al jugador.
            ApplyFearPenalty();
        }

        /// <summary>
        /// Método manejador que se ejecuta automáticamente cuando el sistema avisa que el enemigo bajó de fase (se enfrió).
        /// </summary>
        private void HandleBajarFase()
        {
            // Decrementamos el miedo en 1, manteniendo el valor protegido entre 0 y 4.
            fearLevel = Mathf.Clamp(fearLevel - 1, 0, MaxFearLevel);
            
            // Recalculamos y aplicamos el peso del terror al jugador.
            ApplyFearPenalty();
        }

        /// <summary>
        /// Traduce el nivel de miedo entero (0 a 4) en un porcentaje decimal de penalización física 
        /// y se lo inyecta al PlayerController.
        /// </summary>
        private void ApplyFearPenalty()
        {
            // Control de daños: Si por alguna razón el script se rompió o no tiene el controlador, cancela la ejecución.
            if (playerController == null) return;
            
            // EXPLICACIÓN MATEMÁTICA DEL FACTOR:
            // 1. (float)fearLevel de la línea inferior convierte el entero a float para permitir divisiones decimales exactas.
            // 2. Se divide entre MaxFearLevel (4) para obtener un porcentaje normalizado de 0.0 a 1.0.
            // 3. Se multiplica por 0.8f para escalar ese porcentaje a un rango final de 0.0 a 0.8.
            // Ejemplos de resultado según la fase:
            // - Miedo 0: (0 / 4) * 0.8 = 0.0  -> 0% de reducción (Velocidad normal).
            // - Miedo 1: (1 / 4) * 0.8 = 0.2  -> 20% de reducción.
            // - Miedo 2: (2 / 4) * 0.8 = 0.4  -> 40% de reducción.
            // - Miedo 3: (3 / 4) * 0.8 = 0.6  -> 60% de reducción.
            // - Miedo 4: (4 / 4) * 0.8 = 0.8  -> 80% de reducción (El jugador apenas puede arrastrarse del susto).
            float factor = (float)fearLevel / MaxFearLevel * 0.8f;
            
            // Le enviamos este factor limpio al PlayerController para que reste velocidad o altere el movimiento.
            playerController.AplicarPenalizacionMiedo(factor);
        }
    }
}
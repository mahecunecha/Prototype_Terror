using UnityEngine;
using _Scripts.Systems; // Para ver el IntuicionSystem
using _Scripts.Enums;   // Para ver el PerfilAcustico

namespace _Scripts.Player
{
    /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
     * CLASE: PlayerNoise (El Generador de Pulsos)
     * Se encarga de medir el tiempo entre pasos, reproducir el audio 
     * local para asustar al jugador humano, y enviar el "Paquete de Datos"
     * matemático al cerebro del enemigo.
     * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
    public class PlayerNoise : MonoBehaviour
    {
        [Header("Comunicaciones (Los Cables)")]
        [Tooltip("El 'buzón' central donde dejaremos el paquete de ruido")]
        /*Oye, en este espacio solo se pueden guardar cosas que tengan la estructura de IntuicionSystem
         dataIntuicion es solo un puntero inalambrico*/
        [SerializeField] private IntuicionSystem dataIntuicion; 
        
        [Tooltip("El cuerpo del enemigo para poder calcular a cuántos metros estamos")]
        [SerializeField] private Transform transformEnemigo;

        [Header("Configuración de Audio Físico")]
        [Tooltip("El parlante que reproducirá los .wav en los pies/boca del jugador")]
        [SerializeField] private AudioSource emisorDeSonido;
        
        [Tooltip("Audios para cuando el jugador va lento/agachado")]
        [SerializeField] private AudioClip audioSusurro; 
        
        [Tooltip("Audios para cuando el jugador camina normal")]
        [SerializeField] private AudioClip audioPasoNormal;
        
        [Tooltip("Audios para cuando el jugador corre asustado")]
        [SerializeField] private AudioClip audioGritoSusto;

        // --- EL ETIQUETADOR DE ESTADOS ---
        // Este enum local nos dice qué está haciendo el jugador AHORA MISMO.
        // Más adelante, el script de movimiento cambiará esta variable automáticamente.
        public enum EstadoMovimiento { Quieto, Agachado, Caminando, Corriendo }
        
        [Header("Estado Actual (Pruebas)")]
        [Tooltip("Cambia esto en Unity mientras juegas para probar los distintos ruidos")]
        public EstadoMovimiento estadoActual = EstadoMovimiento.Quieto;

        // El segundero que cuenta el tiempo entre un paso y otro
        private float _cronometroPulso = 0f;

        private void Start()
        {
            // Cláusulas de salvaguarda: Avisamos si olvidaste conectar algo en el Inspector
            if (!dataIntuicion) Debug.LogError("PlayerNoise: Falta conectar el IntuicionSystem.");
            if (!transformEnemigo) Debug.LogError("PlayerNoise: Falta el Transform del Enemigo.");
            if (!emisorDeSonido) Debug.LogError("PlayerNoise: Falta el AudioSource.");
        }

        private void Update()
        {
            // Si falta el buzón de datos, no hacemos nada, para, evitar que el juego explote
            if (!dataIntuicion || !transformEnemigo) return;

            // 1. EL RELOJ: Definimos qué tan rápido late el pulso según el estado
            float tiempoEntrePulsos = 0f;

            switch (estadoActual)
            {
                case EstadoMovimiento.Quieto: 
                    _cronometroPulso = 0f; // Reseteamos el reloj
                    return; // Salimos del Update, no hay ruido que hacer
                
                case EstadoMovimiento.Agachado: 
                    tiempoEntrePulsos = 1.2f; // Un pulso lento (mucho espacio entre pasos)
                    break;
                
                case EstadoMovimiento.Caminando: 
                    tiempoEntrePulsos = 0.7f; // Un pulso normal
                    break;
                
                case EstadoMovimiento.Corriendo: 
                    tiempoEntrePulsos = 0.3f; // Un pulso rapidísimo (pasos acelerados)
                    break;
            }

            // 2. EL SEGUNDERO AVANZA
            _cronometroPulso += Time.deltaTime;

            // 3. EL DISPARO
            if (_cronometroPulso >= tiempoEntrePulsos)
            {
                EmitirRuidoDelPulso();
                _cronometroPulso = 0f; // Vaciamos el reloj para empezar a contar el siguiente paso
            }
        }

        /* * *
         * MÉTODO: EmitirRuidoDelPulso
         * Se ejecuta solo en el frame exacto en el que el pie toca el suelo.
         * Prepara el paquete, reproduce el .wav y lo envía por correo.
         */
        // ReSharper disable Unity.PerformanceAnalysis
        private void EmitirRuidoDelPulso()
        {
            // A. Calculamos la distancia real en metros usando trigonometría de Unity
            float distanciaAlEnemigo = Vector3.Distance(transform.position, transformEnemigo.position);

            // B. Preparamos las variables que meteremos en el paquete
            float volumenPaquete = 0f;
            PerfilAcustico perfilPaquete = PerfilAcustico.GraveFisico; // Por defecto
            AudioClip clipFalsoParaHumano = null;

            // C. Rellenamos el paquete según el estado
            switch (estadoActual)
            {
                case EstadoMovimiento.Agachado:
                    volumenPaquete = 0.1f; // Muy bajito
                    perfilPaquete = PerfilAcustico.AgudoVocal; // Un susurro que se apaga rápido en la distancia
                    clipFalsoParaHumano = audioSusurro;
                    break;

                case EstadoMovimiento.Caminando:
                    volumenPaquete = 0.3f; // Medio
                    perfilPaquete = PerfilAcustico.GraveFisico; // Un paso que hace vibrar el suelo
                    clipFalsoParaHumano = audioPasoNormal;
                    break;

                case EstadoMovimiento.Corriendo:
                    volumenPaquete = 0.8f; // Escandaloso
                    perfilPaquete = PerfilAcustico.AgudoVocal; // Un grito/jadeo de pánico
                    clipFalsoParaHumano = audioGritoSusto;
                    break;
            }

            // D. LA MAGIA: Enviamos el paquete matemático al IntuicionSystem
            // delegando la decisión de si el monstruo lo escucha o no.
            // ¡Fíjate cómo usamos el Enum aquí como una etiqueta de envío!
            dataIntuicion.ModificarIntuicion(volumenPaquete, distanciaAlEnemigo, perfilPaquete, transform.position);

            // E. EL TEATRO: Reproducimos el archivo .wav real para asustar al jugador
            if (emisorDeSonido && clipFalsoParaHumano)
            {
                emisorDeSonido.PlayOneShot(clipFalsoParaHumano);
            }
            
            // Un log para que tú como desarrollador veas que el pulso salió bien
            Debug.Log($"<color=yellow>PULSO: {estadoActual} | Vol: {volumenPaquete} | Perfil: {perfilPaquete} | Dist: {distanciaAlEnemigo:F1}m</color>");
        }
    }
}
using _Scripts.Player;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
// LINEA NUEVA: Permite al script tener acceso directo a las herramientas de cámara de Cinemachine
using Cinemachine; 

namespace _Scripts.UI
{
    // Asegura que este script inicialice después de los componentes base del juego para evitar NullReference
    [DefaultExecutionOrder(100)] 
    public class UI_MenuManager : MonoBehaviour
    {
        // Enums: Una lista de estados lógicos excluyentes. El juego solo puede estar en UNO de estos a la vez.
        private enum MenuState
        {
            Inicio,
            Gameplay,
            Pausa
        }

        [Header("Input (Assets/Input/PlayerControls)")]
        [Tooltip("El contenedor de mapas de control (.inputactions) de nuestro proyecto")]
        [SerializeField] private InputActionAsset inputActionAsset;

        [Header("UI")]
        [Tooltip("El objeto raíz de la interfaz que contiene los botones")]
        [SerializeField] private GameObject menuPanel;
        [SerializeField] private TextMeshProUGUI tituloTexto;
        [SerializeField] private TextMeshProUGUI botonPrincipalTexto;

        [Header("Jugador")]
        [Tooltip("Referencia al script que controla el movimiento físico de nuestro personaje")]
        [SerializeField] private PlayerController playerController;

        [Header("Configuración de Cámara (Cinemachine)")]
        [Tooltip("Arrastra aquí tu Virtual Camera de Cinemachine para congelar la rotación del mouse en las pausas")]
        [SerializeField] private CinemachineInputProvider cameraProvider;

        // Cache de componentes de control para evitar búsquedas repetitivas en cada frame (Ahorro de CPU)
        private InputActionMap _gameplayMap;
        private InputActionMap _uiMap;
        private InputAction _pauseAction;
        private InputAction _unpauseAction;

        // Guarda en qué estado nos encontramos actualmente. Iniciamos por defecto en el Inicio.
        private MenuState _estado = MenuState.Inicio;

        // Constantes: Textos fijos que no van a cambiar durante la ejecución del código
        private const string TituloInicio = "Prototype Terror";
        private const string TituloPausa = "Pausa";
        private const string TextoJugar = "Jugar";
        private const string TextoReanudar = "Reanudar";

        private void Awake()
        {
            // Validación de seguridad: Si olvidaste arrastrar los controles en el inspector, el script se apaga solo
            if (inputActionAsset == null)
            {
                Debug.LogError("UI_MenuManager: Asigna el InputActionAsset PlayerControls en el Inspector.");
                enabled = false;
                return;
            }

            // 1. Buscamos y vinculamos los Action Maps definidos en tu archivo de inputs
            _gameplayMap = inputActionAsset.FindActionMap("Gameplay", true);
            _uiMap = inputActionAsset.FindActionMap("UI", true);
            
            // 2. Buscamos las acciones específicas mapeadas a la tecla P
            _pauseAction = _gameplayMap.FindAction("Pause", true);
            _unpauseAction = _uiMap.FindAction("Unpause", true);

            // 3. SUSCRIPCIÓN: Conectamos físicamente las acciones a nuestras funciones de C#
            _pauseAction.performed += OnPausePerformed;
            _unpauseAction.performed += OnUnpausePerformed;

            // Búsqueda automática: Si no arrastraste el script del jugador, lo intenta buscar en la escena por sí mismo
            if (playerController == null)
                playerController = FindObjectOfType<PlayerController>();
            
            if (cameraProvider == null)
                cameraProvider = FindObjectOfType<CinemachineInputProvider>();

            // Apagamos los dos mapas al nacer para iniciar con un estado completamente limpio
            _gameplayMap.Disable();
            _uiMap.Disable();
        }

        private void Start()
        {
            // Ejecutamos el estado inicial apenas el juego arranca físicamente
            EntrarModoInicio();
        }

        private void OnDestroy()
        {
            // BUENA PRÁCTICA: Rompemos la conexión con los eventos al destruir el objeto para evitar bugs de memoria
            if (_pauseAction != null)
                _pauseAction.performed -= OnPausePerformed;
            if (_unpauseAction != null)
                _unpauseAction.performed -= OnUnpausePerformed;
        }

        // --- MÉTODOS PÚBLICOS PARA LOS BOTONES (EVENTOS ONCLICK) ---

        public void OnClickJugarOReanudar()
        {
            // Si el jugador hace clic estando en el menú o en la pausa, el juego inicia o continúa
            if (_estado == MenuState.Inicio || _estado == MenuState.Pausa)
                EntrarModoGameplay();
        }

        public void OnClickSalir()
        {
            // Compilación condicional: Detiene el juego de forma correcta según el entorno
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Detiene el Play Mode dentro de Unity
#else
            Application.Quit(); // Cierra la aplicación ejecutable (.exe o binario de Linux)
#endif
        }

        // --- RESPUESTAS A LOS INPUTS FÍSICOS (TECLA P) ---

        private void OnPausePerformed(InputAction.CallbackContext context)
        {
            // Filtro de seguridad: Si la acción no se completó o no estamos jugando, ignora el teclazo
            if (!context.performed || _estado != MenuState.Gameplay)
                return;

            EntrarModoPausa();
        }

        private void OnUnpausePerformed(InputAction.CallbackContext context)
        {
            // Filtro de seguridad: Si la acción no se completó o no estamos pausados, ignora el teclazo
            if (!context.performed || _estado != MenuState.Pausa)
                return;

            EntrarModoGameplay();
        }

        // --- MANEJADORES DE ESTADO (MÁQUINA DE ESTADOS) ---

        private void EntrarModoInicio()
        {
            _estado = MenuState.Inicio;
            Time.timeScale = 0f; // CONGELA COMPLETAMENTE EL TIEMPO: Detiene físicas, NavMesh e IA del enemigo

            MostrarMenu(true);                          // Muestra el panel visual del menú
            ConfigurarTextos(TituloInicio, TextoJugar); // Cambia el texto a "Prototype Terror" y "Jugar"
            ConfigurarCursor(true);                     // Libera y muestra el puntero del mouse
            ActivarMapaUI();                            // Apaga controles del jugador, enciende controles de UI
            ConfigurarJugador(false);                   // Apaga el movimiento del script del jugador
            ConfigurarCamara(false);                    // Bloquea el movimiento de la cámara de Cinemachine
        }

        private void EntrarModoGameplay()
        {
            _estado = MenuState.Gameplay;
            Time.timeScale = 1f; // REANUDA EL TIEMPO: El mundo de juego vuelve a latir con normalidad

            MostrarMenu(false);        // Oculta el panel visual por completo de la pantalla
            ConfigurarCursor(false);   // Bloquea y esconde el cursor en el centro de la pantalla
            ActivarMapaGameplay();     // Apaga controles de UI, enciende controles de juego (WASD, ratón)
            ConfigurarJugador(true);   // Le devuelve el control físico al script del jugador
            ConfigurarCamara(true);    // Permite que Cinemachine vuelva a leer el ratón para girar la cabeza
        }

        private void EntrarModoPausa()
        {
            _estado = MenuState.Pausa;
            Time.timeScale = 0f; // CONGELA COMPLETAMENTE EL TIEMPO denuevo

            MostrarMenu(true);                             // Muestra la interfaz encima de la acción congelada
            ConfigurarTextos(TituloPausa, TextoReanudar);  // Cambia dinámicamente los textos a "Pausa" y "Reanudar"
            ConfigurarCursor(true);                        // Libera el mouse para poder clickear las opciones
            ActivarMapaUI();                               // Intercambio de mapas de input: UI activa
            ConfigurarJugador(false);                      // Bloquea movimientos residuales del personaje
            ConfigurarCamara(false);                       // Congela la visual de la cámara en su lugar actual
        }

        // --- SUB-FUNCIONES AUXILIARES DE CONFIGURACIÓN ---

        private void ActivarMapaUI()
        {
            _gameplayMap.Disable(); // Desactiva el mapa de juego (WASD deja de responder instantáneamente)
            _uiMap.Enable();        // Activa el mapa de UI (Permite que funcione la tecla Unpause)
        }

        private void ActivarMapaGameplay()
        {
            _uiMap.Disable();        // Desactiva el mapa de UI
            _gameplayMap.Enable();   // Activa el mapa de juego activo
        }

        private void MostrarMenu(bool visible)
        {
            if (menuPanel != null)
                menuPanel.SetActive(visible); // Enciende o apaga el GameObject completo en la jerarquía
        }

        private void ConfigurarTextos(string titulo, string botonPrincipal)
        {
            if (tituloTexto != null)
                tituloTexto.text = titulo;
            if (botonPrincipalTexto != null)
                botonPrincipalTexto.text = botonPrincipal;
        }

        private static void ConfigurarCursor(bool menuActivo)
        {
            // Si el menú está activo, el cursor se libera. Si no, se bloquea al centro de la pantalla.
            Cursor.lockState = menuActivo ? CursorLockMode.None : CursorLockMode.Locked;
            Cursor.visible = menuActivo; // Alterna la visibilidad del puntero gráfico
        }

        private void ConfigurarJugador(bool activo)
        {
            if (playerController != null)
                playerController.enabled = activo; // Prende o apaga el componente del jugador para frenar movimientos fantasmas
        }

        private void ConfigurarCamara(bool activo)
        {
            if (cameraProvider != null)
                cameraProvider.enabled = activo; // Habilita o deshabilita que Cinemachine escuche al mouse
        }
    }
}

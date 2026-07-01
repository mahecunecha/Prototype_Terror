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
            Gameplay,
            MenuAbierto
        }

        [Header("Input (Assets/Input/PlayerControls)")]
        [Tooltip("El contenedor de mapas de control (.inputactions) de nuestro proyecto")]
        [SerializeField]
        private InputActionAsset inputActionAsset;

        [Header("UI")] [Tooltip("El objeto raíz de la interfaz que contiene los botones")] [SerializeField]
        private GameObject menuPanel;

        [SerializeField] private TextMeshProUGUI tituloTexto;
        [SerializeField] private TextMeshProUGUI botonPrincipalTexto;

        [Header("Jugador")]
        [Tooltip("Referencia al script que controla el movimiento físico de nuestro personaje")]
        [SerializeField]
        private PlayerController playerController;

        [Header("Configuración de Cámara (Cinemachine)")]
        [Tooltip("Arrastra aquí tu Virtual Camera de Cinemachine para congelar la rotación del mouse en las pausas")]
        [SerializeField]
        private CinemachineInputProvider cameraProvider;

        [SerializeField] private CinemachineVirtualCamera virtualCamera; // <-- Cambiamos el tipo aquí
        private CinemachinePOV cameraPov; // Ahora es privado, no se arrastra

        // Cache de componentes de control para evitar búsquedas repetitivas en cada frame (Ahorro de CPU)
        private InputActionMap _gameplayMap;
        private InputActionMap _uiMap;
        private InputAction _pauseAction;
        private InputAction _unpauseAction;

        // Estado actual del menú diegético (P alterna Gameplay ↔ MenuAbierto).
        private MenuState _estado = MenuState.Gameplay;

        // Constantes: Textos fijos que no van a cambiar durante la ejecución del código
        private const string TituloMenu = "Soporte";
        private const string TextoCerrar = "Cerrar";

        private void Awake()
        {
            // Validación de seguridad: Si olvidaste arrastrar los controles en el inspector, el script se apaga solo
            if (inputActionAsset == null)
            {
                Debug.LogError("UI_MenuManager: Asigna el InputActionAsset PlayerControls en el Inspector.");
                enabled = false;
                return;
            }

            if (virtualCamera != null)
            {
                // Esto extrae el módulo interno POV de la cámara virtual
                cameraPov = virtualCamera.GetCinemachineComponent<CinemachinePOV>();

                if (cameraProvider == null)
                    cameraProvider = virtualCamera.GetComponent<CinemachineInputProvider>();
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

            if (cameraPov == null && cameraProvider != null)
                cameraPov = cameraProvider.GetComponentInChildren<CinemachinePOV>();
        }

        private void Start()
        {
            EntrarModoGameplay();
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
            if (_estado == MenuState.MenuAbierto)
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

            EntrarModoMenuAbierto();
        }

        private void OnUnpausePerformed(InputAction.CallbackContext context)
        {
            if (!context.performed || _estado != MenuState.MenuAbierto)
                return;

            EntrarModoGameplay();
        }

        // --- MANEJADORES DE ESTADO (MÁQUINA DE ESTADOS) ---

        private void EntrarModoGameplay()
        {
            _estado = MenuState.Gameplay;

            MostrarMenu(false);
            ConfigurarCursor(false);
            ActivarMapaGameplay();
            ConfigurarJugador(true);
            ConfigurarCamara(true);
        }

        private void EntrarModoMenuAbierto()
        {
            _estado = MenuState.MenuAbierto;

            MostrarMenu(true);
            ConfigurarTextos(TituloMenu, TextoCerrar);
            ConfigurarCursor(true);
            ActivarMapaUI();
            ConfigurarJugador(false);
            ConfigurarCamara(false);
        }

        // --- SUB-FUNCIONES AUXILIARES DE CONFIGURACIÓN ---

        private void ActivarMapaUI()
        {
            _gameplayMap.Disable(); // Desactiva el mapa de juego (WASD deja de responder instantáneamente)
            _uiMap.Enable(); // Activa el mapa de UI (Permite que funcione la tecla Unpause)
        }

        private void ActivarMapaGameplay()
        {
            _uiMap.Disable(); // Desactiva el mapa de UI
            _gameplayMap.Enable(); // Activa el mapa de juego activo
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
                playerController.SetControlBlocked(!activo);
        }

        private void ConfigurarCamara(bool activo)
        {
            if (cameraProvider != null)
                cameraProvider.enabled = activo;

            if (cameraPov == null)
                return;

            var horizontal = cameraPov.m_HorizontalAxis;
            horizontal.m_InputAxisValue = 0f;
            cameraPov.m_HorizontalAxis = horizontal;

            var vertical = cameraPov.m_VerticalAxis;
            vertical.m_InputAxisValue = 0f;
            cameraPov.m_VerticalAxis = vertical;

            if (activo && Mouse.current != null)
                InputSystem.ResetDevice(Mouse.current);
        }
    }
}
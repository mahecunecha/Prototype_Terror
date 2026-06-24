using UnityEngine;
using UnityEngine.InputSystem;

namespace _Scripts.Player
{
    /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
     * CLASE: PlayerController (El Motor Cinemático Oficial)
     * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
    public class PlayerController : MonoBehaviour
    {
        [Header("Conexiones Especializadas")] [SerializeField]
        private PlayerNoise scriptRuido;

        [Header("Configuración de Velocidades (Calibración)")] [SerializeField]
        private float velocidadAgachado = 1.5f;

        [SerializeField] private float velocidadCaminando = 3.5f;
        [SerializeField] private float velocidadCorriendo = 6.0f;

        [Tooltip("Qué tan rápido gira el personaje hacia la dirección de movimiento")] [SerializeField]
        private float velocidadRotacion = 10f; // velocidad de giro

        // Nuevas variables para suavizado
        [Header("Suavizado de Movimiento")] [SerializeField]
        private float smoothTime = 0.1f; // tiempo de suavizado de velocidad

        [SerializeField] private float rotationSmoothTime = 0.1f; // tiempo de suavizado de rotación
        private Vector3 _velocitySmooth; // velocidad suavizada
        private Vector3 _velocitySmoothDerivative; // Derivative for Vector3.SmoothDamp // velocidad actual para SmoothDamp
        private float _currentRotationSmoothVelocity;

        [Header("Configuración del Nuevo Input System")] [SerializeField]
        private InputActionReference moveAction;

        [SerializeField] private InputActionReference sprintAction;
        [SerializeField] private InputActionReference crouchAction;

        private float _velocidadActual;
        private Vector3 _direccionMovimiento;

        private void OnEnable()
        {
            if (moveAction != null) moveAction.action.Enable();
            if (sprintAction != null) sprintAction.action.Enable();
            if (crouchAction != null) crouchAction.action.Enable();
        }

        private void OnDisable()
        {
            if (moveAction != null) moveAction.action.Disable();
            if (sprintAction != null) sprintAction.action.Disable();
            if (crouchAction != null) crouchAction.action.Disable();
        }

        private void Start()
        {
            if (!scriptRuido) Debug.LogError("PlayerController: ¡Falta conectar el componente PlayerNoise!");

            // Bloquear y ocultar el cursor para primera persona
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        private void Update()
        {
            if (!scriptRuido) return;

            // Lectura limpia del Vector2 de movimiento
            Vector2 inputVector = moveAction.action.ReadValue<Vector2>();

            // === MOVIMIENTO RELATIVO A LA CÁMARA (Primera Persona) ===
            // Obtenemos la dirección "adelante" y "derecha" de la cámara, proyectadas al plano XZ
            Transform cam = Camera.main != null ? Camera.main.transform : transform;
            Vector3 camForward = cam.forward;
            Vector3 camRight = cam.right;
            camForward.y = 0f;
            camRight.y = 0f;
            camForward.Normalize();
            camRight.Normalize();

            // La dirección de movimiento es relativa a donde mira la cámara
            _direccionMovimiento = (camForward * inputVector.y + camRight * inputVector.x).normalized;

            // Máquina de estados de velocidad rápida
            if (_direccionMovimiento.sqrMagnitude == 0f)
            {
                _velocidadActual = 0f;
                scriptRuido.estadoActual = PlayerNoise.EstadoMovimiento.Quieto;
            }
            else if (sprintAction.action.IsPressed())
            {
                _velocidadActual = velocidadCorriendo;
                scriptRuido.estadoActual = PlayerNoise.EstadoMovimiento.Corriendo;
            }
            else if (crouchAction.action.IsPressed())
            {
                _velocidadActual = velocidadAgachado;
                scriptRuido.estadoActual = PlayerNoise.EstadoMovimiento.Agachado;
            }
            else
            {
                _velocidadActual = velocidadCaminando;
                scriptRuido.estadoActual = PlayerNoise.EstadoMovimiento.Caminando;
            }

            // === ROTACIÓN: Sincronizar Y del Player con la cámara ===
            // En primera persona, el cuerpo del jugador rota en Y para coincidir con la dirección
            // horizontal de la cámara. Cinemachine POV maneja el pitch (eje vertical).
            float cameraYaw = cam.eulerAngles.y;
            float smoothedYaw = Mathf.SmoothDampAngle(transform.eulerAngles.y, cameraYaw,
                ref _currentRotationSmoothVelocity, rotationSmoothTime);
            transform.rotation = Quaternion.Euler(0f, smoothedYaw, 0f);

            // === MOVIMIENTO con CharacterController ===
            // Calculamos la velocidad deseada
            Vector3 desiredVelocity = _direccionMovimiento * _velocidadActual;
            // Suavizamos la velocidad
            _velocitySmooth = Vector3.SmoothDamp(_velocitySmooth, desiredVelocity, ref _velocitySmoothDerivative, smoothTime);

            // Aplicamos gravedad
            if (TryGetComponent<CharacterController>(out var controller))
            {
                Vector3 moveVector = _velocitySmooth * Time.deltaTime;
                // Gravedad simple para mantener al jugador en el suelo
                if (!controller.isGrounded)
                    moveVector.y -= 9.81f * Time.deltaTime;

                controller.Move(moveVector);
            }
            else
            {
                // Fallback: usar Translate si no hay CharacterController
                transform.Translate(_direccionMovimiento * (_velocidadActual * Time.deltaTime), Space.World);
            }
        }

        /// <summary>
        /// Aplica una penalización al movimiento del jugador basada en el factor de miedo (0-1).
        /// Un factor mayor reduce la velocidad y aumenta los tiempos de suavizado.
        /// </summary>
        /// <param name="factor">Valor entre 0 (sin penalización) y 1 (penalización máxima).</param>
        public void AplicarPenalizacionMiedo(float factor)
        {
            // Reducción de velocidad máxima
            float velocidadBase = velocidadCaminando; // podrías elegir otra referencia
            _velocidadActual = Mathf.Lerp(velocidadBase, velocidadBase * 0.2f, factor);
            // Incrementamos los tiempos de suavizado para sensación de pesadez
            smoothTime = Mathf.Lerp(smoothTime, smoothTime + 0.3f, factor);
            rotationSmoothTime = Mathf.Lerp(rotationSmoothTime, rotationSmoothTime + 0.3f, factor);
        }
    }
}
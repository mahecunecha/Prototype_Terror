using UnityEngine;
using UnityEngine.InputSystem;

namespace _Scripts.Player
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Conexiones Especializadas")] 
        [SerializeField] private PlayerNoise scriptRuido;
        
        [Tooltip("¡Arrastra aquí el objeto @Head que está dentro de tu Jugador!")]
        [SerializeField] private Transform headTransform; // <--- NUEVA CONEXIÓN VITAL

        [Header("Configuración de Velocidades (Calibración)")] 
        [SerializeField] private float velocidadAgachado = 1.5f;
        [SerializeField] private float velocidadCaminando = 3.5f;
        [SerializeField] private float velocidadCorriendo = 6.0f;
        [SerializeField] private float velocidadRotacion = 10f; 

        [Header("Suavizado de Movimiento")] 
        [SerializeField] private float smoothTime = 0.1f; 
        [SerializeField] private float rotationSmoothTime = 0.02f; 
        
        private Vector3 _velocitySmooth; 
        private Vector3 _velocitySmoothDerivative; 
        private float _currentRotationSmoothVelocity;
        
        private float _yaw;
        private float _pitch;

        [Header("Configuración del Nuevo Input System")] 
        [SerializeField] private InputActionReference moveAction;
        [SerializeField] private InputActionReference sprintAction;
        [SerializeField] private InputActionReference crouchAction;
        [SerializeField] private InputActionReference lookActionDebug; 

        private bool _controlBloqueado;
        private float _velocidadActual;
        private Vector3 _direccionMovimiento;

        private void OnEnable()
        {
            if (moveAction != null) moveAction.action.Enable();
            if (sprintAction != null) sprintAction.action.Enable();
            if (crouchAction != null) crouchAction.action.Enable();
            if (lookActionDebug != null) lookActionDebug.action.Enable();
        }

        private void OnDisable()
        {
            if (moveAction != null) moveAction.action.Disable();
            if (sprintAction != null) sprintAction.action.Disable();
            if (crouchAction != null) crouchAction.action.Disable();
            if (lookActionDebug != null) lookActionDebug.action.Disable();
        }

        public void SetControlBlocked(bool blocked)
        {
            if (_controlBloqueado == blocked) return;

            _controlBloqueado = blocked;
            if (blocked)
            {
                _velocitySmooth = Vector3.zero;
                _velocitySmoothDerivative = Vector3.zero;
                _direccionMovimiento = Vector3.zero;
                _velocidadActual = 0f;
                _currentRotationSmoothVelocity = 0f;
            }
        }

        private void Start()
        {
            if (!scriptRuido) Debug.LogError("PlayerController: ¡Falta conectar el componente PlayerNoise!");
            if (!headTransform) Debug.LogError("PlayerController: ¡Falta conectar el Transform del Head!");
            
            _yaw = transform.eulerAngles.y;
            if (headTransform != null)
            {
                _pitch = headTransform.eulerAngles.x;
                if (_pitch > 180f) _pitch -= 360f;
            }
            
            // Ocultar y bloquear el cursor para apuntar correctamente
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        private void Update()
        {
            if (!scriptRuido || _controlBloqueado) return;

            // Leemos el input del mouse
            Vector2 mouseInput = lookActionDebug != null ? lookActionDebug.action.ReadValue<Vector2>() : Vector2.zero;

            // === ROTACIÓN: Cálculo Incremental ===
            _yaw += mouseInput.x * velocidadRotacion * Time.deltaTime;
            _pitch -= mouseInput.y * velocidadRotacion * Time.deltaTime;
            
            // Limitamos la vista para que no te rompas el cuello (Gimbal Lock seguro)
            _pitch = Mathf.Clamp(_pitch, -89f, 89f);

            // 1. ROTACIÓN DEL CUERPO (Suavizada): Solo rota en Y
            float smoothedYaw = Mathf.SmoothDampAngle(transform.eulerAngles.y, _yaw, ref _currentRotationSmoothVelocity, rotationSmoothTime);
            transform.rotation = Quaternion.Euler(0f, smoothedYaw, 0f);
            
            // 2. ROTACIÓN DE LA CABEZA/CÁMARA (Instantánea): Rota en X e Y
            // En vez de pelear con Cinemachine, movemos el objeto que Cinemachine está siguiendo.
            if (headTransform != null)
            {
                headTransform.rotation = Quaternion.Euler(_pitch, _yaw, 0f);
            }

            // === MOVIMIENTO RELATIVO A LA CABEZA ===
            // Ahora caminamos hacia donde apunta el Head, proyectado en el suelo
            Vector3 forward = headTransform.forward;
            Vector3 right = headTransform.right;
            forward.y = 0f;
            right.y = 0f;
            forward.Normalize();
            right.Normalize();

            Vector2 inputVector = moveAction.action.ReadValue<Vector2>();
            _direccionMovimiento = (forward * inputVector.y + right * inputVector.x).normalized;

            // Máquina de estados de velocidad rápida
            if (_direccionMovimiento.sqrMagnitude == 0f)
            {
                _velocidadActual = 0f;
                scriptRuido.estadoActual = PlayerNoise.EstadoMovimiento.Quieto;
            }
            else if (sprintAction != null && sprintAction.action.IsPressed())
            {
                _velocidadActual = velocidadCorriendo;
                scriptRuido.estadoActual = PlayerNoise.EstadoMovimiento.Corriendo;
            }
            else if (crouchAction != null && crouchAction.action.IsPressed())
            {
                _velocidadActual = velocidadAgachado;
                scriptRuido.estadoActual = PlayerNoise.EstadoMovimiento.Agachado;
            }
            else
            {
                _velocidadActual = velocidadCaminando;
                scriptRuido.estadoActual = PlayerNoise.EstadoMovimiento.Caminando;
            }

            // === MOVIMIENTO FÍSICO ===
            Vector3 desiredVelocity = _direccionMovimiento * _velocidadActual;
            _velocitySmooth = Vector3.SmoothDamp(_velocitySmooth, desiredVelocity, ref _velocitySmoothDerivative, smoothTime);

            if (TryGetComponent<CharacterController>(out var controller))
            {
                Vector3 moveVector = _velocitySmooth * Time.deltaTime;
                if (!controller.isGrounded) moveVector.y -= 9.81f * Time.deltaTime;
                controller.Move(moveVector);
            }
            else
            {
                transform.Translate(_direccionMovimiento * (_velocidadActual * Time.deltaTime), Space.World);
            }
        }

        public void AplicarPenalizacionMiedo(float factor)
        {
            float velocidadBase = velocidadCaminando; 
            _velocidadActual = Mathf.Lerp(velocidadBase, velocidadBase * 0.2f, factor);
            smoothTime = Mathf.Lerp(smoothTime, smoothTime + 0.3f, factor);
            rotationSmoothTime = Mathf.Lerp(rotationSmoothTime, rotationSmoothTime + 0.3f, factor);
        }
    }
}
using UnityEngine;
using UnityEngine.InputSystem; 

namespace _Scripts.Player
{
    /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
     * CLASE: PlayerController (El Motor Cinemático Oficial)
     * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
    public class PlayerController : MonoBehaviour
    {
        [Header("Conexiones Especializadas")]
        [SerializeField] private PlayerNoise scriptRuido;

        [Header("Configuración de Velocidades (Calibración)")]
        [SerializeField] private float velocidadAgachado = 1.5f;
        [SerializeField] private float velocidadCaminando = 3.5f;
        [SerializeField] private float velocidadCorriendo = 6.0f;
        [Tooltip("Qué tan rápido gira el personaje hacia la dirección de movimiento")]
        [SerializeField] private float velocidadRotacion = 10f; // <--- AÑADIDO: Velocidad de giro

        [Header("Configuración del Nuevo Input System")]
        [SerializeField] private InputActionReference moveAction;   
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
        }

        private void Update()
        {
            if (!scriptRuido) return;

            // Lectura limpia del Vector2 de movimiento
            Vector2 inputVector = moveAction.action.ReadValue<Vector2>();
            _direccionMovimiento = new Vector3(inputVector.x, 0f, inputVector.y).normalized;

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

            // --- NUEVO: ROTACIÓN FLUIDA ---
            // Solo rotamos si el jugador está presionando alguna tecla (si el vector es mayor a 0)
            if (_direccionMovimiento.sqrMagnitude > 0f)
            {
                // Calculamos hacia dónde debería mirar la cápsula (hacia donde camina)
                Quaternion rotacionObjetivo = Quaternion.LookRotation(_direccionMovimiento);
                
                // Giramos el cuerpo suavemente hacia ese objetivo usando Slerp (Interpolación esférica)
                transform.rotation = Quaternion.Slerp(transform.rotation, rotacionObjetivo, Time.deltaTime * velocidadRotacion);
            }

            // Traslación física cinemática
            transform.Translate(_direccionMovimiento * (_velocidadActual * Time.deltaTime), Space.World);
        }
    }
}
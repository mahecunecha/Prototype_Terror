using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

namespace _Scripts.UI
{
    [DefaultExecutionOrder(100)]
    public class MenuInicioController : MonoBehaviour
    {
        [SerializeField] 
        private string escenaGameplay = "Catacumbas";

        private Button botonJugar;

        private void OnEnable()
        {
            var root = GetComponent<UIDocument>().rootVisualElement;
            if (root != null)
            {
                botonJugar = root.Q<Button>("btnJugar");
                if (botonJugar != null) 
                {
                    botonJugar.clicked += () => UnityEngine.SceneManagement.SceneManager.LoadScene("Catacumbas");
                }
                else
                {
                    Debug.LogWarning("No se encontró el elemento 'btnJugar' de tipo Button.");
                }
            }
        }

        private void OnDisable()
        {
            // Nota: Al usar una expresión lambda anónima, no se puede desregistrar directamente con '-='.
            // Sin embargo, este es el formato exacto solicitado. 
        }
    }
}

using UnityEngine;
using UnityEngine.UI;
using _Scripts.Systems;

namespace _Scripts.UI
{
    public class UI_BarraMiedo : MonoBehaviour
    {
        [Header("Intuicion System (Data Asset)")]
        [Tooltip("Asigna aquí el ScriptableObject de IntuicionSystem")]
        [SerializeField] private IntuicionSystem intuicionSystem;

        [Header("UI Elementos")]
        [SerializeField] private Image[] diamantesUI;

        // El nivel base de miedo en el EnemyBrain es 1.
        private int nivelMiedo = 1;

        private void OnEnable()
        {
            if (intuicionSystem != null)
            {
                intuicionSystem.OnSubirFase += HandleSubirFase;
                intuicionSystem.OnBajarFase += HandleBajarFase;
            }
            ActualizarUI();
        }

        private void OnDisable()
        {
            if (intuicionSystem != null)
            {
                intuicionSystem.OnSubirFase -= HandleSubirFase;
                intuicionSystem.OnBajarFase -= HandleBajarFase;
            }
        }

        private void HandleSubirFase()
        {
            nivelMiedo = Mathf.Clamp(nivelMiedo + 1, 1, 4);
            ActualizarUI();
        }

        private void HandleBajarFase()
        {
            nivelMiedo = Mathf.Clamp(nivelMiedo - 1, 1, 4);
            ActualizarUI();
        }

        private void ActualizarUI()
        {
            if (diamantesUI == null) return;

            for (int i = 0; i < diamantesUI.Length; i++)
            {
                if (diamantesUI[i] != null)
                {
                    // Nivel 1 = 1 diamante, Nivel 2 = 2 diamantes, etc.
                    diamantesUI[i].enabled = (i < nivelMiedo);
                }
            }
        }
    }
}

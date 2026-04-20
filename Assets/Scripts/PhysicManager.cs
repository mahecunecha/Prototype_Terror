using UnityEngine;
using UnityEngine.Serialization;

public class PhysicManager : MonoBehaviour
{
    [FormerlySerializedAs("_actual")] [SerializeField]
    private Vector3 actual;

    [FormerlySerializedAs("_anterior")] [SerializeField]
    private Vector3 anterior;

    [FormerlySerializedAs("_aceleracion")] [SerializeField]
    private Vector3 aceleracion;

    private void FixedUpdate()
    {
        // Calculamos el desplazamiento basado en el pasado
        Vector3 desplazamiento = actual - anterior;

        // Guardamos la posición actual como la "vieja" para el siguiente frame
        anterior = actual;

        // Nueva posición = Actual + Desplazamiento + (Aceleración * tiempo al cuadrado)
        actual += desplazamiento + aceleracion * (Time.fixedDeltaTime * Time.fixedDeltaTime);

        // Aplicamos al objeto de Unity
        transform.position = actual;
    }
}
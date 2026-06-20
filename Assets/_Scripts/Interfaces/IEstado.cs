/* * ESTE SCRIPT ES EL "CONTRATO" DE LOS ESTADOS.
 * No es una clase, es una Interface.
 * Obliga a cualquier estado (Alerta, Persecución, etc.) a tener
 * estos tres momentos clave para que el cerebro del enemigo o jugador
 * sepa cómo activarlos.
 */

namespace _Scripts.Interfaces
{
    public interface IEstado
    {
        // Se ejecuta una sola vez al entrar al estado.
        // Ideal para: Activar animaciones, sonidos de inicio o cambiar la niebla.
        void Entrar();

        // Se ejecuta constantemente mientras el estado esté activo.
        // Ideal para: Calcular el movimiento o revisar si el enemigo nos ve.
        void Ejecutar();

        // Se ejecuta una sola vez al salir del estado.
        // Ideal para: Apagar sonidos, limpiar efectos visuales o resetear variables.
        void Salir();
    }
}
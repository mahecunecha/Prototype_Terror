

/* * ESTE SCRIPT ES EL "DICCIONARIO" DEL JUEGO.
 * Aquí definimos los nombres oficiales de los estados para que
 * el código no tenga errores de ortografía al comunicarse.
 */

namespace _Scripts.Enums
{
    // Las fases por las que pasará el Jugador según su miedo
    public enum FasePlayer
    {
        Alerta,      // El estado normal, explorando con cautela.
        Sobresalto,  // Cuando algo ocurre de repente (un susto leve).
        Colapso,     // El miedo es tan alto que el movimiento falla o se ralentiza.
        Horror       // Estado de muerte o evento final (pérdida de control).
    }

    // Las fases de comportamiento de la Inteligencia Artificial (Enemigo)
    public enum FaseEnemigo
    {
        Rastreo,      // El enemigo camina buscando pistas sin saber dónde estás.
        Sigilo,       // El enemigo sabe que estás cerca y se mueve sin hacer ruido.
        Persecucion,  // El enemigo te vio y va tras de ti (máxima velocidad).
        SedDeSangre   // El estado potenciado donde el enemigo no se detiene por nada.
    }
}

using UnityEngine;
using _Scripts.Interfaces;
using _Scripts.Brains;

namespace _Scripts.States
{
    public class EstadoSedDeSangre : IEstado
    {
        private readonly EnemyBrain _brain;

        public EstadoSedDeSangre(EnemyBrain brain)
        {
            _brain = brain;
        }

        public void Entrar()
        {
            Debug.Log("<color=red>Enemigo entrando en fase de SED DE SANGRE.</color>");
        }

        public void Ejecutar()
        {
        }

        public void Salir()
        {
        }
    }
}

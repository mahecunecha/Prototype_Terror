using UnityEngine;
using _Scripts.Interfaces;
using _Scripts.Brains;

namespace _Scripts.States
{
    public class EstadoPersecucion : IEstado
    {
        private readonly EnemyBrain _brain;

        public EstadoPersecucion(EnemyBrain brain)
        {
            _brain = brain;
        }

        public void Entrar()
        {
            Debug.Log("<color=orange>Enemigo entrando en fase de PERSECUCION.</color>");
        }

        public void Ejecutar()
        {
        }

        public void Salir()
        {
        }
    }
}

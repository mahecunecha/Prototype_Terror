using UnityEngine;

using _Scripts.Interfaces;

using _Scripts.Brains;


namespace _Scripts.States

{

/* * ESTADO: RASTREO (FASE 1)

* El enemigo patrulla tranquilamente entre waypoints.

* Es el estado más "ciego" y lento.

*/

    public class EstadoRastreo : IEstado

    {

        private readonly EnemyBrain _brain;

        private readonly float _velocidadRastreo = 2.5f;


// El constructor nos permite recibir la referencia del cerebro

        public EstadoRastreo(EnemyBrain brain)

        {

            _brain = brain;

        }


        public void Entrar()

        {

            Debug.Log("<color=green>Enemigo entrando en fase de RASTREO.</color>");

// Aquí podrías cambiar el color de la luz del enemigo a blanco/azul

// O bajar el volumen de su respiración.

        }


        public void Ejecutar()

        {

// En este estado, el enemigo simplemente sigue su patrulla normal

// El movimiento perpetuo ya lo maneja el cerebro, así que aquí

// solo nos aseguramos de que la velocidad sea la de rastreo.

            _brain.ActualizarVelocidad(_velocidadRastreo);

        }


        public void Salir()

        {

            Debug.Log("Saliendo de RASTREO: El enemigo ha detectado algo...");

        }

    }

}
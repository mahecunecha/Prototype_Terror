This file is a merged representation of the entire codebase, combined into a single document by Repomix.

# File Summary

## Purpose
This file contains a packed representation of the entire repository's contents.
It is designed to be easily consumable by AI systems for analysis, code review,
or other automated processes.

## File Format
The content is organized as follows:
1. This summary section
2. Repository information
3. Directory structure
4. Repository files (if enabled)
5. Multiple file entries, each consisting of:
  a. A header with the file path (## File: path/to/file)
  b. The full contents of the file in a code block

## Usage Guidelines
- This file should be treated as read-only. Any changes should be made to the
  original repository files, not this packed version.
- When processing this file, use the file path to distinguish
  between different files in the repository.
- Be aware that this file may contain sensitive information. Handle it with
  the same level of security as you would the original repository.

## Notes
- Some files may have been excluded based on .gitignore rules and Repomix's configuration
- Binary files are not included in this packed representation. Please refer to the Repository Structure section for a complete list of file paths, including binary files
- Files matching patterns in .gitignore are excluded
- Files matching default ignore patterns are excluded
- Files are sorted by Git change count (files with more changes are at the bottom)

# Directory Structure
````
Assets/
  _Scripts/
    Brains/
      EnemyBrain_Color.pdf
      EnemyBrain.cs
      mi_informe.pdf
      script_terror.pdf
    Enums/
      GameEnums.cs
    Interfaces/
      IEstado.cs
    Player/
      PlayerController.cs
      PlayerFear.cs
      PlayerNoise.cs
    States/
      EstadoPersecucion.cs
      EstadoRastreo.cs
      EstadoSedDeSangre.cs
      EstadoSigilo.cs
    Systems/
      IntuicionSystem.cs
      TrampaAcustica.cs
    UI/
      UI_BarraMiedo.cs
      UI_MenuManager.cs
  Art/
    Alebardium/
      Bloodlines UI/
        Fonts/
          ManufacturingConsent/
            ManufacturingConsent-Regular.ttf
            OFL.txt
          MedievalSharp/
            MedievalSharp-Regular.ttf
            OFL.txt
        Textures/
          Button/
            Button1/
              Status_Disable.png
              Status_Grey_Default.png
              Status_Grey_Hover.png
              Status_Pressed.png
              Status_Red_Default.png
              Status_Red_Hover.png
            Button2/
              Button2_Status_Disable.png
              Button2_Status_Grey_Default.png
              Button2_Status_Grey_Hover.png
              Button2_Status_Pressed.png
              Button2_Status_Red_Default.png
              Button2_Status_Red_Hover.png
            Button3/
              Button3_Status_Disable.png
              Button3_Status_Grey_Default.png
              Button3_Status_Grey_Hover.png
              Button3_Status_Pressed.png
              Button3_Status_Red_Default.png
              Button3_Status_Red_Hover.png
          Frame/
            Frame_background.png
            Frame_main_menu_red.png
            Frame_main_menu.png
            Frame_outline_red.png
            Frame_outline_v2.png
            Frame_outline.png
          Icon/
            Icons_19.png
            Icons_20.png
            Icons_settins_frame.png
            Icons-1.png
            Icons-16.png
            Icons-17.png
            Icons-18.png
            Icons-2.png
            Icons-3.png
            Icons-4.png
            Icons-5.png
            Icons.png
          Input Field/
            Cross.png
            Frame_input_red.png
            Frame_input.png
          Layout/
            CHECKBOX.png
            Colors.png
            HEALTH.png
            MENU.png
            ON_OFF.png
            PROGRESS_BAR.png
            SETTINGS.png
            TOGGLE_SWITCH.png
          Notice/
            Frame_notice_v1.png
            Frame_notice_v2.png
          Progress_Bar/
            Rectangle/
              Progress_Bar_Rectangle_empty_v1.png
              Progress_Bar_Rectangle_empty_v2.png
              Progress_Bar_Rectangle_empty_v3.png
              Progress_Bar_Rectangle_empty_v4.png
              Progress_Bar_Rectangle_empty_v5.png
              Progress_Bar_Rectangle_full_v1.png
              Progress_Bar_Rectangle_full_v2.png
              Progress_Bar_Rectangle_full_v3.png
              Progress_Bar_Rectangle_full_v4.png
              Progress_Bar_Rectangle_full_v5.png
            Rectangle (Segments)/
              Health_diamond_empty_v1.png
              Health_diamond_empty_v2.png
              Health_diamond_full_v1.png
              Health_diamond_full_v2.png
              Health_rod_empty_v1.png
              Health_rod_full.png
              Slider_5pct_v1.png
              Slider_empty.png
              Slider_full_v1.png
              Slider_toggler.png
            Round/
              Progress_Bar_Round_empty_v1_v4.png
              Progress_Bar_Round_empty_v2_v3.png
              Progress_Bar_Round_full_v1.png
              Progress_Bar_Round_full_v2.png
              Progress_Bar_Round_full_v3.png
              Progress_Bar_Round_full_v4.png
          Toggle/
            Icon Checkmark 1 (Rect).png
            Icon Checkmark 1 (Round).png
            Icon Checkmark 2 (Rect).png
            Icon Checkmark 2 (Round).png
            Icon Checkmark 3 (Rect).png
            Icon Checkmark 3 (Round).png
            Icons-10.png
            Icons-11.png
            Icons-12.png
            Icons-13.png
            Icons-14.png
            Icons-15.png
            Icons-6.png
            Icons-7.png
            Icons-8.png
            Icons-9.png
    Material/
      Enemy_material.mat
      floor_material.mat
      NPC_material.mat
      Player_material.mat
  Input/
    PlayerControls.cs
    PlayerControls.inputactions
  Scenes/
    Catacumbas.unity
    Escena_Inicio.unity
  Sounds/
    Player/
      caminata.wav
      grito.wav
      susurro.wav
  UI Toolkit/
    UnityThemes/
      UnityDefaultRuntimeTheme.tss
  UI_Inicio/
    MenuInicio.uss
    MenuInicio.uxml
    MenuInicioController.cs
  .cursorrules
.gitignore
.repomixignore
Documentacion_Tecnica_Proyecto.md
pagina_codigo-01.png
pagina_codigo-02.png
pagina_codigo-03.png
pagina_codigo-04.png
pagina_codigo-05.png
pagina_codigo-06.png
pagina_codigo-07.png
pagina_codigo-08.png
pagina_codigo-09.png
pagina_codigo-10.png
pagina_codigo-11.png
pagina_codigo-12.png
pagina_codigo-13.png
pagina_codigo-14.png
pagina_codigo-15.png
pagina_codigo-16.png
pagina_codigo-17.png
pagina_codigo-18.png
pagina_codigo-19.png
pagina_codigo-20.png
README.md
repomix-output.xml
todos_los_scripts.pdf
````

# Files

## File: Assets/_Scripts/States/EstadoPersecucion.cs
````csharp
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
````

## File: Assets/_Scripts/States/EstadoSedDeSangre.cs
````csharp
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
````

## File: Assets/_Scripts/States/EstadoSigilo.cs
````csharp
using UnityEngine;
using _Scripts.Interfaces;
using _Scripts.Brains;

namespace _Scripts.States
{
    public class EstadoSigilo : IEstado
    {
        private readonly EnemyBrain _brain;

        public EstadoSigilo(EnemyBrain brain)
        {
            _brain = brain;
        }

        public void Entrar()
        {
            Debug.Log("<color=yellow>Enemigo entrando en fase de SIGILO.</color>");
        }

        public void Ejecutar()
        {
        }

        public void Salir()
        {
        }
    }
}
````

## File: Assets/Art/Alebardium/Bloodlines UI/Fonts/ManufacturingConsent/OFL.txt
````
Copyright 2019 The Manufacturing Consent Project Authors (https://github.com/googlefonts/manufacturing-consent-font)

This Font Software is licensed under the SIL Open Font License, Version 1.1.
This license is copied below, and is also available with a FAQ at:
https://openfontlicense.org


-----------------------------------------------------------
SIL OPEN FONT LICENSE Version 1.1 - 26 February 2007
-----------------------------------------------------------

PREAMBLE
The goals of the Open Font License (OFL) are to stimulate worldwide
development of collaborative font projects, to support the font creation
efforts of academic and linguistic communities, and to provide a free and
open framework in which fonts may be shared and improved in partnership
with others.

The OFL allows the licensed fonts to be used, studied, modified and
redistributed freely as long as they are not sold by themselves. The
fonts, including any derivative works, can be bundled, embedded, 
redistributed and/or sold with any software provided that any reserved
names are not used by derivative works. The fonts and derivatives,
however, cannot be released under any other type of license. The
requirement for fonts to remain under this license does not apply
to any document created using the fonts or their derivatives.

DEFINITIONS
"Font Software" refers to the set of files released by the Copyright
Holder(s) under this license and clearly marked as such. This may
include source files, build scripts and documentation.

"Reserved Font Name" refers to any names specified as such after the
copyright statement(s).

"Original Version" refers to the collection of Font Software components as
distributed by the Copyright Holder(s).

"Modified Version" refers to any derivative made by adding to, deleting,
or substituting -- in part or in whole -- any of the components of the
Original Version, by changing formats or by porting the Font Software to a
new environment.

"Author" refers to any designer, engineer, programmer, technical
writer or other person who contributed to the Font Software.

PERMISSION & CONDITIONS
Permission is hereby granted, free of charge, to any person obtaining
a copy of the Font Software, to use, study, copy, merge, embed, modify,
redistribute, and sell modified and unmodified copies of the Font
Software, subject to the following conditions:

1) Neither the Font Software nor any of its individual components,
in Original or Modified Versions, may be sold by itself.

2) Original or Modified Versions of the Font Software may be bundled,
redistributed and/or sold with any software, provided that each copy
contains the above copyright notice and this license. These can be
included either as stand-alone text files, human-readable headers or
in the appropriate machine-readable metadata fields within text or
binary files as long as those fields can be easily viewed by the user.

3) No Modified Version of the Font Software may use the Reserved Font
Name(s) unless explicit written permission is granted by the corresponding
Copyright Holder. This restriction only applies to the primary font name as
presented to the users.

4) The name(s) of the Copyright Holder(s) or the Author(s) of the Font
Software shall not be used to promote, endorse or advertise any
Modified Version, except to acknowledge the contribution(s) of the
Copyright Holder(s) and the Author(s) or with their explicit written
permission.

5) The Font Software, modified or unmodified, in part or in whole,
must be distributed entirely under this license, and must not be
distributed under any other license. The requirement for fonts to
remain under this license does not apply to any document created
using the Font Software.

TERMINATION
This license becomes null and void if any of the above conditions are
not met.

DISCLAIMER
THE FONT SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO ANY WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT
OF COPYRIGHT, PATENT, TRADEMARK, OR OTHER RIGHT. IN NO EVENT SHALL THE
COPYRIGHT HOLDER BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
INCLUDING ANY GENERAL, SPECIAL, INDIRECT, INCIDENTAL, OR CONSEQUENTIAL
DAMAGES, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF THE USE OR INABILITY TO USE THE FONT SOFTWARE OR FROM
OTHER DEALINGS IN THE FONT SOFTWARE.
````

## File: Assets/Art/Alebardium/Bloodlines UI/Fonts/MedievalSharp/OFL.txt
````
Copyright (c) 2011, wmk69 (wmk69@o2.pl),
with Reserved Font Name MedievalSharp.

This Font Software is licensed under the SIL Open Font License, Version 1.1.
This license is copied below, and is also available with a FAQ at:
https://openfontlicense.org


-----------------------------------------------------------
SIL OPEN FONT LICENSE Version 1.1 - 26 February 2007
-----------------------------------------------------------

PREAMBLE
The goals of the Open Font License (OFL) are to stimulate worldwide
development of collaborative font projects, to support the font creation
efforts of academic and linguistic communities, and to provide a free and
open framework in which fonts may be shared and improved in partnership
with others.

The OFL allows the licensed fonts to be used, studied, modified and
redistributed freely as long as they are not sold by themselves. The
fonts, including any derivative works, can be bundled, embedded, 
redistributed and/or sold with any software provided that any reserved
names are not used by derivative works. The fonts and derivatives,
however, cannot be released under any other type of license. The
requirement for fonts to remain under this license does not apply
to any document created using the fonts or their derivatives.

DEFINITIONS
"Font Software" refers to the set of files released by the Copyright
Holder(s) under this license and clearly marked as such. This may
include source files, build scripts and documentation.

"Reserved Font Name" refers to any names specified as such after the
copyright statement(s).

"Original Version" refers to the collection of Font Software components as
distributed by the Copyright Holder(s).

"Modified Version" refers to any derivative made by adding to, deleting,
or substituting -- in part or in whole -- any of the components of the
Original Version, by changing formats or by porting the Font Software to a
new environment.

"Author" refers to any designer, engineer, programmer, technical
writer or other person who contributed to the Font Software.

PERMISSION & CONDITIONS
Permission is hereby granted, free of charge, to any person obtaining
a copy of the Font Software, to use, study, copy, merge, embed, modify,
redistribute, and sell modified and unmodified copies of the Font
Software, subject to the following conditions:

1) Neither the Font Software nor any of its individual components,
in Original or Modified Versions, may be sold by itself.

2) Original or Modified Versions of the Font Software may be bundled,
redistributed and/or sold with any software, provided that each copy
contains the above copyright notice and this license. These can be
included either as stand-alone text files, human-readable headers or
in the appropriate machine-readable metadata fields within text or
binary files as long as those fields can be easily viewed by the user.

3) No Modified Version of the Font Software may use the Reserved Font
Name(s) unless explicit written permission is granted by the corresponding
Copyright Holder. This restriction only applies to the primary font name as
presented to the users.

4) The name(s) of the Copyright Holder(s) or the Author(s) of the Font
Software shall not be used to promote, endorse or advertise any
Modified Version, except to acknowledge the contribution(s) of the
Copyright Holder(s) and the Author(s) or with their explicit written
permission.

5) The Font Software, modified or unmodified, in part or in whole,
must be distributed entirely under this license, and must not be
distributed under any other license. The requirement for fonts to
remain under this license does not apply to any document created
using the Font Software.

TERMINATION
This license becomes null and void if any of the above conditions are
not met.

DISCLAIMER
THE FONT SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO ANY WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT
OF COPYRIGHT, PATENT, TRADEMARK, OR OTHER RIGHT. IN NO EVENT SHALL THE
COPYRIGHT HOLDER BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
INCLUDING ANY GENERAL, SPECIAL, INDIRECT, INCIDENTAL, OR CONSEQUENTIAL
DAMAGES, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF THE USE OR INABILITY TO USE THE FONT SOFTWARE OR FROM
OTHER DEALINGS IN THE FONT SOFTWARE.
````

## File: Assets/_Scripts/Player/PlayerFear.cs
````csharp
// -----------------------------------------------------------------------------
//  PlayerFear.cs
//  Se suscribe a la "radio" del IntuicionSystem y ajusta el movimiento del
//  jugador basándose en los niveles de miedo del enemigo.
//  Este script DEBE estar adjunto al mismo GameObject que tiene el PlayerController 
//  (por ejemplo, la cápsula del jugador).
// -----------------------------------------------------------------------------
using UnityEngine;

namespace _Scripts.Player
{
    // Garantiza de forma segura que el GameObject tenga un PlayerController.
    // Si no existe, Unity lo añadirá automáticamente para evitar errores de referencia nula en tiempo de ejecución.
    [RequireComponent(typeof(PlayerController))]
    public class PlayerFear : MonoBehaviour
    {
        [Header("Intuicion System (Data Asset)")]
        [Tooltip("Asigna aquí el ScriptableObject de IntuicionSystem que utiliza el EnemyBrain.")]
        [SerializeField] private _Scripts.Systems.IntuicionSystem intuicionSystem;

        // Referencia interna al controlador de movimiento del jugador.
        private PlayerController playerController;
        
        // Nivel de miedo actual del jugador. Rango: 0 (calma total) hasta 4 (terror absoluto).
        private int fearLevel = 0; 
        
        // Límite máximo del nivel de miedo. Corresponde a un factor de 0.8 (80% de penalización de velocidad).
        private const int MaxFearLevel = 4; 

        /// <summary>
        /// Awake se ejecuta al cargar la instancia del script, antes de que empiece el juego.
        /// Ideal para inicializar y capturar componentes internos de forma optimizada sin usar GameObject.Find.
        /// </summary>
        private void Awake()
        {
            // Cacheamos el componente PlayerController que está en este mismo objeto.
            playerController = GetComponent<PlayerController>();
        }

        /// <summary>
        /// Se activa automáticamente cada vez que el objeto se habilita en la escena.
        /// Aquí nos "sintonizamos" a la radio del sistema de intuición (Eventos).
        /// </summary>
        private void OnEnable()
        {
            // Verificación de seguridad por si olvidaste arrastrar el ScriptableObject en el Inspector.
            if (intuicionSystem != null)
            {
                // Nos suscribimos a los eventos. Cuando la IA suba o baje de fase,
                // este script se enterará inmediatamente de forma asíncrona.
                intuicionSystem.OnSubirFase += HandleSubirFase;
                intuicionSystem.OnBajarFase += HandleBajarFase;
            }
        }

        /// <summary>
        /// Se activa automáticamente cuando el objeto se deshabilita o se destruye.
        /// CRUCIAL: Siempre hay que desvincular los eventos para evitar fugas de memoria (Memory Leaks).
        /// </summary>
        private void OnDisable()
        {
            if (intuicionSystem != null)
            {
                // Nos desuscribimos de los eventos para limpiar las referencias en memoria.
                intuicionSystem.OnSubirFase -= HandleSubirFase;
                intuicionSystem.OnBajarFase -= HandleBajarFase;
            }
        }

        /// <summary>
        /// Método manejador que se ejecuta automáticamente cuando el sistema avisa que el enemigo subió de fase.
        /// </summary>
        private void HandleSubirFase()
        {
            // Incrementamos el miedo en 1, pero usamos Mathf.Clamp para asegurar 
            // que matemáticamente nunca supere el MaxFearLevel (4) ni baje de 0.
            fearLevel = Mathf.Clamp(fearLevel + 1, 0, MaxFearLevel);
            
            // Recalculamos y aplicamos el peso del terror al jugador.
            ApplyFearPenalty();
        }

        /// <summary>
        /// Método manejador que se ejecuta automáticamente cuando el sistema avisa que el enemigo bajó de fase (se enfrió).
        /// </summary>
        private void HandleBajarFase()
        {
            // Decrementamos el miedo en 1, manteniendo el valor protegido entre 0 y 4.
            fearLevel = Mathf.Clamp(fearLevel - 1, 0, MaxFearLevel);
            
            // Recalculamos y aplicamos el peso del terror al jugador.
            ApplyFearPenalty();
        }

        /// <summary>
        /// Traduce el nivel de miedo entero (0 a 4) en un porcentaje decimal de penalización física 
        /// y se lo inyecta al PlayerController.
        /// </summary>
        private void ApplyFearPenalty()
        {
            // Control de daños: Si por alguna razón el script se rompió o no tiene el controlador, cancela la ejecución.
            if (playerController == null) return;
            
            // EXPLICACIÓN MATEMÁTICA DEL FACTOR:
            // 1. (float)fearLevel de la línea inferior convierte el entero a float para permitir divisiones decimales exactas.
            // 2. Se divide entre MaxFearLevel (4) para obtener un porcentaje normalizado de 0.0 a 1.0.
            // 3. Se multiplica por 0.8f para escalar ese porcentaje a un rango final de 0.0 a 0.8.
            // Ejemplos de resultado según la fase:
            // - Miedo 0: (0 / 4) * 0.8 = 0.0  -> 0% de reducción (Velocidad normal).
            // - Miedo 1: (1 / 4) * 0.8 = 0.2  -> 20% de reducción.
            // - Miedo 2: (2 / 4) * 0.8 = 0.4  -> 40% de reducción.
            // - Miedo 3: (3 / 4) * 0.8 = 0.6  -> 60% de reducción.
            // - Miedo 4: (4 / 4) * 0.8 = 0.8  -> 80% de reducción (El jugador apenas puede arrastrarse del susto).
            float factor = (float)fearLevel / MaxFearLevel * 0.8f;
            
            // Le enviamos este factor limpio al PlayerController para que reste velocidad o altere el movimiento.
            playerController.AplicarPenalizacionMiedo(factor);
        }
    }
}
````

## File: Assets/_Scripts/Player/PlayerNoise.cs
````csharp
using UnityEngine;
using _Scripts.Systems; // Para ver el IntuicionSystem
using _Scripts.Enums;   // Para ver el PerfilAcustico

namespace _Scripts.Player
{
    /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
     * CLASE: PlayerNoise (El Generador de Pulsos)
     * Se encarga de medir el tiempo entre pasos, reproducir el audio 
     * local para asustar al jugador humano, y enviar el "Paquete de Datos"
     * matemático al cerebro del enemigo.
     * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
    public class PlayerNoise : MonoBehaviour
    {
        [Header("Comunicaciones (Los Cables)")]
        [Tooltip("El 'buzón' central donde dejaremos el paquete de ruido")]
        /*Oye, en este espacio solo se pueden guardar cosas que tengan la estructura de IntuicionSystem
         dataIntuicion es solo un puntero inalambrico*/
        [SerializeField] private IntuicionSystem dataIntuicion; 
        
        [Tooltip("El cuerpo del enemigo para poder calcular a cuántos metros estamos")]
        [SerializeField] private Transform transformEnemigo;

        [Header("Configuración de Audio Físico")]
        [Tooltip("El parlante que reproducirá los .wav en los pies/boca del jugador")]
        [SerializeField] private AudioSource emisorDeSonido;
        
        [Tooltip("Audios para cuando el jugador va lento/agachado")]
        [SerializeField] private AudioClip audioSusurro; 
        
        [Tooltip("Audios para cuando el jugador camina normal")]
        [SerializeField] private AudioClip audioPasoNormal;
        
        [Tooltip("Audios para cuando el jugador corre asustado")]
        [SerializeField] private AudioClip audioGritoSusto;

        // --- EL ETIQUETADOR DE ESTADOS ---
        // Este enum local nos dice qué está haciendo el jugador AHORA MISMO.
        // Más adelante, el script de movimiento cambiará esta variable automáticamente.
        public enum EstadoMovimiento { Quieto, Agachado, Caminando, Corriendo }
        
        [Header("Estado Actual (Pruebas)")]
        [Tooltip("Cambia esto en Unity mientras juegas para probar los distintos ruidos")]
        public EstadoMovimiento estadoActual = EstadoMovimiento.Quieto;

        // El segundero que cuenta el tiempo entre un paso y otro
        private float _cronometroPulso = 0f;

        private void Start()
        {
            // Cláusulas de salvaguarda: Avisamos si olvidaste conectar algo en el Inspector
            if (!dataIntuicion) Debug.LogError("PlayerNoise: Falta conectar el IntuicionSystem.");
            if (!transformEnemigo) Debug.LogError("PlayerNoise: Falta el Transform del Enemigo.");
            if (!emisorDeSonido) Debug.LogError("PlayerNoise: Falta el AudioSource.");
        }

        private void Update()
        {
            // Si falta el buzón de datos, no hacemos nada, para, evitar que el juego explote
            if (!dataIntuicion || !transformEnemigo) return;

            // 1. EL RELOJ: Definimos qué tan rápido late el pulso según el estado
            float tiempoEntrePulsos = 0f;

            switch (estadoActual)
            {
                case EstadoMovimiento.Quieto: 
                    _cronometroPulso = 0f; // Reseteamos el reloj
                    return; // Salimos del Update, no hay ruido que hacer
                
                case EstadoMovimiento.Agachado: 
                    tiempoEntrePulsos = 1.2f; // Un pulso lento (mucho espacio entre pasos)
                    break;
                
                case EstadoMovimiento.Caminando: 
                    tiempoEntrePulsos = 0.7f; // Un pulso normal
                    break;
                
                case EstadoMovimiento.Corriendo: 
                    tiempoEntrePulsos = 0.3f; // Un pulso rapidísimo (pasos acelerados)
                    break;
            }

            // 2. EL SEGUNDERO AVANZA
            _cronometroPulso += Time.deltaTime;

            // 3. EL DISPARO
            if (_cronometroPulso >= tiempoEntrePulsos)
            {
                EmitirRuidoDelPulso();
                _cronometroPulso = 0f; // Vaciamos el reloj para empezar a contar el siguiente paso
            }
        }

        /* * *
         * MÉTODO: EmitirRuidoDelPulso
         * Se ejecuta solo en el frame exacto en el que el pie toca el suelo.
         * Prepara el paquete, reproduce el .wav y lo envía por correo.
         */
        // ReSharper disable Unity.PerformanceAnalysis
        private void EmitirRuidoDelPulso()
        {
            // A. Calculamos la distancia real en metros usando trigonometría de Unity
            float distanciaAlEnemigo = Vector3.Distance(transform.position, transformEnemigo.position);

            // B. Preparamos las variables que meteremos en el paquete
            float volumenPaquete = 0f;
            PerfilAcustico perfilPaquete = PerfilAcustico.GraveFisico; // Por defecto
            AudioClip clipFalsoParaHumano = null;

            // C. Rellenamos el paquete según el estado
            switch (estadoActual)
            {
                case EstadoMovimiento.Agachado:
                    volumenPaquete = 0.1f; // Muy bajito
                    perfilPaquete = PerfilAcustico.AgudoVocal; // Un susurro que se apaga rápido en la distancia
                    clipFalsoParaHumano = audioSusurro;
                    break;

                case EstadoMovimiento.Caminando:
                    volumenPaquete = 0.3f; // Medio
                    perfilPaquete = PerfilAcustico.GraveFisico; // Un paso que hace vibrar el suelo
                    clipFalsoParaHumano = audioPasoNormal;
                    break;

                case EstadoMovimiento.Corriendo:
                    volumenPaquete = 0.8f; // Escandaloso
                    perfilPaquete = PerfilAcustico.AgudoVocal; // Un grito/jadeo de pánico
                    clipFalsoParaHumano = audioGritoSusto;
                    break;
            }

            // D. LA MAGIA: Actualizamos la posición sospechosa...
            dataIntuicion.posicionSospechosa = transform.position;
            
            // ... Y enviamos el paquete matemático al IntuicionSystem
            // ¡Fíjate cómo usamos el Enum aquí como una etiqueta de envío!
            dataIntuicion.ModificarIntuicion(volumenPaquete, distanciaAlEnemigo, perfilPaquete);

            // E. EL TEATRO: Reproducimos el archivo .wav real para asustar al jugador
            if (emisorDeSonido && clipFalsoParaHumano)
            {
                emisorDeSonido.PlayOneShot(clipFalsoParaHumano);
            }
            
            // Un log para que tú como desarrollador veas que el pulso salió bien
            Debug.Log($"<color=yellow>PULSO: {estadoActual} | Vol: {volumenPaquete} | Perfil: {perfilPaquete} | Dist: {distanciaAlEnemigo:F1}m</color>");
        }
    }
}
````

## File: Assets/_Scripts/Systems/TrampaAcustica.cs
````csharp
using UnityEngine;
using System.Collections;
using _Scripts.Enums;

namespace _Scripts.Systems
{
    [RequireComponent(typeof(AudioSource))]
    public class TrampaAcustica : MonoBehaviour
    {
        public IntuicionSystem dataIntuicion;
        [Range(0f, 1f)] public float volumenAlerta = 0.3f;
        public PerfilAcustico perfilAcustico = PerfilAcustico.GraveFisico;
        public float tiempoApagado = 4.0f;

        private AudioSource _audioSource;
        private bool _jugadorPresente = false;
        private Coroutine _rutinaApagado;

        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
            _audioSource.playOnAwake = false;
            _audioSource.loop = true;
            _audioSource.spatialBlend = 1.0f;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                _jugadorPresente = true;

                if (_rutinaApagado != null)
                {
                    StopCoroutine(_rutinaApagado);
                    _rutinaApagado = null;
                }

                if (!_audioSource.isPlaying)
                {
                    _audioSource.Play();
                }

                if (dataIntuicion != null)
                {
                    dataIntuicion.posicionSospechosa = transform.position;

                    GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
                    if (enemy != null)
                    {
                        float distanciaAlMonstruo = Vector3.Distance(transform.position, enemy.transform.position);
                        dataIntuicion.ModificarIntuicion(volumenAlerta, distanciaAlMonstruo, perfilAcustico);
                    }
                }
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                _jugadorPresente = false;
                if (_rutinaApagado != null)
                {
                    StopCoroutine(_rutinaApagado);
                }
                _rutinaApagado = StartCoroutine(RutinaApagarAudio());
            }
        }

        private IEnumerator RutinaApagarAudio()
        {
            yield return new WaitForSeconds(tiempoApagado);
            
            if (!_jugadorPresente && _audioSource.isPlaying)
            {
                _audioSource.Stop();
            }
            _rutinaApagado = null;
        }
    }
}
````

## File: Assets/_Scripts/UI/UI_BarraMiedo.cs
````csharp
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
````

## File: Assets/Art/Material/Enemy_material.mat
````
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 8
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Enemy_material
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_Parent: {fileID: 0}
  m_ModifiedSerializedProperties: 0
  m_ValidKeywords: []
  m_InvalidKeywords: []
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_LockedProperties: 
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Ints: []
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0.5
    - _GlossyReflections: 1
    - _Metallic: 1
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.4641646, g: 0.14346741, b: 0.49056602, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}
  m_BuildTextureStacks: []
````

## File: Assets/Art/Material/floor_material.mat
````
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 8
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: floor_material
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_Parent: {fileID: 0}
  m_ModifiedSerializedProperties: 0
  m_ValidKeywords: []
  m_InvalidKeywords: []
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_LockedProperties: 
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Ints: []
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0.5
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.09230664, g: 0.33962262, b: 0.014417935, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}
  m_BuildTextureStacks: []
````

## File: Assets/Art/Material/NPC_material.mat
````
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 8
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: NPC_material
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_Parent: {fileID: 0}
  m_ModifiedSerializedProperties: 0
  m_ValidKeywords: []
  m_InvalidKeywords: []
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_LockedProperties: 
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Ints: []
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0.5
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.6132076, g: 0.057849765, b: 0.057849765, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}
  m_BuildTextureStacks: []
````

## File: Assets/Art/Material/Player_material.mat
````
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 8
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Player_material
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_Parent: {fileID: 0}
  m_ModifiedSerializedProperties: 0
  m_ValidKeywords: []
  m_InvalidKeywords: []
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_LockedProperties: 
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Ints: []
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0.247
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.8584906, g: 0.49808654, b: 0.74376494, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}
  m_BuildTextureStacks: []
````

## File: Assets/Scenes/Escena_Inicio.unity
````
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!29 &1
OcclusionCullingSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  m_OcclusionBakeSettings:
    smallestOccluder: 5
    smallestHole: 0.25
    backfaceThreshold: 100
  m_SceneGUID: 00000000000000000000000000000000
  m_OcclusionCullingData: {fileID: 0}
--- !u!104 &2
RenderSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 9
  m_Fog: 0
  m_FogColor: {r: 0.5, g: 0.5, b: 0.5, a: 1}
  m_FogMode: 3
  m_FogDensity: 0.01
  m_LinearFogStart: 0
  m_LinearFogEnd: 300
  m_AmbientSkyColor: {r: 0.212, g: 0.227, b: 0.259, a: 1}
  m_AmbientEquatorColor: {r: 0.114, g: 0.125, b: 0.133, a: 1}
  m_AmbientGroundColor: {r: 0.047, g: 0.043, b: 0.035, a: 1}
  m_AmbientIntensity: 1
  m_AmbientMode: 0
  m_SubtractiveShadowColor: {r: 0.42, g: 0.478, b: 0.627, a: 1}
  m_SkyboxMaterial: {fileID: 10304, guid: 0000000000000000f000000000000000, type: 0}
  m_HaloStrength: 0.5
  m_FlareStrength: 1
  m_FlareFadeSpeed: 3
  m_HaloTexture: {fileID: 0}
  m_SpotCookie: {fileID: 10001, guid: 0000000000000000e000000000000000, type: 0}
  m_DefaultReflectionMode: 0
  m_DefaultReflectionResolution: 128
  m_ReflectionBounces: 1
  m_ReflectionIntensity: 1
  m_CustomReflection: {fileID: 0}
  m_Sun: {fileID: 0}
  m_UseRadianceAmbientProbe: 0
--- !u!157 &3
LightmapSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 12
  m_GIWorkflowMode: 1
  m_GISettings:
    serializedVersion: 2
    m_BounceScale: 1
    m_IndirectOutputScale: 1
    m_AlbedoBoost: 1
    m_EnvironmentLightingMode: 0
    m_EnableBakedLightmaps: 1
    m_EnableRealtimeLightmaps: 0
  m_LightmapEditorSettings:
    serializedVersion: 12
    m_Resolution: 2
    m_BakeResolution: 40
    m_AtlasSize: 1024
    m_AO: 0
    m_AOMaxDistance: 1
    m_CompAOExponent: 1
    m_CompAOExponentDirect: 0
    m_ExtractAmbientOcclusion: 0
    m_Padding: 2
    m_LightmapParameters: {fileID: 0}
    m_LightmapsBakeMode: 1
    m_TextureCompression: 1
    m_FinalGather: 0
    m_FinalGatherFiltering: 1
    m_FinalGatherRayCount: 256
    m_ReflectionCompression: 2
    m_MixedBakeMode: 2
    m_BakeBackend: 1
    m_PVRSampling: 1
    m_PVRDirectSampleCount: 32
    m_PVRSampleCount: 512
    m_PVRBounces: 2
    m_PVREnvironmentSampleCount: 256
    m_PVREnvironmentReferencePointCount: 2048
    m_PVRFilteringMode: 1
    m_PVRDenoiserTypeDirect: 1
    m_PVRDenoiserTypeIndirect: 1
    m_PVRDenoiserTypeAO: 1
    m_PVRFilterTypeDirect: 0
    m_PVRFilterTypeIndirect: 0
    m_PVRFilterTypeAO: 0
    m_PVREnvironmentMIS: 1
    m_PVRCulling: 1
    m_PVRFilteringGaussRadiusDirect: 1
    m_PVRFilteringGaussRadiusIndirect: 5
    m_PVRFilteringGaussRadiusAO: 2
    m_PVRFilteringAtrousPositionSigmaDirect: 0.5
    m_PVRFilteringAtrousPositionSigmaIndirect: 2
    m_PVRFilteringAtrousPositionSigmaAO: 1
    m_ExportTrainingData: 0
    m_TrainingDataDestination: TrainingData
    m_LightProbeSampleCountMultiplier: 4
  m_LightingDataAsset: {fileID: 0}
  m_LightingSettings: {fileID: 0}
--- !u!196 &4
NavMeshSettings:
  serializedVersion: 2
  m_ObjectHideFlags: 0
  m_BuildSettings:
    serializedVersion: 3
    agentTypeID: 0
    agentRadius: 0.5
    agentHeight: 2
    agentSlope: 45
    agentClimb: 0.4
    ledgeDropHeight: 0
    maxJumpAcrossDistance: 0
    minRegionArea: 2
    manualCellSize: 0
    cellSize: 0.16666667
    manualTileSize: 0
    tileSize: 256
    buildHeightMesh: 0
    maxJobWorkers: 0
    preserveTilesOutsideBounds: 0
    debug:
      m_Flags: 0
  m_NavMeshData: {fileID: 0}
--- !u!1 &134219226
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 134219229}
  - component: {fileID: 134219228}
  - component: {fileID: 134219227}
  m_Layer: 0
  m_Name: EventSystem
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!114 &134219227
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 134219226}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 01614664b831546d2ae94a42149d80ac, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_SendPointerHoverToParent: 1
  m_MoveRepeatDelay: 0.5
  m_MoveRepeatRate: 0.1
  m_XRTrackingOrigin: {fileID: 0}
  m_ActionsAsset: {fileID: -944628639613478452, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_PointAction: {fileID: -1654692200621890270, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_MoveAction: {fileID: -8784545083839296357, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_SubmitAction: {fileID: 392368643174621059, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_CancelAction: {fileID: 7727032971491509709, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_LeftClickAction: {fileID: 3001919216989983466, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_MiddleClickAction: {fileID: -2185481485913320682, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_RightClickAction: {fileID: -4090225696740746782, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_ScrollWheelAction: {fileID: 6240969308177333660, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_TrackedDevicePositionAction: {fileID: 6564999863303420839, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_TrackedDeviceOrientationAction: {fileID: 7970375526676320489, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_DeselectOnBackgroundClick: 1
  m_PointerBehavior: 0
  m_CursorLockBehavior: 0
  m_ScrollDeltaPerTick: 6
--- !u!114 &134219228
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 134219226}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 76c392e42b5098c458856cdf6ecaaaa1, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_FirstSelected: {fileID: 0}
  m_sendNavigationEvents: 1
  m_DragThreshold: 10
--- !u!4 &134219229
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 134219226}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &732479689
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 732479691}
  - component: {fileID: 732479690}
  - component: {fileID: 732479692}
  m_Layer: 0
  m_Name: UI_Document_Manager
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!114 &732479690
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 732479689}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 19102, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_PanelSettings: {fileID: 11400000, guid: 4425d11ec82b03b408be9b9c96826225, type: 2}
  m_ParentUI: {fileID: 0}
  sourceAsset: {fileID: 9197481963319205126, guid: 337cd63dde14bd7059adb662f049dd56, type: 3}
  m_SortingOrder: 0
--- !u!4 &732479691
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 732479689}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 1.1999894, y: 0.049994383, z: 5.089841}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &732479692
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 732479689}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 2190a56341500098da2ac6305580ead0, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  escenaGameplay: Catacumbas
--- !u!1 &1118566622
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1118566624}
  - component: {fileID: 1118566623}
  m_Layer: 0
  m_Name: Directional Light
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!108 &1118566623
Light:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1118566622}
  m_Enabled: 1
  serializedVersion: 10
  m_Type: 1
  m_Shape: 0
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_Intensity: 1
  m_Range: 10
  m_SpotAngle: 30
  m_InnerSpotAngle: 21.80208
  m_CookieSize: 10
  m_Shadows:
    m_Type: 0
    m_Resolution: -1
    m_CustomResolution: -1
    m_Strength: 1
    m_Bias: 0.05
    m_NormalBias: 0.4
    m_NearPlane: 0.2
    m_CullingMatrixOverride:
      e00: 1
      e01: 0
      e02: 0
      e03: 0
      e10: 0
      e11: 1
      e12: 0
      e13: 0
      e20: 0
      e21: 0
      e22: 1
      e23: 0
      e30: 0
      e31: 0
      e32: 0
      e33: 1
    m_UseCullingMatrixOverride: 0
  m_Cookie: {fileID: 0}
  m_DrawHalo: 0
  m_Flare: {fileID: 0}
  m_RenderMode: 0
  m_CullingMask:
    serializedVersion: 2
    m_Bits: 4294967295
  m_RenderingLayerMask: 1
  m_Lightmapping: 4
  m_LightShadowCasterMode: 0
  m_AreaSize: {x: 1, y: 1}
  m_BounceIntensity: 1
  m_ColorTemperature: 6570
  m_UseColorTemperature: 0
  m_BoundingSphereOverride: {x: 0, y: 0, z: 0, w: 0}
  m_UseBoundingSphereOverride: 0
  m_UseViewFrustumForShadowCasterCull: 1
  m_ShadowRadius: 0
  m_ShadowAngle: 0
--- !u!4 &1118566624
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1118566622}
  serializedVersion: 2
  m_LocalRotation: {x: 0.40821788, y: -0.23456968, z: 0.10938163, w: 0.8754261}
  m_LocalPosition: {x: 1.1999894, y: 0.049994383, z: 5.089841}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 50, y: -30, z: 0}
--- !u!1 &1206418219
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1206418222}
  - component: {fileID: 1206418221}
  - component: {fileID: 1206418220}
  m_Layer: 0
  m_Name: Camera
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!81 &1206418220
AudioListener:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1206418219}
  m_Enabled: 1
--- !u!20 &1206418221
Camera:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1206418219}
  m_Enabled: 1
  serializedVersion: 2
  m_ClearFlags: 1
  m_BackGroundColor: {r: 0.19215687, g: 0.3019608, b: 0.4745098, a: 0}
  m_projectionMatrixMode: 1
  m_GateFitMode: 2
  m_FOVAxisMode: 0
  m_Iso: 200
  m_ShutterSpeed: 0.005
  m_Aperture: 16
  m_FocusDistance: 10
  m_FocalLength: 50
  m_BladeCount: 5
  m_Curvature: {x: 2, y: 11}
  m_BarrelClipping: 0.25
  m_Anamorphism: 0
  m_SensorSize: {x: 36, y: 24}
  m_LensShift: {x: 0, y: 0}
  m_NormalizedViewPortRect:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1
    height: 1
  near clip plane: 0.3
  far clip plane: 1000
  field of view: 60
  orthographic: 0
  orthographic size: 5
  m_Depth: 0
  m_CullingMask:
    serializedVersion: 2
    m_Bits: 4294967295
  m_RenderingPath: -1
  m_TargetTexture: {fileID: 0}
  m_TargetDisplay: 0
  m_TargetEye: 3
  m_HDR: 1
  m_AllowMSAA: 1
  m_AllowDynamicResolution: 0
  m_ForceIntoRT: 0
  m_OcclusionCulling: 1
  m_StereoConvergence: 10
  m_StereoSeparation: 0.022
--- !u!4 &1206418222
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1206418219}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 1.1999894, y: 0.049994383, z: 5.089841}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1660057539 &9223372036854775807
SceneRoots:
  m_ObjectHideFlags: 0
  m_Roots:
  - {fileID: 732479691}
  - {fileID: 1118566624}
  - {fileID: 1206418222}
  - {fileID: 134219229}
````

## File: Assets/UI Toolkit/UnityThemes/UnityDefaultRuntimeTheme.tss
````
@import url("unity-theme://default");
````

## File: Assets/UI_Inicio/MenuInicio.uss
````
.pantalla-completa {
    width: 100%;
    height: 100%;
    background-color: #000000;
    align-items: center;
    justify-content: center;
}

.contenedor-centrado {
    align-items: center;
    justify-content: center;
}

.titulo-juego {
    font-size: 72px;
    color: #AA0000;
    -unity-font-style: bold;
    margin-bottom: 50px;
}

.boton-inicio {
    background-color: #222222;
    border-width: 1px;
    border-color: #555555;
    color: #FFFFFF;
    padding-top: 15px;
    padding-bottom: 15px;
    padding-left: 40px;
    padding-right: 40px;
    font-size: 24px;
    transition-duration: 0.3s;
    transition-property: scale, background-color;
}

.boton-inicio:hover {
    scale: 1.05;
    background-color: #444444;
}
````

## File: Assets/UI_Inicio/MenuInicio.uxml
````
<ui:UXML xmlns:ui="UnityEngine.UIElements" xmlns:uie="UnityEditor.UIElements" xsi="http://www.w3.org/2001/XMLSchema-instance" editor="UnityEditor.UIElements" noNamespaceSchemaLocation="../../UIElementsSchema/UIElements.xsd" editor-extension-mode="False">
    <Style src="project://database/Assets/UI_Inicio/MenuInicio.uss?fileID=7433441132597879392&amp;guid=9655d613110827a83ae6327c73cfdb95&amp;type=3#MenuInicio" />
    <ui:VisualElement class="pantalla-completa" picking-mode="Ignore">
        <ui:VisualElement class="contenedor-centrado" picking-mode="Ignore">
            <ui:Label text="PROTOTYPE TERROR" class="titulo-juego" />
            <ui:Button text="ENTRAR AL HORROR" parse-escape-sequences="true" display-tooltip-when-elided="true" name="btnJugar" picking-mode="Position" style="position: absolute; height: 33px; top: 74px; -unity-text-align: middle-right;" />
        </ui:VisualElement>
    </ui:VisualElement>
</ui:UXML>
````

## File: Assets/UI_Inicio/MenuInicioController.cs
````csharp
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
````

## File: Assets/.cursorrules
````
# MANUAL DE OPERACIÓN DE UNITY & ANTIGRAVITY (MCP)

## 1. Directrices de Optimización de Tokens y Rendimiento
- **Diagnóstico Obligatorio:** Antes de proponer modificaciones de código o corregir errores de compilación/ejecución, DEBES inspeccionar el estado real del proyecto usando 'read_console' o los recursos de escena de GameObject. No adivines soluciones sin ver los logs.
- **Uso de Lotes (Batching):** Para cualquier tarea que implique crear, mover o modificar más de 2 objetos o componentes secuencialmente, utiliza obligatoriamente la herramienta 'batch_execute'. No realices múltiples llamadas secuenciales a herramientas individuales.
- **Modificaciones Quirúrgicas:** Para editar scripts de C#, utiliza prioritariamente la herramienta 'script_apply_edits' con operaciones enfocadas ('replace_method', 'insert_method') en lugar de reescribir o reemplazar archivos de código completos.
- **Validación de APIs en Vivo:** Si necesitas usar clases o métodos de paquetes específicos (como Cinemachine, URP o el nuevo Input System), verifica su existencia y firma exacta primero mediante 'unity_reflect' antes de escribir código.
- **Control de Capturas Visuales:** Limita el uso del parámetro 'include_image=true' en capturas de pantalla ('manage_camera' o 'manage_ui') estrictamente a validaciones visuales críticas que requiera el usuario. Prefiero comprobar jerarquías o datos puros para ahorrar contexto de tokens.

## 2. Reglas del Chasis y Arquitectura del Juego (Prototype Terror)
- **Nombres Clave Obligatorios:** Respeta minuciosamente el Diccionario de Identidad del proyecto:
  * Estados del Player (FasePlayer): Alerta, Sobresalto, Colapso, Horror.
  * Estados del Enemigo (FaseEnemigo): Rastreo, Sigilo, Persecucion, SedDeSangre.
  * Variable de Control Global: 'intuicion' (un acumulador de tipo float de 0.0 a 1.0 dentro del ScriptableObject 'IntuicionSystem').
- **Arquitectura de la IA (EnemyBrain):** Los estados de la IA del enemigo deben desacoplarse del jugador e implementar obligatoriamente la interfaz 'IEstado' (con sus contratos Entrar, Ejecutar, Salir).
- **Rendimiento de Eventos:** Prohíbe el uso de ciclos 'Update()' innecesarios en scripts de interfaz o escucha de datos; toda actualización de estado físico, de miedo o de interfaz debe responder de forma pasiva a eventos o cambios del ScriptableObject.
- **Código Limpio:** Todos los scripts generados deben incluir comentarios estructurados en español detallando la lógica del chasis y finalizar con una línea en blanco (Render Final Newline).

## 3. Interfaces con UI Toolkit
- **Estructura UXML:** Asegúrate de utilizar siempre el prefijo de namespace '<ui:Style>' para añadir hojas de estilos en los archivos UXML. Nunca uses etiquetas '<Style>' desnudas porque rompen el UI Builder de Unity.
````

## File: .gitignore
````
# This .gitignore file should be placed at the root of your Unity project directory
#
# Get latest from https://github.com/github/gitignore/blob/master/Unity.gitignore
#
/[Ll]ibrary/
/[Tt]emp/
/[Oo]bj/
/[Bb]uild/
/[Bb]uilds/
/[Ll]ogs/
/[Mm]emoryCaptures/

# Never ignore Asset meta data
!/[Aa]ssets/**/*.meta

# Uncomment this line if you wish to ignore the asset store tools plugin
# /[Aa]ssets/AssetStoreTools*

# TextMesh Pro files
[Aa]ssets/TextMesh*Pro/

# Autogenerated Jetbrains Rider plugin
[Aa]ssets/Plugins/Editor/JetBrains*

# Visual Studio cache directory
.vs/

# Gradle cache directory
.gradle/

# Autogenerated VS/MD/Consulo solution and project files
ExportedObj/
.consulo/
*.csproj
*.unityproj
*.sln
*.suo
*.tmp
*.user
*.userprefs
*.pidb
*.booproj
*.svd
*.pdb
*.mdb
*.opendb
*.VC.db

# Unity3D generated meta files
*.pidb.meta
*.pdb.meta
*.mdb.meta

# Unity3D generated file on crash reports
sysinfo.txt

# Builds
*.apk
*.unitypackage

# Crashlytics generated file
crashlytics-build.properties
````

## File: .repomixignore
````
# Excluir carpetas pesadas o inútiles de Unity
Library/
Temp/
Obj/
Logs/
UserSettings/
MemoryCaptures/
Builds/
*.meta
*.unitypackage
*.asset
*.prefab
UserSettings/
Packages/
ProjectSettings/
*.meta
````

## File: Documentacion_Tecnica_Proyecto.md
````markdown
This file is a merged representation of the entire codebase, combining all repository files into a single document.
Generated by Repopack on: 2026-06-29T22:07:44.253Z

================================================================
File Summary
================================================================

Purpose:
--------
This file contains a packed representation of the entire repository's contents.
It is designed to be easily consumable by AI systems for analysis, code review,
or other automated processes.

File Format:
------------
The content is organized as follows:
1. This summary section
2. Repository information
3. Repository structure
4. Multiple file entries, each consisting of:
  a. A separator line (================)
  b. The file path (File: path/to/file)
  c. Another separator line
  d. The full contents of the file
  e. A blank line

Usage Guidelines:
-----------------
- This file should be treated as read-only. Any changes should be made to the
  original repository files, not this packed version.
- When processing this file, use the file path to distinguish
  between different files in the repository.
- Be aware that this file may contain sensitive information. Handle it with
  the same level of security as you would the original repository.

Notes:
------
- Some files may have been excluded based on .gitignore rules and Repopack's
  configuration.
- Binary files are not included in this packed representation. Please refer to
  the Repository Structure section for a complete list of file paths, including
  binary files.

Additional Info:
----------------

For more information about Repopack, visit: https://github.com/yamadashy/repopack

================================================================
Repository Structure
================================================================
Assets/
  _Scripts/
    Brains/
      EnemyBrain.cs
      EnemyBrain.cs.meta
    Enums/
      GameEnums.cs
      GameEnums.cs.meta
    Interfaces/
      IEstado.cs
      IEstado.cs.meta
    Player/
      PlayerController.cs
      PlayerController.cs.meta
      PlayerFear.cs
      PlayerFear.cs.meta
      PlayerNoise.cs
      PlayerNoise.cs.meta
    States/
      EstadoRastreo.cs
      EstadoRastreo.cs.meta
    Systems/
      Data_Enemigo_Principal.asset
      Data_Enemigo_Principal.asset.meta
      IntuicionSystem.cs
      IntuicionSystem.cs.meta
    UI/
      UI_MenuManager.cs
      UI_MenuManager.cs.meta
    Brains.meta
    Enums.meta
    Interfaces.meta
    Player.meta
    States.meta
    Systems.meta
    UI.meta
  Art/
    Material/
      New Material.mat
      New Material.mat.meta
    Material.meta
  Input/
    PlayerControls.cs
    PlayerControls.cs.meta
    PlayerControls.inputactions
    PlayerControls.inputactions.meta
  Scenes/
    Catacumbas/
      NavMesh-NavMesh Manager.asset.meta
    Catacumbas.meta
    Catacumbas.unity.meta
  Sounds/
    Player/
      caminata.wav.meta
      grito.wav.meta
      susurro.wav.meta
    Player.meta
  _Scripts.meta
  Art.meta
  Input.meta
  Scenes.meta
  Sounds.meta
  TextMesh Pro.meta
Packages/
  manifest.json
  packages-lock.json
ProjectSettings/
  AudioManager.asset
  ClusterInputManager.asset
  DynamicsManager.asset
  EditorBuildSettings.asset
  EditorSettings.asset
  GraphicsSettings.asset
  InputManager.asset
  MemorySettings.asset
  NavMeshAreas.asset
  PackageManagerSettings.asset
  Physics2DSettings.asset
  PresetManager.asset
  ProjectSettings.asset
  ProjectVersion.txt
  QualitySettings.asset
  SceneTemplateSettings.json
  TagManager.asset
  TimeManager.asset
  UnityConnectSettings.asset
  VersionControlSettings.asset
  VFXManager.asset
UserSettings/
  Layouts/
    CurrentMaximizeLayout.dwlt
    default-2022.dwlt
  EditorUserSettings.asset
  Search.index
  Search.settings
.gitignore
.repopackignore 
README.md

================================================================
Repository Files
================================================================

================
File: Assets/_Scripts/Brains/EnemyBrain.cs
================
using UnityEngine;
using UnityEngine.AI; // Acceso al sistema de navegación
using UnityEngine.SceneManagement; // Importado para reiniciar la escena
using _Scripts.Systems;     // Acceso al corazón de datos (ScriptableObject)
using _Scripts.Interfaces;   // Acceso al contrato IEstado
using _Scripts.States;       // Acceso a las lógicas de estado (Rastreo, Sigilo...)

namespace _Scripts.Brains
{
    /* * * CLASE: EnemyBrain
     * DESCRIPCIÓN: Actúa como el "Cuerpo" y "Contexto" de la IA (Hardware). 
     * No decide qué hacer por sí mismo, sino que delega esa tarea a un objeto IEstado.
     * Mantiene vivo el cronómetro de 60s para el enfriamiento.
     * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
    public class EnemyBrain : MonoBehaviour
    {
        [Header("Referencias de Datos")]
        [Tooltip("El archivo de datos (SO) que compartimos con el jugador y el sistema")]
        [SerializeField] private IntuicionSystem data;
        public IntuicionSystem Data => data; // Propiedad pública para los Estados
        
        [Header("Configuración de Movimiento y Navegación")]
        [Tooltip("Agente de navegación del enemigo")]
        [SerializeField] private NavMeshAgent agent;
        public NavMeshAgent Agent => agent; // Propiedad pública para los Estados

        [Tooltip("Velocidad de traslación física base.")]
        [SerializeField] private float velocidadBase = 3.5f;
        
        [Tooltip("Puntos de patrulla para el movimiento perpetuo.")]
        [SerializeField] private Transform[] waypoints; 
        public Transform[] Waypoints => waypoints; // Propiedad pública para los Estados
        

        [Header("Instintos Base")]
        [Tooltip("Transform del jugador para el Olfato")]
        [SerializeField] private Transform transformJugador;
        [Tooltip("Distancia a la que el enemigo mata instantáneamente")]
        [SerializeField] private float distanciaOlfato = 1.5f;

        /* LÓGICA DE MÁQUINA DE ESTADOS e OPTIMIZACIÓN (CACHING) */
        private IEstado _estadoActual; 
        
        // Cacheamos las instancias de los estados para evitar asignaciones de memoria (GC Allocations)
        private IEstado _estadoRastreo;

        [Header("Reloj de Recuperación")]
        // Contador de segundos para llegar al minuto de enfriamiento
        private float _cronometroSesentaSeg = 0f;
        
        // Guardamos el nivel de fase actual (1, 2, 3...) para pasárselo al SO en el Tick
        private int _nivelMiedoActual = 1;

        /* * *
         * MÉTODO: Start
         * Se ejecuta al nacer. Configuramos los estados cacheando referencias y el estado inicial.
         */
        private void Start()
        {
            if (!data) return; // Si no hay datos sal de la función.
            
            // Verificación y asignación automática de componentes obligatorios
            if (!agent) agent = GetComponent<NavMeshAgent>();
            if (!agent) Debug.LogError("EnemyBrain: Falta el componente NavMeshAgent.");
            if (!transformJugador) Debug.LogError("EnemyBrain: Falta asignar el Transform del Jugador para el Olfato.");

            // Suscripción al SO
            data.OnSubirFase += HandleSubirFase;
            data.OnBajarFase += HandleBajarFase;
                
            // OPTIMIZACIÓN: Instanciamos los estados una sola vez en el inicio
            _estadoRastreo = new EstadoRastreo(this);
            
            // ESTADO INICIAL: Iniciamos usando la referencia cacheada
            CambiarEstado(_estadoRastreo);
        }

        /* * *
         * MÉTODO: Update
         * Ejecución por frame. Mantenemos el pulso de los relojes y la máquina de estados.
         */
        private void Update()
        {
            if (!data) return;

            // 1. CONDICIÓN GLOBAL (OLFATO): Instinto base primario
            if (transformJugador != null && Vector3.Distance(transform.position, transformJugador.position) <= distanciaOlfato)
            {
                EjecutarMuertePorOlfato();
                return;
            }

            // 2. Manejamos el tiempo para el enfriamiento de 60s
            ManejarCronometroRecuperacion();
            
            // 3. EJECUCIÓN DEL ESTADO: El estado controla la lógica en este frame
            _estadoActual?.Ejecutar(); 
        }

        private void EjecutarMuertePorOlfato()
        {
            Debug.Log("<color=red>¡JUGADOR ASESINADO POR OLFATO! Reiniciando escena...</color>");
            
            // Detenemos el movimiento físico inmediatamente
            if (agent != null && agent.isOnNavMesh)
            {
                agent.isStopped = true;
            }

            // Reiniciamos la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        /* * *
         * MÉTODO: ActualizarVelocidad
         * Función pública para que los ESTADOS puedan cambiar la velocidad del NavMeshAgent.
         */
        public void ActualizarVelocidad(float nuevaVelocidad)
        {
            velocidadBase = nuevaVelocidad;
            if (agent != null)
            {
                agent.speed = nuevaVelocidad;
            }
        }

        /* * *
         * MÉTODO: MoverHacia
         * Función pública para que los ESTADOS ordenen el destino al NavMeshAgent.
         */
        public void MoverHacia(Vector3 destino)
        {
            if (agent != null && agent.isOnNavMesh)
            {
                agent.SetDestination(destino);
            }
        }

        /* * *
         * MÉTODO: CambiarEstado
         * Transición limpia de estados reutilizando referencias existentes.
         */
        public void CambiarEstado(IEstado nuevoEstado)
        {
            _estadoActual?.Salir();
            _estadoActual = nuevoEstado;
            _estadoActual.Entrar();
        }

        /* * *
         * MÉTODO: ManejarCronometroRecuperacion
         * Controla el enfriamiento por Ticks.
         */
        private void ManejarCronometroRecuperacion()
        {
            _cronometroSesentaSeg += Time.deltaTime;

            if (_cronometroSesentaSeg >= 60f)
            {
                data.EjecutarTickDeRecuperacion(_nivelMiedoActual);
                _cronometroSesentaSeg = 0f;
            }
        }

        // --- MANEJADORES DE EVENTOS ---

        private void HandleSubirFase()
        {
            _nivelMiedoActual++;
            Debug.Log($"<color=orange>RADIO: El enemigo subió al Nivel {_nivelMiedoActual}</color>");
            // Nota: Aquí se cambiará al estado correspondiente cacheado en el futuro
        }

        private void HandleBajarFase()
        {
            _nivelMiedoActual = Mathf.Max(1, _nivelMiedoActual - 1);
            
            // Si bajamos al nivel base, volvemos a usar la referencia cacheada de Rastreo
            if (_nivelMiedoActual == 1) CambiarEstado(_estadoRastreo);
            
            Debug.Log($"<color=cyan>RADIO: El enemigo bajó al Nivel {_nivelMiedoActual}</color>");
        }

        /* * *
         * MÉTODO DE LIMPIEZA: OnDestroy
         * Se ejecuta si matamos al enemigo o cambiamos de escena.
         * Desconecta los cables de radio para no causar errores de memoria.
         */
        private void OnDestroy()
        {
            if (data != null)
            {
                data.OnSubirFase -= HandleSubirFase;
                data.OnBajarFase -= HandleBajarFase;
            }
        }
    }
}

================
File: Assets/_Scripts/Brains/EnemyBrain.cs.meta
================
fileFormatVersion: 2
guid: b77e2e2cc7ca00869a4c6a7f5fdec407
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Enums/GameEnums.cs
================
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

================
File: Assets/_Scripts/Enums/GameEnums.cs.meta
================
fileFormatVersion: 2
guid: fb065a7cb5b86aa16b992024e4b2ebe3
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Interfaces/IEstado.cs
================
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

================
File: Assets/_Scripts/Interfaces/IEstado.cs.meta
================
fileFormatVersion: 2
guid: e5d047912590d7e4b9600b764ea14d79
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Player/PlayerController.cs
================
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

================
File: Assets/_Scripts/Player/PlayerController.cs.meta
================
fileFormatVersion: 2
guid: c1eee615680ccbe52b6f4f2f11720b2b
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Player/PlayerFear.cs
================
// -----------------------------------------------------------------------------
//  PlayerFear.cs
//  Se suscribe a la "radio" del IntuicionSystem y ajusta el movimiento del
//  jugador basándose en los niveles de miedo del enemigo.
//  Este script DEBE estar adjunto al mismo GameObject que tiene el PlayerController 
//  (por ejemplo, la cápsula del jugador).
// -----------------------------------------------------------------------------
using UnityEngine;

namespace _Scripts.Player
{
    // Garantiza de forma segura que el GameObject tenga un PlayerController.
    // Si no existe, Unity lo añadirá automáticamente para evitar errores de referencia nula en tiempo de ejecución.
    [RequireComponent(typeof(PlayerController))]
    public class PlayerFear : MonoBehaviour
    {
        [Header("Intuicion System (Data Asset)")]
        [Tooltip("Asigna aquí el ScriptableObject de IntuicionSystem que utiliza el EnemyBrain.")]
        [SerializeField] private _Scripts.Systems.IntuicionSystem intuicionSystem;

        // Referencia interna al controlador de movimiento del jugador.
        private PlayerController playerController;
        
        // Nivel de miedo actual del jugador. Rango: 0 (calma total) hasta 4 (terror absoluto).
        private int fearLevel = 0; 
        
        // Límite máximo del nivel de miedo. Corresponde a un factor de 0.8 (80% de penalización de velocidad).
        private const int MaxFearLevel = 4; 

        /// <summary>
        /// Awake se ejecuta al cargar la instancia del script, antes de que empiece el juego.
        /// Ideal para inicializar y capturar componentes internos de forma optimizada sin usar GameObject.Find.
        /// </summary>
        private void Awake()
        {
            // Cacheamos el componente PlayerController que está en este mismo objeto.
            playerController = GetComponent<PlayerController>();
        }

        /// <summary>
        /// Se activa automáticamente cada vez que el objeto se habilita en la escena.
        /// Aquí nos "sintonizamos" a la radio del sistema de intuición (Eventos).
        /// </summary>
        private void OnEnable()
        {
            // Verificación de seguridad por si olvidaste arrastrar el ScriptableObject en el Inspector.
            if (intuicionSystem != null)
            {
                // Nos suscribimos a los eventos. Cuando la IA suba o baje de fase,
                // este script se enterará inmediatamente de forma asíncrona.
                intuicionSystem.OnSubirFase += HandleSubirFase;
                intuicionSystem.OnBajarFase += HandleBajarFase;
            }
        }

        /// <summary>
        /// Se activa automáticamente cuando el objeto se deshabilita o se destruye.
        /// CRUCIAL: Siempre hay que desvincular los eventos para evitar fugas de memoria (Memory Leaks).
        /// </summary>
        private void OnDisable()
        {
            if (intuicionSystem != null)
            {
                // Nos desuscribimos de los eventos para limpiar las referencias en memoria.
                intuicionSystem.OnSubirFase -= HandleSubirFase;
                intuicionSystem.OnBajarFase -= HandleBajarFase;
            }
        }

        /// <summary>
        /// Método manejador que se ejecuta automáticamente cuando el sistema avisa que el enemigo subió de fase.
        /// </summary>
        private void HandleSubirFase()
        {
            // Incrementamos el miedo en 1, pero usamos Mathf.Clamp para asegurar 
            // que matemáticamente nunca supere el MaxFearLevel (4) ni baje de 0.
            fearLevel = Mathf.Clamp(fearLevel + 1, 0, MaxFearLevel);
            
            // Recalculamos y aplicamos el peso del terror al jugador.
            ApplyFearPenalty();
        }

        /// <summary>
        /// Método manejador que se ejecuta automáticamente cuando el sistema avisa que el enemigo bajó de fase (se enfrió).
        /// </summary>
        private void HandleBajarFase()
        {
            // Decrementamos el miedo en 1, manteniendo el valor protegido entre 0 y 4.
            fearLevel = Mathf.Clamp(fearLevel - 1, 0, MaxFearLevel);
            
            // Recalculamos y aplicamos el peso del terror al jugador.
            ApplyFearPenalty();
        }

        /// <summary>
        /// Traduce el nivel de miedo entero (0 a 4) en un porcentaje decimal de penalización física 
        /// y se lo inyecta al PlayerController.
        /// </summary>
        private void ApplyFearPenalty()
        {
            // Control de daños: Si por alguna razón el script se rompió o no tiene el controlador, cancela la ejecución.
            if (playerController == null) return;
            
            // EXPLICACIÓN MATEMÁTICA DEL FACTOR:
            // 1. (float)fearLevel de la línea inferior convierte el entero a float para permitir divisiones decimales exactas.
            // 2. Se divide entre MaxFearLevel (4) para obtener un porcentaje normalizado de 0.0 a 1.0.
            // 3. Se multiplica por 0.8f para escalar ese porcentaje a un rango final de 0.0 a 0.8.
            // Ejemplos de resultado según la fase:
            // - Miedo 0: (0 / 4) * 0.8 = 0.0  -> 0% de reducción (Velocidad normal).
            // - Miedo 1: (1 / 4) * 0.8 = 0.2  -> 20% de reducción.
            // - Miedo 2: (2 / 4) * 0.8 = 0.4  -> 40% de reducción.
            // - Miedo 3: (3 / 4) * 0.8 = 0.6  -> 60% de reducción.
            // - Miedo 4: (4 / 4) * 0.8 = 0.8  -> 80% de reducción (El jugador apenas puede arrastrarse del susto).
            float factor = (float)fearLevel / MaxFearLevel * 0.8f;
            
            // Le enviamos este factor limpio al PlayerController para que reste velocidad o altere el movimiento.
            playerController.AplicarPenalizacionMiedo(factor);
        }
    }
}

================
File: Assets/_Scripts/Player/PlayerFear.cs.meta
================
fileFormatVersion: 2
guid: 4843a5be6ad200c6dbcd89cb895ad484
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Player/PlayerNoise.cs
================
using UnityEngine;
using _Scripts.Systems; // Para ver el IntuicionSystem
using _Scripts.Enums;   // Para ver el PerfilAcustico

namespace _Scripts.Player
{
    /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
     * CLASE: PlayerNoise (El Generador de Pulsos)
     * Se encarga de medir el tiempo entre pasos, reproducir el audio 
     * local para asustar al jugador humano, y enviar el "Paquete de Datos"
     * matemático al cerebro del enemigo.
     * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
    public class PlayerNoise : MonoBehaviour
    {
        [Header("Comunicaciones (Los Cables)")]
        [Tooltip("El 'buzón' central donde dejaremos el paquete de ruido")]
        /*Oye, en este espacio solo se pueden guardar cosas que tengan la estructura de IntuicionSystem
         dataIntuicion es solo un puntero inalambrico*/
        [SerializeField] private IntuicionSystem dataIntuicion; 
        
        [Tooltip("El cuerpo del enemigo para poder calcular a cuántos metros estamos")]
        [SerializeField] private Transform transformEnemigo;

        [Header("Configuración de Audio Físico")]
        [Tooltip("El parlante que reproducirá los .wav en los pies/boca del jugador")]
        [SerializeField] private AudioSource emisorDeSonido;
        
        [Tooltip("Audios para cuando el jugador va lento/agachado")]
        [SerializeField] private AudioClip audioSusurro; 
        
        [Tooltip("Audios para cuando el jugador camina normal")]
        [SerializeField] private AudioClip audioPasoNormal;
        
        [Tooltip("Audios para cuando el jugador corre asustado")]
        [SerializeField] private AudioClip audioGritoSusto;

        // --- EL ETIQUETADOR DE ESTADOS ---
        // Este enum local nos dice qué está haciendo el jugador AHORA MISMO.
        // Más adelante, el script de movimiento cambiará esta variable automáticamente.
        public enum EstadoMovimiento { Quieto, Agachado, Caminando, Corriendo }
        
        [Header("Estado Actual (Pruebas)")]
        [Tooltip("Cambia esto en Unity mientras juegas para probar los distintos ruidos")]
        public EstadoMovimiento estadoActual = EstadoMovimiento.Quieto;

        // El segundero que cuenta el tiempo entre un paso y otro
        private float _cronometroPulso = 0f;

        private void Start()
        {
            // Cláusulas de salvaguarda: Avisamos si olvidaste conectar algo en el Inspector
            if (!dataIntuicion) Debug.LogError("PlayerNoise: Falta conectar el IntuicionSystem.");
            if (!transformEnemigo) Debug.LogError("PlayerNoise: Falta el Transform del Enemigo.");
            if (!emisorDeSonido) Debug.LogError("PlayerNoise: Falta el AudioSource.");
        }

        private void Update()
        {
            // Si falta el buzón de datos, no hacemos nada, para, evitar que el juego explote
            if (!dataIntuicion || !transformEnemigo) return;

            // 1. EL RELOJ: Definimos qué tan rápido late el pulso según el estado
            float tiempoEntrePulsos = 0f;

            switch (estadoActual)
            {
                case EstadoMovimiento.Quieto: 
                    _cronometroPulso = 0f; // Reseteamos el reloj
                    return; // Salimos del Update, no hay ruido que hacer
                
                case EstadoMovimiento.Agachado: 
                    tiempoEntrePulsos = 1.2f; // Un pulso lento (mucho espacio entre pasos)
                    break;
                
                case EstadoMovimiento.Caminando: 
                    tiempoEntrePulsos = 0.7f; // Un pulso normal
                    break;
                
                case EstadoMovimiento.Corriendo: 
                    tiempoEntrePulsos = 0.3f; // Un pulso rapidísimo (pasos acelerados)
                    break;
            }

            // 2. EL SEGUNDERO AVANZA
            _cronometroPulso += Time.deltaTime;

            // 3. EL DISPARO
            if (_cronometroPulso >= tiempoEntrePulsos)
            {
                EmitirRuidoDelPulso();
                _cronometroPulso = 0f; // Vaciamos el reloj para empezar a contar el siguiente paso
            }
        }

        /* * *
         * MÉTODO: EmitirRuidoDelPulso
         * Se ejecuta solo en el frame exacto en el que el pie toca el suelo.
         * Prepara el paquete, reproduce el .wav y lo envía por correo.
         */
        // ReSharper disable Unity.PerformanceAnalysis
        private void EmitirRuidoDelPulso()
        {
            // A. Calculamos la distancia real en metros usando trigonometría de Unity
            float distanciaAlEnemigo = Vector3.Distance(transform.position, transformEnemigo.position);

            // B. Preparamos las variables que meteremos en el paquete
            float volumenPaquete = 0f;
            PerfilAcustico perfilPaquete = PerfilAcustico.GraveFisico; // Por defecto
            AudioClip clipFalsoParaHumano = null;

            // C. Rellenamos el paquete según el estado
            switch (estadoActual)
            {
                case EstadoMovimiento.Agachado:
                    volumenPaquete = 0.1f; // Muy bajito
                    perfilPaquete = PerfilAcustico.AgudoVocal; // Un susurro que se apaga rápido en la distancia
                    clipFalsoParaHumano = audioSusurro;
                    break;

                case EstadoMovimiento.Caminando:
                    volumenPaquete = 0.3f; // Medio
                    perfilPaquete = PerfilAcustico.GraveFisico; // Un paso que hace vibrar el suelo
                    clipFalsoParaHumano = audioPasoNormal;
                    break;

                case EstadoMovimiento.Corriendo:
                    volumenPaquete = 0.8f; // Escandaloso
                    perfilPaquete = PerfilAcustico.AgudoVocal; // Un grito/jadeo de pánico
                    clipFalsoParaHumano = audioGritoSusto;
                    break;
            }

            // D. LA MAGIA: Actualizamos la posición sospechosa...
            dataIntuicion.posicionSospechosa = transform.position;
            
            // ... Y enviamos el paquete matemático al IntuicionSystem
            // ¡Fíjate cómo usamos el Enum aquí como una etiqueta de envío!
            dataIntuicion.ModificarIntuicion(volumenPaquete, distanciaAlEnemigo, perfilPaquete);

            // E. EL TEATRO: Reproducimos el archivo .wav real para asustar al jugador
            if (emisorDeSonido && clipFalsoParaHumano)
            {
                emisorDeSonido.PlayOneShot(clipFalsoParaHumano);
            }
            
            // Un log para que tú como desarrollador veas que el pulso salió bien
            Debug.Log($"<color=yellow>PULSO: {estadoActual} | Vol: {volumenPaquete} | Perfil: {perfilPaquete} | Dist: {distanciaAlEnemigo:F1}m</color>");
        }
    }
}

================
File: Assets/_Scripts/Player/PlayerNoise.cs.meta
================
fileFormatVersion: 2
guid: d5caa585a553b6effba1868091a906e7
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/States/EstadoRastreo.cs
================
using UnityEngine;
using _Scripts.Interfaces;
using _Scripts.Brains;

namespace _Scripts.States
{
    /* * ESTADO: RASTREO (FASE 1)
     * El enemigo patrulla tranquilamente entre waypoints usando NavMeshAgent.
     * Es el estado más "ciego" y lento.
     */
    public class EstadoRastreo : IEstado
    {
        private readonly EnemyBrain _brain;
        private readonly float _velocidadRastreo = 2.5f;
        
        private int _indexWaypointActual = 0;
        private Vector3 _ultimoDestinoAsignado;
        private bool _iniciando = true;

        // El constructor nos permite recibir la referencia del cerebro
        public EstadoRastreo(EnemyBrain brain)
        {
            _brain = brain;
        }

        public void Entrar()
        {
            Debug.Log("<color=green>Enemigo entrando en fase de RASTREO.</color>");
            _brain.ActualizarVelocidad(_velocidadRastreo);
            _ultimoDestinoAsignado = Vector3.zero;
            _iniciando = true;
        }

        public void Ejecutar()
        {
            // 1. Aseguramos que la velocidad actual del agente sea la de rastreo
            _brain.ActualizarVelocidad(_velocidadRastreo);

            Vector3 destinoObjetivo;
            bool esSospecha = _brain.Data.IntuicionActual > 0.2f;

            if (esSospecha)
            {
                // Si la intuición es alta, vamos a investigar la posición sospechosa
                destinoObjetivo = _brain.Data.posicionSospechosa;
            }
            else
            {
                // Si no, volvemos a la patrulla normal
                if (_brain.Waypoints == null || _brain.Waypoints.Length == 0) return;
                destinoObjetivo = _brain.Waypoints[_indexWaypointActual].position;
            }

            // 2. OPTIMIZACIÓN CRÍTICA: Solo llamamos a SetDestination si el destino ha cambiado.
            // Si llamamos a SetDestination en cada frame (Update), el agente recalcula la ruta infinitamente y se queda quieto.
            if (_iniciando || Vector3.Distance(_ultimoDestinoAsignado, destinoObjetivo) > 0.1f)
            {
                _brain.MoverHacia(destinoObjetivo);
                _ultimoDestinoAsignado = destinoObjetivo;
                _iniciando = false;
            }

            // 3. CAMBIO DE WAYPOINT: Si estamos patrullando y llegamos físicamente cerca del punto, avanzamos
            if (!esSospecha)
            {
                float distanciaFisica = Vector3.Distance(_brain.transform.position, destinoObjetivo);
                if (distanciaFisica < 0.8f)
                {
                    _indexWaypointActual = (_indexWaypointActual + 1) % _brain.Waypoints.Length;
                }
            }
        }

        public void Exit() // Cumple la interfaz si requiere Salir en español
        {
            Salir();
        }

        public void Salir()
        {
            Debug.Log("Saliendo de RASTREO: El enemigo ha cambiado de estado.");
        }
    }
}

================
File: Assets/_Scripts/States/EstadoRastreo.cs.meta
================
fileFormatVersion: 2
guid: a62626fab6c135c59a7a83b148b7ef96
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Systems/Data_Enemigo_Principal.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: dd938d6e69397d316ba85446da156fb1, type: 3}
  m_Name: Data_Enemigo_Principal
  m_EditorClassIdentifier: 
  intuicionActual: 0
  posicionSospechosa: {x: 0, y: 0, z: 0}

================
File: Assets/_Scripts/Systems/Data_Enemigo_Principal.asset.meta
================
fileFormatVersion: 2
guid: 8e2d73a2e10bd0101bd926c29d0b153b
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 11400000
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Systems/IntuicionSystem.cs
================
using UnityEngine;
using System; // Necesario para usar los "Eventos" (La Radio)

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DICCIONARIO ACÚSTICO
 * Lo definimos aquí para que cualquier objeto del juego pueda
 * "etiquetar" su ruido antes de enviarlo al sistema.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
namespace _Scripts.Enums
{
    public enum PerfilAcustico
    {
        AgudoVocal, // Gritos, susurros, cristales rotos (Se ahogan rápido con la distancia)
        GraveFisico // Pasos pesados, muebles cayendo (Viajan lejos por el suelo/estructura)
    }
}

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * EL CORAZÓN DE DATOS (SISTEMA DE INTUICIÓN)
 * Actúa como un Analizador de Frecuencias Básico. Recibe paquetes 
 * de sonido, calcula su impacto real y alerta al enemigo.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
namespace _Scripts.Systems
{
    [CreateAssetMenu(fileName = "NuevaIntuicion", menuName = "Sistema/Intuicion Data")]
    public class IntuicionSystem : ScriptableObject
    {
        [Header("Datos de la Fase (Escala 0.0 a 1.0)")]
        [Tooltip("El medidor de peligro de la fase actual")]
        [SerializeField] private float intuicionActual = 0f;
        public float IntuicionActual => intuicionActual;

        [Header("Memoria de Posición")]
        [Tooltip("Última posición global donde se originó un ruido válido")]
        public Vector3 posicionSospechosa;

        // EVENTOS ("La Radio"): Avisan al enemigo cuando debe cambiar de fase
        public event Action OnSubirFase;
        public event Action OnBajarFase;

        /* * *
         * MÉTODO PARA SUBIR: LA PUERTA DE ENTRADA DEL RUIDO
         * Recibe el "Paquete de Sonido" (Volumen, Distancia y Tipo) y 
         * decide cuánto asusta realmente al monstruo.
         */
        // ReSharper disable Unity.PerformanceAnalysis
        public void ModificarIntuicion(float volumenOriginal, float distanciaAlMonstruo, _Scripts.Enums.PerfilAcustico perfil)
        {
            // Esta variable guardará el ruido final después de calcular la distancia
            float incrementoFinal = 0f;

            // 1. FILTRO MATEMÁTICO DE FRECUENCIAS (La magia del sonido)
            switch (perfil)
            { 
                case _Scripts.Enums.PerfilAcustico.AgudoVocal:
                    // REGLA AGUDA: Multiplicamos la distancia x 2.0
                    // Si el monstruo está a 10m, el divisor será 20. El sonido se vuelve diminuto muy rápido.
                    incrementoFinal = volumenOriginal / Mathf.Max(distanciaAlMonstruo * 2.0f, 0.1f);
                    break;

                case _Scripts.Enums.PerfilAcustico.GraveFisico:
                    // REGLA GRAVE: Multiplicamos la distancia x 0.3 (La reducimos)
                    // Si el monstruo está a 10m, el divisor será solo 3. La vibración llega casi intacta.
                    incrementoFinal = volumenOriginal / Mathf.Max(distanciaAlMonstruo * 0.3f, 0.1f);
                    break;
            }

            // 2. REGLA DEL 75% (Zona de Gracia)
            // Si el monstruo ya está muy alterado (>0.75), los ruidos le afectan 3 veces menos.
            // Así le damos al jugador una micro-oportunidad de escapar antes de pasar a Persecución.
            if (intuicionActual >= 0.75f && incrementoFinal > 0)
            {
                intuicionActual += (incrementoFinal / 3f);
            }
            else
            {
                intuicionActual += incrementoFinal;
            }

            // 3. REGLA DE CASCADA (SUBIDA)
            // Si el vaso se derrama, gritamos por la radio para que el EnemyBrain suba de fase.
            if (!(intuicionActual >= 1.0f)) return;
            intuicionActual = 0f; // Vaciamos el vaso para el nuevo nivel
            OnSubirFase?.Invoke(); // El '?' asegura que no haya error si nadie escucha
        }

        /* * *
         * TICK DE RECUPERACIÓN (Llamado por el EnemyBrain cada 60s)
         * Reduce el miedo con el tiempo. Es más difícil calmarlo en niveles altos.
         */
        public void EjecutarTickDeRecuperacion(int miedoLevel)
        {
            // FÓRMULA: Reducción = Intuición Actual * (1/3 * 1/Miedo)
            float factorEnfriamiento = (1f / 3f) * (1f / miedoLevel);
            float cantidadARestar = intuicionActual * factorEnfriamiento;

            intuicionActual -= cantidadARestar;

            // REGLA DE CASCADA (BAJADA)
            if (intuicionActual <= 0f)
            {
                // REGALO AL JUGADOR: Si el monstruo se calma y baja de fase, 
                // la nueva fase empieza en 0.7 (70%) en lugar de 1.0. No se olvida de ti del todo.
                intuicionActual = 0.7f; 
                OnBajarFase?.Invoke(); 
            }

            // Mantenemos el número entre 0.0 y 1.0 por seguridad del motor
            intuicionActual = Mathf.Clamp01(intuicionActual);
        }
    }
}

================
File: Assets/_Scripts/Systems/IntuicionSystem.cs.meta
================
fileFormatVersion: 2
guid: dd938d6e69397d316ba85446da156fb1
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/UI/UI_MenuManager.cs
================
using _Scripts.Player;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
// LINEA NUEVA: Permite al script tener acceso directo a las herramientas de cámara de Cinemachine
using Cinemachine;

namespace _Scripts.UI
{
    // Asegura que este script inicialice después de los componentes base del juego para evitar NullReference
    [DefaultExecutionOrder(100)]
    public class UI_MenuManager : MonoBehaviour
    {
        // Enums: Una lista de estados lógicos excluyentes. El juego solo puede estar en UNO de estos a la vez.
        private enum MenuState
        {
            Gameplay,
            MenuAbierto
        }

        [Header("Input (Assets/Input/PlayerControls)")]
        [Tooltip("El contenedor de mapas de control (.inputactions) de nuestro proyecto")]
        [SerializeField]
        private InputActionAsset inputActionAsset;

        [Header("UI")] [Tooltip("El objeto raíz de la interfaz que contiene los botones")] [SerializeField]
        private GameObject menuPanel;

        [SerializeField] private TextMeshProUGUI tituloTexto;
        [SerializeField] private TextMeshProUGUI botonPrincipalTexto;

        [Header("Jugador")]
        [Tooltip("Referencia al script que controla el movimiento físico de nuestro personaje")]
        [SerializeField]
        private PlayerController playerController;

        [Header("Configuración de Cámara (Cinemachine)")]
        [Tooltip("Arrastra aquí tu Virtual Camera de Cinemachine para congelar la rotación del mouse en las pausas")]
        [SerializeField]
        private CinemachineInputProvider cameraProvider;

        [SerializeField] private CinemachineVirtualCamera virtualCamera; // <-- Cambiamos el tipo aquí
        private CinemachinePOV cameraPov; // Ahora es privado, no se arrastra

        // Cache de componentes de control para evitar búsquedas repetitivas en cada frame (Ahorro de CPU)
        private InputActionMap _gameplayMap;
        private InputActionMap _uiMap;
        private InputAction _pauseAction;
        private InputAction _unpauseAction;

        // Estado actual del menú diegético (P alterna Gameplay ↔ MenuAbierto).
        private MenuState _estado = MenuState.Gameplay;

        // Constantes: Textos fijos que no van a cambiar durante la ejecución del código
        private const string TituloMenu = "Soporte";
        private const string TextoCerrar = "Cerrar";

        private void Awake()
        {
            // Validación de seguridad: Si olvidaste arrastrar los controles en el inspector, el script se apaga solo
            if (inputActionAsset == null)
            {
                Debug.LogError("UI_MenuManager: Asigna el InputActionAsset PlayerControls en el Inspector.");
                enabled = false;
                return;
            }

            if (virtualCamera != null)
            {
                // Esto extrae el módulo interno POV de la cámara virtual
                cameraPov = virtualCamera.GetCinemachineComponent<CinemachinePOV>();

                if (cameraProvider == null)
                    cameraProvider = virtualCamera.GetComponent<CinemachineInputProvider>();
            }

            // 1. Buscamos y vinculamos los Action Maps definidos en tu archivo de inputs
            _gameplayMap = inputActionAsset.FindActionMap("Gameplay", true);
            _uiMap = inputActionAsset.FindActionMap("UI", true);

            // 2. Buscamos las acciones específicas mapeadas a la tecla P
            _pauseAction = _gameplayMap.FindAction("Pause", true);
            _unpauseAction = _uiMap.FindAction("Unpause", true);

            // 3. SUSCRIPCIÓN: Conectamos físicamente las acciones a nuestras funciones de C#
            _pauseAction.performed += OnPausePerformed;
            _unpauseAction.performed += OnUnpausePerformed;

            // Búsqueda automática: Si no arrastraste el script del jugador, lo intenta buscar en la escena por sí mismo
            if (playerController == null)
                playerController = FindObjectOfType<PlayerController>();

            if (cameraProvider == null)
                cameraProvider = FindObjectOfType<CinemachineInputProvider>();

            if (cameraPov == null && cameraProvider != null)
                cameraPov = cameraProvider.GetComponentInChildren<CinemachinePOV>();
        }

        private void Start()
        {
            EntrarModoGameplay();
        }

        private void OnDestroy()
        {
            // BUENA PRÁCTICA: Rompemos la conexión con los eventos al destruir el objeto para evitar bugs de memoria
            if (_pauseAction != null)
                _pauseAction.performed -= OnPausePerformed;
            if (_unpauseAction != null)
                _unpauseAction.performed -= OnUnpausePerformed;
        }

        // --- MÉTODOS PÚBLICOS PARA LOS BOTONES (EVENTOS ONCLICK) ---

        public void OnClickJugarOReanudar()
        {
            if (_estado == MenuState.MenuAbierto)
                EntrarModoGameplay();
        }

        public void OnClickSalir()
        {
            // Compilación condicional: Detiene el juego de forma correcta según el entorno
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Detiene el Play Mode dentro de Unity
#else
            Application.Quit(); // Cierra la aplicación ejecutable (.exe o binario de Linux)
#endif
        }

        // --- RESPUESTAS A LOS INPUTS FÍSICOS (TECLA P) ---

        private void OnPausePerformed(InputAction.CallbackContext context)
        {
            // Filtro de seguridad: Si la acción no se completó o no estamos jugando, ignora el teclazo
            if (!context.performed || _estado != MenuState.Gameplay)
                return;

            EntrarModoMenuAbierto();
        }

        private void OnUnpausePerformed(InputAction.CallbackContext context)
        {
            if (!context.performed || _estado != MenuState.MenuAbierto)
                return;

            EntrarModoGameplay();
        }

        // --- MANEJADORES DE ESTADO (MÁQUINA DE ESTADOS) ---

        private void EntrarModoGameplay()
        {
            _estado = MenuState.Gameplay;

            MostrarMenu(false);
            ConfigurarCursor(false);
            ActivarMapaGameplay();
            ConfigurarJugador(true);
            ConfigurarCamara(true);
        }

        private void EntrarModoMenuAbierto()
        {
            _estado = MenuState.MenuAbierto;

            MostrarMenu(true);
            ConfigurarTextos(TituloMenu, TextoCerrar);
            ConfigurarCursor(true);
            ActivarMapaUI();
            ConfigurarJugador(false);
            ConfigurarCamara(false);
        }

        // --- SUB-FUNCIONES AUXILIARES DE CONFIGURACIÓN ---

        private void ActivarMapaUI()
        {
            _gameplayMap.Disable(); // Desactiva el mapa de juego (WASD deja de responder instantáneamente)
            _uiMap.Enable(); // Activa el mapa de UI (Permite que funcione la tecla Unpause)
        }

        private void ActivarMapaGameplay()
        {
            _uiMap.Disable(); // Desactiva el mapa de UI
            _gameplayMap.Enable(); // Activa el mapa de juego activo
        }

        private void MostrarMenu(bool visible)
        {
            if (menuPanel != null)
                menuPanel.SetActive(visible); // Enciende o apaga el GameObject completo en la jerarquía
        }

        private void ConfigurarTextos(string titulo, string botonPrincipal)
        {
            if (tituloTexto != null)
                tituloTexto.text = titulo;
            if (botonPrincipalTexto != null)
                botonPrincipalTexto.text = botonPrincipal;
        }

        private static void ConfigurarCursor(bool menuActivo)
        {
            // Si el menú está activo, el cursor se libera. Si no, se bloquea al centro de la pantalla.
            Cursor.lockState = menuActivo ? CursorLockMode.None : CursorLockMode.Locked;
            Cursor.visible = menuActivo; // Alterna la visibilidad del puntero gráfico
        }

        private void ConfigurarJugador(bool activo)
        {
            if (playerController != null)
                playerController.SetControlBlocked(!activo);
        }

        private void ConfigurarCamara(bool activo)
        {
            if (cameraProvider != null)
                cameraProvider.enabled = activo;

            if (cameraPov == null)
                return;

            var horizontal = cameraPov.m_HorizontalAxis;
            horizontal.m_InputAxisValue = 0f;
            cameraPov.m_HorizontalAxis = horizontal;

            var vertical = cameraPov.m_VerticalAxis;
            vertical.m_InputAxisValue = 0f;
            cameraPov.m_VerticalAxis = vertical;

            if (activo && Mouse.current != null)
                InputSystem.ResetDevice(Mouse.current);
        }
    }
}

================
File: Assets/_Scripts/UI/UI_MenuManager.cs.meta
================
fileFormatVersion: 2
guid: be633adea2560e14ca0c51c9142b2d13
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Brains.meta
================
fileFormatVersion: 2
guid: 4d4a0201a8835fa32a433ffce65a2862
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Enums.meta
================
fileFormatVersion: 2
guid: cc8f08fa2dd7c05e9abb5d8c71ae83e2
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Interfaces.meta
================
fileFormatVersion: 2
guid: 9f60ab6e60e1d32afac3f16f305d8876
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Player.meta
================
fileFormatVersion: 2
guid: 50a3df36d58deaa1d880127a6e0d3790
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/States.meta
================
fileFormatVersion: 2
guid: b1777e4094e5a2613b3c8dca3de80620
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Systems.meta
================
fileFormatVersion: 2
guid: 03f6ec4b10f469479b868dda3f2d5686
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/UI.meta
================
fileFormatVersion: 2
guid: b86c2fceb38c5d14e9bc94187f263959
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Art/Material/New Material.mat
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 8
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: New Material
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_Parent: {fileID: 0}
  m_ModifiedSerializedProperties: 0
  m_ValidKeywords: []
  m_InvalidKeywords: []
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_LockedProperties: 
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Ints: []
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0.5
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.33404577, g: 0.735849, b: 0.16313633, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}
  m_BuildTextureStacks: []

================
File: Assets/Art/Material/New Material.mat.meta
================
fileFormatVersion: 2
guid: a2fb724e44cf9471098c3d22f47cec3f
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 2100000
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Art/Material.meta
================
fileFormatVersion: 2
guid: 167a659b0331fb1fb9135714edd098b3
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Input/PlayerControls.cs
================
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.14.2
//     from Assets/Input/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

/// <summary>
/// Provides programmatic access to <see cref="InputActionAsset" />, <see cref="InputActionMap" />, <see cref="InputAction" /> and <see cref="InputControlScheme" /> instances defined in asset "Assets/Input/PlayerControls.inputactions".
/// </summary>
/// <remarks>
/// This class is source generated and any manual edits will be discarded if the associated asset is reimported or modified.
/// </remarks>
/// <example>
/// <code>
/// using namespace UnityEngine;
/// using UnityEngine.InputSystem;
///
/// // Example of using an InputActionMap named "Player" from a UnityEngine.MonoBehaviour implementing callback interface.
/// public class Example : MonoBehaviour, MyActions.IPlayerActions
/// {
///     private MyActions_Actions m_Actions;                  // Source code representation of asset.
///     private MyActions_Actions.PlayerActions m_Player;     // Source code representation of action map.
///
///     void Awake()
///     {
///         m_Actions = new MyActions_Actions();              // Create asset object.
///         m_Player = m_Actions.Player;                      // Extract action map object.
///         m_Player.AddCallbacks(this);                      // Register callback interface IPlayerActions.
///     }
///
///     void OnDestroy()
///     {
///         m_Actions.Dispose();                              // Destroy asset object.
///     }
///
///     void OnEnable()
///     {
///         m_Player.Enable();                                // Enable all actions within map.
///     }
///
///     void OnDisable()
///     {
///         m_Player.Disable();                               // Disable all actions within map.
///     }
///
///     #region Interface implementation of MyActions.IPlayerActions
///
///     // Invoked when "Move" action is either started, performed or canceled.
///     public void OnMove(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnMove: {context.ReadValue&lt;Vector2&gt;()}");
///     }
///
///     // Invoked when "Attack" action is either started, performed or canceled.
///     public void OnAttack(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnAttack: {context.ReadValue&lt;float&gt;()}");
///     }
///
///     #endregion
/// }
/// </code>
/// </example>
public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    /// <summary>
    /// Provides access to the underlying asset instance.
    /// </summary>
    public InputActionAsset asset { get; }

    /// <summary>
    /// Constructs a new instance.
    /// </summary>
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""version"": 1,
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""7abfd263-bb92-434a-a6e1-384bbda27d16"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9c18749d-7a66-4e7c-a1f1-fd577b715664"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""eb10d26d-9ee2-4ae3-9e82-8874a4c3e951"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""9c4689f5-077d-4e7b-a95f-e7990376191c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""afeb5324-c85c-4351-bd99-5d6703cdb2af"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""ae16035a-5f2b-41de-a7f3-cb7b3d469034"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fa8f4d5d-a1bb-490e-9f42-760d0b8b0da7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a662e232-7817-4fbe-81c8-95daa41d475e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5114778e-34cb-4c5b-8508-c3b7d0706900"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b35f0a8f-0fe1-4b56-9e31-453e95fe1794"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""405aa2a3-f408-47d6-ba6f-b9d19c015576"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""efc3f80b-b584-4a72-9d00-4cb97d2cd1c9"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7aff7f1f-414f-47d6-a334-fedd5f7e544f"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1064827c-1861-4165-ab61-3cdd244c9d32"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""355006be-f334-47af-834a-315147fdb808"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""ca338fad-e951-45db-b139-b0296a2f9796"",
            ""actions"": [
                {
                    ""name"": ""Unpause"",
                    ""type"": ""Button"",
                    ""id"": ""550a9331-cb76-441c-9cdb-d002470bcb2b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4f82ebaa-9a03-4b18-898a-ba952e7c7bea"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Unpause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Sprint = m_Gameplay.FindAction("Sprint", throwIfNotFound: true);
        m_Gameplay_Crouch = m_Gameplay.FindAction("Crouch", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
        m_Gameplay_Look = m_Gameplay.FindAction("Look", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Unpause = m_UI.FindAction("Unpause", throwIfNotFound: true);
    }

    ~@PlayerControls()
    {
        UnityEngine.Debug.Assert(!m_Gameplay.enabled, "This will cause a leak and performance issues, PlayerControls.Gameplay.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_UI.enabled, "This will cause a leak and performance issues, PlayerControls.UI.Disable() has not been called.");
    }

    /// <summary>
    /// Destroys this asset and all associated <see cref="InputAction"/> instances.
    /// </summary>
    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindingMask" />
    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.devices" />
    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.controlSchemes" />
    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Contains(InputAction)" />
    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.GetEnumerator()" />
    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    /// <inheritdoc cref="IEnumerable.GetEnumerator()" />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Enable()" />
    public void Enable()
    {
        asset.Enable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Disable()" />
    public void Disable()
    {
        asset.Disable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindings" />
    public IEnumerable<InputBinding> bindings => asset.bindings;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindAction(string, bool)" />
    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindBinding(InputBinding, out InputAction)" />
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Sprint;
    private readonly InputAction m_Gameplay_Crouch;
    private readonly InputAction m_Gameplay_Pause;
    private readonly InputAction m_Gameplay_Look;
    /// <summary>
    /// Provides access to input actions defined in input action map "Gameplay".
    /// </summary>
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Move".
        /// </summary>
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Sprint".
        /// </summary>
        public InputAction @Sprint => m_Wrapper.m_Gameplay_Sprint;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Crouch".
        /// </summary>
        public InputAction @Crouch => m_Wrapper.m_Gameplay_Crouch;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Pause".
        /// </summary>
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Look".
        /// </summary>
        public InputAction @Look => m_Wrapper.m_Gameplay_Look;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="GameplayActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="GameplayActions" />
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @Crouch.started += instance.OnCrouch;
            @Crouch.performed += instance.OnCrouch;
            @Crouch.canceled += instance.OnCrouch;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="GameplayActions" />
        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @Crouch.started -= instance.OnCrouch;
            @Crouch.performed -= instance.OnCrouch;
            @Crouch.canceled -= instance.OnCrouch;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />.
        /// </summary>
        /// <seealso cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />
        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="GameplayActions.AddCallbacks(IGameplayActions)" />
        /// <seealso cref="GameplayActions.RemoveCallbacks(IGameplayActions)" />
        /// <seealso cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />
        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="GameplayActions" /> instance referencing this action map.
    /// </summary>
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_Unpause;
    /// <summary>
    /// Provides access to input actions defined in input action map "UI".
    /// </summary>
    public struct UIActions
    {
        private @PlayerControls m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public UIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "UI/Unpause".
        /// </summary>
        public InputAction @Unpause => m_Wrapper.m_UI_Unpause;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="UIActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="UIActions" />
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @Unpause.started += instance.OnUnpause;
            @Unpause.performed += instance.OnUnpause;
            @Unpause.canceled += instance.OnUnpause;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="UIActions" />
        private void UnregisterCallbacks(IUIActions instance)
        {
            @Unpause.started -= instance.OnUnpause;
            @Unpause.performed -= instance.OnUnpause;
            @Unpause.canceled -= instance.OnUnpause;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="UIActions.UnregisterCallbacks(IUIActions)" />.
        /// </summary>
        /// <seealso cref="UIActions.UnregisterCallbacks(IUIActions)" />
        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="UIActions.AddCallbacks(IUIActions)" />
        /// <seealso cref="UIActions.RemoveCallbacks(IUIActions)" />
        /// <seealso cref="UIActions.UnregisterCallbacks(IUIActions)" />
        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="UIActions" /> instance referencing this action map.
    /// </summary>
    public UIActions @UI => new UIActions(this);
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "Gameplay" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="GameplayActions.AddCallbacks(IGameplayActions)" />
    /// <seealso cref="GameplayActions.RemoveCallbacks(IGameplayActions)" />
    public interface IGameplayActions
    {
        /// <summary>
        /// Method invoked when associated input action "Move" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnMove(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Sprint" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnSprint(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Crouch" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnCrouch(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Pause" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPause(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Look" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnLook(InputAction.CallbackContext context);
    }
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "UI" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="UIActions.AddCallbacks(IUIActions)" />
    /// <seealso cref="UIActions.RemoveCallbacks(IUIActions)" />
    public interface IUIActions
    {
        /// <summary>
        /// Method invoked when associated input action "Unpause" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnUnpause(InputAction.CallbackContext context);
    }
}

================
File: Assets/Input/PlayerControls.cs.meta
================
fileFormatVersion: 2
guid: c328b888a7ec9dab287555920201b737
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Input/PlayerControls.inputactions
================
{
    "version": 1,
    "name": "PlayerControls",
    "maps": [
        {
            "name": "Gameplay",
            "id": "7abfd263-bb92-434a-a6e1-384bbda27d16",
            "actions": [
                {
                    "name": "Move",
                    "type": "Value",
                    "id": "9c18749d-7a66-4e7c-a1f1-fd577b715664",
                    "expectedControlType": "Vector2",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": true
                },
                {
                    "name": "Sprint",
                    "type": "Button",
                    "id": "eb10d26d-9ee2-4ae3-9e82-8874a4c3e951",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Crouch",
                    "type": "Button",
                    "id": "9c4689f5-077d-4e7b-a95f-e7990376191c",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Pause",
                    "type": "Button",
                    "id": "afeb5324-c85c-4351-bd99-5d6703cdb2af",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Look",
                    "type": "Value",
                    "id": "ae16035a-5f2b-41de-a7f3-cb7b3d469034",
                    "expectedControlType": "Vector2",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": true
                }
            ],
            "bindings": [
                {
                    "name": "2D Vector",
                    "id": "fa8f4d5d-a1bb-490e-9f42-760d0b8b0da7",
                    "path": "2DVector",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "up",
                    "id": "a662e232-7817-4fbe-81c8-95daa41d475e",
                    "path": "<Keyboard>/w",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "down",
                    "id": "5114778e-34cb-4c5b-8508-c3b7d0706900",
                    "path": "<Keyboard>/s",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "left",
                    "id": "b35f0a8f-0fe1-4b56-9e31-453e95fe1794",
                    "path": "<Keyboard>/a",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "right",
                    "id": "405aa2a3-f408-47d6-ba6f-b9d19c015576",
                    "path": "<Keyboard>/d",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "",
                    "id": "efc3f80b-b584-4a72-9d00-4cb97d2cd1c9",
                    "path": "<XInputController>/leftTrigger",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Sprint",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "7aff7f1f-414f-47d6-a334-fedd5f7e544f",
                    "path": "<XInputController>/leftStick/down",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Crouch",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "1064827c-1861-4165-ab61-3cdd244c9d32",
                    "path": "<Keyboard>/p",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Pause",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "355006be-f334-47af-834a-315147fdb808",
                    "path": "<Mouse>/delta",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Look",
                    "isComposite": false,
                    "isPartOfComposite": false
                }
            ]
        },
        {
            "name": "UI",
            "id": "ca338fad-e951-45db-b139-b0296a2f9796",
            "actions": [
                {
                    "name": "Unpause",
                    "type": "Button",
                    "id": "550a9331-cb76-441c-9cdb-d002470bcb2b",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                }
            ],
            "bindings": [
                {
                    "name": "",
                    "id": "4f82ebaa-9a03-4b18-898a-ba952e7c7bea",
                    "path": "<Keyboard>/p",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Unpause",
                    "isComposite": false,
                    "isPartOfComposite": false
                }
            ]
        }
    ],
    "controlSchemes": []
}

================
File: Assets/Input/PlayerControls.inputactions.meta
================
fileFormatVersion: 2
guid: 5e2296452dc258735bf427a4404e4af0
ScriptedImporter:
  internalIDToNameTable: []
  externalObjects: {}
  serializedVersion: 2
  userData: 
  assetBundleName: 
  assetBundleVariant: 
  script: {fileID: 11500000, guid: 8404be70184654265930450def6a9037, type: 3}
  generateWrapperCode: 1
  wrapperCodePath: 
  wrapperClassName: 
  wrapperCodeNamespace:

================
File: Assets/Scenes/Catacumbas/NavMesh-NavMesh Manager.asset.meta
================
fileFormatVersion: 2
guid: a8ef8db4876e183d0b1115166c5e9d8d
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 23800000
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Scenes/Catacumbas.meta
================
fileFormatVersion: 2
guid: d2f039929018535fc8a556e61edec348
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Scenes/Catacumbas.unity.meta
================
fileFormatVersion: 2
guid: b9ba936afff67f09f8d3b1c54550ad34
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Sounds/Player/caminata.wav.meta
================
fileFormatVersion: 2
guid: 6f07fc5c44e12b773b6ec4a155e6ae7c
AudioImporter:
  externalObjects: {}
  serializedVersion: 7
  defaultSettings:
    serializedVersion: 2
    loadType: 0
    sampleRateSetting: 0
    sampleRateOverride: 44100
    compressionFormat: 1
    quality: 1
    conversionMode: 0
    preloadAudioData: 0
  platformSettingOverrides: {}
  forceToMono: 0
  normalize: 1
  loadInBackground: 0
  ambisonic: 0
  3D: 1
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Sounds/Player/grito.wav.meta
================
fileFormatVersion: 2
guid: f0a9db96aa8068c7682df3950e6a55b8
AudioImporter:
  externalObjects: {}
  serializedVersion: 7
  defaultSettings:
    serializedVersion: 2
    loadType: 0
    sampleRateSetting: 0
    sampleRateOverride: 44100
    compressionFormat: 1
    quality: 1
    conversionMode: 0
    preloadAudioData: 0
  platformSettingOverrides: {}
  forceToMono: 0
  normalize: 1
  loadInBackground: 0
  ambisonic: 0
  3D: 1
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Sounds/Player/susurro.wav.meta
================
fileFormatVersion: 2
guid: e0019f101d7b58e26ac288a24bf0c122
AudioImporter:
  externalObjects: {}
  serializedVersion: 7
  defaultSettings:
    serializedVersion: 2
    loadType: 0
    sampleRateSetting: 0
    sampleRateOverride: 44100
    compressionFormat: 1
    quality: 1
    conversionMode: 0
    preloadAudioData: 0
  platformSettingOverrides: {}
  forceToMono: 0
  normalize: 1
  loadInBackground: 0
  ambisonic: 0
  3D: 1
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Sounds/Player.meta
================
fileFormatVersion: 2
guid: d5bb672078e8ee172b9b2ec818129e46
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts.meta
================
fileFormatVersion: 2
guid: 963f125796fb29e41b5491699d6b5b47
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Art.meta
================
fileFormatVersion: 2
guid: d1e981140701cea83b402c6def1f2119
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Input.meta
================
fileFormatVersion: 2
guid: 77c5b9aba54d783c58629202f1bfe7b2
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Scenes.meta
================
fileFormatVersion: 2
guid: 879fc5a1263e83a6f852097b7099d190
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Sounds.meta
================
fileFormatVersion: 2
guid: 8d2dc47ded6f49736b1a9e45de3005be
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/TextMesh Pro.meta
================
fileFormatVersion: 2
guid: f54d1bd14bd3ca042bd867b519fee8cc
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Packages/manifest.json
================
{
  "dependencies": {
    "com.coplaydev.unity-mcp": "https://github.com/CoplayDev/unity-mcp.git?path=/MCPForUnity#main",
    "com.unity.ai.navigation": "1.1.7",
    "com.unity.cinemachine": "2.10.7",
    "com.unity.ide.rider": "3.0.40",
    "com.unity.inputsystem": "1.14.2",
    "com.unity.textmeshpro": "3.0.9",
    "com.unity.toolchain.linux-x86_64": "2.0.11",
    "com.unity.modules.ai": "1.0.0",
    "com.unity.modules.androidjni": "1.0.0",
    "com.unity.modules.animation": "1.0.0",
    "com.unity.modules.assetbundle": "1.0.0",
    "com.unity.modules.audio": "1.0.0",
    "com.unity.modules.cloth": "1.0.0",
    "com.unity.modules.director": "1.0.0",
    "com.unity.modules.imageconversion": "1.0.0",
    "com.unity.modules.imgui": "1.0.0",
    "com.unity.modules.jsonserialize": "1.0.0",
    "com.unity.modules.particlesystem": "1.0.0",
    "com.unity.modules.physics": "1.0.0",
    "com.unity.modules.physics2d": "1.0.0",
    "com.unity.modules.screencapture": "1.0.0",
    "com.unity.modules.terrain": "1.0.0",
    "com.unity.modules.terrainphysics": "1.0.0",
    "com.unity.modules.tilemap": "1.0.0",
    "com.unity.modules.ui": "1.0.0",
    "com.unity.modules.uielements": "1.0.0",
    "com.unity.modules.umbra": "1.0.0",
    "com.unity.modules.unityanalytics": "1.0.0",
    "com.unity.modules.unitywebrequest": "1.0.0",
    "com.unity.modules.unitywebrequestassetbundle": "1.0.0",
    "com.unity.modules.unitywebrequestaudio": "1.0.0",
    "com.unity.modules.unitywebrequesttexture": "1.0.0",
    "com.unity.modules.unitywebrequestwww": "1.0.0",
    "com.unity.modules.vehicles": "1.0.0",
    "com.unity.modules.video": "1.0.0",
    "com.unity.modules.vr": "1.0.0",
    "com.unity.modules.wind": "1.0.0",
    "com.unity.modules.xr": "1.0.0"
  }
}

================
File: Packages/packages-lock.json
================
{
  "dependencies": {
    "com.coplaydev.unity-mcp": {
      "version": "https://github.com/CoplayDev/unity-mcp.git?path=/MCPForUnity#main",
      "depth": 0,
      "source": "git",
      "dependencies": {
        "com.unity.modules.animation": "1.0.0",
        "com.unity.modules.imageconversion": "1.0.0",
        "com.unity.modules.physics": "1.0.0",
        "com.unity.modules.physics2d": "1.0.0",
        "com.unity.modules.uielements": "1.0.0",
        "com.unity.modules.screencapture": "1.0.0",
        "com.unity.modules.unitywebrequest": "1.0.0",
        "com.unity.nuget.newtonsoft-json": "3.0.2",
        "com.unity.test-framework": "1.1.31"
      },
      "hash": "85c101f5329ec1b0c6f70cba44614166dd78f53c"
    },
    "com.unity.ai.navigation": {
      "version": "1.1.7",
      "depth": 0,
      "source": "registry",
      "dependencies": {
        "com.unity.modules.ai": "1.0.0"
      },
      "url": "https://packages.unity.com"
    },
    "com.unity.cinemachine": {
      "version": "2.10.7",
      "depth": 0,
      "source": "registry",
      "dependencies": {
        "com.unity.test-framework": "1.1.31"
      },
      "url": "https://packages.unity.com"
    },
    "com.unity.ext.nunit": {
      "version": "1.0.6",
      "depth": 1,
      "source": "registry",
      "dependencies": {},
      "url": "https://packages.unity.com"
    },
    "com.unity.ide.rider": {
      "version": "3.0.40",
      "depth": 0,
      "source": "registry",
      "dependencies": {
        "com.unity.ext.nunit": "1.0.6"
      },
      "url": "https://packages.unity.com"
    },
    "com.unity.inputsystem": {
      "version": "1.14.2",
      "depth": 0,
      "source": "registry",
      "dependencies": {
        "com.unity.modules.uielements": "1.0.0"
      },
      "url": "https://packages.unity.com"
    },
    "com.unity.nuget.newtonsoft-json": {
      "version": "3.2.1",
      "depth": 1,
      "source": "registry",
      "dependencies": {},
      "url": "https://packages.unity.com"
    },
    "com.unity.sysroot": {
      "version": "2.0.10",
      "depth": 1,
      "source": "registry",
      "dependencies": {},
      "url": "https://packages.unity.com"
    },
    "com.unity.sysroot.linux-x86_64": {
      "version": "2.0.9",
      "depth": 1,
      "source": "registry",
      "dependencies": {
        "com.unity.sysroot": "2.0.10"
      },
      "url": "https://packages.unity.com"
    },
    "com.unity.test-framework": {
      "version": "1.1.33",
      "depth": 1,
      "source": "registry",
      "dependencies": {
        "com.unity.ext.nunit": "1.0.6",
        "com.unity.modules.imgui": "1.0.0",
        "com.unity.modules.jsonserialize": "1.0.0"
      },
      "url": "https://packages.unity.com"
    },
    "com.unity.textmeshpro": {
      "version": "3.0.9",
      "depth": 0,
      "source": "registry",
      "dependencies": {
        "com.unity.ugui": "1.0.0"
      },
      "url": "https://packages.unity.com"
    },
    "com.unity.toolchain.linux-x86_64": {
      "version": "2.0.11",
      "depth": 0,
      "source": "registry",
      "dependencies": {
        "com.unity.sysroot": "2.0.10",
        "com.unity.sysroot.linux-x86_64": "2.0.9"
      },
      "url": "https://packages.unity.com"
    },
    "com.unity.ugui": {
      "version": "1.0.0",
      "depth": 1,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.ui": "1.0.0",
        "com.unity.modules.imgui": "1.0.0"
      }
    },
    "com.unity.modules.ai": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.androidjni": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.animation": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.assetbundle": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.audio": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.cloth": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.physics": "1.0.0"
      }
    },
    "com.unity.modules.director": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.audio": "1.0.0",
        "com.unity.modules.animation": "1.0.0"
      }
    },
    "com.unity.modules.imageconversion": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.imgui": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.jsonserialize": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.particlesystem": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.physics": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.physics2d": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.screencapture": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.imageconversion": "1.0.0"
      }
    },
    "com.unity.modules.subsystems": {
      "version": "1.0.0",
      "depth": 1,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.jsonserialize": "1.0.0"
      }
    },
    "com.unity.modules.terrain": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.terrainphysics": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.physics": "1.0.0",
        "com.unity.modules.terrain": "1.0.0"
      }
    },
    "com.unity.modules.tilemap": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.physics2d": "1.0.0"
      }
    },
    "com.unity.modules.ui": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.uielements": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.ui": "1.0.0",
        "com.unity.modules.imgui": "1.0.0",
        "com.unity.modules.jsonserialize": "1.0.0"
      }
    },
    "com.unity.modules.umbra": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.unityanalytics": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.unitywebrequest": "1.0.0",
        "com.unity.modules.jsonserialize": "1.0.0"
      }
    },
    "com.unity.modules.unitywebrequest": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.unitywebrequestassetbundle": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.assetbundle": "1.0.0",
        "com.unity.modules.unitywebrequest": "1.0.0"
      }
    },
    "com.unity.modules.unitywebrequestaudio": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.unitywebrequest": "1.0.0",
        "com.unity.modules.audio": "1.0.0"
      }
    },
    "com.unity.modules.unitywebrequesttexture": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.unitywebrequest": "1.0.0",
        "com.unity.modules.imageconversion": "1.0.0"
      }
    },
    "com.unity.modules.unitywebrequestwww": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.unitywebrequest": "1.0.0",
        "com.unity.modules.unitywebrequestassetbundle": "1.0.0",
        "com.unity.modules.unitywebrequestaudio": "1.0.0",
        "com.unity.modules.audio": "1.0.0",
        "com.unity.modules.assetbundle": "1.0.0",
        "com.unity.modules.imageconversion": "1.0.0"
      }
    },
    "com.unity.modules.vehicles": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.physics": "1.0.0"
      }
    },
    "com.unity.modules.video": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.audio": "1.0.0",
        "com.unity.modules.ui": "1.0.0",
        "com.unity.modules.unitywebrequest": "1.0.0"
      }
    },
    "com.unity.modules.vr": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.jsonserialize": "1.0.0",
        "com.unity.modules.physics": "1.0.0",
        "com.unity.modules.xr": "1.0.0"
      }
    },
    "com.unity.modules.wind": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.xr": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.physics": "1.0.0",
        "com.unity.modules.jsonserialize": "1.0.0",
        "com.unity.modules.subsystems": "1.0.0"
      }
    }
  }
}

================
File: ProjectSettings/AudioManager.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!11 &1
AudioManager:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  m_Volume: 1
  Rolloff Scale: 1
  Doppler Factor: 1
  Default Speaker Mode: 2
  m_SampleRate: 0
  m_DSPBufferSize: 1024
  m_VirtualVoiceCount: 512
  m_RealVoiceCount: 32
  m_EnableOutputSuspension: 1
  m_SpatializerPlugin: 
  m_AmbisonicDecoderPlugin: 
  m_DisableAudio: 0
  m_VirtualizeEffects: 1
  m_RequestedDSPBufferSize: 0

================
File: ProjectSettings/ClusterInputManager.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!236 &1
ClusterInputManager:
  m_ObjectHideFlags: 0
  m_Inputs: []

================
File: ProjectSettings/DynamicsManager.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!55 &1
PhysicsManager:
  m_ObjectHideFlags: 0
  serializedVersion: 14
  m_Gravity: {x: 0, y: -9.81, z: 0}
  m_DefaultMaterial: {fileID: 0}
  m_BounceThreshold: 2
  m_DefaultMaxDepenetrationVelocity: 10
  m_SleepThreshold: 0.005
  m_DefaultContactOffset: 0.01
  m_DefaultSolverIterations: 6
  m_DefaultSolverVelocityIterations: 1
  m_QueriesHitBackfaces: 0
  m_QueriesHitTriggers: 1
  m_EnableAdaptiveForce: 0
  m_ClothInterCollisionDistance: 0.1
  m_ClothInterCollisionStiffness: 0.2
  m_ContactsGeneration: 1
  m_LayerCollisionMatrix: ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
  m_SimulationMode: 0
  m_AutoSyncTransforms: 0
  m_ReuseCollisionCallbacks: 0
  m_InvokeCollisionCallbacks: 1
  m_ClothInterCollisionSettingsToggle: 0
  m_ClothGravity: {x: 0, y: -9.81, z: 0}
  m_ContactPairsMode: 0
  m_BroadphaseType: 0
  m_WorldBounds:
    m_Center: {x: 0, y: 0, z: 0}
    m_Extent: {x: 250, y: 250, z: 250}
  m_WorldSubdivisions: 8
  m_FrictionType: 0
  m_EnableEnhancedDeterminism: 0
  m_EnableUnifiedHeightmaps: 1
  m_ImprovedPatchFriction: 0
  m_SolverType: 0
  m_DefaultMaxAngularSpeed: 50
  m_FastMotionThreshold: 3.4028235e+38

================
File: ProjectSettings/EditorBuildSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1045 &1
EditorBuildSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  m_Scenes: []
  m_configObjects: {}

================
File: ProjectSettings/EditorSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!159 &1
EditorSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 12
  m_SerializationMode: 2
  m_LineEndingsForNewScripts: 1
  m_DefaultBehaviorMode: 0
  m_PrefabRegularEnvironment: {fileID: 0}
  m_PrefabUIEnvironment: {fileID: 0}
  m_SpritePackerMode: 0
  m_SpritePackerCacheSize: 10
  m_SpritePackerPaddingPower: 1
  m_Bc7TextureCompressor: 0
  m_EtcTextureCompressorBehavior: 1
  m_EtcTextureFastCompressor: 1
  m_EtcTextureNormalCompressor: 2
  m_EtcTextureBestCompressor: 4
  m_ProjectGenerationIncludedExtensions: txt;xml;fnt;cd;asmdef;asmref;rsp;java;cpp;c;mm;m;h
  m_ProjectGenerationRootNamespace: 
  m_EnableTextureStreamingInEditMode: 1
  m_EnableTextureStreamingInPlayMode: 1
  m_EnableEditorAsyncCPUTextureLoading: 0
  m_AsyncShaderCompilation: 1
  m_PrefabModeAllowAutoSave: 1
  m_EnterPlayModeOptionsEnabled: 0
  m_EnterPlayModeOptions: 3
  m_GameObjectNamingDigits: 1
  m_GameObjectNamingScheme: 0
  m_AssetNamingUsesSpace: 1
  m_InspectorUseIMGUIDefaultInspector: 0
  m_UseLegacyProbeSampleCount: 0
  m_SerializeInlineMappingsOnOneLine: 1
  m_DisableCookiesInLightmapper: 0
  m_AssetPipelineMode: 1
  m_RefreshImportMode: 0
  m_CacheServerMode: 0
  m_CacheServerEndpoint: 
  m_CacheServerNamespacePrefix: default
  m_CacheServerEnableDownload: 1
  m_CacheServerEnableUpload: 1
  m_CacheServerEnableAuth: 0
  m_CacheServerEnableTls: 0
  m_CacheServerValidationMode: 2
  m_CacheServerDownloadBatchSize: 128
  m_EnableEnlightenBakedGI: 0

================
File: ProjectSettings/GraphicsSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!30 &1
GraphicsSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 15
  m_Deferred:
    m_Mode: 1
    m_Shader: {fileID: 69, guid: 0000000000000000f000000000000000, type: 0}
  m_DeferredReflections:
    m_Mode: 1
    m_Shader: {fileID: 74, guid: 0000000000000000f000000000000000, type: 0}
  m_ScreenSpaceShadows:
    m_Mode: 1
    m_Shader: {fileID: 64, guid: 0000000000000000f000000000000000, type: 0}
  m_DepthNormals:
    m_Mode: 1
    m_Shader: {fileID: 62, guid: 0000000000000000f000000000000000, type: 0}
  m_MotionVectors:
    m_Mode: 1
    m_Shader: {fileID: 75, guid: 0000000000000000f000000000000000, type: 0}
  m_LightHalo:
    m_Mode: 1
    m_Shader: {fileID: 105, guid: 0000000000000000f000000000000000, type: 0}
  m_LensFlare:
    m_Mode: 1
    m_Shader: {fileID: 102, guid: 0000000000000000f000000000000000, type: 0}
  m_VideoShadersIncludeMode: 2
  m_AlwaysIncludedShaders:
  - {fileID: 7, guid: 0000000000000000f000000000000000, type: 0}
  - {fileID: 15104, guid: 0000000000000000f000000000000000, type: 0}
  - {fileID: 15105, guid: 0000000000000000f000000000000000, type: 0}
  - {fileID: 15106, guid: 0000000000000000f000000000000000, type: 0}
  - {fileID: 10753, guid: 0000000000000000f000000000000000, type: 0}
  - {fileID: 10770, guid: 0000000000000000f000000000000000, type: 0}
  - {fileID: 10783, guid: 0000000000000000f000000000000000, type: 0}
  m_PreloadedShaders: []
  m_PreloadShadersBatchTimeLimit: -1
  m_SpritesDefaultMaterial: {fileID: 10754, guid: 0000000000000000f000000000000000, type: 0}
  m_CustomRenderPipeline: {fileID: 0}
  m_TransparencySortMode: 0
  m_TransparencySortAxis: {x: 0, y: 0, z: 1}
  m_DefaultRenderingPath: 1
  m_DefaultMobileRenderingPath: 1
  m_TierSettings: []
  m_LightmapStripping: 0
  m_FogStripping: 0
  m_InstancingStripping: 0
  m_BrgStripping: 0
  m_LightmapKeepPlain: 1
  m_LightmapKeepDirCombined: 1
  m_LightmapKeepDynamicPlain: 1
  m_LightmapKeepDynamicDirCombined: 1
  m_LightmapKeepShadowMask: 1
  m_LightmapKeepSubtractive: 1
  m_FogKeepLinear: 1
  m_FogKeepExp: 1
  m_FogKeepExp2: 1
  m_AlbedoSwatchInfos: []
  m_LightsUseLinearIntensity: 0
  m_LightsUseColorTemperature: 0
  m_DefaultRenderingLayerMask: 1
  m_LogWhenShaderIsCompiled: 0
  m_SRPDefaultSettings: {}
  m_LightProbeOutsideHullStrategy: 1
  m_CameraRelativeLightCulling: 0
  m_CameraRelativeShadowCulling: 0

================
File: ProjectSettings/InputManager.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!13 &1
InputManager:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  m_Axes:
  - serializedVersion: 3
    m_Name: Horizontal
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: left
    positiveButton: right
    altNegativeButton: a
    altPositiveButton: d
    gravity: 3
    dead: 0.001
    sensitivity: 3
    snap: 1
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Vertical
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: down
    positiveButton: up
    altNegativeButton: s
    altPositiveButton: w
    gravity: 3
    dead: 0.001
    sensitivity: 3
    snap: 1
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Fire1
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: left ctrl
    altNegativeButton: 
    altPositiveButton: mouse 0
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Fire2
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: left alt
    altNegativeButton: 
    altPositiveButton: mouse 1
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Fire3
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: left shift
    altNegativeButton: 
    altPositiveButton: mouse 2
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Jump
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: space
    altNegativeButton: 
    altPositiveButton: 
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Mouse X
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: 
    altNegativeButton: 
    altPositiveButton: 
    gravity: 0
    dead: 0
    sensitivity: 0.1
    snap: 0
    invert: 0
    type: 1
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Mouse Y
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: 
    altNegativeButton: 
    altPositiveButton: 
    gravity: 0
    dead: 0
    sensitivity: 0.1
    snap: 0
    invert: 0
    type: 1
    axis: 1
    joyNum: 0
  - serializedVersion: 3
    m_Name: Mouse ScrollWheel
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: 
    altNegativeButton: 
    altPositiveButton: 
    gravity: 0
    dead: 0
    sensitivity: 0.1
    snap: 0
    invert: 0
    type: 1
    axis: 2
    joyNum: 0
  - serializedVersion: 3
    m_Name: Horizontal
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: 
    altNegativeButton: 
    altPositiveButton: 
    gravity: 0
    dead: 0.19
    sensitivity: 1
    snap: 0
    invert: 0
    type: 2
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Vertical
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: 
    altNegativeButton: 
    altPositiveButton: 
    gravity: 0
    dead: 0.19
    sensitivity: 1
    snap: 0
    invert: 1
    type: 2
    axis: 1
    joyNum: 0
  - serializedVersion: 3
    m_Name: Fire1
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: joystick button 0
    altNegativeButton: 
    altPositiveButton: 
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Fire2
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: joystick button 1
    altNegativeButton: 
    altPositiveButton: 
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Fire3
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: joystick button 2
    altNegativeButton: 
    altPositiveButton: 
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Jump
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: joystick button 3
    altNegativeButton: 
    altPositiveButton: 
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Submit
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: return
    altNegativeButton: 
    altPositiveButton: joystick button 0
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Submit
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: enter
    altNegativeButton: 
    altPositiveButton: space
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Cancel
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: escape
    altNegativeButton: 
    altPositiveButton: joystick button 1
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  m_UsePhysicalKeys: 1

================
File: ProjectSettings/MemorySettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!387306366 &1
MemorySettings:
  m_ObjectHideFlags: 0
  m_EditorMemorySettings:
    m_MainAllocatorBlockSize: -1
    m_ThreadAllocatorBlockSize: -1
    m_MainGfxBlockSize: -1
    m_ThreadGfxBlockSize: -1
    m_CacheBlockSize: -1
    m_TypetreeBlockSize: -1
    m_ProfilerBlockSize: -1
    m_ProfilerEditorBlockSize: -1
    m_BucketAllocatorGranularity: -1
    m_BucketAllocatorBucketsCount: -1
    m_BucketAllocatorBlockSize: -1
    m_BucketAllocatorBlockCount: -1
    m_ProfilerBucketAllocatorGranularity: -1
    m_ProfilerBucketAllocatorBucketsCount: -1
    m_ProfilerBucketAllocatorBlockSize: -1
    m_ProfilerBucketAllocatorBlockCount: -1
    m_TempAllocatorSizeMain: -1
    m_JobTempAllocatorBlockSize: -1
    m_BackgroundJobTempAllocatorBlockSize: -1
    m_JobTempAllocatorReducedBlockSize: -1
    m_TempAllocatorSizeGIBakingWorker: -1
    m_TempAllocatorSizeNavMeshWorker: -1
    m_TempAllocatorSizeAudioWorker: -1
    m_TempAllocatorSizeCloudWorker: -1
    m_TempAllocatorSizeGfx: -1
    m_TempAllocatorSizeJobWorker: -1
    m_TempAllocatorSizeBackgroundWorker: -1
    m_TempAllocatorSizePreloadManager: -1
  m_PlatformMemorySettings: {}

================
File: ProjectSettings/NavMeshAreas.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!126 &1
NavMeshProjectSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  areas:
  - name: Walkable
    cost: 1
  - name: Not Walkable
    cost: 1
  - name: Jump
    cost: 2
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  m_LastAgentTypeID: -1372625422
  m_Settings:
  - serializedVersion: 3
    agentTypeID: 0
    agentRadius: 0.5
    agentHeight: 2
    agentSlope: 45
    agentClimb: 0.75
    ledgeDropHeight: 0
    maxJumpAcrossDistance: 0
    minRegionArea: 2
    manualCellSize: 0
    cellSize: 0.16666667
    manualTileSize: 0
    tileSize: 256
    buildHeightMesh: 0
    maxJobWorkers: 0
    preserveTilesOutsideBounds: 0
    debug:
      m_Flags: 0
  m_SettingNames:
  - Humanoid

================
File: ProjectSettings/PackageManagerSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &1
MonoBehaviour:
  m_ObjectHideFlags: 53
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 13964, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_EnablePreReleasePackages: 0
  m_AdvancedSettingsExpanded: 1
  m_ScopedRegistriesSettingsExpanded: 1
  m_SeeAllPackageVersions: 0
  m_DismissPreviewPackagesInUse: 0
  oneTimeWarningShown: 0
  m_Registries:
  - m_Id: main
    m_Name: 
    m_Url: https://packages.unity.com
    m_Scopes: []
    m_IsDefault: 1
    m_Capabilities: 7
    m_ConfigSource: 0
  m_UserSelectedRegistryName: 
  m_UserAddingNewScopedRegistry: 0
  m_RegistryInfoDraft:
    m_Modified: 0
    m_ErrorMessage: 
    m_UserModificationsInstanceId: -888
    m_OriginalInstanceId: -890
  m_LoadAssets: 0

================
File: ProjectSettings/Physics2DSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!19 &1
Physics2DSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 6
  m_Gravity: {x: 0, y: -9.81}
  m_DefaultMaterial: {fileID: 0}
  m_VelocityIterations: 8
  m_PositionIterations: 3
  m_VelocityThreshold: 1
  m_MaxLinearCorrection: 0.2
  m_MaxAngularCorrection: 8
  m_MaxTranslationSpeed: 100
  m_MaxRotationSpeed: 360
  m_BaumgarteScale: 0.2
  m_BaumgarteTimeOfImpactScale: 0.75
  m_TimeToSleep: 0.5
  m_LinearSleepTolerance: 0.01
  m_AngularSleepTolerance: 2
  m_DefaultContactOffset: 0.01
  m_JobOptions:
    serializedVersion: 2
    useMultithreading: 0
    useConsistencySorting: 0
    m_InterpolationPosesPerJob: 100
    m_NewContactsPerJob: 30
    m_CollideContactsPerJob: 100
    m_ClearFlagsPerJob: 200
    m_ClearBodyForcesPerJob: 200
    m_SyncDiscreteFixturesPerJob: 50
    m_SyncContinuousFixturesPerJob: 50
    m_FindNearestContactsPerJob: 100
    m_UpdateTriggerContactsPerJob: 100
    m_IslandSolverCostThreshold: 100
    m_IslandSolverBodyCostScale: 1
    m_IslandSolverContactCostScale: 10
    m_IslandSolverJointCostScale: 10
    m_IslandSolverBodiesPerJob: 50
    m_IslandSolverContactsPerJob: 50
  m_SimulationMode: 0
  m_QueriesHitTriggers: 1
  m_QueriesStartInColliders: 1
  m_CallbacksOnDisable: 1
  m_ReuseCollisionCallbacks: 1
  m_AutoSyncTransforms: 0
  m_GizmoOptions: 10
  m_LayerCollisionMatrix: ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff

================
File: ProjectSettings/PresetManager.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1386491679 &1
PresetManager:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  m_DefaultPresets: {}

================
File: ProjectSettings/ProjectSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!129 &1
PlayerSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 26
  productGUID: 03736164c74b51c748580d8812fc1936
  AndroidProfiler: 0
  AndroidFilterTouchesWhenObscured: 0
  AndroidEnableSustainedPerformanceMode: 0
  defaultScreenOrientation: 4
  targetDevice: 2
  useOnDemandResources: 0
  accelerometerFrequency: 60
  companyName: DefaultCompany
  productName: Prototype_Terror
  defaultCursor: {fileID: 0}
  cursorHotspot: {x: 0, y: 0}
  m_SplashScreenBackgroundColor: {r: 0.12156863, g: 0.12156863, b: 0.1254902, a: 1}
  m_ShowUnitySplashScreen: 1
  m_ShowUnitySplashLogo: 1
  m_SplashScreenOverlayOpacity: 1
  m_SplashScreenAnimation: 1
  m_SplashScreenLogoStyle: 1
  m_SplashScreenDrawMode: 0
  m_SplashScreenBackgroundAnimationZoom: 1
  m_SplashScreenLogoAnimationZoom: 1
  m_SplashScreenBackgroundLandscapeAspect: 1
  m_SplashScreenBackgroundPortraitAspect: 1
  m_SplashScreenBackgroundLandscapeUvs:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1
    height: 1
  m_SplashScreenBackgroundPortraitUvs:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1
    height: 1
  m_SplashScreenLogos: []
  m_VirtualRealitySplashScreen: {fileID: 0}
  m_HolographicTrackingLossScreen: {fileID: 0}
  defaultScreenWidth: 1920
  defaultScreenHeight: 1080
  defaultScreenWidthWeb: 960
  defaultScreenHeightWeb: 600
  m_StereoRenderingPath: 0
  m_ActiveColorSpace: 0
  unsupportedMSAAFallback: 0
  m_SpriteBatchVertexThreshold: 300
  m_MTRendering: 1
  mipStripping: 0
  numberOfMipsStripped: 0
  numberOfMipsStrippedPerMipmapLimitGroup: {}
  m_StackTraceTypes: 010000000100000001000000010000000100000001000000
  iosShowActivityIndicatorOnLoading: -1
  androidShowActivityIndicatorOnLoading: -1
  iosUseCustomAppBackgroundBehavior: 0
  allowedAutorotateToPortrait: 1
  allowedAutorotateToPortraitUpsideDown: 1
  allowedAutorotateToLandscapeRight: 1
  allowedAutorotateToLandscapeLeft: 1
  useOSAutorotation: 1
  use32BitDisplayBuffer: 1
  preserveFramebufferAlpha: 0
  disableDepthAndStencilBuffers: 0
  androidStartInFullscreen: 1
  androidRenderOutsideSafeArea: 1
  androidUseSwappy: 1
  androidBlitType: 0
  androidResizableWindow: 0
  androidDefaultWindowWidth: 1920
  androidDefaultWindowHeight: 1080
  androidMinimumWindowWidth: 400
  androidMinimumWindowHeight: 300
  androidFullscreenMode: 1
  androidAutoRotationBehavior: 1
  androidPredictiveBackSupport: 1
  defaultIsNativeResolution: 1
  macRetinaSupport: 1
  runInBackground: 0
  captureSingleScreen: 0
  muteOtherAudioSources: 0
  Prepare IOS For Recording: 0
  Force IOS Speakers When Recording: 0
  audioSpatialExperience: 0
  deferSystemGesturesMode: 0
  hideHomeButton: 0
  submitAnalytics: 1
  usePlayerLog: 1
  dedicatedServerOptimizations: 0
  bakeCollisionMeshes: 0
  forceSingleInstance: 0
  useFlipModelSwapchain: 1
  resizableWindow: 0
  useMacAppStoreValidation: 0
  macAppStoreCategory: public.app-category.games
  gpuSkinning: 0
  xboxPIXTextureCapture: 0
  xboxEnableAvatar: 0
  xboxEnableKinect: 0
  xboxEnableKinectAutoTracking: 0
  xboxEnableFitness: 0
  visibleInBackground: 1
  allowFullscreenSwitch: 1
  fullscreenMode: 1
  xboxSpeechDB: 0
  xboxEnableHeadOrientation: 0
  xboxEnableGuest: 0
  xboxEnablePIXSampling: 0
  metalFramebufferOnly: 0
  xboxOneResolution: 0
  xboxOneSResolution: 0
  xboxOneXResolution: 3
  xboxOneMonoLoggingLevel: 0
  xboxOneLoggingLevel: 1
  xboxOneDisableEsram: 0
  xboxOneEnableTypeOptimization: 0
  xboxOnePresentImmediateThreshold: 0
  switchQueueCommandMemory: 1048576
  switchQueueControlMemory: 16384
  switchQueueComputeMemory: 262144
  switchNVNShaderPoolsGranularity: 33554432
  switchNVNDefaultPoolsGranularity: 16777216
  switchNVNOtherPoolsGranularity: 16777216
  switchGpuScratchPoolGranularity: 2097152
  switchAllowGpuScratchShrinking: 0
  switchNVNMaxPublicTextureIDCount: 0
  switchNVNMaxPublicSamplerIDCount: 0
  switchNVNGraphicsFirmwareMemory: 32
  switchMaxWorkerMultiple: 8
  stadiaPresentMode: 0
  stadiaTargetFramerate: 0
  vulkanNumSwapchainBuffers: 3
  vulkanEnableSetSRGBWrite: 0
  vulkanEnablePreTransform: 0
  vulkanEnableLateAcquireNextImage: 0
  vulkanEnableCommandBufferRecycling: 1
  loadStoreDebugModeEnabled: 0
  visionOSBundleVersion: 1.0
  tvOSBundleVersion: 1.0
  bundleVersion: 1.0
  preloadedAssets: []
  metroInputSource: 0
  wsaTransparentSwapchain: 0
  m_HolographicPauseOnTrackingLoss: 1
  xboxOneDisableKinectGpuReservation: 1
  xboxOneEnable7thCore: 1
  vrSettings:
    enable360StereoCapture: 0
  isWsaHolographicRemotingEnabled: 0
  enableFrameTimingStats: 0
  enableOpenGLProfilerGPURecorders: 1
  allowHDRDisplaySupport: 0
  useHDRDisplay: 0
  hdrBitDepth: 0
  m_ColorGamuts: 00000000
  targetPixelDensity: 30
  resolutionScalingMode: 0
  resetResolutionOnWindowResize: 0
  androidSupportedAspectRatio: 1
  androidMaxAspectRatio: 2.1
  applicationIdentifier:
    Standalone: com.DefaultCompany.Prototype-Terror
  buildNumber:
    Standalone: 0
    VisionOS: 0
    iPhone: 0
    tvOS: 0
  overrideDefaultApplicationIdentifier: 0
  AndroidBundleVersionCode: 1
  AndroidMinSdkVersion: 22
  AndroidTargetSdkVersion: 0
  AndroidPreferredInstallLocation: 1
  aotOptions: 
  stripEngineCode: 1
  iPhoneStrippingLevel: 0
  iPhoneScriptCallOptimization: 0
  ForceInternetPermission: 0
  ForceSDCardPermission: 0
  CreateWallpaper: 0
  APKExpansionFiles: 0
  keepLoadedShadersAlive: 0
  StripUnusedMeshComponents: 0
  strictShaderVariantMatching: 0
  VertexChannelCompressionMask: 4054
  iPhoneSdkVersion: 988
  iOSSimulatorArchitecture: 0
  iOSTargetOSVersionString: 12.0
  tvOSSdkVersion: 0
  tvOSSimulatorArchitecture: 0
  tvOSRequireExtendedGameController: 0
  tvOSTargetOSVersionString: 12.0
  VisionOSSdkVersion: 0
  VisionOSTargetOSVersionString: 1.0
  uIPrerenderedIcon: 0
  uIRequiresPersistentWiFi: 0
  uIRequiresFullScreen: 1
  uIStatusBarHidden: 1
  uIExitOnSuspend: 0
  uIStatusBarStyle: 0
  appleTVSplashScreen: {fileID: 0}
  appleTVSplashScreen2x: {fileID: 0}
  tvOSSmallIconLayers: []
  tvOSSmallIconLayers2x: []
  tvOSLargeIconLayers: []
  tvOSLargeIconLayers2x: []
  tvOSTopShelfImageLayers: []
  tvOSTopShelfImageLayers2x: []
  tvOSTopShelfImageWideLayers: []
  tvOSTopShelfImageWideLayers2x: []
  iOSLaunchScreenType: 0
  iOSLaunchScreenPortrait: {fileID: 0}
  iOSLaunchScreenLandscape: {fileID: 0}
  iOSLaunchScreenBackgroundColor:
    serializedVersion: 2
    rgba: 0
  iOSLaunchScreenFillPct: 100
  iOSLaunchScreenSize: 100
  iOSLaunchScreenCustomXibPath: 
  iOSLaunchScreeniPadType: 0
  iOSLaunchScreeniPadImage: {fileID: 0}
  iOSLaunchScreeniPadBackgroundColor:
    serializedVersion: 2
    rgba: 0
  iOSLaunchScreeniPadFillPct: 100
  iOSLaunchScreeniPadSize: 100
  iOSLaunchScreeniPadCustomXibPath: 
  iOSLaunchScreenCustomStoryboardPath: 
  iOSLaunchScreeniPadCustomStoryboardPath: 
  iOSDeviceRequirements: []
  iOSURLSchemes: []
  macOSURLSchemes: []
  iOSBackgroundModes: 0
  iOSMetalForceHardShadows: 0
  metalEditorSupport: 1
  metalAPIValidation: 1
  metalCompileShaderBinary: 0
  iOSRenderExtraFrameOnPause: 0
  iosCopyPluginsCodeInsteadOfSymlink: 0
  appleDeveloperTeamID: 
  iOSManualSigningProvisioningProfileID: 
  tvOSManualSigningProvisioningProfileID: 
  VisionOSManualSigningProvisioningProfileID: 
  iOSManualSigningProvisioningProfileType: 0
  tvOSManualSigningProvisioningProfileType: 0
  VisionOSManualSigningProvisioningProfileType: 0
  appleEnableAutomaticSigning: 0
  iOSRequireARKit: 0
  iOSAutomaticallyDetectAndAddCapabilities: 1
  appleEnableProMotion: 0
  shaderPrecisionModel: 0
  clonedFromGUID: 00000000000000000000000000000000
  templatePackageId: 
  templateDefaultScene: 
  useCustomMainManifest: 0
  useCustomLauncherManifest: 0
  useCustomMainGradleTemplate: 0
  useCustomLauncherGradleManifest: 0
  useCustomBaseGradleTemplate: 0
  useCustomGradlePropertiesTemplate: 0
  useCustomGradleSettingsTemplate: 0
  useCustomProguardFile: 0
  AndroidTargetArchitectures: 1
  AndroidTargetDevices: 0
  AndroidSplashScreenScale: 0
  androidSplashScreen: {fileID: 0}
  AndroidKeystoreName: 
  AndroidKeyaliasName: 
  AndroidEnableArmv9SecurityFeatures: 0
  AndroidBuildApkPerCpuArchitecture: 0
  AndroidTVCompatibility: 0
  AndroidIsGame: 1
  AndroidEnableTango: 0
  androidEnableBanner: 1
  androidUseLowAccuracyLocation: 0
  androidUseCustomKeystore: 0
  m_AndroidBanners:
  - width: 320
    height: 180
    banner: {fileID: 0}
  androidGamepadSupportLevel: 0
  chromeosInputEmulation: 1
  AndroidMinifyRelease: 0
  AndroidMinifyDebug: 0
  AndroidValidateAppBundleSize: 1
  AndroidAppBundleSizeToValidate: 200
  m_BuildTargetIcons: []
  m_BuildTargetPlatformIcons: []
  m_BuildTargetBatching: []
  m_BuildTargetShaderSettings: []
  m_BuildTargetGraphicsJobs: []
  m_BuildTargetGraphicsJobMode: []
  m_BuildTargetGraphicsAPIs: []
  m_BuildTargetVRSettings: []
  m_DefaultShaderChunkSizeInMB: 16
  m_DefaultShaderChunkCount: 0
  openGLRequireES31: 0
  openGLRequireES31AEP: 0
  openGLRequireES32: 0
  m_TemplateCustomTags: {}
  mobileMTRendering:
    Android: 1
    VisionOS: 1
    iPhone: 1
    tvOS: 1
  m_BuildTargetGroupLightmapEncodingQuality: []
  m_BuildTargetGroupHDRCubemapEncodingQuality: []
  m_BuildTargetGroupLightmapSettings: []
  m_BuildTargetGroupLoadStoreDebugModeSettings: []
  m_BuildTargetNormalMapEncoding: []
  m_BuildTargetDefaultTextureCompressionFormat: []
  playModeTestRunnerEnabled: 0
  runPlayModeTestAsEditModeTest: 0
  actionOnDotNetUnhandledException: 1
  enableInternalProfiler: 0
  logObjCUncaughtExceptions: 1
  enableCrashReportAPI: 0
  cameraUsageDescription: 
  locationUsageDescription: 
  microphoneUsageDescription: 
  bluetoothUsageDescription: 
  macOSTargetOSVersion: 10.13.0
  switchNMETAOverride: 
  switchNetLibKey: 
  switchSocketMemoryPoolSize: 6144
  switchSocketAllocatorPoolSize: 128
  switchSocketConcurrencyLimit: 14
  switchScreenResolutionBehavior: 2
  switchUseCPUProfiler: 0
  switchEnableFileSystemTrace: 0
  switchLTOSetting: 0
  switchApplicationID: 0x01004b9000490000
  switchNSODependencies: 
  switchCompilerFlags: 
  switchTitleNames_0: 
  switchTitleNames_1: 
  switchTitleNames_2: 
  switchTitleNames_3: 
  switchTitleNames_4: 
  switchTitleNames_5: 
  switchTitleNames_6: 
  switchTitleNames_7: 
  switchTitleNames_8: 
  switchTitleNames_9: 
  switchTitleNames_10: 
  switchTitleNames_11: 
  switchTitleNames_12: 
  switchTitleNames_13: 
  switchTitleNames_14: 
  switchTitleNames_15: 
  switchPublisherNames_0: 
  switchPublisherNames_1: 
  switchPublisherNames_2: 
  switchPublisherNames_3: 
  switchPublisherNames_4: 
  switchPublisherNames_5: 
  switchPublisherNames_6: 
  switchPublisherNames_7: 
  switchPublisherNames_8: 
  switchPublisherNames_9: 
  switchPublisherNames_10: 
  switchPublisherNames_11: 
  switchPublisherNames_12: 
  switchPublisherNames_13: 
  switchPublisherNames_14: 
  switchPublisherNames_15: 
  switchIcons_0: {fileID: 0}
  switchIcons_1: {fileID: 0}
  switchIcons_2: {fileID: 0}
  switchIcons_3: {fileID: 0}
  switchIcons_4: {fileID: 0}
  switchIcons_5: {fileID: 0}
  switchIcons_6: {fileID: 0}
  switchIcons_7: {fileID: 0}
  switchIcons_8: {fileID: 0}
  switchIcons_9: {fileID: 0}
  switchIcons_10: {fileID: 0}
  switchIcons_11: {fileID: 0}
  switchIcons_12: {fileID: 0}
  switchIcons_13: {fileID: 0}
  switchIcons_14: {fileID: 0}
  switchIcons_15: {fileID: 0}
  switchSmallIcons_0: {fileID: 0}
  switchSmallIcons_1: {fileID: 0}
  switchSmallIcons_2: {fileID: 0}
  switchSmallIcons_3: {fileID: 0}
  switchSmallIcons_4: {fileID: 0}
  switchSmallIcons_5: {fileID: 0}
  switchSmallIcons_6: {fileID: 0}
  switchSmallIcons_7: {fileID: 0}
  switchSmallIcons_8: {fileID: 0}
  switchSmallIcons_9: {fileID: 0}
  switchSmallIcons_10: {fileID: 0}
  switchSmallIcons_11: {fileID: 0}
  switchSmallIcons_12: {fileID: 0}
  switchSmallIcons_13: {fileID: 0}
  switchSmallIcons_14: {fileID: 0}
  switchSmallIcons_15: {fileID: 0}
  switchManualHTML: 
  switchAccessibleURLs: 
  switchLegalInformation: 
  switchMainThreadStackSize: 1048576
  switchPresenceGroupId: 
  switchLogoHandling: 0
  switchReleaseVersion: 0
  switchDisplayVersion: 1.0.0
  switchStartupUserAccount: 0
  switchSupportedLanguagesMask: 0
  switchLogoType: 0
  switchApplicationErrorCodeCategory: 
  switchUserAccountSaveDataSize: 0
  switchUserAccountSaveDataJournalSize: 0
  switchApplicationAttribute: 0
  switchCardSpecSize: -1
  switchCardSpecClock: -1
  switchRatingsMask: 0
  switchRatingsInt_0: 0
  switchRatingsInt_1: 0
  switchRatingsInt_2: 0
  switchRatingsInt_3: 0
  switchRatingsInt_4: 0
  switchRatingsInt_5: 0
  switchRatingsInt_6: 0
  switchRatingsInt_7: 0
  switchRatingsInt_8: 0
  switchRatingsInt_9: 0
  switchRatingsInt_10: 0
  switchRatingsInt_11: 0
  switchRatingsInt_12: 0
  switchLocalCommunicationIds_0: 
  switchLocalCommunicationIds_1: 
  switchLocalCommunicationIds_2: 
  switchLocalCommunicationIds_3: 
  switchLocalCommunicationIds_4: 
  switchLocalCommunicationIds_5: 
  switchLocalCommunicationIds_6: 
  switchLocalCommunicationIds_7: 
  switchParentalControl: 0
  switchAllowsScreenshot: 1
  switchAllowsVideoCapturing: 1
  switchAllowsRuntimeAddOnContentInstall: 0
  switchDataLossConfirmation: 0
  switchUserAccountLockEnabled: 0
  switchSystemResourceMemory: 16777216
  switchSupportedNpadStyles: 22
  switchNativeFsCacheSize: 32
  switchIsHoldTypeHorizontal: 1
  switchSupportedNpadCount: 8
  switchEnableTouchScreen: 1
  switchSocketConfigEnabled: 0
  switchTcpInitialSendBufferSize: 32
  switchTcpInitialReceiveBufferSize: 64
  switchTcpAutoSendBufferSizeMax: 256
  switchTcpAutoReceiveBufferSizeMax: 256
  switchUdpSendBufferSize: 9
  switchUdpReceiveBufferSize: 42
  switchSocketBufferEfficiency: 4
  switchSocketInitializeEnabled: 1
  switchNetworkInterfaceManagerInitializeEnabled: 1
  switchDisableHTCSPlayerConnection: 0
  switchUseNewStyleFilepaths: 1
  switchUseLegacyFmodPriorities: 0
  switchUseMicroSleepForYield: 1
  switchEnableRamDiskSupport: 0
  switchMicroSleepForYieldTime: 25
  switchRamDiskSpaceSize: 12
  ps4NPAgeRating: 12
  ps4NPTitleSecret: 
  ps4NPTrophyPackPath: 
  ps4ParentalLevel: 11
  ps4ContentID: ED1633-NPXX51362_00-0000000000000000
  ps4Category: 0
  ps4MasterVersion: 01.00
  ps4AppVersion: 01.00
  ps4AppType: 0
  ps4ParamSfxPath: 
  ps4VideoOutPixelFormat: 0
  ps4VideoOutInitialWidth: 1920
  ps4VideoOutBaseModeInitialWidth: 1920
  ps4VideoOutReprojectionRate: 60
  ps4PronunciationXMLPath: 
  ps4PronunciationSIGPath: 
  ps4BackgroundImagePath: 
  ps4StartupImagePath: 
  ps4StartupImagesFolder: 
  ps4IconImagesFolder: 
  ps4SaveDataImagePath: 
  ps4SdkOverride: 
  ps4BGMPath: 
  ps4ShareFilePath: 
  ps4ShareOverlayImagePath: 
  ps4PrivacyGuardImagePath: 
  ps4ExtraSceSysFile: 
  ps4NPtitleDatPath: 
  ps4RemotePlayKeyAssignment: -1
  ps4RemotePlayKeyMappingDir: 
  ps4PlayTogetherPlayerCount: 0
  ps4EnterButtonAssignment: 2
  ps4ApplicationParam1: 0
  ps4ApplicationParam2: 0
  ps4ApplicationParam3: 0
  ps4ApplicationParam4: 0
  ps4DownloadDataSize: 0
  ps4GarlicHeapSize: 2048
  ps4ProGarlicHeapSize: 2560
  playerPrefsMaxSize: 32768
  ps4Passcode: 4EwVk0C2KFbDdUaCA4zNf7lIpbttlF2n
  ps4pnSessions: 1
  ps4pnPresence: 1
  ps4pnFriends: 1
  ps4pnGameCustomData: 1
  playerPrefsSupport: 0
  enableApplicationExit: 0
  resetTempFolder: 1
  restrictedAudioUsageRights: 0
  ps4UseResolutionFallback: 0
  ps4ReprojectionSupport: 0
  ps4UseAudio3dBackend: 0
  ps4UseLowGarlicFragmentationMode: 1
  ps4SocialScreenEnabled: 0
  ps4ScriptOptimizationLevel: 2
  ps4Audio3dVirtualSpeakerCount: 14
  ps4attribCpuUsage: 0
  ps4PatchPkgPath: 
  ps4PatchLatestPkgPath: 
  ps4PatchChangeinfoPath: 
  ps4PatchDayOne: 0
  ps4attribUserManagement: 0
  ps4attribMoveSupport: 0
  ps4attrib3DSupport: 0
  ps4attribShareSupport: 0
  ps4attribExclusiveVR: 0
  ps4disableAutoHideSplash: 0
  ps4videoRecordingFeaturesUsed: 0
  ps4contentSearchFeaturesUsed: 0
  ps4CompatibilityPS5: 0
  ps4AllowPS5Detection: 0
  ps4GPU800MHz: 1
  ps4attribEyeToEyeDistanceSettingVR: 0
  ps4IncludedModules: []
  ps4attribVROutputEnabled: 0
  monoEnv: 
  splashScreenBackgroundSourceLandscape: {fileID: 0}
  splashScreenBackgroundSourcePortrait: {fileID: 0}
  blurSplashScreenBackground: 1
  spritePackerPolicy: 
  webGLMemorySize: 32
  webGLExceptionSupport: 1
  webGLNameFilesAsHashes: 0
  webGLShowDiagnostics: 0
  webGLDataCaching: 1
  webGLDebugSymbols: 0
  webGLEmscriptenArgs: 
  webGLModulesDirectory: 
  webGLTemplate: APPLICATION:Default
  webGLAnalyzeBuildSize: 0
  webGLUseEmbeddedResources: 0
  webGLCompressionFormat: 1
  webGLWasmArithmeticExceptions: 0
  webGLLinkerTarget: 1
  webGLThreadsSupport: 0
  webGLDecompressionFallback: 0
  webGLInitialMemorySize: 32
  webGLMaximumMemorySize: 2048
  webGLMemoryGrowthMode: 2
  webGLMemoryLinearGrowthStep: 16
  webGLMemoryGeometricGrowthStep: 0.2
  webGLMemoryGeometricGrowthCap: 96
  webGLPowerPreference: 2
  scriptingDefineSymbols: {}
  additionalCompilerArguments: {}
  platformArchitecture: {}
  scriptingBackend: {}
  il2cppCompilerConfiguration: {}
  il2cppCodeGeneration: {}
  managedStrippingLevel: {}
  incrementalIl2cppBuild: {}
  suppressCommonWarnings: 1
  allowUnsafeCode: 0
  useDeterministicCompilation: 1
  additionalIl2CppArgs: 
  scriptingRuntimeVersion: 1
  gcIncremental: 1
  gcWBarrierValidation: 0
  apiCompatibilityLevelPerPlatform: {}
  m_RenderingPath: 1
  m_MobileRenderingPath: 1
  metroPackageName: Prototype_Terror
  metroPackageVersion: 
  metroCertificatePath: 
  metroCertificatePassword: 
  metroCertificateSubject: 
  metroCertificateIssuer: 
  metroCertificateNotAfter: 0000000000000000
  metroApplicationDescription: Prototype_Terror
  wsaImages: {}
  metroTileShortName: 
  metroTileShowName: 0
  metroMediumTileShowName: 0
  metroLargeTileShowName: 0
  metroWideTileShowName: 0
  metroSupportStreamingInstall: 0
  metroLastRequiredScene: 0
  metroDefaultTileSize: 1
  metroTileForegroundText: 2
  metroTileBackgroundColor: {r: 0.13333334, g: 0.17254902, b: 0.21568628, a: 0}
  metroSplashScreenBackgroundColor: {r: 0.12941177, g: 0.17254902, b: 0.21568628, a: 1}
  metroSplashScreenUseBackgroundColor: 0
  syncCapabilities: 0
  platformCapabilities: {}
  metroTargetDeviceFamilies: {}
  metroFTAName: 
  metroFTAFileTypes: []
  metroProtocolName: 
  vcxProjDefaultLanguage: 
  XboxOneProductId: 
  XboxOneUpdateKey: 
  XboxOneSandboxId: 
  XboxOneContentId: 
  XboxOneTitleId: 
  XboxOneSCId: 
  XboxOneGameOsOverridePath: 
  XboxOnePackagingOverridePath: 
  XboxOneAppManifestOverridePath: 
  XboxOneVersion: 1.0.0.0
  XboxOnePackageEncryption: 0
  XboxOnePackageUpdateGranularity: 2
  XboxOneDescription: 
  XboxOneLanguage:
  - enus
  XboxOneCapability: []
  XboxOneGameRating: {}
  XboxOneIsContentPackage: 0
  XboxOneEnhancedXboxCompatibilityMode: 0
  XboxOneEnableGPUVariability: 1
  XboxOneSockets: {}
  XboxOneSplashScreen: {fileID: 0}
  XboxOneAllowedProductIds: []
  XboxOnePersistentLocalStorageSize: 0
  XboxOneXTitleMemory: 8
  XboxOneOverrideIdentityName: 
  XboxOneOverrideIdentityPublisher: 
  vrEditorSettings: {}
  cloudServicesEnabled: {}
  luminIcon:
    m_Name: 
    m_ModelFolderPath: 
    m_PortalFolderPath: 
  luminCert:
    m_CertPath: 
    m_SignPackage: 1
  luminIsChannelApp: 0
  luminVersion:
    m_VersionCode: 1
    m_VersionName: 
  hmiPlayerDataPath: 
  hmiForceSRGBBlit: 1
  embeddedLinuxEnableGamepadInput: 1
  hmiLogStartupTiming: 0
  hmiCpuConfiguration: 
  apiCompatibilityLevel: 6
  activeInputHandler: 1
  windowsGamepadBackendHint: 0
  cloudProjectId: 
  framebufferDepthMemorylessMode: 0
  qualitySettingsNames: []
  projectName: 
  organizationId: 
  cloudEnabled: 0
  legacyClampBlendShapeWeights: 0
  hmiLoadingImage: {fileID: 0}
  platformRequiresReadableAssets: 0
  virtualTexturingSupportEnabled: 0
  insecureHttpOption: 0

================
File: ProjectSettings/ProjectVersion.txt
================
m_EditorVersion: 2022.3.62f3
m_EditorVersionWithRevision: 2022.3.62f3 (96770f904ca7)

================
File: ProjectSettings/QualitySettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!47 &1
QualitySettings:
  m_ObjectHideFlags: 0
  serializedVersion: 5
  m_CurrentQuality: 5
  m_QualitySettings:
  - serializedVersion: 3
    name: Very Low
    pixelLightCount: 0
    shadows: 0
    shadowResolution: 0
    shadowProjection: 1
    shadowCascades: 1
    shadowDistance: 15
    shadowNearPlaneOffset: 3
    shadowCascade2Split: 0.33333334
    shadowCascade4Split: {x: 0.06666667, y: 0.2, z: 0.46666667}
    shadowmaskMode: 0
    skinWeights: 1
    globalTextureMipmapLimit: 1
    textureMipmapLimitSettings: []
    anisotropicTextures: 0
    antiAliasing: 0
    softParticles: 0
    softVegetation: 0
    realtimeReflectionProbes: 0
    billboardsFaceCameraPosition: 0
    useLegacyDetailDistribution: 0
    vSyncCount: 0
    realtimeGICPUUsage: 25
    lodBias: 0.3
    maximumLODLevel: 0
    enableLODCrossFade: 1
    streamingMipmapsActive: 0
    streamingMipmapsAddAllCameras: 1
    streamingMipmapsMemoryBudget: 512
    streamingMipmapsRenderersPerFrame: 512
    streamingMipmapsMaxLevelReduction: 2
    streamingMipmapsMaxFileIORequests: 1024
    particleRaycastBudget: 4
    asyncUploadTimeSlice: 2
    asyncUploadBufferSize: 16
    asyncUploadPersistentBuffer: 1
    resolutionScalingFixedDPIFactor: 1
    customRenderPipeline: {fileID: 0}
    terrainQualityOverrides: 0
    terrainPixelError: 1
    terrainDetailDensityScale: 1
    terrainBasemapDistance: 1000
    terrainDetailDistance: 80
    terrainTreeDistance: 5000
    terrainBillboardStart: 50
    terrainFadeLength: 5
    terrainMaxTrees: 50
    excludedTargetPlatforms: []
  - serializedVersion: 3
    name: Low
    pixelLightCount: 0
    shadows: 0
    shadowResolution: 0
    shadowProjection: 1
    shadowCascades: 1
    shadowDistance: 20
    shadowNearPlaneOffset: 3
    shadowCascade2Split: 0.33333334
    shadowCascade4Split: {x: 0.06666667, y: 0.2, z: 0.46666667}
    shadowmaskMode: 0
    skinWeights: 2
    globalTextureMipmapLimit: 0
    textureMipmapLimitSettings: []
    anisotropicTextures: 0
    antiAliasing: 0
    softParticles: 0
    softVegetation: 0
    realtimeReflectionProbes: 0
    billboardsFaceCameraPosition: 0
    useLegacyDetailDistribution: 0
    vSyncCount: 0
    realtimeGICPUUsage: 25
    lodBias: 0.4
    maximumLODLevel: 0
    enableLODCrossFade: 1
    streamingMipmapsActive: 0
    streamingMipmapsAddAllCameras: 1
    streamingMipmapsMemoryBudget: 512
    streamingMipmapsRenderersPerFrame: 512
    streamingMipmapsMaxLevelReduction: 2
    streamingMipmapsMaxFileIORequests: 1024
    particleRaycastBudget: 16
    asyncUploadTimeSlice: 2
    asyncUploadBufferSize: 16
    asyncUploadPersistentBuffer: 1
    resolutionScalingFixedDPIFactor: 1
    customRenderPipeline: {fileID: 0}
    terrainQualityOverrides: 0
    terrainPixelError: 1
    terrainDetailDensityScale: 1
    terrainBasemapDistance: 1000
    terrainDetailDistance: 80
    terrainTreeDistance: 5000
    terrainBillboardStart: 50
    terrainFadeLength: 5
    terrainMaxTrees: 50
    excludedTargetPlatforms: []
  - serializedVersion: 3
    name: Medium
    pixelLightCount: 1
    shadows: 1
    shadowResolution: 0
    shadowProjection: 1
    shadowCascades: 1
    shadowDistance: 20
    shadowNearPlaneOffset: 3
    shadowCascade2Split: 0.33333334
    shadowCascade4Split: {x: 0.06666667, y: 0.2, z: 0.46666667}
    shadowmaskMode: 0
    skinWeights: 2
    globalTextureMipmapLimit: 0
    textureMipmapLimitSettings: []
    anisotropicTextures: 1
    antiAliasing: 0
    softParticles: 0
    softVegetation: 0
    realtimeReflectionProbes: 0
    billboardsFaceCameraPosition: 0
    useLegacyDetailDistribution: 0
    vSyncCount: 1
    realtimeGICPUUsage: 25
    lodBias: 0.7
    maximumLODLevel: 0
    enableLODCrossFade: 1
    streamingMipmapsActive: 0
    streamingMipmapsAddAllCameras: 1
    streamingMipmapsMemoryBudget: 512
    streamingMipmapsRenderersPerFrame: 512
    streamingMipmapsMaxLevelReduction: 2
    streamingMipmapsMaxFileIORequests: 1024
    particleRaycastBudget: 64
    asyncUploadTimeSlice: 2
    asyncUploadBufferSize: 16
    asyncUploadPersistentBuffer: 1
    resolutionScalingFixedDPIFactor: 1
    customRenderPipeline: {fileID: 0}
    terrainQualityOverrides: 0
    terrainPixelError: 1
    terrainDetailDensityScale: 1
    terrainBasemapDistance: 1000
    terrainDetailDistance: 80
    terrainTreeDistance: 5000
    terrainBillboardStart: 50
    terrainFadeLength: 5
    terrainMaxTrees: 50
    excludedTargetPlatforms: []
  - serializedVersion: 3
    name: High
    pixelLightCount: 2
    shadows: 2
    shadowResolution: 1
    shadowProjection: 1
    shadowCascades: 2
    shadowDistance: 40
    shadowNearPlaneOffset: 3
    shadowCascade2Split: 0.33333334
    shadowCascade4Split: {x: 0.06666667, y: 0.2, z: 0.46666667}
    shadowmaskMode: 1
    skinWeights: 2
    globalTextureMipmapLimit: 0
    textureMipmapLimitSettings: []
    anisotropicTextures: 1
    antiAliasing: 0
    softParticles: 0
    softVegetation: 1
    realtimeReflectionProbes: 1
    billboardsFaceCameraPosition: 1
    useLegacyDetailDistribution: 0
    vSyncCount: 1
    realtimeGICPUUsage: 50
    lodBias: 1
    maximumLODLevel: 0
    enableLODCrossFade: 1
    streamingMipmapsActive: 0
    streamingMipmapsAddAllCameras: 1
    streamingMipmapsMemoryBudget: 512
    streamingMipmapsRenderersPerFrame: 512
    streamingMipmapsMaxLevelReduction: 2
    streamingMipmapsMaxFileIORequests: 1024
    particleRaycastBudget: 256
    asyncUploadTimeSlice: 2
    asyncUploadBufferSize: 16
    asyncUploadPersistentBuffer: 1
    resolutionScalingFixedDPIFactor: 1
    customRenderPipeline: {fileID: 0}
    terrainQualityOverrides: 0
    terrainPixelError: 1
    terrainDetailDensityScale: 1
    terrainBasemapDistance: 1000
    terrainDetailDistance: 80
    terrainTreeDistance: 5000
    terrainBillboardStart: 50
    terrainFadeLength: 5
    terrainMaxTrees: 50
    excludedTargetPlatforms: []
  - serializedVersion: 3
    name: Very High
    pixelLightCount: 3
    shadows: 2
    shadowResolution: 2
    shadowProjection: 1
    shadowCascades: 2
    shadowDistance: 70
    shadowNearPlaneOffset: 3
    shadowCascade2Split: 0.33333334
    shadowCascade4Split: {x: 0.06666667, y: 0.2, z: 0.46666667}
    shadowmaskMode: 1
    skinWeights: 4
    globalTextureMipmapLimit: 0
    textureMipmapLimitSettings: []
    anisotropicTextures: 2
    antiAliasing: 2
    softParticles: 1
    softVegetation: 1
    realtimeReflectionProbes: 1
    billboardsFaceCameraPosition: 1
    useLegacyDetailDistribution: 0
    vSyncCount: 1
    realtimeGICPUUsage: 50
    lodBias: 1.5
    maximumLODLevel: 0
    enableLODCrossFade: 1
    streamingMipmapsActive: 0
    streamingMipmapsAddAllCameras: 1
    streamingMipmapsMemoryBudget: 512
    streamingMipmapsRenderersPerFrame: 512
    streamingMipmapsMaxLevelReduction: 2
    streamingMipmapsMaxFileIORequests: 1024
    particleRaycastBudget: 1024
    asyncUploadTimeSlice: 2
    asyncUploadBufferSize: 16
    asyncUploadPersistentBuffer: 1
    resolutionScalingFixedDPIFactor: 1
    customRenderPipeline: {fileID: 0}
    terrainQualityOverrides: 0
    terrainPixelError: 1
    terrainDetailDensityScale: 1
    terrainBasemapDistance: 1000
    terrainDetailDistance: 80
    terrainTreeDistance: 5000
    terrainBillboardStart: 50
    terrainFadeLength: 5
    terrainMaxTrees: 50
    excludedTargetPlatforms: []
  - serializedVersion: 3
    name: Ultra
    pixelLightCount: 4
    shadows: 2
    shadowResolution: 2
    shadowProjection: 1
    shadowCascades: 4
    shadowDistance: 150
    shadowNearPlaneOffset: 3
    shadowCascade2Split: 0.33333334
    shadowCascade4Split: {x: 0.06666667, y: 0.2, z: 0.46666667}
    shadowmaskMode: 1
    skinWeights: 255
    globalTextureMipmapLimit: 0
    textureMipmapLimitSettings: []
    anisotropicTextures: 2
    antiAliasing: 2
    softParticles: 1
    softVegetation: 1
    realtimeReflectionProbes: 1
    billboardsFaceCameraPosition: 1
    useLegacyDetailDistribution: 0
    vSyncCount: 1
    realtimeGICPUUsage: 100
    lodBias: 2
    maximumLODLevel: 0
    enableLODCrossFade: 1
    streamingMipmapsActive: 0
    streamingMipmapsAddAllCameras: 1
    streamingMipmapsMemoryBudget: 512
    streamingMipmapsRenderersPerFrame: 512
    streamingMipmapsMaxLevelReduction: 2
    streamingMipmapsMaxFileIORequests: 1024
    particleRaycastBudget: 4096
    asyncUploadTimeSlice: 2
    asyncUploadBufferSize: 16
    asyncUploadPersistentBuffer: 1
    resolutionScalingFixedDPIFactor: 1
    customRenderPipeline: {fileID: 0}
    terrainQualityOverrides: 0
    terrainPixelError: 1
    terrainDetailDensityScale: 1
    terrainBasemapDistance: 1000
    terrainDetailDistance: 80
    terrainTreeDistance: 5000
    terrainBillboardStart: 50
    terrainFadeLength: 5
    terrainMaxTrees: 50
    excludedTargetPlatforms: []
  m_TextureMipmapLimitGroupNames: []
  m_PerPlatformDefaultQuality:
    Android: 2
    EmbeddedLinux: 5
    GameCoreScarlett: 5
    GameCoreXboxOne: 5
    LinuxHeadlessSimulation: 5
    Nintendo Switch: 5
    PS4: 5
    PS5: 5
    QNX: 5
    Server: 5
    Stadia: 5
    Standalone: 5
    VisionOS: 5
    WebGL: 3
    Windows Store Apps: 5
    XboxOne: 5
    iPhone: 2
    tvOS: 2

================
File: ProjectSettings/SceneTemplateSettings.json
================
{
    "templatePinStates": [],
    "dependencyTypeInfos": [
        {
            "userAdded": false,
            "type": "UnityEngine.AnimationClip",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEditor.Animations.AnimatorController",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.AnimatorOverrideController",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEditor.Audio.AudioMixerController",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.ComputeShader",
            "defaultInstantiationMode": 1
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Cubemap",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.GameObject",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEditor.LightingDataAsset",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.LightingSettings",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Material",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEditor.MonoScript",
            "defaultInstantiationMode": 1
        },
        {
            "userAdded": false,
            "type": "UnityEngine.PhysicMaterial",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.PhysicsMaterial2D",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Rendering.PostProcessing.PostProcessProfile",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Rendering.PostProcessing.PostProcessResources",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Rendering.VolumeProfile",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEditor.SceneAsset",
            "defaultInstantiationMode": 1
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Shader",
            "defaultInstantiationMode": 1
        },
        {
            "userAdded": false,
            "type": "UnityEngine.ShaderVariantCollection",
            "defaultInstantiationMode": 1
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Texture",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Texture2D",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Timeline.TimelineAsset",
            "defaultInstantiationMode": 0
        }
    ],
    "defaultDependencyTypeInfo": {
        "userAdded": false,
        "type": "<default_scene_template_dependencies>",
        "defaultInstantiationMode": 1
    },
    "newSceneOverride": 0
}

================
File: ProjectSettings/TagManager.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!78 &1
TagManager:
  serializedVersion: 2
  tags: []
  layers:
  - Default
  - TransparentFX
  - Ignore Raycast
  - 
  - Water
  - UI
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  m_SortingLayers:
  - name: Default
    uniqueID: 0
    locked: 0

================
File: ProjectSettings/TimeManager.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!5 &1
TimeManager:
  m_ObjectHideFlags: 0
  Fixed Timestep: 0.02
  Maximum Allowed Timestep: 0.33333334
  m_TimeScale: 1
  Maximum Particle Timestep: 0.03

================
File: ProjectSettings/UnityConnectSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!310 &1
UnityConnectSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 1
  m_Enabled: 0
  m_TestMode: 0
  m_EventOldUrl: https://api.uca.cloud.unity3d.com/v1/events
  m_EventUrl: https://cdp.cloud.unity3d.com/v1/events
  m_ConfigUrl: https://config.uca.cloud.unity3d.com
  m_DashboardUrl: https://dashboard.unity3d.com
  m_TestInitMode: 0
  CrashReportingSettings:
    m_EventUrl: https://perf-events.cloud.unity3d.com
    m_Enabled: 0
    m_LogBufferSize: 10
    m_CaptureEditorExceptions: 1
  UnityPurchasingSettings:
    m_Enabled: 0
    m_TestMode: 0
  UnityAnalyticsSettings:
    m_Enabled: 0
    m_TestMode: 0
    m_InitializeOnStartup: 1
    m_PackageRequiringCoreStatsPresent: 0
  UnityAdsSettings:
    m_Enabled: 0
    m_InitializeOnStartup: 1
    m_TestMode: 0
    m_IosGameId: 
    m_AndroidGameId: 
    m_GameIds: {}
    m_GameId: 
  PerformanceReportingSettings:
    m_Enabled: 0

================
File: ProjectSettings/VersionControlSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!890905787 &1
VersionControlSettings:
  m_ObjectHideFlags: 0
  m_Mode: Visible Meta Files
  m_CollabEditorSettings:
    inProgressEnabled: 1

================
File: ProjectSettings/VFXManager.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!937362698 &1
VFXManager:
  m_ObjectHideFlags: 0
  m_IndirectShader: {fileID: 0}
  m_CopyBufferShader: {fileID: 0}
  m_SortShader: {fileID: 0}
  m_StripUpdateShader: {fileID: 0}
  m_EmptyShader: {fileID: 0}
  m_RenderPipeSettingsPath: 
  m_FixedTimeStep: 0.016666668
  m_MaxDeltaTime: 0.05
  m_MaxScrubTime: 30
  m_CompiledVersion: 0
  m_RuntimeVersion: 0
  m_RuntimeResources: {fileID: 0}
  m_BatchEmptyLifetime: 300

================
File: UserSettings/Layouts/CurrentMaximizeLayout.dwlt
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &1
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12010, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 3}
  - {fileID: 12}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 30
    width: 1920
    height: 863
  m_MinSize: {x: 300, y: 100}
  m_MaxSize: {x: 24288, y: 16192}
  vertical: 0
  controlID: 43
  draggingID: 0
--- !u!114 &2
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12015, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Game
    m_Image: {fileID: -6423792434712278376, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 407
    y: 125
    width: 1103
    height: 491
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
  m_SerializedViewNames: []
  m_SerializedViewValues: []
  m_PlayModeViewName: GameView
  m_ShowGizmos: 0
  m_TargetDisplay: 0
  m_ClearColor: {r: 0, g: 0, b: 0, a: 0}
  m_TargetSize: {x: 836, y: 470}
  m_TextureFilterMode: 0
  m_TextureHideFlags: 61
  m_RenderIMGUI: 1
  m_EnterPlayModeBehavior: 0
  m_UseMipMap: 0
  m_VSyncEnabled: 0
  m_Gizmos: 0
  m_Stats: 0
  m_SelectedSizes: 01000000000000000000000000000000000000000000000000000000000000000000000000000000
  m_ZoomArea:
    m_HRangeLocked: 0
    m_VRangeLocked: 0
    hZoomLockedByDefault: 0
    vZoomLockedByDefault: 0
    m_HBaseRangeMin: -418
    m_HBaseRangeMax: 418
    m_VBaseRangeMin: -235
    m_VBaseRangeMax: 235
    m_HAllowExceedBaseRangeMin: 1
    m_HAllowExceedBaseRangeMax: 1
    m_VAllowExceedBaseRangeMin: 1
    m_VAllowExceedBaseRangeMax: 1
    m_ScaleWithWindow: 0
    m_HSlider: 0
    m_VSlider: 0
    m_IgnoreScrollWheelUntilClicked: 0
    m_EnableMouseInput: 0
    m_EnableSliderZoomHorizontal: 0
    m_EnableSliderZoomVertical: 0
    m_UniformScale: 1
    m_UpDirection: 1
    m_DrawArea:
      serializedVersion: 2
      x: 0
      y: 21
      width: 1103
      height: 470
    m_Scale: {x: 1, y: 1}
    m_Translation: {x: 551.5, y: 235}
    m_MarginLeft: 0
    m_MarginRight: 0
    m_MarginTop: 0
    m_MarginBottom: 0
    m_LastShownAreaInsideMargins:
      serializedVersion: 2
      x: -551.5
      y: -235
      width: 1103
      height: 470
    m_MinimalGUI: 1
  m_defaultScale: 1
  m_LastWindowPixelSize: {x: 1103, y: 491}
  m_ClearInEditMode: 1
  m_NoCameraWarning: 1
  m_LowResolutionForAspectRatios: 01000000000000000000
  m_XRRenderMode: 0
  m_RenderTexture: {fileID: 0}
  m_showToolbar: 1
--- !u!114 &3
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12010, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 4}
  - {fileID: 9}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1512
    height: 863
  m_MinSize: {x: 200, y: 100}
  m_MaxSize: {x: 16192, y: 16192}
  vertical: 1
  controlID: 44
  draggingID: 0
--- !u!114 &4
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12010, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 5}
  - {fileID: 7}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1512
    height: 512
  m_MinSize: {x: 200, y: 50}
  m_MaxSize: {x: 16192, y: 8096}
  vertical: 0
  controlID: 45
  draggingID: 0
--- !u!114 &5
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 407
    height: 512
  m_MinSize: {x: 201, y: 221}
  m_MaxSize: {x: 4001, y: 4021}
  m_ActualView: {fileID: 6}
  m_Panes:
  - {fileID: 6}
  m_Selected: 0
  m_LastSelected: 0
--- !u!114 &6
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12061, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Hierarchy
    m_Image: {fileID: 7966133145522015247, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 0
    y: 125
    width: 406
    height: 491
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
  m_SceneHierarchy:
    m_TreeViewState:
      scrollPos: {x: 0, y: 0}
      m_SelectedIDs: 
      m_LastClickedID: 0
      m_ExpandedIDs: 02fbffff144f0000
      m_RenameOverlay:
        m_UserAcceptedRename: 0
        m_Name: 
        m_OriginalName: 
        m_EditFieldRect:
          serializedVersion: 2
          x: 0
          y: 0
          width: 0
          height: 0
        m_UserData: 0
        m_IsWaitingForDelay: 0
        m_IsRenaming: 0
        m_OriginalEventType: 11
        m_IsRenamingFilename: 0
        m_ClientGUIView: {fileID: 0}
      m_SearchString: 
    m_ExpandedScenes: []
    m_CurrenRootInstanceID: 0
    m_LockTracker:
      m_IsLocked: 0
    m_CurrentSortingName: TransformSorting
  m_WindowGUID: 4c969a2b90040154d917609493e03593
--- !u!114 &7
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: GameView
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 407
    y: 0
    width: 1105
    height: 512
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_ActualView: {fileID: 2}
  m_Panes:
  - {fileID: 8}
  - {fileID: 2}
  m_Selected: 1
  m_LastSelected: 0
--- !u!114 &8
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12013, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Scene
    m_Image: {fileID: 2593428753322112591, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 407
    y: 125
    width: 1103
    height: 491
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData:
    - dockPosition: 0
      containerId: overlay-toolbar__top
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: -174, y: -26}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 3
      id: Tool Settings
      index: 0
      layout: 1
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 0
      containerId: overlay-toolbar__top
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: -141, y: 149}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 1
      id: unity-grid-and-snap-toolbar
      index: 1
      layout: 1
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-toolbar__top
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: unity-scene-view-toolbar
      index: 0
      layout: 1
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-toolbar__top
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 1
      id: unity-search-toolbar
      index: 1
      layout: 1
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 0
      containerId: overlay-container--left
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: unity-transform-toolbar
      index: 0
      layout: 2
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 0
      containerId: overlay-container--left
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 0, y: 197}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: unity-component-tools
      index: 1
      layout: 2
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 0
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 67.5, y: 86}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Orientation
      index: 0
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Light Settings
      index: 0
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Camera
      index: 1
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Cloth Constraints
      index: 1
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Cloth Collisions
      index: 2
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Navmesh Display
      index: 4
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Agent Display
      index: 5
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Obstacle Display
      index: 6
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Occlusion Culling
      index: 3
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Physics Debugger
      index: 4
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Scene Visibility
      index: 5
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Particles
      index: 6
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Tilemap
      index: 11
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Tilemap Palette Helper
      index: 12
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 48, y: 48}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/TrailRenderer
      index: 7
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 48, y: 48}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: UnityEditor.SceneViewCameraOverlay
      index: 9
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 48, y: 48}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: AINavigationOverlay
      index: 8
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    m_OverlaysVisible: 1
  m_WindowGUID: cc27987af1a868c49b0894db9c0f5429
  m_Gizmos: 1
  m_OverrideSceneCullingMask: 6917529027641081856
  m_SceneIsLit: 1
  m_SceneLighting: 1
  m_2DMode: 0
  m_isRotationLocked: 0
  m_PlayAudio: 0
  m_AudioPlay: 0
  m_Position:
    m_Target: {x: -0.79999995, y: 0.050000012, z: -42.2}
    speed: 2
    m_Value: {x: -0.79999995, y: 0.050000012, z: -42.2}
  m_RenderMode: 0
  m_CameraMode:
    drawMode: 0
    name: Shaded
    section: Shading Mode
  m_ValidateTrueMetals: 0
  m_DoValidateTrueMetals: 0
  m_SceneViewState:
    m_AlwaysRefresh: 0
    showFog: 1
    showSkybox: 1
    showFlares: 1
    showImageEffects: 1
    showParticleSystems: 1
    showVisualEffectGraphs: 1
    m_FxEnabled: 1
  m_Grid:
    xGrid:
      m_Fade:
        m_Target: 0
        speed: 2
        m_Value: 0
      m_Color: {r: 0.5, g: 0.5, b: 0.5, a: 0.4}
      m_Pivot: {x: 0, y: 0, z: 0}
      m_Size: {x: 1, y: 1}
    yGrid:
      m_Fade:
        m_Target: 1
        speed: 2
        m_Value: 1
      m_Color: {r: 0.5, g: 0.5, b: 0.5, a: 0.4}
      m_Pivot: {x: 0, y: 0, z: 0}
      m_Size: {x: 1, y: 1}
    zGrid:
      m_Fade:
        m_Target: 0
        speed: 2
        m_Value: 0
      m_Color: {r: 0.5, g: 0.5, b: 0.5, a: 0.4}
      m_Pivot: {x: 0, y: 0, z: 0}
      m_Size: {x: 1, y: 1}
    m_ShowGrid: 1
    m_GridAxis: 1
    m_gridOpacity: 0.5
  m_Rotation:
    m_Target: {x: 0.7071068, y: 0, z: 0, w: 0.7071068}
    speed: 2
    m_Value: {x: 0.7071068, y: 0, z: 0, w: 0.7071068}
  m_Size:
    m_Target: 105.827156
    speed: 2
    m_Value: 105.827156
  m_Ortho:
    m_Target: 1
    speed: 2
    m_Value: 1
  m_CameraSettings:
    m_Speed: 1
    m_SpeedNormalized: 0.5
    m_SpeedMin: 0.001
    m_SpeedMax: 2
    m_EasingEnabled: 1
    m_EasingDuration: 0.4
    m_AccelerationEnabled: 1
    m_FieldOfViewHorizontalOrVertical: 60
    m_NearClip: 0.03
    m_FarClip: 10000
    m_DynamicClip: 1
    m_OcclusionCulling: 0
  m_LastSceneViewRotation: {x: 0, y: 0, z: 0, w: 0}
  m_LastSceneViewOrtho: 0
  m_ReplacementShader: {fileID: 0}
  m_ReplacementString: 
  m_SceneVisActive: 1
  m_LastLockedObject: {fileID: 0}
  m_ViewIsLockedToObject: 0
--- !u!114 &9
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: ConsoleWindow
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 0
    y: 512
    width: 1512
    height: 351
  m_MinSize: {x: 100, y: 100}
  m_MaxSize: {x: 4000, y: 4000}
  m_ActualView: {fileID: 11}
  m_Panes:
  - {fileID: 10}
  - {fileID: 11}
  m_Selected: 1
  m_LastSelected: 0
--- !u!114 &10
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12014, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 230, y: 250}
  m_MaxSize: {x: 10000, y: 10000}
  m_TitleContent:
    m_Text: Project
    m_Image: {fileID: -5467254957812901981, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 6
    y: 631
    width: 1502
    height: 326
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
  m_SearchFilter:
    m_NameFilter: 
    m_ClassNames: []
    m_AssetLabels: []
    m_AssetBundleNames: []
    m_ReferencingInstanceIDs: 
    m_SceneHandles: 
    m_ShowAllHits: 0
    m_SkipHidden: 0
    m_SearchArea: 1
    m_Folders:
    - Assets
    m_Globs: []
    m_OriginalText: 
    m_ImportLogFlags: 0
    m_FilterByTypeIntersection: 0
  m_ViewMode: 1
  m_StartGridSize: 64
  m_LastFolders:
  - Assets
  m_LastFoldersGridSize: -1
  m_LastProjectPath: /mnt/IgniteDrive/Proyectos_Unity/Prototype_Terror
  m_LockTracker:
    m_IsLocked: 0
  m_FolderTreeState:
    scrollPos: {x: 0, y: 5}
    m_SelectedIDs: 724f0000
    m_LastClickedID: 20338
    m_ExpandedIDs: 00000000724f0000744f0000764f000000ca9a3bffffff7f
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 9}
    m_SearchString: 
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
  m_AssetTreeState:
    scrollPos: {x: 0, y: 0}
    m_SelectedIDs: 
    m_LastClickedID: 0
    m_ExpandedIDs: 00000000724f0000744f0000764f0000
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 0}
    m_SearchString: 
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
  m_ListAreaState:
    m_SelectedInstanceIDs: 
    m_LastClickedInstanceID: 0
    m_HadKeyboardFocusLastEvent: 0
    m_ExpandedInstanceIDs: c623000022450000
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 9}
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
    m_NewAssetIndexInList: -1
    m_ScrollPosition: {x: 0, y: 0}
    m_GridSize: 64
  m_SkipHiddenPackages: 0
  m_DirectoriesAreaWidth: 207
--- !u!114 &11
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12003, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 100, y: 100}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Console
    m_Image: {fileID: -4327648978806127646, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 0
    y: 637
    width: 1511
    height: 330
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
--- !u!114 &12
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 1512
    y: 0
    width: 408
    height: 863
  m_MinSize: {x: 275, y: 50}
  m_MaxSize: {x: 4000, y: 4000}
  m_ActualView: {fileID: 13}
  m_Panes:
  - {fileID: 13}
  m_Selected: 0
  m_LastSelected: 0
--- !u!114 &13
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12019, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 275, y: 50}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Inspector
    m_Image: {fileID: -2667387946076563598, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 1512
    y: 125
    width: 407
    height: 842
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
  m_ObjectsLockedBeforeSerialization: []
  m_InstanceIDsLockedBeforeSerialization: 
  m_PreviewResizer:
    m_CachedPref: 160
    m_ControlHash: -371814159
    m_PrefName: Preview_InspectorPreview
  m_LastInspectedObjectInstanceID: -1
  m_LastVerticalScrollValue: 0
  m_GlobalObjectId: 
  m_InspectorMode: 0
  m_LockTracker:
    m_IsLocked: 0
  m_PreviewWindow: {fileID: 0}

================
File: UserSettings/Layouts/default-2022.dwlt
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &1
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12004, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_PixelRect:
    serializedVersion: 2
    x: 6
    y: 74
    width: 1908
    height: 897
  m_ShowMode: 4
  m_Title: Hierarchy
  m_RootView: {fileID: 2}
  m_MinSize: {x: 875, y: 321}
  m_MaxSize: {x: 10000, y: 10000}
  m_Maximized: 0
--- !u!114 &2
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12008, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 3}
  - {fileID: 5}
  - {fileID: 4}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1908
    height: 897
  m_MinSize: {x: 875, y: 300}
  m_MaxSize: {x: 10000, y: 10000}
  m_UseTopView: 1
  m_TopViewHeight: 30
  m_UseBottomView: 1
  m_BottomViewHeight: 20
--- !u!114 &3
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12011, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1908
    height: 30
  m_MinSize: {x: 0, y: 0}
  m_MaxSize: {x: 0, y: 0}
  m_LastLoadedLayoutName: 
--- !u!114 &4
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12042, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 0
    y: 877
    width: 1908
    height: 20
  m_MinSize: {x: 0, y: 0}
  m_MaxSize: {x: 0, y: 0}
--- !u!114 &5
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12010, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 6}
  - {fileID: 11}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 30
    width: 1908
    height: 847
  m_MinSize: {x: 300, y: 100}
  m_MaxSize: {x: 24288, y: 16192}
  vertical: 0
  controlID: 105
  draggingID: 0
--- !u!114 &6
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12010, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 7}
  - {fileID: 10}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1503
    height: 847
  m_MinSize: {x: 200, y: 100}
  m_MaxSize: {x: 16192, y: 16192}
  vertical: 1
  controlID: 46
  draggingID: 0
--- !u!114 &7
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12010, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 8}
  - {fileID: 9}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1503
    height: 500
  m_MinSize: {x: 200, y: 50}
  m_MaxSize: {x: 16192, y: 8096}
  vertical: 0
  controlID: 47
  draggingID: 0
--- !u!114 &8
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 405
    height: 500
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_ActualView: {fileID: 13}
  m_Panes:
  - {fileID: 13}
  m_Selected: 0
  m_LastSelected: 0
--- !u!114 &9
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: SceneView
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 405
    y: 0
    width: 1098
    height: 500
  m_MinSize: {x: 202, y: 221}
  m_MaxSize: {x: 4002, y: 4021}
  m_ActualView: {fileID: 14}
  m_Panes:
  - {fileID: 14}
  - {fileID: 12}
  m_Selected: 0
  m_LastSelected: 1
--- !u!114 &10
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: ConsoleWindow
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 0
    y: 500
    width: 1503
    height: 347
  m_MinSize: {x: 101, y: 121}
  m_MaxSize: {x: 4001, y: 4021}
  m_ActualView: {fileID: 16}
  m_Panes:
  - {fileID: 15}
  - {fileID: 16}
  m_Selected: 1
  m_LastSelected: 0
--- !u!114 &11
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 1503
    y: 0
    width: 405
    height: 847
  m_MinSize: {x: 276, y: 71}
  m_MaxSize: {x: 4001, y: 4021}
  m_ActualView: {fileID: 17}
  m_Panes:
  - {fileID: 17}
  m_Selected: 0
  m_LastSelected: 0
--- !u!114 &12
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12015, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Game
    m_Image: {fileID: -6423792434712278376, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 411
    y: 131
    width: 1096
    height: 479
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
  m_SerializedViewNames: []
  m_SerializedViewValues: []
  m_PlayModeViewName: GameView
  m_ShowGizmos: 0
  m_TargetDisplay: 0
  m_ClearColor: {r: 0, g: 0, b: 0, a: 0}
  m_TargetSize: {x: 814, y: 458}
  m_TextureFilterMode: 0
  m_TextureHideFlags: 61
  m_RenderIMGUI: 1
  m_EnterPlayModeBehavior: 0
  m_UseMipMap: 0
  m_VSyncEnabled: 0
  m_Gizmos: 0
  m_Stats: 0
  m_SelectedSizes: 01000000000000000000000000000000000000000000000000000000000000000000000000000000
  m_ZoomArea:
    m_HRangeLocked: 0
    m_VRangeLocked: 0
    hZoomLockedByDefault: 0
    vZoomLockedByDefault: 0
    m_HBaseRangeMin: -407
    m_HBaseRangeMax: 407
    m_VBaseRangeMin: -229
    m_VBaseRangeMax: 229
    m_HAllowExceedBaseRangeMin: 1
    m_HAllowExceedBaseRangeMax: 1
    m_VAllowExceedBaseRangeMin: 1
    m_VAllowExceedBaseRangeMax: 1
    m_ScaleWithWindow: 0
    m_HSlider: 0
    m_VSlider: 0
    m_IgnoreScrollWheelUntilClicked: 0
    m_EnableMouseInput: 0
    m_EnableSliderZoomHorizontal: 0
    m_EnableSliderZoomVertical: 0
    m_UniformScale: 1
    m_UpDirection: 1
    m_DrawArea:
      serializedVersion: 2
      x: 0
      y: 21
      width: 1096
      height: 458
    m_Scale: {x: 1, y: 1}
    m_Translation: {x: 548, y: 229}
    m_MarginLeft: 0
    m_MarginRight: 0
    m_MarginTop: 0
    m_MarginBottom: 0
    m_LastShownAreaInsideMargins:
      serializedVersion: 2
      x: -548
      y: -229
      width: 1096
      height: 458
    m_MinimalGUI: 1
  m_defaultScale: 1
  m_LastWindowPixelSize: {x: 1096, y: 479}
  m_ClearInEditMode: 1
  m_NoCameraWarning: 1
  m_LowResolutionForAspectRatios: 01000000000000000000
  m_XRRenderMode: 0
  m_RenderTexture: {fileID: 0}
  m_showToolbar: 1
--- !u!114 &13
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12061, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Hierarchy
    m_Image: {fileID: 7966133145522015247, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 6
    y: 131
    width: 404
    height: 479
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
  m_SceneHierarchy:
    m_TreeViewState:
      scrollPos: {x: 0, y: 0}
      m_SelectedIDs: 124f0000
      m_LastClickedID: 20242
      m_ExpandedIDs: 0efbffff624e00006a4e0000c44e0000d84e0000e44e00000e4f0000124f0000
      m_RenameOverlay:
        m_UserAcceptedRename: 0
        m_Name: 
        m_OriginalName: 
        m_EditFieldRect:
          serializedVersion: 2
          x: 0
          y: 0
          width: 0
          height: 0
        m_UserData: 0
        m_IsWaitingForDelay: 0
        m_IsRenaming: 0
        m_OriginalEventType: 11
        m_IsRenamingFilename: 0
        m_ClientGUIView: {fileID: 0}
      m_SearchString: 
    m_ExpandedScenes: []
    m_CurrenRootInstanceID: 0
    m_LockTracker:
      m_IsLocked: 0
    m_CurrentSortingName: TransformSorting
  m_WindowGUID: 4c969a2b90040154d917609493e03593
--- !u!114 &14
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12013, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Scene
    m_Image: {fileID: 2593428753322112591, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 411
    y: 131
    width: 1096
    height: 479
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData:
    - dockPosition: 0
      containerId: overlay-toolbar__top
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: -174, y: -26}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 3
      id: Tool Settings
      index: 0
      layout: 1
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 0
      containerId: overlay-toolbar__top
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: -141, y: 149}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 1
      id: unity-grid-and-snap-toolbar
      index: 1
      layout: 1
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-toolbar__top
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: unity-scene-view-toolbar
      index: 0
      layout: 1
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-toolbar__top
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 1
      id: unity-search-toolbar
      index: 1
      layout: 1
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 0
      containerId: overlay-container--left
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: unity-transform-toolbar
      index: 0
      layout: 2
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 0
      containerId: overlay-container--left
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 0, y: 197}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: unity-component-tools
      index: 1
      layout: 2
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 0
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 67.5, y: 86}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Orientation
      index: 0
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Light Settings
      index: 0
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Camera
      index: 1
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Cloth Constraints
      index: 1
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Cloth Collisions
      index: 2
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Navmesh Display
      index: 4
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Agent Display
      index: 5
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Obstacle Display
      index: 6
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Occlusion Culling
      index: 3
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Physics Debugger
      index: 4
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Scene Visibility
      index: 5
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Particles
      index: 6
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Tilemap
      index: 11
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Tilemap Palette Helper
      index: 12
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 48, y: 48}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/TrailRenderer
      index: 7
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 48, y: 48}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: UnityEditor.SceneViewCameraOverlay
      index: 9
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 48, y: 48}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: AINavigationOverlay
      index: 8
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    m_OverlaysVisible: 1
  m_WindowGUID: cc27987af1a868c49b0894db9c0f5429
  m_Gizmos: 1
  m_OverrideSceneCullingMask: 6917529027641081856
  m_SceneIsLit: 1
  m_SceneLighting: 1
  m_2DMode: 0
  m_isRotationLocked: 0
  m_PlayAudio: 0
  m_AudioPlay: 0
  m_Position:
    m_Target: {x: -0.79999995, y: 0.050000012, z: -42.2}
    speed: 2
    m_Value: {x: -0.79999995, y: 0.050000012, z: -42.2}
  m_RenderMode: 0
  m_CameraMode:
    drawMode: 0
    name: Shaded
    section: Shading Mode
  m_ValidateTrueMetals: 0
  m_DoValidateTrueMetals: 0
  m_SceneViewState:
    m_AlwaysRefresh: 0
    showFog: 1
    showSkybox: 1
    showFlares: 1
    showImageEffects: 1
    showParticleSystems: 1
    showVisualEffectGraphs: 1
    m_FxEnabled: 1
  m_Grid:
    xGrid:
      m_Fade:
        m_Target: 0
        speed: 2
        m_Value: 0
      m_Color: {r: 0.5, g: 0.5, b: 0.5, a: 0.4}
      m_Pivot: {x: 0, y: 0, z: 0}
      m_Size: {x: 1, y: 1}
    yGrid:
      m_Fade:
        m_Target: 1
        speed: 2
        m_Value: 1
      m_Color: {r: 0.5, g: 0.5, b: 0.5, a: 0.4}
      m_Pivot: {x: 0, y: 0, z: 0}
      m_Size: {x: 1, y: 1}
    zGrid:
      m_Fade:
        m_Target: 0
        speed: 2
        m_Value: 0
      m_Color: {r: 0.5, g: 0.5, b: 0.5, a: 0.4}
      m_Pivot: {x: 0, y: 0, z: 0}
      m_Size: {x: 1, y: 1}
    m_ShowGrid: 1
    m_GridAxis: 1
    m_gridOpacity: 0.5
  m_Rotation:
    m_Target: {x: 0.22078489, y: 0.25767496, z: -0.060605027, w: 0.9387179}
    speed: 2
    m_Value: {x: 0.22078416, y: 0.2576741, z: -0.060604826, w: 0.93871474}
  m_Size:
    m_Target: 4.1487246
    speed: 2
    m_Value: 4.344214
  m_Ortho:
    m_Target: 1
    speed: 2
    m_Value: 1
  m_CameraSettings:
    m_Speed: 1
    m_SpeedNormalized: 0.5
    m_SpeedMin: 0.001
    m_SpeedMax: 2
    m_EasingEnabled: 1
    m_EasingDuration: 0.4
    m_AccelerationEnabled: 1
    m_FieldOfViewHorizontalOrVertical: 60
    m_NearClip: 0.03
    m_FarClip: 10000
    m_DynamicClip: 1
    m_OcclusionCulling: 0
  m_LastSceneViewRotation: {x: 0, y: 0, z: 0, w: 0}
  m_LastSceneViewOrtho: 0
  m_ReplacementShader: {fileID: 0}
  m_ReplacementString: 
  m_SceneVisActive: 1
  m_LastLockedObject: {fileID: 0}
  m_ViewIsLockedToObject: 0
--- !u!114 &15
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12014, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 230, y: 250}
  m_MaxSize: {x: 10000, y: 10000}
  m_TitleContent:
    m_Text: Project
    m_Image: {fileID: -5467254957812901981, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 6
    y: 631
    width: 1502
    height: 326
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
  m_SearchFilter:
    m_NameFilter: 
    m_ClassNames: []
    m_AssetLabels: []
    m_AssetBundleNames: []
    m_ReferencingInstanceIDs: 
    m_SceneHandles: 
    m_ShowAllHits: 0
    m_SkipHidden: 0
    m_SearchArea: 1
    m_Folders:
    - Assets/_Scripts
    m_Globs: []
    m_OriginalText: 
    m_ImportLogFlags: 0
    m_FilterByTypeIntersection: 0
  m_ViewMode: 1
  m_StartGridSize: 64
  m_LastFolders:
  - Assets/_Scripts
  m_LastFoldersGridSize: -1
  m_LastProjectPath: /mnt/IgniteDrive/Proyectos_Unity/Prototype_Terror
  m_LockTracker:
    m_IsLocked: 0
  m_FolderTreeState:
    scrollPos: {x: 0, y: 5}
    m_SelectedIDs: 7a4f0000
    m_LastClickedID: 20346
    m_ExpandedIDs: 00000000784f00007a4f00007c4f000000ca9a3bffffff7f
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 10}
    m_SearchString: 
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
  m_AssetTreeState:
    scrollPos: {x: 0, y: 0}
    m_SelectedIDs: 
    m_LastClickedID: 0
    m_ExpandedIDs: 00000000784f00007a4f00007c4f0000
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 0}
    m_SearchString: 
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
  m_ListAreaState:
    m_SelectedInstanceIDs: 7c4e0000
    m_LastClickedInstanceID: 20092
    m_HadKeyboardFocusLastEvent: 1
    m_ExpandedInstanceIDs: c623000022450000
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 10}
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
    m_NewAssetIndexInList: -1
    m_ScrollPosition: {x: 0, y: 0}
    m_GridSize: 64
  m_SkipHiddenPackages: 0
  m_DirectoriesAreaWidth: 207
--- !u!114 &16
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12003, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 100, y: 100}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Console
    m_Image: {fileID: -4327648978806127646, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 6
    y: 631
    width: 1502
    height: 326
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
--- !u!114 &17
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12019, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 275, y: 50}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Inspector
    m_Image: {fileID: -2667387946076563598, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 1509
    y: 131
    width: 404
    height: 826
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
  m_ObjectsLockedBeforeSerialization: []
  m_InstanceIDsLockedBeforeSerialization: 
  m_PreviewResizer:
    m_CachedPref: 160
    m_ControlHash: -371814159
    m_PrefName: Preview_InspectorPreview
  m_LastInspectedObjectInstanceID: -1
  m_LastVerticalScrollValue: 0
  m_GlobalObjectId: 
  m_InspectorMode: 0
  m_LockTracker:
    m_IsLocked: 0
  m_PreviewWindow: {fileID: 0}

================
File: UserSettings/EditorUserSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!162 &1
EditorUserSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 4
  m_ConfigSettings:
    RecentlyUsedSceneGuid-0:
      value: 010856075c065f5a0b080a7447250f49104f1c792e792565797c4863e3e4676c
      flags: 0
    vcSharedLogLevel:
      value: 0d5e400f0650
      flags: 0
  m_VCAutomaticAdd: 1
  m_VCDebugCom: 0
  m_VCDebugCmd: 0
  m_VCDebugOut: 0
  m_SemanticMergeMode: 2
  m_DesiredImportWorkerCount: 1
  m_StandbyImportWorkerCount: 1
  m_IdleImportWorkerShutdownDelay: 60000
  m_VCShowFailedCheckout: 1
  m_VCOverwriteFailedCheckoutAssets: 1
  m_VCProjectOverlayIcons: 1
  m_VCHierarchyOverlayIcons: 1
  m_VCOtherOverlayIcons: 1
  m_VCAllowAsyncUpdate: 1
  m_VCScanLocalPackagesOnConnect: 1
  m_ArtifactGarbageCollection: 1

================
File: UserSettings/Search.index
================
{
    "name": "Assets",
    "roots": ["Assets"],
    "includes": [],
    "excludes": ["Assets/Temp/", "Assets/External/"],
    "options": {
        "types": true,
        "properties": true,
        "extended": false,
        "dependencies": false
    },
    "baseScore": 999
}

================
File: UserSettings/Search.settings
================
trackSelection = true
refreshSearchWindowsInPlayMode = false
pickerAdvancedUI = false
fetchPreview = true
defaultFlags = 0
keepOpen = true
queryFolder = "Assets"
onBoardingDoNotAskAgain = true
showPackageIndexes = false
showStatusBar = false
scopes = {
}
providers = {
	asset = {
		active = true
		priority = 25
		defaultAction = null
	}
	scene = {
		active = true
		priority = 50
		defaultAction = null
	}
	adb = {
		active = false
		priority = 2500
		defaultAction = null
	}
	find = {
		active = true
		priority = 25
		defaultAction = null
	}
	packages = {
		active = false
		priority = 90
		defaultAction = null
	}
	store = {
		active = false
		priority = 100
		defaultAction = null
	}
	performance = {
		active = false
		priority = 100
		defaultAction = null
	}
	profilermarkers = {
		active = false
		priority = 100
		defaultAction = null
	}
	log = {
		active = false
		priority = 210
		defaultAction = null
	}
}
objectSelectors = {
}
recentSearches = [
]
searchItemFavorites = [
]
savedSearchesSortOrder = 0
showSavedSearchPanel = false
hideTabs = false
expandedQueries = [
]
queryBuilder = true
ignoredProperties = "id;name;classname;imagecontentshash"
helperWidgetCurrentArea = "all"
disabledIndexers = ""
minIndexVariations = 2
findProviderIndexHelper = true

================
File: .gitignore
================
# This .gitignore file should be placed at the root of your Unity project directory
#
# Get latest from https://github.com/github/gitignore/blob/master/Unity.gitignore
#
/[Ll]ibrary/
/[Tt]emp/
/[Oo]bj/
/[Bb]uild/
/[Bb]uilds/
/[Ll]ogs/
/[Mm]emoryCaptures/

# Never ignore Asset meta data
!/[Aa]ssets/**/*.meta

# Uncomment this line if you wish to ignore the asset store tools plugin
# /[Aa]ssets/AssetStoreTools*

# TextMesh Pro files
[Aa]ssets/TextMesh*Pro/

# Autogenerated Jetbrains Rider plugin
[Aa]ssets/Plugins/Editor/JetBrains*

# Visual Studio cache directory
.vs/

# Gradle cache directory
.gradle/

# Autogenerated VS/MD/Consulo solution and project files
ExportedObj/
.consulo/
*.csproj
*.unityproj
*.sln
*.suo
*.tmp
*.user
*.userprefs
*.pidb
*.booproj
*.svd
*.pdb
*.mdb
*.opendb
*.VC.db

# Unity3D generated meta files
*.pidb.meta
*.pdb.meta
*.mdb.meta

# Unity3D generated file on crash reports
sysinfo.txt

# Builds
*.apk
*.unitypackage

# Crashlytics generated file
crashlytics-build.properties

================
File: .repopackignore 
================
# Excluir carpetas pesadas o inútiles de Unity
Library/
Temp/
Obj/
Logs/
UserSettings/
MemoryCaptures/
Builds/
*.meta
*.unitypackage
*.asset
*.prefab

================
File: README.md
================
# Prototype_Terror
````

## File: README.md
````markdown
# Prototype_Terror
````

## File: Assets/_Scripts/Enums/GameEnums.cs
````csharp
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
````

## File: Assets/_Scripts/Interfaces/IEstado.cs
````csharp
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
````

## File: Assets/_Scripts/Player/PlayerController.cs
````csharp
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
````

## File: Assets/_Scripts/States/EstadoRastreo.cs
````csharp
using UnityEngine;
using _Scripts.Interfaces;
using _Scripts.Brains;

namespace _Scripts.States
{
    /* * ESTADO: RASTREO (FASE 1)
     * El enemigo patrulla tranquilamente entre waypoints usando NavMeshAgent.
     * Es el estado más "ciego" y lento.
     */
    public class EstadoRastreo : IEstado
    {
        private readonly EnemyBrain _brain;
        private readonly float _velocidadRastreo = 2.5f;
        
        private int _indexWaypointActual = 0;
        private Vector3 _ultimoDestinoAsignado;
        private bool _iniciando = true;

        // El constructor nos permite recibir la referencia del cerebro
        public EstadoRastreo(EnemyBrain brain)
        {
            _brain = brain;
        }

        public void Entrar()
        {
            Debug.Log("<color=green>Enemigo entrando en fase de RASTREO.</color>");
            _brain.ActualizarVelocidad(_velocidadRastreo);
            _ultimoDestinoAsignado = Vector3.zero;
            _iniciando = true;
        }

        public void Ejecutar()
        {
            // 1. Aseguramos que la velocidad actual del agente sea la de rastreo
            _brain.ActualizarVelocidad(_velocidadRastreo);

            Vector3 destinoObjetivo;
            bool esSospecha = _brain.Data.IntuicionActual > 0.2f;

            if (esSospecha)
            {
                // Si la intuición es alta, vamos a investigar la posición sospechosa
                destinoObjetivo = _brain.Data.posicionSospechosa;
            }
            else
            {
                // Si no, volvemos a la patrulla normal
                if (_brain.Waypoints == null || _brain.Waypoints.Length == 0) return;
                destinoObjetivo = _brain.Waypoints[_indexWaypointActual].position;
            }

            // 2. OPTIMIZACIÓN CRÍTICA: Solo llamamos a SetDestination si el destino ha cambiado.
            // Si llamamos a SetDestination en cada frame (Update), el agente recalcula la ruta infinitamente y se queda quieto.
            if (_iniciando || Vector3.Distance(_ultimoDestinoAsignado, destinoObjetivo) > 0.1f)
            {
                _brain.MoverHacia(destinoObjetivo);
                _ultimoDestinoAsignado = destinoObjetivo;
                _iniciando = false;
            }

            // 3. CAMBIO DE WAYPOINT: Si estamos patrullando y llegamos físicamente cerca del punto, avanzamos
            if (!esSospecha)
            {
                float distanciaFisica = Vector3.Distance(_brain.transform.position, destinoObjetivo);
                if (distanciaFisica < 0.8f)
                {
                    _indexWaypointActual = (_indexWaypointActual + 1) % _brain.Waypoints.Length;
                }
            }
        }

        public void Exit() // Cumple la interfaz si requiere Salir en español
        {
            Salir();
        }

        public void Salir()
        {
            Debug.Log("Saliendo de RASTREO: El enemigo ha cambiado de estado.");
        }
    }
}
````

## File: Assets/_Scripts/Systems/IntuicionSystem.cs
````csharp
using UnityEngine;
using System; // Necesario para usar los "Eventos" (La Radio)

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DICCIONARIO ACÚSTICO
 * Lo definimos aquí para que cualquier objeto del juego pueda
 * "etiquetar" su ruido antes de enviarlo al sistema.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
namespace _Scripts.Enums
{
    public enum PerfilAcustico
    {
        AgudoVocal, // Gritos, susurros, cristales rotos (Se ahogan rápido con la distancia)
        GraveFisico // Pasos pesados, muebles cayendo (Viajan lejos por el suelo/estructura)
    }
}

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * EL CORAZÓN DE DATOS (SISTEMA DE INTUICIÓN)
 * Actúa como un Analizador de Frecuencias Básico. Recibe paquetes 
 * de sonido, calcula su impacto real y alerta al enemigo.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
namespace _Scripts.Systems
{
    [CreateAssetMenu(fileName = "NuevaIntuicion", menuName = "Sistema/Intuicion Data")]
    public class IntuicionSystem : ScriptableObject
    {
        [Header("Datos de la Fase (Escala 0.0 a 1.0)")]
        [Tooltip("El medidor de peligro de la fase actual")]
        [SerializeField] private float intuicionActual = 0f;
        public float IntuicionActual => intuicionActual;

        [Header("Memoria de Posición")]
        [Tooltip("Última posición global donde se originó un ruido válido")]
        public Vector3 posicionSospechosa;

        // EVENTOS ("La Radio"): Avisan al enemigo cuando debe cambiar de fase
        public event Action OnSubirFase;
        public event Action OnBajarFase;

        /* * *
         * MÉTODO PARA SUBIR: LA PUERTA DE ENTRADA DEL RUIDO
         * Recibe el "Paquete de Sonido" (Volumen, Distancia y Tipo) y 
         * decide cuánto asusta realmente al monstruo.
         */
        // ReSharper disable Unity.PerformanceAnalysis
        public void ModificarIntuicion(float volumenOriginal, float distanciaAlMonstruo, _Scripts.Enums.PerfilAcustico perfil)
        {
            // Esta variable guardará el ruido final después de calcular la distancia
            float incrementoFinal = 0f;

            // 1. FILTRO MATEMÁTICO DE FRECUENCIAS (La magia del sonido)
            switch (perfil)
            { 
                case _Scripts.Enums.PerfilAcustico.AgudoVocal:
                    // REGLA AGUDA: Multiplicamos la distancia x 2.0
                    // Si el monstruo está a 10m, el divisor será 20. El sonido se vuelve diminuto muy rápido.
                    incrementoFinal = volumenOriginal / Mathf.Max(distanciaAlMonstruo * 2.0f, 0.1f);
                    break;

                case _Scripts.Enums.PerfilAcustico.GraveFisico:
                    // REGLA GRAVE: Multiplicamos la distancia x 0.3 (La reducimos)
                    // Si el monstruo está a 10m, el divisor será solo 3. La vibración llega casi intacta.
                    incrementoFinal = volumenOriginal / Mathf.Max(distanciaAlMonstruo * 0.3f, 0.1f);
                    break;
            }

            // 2. REGLA DEL 75% (Zona de Gracia)
            // Si el monstruo ya está muy alterado (>0.75), los ruidos le afectan 3 veces menos.
            // Así le damos al jugador una micro-oportunidad de escapar antes de pasar a Persecución.
            if (intuicionActual >= 0.75f && incrementoFinal > 0)
            {
                intuicionActual += (incrementoFinal / 3f);
            }
            else
            {
                intuicionActual += incrementoFinal;
            }

            // 3. REGLA DE CASCADA (SUBIDA)
            // Si el vaso se derrama, gritamos por la radio para que el EnemyBrain suba de fase.
            if (!(intuicionActual >= 1.0f)) return;
            intuicionActual = 0f; // Vaciamos el vaso para el nuevo nivel
            OnSubirFase?.Invoke(); // El '?' asegura que no haya error si nadie escucha
        }

        /* * *
         * TICK DE RECUPERACIÓN (Llamado por el EnemyBrain cada 60s)
         * Reduce el miedo con el tiempo. Es más difícil calmarlo en niveles altos.
         */
        public void EjecutarTickDeRecuperacion(int miedoLevel)
        {
            // FÓRMULA: Reducción = Intuición Actual * (1/3 * 1/Miedo)
            float factorEnfriamiento = (1f / 3f) * (1f / miedoLevel);
            float cantidadARestar = intuicionActual * factorEnfriamiento;

            intuicionActual -= cantidadARestar;

            // REGLA DE CASCADA (BAJADA)
            if (intuicionActual <= 0f)
            {
                // REGALO AL JUGADOR: Si el monstruo se calma y baja de fase, 
                // la nueva fase empieza en 0.7 (70%) en lugar de 1.0. No se olvida de ti del todo.
                intuicionActual = 0.7f; 
                OnBajarFase?.Invoke(); 
            }

            // Mantenemos el número entre 0.0 y 1.0 por seguridad del motor
            intuicionActual = Mathf.Clamp01(intuicionActual);
        }
    }
}
````

## File: Assets/_Scripts/UI/UI_MenuManager.cs
````csharp
using _Scripts.Player;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
// LINEA NUEVA: Permite al script tener acceso directo a las herramientas de cámara de Cinemachine
using Cinemachine;

namespace _Scripts.UI
{
    // Asegura que este script inicialice después de los componentes base del juego para evitar NullReference
    [DefaultExecutionOrder(100)]
    public class UI_MenuManager : MonoBehaviour
    {
        // Enums: Una lista de estados lógicos excluyentes. El juego solo puede estar en UNO de estos a la vez.
        private enum MenuState
        {
            Gameplay,
            MenuAbierto
        }

        [Header("Input (Assets/Input/PlayerControls)")]
        [Tooltip("El contenedor de mapas de control (.inputactions) de nuestro proyecto")]
        [SerializeField]
        private InputActionAsset inputActionAsset;

        [Header("UI")] [Tooltip("El objeto raíz de la interfaz que contiene los botones")] [SerializeField]
        private GameObject menuPanel;

        [SerializeField] private TextMeshProUGUI tituloTexto;
        [SerializeField] private TextMeshProUGUI botonPrincipalTexto;

        [Header("Jugador")]
        [Tooltip("Referencia al script que controla el movimiento físico de nuestro personaje")]
        [SerializeField]
        private PlayerController playerController;

        [Header("Configuración de Cámara (Cinemachine)")]
        [Tooltip("Arrastra aquí tu Virtual Camera de Cinemachine para congelar la rotación del mouse en las pausas")]
        [SerializeField]
        private CinemachineInputProvider cameraProvider;

        [SerializeField] private CinemachineVirtualCamera virtualCamera; // <-- Cambiamos el tipo aquí
        private CinemachinePOV cameraPov; // Ahora es privado, no se arrastra

        // Cache de componentes de control para evitar búsquedas repetitivas en cada frame (Ahorro de CPU)
        private InputActionMap _gameplayMap;
        private InputActionMap _uiMap;
        private InputAction _pauseAction;
        private InputAction _unpauseAction;

        // Estado actual del menú diegético (P alterna Gameplay ↔ MenuAbierto).
        private MenuState _estado = MenuState.Gameplay;

        // Constantes: Textos fijos que no van a cambiar durante la ejecución del código
        

        private void Awake()
        {
            // Validación de seguridad: Si olvidaste arrastrar los controles en el inspector, el script se apaga solo
            if (inputActionAsset == null)
            {
                Debug.LogError("UI_MenuManager: Asigna el InputActionAsset PlayerControls en el Inspector.");
                enabled = false;
                return;
            }

            if (virtualCamera != null)
            {
                // Esto extrae el módulo interno POV de la cámara virtual
                cameraPov = virtualCamera.GetCinemachineComponent<CinemachinePOV>();

                if (cameraProvider == null)
                    cameraProvider = virtualCamera.GetComponent<CinemachineInputProvider>();
            }

            // 1. Buscamos y vinculamos los Action Maps definidos en tu archivo de inputs
            _gameplayMap = inputActionAsset.FindActionMap("Gameplay", true);
            _uiMap = inputActionAsset.FindActionMap("UI", true);

            // 2. Buscamos las acciones específicas mapeadas a la tecla P
            _pauseAction = _gameplayMap.FindAction("Pause", true);
            _unpauseAction = _uiMap.FindAction("Unpause", true);

            // 3. SUSCRIPCIÓN: Conectamos físicamente las acciones a nuestras funciones de C#
            _pauseAction.performed += OnPausePerformed;
            _unpauseAction.performed += OnUnpausePerformed;

            // Búsqueda automática: Si no arrastraste el script del jugador, lo intenta buscar en la escena por sí mismo
            if (playerController == null)
                playerController = FindObjectOfType<PlayerController>();

            if (cameraProvider == null)
                cameraProvider = FindObjectOfType<CinemachineInputProvider>();

            if (cameraPov == null && cameraProvider != null)
                cameraPov = cameraProvider.GetComponentInChildren<CinemachinePOV>();
        }

private void Start()
{
    if (menuPanel != null)
    {
        Button[] botones = menuPanel.GetComponentsInChildren<Button>(true);
        foreach (Button b in botones)
        {
            if (b.gameObject.name == "Boton_Jugar_Reanudar")
            {
                b.onClick.RemoveListener(OnClickJugarOReanudar);
                b.onClick.AddListener(OnClickJugarOReanudar);
                break;
            }
        }
    }

    EntrarModoGameplay();
}

        private void OnDestroy()
        {
            // BUENA PRÁCTICA: Rompemos la conexión con los eventos al destruir el objeto para evitar bugs de memoria
            if (_pauseAction != null)
                _pauseAction.performed -= OnPausePerformed;
            if (_unpauseAction != null)
                _unpauseAction.performed -= OnUnpausePerformed;
        }

        // --- MÉTODOS PÚBLICOS PARA LOS BOTONES (EVENTOS ONCLICK) ---

        public void OnClickJugarOReanudar()
        {
            if (_estado == MenuState.MenuAbierto)
                EntrarModoGameplay();
        }

        public void OnClickSalir()
        {
            // Compilación condicional: Detiene el juego de forma correcta según el entorno
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Detiene el Play Mode dentro de Unity
#else
            Application.Quit(); // Cierra la aplicación ejecutable (.exe o binario de Linux)
#endif
        }

        // --- RESPUESTAS A LOS INPUTS FÍSICOS (TECLA P) ---

        private void OnPausePerformed(InputAction.CallbackContext context)
        {
            // Filtro de seguridad: Si la acción no se completó o no estamos jugando, ignora el teclazo
            if (!context.performed || _estado != MenuState.Gameplay)
                return;

            EntrarModoMenuAbierto();
        }

        private void OnUnpausePerformed(InputAction.CallbackContext context)
        {
            if (!context.performed || _estado != MenuState.MenuAbierto)
                return;

            EntrarModoGameplay();
        }

        // --- MANEJADORES DE ESTADO (MÁQUINA DE ESTADOS) ---

        private void EntrarModoGameplay()
        {
            _estado = MenuState.Gameplay;

            MostrarMenu(false);
            ConfigurarCursor(false);
            ActivarMapaGameplay();
            ConfigurarJugador(true);
            ConfigurarCamara(true);
        }

private void EntrarModoMenuAbierto()
{
    _estado = MenuState.MenuAbierto;

    MostrarMenu(true);
    // ConfigurarTextos(TituloMenu, TextoCerrar); // Eliminado para no sobreescribir el diseño del usuario
    ConfigurarCursor(true);
    ActivarMapaUI();
    ConfigurarJugador(false);
    ConfigurarCamara(false);
}

        // --- SUB-FUNCIONES AUXILIARES DE CONFIGURACIÓN ---

        private void ActivarMapaUI()
        {
            _gameplayMap.Disable(); // Desactiva el mapa de juego (WASD deja de responder instantáneamente)
            _uiMap.Enable(); // Activa el mapa de UI (Permite que funcione la tecla Unpause)
        }

        private void ActivarMapaGameplay()
        {
            _uiMap.Disable(); // Desactiva el mapa de UI
            _gameplayMap.Enable(); // Activa el mapa de juego activo
        }

        private void MostrarMenu(bool visible)
        {
            if (menuPanel != null)
                menuPanel.SetActive(visible); // Enciende o apaga el GameObject completo en la jerarquía
        }

        private void ConfigurarTextos(string titulo, string botonPrincipal)
        {
            if (tituloTexto != null)
                tituloTexto.text = titulo;
            if (botonPrincipalTexto != null)
                botonPrincipalTexto.text = botonPrincipal;
        }

        private static void ConfigurarCursor(bool menuActivo)
        {
            // Si el menú está activo, el cursor se libera. Si no, se bloquea al centro de la pantalla.
            Cursor.lockState = menuActivo ? CursorLockMode.None : CursorLockMode.Locked;
            Cursor.visible = menuActivo; // Alterna la visibilidad del puntero gráfico
        }

        private void ConfigurarJugador(bool activo)
        {
            if (playerController != null)
                playerController.SetControlBlocked(!activo);
        }

        private void ConfigurarCamara(bool activo)
        {
            if (cameraProvider != null)
                cameraProvider.enabled = activo;

            if (cameraPov == null)
                return;

            var horizontal = cameraPov.m_HorizontalAxis;
            horizontal.m_InputAxisValue = 0f;
            cameraPov.m_HorizontalAxis = horizontal;

            var vertical = cameraPov.m_VerticalAxis;
            vertical.m_InputAxisValue = 0f;
            cameraPov.m_VerticalAxis = vertical;

            if (activo && Mouse.current != null)
                InputSystem.ResetDevice(Mouse.current);
        }
    }
}
````

## File: Assets/Input/PlayerControls.cs
````csharp
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.14.2
//     from Assets/Input/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

/// <summary>
/// Provides programmatic access to <see cref="InputActionAsset" />, <see cref="InputActionMap" />, <see cref="InputAction" /> and <see cref="InputControlScheme" /> instances defined in asset "Assets/Input/PlayerControls.inputactions".
/// </summary>
/// <remarks>
/// This class is source generated and any manual edits will be discarded if the associated asset is reimported or modified.
/// </remarks>
/// <example>
/// <code>
/// using namespace UnityEngine;
/// using UnityEngine.InputSystem;
///
/// // Example of using an InputActionMap named "Player" from a UnityEngine.MonoBehaviour implementing callback interface.
/// public class Example : MonoBehaviour, MyActions.IPlayerActions
/// {
///     private MyActions_Actions m_Actions;                  // Source code representation of asset.
///     private MyActions_Actions.PlayerActions m_Player;     // Source code representation of action map.
///
///     void Awake()
///     {
///         m_Actions = new MyActions_Actions();              // Create asset object.
///         m_Player = m_Actions.Player;                      // Extract action map object.
///         m_Player.AddCallbacks(this);                      // Register callback interface IPlayerActions.
///     }
///
///     void OnDestroy()
///     {
///         m_Actions.Dispose();                              // Destroy asset object.
///     }
///
///     void OnEnable()
///     {
///         m_Player.Enable();                                // Enable all actions within map.
///     }
///
///     void OnDisable()
///     {
///         m_Player.Disable();                               // Disable all actions within map.
///     }
///
///     #region Interface implementation of MyActions.IPlayerActions
///
///     // Invoked when "Move" action is either started, performed or canceled.
///     public void OnMove(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnMove: {context.ReadValue&lt;Vector2&gt;()}");
///     }
///
///     // Invoked when "Attack" action is either started, performed or canceled.
///     public void OnAttack(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnAttack: {context.ReadValue&lt;float&gt;()}");
///     }
///
///     #endregion
/// }
/// </code>
/// </example>
public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    /// <summary>
    /// Provides access to the underlying asset instance.
    /// </summary>
    public InputActionAsset asset { get; }

    /// <summary>
    /// Constructs a new instance.
    /// </summary>
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""version"": 1,
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""7abfd263-bb92-434a-a6e1-384bbda27d16"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9c18749d-7a66-4e7c-a1f1-fd577b715664"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""eb10d26d-9ee2-4ae3-9e82-8874a4c3e951"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""9c4689f5-077d-4e7b-a95f-e7990376191c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""afeb5324-c85c-4351-bd99-5d6703cdb2af"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""ae16035a-5f2b-41de-a7f3-cb7b3d469034"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fa8f4d5d-a1bb-490e-9f42-760d0b8b0da7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a662e232-7817-4fbe-81c8-95daa41d475e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5114778e-34cb-4c5b-8508-c3b7d0706900"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b35f0a8f-0fe1-4b56-9e31-453e95fe1794"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""405aa2a3-f408-47d6-ba6f-b9d19c015576"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""efc3f80b-b584-4a72-9d00-4cb97d2cd1c9"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7aff7f1f-414f-47d6-a334-fedd5f7e544f"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1064827c-1861-4165-ab61-3cdd244c9d32"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""355006be-f334-47af-834a-315147fdb808"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""ca338fad-e951-45db-b139-b0296a2f9796"",
            ""actions"": [
                {
                    ""name"": ""Unpause"",
                    ""type"": ""Button"",
                    ""id"": ""550a9331-cb76-441c-9cdb-d002470bcb2b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4f82ebaa-9a03-4b18-898a-ba952e7c7bea"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Unpause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Sprint = m_Gameplay.FindAction("Sprint", throwIfNotFound: true);
        m_Gameplay_Crouch = m_Gameplay.FindAction("Crouch", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
        m_Gameplay_Look = m_Gameplay.FindAction("Look", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Unpause = m_UI.FindAction("Unpause", throwIfNotFound: true);
    }

    ~@PlayerControls()
    {
        UnityEngine.Debug.Assert(!m_Gameplay.enabled, "This will cause a leak and performance issues, PlayerControls.Gameplay.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_UI.enabled, "This will cause a leak and performance issues, PlayerControls.UI.Disable() has not been called.");
    }

    /// <summary>
    /// Destroys this asset and all associated <see cref="InputAction"/> instances.
    /// </summary>
    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindingMask" />
    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.devices" />
    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.controlSchemes" />
    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Contains(InputAction)" />
    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.GetEnumerator()" />
    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    /// <inheritdoc cref="IEnumerable.GetEnumerator()" />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Enable()" />
    public void Enable()
    {
        asset.Enable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Disable()" />
    public void Disable()
    {
        asset.Disable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindings" />
    public IEnumerable<InputBinding> bindings => asset.bindings;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindAction(string, bool)" />
    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindBinding(InputBinding, out InputAction)" />
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Sprint;
    private readonly InputAction m_Gameplay_Crouch;
    private readonly InputAction m_Gameplay_Pause;
    private readonly InputAction m_Gameplay_Look;
    /// <summary>
    /// Provides access to input actions defined in input action map "Gameplay".
    /// </summary>
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Move".
        /// </summary>
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Sprint".
        /// </summary>
        public InputAction @Sprint => m_Wrapper.m_Gameplay_Sprint;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Crouch".
        /// </summary>
        public InputAction @Crouch => m_Wrapper.m_Gameplay_Crouch;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Pause".
        /// </summary>
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Look".
        /// </summary>
        public InputAction @Look => m_Wrapper.m_Gameplay_Look;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="GameplayActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="GameplayActions" />
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @Crouch.started += instance.OnCrouch;
            @Crouch.performed += instance.OnCrouch;
            @Crouch.canceled += instance.OnCrouch;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="GameplayActions" />
        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @Crouch.started -= instance.OnCrouch;
            @Crouch.performed -= instance.OnCrouch;
            @Crouch.canceled -= instance.OnCrouch;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />.
        /// </summary>
        /// <seealso cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />
        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="GameplayActions.AddCallbacks(IGameplayActions)" />
        /// <seealso cref="GameplayActions.RemoveCallbacks(IGameplayActions)" />
        /// <seealso cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />
        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="GameplayActions" /> instance referencing this action map.
    /// </summary>
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_Unpause;
    /// <summary>
    /// Provides access to input actions defined in input action map "UI".
    /// </summary>
    public struct UIActions
    {
        private @PlayerControls m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public UIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "UI/Unpause".
        /// </summary>
        public InputAction @Unpause => m_Wrapper.m_UI_Unpause;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="UIActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="UIActions" />
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @Unpause.started += instance.OnUnpause;
            @Unpause.performed += instance.OnUnpause;
            @Unpause.canceled += instance.OnUnpause;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="UIActions" />
        private void UnregisterCallbacks(IUIActions instance)
        {
            @Unpause.started -= instance.OnUnpause;
            @Unpause.performed -= instance.OnUnpause;
            @Unpause.canceled -= instance.OnUnpause;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="UIActions.UnregisterCallbacks(IUIActions)" />.
        /// </summary>
        /// <seealso cref="UIActions.UnregisterCallbacks(IUIActions)" />
        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="UIActions.AddCallbacks(IUIActions)" />
        /// <seealso cref="UIActions.RemoveCallbacks(IUIActions)" />
        /// <seealso cref="UIActions.UnregisterCallbacks(IUIActions)" />
        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="UIActions" /> instance referencing this action map.
    /// </summary>
    public UIActions @UI => new UIActions(this);
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "Gameplay" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="GameplayActions.AddCallbacks(IGameplayActions)" />
    /// <seealso cref="GameplayActions.RemoveCallbacks(IGameplayActions)" />
    public interface IGameplayActions
    {
        /// <summary>
        /// Method invoked when associated input action "Move" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnMove(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Sprint" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnSprint(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Crouch" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnCrouch(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Pause" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPause(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Look" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnLook(InputAction.CallbackContext context);
    }
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "UI" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="UIActions.AddCallbacks(IUIActions)" />
    /// <seealso cref="UIActions.RemoveCallbacks(IUIActions)" />
    public interface IUIActions
    {
        /// <summary>
        /// Method invoked when associated input action "Unpause" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnUnpause(InputAction.CallbackContext context);
    }
}
````

## File: Assets/Input/PlayerControls.inputactions
````
{
    "version": 1,
    "name": "PlayerControls",
    "maps": [
        {
            "name": "Gameplay",
            "id": "7abfd263-bb92-434a-a6e1-384bbda27d16",
            "actions": [
                {
                    "name": "Move",
                    "type": "Value",
                    "id": "9c18749d-7a66-4e7c-a1f1-fd577b715664",
                    "expectedControlType": "Vector2",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": true
                },
                {
                    "name": "Sprint",
                    "type": "Button",
                    "id": "eb10d26d-9ee2-4ae3-9e82-8874a4c3e951",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Crouch",
                    "type": "Button",
                    "id": "9c4689f5-077d-4e7b-a95f-e7990376191c",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Pause",
                    "type": "Button",
                    "id": "afeb5324-c85c-4351-bd99-5d6703cdb2af",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Look",
                    "type": "Value",
                    "id": "ae16035a-5f2b-41de-a7f3-cb7b3d469034",
                    "expectedControlType": "Vector2",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": true
                }
            ],
            "bindings": [
                {
                    "name": "2D Vector",
                    "id": "fa8f4d5d-a1bb-490e-9f42-760d0b8b0da7",
                    "path": "2DVector",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "up",
                    "id": "a662e232-7817-4fbe-81c8-95daa41d475e",
                    "path": "<Keyboard>/w",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "down",
                    "id": "5114778e-34cb-4c5b-8508-c3b7d0706900",
                    "path": "<Keyboard>/s",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "left",
                    "id": "b35f0a8f-0fe1-4b56-9e31-453e95fe1794",
                    "path": "<Keyboard>/a",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "right",
                    "id": "405aa2a3-f408-47d6-ba6f-b9d19c015576",
                    "path": "<Keyboard>/d",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "",
                    "id": "efc3f80b-b584-4a72-9d00-4cb97d2cd1c9",
                    "path": "<XInputController>/leftTrigger",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Sprint",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "7aff7f1f-414f-47d6-a334-fedd5f7e544f",
                    "path": "<XInputController>/leftStick/down",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Crouch",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "1064827c-1861-4165-ab61-3cdd244c9d32",
                    "path": "<Keyboard>/p",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Pause",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "355006be-f334-47af-834a-315147fdb808",
                    "path": "<Mouse>/delta",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Look",
                    "isComposite": false,
                    "isPartOfComposite": false
                }
            ]
        },
        {
            "name": "UI",
            "id": "ca338fad-e951-45db-b139-b0296a2f9796",
            "actions": [
                {
                    "name": "Unpause",
                    "type": "Button",
                    "id": "550a9331-cb76-441c-9cdb-d002470bcb2b",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                }
            ],
            "bindings": [
                {
                    "name": "",
                    "id": "4f82ebaa-9a03-4b18-898a-ba952e7c7bea",
                    "path": "<Keyboard>/p",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Unpause",
                    "isComposite": false,
                    "isPartOfComposite": false
                }
            ]
        }
    ],
    "controlSchemes": []
}
````

## File: repomix-output.xml
````xml
This file is a merged representation of the entire codebase, combined into a single document by Repomix.

<file_summary>
This section contains a summary of this file.

<purpose>
This file contains a packed representation of the entire repository's contents.
It is designed to be easily consumable by AI systems for analysis, code review,
or other automated processes.
</purpose>

<file_format>
The content is organized as follows:
1. This summary section
2. Repository information
3. Directory structure
4. Repository files (if enabled)
5. Multiple file entries, each consisting of:
  - File path as an attribute
  - Full contents of the file
</file_format>

<usage_guidelines>
- This file should be treated as read-only. Any changes should be made to the
  original repository files, not this packed version.
- When processing this file, use the file path to distinguish
  between different files in the repository.
- Be aware that this file may contain sensitive information. Handle it with
  the same level of security as you would the original repository.
</usage_guidelines>

<notes>
- Some files may have been excluded based on .gitignore rules and Repomix's configuration
- Binary files are not included in this packed representation. Please refer to the Repository Structure section for a complete list of file paths, including binary files
- Files matching patterns in .gitignore are excluded
- Files matching default ignore patterns are excluded
- Files are sorted by Git change count (files with more changes are at the bottom)
</notes>

</file_summary>

<directory_structure>
Assets/
  _Scripts/
    Brains/
      EnemyBrain_Color.pdf
      EnemyBrain.cs
      mi_informe.pdf
      script_terror.pdf
    Enums/
      GameEnums.cs
    Interfaces/
      IEstado.cs
    Player/
      PlayerController.cs
      PlayerFear.cs
      PlayerNoise.cs
    States/
      EstadoRastreo.cs
    Systems/
      IntuicionSystem.cs
      TrampaAcustica.cs
    UI/
      UI_BarraMiedo.cs
      UI_MenuManager.cs
  Art/
    Alebardium/
      Bloodlines UI/
        Fonts/
          ManufacturingConsent/
            ManufacturingConsent-Regular.ttf
            OFL.txt
          MedievalSharp/
            MedievalSharp-Regular.ttf
            OFL.txt
        Textures/
          Button/
            Button1/
              Status_Disable.png
              Status_Grey_Default.png
              Status_Grey_Hover.png
              Status_Pressed.png
              Status_Red_Default.png
              Status_Red_Hover.png
            Button2/
              Button2_Status_Disable.png
              Button2_Status_Grey_Default.png
              Button2_Status_Grey_Hover.png
              Button2_Status_Pressed.png
              Button2_Status_Red_Default.png
              Button2_Status_Red_Hover.png
            Button3/
              Button3_Status_Disable.png
              Button3_Status_Grey_Default.png
              Button3_Status_Grey_Hover.png
              Button3_Status_Pressed.png
              Button3_Status_Red_Default.png
              Button3_Status_Red_Hover.png
          Frame/
            Frame_background.png
            Frame_main_menu_red.png
            Frame_main_menu.png
            Frame_outline_red.png
            Frame_outline_v2.png
            Frame_outline.png
          Icon/
            Icons_19.png
            Icons_20.png
            Icons_settins_frame.png
            Icons-1.png
            Icons-16.png
            Icons-17.png
            Icons-18.png
            Icons-2.png
            Icons-3.png
            Icons-4.png
            Icons-5.png
            Icons.png
          Input Field/
            Cross.png
            Frame_input_red.png
            Frame_input.png
          Layout/
            CHECKBOX.png
            Colors.png
            HEALTH.png
            MENU.png
            ON_OFF.png
            PROGRESS_BAR.png
            SETTINGS.png
            TOGGLE_SWITCH.png
          Notice/
            Frame_notice_v1.png
            Frame_notice_v2.png
          Progress_Bar/
            Rectangle/
              Progress_Bar_Rectangle_empty_v1.png
              Progress_Bar_Rectangle_empty_v2.png
              Progress_Bar_Rectangle_empty_v3.png
              Progress_Bar_Rectangle_empty_v4.png
              Progress_Bar_Rectangle_empty_v5.png
              Progress_Bar_Rectangle_full_v1.png
              Progress_Bar_Rectangle_full_v2.png
              Progress_Bar_Rectangle_full_v3.png
              Progress_Bar_Rectangle_full_v4.png
              Progress_Bar_Rectangle_full_v5.png
            Rectangle (Segments)/
              Health_diamond_empty_v1.png
              Health_diamond_empty_v2.png
              Health_diamond_full_v1.png
              Health_diamond_full_v2.png
              Health_rod_empty_v1.png
              Health_rod_full.png
              Slider_5pct_v1.png
              Slider_empty.png
              Slider_full_v1.png
              Slider_toggler.png
            Round/
              Progress_Bar_Round_empty_v1_v4.png
              Progress_Bar_Round_empty_v2_v3.png
              Progress_Bar_Round_full_v1.png
              Progress_Bar_Round_full_v2.png
              Progress_Bar_Round_full_v3.png
              Progress_Bar_Round_full_v4.png
          Toggle/
            Icon Checkmark 1 (Rect).png
            Icon Checkmark 1 (Round).png
            Icon Checkmark 2 (Rect).png
            Icon Checkmark 2 (Round).png
            Icon Checkmark 3 (Rect).png
            Icon Checkmark 3 (Round).png
            Icons-10.png
            Icons-11.png
            Icons-12.png
            Icons-13.png
            Icons-14.png
            Icons-15.png
            Icons-6.png
            Icons-7.png
            Icons-8.png
            Icons-9.png
    Material/
      Enemy_material.mat
      floor_material.mat
      NPC_material.mat
      Player_material.mat
  Input/
    PlayerControls.cs
    PlayerControls.inputactions
  Scenes/
    Catacumbas.unity
    Escena_Inicio.unity
  Sounds/
    Player/
      caminata.wav
      grito.wav
      susurro.wav
  UI Toolkit/
    UnityThemes/
      UnityDefaultRuntimeTheme.tss
  UI_Inicio/
    MenuInicio.uss
    MenuInicio.uxml
    MenuInicioController.cs
  .cursorrules
.gitignore
.repomixignore
Documentacion_Tecnica_Proyecto.md
pagina_codigo-01.png
pagina_codigo-02.png
pagina_codigo-03.png
pagina_codigo-04.png
pagina_codigo-05.png
pagina_codigo-06.png
pagina_codigo-07.png
pagina_codigo-08.png
pagina_codigo-09.png
pagina_codigo-10.png
pagina_codigo-11.png
pagina_codigo-12.png
pagina_codigo-13.png
pagina_codigo-14.png
pagina_codigo-15.png
pagina_codigo-16.png
pagina_codigo-17.png
pagina_codigo-18.png
pagina_codigo-19.png
pagina_codigo-20.png
README.md
repomix-output.md
todos_los_scripts.pdf
</directory_structure>

<files>
This section contains the contents of the repository's files.

<file path="Assets/Art/Alebardium/Bloodlines UI/Fonts/ManufacturingConsent/OFL.txt">
Copyright 2019 The Manufacturing Consent Project Authors (https://github.com/googlefonts/manufacturing-consent-font)

This Font Software is licensed under the SIL Open Font License, Version 1.1.
This license is copied below, and is also available with a FAQ at:
https://openfontlicense.org


-----------------------------------------------------------
SIL OPEN FONT LICENSE Version 1.1 - 26 February 2007
-----------------------------------------------------------

PREAMBLE
The goals of the Open Font License (OFL) are to stimulate worldwide
development of collaborative font projects, to support the font creation
efforts of academic and linguistic communities, and to provide a free and
open framework in which fonts may be shared and improved in partnership
with others.

The OFL allows the licensed fonts to be used, studied, modified and
redistributed freely as long as they are not sold by themselves. The
fonts, including any derivative works, can be bundled, embedded, 
redistributed and/or sold with any software provided that any reserved
names are not used by derivative works. The fonts and derivatives,
however, cannot be released under any other type of license. The
requirement for fonts to remain under this license does not apply
to any document created using the fonts or their derivatives.

DEFINITIONS
"Font Software" refers to the set of files released by the Copyright
Holder(s) under this license and clearly marked as such. This may
include source files, build scripts and documentation.

"Reserved Font Name" refers to any names specified as such after the
copyright statement(s).

"Original Version" refers to the collection of Font Software components as
distributed by the Copyright Holder(s).

"Modified Version" refers to any derivative made by adding to, deleting,
or substituting -- in part or in whole -- any of the components of the
Original Version, by changing formats or by porting the Font Software to a
new environment.

"Author" refers to any designer, engineer, programmer, technical
writer or other person who contributed to the Font Software.

PERMISSION & CONDITIONS
Permission is hereby granted, free of charge, to any person obtaining
a copy of the Font Software, to use, study, copy, merge, embed, modify,
redistribute, and sell modified and unmodified copies of the Font
Software, subject to the following conditions:

1) Neither the Font Software nor any of its individual components,
in Original or Modified Versions, may be sold by itself.

2) Original or Modified Versions of the Font Software may be bundled,
redistributed and/or sold with any software, provided that each copy
contains the above copyright notice and this license. These can be
included either as stand-alone text files, human-readable headers or
in the appropriate machine-readable metadata fields within text or
binary files as long as those fields can be easily viewed by the user.

3) No Modified Version of the Font Software may use the Reserved Font
Name(s) unless explicit written permission is granted by the corresponding
Copyright Holder. This restriction only applies to the primary font name as
presented to the users.

4) The name(s) of the Copyright Holder(s) or the Author(s) of the Font
Software shall not be used to promote, endorse or advertise any
Modified Version, except to acknowledge the contribution(s) of the
Copyright Holder(s) and the Author(s) or with their explicit written
permission.

5) The Font Software, modified or unmodified, in part or in whole,
must be distributed entirely under this license, and must not be
distributed under any other license. The requirement for fonts to
remain under this license does not apply to any document created
using the Font Software.

TERMINATION
This license becomes null and void if any of the above conditions are
not met.

DISCLAIMER
THE FONT SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO ANY WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT
OF COPYRIGHT, PATENT, TRADEMARK, OR OTHER RIGHT. IN NO EVENT SHALL THE
COPYRIGHT HOLDER BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
INCLUDING ANY GENERAL, SPECIAL, INDIRECT, INCIDENTAL, OR CONSEQUENTIAL
DAMAGES, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF THE USE OR INABILITY TO USE THE FONT SOFTWARE OR FROM
OTHER DEALINGS IN THE FONT SOFTWARE.
</file>

<file path="Assets/Art/Alebardium/Bloodlines UI/Fonts/MedievalSharp/OFL.txt">
Copyright (c) 2011, wmk69 (wmk69@o2.pl),
with Reserved Font Name MedievalSharp.

This Font Software is licensed under the SIL Open Font License, Version 1.1.
This license is copied below, and is also available with a FAQ at:
https://openfontlicense.org


-----------------------------------------------------------
SIL OPEN FONT LICENSE Version 1.1 - 26 February 2007
-----------------------------------------------------------

PREAMBLE
The goals of the Open Font License (OFL) are to stimulate worldwide
development of collaborative font projects, to support the font creation
efforts of academic and linguistic communities, and to provide a free and
open framework in which fonts may be shared and improved in partnership
with others.

The OFL allows the licensed fonts to be used, studied, modified and
redistributed freely as long as they are not sold by themselves. The
fonts, including any derivative works, can be bundled, embedded, 
redistributed and/or sold with any software provided that any reserved
names are not used by derivative works. The fonts and derivatives,
however, cannot be released under any other type of license. The
requirement for fonts to remain under this license does not apply
to any document created using the fonts or their derivatives.

DEFINITIONS
"Font Software" refers to the set of files released by the Copyright
Holder(s) under this license and clearly marked as such. This may
include source files, build scripts and documentation.

"Reserved Font Name" refers to any names specified as such after the
copyright statement(s).

"Original Version" refers to the collection of Font Software components as
distributed by the Copyright Holder(s).

"Modified Version" refers to any derivative made by adding to, deleting,
or substituting -- in part or in whole -- any of the components of the
Original Version, by changing formats or by porting the Font Software to a
new environment.

"Author" refers to any designer, engineer, programmer, technical
writer or other person who contributed to the Font Software.

PERMISSION & CONDITIONS
Permission is hereby granted, free of charge, to any person obtaining
a copy of the Font Software, to use, study, copy, merge, embed, modify,
redistribute, and sell modified and unmodified copies of the Font
Software, subject to the following conditions:

1) Neither the Font Software nor any of its individual components,
in Original or Modified Versions, may be sold by itself.

2) Original or Modified Versions of the Font Software may be bundled,
redistributed and/or sold with any software, provided that each copy
contains the above copyright notice and this license. These can be
included either as stand-alone text files, human-readable headers or
in the appropriate machine-readable metadata fields within text or
binary files as long as those fields can be easily viewed by the user.

3) No Modified Version of the Font Software may use the Reserved Font
Name(s) unless explicit written permission is granted by the corresponding
Copyright Holder. This restriction only applies to the primary font name as
presented to the users.

4) The name(s) of the Copyright Holder(s) or the Author(s) of the Font
Software shall not be used to promote, endorse or advertise any
Modified Version, except to acknowledge the contribution(s) of the
Copyright Holder(s) and the Author(s) or with their explicit written
permission.

5) The Font Software, modified or unmodified, in part or in whole,
must be distributed entirely under this license, and must not be
distributed under any other license. The requirement for fonts to
remain under this license does not apply to any document created
using the Font Software.

TERMINATION
This license becomes null and void if any of the above conditions are
not met.

DISCLAIMER
THE FONT SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO ANY WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT
OF COPYRIGHT, PATENT, TRADEMARK, OR OTHER RIGHT. IN NO EVENT SHALL THE
COPYRIGHT HOLDER BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
INCLUDING ANY GENERAL, SPECIAL, INDIRECT, INCIDENTAL, OR CONSEQUENTIAL
DAMAGES, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF THE USE OR INABILITY TO USE THE FONT SOFTWARE OR FROM
OTHER DEALINGS IN THE FONT SOFTWARE.
</file>

<file path="Assets/_Scripts/Player/PlayerFear.cs">
// -----------------------------------------------------------------------------
//  PlayerFear.cs
//  Se suscribe a la "radio" del IntuicionSystem y ajusta el movimiento del
//  jugador basándose en los niveles de miedo del enemigo.
//  Este script DEBE estar adjunto al mismo GameObject que tiene el PlayerController 
//  (por ejemplo, la cápsula del jugador).
// -----------------------------------------------------------------------------
using UnityEngine;

namespace _Scripts.Player
{
    // Garantiza de forma segura que el GameObject tenga un PlayerController.
    // Si no existe, Unity lo añadirá automáticamente para evitar errores de referencia nula en tiempo de ejecución.
    [RequireComponent(typeof(PlayerController))]
    public class PlayerFear : MonoBehaviour
    {
        [Header("Intuicion System (Data Asset)")]
        [Tooltip("Asigna aquí el ScriptableObject de IntuicionSystem que utiliza el EnemyBrain.")]
        [SerializeField] private _Scripts.Systems.IntuicionSystem intuicionSystem;

        // Referencia interna al controlador de movimiento del jugador.
        private PlayerController playerController;
        
        // Nivel de miedo actual del jugador. Rango: 0 (calma total) hasta 4 (terror absoluto).
        private int fearLevel = 0; 
        
        // Límite máximo del nivel de miedo. Corresponde a un factor de 0.8 (80% de penalización de velocidad).
        private const int MaxFearLevel = 4; 

        /// <summary>
        /// Awake se ejecuta al cargar la instancia del script, antes de que empiece el juego.
        /// Ideal para inicializar y capturar componentes internos de forma optimizada sin usar GameObject.Find.
        /// </summary>
        private void Awake()
        {
            // Cacheamos el componente PlayerController que está en este mismo objeto.
            playerController = GetComponent<PlayerController>();
        }

        /// <summary>
        /// Se activa automáticamente cada vez que el objeto se habilita en la escena.
        /// Aquí nos "sintonizamos" a la radio del sistema de intuición (Eventos).
        /// </summary>
        private void OnEnable()
        {
            // Verificación de seguridad por si olvidaste arrastrar el ScriptableObject en el Inspector.
            if (intuicionSystem != null)
            {
                // Nos suscribimos a los eventos. Cuando la IA suba o baje de fase,
                // este script se enterará inmediatamente de forma asíncrona.
                intuicionSystem.OnSubirFase += HandleSubirFase;
                intuicionSystem.OnBajarFase += HandleBajarFase;
            }
        }

        /// <summary>
        /// Se activa automáticamente cuando el objeto se deshabilita o se destruye.
        /// CRUCIAL: Siempre hay que desvincular los eventos para evitar fugas de memoria (Memory Leaks).
        /// </summary>
        private void OnDisable()
        {
            if (intuicionSystem != null)
            {
                // Nos desuscribimos de los eventos para limpiar las referencias en memoria.
                intuicionSystem.OnSubirFase -= HandleSubirFase;
                intuicionSystem.OnBajarFase -= HandleBajarFase;
            }
        }

        /// <summary>
        /// Método manejador que se ejecuta automáticamente cuando el sistema avisa que el enemigo subió de fase.
        /// </summary>
        private void HandleSubirFase()
        {
            // Incrementamos el miedo en 1, pero usamos Mathf.Clamp para asegurar 
            // que matemáticamente nunca supere el MaxFearLevel (4) ni baje de 0.
            fearLevel = Mathf.Clamp(fearLevel + 1, 0, MaxFearLevel);
            
            // Recalculamos y aplicamos el peso del terror al jugador.
            ApplyFearPenalty();
        }

        /// <summary>
        /// Método manejador que se ejecuta automáticamente cuando el sistema avisa que el enemigo bajó de fase (se enfrió).
        /// </summary>
        private void HandleBajarFase()
        {
            // Decrementamos el miedo en 1, manteniendo el valor protegido entre 0 y 4.
            fearLevel = Mathf.Clamp(fearLevel - 1, 0, MaxFearLevel);
            
            // Recalculamos y aplicamos el peso del terror al jugador.
            ApplyFearPenalty();
        }

        /// <summary>
        /// Traduce el nivel de miedo entero (0 a 4) en un porcentaje decimal de penalización física 
        /// y se lo inyecta al PlayerController.
        /// </summary>
        private void ApplyFearPenalty()
        {
            // Control de daños: Si por alguna razón el script se rompió o no tiene el controlador, cancela la ejecución.
            if (playerController == null) return;
            
            // EXPLICACIÓN MATEMÁTICA DEL FACTOR:
            // 1. (float)fearLevel de la línea inferior convierte el entero a float para permitir divisiones decimales exactas.
            // 2. Se divide entre MaxFearLevel (4) para obtener un porcentaje normalizado de 0.0 a 1.0.
            // 3. Se multiplica por 0.8f para escalar ese porcentaje a un rango final de 0.0 a 0.8.
            // Ejemplos de resultado según la fase:
            // - Miedo 0: (0 / 4) * 0.8 = 0.0  -> 0% de reducción (Velocidad normal).
            // - Miedo 1: (1 / 4) * 0.8 = 0.2  -> 20% de reducción.
            // - Miedo 2: (2 / 4) * 0.8 = 0.4  -> 40% de reducción.
            // - Miedo 3: (3 / 4) * 0.8 = 0.6  -> 60% de reducción.
            // - Miedo 4: (4 / 4) * 0.8 = 0.8  -> 80% de reducción (El jugador apenas puede arrastrarse del susto).
            float factor = (float)fearLevel / MaxFearLevel * 0.8f;
            
            // Le enviamos este factor limpio al PlayerController para que reste velocidad o altere el movimiento.
            playerController.AplicarPenalizacionMiedo(factor);
        }
    }
}
</file>

<file path="Assets/_Scripts/Player/PlayerNoise.cs">
using UnityEngine;
using _Scripts.Systems; // Para ver el IntuicionSystem
using _Scripts.Enums;   // Para ver el PerfilAcustico

namespace _Scripts.Player
{
    /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
     * CLASE: PlayerNoise (El Generador de Pulsos)
     * Se encarga de medir el tiempo entre pasos, reproducir el audio 
     * local para asustar al jugador humano, y enviar el "Paquete de Datos"
     * matemático al cerebro del enemigo.
     * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
    public class PlayerNoise : MonoBehaviour
    {
        [Header("Comunicaciones (Los Cables)")]
        [Tooltip("El 'buzón' central donde dejaremos el paquete de ruido")]
        /*Oye, en este espacio solo se pueden guardar cosas que tengan la estructura de IntuicionSystem
         dataIntuicion es solo un puntero inalambrico*/
        [SerializeField] private IntuicionSystem dataIntuicion; 
        
        [Tooltip("El cuerpo del enemigo para poder calcular a cuántos metros estamos")]
        [SerializeField] private Transform transformEnemigo;

        [Header("Configuración de Audio Físico")]
        [Tooltip("El parlante que reproducirá los .wav en los pies/boca del jugador")]
        [SerializeField] private AudioSource emisorDeSonido;
        
        [Tooltip("Audios para cuando el jugador va lento/agachado")]
        [SerializeField] private AudioClip audioSusurro; 
        
        [Tooltip("Audios para cuando el jugador camina normal")]
        [SerializeField] private AudioClip audioPasoNormal;
        
        [Tooltip("Audios para cuando el jugador corre asustado")]
        [SerializeField] private AudioClip audioGritoSusto;

        // --- EL ETIQUETADOR DE ESTADOS ---
        // Este enum local nos dice qué está haciendo el jugador AHORA MISMO.
        // Más adelante, el script de movimiento cambiará esta variable automáticamente.
        public enum EstadoMovimiento { Quieto, Agachado, Caminando, Corriendo }
        
        [Header("Estado Actual (Pruebas)")]
        [Tooltip("Cambia esto en Unity mientras juegas para probar los distintos ruidos")]
        public EstadoMovimiento estadoActual = EstadoMovimiento.Quieto;

        // El segundero que cuenta el tiempo entre un paso y otro
        private float _cronometroPulso = 0f;

        private void Start()
        {
            // Cláusulas de salvaguarda: Avisamos si olvidaste conectar algo en el Inspector
            if (!dataIntuicion) Debug.LogError("PlayerNoise: Falta conectar el IntuicionSystem.");
            if (!transformEnemigo) Debug.LogError("PlayerNoise: Falta el Transform del Enemigo.");
            if (!emisorDeSonido) Debug.LogError("PlayerNoise: Falta el AudioSource.");
        }

        private void Update()
        {
            // Si falta el buzón de datos, no hacemos nada, para, evitar que el juego explote
            if (!dataIntuicion || !transformEnemigo) return;

            // 1. EL RELOJ: Definimos qué tan rápido late el pulso según el estado
            float tiempoEntrePulsos = 0f;

            switch (estadoActual)
            {
                case EstadoMovimiento.Quieto: 
                    _cronometroPulso = 0f; // Reseteamos el reloj
                    return; // Salimos del Update, no hay ruido que hacer
                
                case EstadoMovimiento.Agachado: 
                    tiempoEntrePulsos = 1.2f; // Un pulso lento (mucho espacio entre pasos)
                    break;
                
                case EstadoMovimiento.Caminando: 
                    tiempoEntrePulsos = 0.7f; // Un pulso normal
                    break;
                
                case EstadoMovimiento.Corriendo: 
                    tiempoEntrePulsos = 0.3f; // Un pulso rapidísimo (pasos acelerados)
                    break;
            }

            // 2. EL SEGUNDERO AVANZA
            _cronometroPulso += Time.deltaTime;

            // 3. EL DISPARO
            if (_cronometroPulso >= tiempoEntrePulsos)
            {
                EmitirRuidoDelPulso();
                _cronometroPulso = 0f; // Vaciamos el reloj para empezar a contar el siguiente paso
            }
        }

        /* * *
         * MÉTODO: EmitirRuidoDelPulso
         * Se ejecuta solo en el frame exacto en el que el pie toca el suelo.
         * Prepara el paquete, reproduce el .wav y lo envía por correo.
         */
        // ReSharper disable Unity.PerformanceAnalysis
        private void EmitirRuidoDelPulso()
        {
            // A. Calculamos la distancia real en metros usando trigonometría de Unity
            float distanciaAlEnemigo = Vector3.Distance(transform.position, transformEnemigo.position);

            // B. Preparamos las variables que meteremos en el paquete
            float volumenPaquete = 0f;
            PerfilAcustico perfilPaquete = PerfilAcustico.GraveFisico; // Por defecto
            AudioClip clipFalsoParaHumano = null;

            // C. Rellenamos el paquete según el estado
            switch (estadoActual)
            {
                case EstadoMovimiento.Agachado:
                    volumenPaquete = 0.1f; // Muy bajito
                    perfilPaquete = PerfilAcustico.AgudoVocal; // Un susurro que se apaga rápido en la distancia
                    clipFalsoParaHumano = audioSusurro;
                    break;

                case EstadoMovimiento.Caminando:
                    volumenPaquete = 0.3f; // Medio
                    perfilPaquete = PerfilAcustico.GraveFisico; // Un paso que hace vibrar el suelo
                    clipFalsoParaHumano = audioPasoNormal;
                    break;

                case EstadoMovimiento.Corriendo:
                    volumenPaquete = 0.8f; // Escandaloso
                    perfilPaquete = PerfilAcustico.AgudoVocal; // Un grito/jadeo de pánico
                    clipFalsoParaHumano = audioGritoSusto;
                    break;
            }

            // D. LA MAGIA: Actualizamos la posición sospechosa...
            dataIntuicion.posicionSospechosa = transform.position;
            
            // ... Y enviamos el paquete matemático al IntuicionSystem
            // ¡Fíjate cómo usamos el Enum aquí como una etiqueta de envío!
            dataIntuicion.ModificarIntuicion(volumenPaquete, distanciaAlEnemigo, perfilPaquete);

            // E. EL TEATRO: Reproducimos el archivo .wav real para asustar al jugador
            if (emisorDeSonido && clipFalsoParaHumano)
            {
                emisorDeSonido.PlayOneShot(clipFalsoParaHumano);
            }
            
            // Un log para que tú como desarrollador veas que el pulso salió bien
            Debug.Log($"<color=yellow>PULSO: {estadoActual} | Vol: {volumenPaquete} | Perfil: {perfilPaquete} | Dist: {distanciaAlEnemigo:F1}m</color>");
        }
    }
}
</file>

<file path="Assets/_Scripts/Systems/TrampaAcustica.cs">
using UnityEngine;
using System.Collections;
using _Scripts.Enums;

namespace _Scripts.Systems
{
    [RequireComponent(typeof(AudioSource))]
    public class TrampaAcustica : MonoBehaviour
    {
        public IntuicionSystem dataIntuicion;
        [Range(0f, 1f)] public float volumenAlerta = 0.3f;
        public PerfilAcustico perfilAcustico = PerfilAcustico.GraveFisico;
        public float tiempoApagado = 4.0f;

        private AudioSource _audioSource;
        private bool _jugadorPresente = false;
        private Coroutine _rutinaApagado;

        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
            _audioSource.playOnAwake = false;
            _audioSource.loop = true;
            _audioSource.spatialBlend = 1.0f;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                _jugadorPresente = true;

                if (_rutinaApagado != null)
                {
                    StopCoroutine(_rutinaApagado);
                    _rutinaApagado = null;
                }

                if (!_audioSource.isPlaying)
                {
                    _audioSource.Play();
                }

                if (dataIntuicion != null)
                {
                    dataIntuicion.posicionSospechosa = transform.position;

                    GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
                    if (enemy != null)
                    {
                        float distanciaAlMonstruo = Vector3.Distance(transform.position, enemy.transform.position);
                        dataIntuicion.ModificarIntuicion(volumenAlerta, distanciaAlMonstruo, perfilAcustico);
                    }
                }
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                _jugadorPresente = false;
                if (_rutinaApagado != null)
                {
                    StopCoroutine(_rutinaApagado);
                }
                _rutinaApagado = StartCoroutine(RutinaApagarAudio());
            }
        }

        private IEnumerator RutinaApagarAudio()
        {
            yield return new WaitForSeconds(tiempoApagado);
            
            if (!_jugadorPresente && _audioSource.isPlaying)
            {
                _audioSource.Stop();
            }
            _rutinaApagado = null;
        }
    }
}
</file>

<file path="Assets/_Scripts/UI/UI_BarraMiedo.cs">
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
</file>

<file path="Assets/Art/Material/Enemy_material.mat">
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 8
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Enemy_material
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_Parent: {fileID: 0}
  m_ModifiedSerializedProperties: 0
  m_ValidKeywords: []
  m_InvalidKeywords: []
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_LockedProperties: 
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Ints: []
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0.5
    - _GlossyReflections: 1
    - _Metallic: 1
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.4641646, g: 0.14346741, b: 0.49056602, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}
  m_BuildTextureStacks: []
</file>

<file path="Assets/Art/Material/floor_material.mat">
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 8
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: floor_material
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_Parent: {fileID: 0}
  m_ModifiedSerializedProperties: 0
  m_ValidKeywords: []
  m_InvalidKeywords: []
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_LockedProperties: 
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Ints: []
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0.5
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.09230664, g: 0.33962262, b: 0.014417935, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}
  m_BuildTextureStacks: []
</file>

<file path="Assets/Art/Material/NPC_material.mat">
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 8
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: NPC_material
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_Parent: {fileID: 0}
  m_ModifiedSerializedProperties: 0
  m_ValidKeywords: []
  m_InvalidKeywords: []
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_LockedProperties: 
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Ints: []
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0.5
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.6132076, g: 0.057849765, b: 0.057849765, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}
  m_BuildTextureStacks: []
</file>

<file path="Assets/Art/Material/Player_material.mat">
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 8
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Player_material
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_Parent: {fileID: 0}
  m_ModifiedSerializedProperties: 0
  m_ValidKeywords: []
  m_InvalidKeywords: []
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_LockedProperties: 
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Ints: []
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0.247
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.8584906, g: 0.49808654, b: 0.74376494, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}
  m_BuildTextureStacks: []
</file>

<file path="Assets/Scenes/Escena_Inicio.unity">
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!29 &1
OcclusionCullingSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  m_OcclusionBakeSettings:
    smallestOccluder: 5
    smallestHole: 0.25
    backfaceThreshold: 100
  m_SceneGUID: 00000000000000000000000000000000
  m_OcclusionCullingData: {fileID: 0}
--- !u!104 &2
RenderSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 9
  m_Fog: 0
  m_FogColor: {r: 0.5, g: 0.5, b: 0.5, a: 1}
  m_FogMode: 3
  m_FogDensity: 0.01
  m_LinearFogStart: 0
  m_LinearFogEnd: 300
  m_AmbientSkyColor: {r: 0.212, g: 0.227, b: 0.259, a: 1}
  m_AmbientEquatorColor: {r: 0.114, g: 0.125, b: 0.133, a: 1}
  m_AmbientGroundColor: {r: 0.047, g: 0.043, b: 0.035, a: 1}
  m_AmbientIntensity: 1
  m_AmbientMode: 0
  m_SubtractiveShadowColor: {r: 0.42, g: 0.478, b: 0.627, a: 1}
  m_SkyboxMaterial: {fileID: 10304, guid: 0000000000000000f000000000000000, type: 0}
  m_HaloStrength: 0.5
  m_FlareStrength: 1
  m_FlareFadeSpeed: 3
  m_HaloTexture: {fileID: 0}
  m_SpotCookie: {fileID: 10001, guid: 0000000000000000e000000000000000, type: 0}
  m_DefaultReflectionMode: 0
  m_DefaultReflectionResolution: 128
  m_ReflectionBounces: 1
  m_ReflectionIntensity: 1
  m_CustomReflection: {fileID: 0}
  m_Sun: {fileID: 0}
  m_UseRadianceAmbientProbe: 0
--- !u!157 &3
LightmapSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 12
  m_GIWorkflowMode: 1
  m_GISettings:
    serializedVersion: 2
    m_BounceScale: 1
    m_IndirectOutputScale: 1
    m_AlbedoBoost: 1
    m_EnvironmentLightingMode: 0
    m_EnableBakedLightmaps: 1
    m_EnableRealtimeLightmaps: 0
  m_LightmapEditorSettings:
    serializedVersion: 12
    m_Resolution: 2
    m_BakeResolution: 40
    m_AtlasSize: 1024
    m_AO: 0
    m_AOMaxDistance: 1
    m_CompAOExponent: 1
    m_CompAOExponentDirect: 0
    m_ExtractAmbientOcclusion: 0
    m_Padding: 2
    m_LightmapParameters: {fileID: 0}
    m_LightmapsBakeMode: 1
    m_TextureCompression: 1
    m_FinalGather: 0
    m_FinalGatherFiltering: 1
    m_FinalGatherRayCount: 256
    m_ReflectionCompression: 2
    m_MixedBakeMode: 2
    m_BakeBackend: 1
    m_PVRSampling: 1
    m_PVRDirectSampleCount: 32
    m_PVRSampleCount: 512
    m_PVRBounces: 2
    m_PVREnvironmentSampleCount: 256
    m_PVREnvironmentReferencePointCount: 2048
    m_PVRFilteringMode: 1
    m_PVRDenoiserTypeDirect: 1
    m_PVRDenoiserTypeIndirect: 1
    m_PVRDenoiserTypeAO: 1
    m_PVRFilterTypeDirect: 0
    m_PVRFilterTypeIndirect: 0
    m_PVRFilterTypeAO: 0
    m_PVREnvironmentMIS: 1
    m_PVRCulling: 1
    m_PVRFilteringGaussRadiusDirect: 1
    m_PVRFilteringGaussRadiusIndirect: 5
    m_PVRFilteringGaussRadiusAO: 2
    m_PVRFilteringAtrousPositionSigmaDirect: 0.5
    m_PVRFilteringAtrousPositionSigmaIndirect: 2
    m_PVRFilteringAtrousPositionSigmaAO: 1
    m_ExportTrainingData: 0
    m_TrainingDataDestination: TrainingData
    m_LightProbeSampleCountMultiplier: 4
  m_LightingDataAsset: {fileID: 0}
  m_LightingSettings: {fileID: 0}
--- !u!196 &4
NavMeshSettings:
  serializedVersion: 2
  m_ObjectHideFlags: 0
  m_BuildSettings:
    serializedVersion: 3
    agentTypeID: 0
    agentRadius: 0.5
    agentHeight: 2
    agentSlope: 45
    agentClimb: 0.4
    ledgeDropHeight: 0
    maxJumpAcrossDistance: 0
    minRegionArea: 2
    manualCellSize: 0
    cellSize: 0.16666667
    manualTileSize: 0
    tileSize: 256
    buildHeightMesh: 0
    maxJobWorkers: 0
    preserveTilesOutsideBounds: 0
    debug:
      m_Flags: 0
  m_NavMeshData: {fileID: 0}
--- !u!1 &134219226
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 134219229}
  - component: {fileID: 134219228}
  - component: {fileID: 134219227}
  m_Layer: 0
  m_Name: EventSystem
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!114 &134219227
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 134219226}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 01614664b831546d2ae94a42149d80ac, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_SendPointerHoverToParent: 1
  m_MoveRepeatDelay: 0.5
  m_MoveRepeatRate: 0.1
  m_XRTrackingOrigin: {fileID: 0}
  m_ActionsAsset: {fileID: -944628639613478452, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_PointAction: {fileID: -1654692200621890270, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_MoveAction: {fileID: -8784545083839296357, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_SubmitAction: {fileID: 392368643174621059, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_CancelAction: {fileID: 7727032971491509709, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_LeftClickAction: {fileID: 3001919216989983466, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_MiddleClickAction: {fileID: -2185481485913320682, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_RightClickAction: {fileID: -4090225696740746782, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_ScrollWheelAction: {fileID: 6240969308177333660, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_TrackedDevicePositionAction: {fileID: 6564999863303420839, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_TrackedDeviceOrientationAction: {fileID: 7970375526676320489, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_DeselectOnBackgroundClick: 1
  m_PointerBehavior: 0
  m_CursorLockBehavior: 0
  m_ScrollDeltaPerTick: 6
--- !u!114 &134219228
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 134219226}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 76c392e42b5098c458856cdf6ecaaaa1, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_FirstSelected: {fileID: 0}
  m_sendNavigationEvents: 1
  m_DragThreshold: 10
--- !u!4 &134219229
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 134219226}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &732479689
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 732479691}
  - component: {fileID: 732479690}
  - component: {fileID: 732479692}
  m_Layer: 0
  m_Name: UI_Document_Manager
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!114 &732479690
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 732479689}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 19102, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_PanelSettings: {fileID: 11400000, guid: 4425d11ec82b03b408be9b9c96826225, type: 2}
  m_ParentUI: {fileID: 0}
  sourceAsset: {fileID: 9197481963319205126, guid: 337cd63dde14bd7059adb662f049dd56, type: 3}
  m_SortingOrder: 0
--- !u!4 &732479691
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 732479689}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 1.1999894, y: 0.049994383, z: 5.089841}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &732479692
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 732479689}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 2190a56341500098da2ac6305580ead0, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  escenaGameplay: Catacumbas
--- !u!1 &1118566622
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1118566624}
  - component: {fileID: 1118566623}
  m_Layer: 0
  m_Name: Directional Light
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!108 &1118566623
Light:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1118566622}
  m_Enabled: 1
  serializedVersion: 10
  m_Type: 1
  m_Shape: 0
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_Intensity: 1
  m_Range: 10
  m_SpotAngle: 30
  m_InnerSpotAngle: 21.80208
  m_CookieSize: 10
  m_Shadows:
    m_Type: 0
    m_Resolution: -1
    m_CustomResolution: -1
    m_Strength: 1
    m_Bias: 0.05
    m_NormalBias: 0.4
    m_NearPlane: 0.2
    m_CullingMatrixOverride:
      e00: 1
      e01: 0
      e02: 0
      e03: 0
      e10: 0
      e11: 1
      e12: 0
      e13: 0
      e20: 0
      e21: 0
      e22: 1
      e23: 0
      e30: 0
      e31: 0
      e32: 0
      e33: 1
    m_UseCullingMatrixOverride: 0
  m_Cookie: {fileID: 0}
  m_DrawHalo: 0
  m_Flare: {fileID: 0}
  m_RenderMode: 0
  m_CullingMask:
    serializedVersion: 2
    m_Bits: 4294967295
  m_RenderingLayerMask: 1
  m_Lightmapping: 4
  m_LightShadowCasterMode: 0
  m_AreaSize: {x: 1, y: 1}
  m_BounceIntensity: 1
  m_ColorTemperature: 6570
  m_UseColorTemperature: 0
  m_BoundingSphereOverride: {x: 0, y: 0, z: 0, w: 0}
  m_UseBoundingSphereOverride: 0
  m_UseViewFrustumForShadowCasterCull: 1
  m_ShadowRadius: 0
  m_ShadowAngle: 0
--- !u!4 &1118566624
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1118566622}
  serializedVersion: 2
  m_LocalRotation: {x: 0.40821788, y: -0.23456968, z: 0.10938163, w: 0.8754261}
  m_LocalPosition: {x: 1.1999894, y: 0.049994383, z: 5.089841}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 50, y: -30, z: 0}
--- !u!1 &1206418219
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1206418222}
  - component: {fileID: 1206418221}
  - component: {fileID: 1206418220}
  m_Layer: 0
  m_Name: Camera
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!81 &1206418220
AudioListener:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1206418219}
  m_Enabled: 1
--- !u!20 &1206418221
Camera:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1206418219}
  m_Enabled: 1
  serializedVersion: 2
  m_ClearFlags: 1
  m_BackGroundColor: {r: 0.19215687, g: 0.3019608, b: 0.4745098, a: 0}
  m_projectionMatrixMode: 1
  m_GateFitMode: 2
  m_FOVAxisMode: 0
  m_Iso: 200
  m_ShutterSpeed: 0.005
  m_Aperture: 16
  m_FocusDistance: 10
  m_FocalLength: 50
  m_BladeCount: 5
  m_Curvature: {x: 2, y: 11}
  m_BarrelClipping: 0.25
  m_Anamorphism: 0
  m_SensorSize: {x: 36, y: 24}
  m_LensShift: {x: 0, y: 0}
  m_NormalizedViewPortRect:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1
    height: 1
  near clip plane: 0.3
  far clip plane: 1000
  field of view: 60
  orthographic: 0
  orthographic size: 5
  m_Depth: 0
  m_CullingMask:
    serializedVersion: 2
    m_Bits: 4294967295
  m_RenderingPath: -1
  m_TargetTexture: {fileID: 0}
  m_TargetDisplay: 0
  m_TargetEye: 3
  m_HDR: 1
  m_AllowMSAA: 1
  m_AllowDynamicResolution: 0
  m_ForceIntoRT: 0
  m_OcclusionCulling: 1
  m_StereoConvergence: 10
  m_StereoSeparation: 0.022
--- !u!4 &1206418222
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1206418219}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 1.1999894, y: 0.049994383, z: 5.089841}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1660057539 &9223372036854775807
SceneRoots:
  m_ObjectHideFlags: 0
  m_Roots:
  - {fileID: 732479691}
  - {fileID: 1118566624}
  - {fileID: 1206418222}
  - {fileID: 134219229}
</file>

<file path="Assets/UI Toolkit/UnityThemes/UnityDefaultRuntimeTheme.tss">
@import url("unity-theme://default");
</file>

<file path="Assets/UI_Inicio/MenuInicio.uss">
.pantalla-completa {
    width: 100%;
    height: 100%;
    background-color: #000000;
    align-items: center;
    justify-content: center;
}

.contenedor-centrado {
    align-items: center;
    justify-content: center;
}

.titulo-juego {
    font-size: 72px;
    color: #AA0000;
    -unity-font-style: bold;
    margin-bottom: 50px;
}

.boton-inicio {
    background-color: #222222;
    border-width: 1px;
    border-color: #555555;
    color: #FFFFFF;
    padding-top: 15px;
    padding-bottom: 15px;
    padding-left: 40px;
    padding-right: 40px;
    font-size: 24px;
    transition-duration: 0.3s;
    transition-property: scale, background-color;
}

.boton-inicio:hover {
    scale: 1.05;
    background-color: #444444;
}
</file>

<file path="Assets/UI_Inicio/MenuInicio.uxml">
<ui:UXML xmlns:ui="UnityEngine.UIElements" xmlns:uie="UnityEditor.UIElements" xsi="http://www.w3.org/2001/XMLSchema-instance" editor="UnityEditor.UIElements" noNamespaceSchemaLocation="../../UIElementsSchema/UIElements.xsd" editor-extension-mode="False">
    <Style src="project://database/Assets/UI_Inicio/MenuInicio.uss?fileID=7433441132597879392&amp;guid=9655d613110827a83ae6327c73cfdb95&amp;type=3#MenuInicio" />
    <ui:VisualElement class="pantalla-completa" picking-mode="Ignore">
        <ui:VisualElement class="contenedor-centrado" picking-mode="Ignore">
            <ui:Label text="PROTOTYPE TERROR" class="titulo-juego" />
            <ui:Button text="ENTRAR AL HORROR" parse-escape-sequences="true" display-tooltip-when-elided="true" name="btnJugar" picking-mode="Position" style="position: absolute; height: 33px; top: 74px; -unity-text-align: middle-right;" />
        </ui:VisualElement>
    </ui:VisualElement>
</ui:UXML>
</file>

<file path="Assets/UI_Inicio/MenuInicioController.cs">
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
</file>

<file path="Assets/.cursorrules">
# MANUAL DE OPERACIÓN DE UNITY & ANTIGRAVITY (MCP)

## 1. Directrices de Optimización de Tokens y Rendimiento
- **Diagnóstico Obligatorio:** Antes de proponer modificaciones de código o corregir errores de compilación/ejecución, DEBES inspeccionar el estado real del proyecto usando 'read_console' o los recursos de escena de GameObject. No adivines soluciones sin ver los logs.
- **Uso de Lotes (Batching):** Para cualquier tarea que implique crear, mover o modificar más de 2 objetos o componentes secuencialmente, utiliza obligatoriamente la herramienta 'batch_execute'. No realices múltiples llamadas secuenciales a herramientas individuales.
- **Modificaciones Quirúrgicas:** Para editar scripts de C#, utiliza prioritariamente la herramienta 'script_apply_edits' con operaciones enfocadas ('replace_method', 'insert_method') en lugar de reescribir o reemplazar archivos de código completos.
- **Validación de APIs en Vivo:** Si necesitas usar clases o métodos de paquetes específicos (como Cinemachine, URP o el nuevo Input System), verifica su existencia y firma exacta primero mediante 'unity_reflect' antes de escribir código.
- **Control de Capturas Visuales:** Limita el uso del parámetro 'include_image=true' en capturas de pantalla ('manage_camera' o 'manage_ui') estrictamente a validaciones visuales críticas que requiera el usuario. Prefiero comprobar jerarquías o datos puros para ahorrar contexto de tokens.

## 2. Reglas del Chasis y Arquitectura del Juego (Prototype Terror)
- **Nombres Clave Obligatorios:** Respeta minuciosamente el Diccionario de Identidad del proyecto:
  * Estados del Player (FasePlayer): Alerta, Sobresalto, Colapso, Horror.
  * Estados del Enemigo (FaseEnemigo): Rastreo, Sigilo, Persecucion, SedDeSangre.
  * Variable de Control Global: 'intuicion' (un acumulador de tipo float de 0.0 a 1.0 dentro del ScriptableObject 'IntuicionSystem').
- **Arquitectura de la IA (EnemyBrain):** Los estados de la IA del enemigo deben desacoplarse del jugador e implementar obligatoriamente la interfaz 'IEstado' (con sus contratos Entrar, Ejecutar, Salir).
- **Rendimiento de Eventos:** Prohíbe el uso de ciclos 'Update()' innecesarios en scripts de interfaz o escucha de datos; toda actualización de estado físico, de miedo o de interfaz debe responder de forma pasiva a eventos o cambios del ScriptableObject.
- **Código Limpio:** Todos los scripts generados deben incluir comentarios estructurados en español detallando la lógica del chasis y finalizar con una línea en blanco (Render Final Newline).

## 3. Interfaces con UI Toolkit
- **Estructura UXML:** Asegúrate de utilizar siempre el prefijo de namespace '<ui:Style>' para añadir hojas de estilos en los archivos UXML. Nunca uses etiquetas '<Style>' desnudas porque rompen el UI Builder de Unity.
</file>

<file path=".gitignore">
# This .gitignore file should be placed at the root of your Unity project directory
#
# Get latest from https://github.com/github/gitignore/blob/master/Unity.gitignore
#
/[Ll]ibrary/
/[Tt]emp/
/[Oo]bj/
/[Bb]uild/
/[Bb]uilds/
/[Ll]ogs/
/[Mm]emoryCaptures/

# Never ignore Asset meta data
!/[Aa]ssets/**/*.meta

# Uncomment this line if you wish to ignore the asset store tools plugin
# /[Aa]ssets/AssetStoreTools*

# TextMesh Pro files
[Aa]ssets/TextMesh*Pro/

# Autogenerated Jetbrains Rider plugin
[Aa]ssets/Plugins/Editor/JetBrains*

# Visual Studio cache directory
.vs/

# Gradle cache directory
.gradle/

# Autogenerated VS/MD/Consulo solution and project files
ExportedObj/
.consulo/
*.csproj
*.unityproj
*.sln
*.suo
*.tmp
*.user
*.userprefs
*.pidb
*.booproj
*.svd
*.pdb
*.mdb
*.opendb
*.VC.db

# Unity3D generated meta files
*.pidb.meta
*.pdb.meta
*.mdb.meta

# Unity3D generated file on crash reports
sysinfo.txt

# Builds
*.apk
*.unitypackage

# Crashlytics generated file
crashlytics-build.properties
</file>

<file path=".repomixignore">
# Excluir carpetas pesadas o inútiles de Unity
Library/
Temp/
Obj/
Logs/
UserSettings/
MemoryCaptures/
Builds/
*.meta
*.unitypackage
*.asset
*.prefab
UserSettings/
Packages/
ProjectSettings/
*.meta
</file>

<file path="Documentacion_Tecnica_Proyecto.md">
This file is a merged representation of the entire codebase, combining all repository files into a single document.
Generated by Repopack on: 2026-06-29T22:07:44.253Z

================================================================
File Summary
================================================================

Purpose:
--------
This file contains a packed representation of the entire repository's contents.
It is designed to be easily consumable by AI systems for analysis, code review,
or other automated processes.

File Format:
------------
The content is organized as follows:
1. This summary section
2. Repository information
3. Repository structure
4. Multiple file entries, each consisting of:
  a. A separator line (================)
  b. The file path (File: path/to/file)
  c. Another separator line
  d. The full contents of the file
  e. A blank line

Usage Guidelines:
-----------------
- This file should be treated as read-only. Any changes should be made to the
  original repository files, not this packed version.
- When processing this file, use the file path to distinguish
  between different files in the repository.
- Be aware that this file may contain sensitive information. Handle it with
  the same level of security as you would the original repository.

Notes:
------
- Some files may have been excluded based on .gitignore rules and Repopack's
  configuration.
- Binary files are not included in this packed representation. Please refer to
  the Repository Structure section for a complete list of file paths, including
  binary files.

Additional Info:
----------------

For more information about Repopack, visit: https://github.com/yamadashy/repopack

================================================================
Repository Structure
================================================================
Assets/
  _Scripts/
    Brains/
      EnemyBrain.cs
      EnemyBrain.cs.meta
    Enums/
      GameEnums.cs
      GameEnums.cs.meta
    Interfaces/
      IEstado.cs
      IEstado.cs.meta
    Player/
      PlayerController.cs
      PlayerController.cs.meta
      PlayerFear.cs
      PlayerFear.cs.meta
      PlayerNoise.cs
      PlayerNoise.cs.meta
    States/
      EstadoRastreo.cs
      EstadoRastreo.cs.meta
    Systems/
      Data_Enemigo_Principal.asset
      Data_Enemigo_Principal.asset.meta
      IntuicionSystem.cs
      IntuicionSystem.cs.meta
    UI/
      UI_MenuManager.cs
      UI_MenuManager.cs.meta
    Brains.meta
    Enums.meta
    Interfaces.meta
    Player.meta
    States.meta
    Systems.meta
    UI.meta
  Art/
    Material/
      New Material.mat
      New Material.mat.meta
    Material.meta
  Input/
    PlayerControls.cs
    PlayerControls.cs.meta
    PlayerControls.inputactions
    PlayerControls.inputactions.meta
  Scenes/
    Catacumbas/
      NavMesh-NavMesh Manager.asset.meta
    Catacumbas.meta
    Catacumbas.unity.meta
  Sounds/
    Player/
      caminata.wav.meta
      grito.wav.meta
      susurro.wav.meta
    Player.meta
  _Scripts.meta
  Art.meta
  Input.meta
  Scenes.meta
  Sounds.meta
  TextMesh Pro.meta
Packages/
  manifest.json
  packages-lock.json
ProjectSettings/
  AudioManager.asset
  ClusterInputManager.asset
  DynamicsManager.asset
  EditorBuildSettings.asset
  EditorSettings.asset
  GraphicsSettings.asset
  InputManager.asset
  MemorySettings.asset
  NavMeshAreas.asset
  PackageManagerSettings.asset
  Physics2DSettings.asset
  PresetManager.asset
  ProjectSettings.asset
  ProjectVersion.txt
  QualitySettings.asset
  SceneTemplateSettings.json
  TagManager.asset
  TimeManager.asset
  UnityConnectSettings.asset
  VersionControlSettings.asset
  VFXManager.asset
UserSettings/
  Layouts/
    CurrentMaximizeLayout.dwlt
    default-2022.dwlt
  EditorUserSettings.asset
  Search.index
  Search.settings
.gitignore
.repopackignore 
README.md

================================================================
Repository Files
================================================================

================
File: Assets/_Scripts/Brains/EnemyBrain.cs
================
using UnityEngine;
using UnityEngine.AI; // Acceso al sistema de navegación
using UnityEngine.SceneManagement; // Importado para reiniciar la escena
using _Scripts.Systems;     // Acceso al corazón de datos (ScriptableObject)
using _Scripts.Interfaces;   // Acceso al contrato IEstado
using _Scripts.States;       // Acceso a las lógicas de estado (Rastreo, Sigilo...)

namespace _Scripts.Brains
{
    /* * * CLASE: EnemyBrain
     * DESCRIPCIÓN: Actúa como el "Cuerpo" y "Contexto" de la IA (Hardware). 
     * No decide qué hacer por sí mismo, sino que delega esa tarea a un objeto IEstado.
     * Mantiene vivo el cronómetro de 60s para el enfriamiento.
     * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
    public class EnemyBrain : MonoBehaviour
    {
        [Header("Referencias de Datos")]
        [Tooltip("El archivo de datos (SO) que compartimos con el jugador y el sistema")]
        [SerializeField] private IntuicionSystem data;
        public IntuicionSystem Data => data; // Propiedad pública para los Estados
        
        [Header("Configuración de Movimiento y Navegación")]
        [Tooltip("Agente de navegación del enemigo")]
        [SerializeField] private NavMeshAgent agent;
        public NavMeshAgent Agent => agent; // Propiedad pública para los Estados

        [Tooltip("Velocidad de traslación física base.")]
        [SerializeField] private float velocidadBase = 3.5f;
        
        [Tooltip("Puntos de patrulla para el movimiento perpetuo.")]
        [SerializeField] private Transform[] waypoints; 
        public Transform[] Waypoints => waypoints; // Propiedad pública para los Estados
        

        [Header("Instintos Base")]
        [Tooltip("Transform del jugador para el Olfato")]
        [SerializeField] private Transform transformJugador;
        [Tooltip("Distancia a la que el enemigo mata instantáneamente")]
        [SerializeField] private float distanciaOlfato = 1.5f;

        /* LÓGICA DE MÁQUINA DE ESTADOS e OPTIMIZACIÓN (CACHING) */
        private IEstado _estadoActual; 
        
        // Cacheamos las instancias de los estados para evitar asignaciones de memoria (GC Allocations)
        private IEstado _estadoRastreo;

        [Header("Reloj de Recuperación")]
        // Contador de segundos para llegar al minuto de enfriamiento
        private float _cronometroSesentaSeg = 0f;
        
        // Guardamos el nivel de fase actual (1, 2, 3...) para pasárselo al SO en el Tick
        private int _nivelMiedoActual = 1;

        /* * *
         * MÉTODO: Start
         * Se ejecuta al nacer. Configuramos los estados cacheando referencias y el estado inicial.
         */
        private void Start()
        {
            if (!data) return; // Si no hay datos sal de la función.
            
            // Verificación y asignación automática de componentes obligatorios
            if (!agent) agent = GetComponent<NavMeshAgent>();
            if (!agent) Debug.LogError("EnemyBrain: Falta el componente NavMeshAgent.");
            if (!transformJugador) Debug.LogError("EnemyBrain: Falta asignar el Transform del Jugador para el Olfato.");

            // Suscripción al SO
            data.OnSubirFase += HandleSubirFase;
            data.OnBajarFase += HandleBajarFase;
                
            // OPTIMIZACIÓN: Instanciamos los estados una sola vez en el inicio
            _estadoRastreo = new EstadoRastreo(this);
            
            // ESTADO INICIAL: Iniciamos usando la referencia cacheada
            CambiarEstado(_estadoRastreo);
        }

        /* * *
         * MÉTODO: Update
         * Ejecución por frame. Mantenemos el pulso de los relojes y la máquina de estados.
         */
        private void Update()
        {
            if (!data) return;

            // 1. CONDICIÓN GLOBAL (OLFATO): Instinto base primario
            if (transformJugador != null && Vector3.Distance(transform.position, transformJugador.position) <= distanciaOlfato)
            {
                EjecutarMuertePorOlfato();
                return;
            }

            // 2. Manejamos el tiempo para el enfriamiento de 60s
            ManejarCronometroRecuperacion();
            
            // 3. EJECUCIÓN DEL ESTADO: El estado controla la lógica en este frame
            _estadoActual?.Ejecutar(); 
        }

        private void EjecutarMuertePorOlfato()
        {
            Debug.Log("<color=red>¡JUGADOR ASESINADO POR OLFATO! Reiniciando escena...</color>");
            
            // Detenemos el movimiento físico inmediatamente
            if (agent != null && agent.isOnNavMesh)
            {
                agent.isStopped = true;
            }

            // Reiniciamos la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        /* * *
         * MÉTODO: ActualizarVelocidad
         * Función pública para que los ESTADOS puedan cambiar la velocidad del NavMeshAgent.
         */
        public void ActualizarVelocidad(float nuevaVelocidad)
        {
            velocidadBase = nuevaVelocidad;
            if (agent != null)
            {
                agent.speed = nuevaVelocidad;
            }
        }

        /* * *
         * MÉTODO: MoverHacia
         * Función pública para que los ESTADOS ordenen el destino al NavMeshAgent.
         */
        public void MoverHacia(Vector3 destino)
        {
            if (agent != null && agent.isOnNavMesh)
            {
                agent.SetDestination(destino);
            }
        }

        /* * *
         * MÉTODO: CambiarEstado
         * Transición limpia de estados reutilizando referencias existentes.
         */
        public void CambiarEstado(IEstado nuevoEstado)
        {
            _estadoActual?.Salir();
            _estadoActual = nuevoEstado;
            _estadoActual.Entrar();
        }

        /* * *
         * MÉTODO: ManejarCronometroRecuperacion
         * Controla el enfriamiento por Ticks.
         */
        private void ManejarCronometroRecuperacion()
        {
            _cronometroSesentaSeg += Time.deltaTime;

            if (_cronometroSesentaSeg >= 60f)
            {
                data.EjecutarTickDeRecuperacion(_nivelMiedoActual);
                _cronometroSesentaSeg = 0f;
            }
        }

        // --- MANEJADORES DE EVENTOS ---

        private void HandleSubirFase()
        {
            _nivelMiedoActual++;
            Debug.Log($"<color=orange>RADIO: El enemigo subió al Nivel {_nivelMiedoActual}</color>");
            // Nota: Aquí se cambiará al estado correspondiente cacheado en el futuro
        }

        private void HandleBajarFase()
        {
            _nivelMiedoActual = Mathf.Max(1, _nivelMiedoActual - 1);
            
            // Si bajamos al nivel base, volvemos a usar la referencia cacheada de Rastreo
            if (_nivelMiedoActual == 1) CambiarEstado(_estadoRastreo);
            
            Debug.Log($"<color=cyan>RADIO: El enemigo bajó al Nivel {_nivelMiedoActual}</color>");
        }

        /* * *
         * MÉTODO DE LIMPIEZA: OnDestroy
         * Se ejecuta si matamos al enemigo o cambiamos de escena.
         * Desconecta los cables de radio para no causar errores de memoria.
         */
        private void OnDestroy()
        {
            if (data != null)
            {
                data.OnSubirFase -= HandleSubirFase;
                data.OnBajarFase -= HandleBajarFase;
            }
        }
    }
}

================
File: Assets/_Scripts/Brains/EnemyBrain.cs.meta
================
fileFormatVersion: 2
guid: b77e2e2cc7ca00869a4c6a7f5fdec407
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Enums/GameEnums.cs
================
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

================
File: Assets/_Scripts/Enums/GameEnums.cs.meta
================
fileFormatVersion: 2
guid: fb065a7cb5b86aa16b992024e4b2ebe3
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Interfaces/IEstado.cs
================
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

================
File: Assets/_Scripts/Interfaces/IEstado.cs.meta
================
fileFormatVersion: 2
guid: e5d047912590d7e4b9600b764ea14d79
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Player/PlayerController.cs
================
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

================
File: Assets/_Scripts/Player/PlayerController.cs.meta
================
fileFormatVersion: 2
guid: c1eee615680ccbe52b6f4f2f11720b2b
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Player/PlayerFear.cs
================
// -----------------------------------------------------------------------------
//  PlayerFear.cs
//  Se suscribe a la "radio" del IntuicionSystem y ajusta el movimiento del
//  jugador basándose en los niveles de miedo del enemigo.
//  Este script DEBE estar adjunto al mismo GameObject que tiene el PlayerController 
//  (por ejemplo, la cápsula del jugador).
// -----------------------------------------------------------------------------
using UnityEngine;

namespace _Scripts.Player
{
    // Garantiza de forma segura que el GameObject tenga un PlayerController.
    // Si no existe, Unity lo añadirá automáticamente para evitar errores de referencia nula en tiempo de ejecución.
    [RequireComponent(typeof(PlayerController))]
    public class PlayerFear : MonoBehaviour
    {
        [Header("Intuicion System (Data Asset)")]
        [Tooltip("Asigna aquí el ScriptableObject de IntuicionSystem que utiliza el EnemyBrain.")]
        [SerializeField] private _Scripts.Systems.IntuicionSystem intuicionSystem;

        // Referencia interna al controlador de movimiento del jugador.
        private PlayerController playerController;
        
        // Nivel de miedo actual del jugador. Rango: 0 (calma total) hasta 4 (terror absoluto).
        private int fearLevel = 0; 
        
        // Límite máximo del nivel de miedo. Corresponde a un factor de 0.8 (80% de penalización de velocidad).
        private const int MaxFearLevel = 4; 

        /// <summary>
        /// Awake se ejecuta al cargar la instancia del script, antes de que empiece el juego.
        /// Ideal para inicializar y capturar componentes internos de forma optimizada sin usar GameObject.Find.
        /// </summary>
        private void Awake()
        {
            // Cacheamos el componente PlayerController que está en este mismo objeto.
            playerController = GetComponent<PlayerController>();
        }

        /// <summary>
        /// Se activa automáticamente cada vez que el objeto se habilita en la escena.
        /// Aquí nos "sintonizamos" a la radio del sistema de intuición (Eventos).
        /// </summary>
        private void OnEnable()
        {
            // Verificación de seguridad por si olvidaste arrastrar el ScriptableObject en el Inspector.
            if (intuicionSystem != null)
            {
                // Nos suscribimos a los eventos. Cuando la IA suba o baje de fase,
                // este script se enterará inmediatamente de forma asíncrona.
                intuicionSystem.OnSubirFase += HandleSubirFase;
                intuicionSystem.OnBajarFase += HandleBajarFase;
            }
        }

        /// <summary>
        /// Se activa automáticamente cuando el objeto se deshabilita o se destruye.
        /// CRUCIAL: Siempre hay que desvincular los eventos para evitar fugas de memoria (Memory Leaks).
        /// </summary>
        private void OnDisable()
        {
            if (intuicionSystem != null)
            {
                // Nos desuscribimos de los eventos para limpiar las referencias en memoria.
                intuicionSystem.OnSubirFase -= HandleSubirFase;
                intuicionSystem.OnBajarFase -= HandleBajarFase;
            }
        }

        /// <summary>
        /// Método manejador que se ejecuta automáticamente cuando el sistema avisa que el enemigo subió de fase.
        /// </summary>
        private void HandleSubirFase()
        {
            // Incrementamos el miedo en 1, pero usamos Mathf.Clamp para asegurar 
            // que matemáticamente nunca supere el MaxFearLevel (4) ni baje de 0.
            fearLevel = Mathf.Clamp(fearLevel + 1, 0, MaxFearLevel);
            
            // Recalculamos y aplicamos el peso del terror al jugador.
            ApplyFearPenalty();
        }

        /// <summary>
        /// Método manejador que se ejecuta automáticamente cuando el sistema avisa que el enemigo bajó de fase (se enfrió).
        /// </summary>
        private void HandleBajarFase()
        {
            // Decrementamos el miedo en 1, manteniendo el valor protegido entre 0 y 4.
            fearLevel = Mathf.Clamp(fearLevel - 1, 0, MaxFearLevel);
            
            // Recalculamos y aplicamos el peso del terror al jugador.
            ApplyFearPenalty();
        }

        /// <summary>
        /// Traduce el nivel de miedo entero (0 a 4) en un porcentaje decimal de penalización física 
        /// y se lo inyecta al PlayerController.
        /// </summary>
        private void ApplyFearPenalty()
        {
            // Control de daños: Si por alguna razón el script se rompió o no tiene el controlador, cancela la ejecución.
            if (playerController == null) return;
            
            // EXPLICACIÓN MATEMÁTICA DEL FACTOR:
            // 1. (float)fearLevel de la línea inferior convierte el entero a float para permitir divisiones decimales exactas.
            // 2. Se divide entre MaxFearLevel (4) para obtener un porcentaje normalizado de 0.0 a 1.0.
            // 3. Se multiplica por 0.8f para escalar ese porcentaje a un rango final de 0.0 a 0.8.
            // Ejemplos de resultado según la fase:
            // - Miedo 0: (0 / 4) * 0.8 = 0.0  -> 0% de reducción (Velocidad normal).
            // - Miedo 1: (1 / 4) * 0.8 = 0.2  -> 20% de reducción.
            // - Miedo 2: (2 / 4) * 0.8 = 0.4  -> 40% de reducción.
            // - Miedo 3: (3 / 4) * 0.8 = 0.6  -> 60% de reducción.
            // - Miedo 4: (4 / 4) * 0.8 = 0.8  -> 80% de reducción (El jugador apenas puede arrastrarse del susto).
            float factor = (float)fearLevel / MaxFearLevel * 0.8f;
            
            // Le enviamos este factor limpio al PlayerController para que reste velocidad o altere el movimiento.
            playerController.AplicarPenalizacionMiedo(factor);
        }
    }
}

================
File: Assets/_Scripts/Player/PlayerFear.cs.meta
================
fileFormatVersion: 2
guid: 4843a5be6ad200c6dbcd89cb895ad484
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Player/PlayerNoise.cs
================
using UnityEngine;
using _Scripts.Systems; // Para ver el IntuicionSystem
using _Scripts.Enums;   // Para ver el PerfilAcustico

namespace _Scripts.Player
{
    /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
     * CLASE: PlayerNoise (El Generador de Pulsos)
     * Se encarga de medir el tiempo entre pasos, reproducir el audio 
     * local para asustar al jugador humano, y enviar el "Paquete de Datos"
     * matemático al cerebro del enemigo.
     * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
    public class PlayerNoise : MonoBehaviour
    {
        [Header("Comunicaciones (Los Cables)")]
        [Tooltip("El 'buzón' central donde dejaremos el paquete de ruido")]
        /*Oye, en este espacio solo se pueden guardar cosas que tengan la estructura de IntuicionSystem
         dataIntuicion es solo un puntero inalambrico*/
        [SerializeField] private IntuicionSystem dataIntuicion; 
        
        [Tooltip("El cuerpo del enemigo para poder calcular a cuántos metros estamos")]
        [SerializeField] private Transform transformEnemigo;

        [Header("Configuración de Audio Físico")]
        [Tooltip("El parlante que reproducirá los .wav en los pies/boca del jugador")]
        [SerializeField] private AudioSource emisorDeSonido;
        
        [Tooltip("Audios para cuando el jugador va lento/agachado")]
        [SerializeField] private AudioClip audioSusurro; 
        
        [Tooltip("Audios para cuando el jugador camina normal")]
        [SerializeField] private AudioClip audioPasoNormal;
        
        [Tooltip("Audios para cuando el jugador corre asustado")]
        [SerializeField] private AudioClip audioGritoSusto;

        // --- EL ETIQUETADOR DE ESTADOS ---
        // Este enum local nos dice qué está haciendo el jugador AHORA MISMO.
        // Más adelante, el script de movimiento cambiará esta variable automáticamente.
        public enum EstadoMovimiento { Quieto, Agachado, Caminando, Corriendo }
        
        [Header("Estado Actual (Pruebas)")]
        [Tooltip("Cambia esto en Unity mientras juegas para probar los distintos ruidos")]
        public EstadoMovimiento estadoActual = EstadoMovimiento.Quieto;

        // El segundero que cuenta el tiempo entre un paso y otro
        private float _cronometroPulso = 0f;

        private void Start()
        {
            // Cláusulas de salvaguarda: Avisamos si olvidaste conectar algo en el Inspector
            if (!dataIntuicion) Debug.LogError("PlayerNoise: Falta conectar el IntuicionSystem.");
            if (!transformEnemigo) Debug.LogError("PlayerNoise: Falta el Transform del Enemigo.");
            if (!emisorDeSonido) Debug.LogError("PlayerNoise: Falta el AudioSource.");
        }

        private void Update()
        {
            // Si falta el buzón de datos, no hacemos nada, para, evitar que el juego explote
            if (!dataIntuicion || !transformEnemigo) return;

            // 1. EL RELOJ: Definimos qué tan rápido late el pulso según el estado
            float tiempoEntrePulsos = 0f;

            switch (estadoActual)
            {
                case EstadoMovimiento.Quieto: 
                    _cronometroPulso = 0f; // Reseteamos el reloj
                    return; // Salimos del Update, no hay ruido que hacer
                
                case EstadoMovimiento.Agachado: 
                    tiempoEntrePulsos = 1.2f; // Un pulso lento (mucho espacio entre pasos)
                    break;
                
                case EstadoMovimiento.Caminando: 
                    tiempoEntrePulsos = 0.7f; // Un pulso normal
                    break;
                
                case EstadoMovimiento.Corriendo: 
                    tiempoEntrePulsos = 0.3f; // Un pulso rapidísimo (pasos acelerados)
                    break;
            }

            // 2. EL SEGUNDERO AVANZA
            _cronometroPulso += Time.deltaTime;

            // 3. EL DISPARO
            if (_cronometroPulso >= tiempoEntrePulsos)
            {
                EmitirRuidoDelPulso();
                _cronometroPulso = 0f; // Vaciamos el reloj para empezar a contar el siguiente paso
            }
        }

        /* * *
         * MÉTODO: EmitirRuidoDelPulso
         * Se ejecuta solo en el frame exacto en el que el pie toca el suelo.
         * Prepara el paquete, reproduce el .wav y lo envía por correo.
         */
        // ReSharper disable Unity.PerformanceAnalysis
        private void EmitirRuidoDelPulso()
        {
            // A. Calculamos la distancia real en metros usando trigonometría de Unity
            float distanciaAlEnemigo = Vector3.Distance(transform.position, transformEnemigo.position);

            // B. Preparamos las variables que meteremos en el paquete
            float volumenPaquete = 0f;
            PerfilAcustico perfilPaquete = PerfilAcustico.GraveFisico; // Por defecto
            AudioClip clipFalsoParaHumano = null;

            // C. Rellenamos el paquete según el estado
            switch (estadoActual)
            {
                case EstadoMovimiento.Agachado:
                    volumenPaquete = 0.1f; // Muy bajito
                    perfilPaquete = PerfilAcustico.AgudoVocal; // Un susurro que se apaga rápido en la distancia
                    clipFalsoParaHumano = audioSusurro;
                    break;

                case EstadoMovimiento.Caminando:
                    volumenPaquete = 0.3f; // Medio
                    perfilPaquete = PerfilAcustico.GraveFisico; // Un paso que hace vibrar el suelo
                    clipFalsoParaHumano = audioPasoNormal;
                    break;

                case EstadoMovimiento.Corriendo:
                    volumenPaquete = 0.8f; // Escandaloso
                    perfilPaquete = PerfilAcustico.AgudoVocal; // Un grito/jadeo de pánico
                    clipFalsoParaHumano = audioGritoSusto;
                    break;
            }

            // D. LA MAGIA: Actualizamos la posición sospechosa...
            dataIntuicion.posicionSospechosa = transform.position;
            
            // ... Y enviamos el paquete matemático al IntuicionSystem
            // ¡Fíjate cómo usamos el Enum aquí como una etiqueta de envío!
            dataIntuicion.ModificarIntuicion(volumenPaquete, distanciaAlEnemigo, perfilPaquete);

            // E. EL TEATRO: Reproducimos el archivo .wav real para asustar al jugador
            if (emisorDeSonido && clipFalsoParaHumano)
            {
                emisorDeSonido.PlayOneShot(clipFalsoParaHumano);
            }
            
            // Un log para que tú como desarrollador veas que el pulso salió bien
            Debug.Log($"<color=yellow>PULSO: {estadoActual} | Vol: {volumenPaquete} | Perfil: {perfilPaquete} | Dist: {distanciaAlEnemigo:F1}m</color>");
        }
    }
}

================
File: Assets/_Scripts/Player/PlayerNoise.cs.meta
================
fileFormatVersion: 2
guid: d5caa585a553b6effba1868091a906e7
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/States/EstadoRastreo.cs
================
using UnityEngine;
using _Scripts.Interfaces;
using _Scripts.Brains;

namespace _Scripts.States
{
    /* * ESTADO: RASTREO (FASE 1)
     * El enemigo patrulla tranquilamente entre waypoints usando NavMeshAgent.
     * Es el estado más "ciego" y lento.
     */
    public class EstadoRastreo : IEstado
    {
        private readonly EnemyBrain _brain;
        private readonly float _velocidadRastreo = 2.5f;
        
        private int _indexWaypointActual = 0;
        private Vector3 _ultimoDestinoAsignado;
        private bool _iniciando = true;

        // El constructor nos permite recibir la referencia del cerebro
        public EstadoRastreo(EnemyBrain brain)
        {
            _brain = brain;
        }

        public void Entrar()
        {
            Debug.Log("<color=green>Enemigo entrando en fase de RASTREO.</color>");
            _brain.ActualizarVelocidad(_velocidadRastreo);
            _ultimoDestinoAsignado = Vector3.zero;
            _iniciando = true;
        }

        public void Ejecutar()
        {
            // 1. Aseguramos que la velocidad actual del agente sea la de rastreo
            _brain.ActualizarVelocidad(_velocidadRastreo);

            Vector3 destinoObjetivo;
            bool esSospecha = _brain.Data.IntuicionActual > 0.2f;

            if (esSospecha)
            {
                // Si la intuición es alta, vamos a investigar la posición sospechosa
                destinoObjetivo = _brain.Data.posicionSospechosa;
            }
            else
            {
                // Si no, volvemos a la patrulla normal
                if (_brain.Waypoints == null || _brain.Waypoints.Length == 0) return;
                destinoObjetivo = _brain.Waypoints[_indexWaypointActual].position;
            }

            // 2. OPTIMIZACIÓN CRÍTICA: Solo llamamos a SetDestination si el destino ha cambiado.
            // Si llamamos a SetDestination en cada frame (Update), el agente recalcula la ruta infinitamente y se queda quieto.
            if (_iniciando || Vector3.Distance(_ultimoDestinoAsignado, destinoObjetivo) > 0.1f)
            {
                _brain.MoverHacia(destinoObjetivo);
                _ultimoDestinoAsignado = destinoObjetivo;
                _iniciando = false;
            }

            // 3. CAMBIO DE WAYPOINT: Si estamos patrullando y llegamos físicamente cerca del punto, avanzamos
            if (!esSospecha)
            {
                float distanciaFisica = Vector3.Distance(_brain.transform.position, destinoObjetivo);
                if (distanciaFisica < 0.8f)
                {
                    _indexWaypointActual = (_indexWaypointActual + 1) % _brain.Waypoints.Length;
                }
            }
        }

        public void Exit() // Cumple la interfaz si requiere Salir en español
        {
            Salir();
        }

        public void Salir()
        {
            Debug.Log("Saliendo de RASTREO: El enemigo ha cambiado de estado.");
        }
    }
}

================
File: Assets/_Scripts/States/EstadoRastreo.cs.meta
================
fileFormatVersion: 2
guid: a62626fab6c135c59a7a83b148b7ef96
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Systems/Data_Enemigo_Principal.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &11400000
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: dd938d6e69397d316ba85446da156fb1, type: 3}
  m_Name: Data_Enemigo_Principal
  m_EditorClassIdentifier: 
  intuicionActual: 0
  posicionSospechosa: {x: 0, y: 0, z: 0}

================
File: Assets/_Scripts/Systems/Data_Enemigo_Principal.asset.meta
================
fileFormatVersion: 2
guid: 8e2d73a2e10bd0101bd926c29d0b153b
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 11400000
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Systems/IntuicionSystem.cs
================
using UnityEngine;
using System; // Necesario para usar los "Eventos" (La Radio)

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DICCIONARIO ACÚSTICO
 * Lo definimos aquí para que cualquier objeto del juego pueda
 * "etiquetar" su ruido antes de enviarlo al sistema.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
namespace _Scripts.Enums
{
    public enum PerfilAcustico
    {
        AgudoVocal, // Gritos, susurros, cristales rotos (Se ahogan rápido con la distancia)
        GraveFisico // Pasos pesados, muebles cayendo (Viajan lejos por el suelo/estructura)
    }
}

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * EL CORAZÓN DE DATOS (SISTEMA DE INTUICIÓN)
 * Actúa como un Analizador de Frecuencias Básico. Recibe paquetes 
 * de sonido, calcula su impacto real y alerta al enemigo.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
namespace _Scripts.Systems
{
    [CreateAssetMenu(fileName = "NuevaIntuicion", menuName = "Sistema/Intuicion Data")]
    public class IntuicionSystem : ScriptableObject
    {
        [Header("Datos de la Fase (Escala 0.0 a 1.0)")]
        [Tooltip("El medidor de peligro de la fase actual")]
        [SerializeField] private float intuicionActual = 0f;
        public float IntuicionActual => intuicionActual;

        [Header("Memoria de Posición")]
        [Tooltip("Última posición global donde se originó un ruido válido")]
        public Vector3 posicionSospechosa;

        // EVENTOS ("La Radio"): Avisan al enemigo cuando debe cambiar de fase
        public event Action OnSubirFase;
        public event Action OnBajarFase;

        /* * *
         * MÉTODO PARA SUBIR: LA PUERTA DE ENTRADA DEL RUIDO
         * Recibe el "Paquete de Sonido" (Volumen, Distancia y Tipo) y 
         * decide cuánto asusta realmente al monstruo.
         */
        // ReSharper disable Unity.PerformanceAnalysis
        public void ModificarIntuicion(float volumenOriginal, float distanciaAlMonstruo, _Scripts.Enums.PerfilAcustico perfil)
        {
            // Esta variable guardará el ruido final después de calcular la distancia
            float incrementoFinal = 0f;

            // 1. FILTRO MATEMÁTICO DE FRECUENCIAS (La magia del sonido)
            switch (perfil)
            { 
                case _Scripts.Enums.PerfilAcustico.AgudoVocal:
                    // REGLA AGUDA: Multiplicamos la distancia x 2.0
                    // Si el monstruo está a 10m, el divisor será 20. El sonido se vuelve diminuto muy rápido.
                    incrementoFinal = volumenOriginal / Mathf.Max(distanciaAlMonstruo * 2.0f, 0.1f);
                    break;

                case _Scripts.Enums.PerfilAcustico.GraveFisico:
                    // REGLA GRAVE: Multiplicamos la distancia x 0.3 (La reducimos)
                    // Si el monstruo está a 10m, el divisor será solo 3. La vibración llega casi intacta.
                    incrementoFinal = volumenOriginal / Mathf.Max(distanciaAlMonstruo * 0.3f, 0.1f);
                    break;
            }

            // 2. REGLA DEL 75% (Zona de Gracia)
            // Si el monstruo ya está muy alterado (>0.75), los ruidos le afectan 3 veces menos.
            // Así le damos al jugador una micro-oportunidad de escapar antes de pasar a Persecución.
            if (intuicionActual >= 0.75f && incrementoFinal > 0)
            {
                intuicionActual += (incrementoFinal / 3f);
            }
            else
            {
                intuicionActual += incrementoFinal;
            }

            // 3. REGLA DE CASCADA (SUBIDA)
            // Si el vaso se derrama, gritamos por la radio para que el EnemyBrain suba de fase.
            if (!(intuicionActual >= 1.0f)) return;
            intuicionActual = 0f; // Vaciamos el vaso para el nuevo nivel
            OnSubirFase?.Invoke(); // El '?' asegura que no haya error si nadie escucha
        }

        /* * *
         * TICK DE RECUPERACIÓN (Llamado por el EnemyBrain cada 60s)
         * Reduce el miedo con el tiempo. Es más difícil calmarlo en niveles altos.
         */
        public void EjecutarTickDeRecuperacion(int miedoLevel)
        {
            // FÓRMULA: Reducción = Intuición Actual * (1/3 * 1/Miedo)
            float factorEnfriamiento = (1f / 3f) * (1f / miedoLevel);
            float cantidadARestar = intuicionActual * factorEnfriamiento;

            intuicionActual -= cantidadARestar;

            // REGLA DE CASCADA (BAJADA)
            if (intuicionActual <= 0f)
            {
                // REGALO AL JUGADOR: Si el monstruo se calma y baja de fase, 
                // la nueva fase empieza en 0.7 (70%) en lugar de 1.0. No se olvida de ti del todo.
                intuicionActual = 0.7f; 
                OnBajarFase?.Invoke(); 
            }

            // Mantenemos el número entre 0.0 y 1.0 por seguridad del motor
            intuicionActual = Mathf.Clamp01(intuicionActual);
        }
    }
}

================
File: Assets/_Scripts/Systems/IntuicionSystem.cs.meta
================
fileFormatVersion: 2
guid: dd938d6e69397d316ba85446da156fb1
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/UI/UI_MenuManager.cs
================
using _Scripts.Player;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
// LINEA NUEVA: Permite al script tener acceso directo a las herramientas de cámara de Cinemachine
using Cinemachine;

namespace _Scripts.UI
{
    // Asegura que este script inicialice después de los componentes base del juego para evitar NullReference
    [DefaultExecutionOrder(100)]
    public class UI_MenuManager : MonoBehaviour
    {
        // Enums: Una lista de estados lógicos excluyentes. El juego solo puede estar en UNO de estos a la vez.
        private enum MenuState
        {
            Gameplay,
            MenuAbierto
        }

        [Header("Input (Assets/Input/PlayerControls)")]
        [Tooltip("El contenedor de mapas de control (.inputactions) de nuestro proyecto")]
        [SerializeField]
        private InputActionAsset inputActionAsset;

        [Header("UI")] [Tooltip("El objeto raíz de la interfaz que contiene los botones")] [SerializeField]
        private GameObject menuPanel;

        [SerializeField] private TextMeshProUGUI tituloTexto;
        [SerializeField] private TextMeshProUGUI botonPrincipalTexto;

        [Header("Jugador")]
        [Tooltip("Referencia al script que controla el movimiento físico de nuestro personaje")]
        [SerializeField]
        private PlayerController playerController;

        [Header("Configuración de Cámara (Cinemachine)")]
        [Tooltip("Arrastra aquí tu Virtual Camera de Cinemachine para congelar la rotación del mouse en las pausas")]
        [SerializeField]
        private CinemachineInputProvider cameraProvider;

        [SerializeField] private CinemachineVirtualCamera virtualCamera; // <-- Cambiamos el tipo aquí
        private CinemachinePOV cameraPov; // Ahora es privado, no se arrastra

        // Cache de componentes de control para evitar búsquedas repetitivas en cada frame (Ahorro de CPU)
        private InputActionMap _gameplayMap;
        private InputActionMap _uiMap;
        private InputAction _pauseAction;
        private InputAction _unpauseAction;

        // Estado actual del menú diegético (P alterna Gameplay ↔ MenuAbierto).
        private MenuState _estado = MenuState.Gameplay;

        // Constantes: Textos fijos que no van a cambiar durante la ejecución del código
        private const string TituloMenu = "Soporte";
        private const string TextoCerrar = "Cerrar";

        private void Awake()
        {
            // Validación de seguridad: Si olvidaste arrastrar los controles en el inspector, el script se apaga solo
            if (inputActionAsset == null)
            {
                Debug.LogError("UI_MenuManager: Asigna el InputActionAsset PlayerControls en el Inspector.");
                enabled = false;
                return;
            }

            if (virtualCamera != null)
            {
                // Esto extrae el módulo interno POV de la cámara virtual
                cameraPov = virtualCamera.GetCinemachineComponent<CinemachinePOV>();

                if (cameraProvider == null)
                    cameraProvider = virtualCamera.GetComponent<CinemachineInputProvider>();
            }

            // 1. Buscamos y vinculamos los Action Maps definidos en tu archivo de inputs
            _gameplayMap = inputActionAsset.FindActionMap("Gameplay", true);
            _uiMap = inputActionAsset.FindActionMap("UI", true);

            // 2. Buscamos las acciones específicas mapeadas a la tecla P
            _pauseAction = _gameplayMap.FindAction("Pause", true);
            _unpauseAction = _uiMap.FindAction("Unpause", true);

            // 3. SUSCRIPCIÓN: Conectamos físicamente las acciones a nuestras funciones de C#
            _pauseAction.performed += OnPausePerformed;
            _unpauseAction.performed += OnUnpausePerformed;

            // Búsqueda automática: Si no arrastraste el script del jugador, lo intenta buscar en la escena por sí mismo
            if (playerController == null)
                playerController = FindObjectOfType<PlayerController>();

            if (cameraProvider == null)
                cameraProvider = FindObjectOfType<CinemachineInputProvider>();

            if (cameraPov == null && cameraProvider != null)
                cameraPov = cameraProvider.GetComponentInChildren<CinemachinePOV>();
        }

        private void Start()
        {
            EntrarModoGameplay();
        }

        private void OnDestroy()
        {
            // BUENA PRÁCTICA: Rompemos la conexión con los eventos al destruir el objeto para evitar bugs de memoria
            if (_pauseAction != null)
                _pauseAction.performed -= OnPausePerformed;
            if (_unpauseAction != null)
                _unpauseAction.performed -= OnUnpausePerformed;
        }

        // --- MÉTODOS PÚBLICOS PARA LOS BOTONES (EVENTOS ONCLICK) ---

        public void OnClickJugarOReanudar()
        {
            if (_estado == MenuState.MenuAbierto)
                EntrarModoGameplay();
        }

        public void OnClickSalir()
        {
            // Compilación condicional: Detiene el juego de forma correcta según el entorno
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Detiene el Play Mode dentro de Unity
#else
            Application.Quit(); // Cierra la aplicación ejecutable (.exe o binario de Linux)
#endif
        }

        // --- RESPUESTAS A LOS INPUTS FÍSICOS (TECLA P) ---

        private void OnPausePerformed(InputAction.CallbackContext context)
        {
            // Filtro de seguridad: Si la acción no se completó o no estamos jugando, ignora el teclazo
            if (!context.performed || _estado != MenuState.Gameplay)
                return;

            EntrarModoMenuAbierto();
        }

        private void OnUnpausePerformed(InputAction.CallbackContext context)
        {
            if (!context.performed || _estado != MenuState.MenuAbierto)
                return;

            EntrarModoGameplay();
        }

        // --- MANEJADORES DE ESTADO (MÁQUINA DE ESTADOS) ---

        private void EntrarModoGameplay()
        {
            _estado = MenuState.Gameplay;

            MostrarMenu(false);
            ConfigurarCursor(false);
            ActivarMapaGameplay();
            ConfigurarJugador(true);
            ConfigurarCamara(true);
        }

        private void EntrarModoMenuAbierto()
        {
            _estado = MenuState.MenuAbierto;

            MostrarMenu(true);
            ConfigurarTextos(TituloMenu, TextoCerrar);
            ConfigurarCursor(true);
            ActivarMapaUI();
            ConfigurarJugador(false);
            ConfigurarCamara(false);
        }

        // --- SUB-FUNCIONES AUXILIARES DE CONFIGURACIÓN ---

        private void ActivarMapaUI()
        {
            _gameplayMap.Disable(); // Desactiva el mapa de juego (WASD deja de responder instantáneamente)
            _uiMap.Enable(); // Activa el mapa de UI (Permite que funcione la tecla Unpause)
        }

        private void ActivarMapaGameplay()
        {
            _uiMap.Disable(); // Desactiva el mapa de UI
            _gameplayMap.Enable(); // Activa el mapa de juego activo
        }

        private void MostrarMenu(bool visible)
        {
            if (menuPanel != null)
                menuPanel.SetActive(visible); // Enciende o apaga el GameObject completo en la jerarquía
        }

        private void ConfigurarTextos(string titulo, string botonPrincipal)
        {
            if (tituloTexto != null)
                tituloTexto.text = titulo;
            if (botonPrincipalTexto != null)
                botonPrincipalTexto.text = botonPrincipal;
        }

        private static void ConfigurarCursor(bool menuActivo)
        {
            // Si el menú está activo, el cursor se libera. Si no, se bloquea al centro de la pantalla.
            Cursor.lockState = menuActivo ? CursorLockMode.None : CursorLockMode.Locked;
            Cursor.visible = menuActivo; // Alterna la visibilidad del puntero gráfico
        }

        private void ConfigurarJugador(bool activo)
        {
            if (playerController != null)
                playerController.SetControlBlocked(!activo);
        }

        private void ConfigurarCamara(bool activo)
        {
            if (cameraProvider != null)
                cameraProvider.enabled = activo;

            if (cameraPov == null)
                return;

            var horizontal = cameraPov.m_HorizontalAxis;
            horizontal.m_InputAxisValue = 0f;
            cameraPov.m_HorizontalAxis = horizontal;

            var vertical = cameraPov.m_VerticalAxis;
            vertical.m_InputAxisValue = 0f;
            cameraPov.m_VerticalAxis = vertical;

            if (activo && Mouse.current != null)
                InputSystem.ResetDevice(Mouse.current);
        }
    }
}

================
File: Assets/_Scripts/UI/UI_MenuManager.cs.meta
================
fileFormatVersion: 2
guid: be633adea2560e14ca0c51c9142b2d13
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Brains.meta
================
fileFormatVersion: 2
guid: 4d4a0201a8835fa32a433ffce65a2862
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Enums.meta
================
fileFormatVersion: 2
guid: cc8f08fa2dd7c05e9abb5d8c71ae83e2
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Interfaces.meta
================
fileFormatVersion: 2
guid: 9f60ab6e60e1d32afac3f16f305d8876
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Player.meta
================
fileFormatVersion: 2
guid: 50a3df36d58deaa1d880127a6e0d3790
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/States.meta
================
fileFormatVersion: 2
guid: b1777e4094e5a2613b3c8dca3de80620
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/Systems.meta
================
fileFormatVersion: 2
guid: 03f6ec4b10f469479b868dda3f2d5686
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts/UI.meta
================
fileFormatVersion: 2
guid: b86c2fceb38c5d14e9bc94187f263959
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Art/Material/New Material.mat
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 8
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: New Material
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_Parent: {fileID: 0}
  m_ModifiedSerializedProperties: 0
  m_ValidKeywords: []
  m_InvalidKeywords: []
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_LockedProperties: 
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Ints: []
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0.5
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.33404577, g: 0.735849, b: 0.16313633, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}
  m_BuildTextureStacks: []

================
File: Assets/Art/Material/New Material.mat.meta
================
fileFormatVersion: 2
guid: a2fb724e44cf9471098c3d22f47cec3f
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 2100000
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Art/Material.meta
================
fileFormatVersion: 2
guid: 167a659b0331fb1fb9135714edd098b3
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Input/PlayerControls.cs
================
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.14.2
//     from Assets/Input/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

/// <summary>
/// Provides programmatic access to <see cref="InputActionAsset" />, <see cref="InputActionMap" />, <see cref="InputAction" /> and <see cref="InputControlScheme" /> instances defined in asset "Assets/Input/PlayerControls.inputactions".
/// </summary>
/// <remarks>
/// This class is source generated and any manual edits will be discarded if the associated asset is reimported or modified.
/// </remarks>
/// <example>
/// <code>
/// using namespace UnityEngine;
/// using UnityEngine.InputSystem;
///
/// // Example of using an InputActionMap named "Player" from a UnityEngine.MonoBehaviour implementing callback interface.
/// public class Example : MonoBehaviour, MyActions.IPlayerActions
/// {
///     private MyActions_Actions m_Actions;                  // Source code representation of asset.
///     private MyActions_Actions.PlayerActions m_Player;     // Source code representation of action map.
///
///     void Awake()
///     {
///         m_Actions = new MyActions_Actions();              // Create asset object.
///         m_Player = m_Actions.Player;                      // Extract action map object.
///         m_Player.AddCallbacks(this);                      // Register callback interface IPlayerActions.
///     }
///
///     void OnDestroy()
///     {
///         m_Actions.Dispose();                              // Destroy asset object.
///     }
///
///     void OnEnable()
///     {
///         m_Player.Enable();                                // Enable all actions within map.
///     }
///
///     void OnDisable()
///     {
///         m_Player.Disable();                               // Disable all actions within map.
///     }
///
///     #region Interface implementation of MyActions.IPlayerActions
///
///     // Invoked when "Move" action is either started, performed or canceled.
///     public void OnMove(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnMove: {context.ReadValue&lt;Vector2&gt;()}");
///     }
///
///     // Invoked when "Attack" action is either started, performed or canceled.
///     public void OnAttack(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnAttack: {context.ReadValue&lt;float&gt;()}");
///     }
///
///     #endregion
/// }
/// </code>
/// </example>
public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    /// <summary>
    /// Provides access to the underlying asset instance.
    /// </summary>
    public InputActionAsset asset { get; }

    /// <summary>
    /// Constructs a new instance.
    /// </summary>
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""version"": 1,
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""7abfd263-bb92-434a-a6e1-384bbda27d16"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9c18749d-7a66-4e7c-a1f1-fd577b715664"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""eb10d26d-9ee2-4ae3-9e82-8874a4c3e951"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""9c4689f5-077d-4e7b-a95f-e7990376191c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""afeb5324-c85c-4351-bd99-5d6703cdb2af"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""ae16035a-5f2b-41de-a7f3-cb7b3d469034"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fa8f4d5d-a1bb-490e-9f42-760d0b8b0da7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a662e232-7817-4fbe-81c8-95daa41d475e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5114778e-34cb-4c5b-8508-c3b7d0706900"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b35f0a8f-0fe1-4b56-9e31-453e95fe1794"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""405aa2a3-f408-47d6-ba6f-b9d19c015576"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""efc3f80b-b584-4a72-9d00-4cb97d2cd1c9"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7aff7f1f-414f-47d6-a334-fedd5f7e544f"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1064827c-1861-4165-ab61-3cdd244c9d32"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""355006be-f334-47af-834a-315147fdb808"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""ca338fad-e951-45db-b139-b0296a2f9796"",
            ""actions"": [
                {
                    ""name"": ""Unpause"",
                    ""type"": ""Button"",
                    ""id"": ""550a9331-cb76-441c-9cdb-d002470bcb2b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4f82ebaa-9a03-4b18-898a-ba952e7c7bea"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Unpause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Sprint = m_Gameplay.FindAction("Sprint", throwIfNotFound: true);
        m_Gameplay_Crouch = m_Gameplay.FindAction("Crouch", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
        m_Gameplay_Look = m_Gameplay.FindAction("Look", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Unpause = m_UI.FindAction("Unpause", throwIfNotFound: true);
    }

    ~@PlayerControls()
    {
        UnityEngine.Debug.Assert(!m_Gameplay.enabled, "This will cause a leak and performance issues, PlayerControls.Gameplay.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_UI.enabled, "This will cause a leak and performance issues, PlayerControls.UI.Disable() has not been called.");
    }

    /// <summary>
    /// Destroys this asset and all associated <see cref="InputAction"/> instances.
    /// </summary>
    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindingMask" />
    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.devices" />
    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.controlSchemes" />
    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Contains(InputAction)" />
    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.GetEnumerator()" />
    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    /// <inheritdoc cref="IEnumerable.GetEnumerator()" />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Enable()" />
    public void Enable()
    {
        asset.Enable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Disable()" />
    public void Disable()
    {
        asset.Disable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindings" />
    public IEnumerable<InputBinding> bindings => asset.bindings;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindAction(string, bool)" />
    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindBinding(InputBinding, out InputAction)" />
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Sprint;
    private readonly InputAction m_Gameplay_Crouch;
    private readonly InputAction m_Gameplay_Pause;
    private readonly InputAction m_Gameplay_Look;
    /// <summary>
    /// Provides access to input actions defined in input action map "Gameplay".
    /// </summary>
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Move".
        /// </summary>
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Sprint".
        /// </summary>
        public InputAction @Sprint => m_Wrapper.m_Gameplay_Sprint;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Crouch".
        /// </summary>
        public InputAction @Crouch => m_Wrapper.m_Gameplay_Crouch;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Pause".
        /// </summary>
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Look".
        /// </summary>
        public InputAction @Look => m_Wrapper.m_Gameplay_Look;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="GameplayActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="GameplayActions" />
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @Crouch.started += instance.OnCrouch;
            @Crouch.performed += instance.OnCrouch;
            @Crouch.canceled += instance.OnCrouch;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="GameplayActions" />
        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @Crouch.started -= instance.OnCrouch;
            @Crouch.performed -= instance.OnCrouch;
            @Crouch.canceled -= instance.OnCrouch;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />.
        /// </summary>
        /// <seealso cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />
        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="GameplayActions.AddCallbacks(IGameplayActions)" />
        /// <seealso cref="GameplayActions.RemoveCallbacks(IGameplayActions)" />
        /// <seealso cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />
        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="GameplayActions" /> instance referencing this action map.
    /// </summary>
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_Unpause;
    /// <summary>
    /// Provides access to input actions defined in input action map "UI".
    /// </summary>
    public struct UIActions
    {
        private @PlayerControls m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public UIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "UI/Unpause".
        /// </summary>
        public InputAction @Unpause => m_Wrapper.m_UI_Unpause;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="UIActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="UIActions" />
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @Unpause.started += instance.OnUnpause;
            @Unpause.performed += instance.OnUnpause;
            @Unpause.canceled += instance.OnUnpause;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="UIActions" />
        private void UnregisterCallbacks(IUIActions instance)
        {
            @Unpause.started -= instance.OnUnpause;
            @Unpause.performed -= instance.OnUnpause;
            @Unpause.canceled -= instance.OnUnpause;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="UIActions.UnregisterCallbacks(IUIActions)" />.
        /// </summary>
        /// <seealso cref="UIActions.UnregisterCallbacks(IUIActions)" />
        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="UIActions.AddCallbacks(IUIActions)" />
        /// <seealso cref="UIActions.RemoveCallbacks(IUIActions)" />
        /// <seealso cref="UIActions.UnregisterCallbacks(IUIActions)" />
        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="UIActions" /> instance referencing this action map.
    /// </summary>
    public UIActions @UI => new UIActions(this);
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "Gameplay" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="GameplayActions.AddCallbacks(IGameplayActions)" />
    /// <seealso cref="GameplayActions.RemoveCallbacks(IGameplayActions)" />
    public interface IGameplayActions
    {
        /// <summary>
        /// Method invoked when associated input action "Move" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnMove(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Sprint" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnSprint(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Crouch" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnCrouch(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Pause" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPause(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Look" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnLook(InputAction.CallbackContext context);
    }
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "UI" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="UIActions.AddCallbacks(IUIActions)" />
    /// <seealso cref="UIActions.RemoveCallbacks(IUIActions)" />
    public interface IUIActions
    {
        /// <summary>
        /// Method invoked when associated input action "Unpause" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnUnpause(InputAction.CallbackContext context);
    }
}

================
File: Assets/Input/PlayerControls.cs.meta
================
fileFormatVersion: 2
guid: c328b888a7ec9dab287555920201b737
MonoImporter:
  externalObjects: {}
  serializedVersion: 2
  defaultReferences: []
  executionOrder: 0
  icon: {instanceID: 0}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Input/PlayerControls.inputactions
================
{
    "version": 1,
    "name": "PlayerControls",
    "maps": [
        {
            "name": "Gameplay",
            "id": "7abfd263-bb92-434a-a6e1-384bbda27d16",
            "actions": [
                {
                    "name": "Move",
                    "type": "Value",
                    "id": "9c18749d-7a66-4e7c-a1f1-fd577b715664",
                    "expectedControlType": "Vector2",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": true
                },
                {
                    "name": "Sprint",
                    "type": "Button",
                    "id": "eb10d26d-9ee2-4ae3-9e82-8874a4c3e951",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Crouch",
                    "type": "Button",
                    "id": "9c4689f5-077d-4e7b-a95f-e7990376191c",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Pause",
                    "type": "Button",
                    "id": "afeb5324-c85c-4351-bd99-5d6703cdb2af",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Look",
                    "type": "Value",
                    "id": "ae16035a-5f2b-41de-a7f3-cb7b3d469034",
                    "expectedControlType": "Vector2",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": true
                }
            ],
            "bindings": [
                {
                    "name": "2D Vector",
                    "id": "fa8f4d5d-a1bb-490e-9f42-760d0b8b0da7",
                    "path": "2DVector",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "up",
                    "id": "a662e232-7817-4fbe-81c8-95daa41d475e",
                    "path": "<Keyboard>/w",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "down",
                    "id": "5114778e-34cb-4c5b-8508-c3b7d0706900",
                    "path": "<Keyboard>/s",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "left",
                    "id": "b35f0a8f-0fe1-4b56-9e31-453e95fe1794",
                    "path": "<Keyboard>/a",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "right",
                    "id": "405aa2a3-f408-47d6-ba6f-b9d19c015576",
                    "path": "<Keyboard>/d",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "",
                    "id": "efc3f80b-b584-4a72-9d00-4cb97d2cd1c9",
                    "path": "<XInputController>/leftTrigger",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Sprint",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "7aff7f1f-414f-47d6-a334-fedd5f7e544f",
                    "path": "<XInputController>/leftStick/down",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Crouch",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "1064827c-1861-4165-ab61-3cdd244c9d32",
                    "path": "<Keyboard>/p",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Pause",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "355006be-f334-47af-834a-315147fdb808",
                    "path": "<Mouse>/delta",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Look",
                    "isComposite": false,
                    "isPartOfComposite": false
                }
            ]
        },
        {
            "name": "UI",
            "id": "ca338fad-e951-45db-b139-b0296a2f9796",
            "actions": [
                {
                    "name": "Unpause",
                    "type": "Button",
                    "id": "550a9331-cb76-441c-9cdb-d002470bcb2b",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                }
            ],
            "bindings": [
                {
                    "name": "",
                    "id": "4f82ebaa-9a03-4b18-898a-ba952e7c7bea",
                    "path": "<Keyboard>/p",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Unpause",
                    "isComposite": false,
                    "isPartOfComposite": false
                }
            ]
        }
    ],
    "controlSchemes": []
}

================
File: Assets/Input/PlayerControls.inputactions.meta
================
fileFormatVersion: 2
guid: 5e2296452dc258735bf427a4404e4af0
ScriptedImporter:
  internalIDToNameTable: []
  externalObjects: {}
  serializedVersion: 2
  userData: 
  assetBundleName: 
  assetBundleVariant: 
  script: {fileID: 11500000, guid: 8404be70184654265930450def6a9037, type: 3}
  generateWrapperCode: 1
  wrapperCodePath: 
  wrapperClassName: 
  wrapperCodeNamespace:

================
File: Assets/Scenes/Catacumbas/NavMesh-NavMesh Manager.asset.meta
================
fileFormatVersion: 2
guid: a8ef8db4876e183d0b1115166c5e9d8d
NativeFormatImporter:
  externalObjects: {}
  mainObjectFileID: 23800000
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Scenes/Catacumbas.meta
================
fileFormatVersion: 2
guid: d2f039929018535fc8a556e61edec348
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Scenes/Catacumbas.unity.meta
================
fileFormatVersion: 2
guid: b9ba936afff67f09f8d3b1c54550ad34
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Sounds/Player/caminata.wav.meta
================
fileFormatVersion: 2
guid: 6f07fc5c44e12b773b6ec4a155e6ae7c
AudioImporter:
  externalObjects: {}
  serializedVersion: 7
  defaultSettings:
    serializedVersion: 2
    loadType: 0
    sampleRateSetting: 0
    sampleRateOverride: 44100
    compressionFormat: 1
    quality: 1
    conversionMode: 0
    preloadAudioData: 0
  platformSettingOverrides: {}
  forceToMono: 0
  normalize: 1
  loadInBackground: 0
  ambisonic: 0
  3D: 1
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Sounds/Player/grito.wav.meta
================
fileFormatVersion: 2
guid: f0a9db96aa8068c7682df3950e6a55b8
AudioImporter:
  externalObjects: {}
  serializedVersion: 7
  defaultSettings:
    serializedVersion: 2
    loadType: 0
    sampleRateSetting: 0
    sampleRateOverride: 44100
    compressionFormat: 1
    quality: 1
    conversionMode: 0
    preloadAudioData: 0
  platformSettingOverrides: {}
  forceToMono: 0
  normalize: 1
  loadInBackground: 0
  ambisonic: 0
  3D: 1
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Sounds/Player/susurro.wav.meta
================
fileFormatVersion: 2
guid: e0019f101d7b58e26ac288a24bf0c122
AudioImporter:
  externalObjects: {}
  serializedVersion: 7
  defaultSettings:
    serializedVersion: 2
    loadType: 0
    sampleRateSetting: 0
    sampleRateOverride: 44100
    compressionFormat: 1
    quality: 1
    conversionMode: 0
    preloadAudioData: 0
  platformSettingOverrides: {}
  forceToMono: 0
  normalize: 1
  loadInBackground: 0
  ambisonic: 0
  3D: 1
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Sounds/Player.meta
================
fileFormatVersion: 2
guid: d5bb672078e8ee172b9b2ec818129e46
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/_Scripts.meta
================
fileFormatVersion: 2
guid: 963f125796fb29e41b5491699d6b5b47
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Art.meta
================
fileFormatVersion: 2
guid: d1e981140701cea83b402c6def1f2119
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Input.meta
================
fileFormatVersion: 2
guid: 77c5b9aba54d783c58629202f1bfe7b2
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Scenes.meta
================
fileFormatVersion: 2
guid: 879fc5a1263e83a6f852097b7099d190
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/Sounds.meta
================
fileFormatVersion: 2
guid: 8d2dc47ded6f49736b1a9e45de3005be
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Assets/TextMesh Pro.meta
================
fileFormatVersion: 2
guid: f54d1bd14bd3ca042bd867b519fee8cc
folderAsset: yes
DefaultImporter:
  externalObjects: {}
  userData: 
  assetBundleName: 
  assetBundleVariant:

================
File: Packages/manifest.json
================
{
  "dependencies": {
    "com.coplaydev.unity-mcp": "https://github.com/CoplayDev/unity-mcp.git?path=/MCPForUnity#main",
    "com.unity.ai.navigation": "1.1.7",
    "com.unity.cinemachine": "2.10.7",
    "com.unity.ide.rider": "3.0.40",
    "com.unity.inputsystem": "1.14.2",
    "com.unity.textmeshpro": "3.0.9",
    "com.unity.toolchain.linux-x86_64": "2.0.11",
    "com.unity.modules.ai": "1.0.0",
    "com.unity.modules.androidjni": "1.0.0",
    "com.unity.modules.animation": "1.0.0",
    "com.unity.modules.assetbundle": "1.0.0",
    "com.unity.modules.audio": "1.0.0",
    "com.unity.modules.cloth": "1.0.0",
    "com.unity.modules.director": "1.0.0",
    "com.unity.modules.imageconversion": "1.0.0",
    "com.unity.modules.imgui": "1.0.0",
    "com.unity.modules.jsonserialize": "1.0.0",
    "com.unity.modules.particlesystem": "1.0.0",
    "com.unity.modules.physics": "1.0.0",
    "com.unity.modules.physics2d": "1.0.0",
    "com.unity.modules.screencapture": "1.0.0",
    "com.unity.modules.terrain": "1.0.0",
    "com.unity.modules.terrainphysics": "1.0.0",
    "com.unity.modules.tilemap": "1.0.0",
    "com.unity.modules.ui": "1.0.0",
    "com.unity.modules.uielements": "1.0.0",
    "com.unity.modules.umbra": "1.0.0",
    "com.unity.modules.unityanalytics": "1.0.0",
    "com.unity.modules.unitywebrequest": "1.0.0",
    "com.unity.modules.unitywebrequestassetbundle": "1.0.0",
    "com.unity.modules.unitywebrequestaudio": "1.0.0",
    "com.unity.modules.unitywebrequesttexture": "1.0.0",
    "com.unity.modules.unitywebrequestwww": "1.0.0",
    "com.unity.modules.vehicles": "1.0.0",
    "com.unity.modules.video": "1.0.0",
    "com.unity.modules.vr": "1.0.0",
    "com.unity.modules.wind": "1.0.0",
    "com.unity.modules.xr": "1.0.0"
  }
}

================
File: Packages/packages-lock.json
================
{
  "dependencies": {
    "com.coplaydev.unity-mcp": {
      "version": "https://github.com/CoplayDev/unity-mcp.git?path=/MCPForUnity#main",
      "depth": 0,
      "source": "git",
      "dependencies": {
        "com.unity.modules.animation": "1.0.0",
        "com.unity.modules.imageconversion": "1.0.0",
        "com.unity.modules.physics": "1.0.0",
        "com.unity.modules.physics2d": "1.0.0",
        "com.unity.modules.uielements": "1.0.0",
        "com.unity.modules.screencapture": "1.0.0",
        "com.unity.modules.unitywebrequest": "1.0.0",
        "com.unity.nuget.newtonsoft-json": "3.0.2",
        "com.unity.test-framework": "1.1.31"
      },
      "hash": "85c101f5329ec1b0c6f70cba44614166dd78f53c"
    },
    "com.unity.ai.navigation": {
      "version": "1.1.7",
      "depth": 0,
      "source": "registry",
      "dependencies": {
        "com.unity.modules.ai": "1.0.0"
      },
      "url": "https://packages.unity.com"
    },
    "com.unity.cinemachine": {
      "version": "2.10.7",
      "depth": 0,
      "source": "registry",
      "dependencies": {
        "com.unity.test-framework": "1.1.31"
      },
      "url": "https://packages.unity.com"
    },
    "com.unity.ext.nunit": {
      "version": "1.0.6",
      "depth": 1,
      "source": "registry",
      "dependencies": {},
      "url": "https://packages.unity.com"
    },
    "com.unity.ide.rider": {
      "version": "3.0.40",
      "depth": 0,
      "source": "registry",
      "dependencies": {
        "com.unity.ext.nunit": "1.0.6"
      },
      "url": "https://packages.unity.com"
    },
    "com.unity.inputsystem": {
      "version": "1.14.2",
      "depth": 0,
      "source": "registry",
      "dependencies": {
        "com.unity.modules.uielements": "1.0.0"
      },
      "url": "https://packages.unity.com"
    },
    "com.unity.nuget.newtonsoft-json": {
      "version": "3.2.1",
      "depth": 1,
      "source": "registry",
      "dependencies": {},
      "url": "https://packages.unity.com"
    },
    "com.unity.sysroot": {
      "version": "2.0.10",
      "depth": 1,
      "source": "registry",
      "dependencies": {},
      "url": "https://packages.unity.com"
    },
    "com.unity.sysroot.linux-x86_64": {
      "version": "2.0.9",
      "depth": 1,
      "source": "registry",
      "dependencies": {
        "com.unity.sysroot": "2.0.10"
      },
      "url": "https://packages.unity.com"
    },
    "com.unity.test-framework": {
      "version": "1.1.33",
      "depth": 1,
      "source": "registry",
      "dependencies": {
        "com.unity.ext.nunit": "1.0.6",
        "com.unity.modules.imgui": "1.0.0",
        "com.unity.modules.jsonserialize": "1.0.0"
      },
      "url": "https://packages.unity.com"
    },
    "com.unity.textmeshpro": {
      "version": "3.0.9",
      "depth": 0,
      "source": "registry",
      "dependencies": {
        "com.unity.ugui": "1.0.0"
      },
      "url": "https://packages.unity.com"
    },
    "com.unity.toolchain.linux-x86_64": {
      "version": "2.0.11",
      "depth": 0,
      "source": "registry",
      "dependencies": {
        "com.unity.sysroot": "2.0.10",
        "com.unity.sysroot.linux-x86_64": "2.0.9"
      },
      "url": "https://packages.unity.com"
    },
    "com.unity.ugui": {
      "version": "1.0.0",
      "depth": 1,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.ui": "1.0.0",
        "com.unity.modules.imgui": "1.0.0"
      }
    },
    "com.unity.modules.ai": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.androidjni": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.animation": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.assetbundle": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.audio": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.cloth": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.physics": "1.0.0"
      }
    },
    "com.unity.modules.director": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.audio": "1.0.0",
        "com.unity.modules.animation": "1.0.0"
      }
    },
    "com.unity.modules.imageconversion": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.imgui": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.jsonserialize": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.particlesystem": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.physics": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.physics2d": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.screencapture": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.imageconversion": "1.0.0"
      }
    },
    "com.unity.modules.subsystems": {
      "version": "1.0.0",
      "depth": 1,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.jsonserialize": "1.0.0"
      }
    },
    "com.unity.modules.terrain": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.terrainphysics": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.physics": "1.0.0",
        "com.unity.modules.terrain": "1.0.0"
      }
    },
    "com.unity.modules.tilemap": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.physics2d": "1.0.0"
      }
    },
    "com.unity.modules.ui": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.uielements": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.ui": "1.0.0",
        "com.unity.modules.imgui": "1.0.0",
        "com.unity.modules.jsonserialize": "1.0.0"
      }
    },
    "com.unity.modules.umbra": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.unityanalytics": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.unitywebrequest": "1.0.0",
        "com.unity.modules.jsonserialize": "1.0.0"
      }
    },
    "com.unity.modules.unitywebrequest": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.unitywebrequestassetbundle": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.assetbundle": "1.0.0",
        "com.unity.modules.unitywebrequest": "1.0.0"
      }
    },
    "com.unity.modules.unitywebrequestaudio": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.unitywebrequest": "1.0.0",
        "com.unity.modules.audio": "1.0.0"
      }
    },
    "com.unity.modules.unitywebrequesttexture": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.unitywebrequest": "1.0.0",
        "com.unity.modules.imageconversion": "1.0.0"
      }
    },
    "com.unity.modules.unitywebrequestwww": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.unitywebrequest": "1.0.0",
        "com.unity.modules.unitywebrequestassetbundle": "1.0.0",
        "com.unity.modules.unitywebrequestaudio": "1.0.0",
        "com.unity.modules.audio": "1.0.0",
        "com.unity.modules.assetbundle": "1.0.0",
        "com.unity.modules.imageconversion": "1.0.0"
      }
    },
    "com.unity.modules.vehicles": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.physics": "1.0.0"
      }
    },
    "com.unity.modules.video": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.audio": "1.0.0",
        "com.unity.modules.ui": "1.0.0",
        "com.unity.modules.unitywebrequest": "1.0.0"
      }
    },
    "com.unity.modules.vr": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.jsonserialize": "1.0.0",
        "com.unity.modules.physics": "1.0.0",
        "com.unity.modules.xr": "1.0.0"
      }
    },
    "com.unity.modules.wind": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {}
    },
    "com.unity.modules.xr": {
      "version": "1.0.0",
      "depth": 0,
      "source": "builtin",
      "dependencies": {
        "com.unity.modules.physics": "1.0.0",
        "com.unity.modules.jsonserialize": "1.0.0",
        "com.unity.modules.subsystems": "1.0.0"
      }
    }
  }
}

================
File: ProjectSettings/AudioManager.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!11 &1
AudioManager:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  m_Volume: 1
  Rolloff Scale: 1
  Doppler Factor: 1
  Default Speaker Mode: 2
  m_SampleRate: 0
  m_DSPBufferSize: 1024
  m_VirtualVoiceCount: 512
  m_RealVoiceCount: 32
  m_EnableOutputSuspension: 1
  m_SpatializerPlugin: 
  m_AmbisonicDecoderPlugin: 
  m_DisableAudio: 0
  m_VirtualizeEffects: 1
  m_RequestedDSPBufferSize: 0

================
File: ProjectSettings/ClusterInputManager.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!236 &1
ClusterInputManager:
  m_ObjectHideFlags: 0
  m_Inputs: []

================
File: ProjectSettings/DynamicsManager.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!55 &1
PhysicsManager:
  m_ObjectHideFlags: 0
  serializedVersion: 14
  m_Gravity: {x: 0, y: -9.81, z: 0}
  m_DefaultMaterial: {fileID: 0}
  m_BounceThreshold: 2
  m_DefaultMaxDepenetrationVelocity: 10
  m_SleepThreshold: 0.005
  m_DefaultContactOffset: 0.01
  m_DefaultSolverIterations: 6
  m_DefaultSolverVelocityIterations: 1
  m_QueriesHitBackfaces: 0
  m_QueriesHitTriggers: 1
  m_EnableAdaptiveForce: 0
  m_ClothInterCollisionDistance: 0.1
  m_ClothInterCollisionStiffness: 0.2
  m_ContactsGeneration: 1
  m_LayerCollisionMatrix: ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
  m_SimulationMode: 0
  m_AutoSyncTransforms: 0
  m_ReuseCollisionCallbacks: 0
  m_InvokeCollisionCallbacks: 1
  m_ClothInterCollisionSettingsToggle: 0
  m_ClothGravity: {x: 0, y: -9.81, z: 0}
  m_ContactPairsMode: 0
  m_BroadphaseType: 0
  m_WorldBounds:
    m_Center: {x: 0, y: 0, z: 0}
    m_Extent: {x: 250, y: 250, z: 250}
  m_WorldSubdivisions: 8
  m_FrictionType: 0
  m_EnableEnhancedDeterminism: 0
  m_EnableUnifiedHeightmaps: 1
  m_ImprovedPatchFriction: 0
  m_SolverType: 0
  m_DefaultMaxAngularSpeed: 50
  m_FastMotionThreshold: 3.4028235e+38

================
File: ProjectSettings/EditorBuildSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1045 &1
EditorBuildSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  m_Scenes: []
  m_configObjects: {}

================
File: ProjectSettings/EditorSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!159 &1
EditorSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 12
  m_SerializationMode: 2
  m_LineEndingsForNewScripts: 1
  m_DefaultBehaviorMode: 0
  m_PrefabRegularEnvironment: {fileID: 0}
  m_PrefabUIEnvironment: {fileID: 0}
  m_SpritePackerMode: 0
  m_SpritePackerCacheSize: 10
  m_SpritePackerPaddingPower: 1
  m_Bc7TextureCompressor: 0
  m_EtcTextureCompressorBehavior: 1
  m_EtcTextureFastCompressor: 1
  m_EtcTextureNormalCompressor: 2
  m_EtcTextureBestCompressor: 4
  m_ProjectGenerationIncludedExtensions: txt;xml;fnt;cd;asmdef;asmref;rsp;java;cpp;c;mm;m;h
  m_ProjectGenerationRootNamespace: 
  m_EnableTextureStreamingInEditMode: 1
  m_EnableTextureStreamingInPlayMode: 1
  m_EnableEditorAsyncCPUTextureLoading: 0
  m_AsyncShaderCompilation: 1
  m_PrefabModeAllowAutoSave: 1
  m_EnterPlayModeOptionsEnabled: 0
  m_EnterPlayModeOptions: 3
  m_GameObjectNamingDigits: 1
  m_GameObjectNamingScheme: 0
  m_AssetNamingUsesSpace: 1
  m_InspectorUseIMGUIDefaultInspector: 0
  m_UseLegacyProbeSampleCount: 0
  m_SerializeInlineMappingsOnOneLine: 1
  m_DisableCookiesInLightmapper: 0
  m_AssetPipelineMode: 1
  m_RefreshImportMode: 0
  m_CacheServerMode: 0
  m_CacheServerEndpoint: 
  m_CacheServerNamespacePrefix: default
  m_CacheServerEnableDownload: 1
  m_CacheServerEnableUpload: 1
  m_CacheServerEnableAuth: 0
  m_CacheServerEnableTls: 0
  m_CacheServerValidationMode: 2
  m_CacheServerDownloadBatchSize: 128
  m_EnableEnlightenBakedGI: 0

================
File: ProjectSettings/GraphicsSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!30 &1
GraphicsSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 15
  m_Deferred:
    m_Mode: 1
    m_Shader: {fileID: 69, guid: 0000000000000000f000000000000000, type: 0}
  m_DeferredReflections:
    m_Mode: 1
    m_Shader: {fileID: 74, guid: 0000000000000000f000000000000000, type: 0}
  m_ScreenSpaceShadows:
    m_Mode: 1
    m_Shader: {fileID: 64, guid: 0000000000000000f000000000000000, type: 0}
  m_DepthNormals:
    m_Mode: 1
    m_Shader: {fileID: 62, guid: 0000000000000000f000000000000000, type: 0}
  m_MotionVectors:
    m_Mode: 1
    m_Shader: {fileID: 75, guid: 0000000000000000f000000000000000, type: 0}
  m_LightHalo:
    m_Mode: 1
    m_Shader: {fileID: 105, guid: 0000000000000000f000000000000000, type: 0}
  m_LensFlare:
    m_Mode: 1
    m_Shader: {fileID: 102, guid: 0000000000000000f000000000000000, type: 0}
  m_VideoShadersIncludeMode: 2
  m_AlwaysIncludedShaders:
  - {fileID: 7, guid: 0000000000000000f000000000000000, type: 0}
  - {fileID: 15104, guid: 0000000000000000f000000000000000, type: 0}
  - {fileID: 15105, guid: 0000000000000000f000000000000000, type: 0}
  - {fileID: 15106, guid: 0000000000000000f000000000000000, type: 0}
  - {fileID: 10753, guid: 0000000000000000f000000000000000, type: 0}
  - {fileID: 10770, guid: 0000000000000000f000000000000000, type: 0}
  - {fileID: 10783, guid: 0000000000000000f000000000000000, type: 0}
  m_PreloadedShaders: []
  m_PreloadShadersBatchTimeLimit: -1
  m_SpritesDefaultMaterial: {fileID: 10754, guid: 0000000000000000f000000000000000, type: 0}
  m_CustomRenderPipeline: {fileID: 0}
  m_TransparencySortMode: 0
  m_TransparencySortAxis: {x: 0, y: 0, z: 1}
  m_DefaultRenderingPath: 1
  m_DefaultMobileRenderingPath: 1
  m_TierSettings: []
  m_LightmapStripping: 0
  m_FogStripping: 0
  m_InstancingStripping: 0
  m_BrgStripping: 0
  m_LightmapKeepPlain: 1
  m_LightmapKeepDirCombined: 1
  m_LightmapKeepDynamicPlain: 1
  m_LightmapKeepDynamicDirCombined: 1
  m_LightmapKeepShadowMask: 1
  m_LightmapKeepSubtractive: 1
  m_FogKeepLinear: 1
  m_FogKeepExp: 1
  m_FogKeepExp2: 1
  m_AlbedoSwatchInfos: []
  m_LightsUseLinearIntensity: 0
  m_LightsUseColorTemperature: 0
  m_DefaultRenderingLayerMask: 1
  m_LogWhenShaderIsCompiled: 0
  m_SRPDefaultSettings: {}
  m_LightProbeOutsideHullStrategy: 1
  m_CameraRelativeLightCulling: 0
  m_CameraRelativeShadowCulling: 0

================
File: ProjectSettings/InputManager.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!13 &1
InputManager:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  m_Axes:
  - serializedVersion: 3
    m_Name: Horizontal
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: left
    positiveButton: right
    altNegativeButton: a
    altPositiveButton: d
    gravity: 3
    dead: 0.001
    sensitivity: 3
    snap: 1
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Vertical
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: down
    positiveButton: up
    altNegativeButton: s
    altPositiveButton: w
    gravity: 3
    dead: 0.001
    sensitivity: 3
    snap: 1
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Fire1
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: left ctrl
    altNegativeButton: 
    altPositiveButton: mouse 0
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Fire2
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: left alt
    altNegativeButton: 
    altPositiveButton: mouse 1
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Fire3
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: left shift
    altNegativeButton: 
    altPositiveButton: mouse 2
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Jump
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: space
    altNegativeButton: 
    altPositiveButton: 
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Mouse X
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: 
    altNegativeButton: 
    altPositiveButton: 
    gravity: 0
    dead: 0
    sensitivity: 0.1
    snap: 0
    invert: 0
    type: 1
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Mouse Y
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: 
    altNegativeButton: 
    altPositiveButton: 
    gravity: 0
    dead: 0
    sensitivity: 0.1
    snap: 0
    invert: 0
    type: 1
    axis: 1
    joyNum: 0
  - serializedVersion: 3
    m_Name: Mouse ScrollWheel
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: 
    altNegativeButton: 
    altPositiveButton: 
    gravity: 0
    dead: 0
    sensitivity: 0.1
    snap: 0
    invert: 0
    type: 1
    axis: 2
    joyNum: 0
  - serializedVersion: 3
    m_Name: Horizontal
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: 
    altNegativeButton: 
    altPositiveButton: 
    gravity: 0
    dead: 0.19
    sensitivity: 1
    snap: 0
    invert: 0
    type: 2
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Vertical
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: 
    altNegativeButton: 
    altPositiveButton: 
    gravity: 0
    dead: 0.19
    sensitivity: 1
    snap: 0
    invert: 1
    type: 2
    axis: 1
    joyNum: 0
  - serializedVersion: 3
    m_Name: Fire1
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: joystick button 0
    altNegativeButton: 
    altPositiveButton: 
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Fire2
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: joystick button 1
    altNegativeButton: 
    altPositiveButton: 
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Fire3
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: joystick button 2
    altNegativeButton: 
    altPositiveButton: 
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Jump
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: joystick button 3
    altNegativeButton: 
    altPositiveButton: 
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Submit
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: return
    altNegativeButton: 
    altPositiveButton: joystick button 0
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Submit
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: enter
    altNegativeButton: 
    altPositiveButton: space
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  - serializedVersion: 3
    m_Name: Cancel
    descriptiveName: 
    descriptiveNegativeName: 
    negativeButton: 
    positiveButton: escape
    altNegativeButton: 
    altPositiveButton: joystick button 1
    gravity: 1000
    dead: 0.001
    sensitivity: 1000
    snap: 0
    invert: 0
    type: 0
    axis: 0
    joyNum: 0
  m_UsePhysicalKeys: 1

================
File: ProjectSettings/MemorySettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!387306366 &1
MemorySettings:
  m_ObjectHideFlags: 0
  m_EditorMemorySettings:
    m_MainAllocatorBlockSize: -1
    m_ThreadAllocatorBlockSize: -1
    m_MainGfxBlockSize: -1
    m_ThreadGfxBlockSize: -1
    m_CacheBlockSize: -1
    m_TypetreeBlockSize: -1
    m_ProfilerBlockSize: -1
    m_ProfilerEditorBlockSize: -1
    m_BucketAllocatorGranularity: -1
    m_BucketAllocatorBucketsCount: -1
    m_BucketAllocatorBlockSize: -1
    m_BucketAllocatorBlockCount: -1
    m_ProfilerBucketAllocatorGranularity: -1
    m_ProfilerBucketAllocatorBucketsCount: -1
    m_ProfilerBucketAllocatorBlockSize: -1
    m_ProfilerBucketAllocatorBlockCount: -1
    m_TempAllocatorSizeMain: -1
    m_JobTempAllocatorBlockSize: -1
    m_BackgroundJobTempAllocatorBlockSize: -1
    m_JobTempAllocatorReducedBlockSize: -1
    m_TempAllocatorSizeGIBakingWorker: -1
    m_TempAllocatorSizeNavMeshWorker: -1
    m_TempAllocatorSizeAudioWorker: -1
    m_TempAllocatorSizeCloudWorker: -1
    m_TempAllocatorSizeGfx: -1
    m_TempAllocatorSizeJobWorker: -1
    m_TempAllocatorSizeBackgroundWorker: -1
    m_TempAllocatorSizePreloadManager: -1
  m_PlatformMemorySettings: {}

================
File: ProjectSettings/NavMeshAreas.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!126 &1
NavMeshProjectSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  areas:
  - name: Walkable
    cost: 1
  - name: Not Walkable
    cost: 1
  - name: Jump
    cost: 2
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  - name: 
    cost: 1
  m_LastAgentTypeID: -1372625422
  m_Settings:
  - serializedVersion: 3
    agentTypeID: 0
    agentRadius: 0.5
    agentHeight: 2
    agentSlope: 45
    agentClimb: 0.75
    ledgeDropHeight: 0
    maxJumpAcrossDistance: 0
    minRegionArea: 2
    manualCellSize: 0
    cellSize: 0.16666667
    manualTileSize: 0
    tileSize: 256
    buildHeightMesh: 0
    maxJobWorkers: 0
    preserveTilesOutsideBounds: 0
    debug:
      m_Flags: 0
  m_SettingNames:
  - Humanoid

================
File: ProjectSettings/PackageManagerSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &1
MonoBehaviour:
  m_ObjectHideFlags: 53
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 13964, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_EnablePreReleasePackages: 0
  m_AdvancedSettingsExpanded: 1
  m_ScopedRegistriesSettingsExpanded: 1
  m_SeeAllPackageVersions: 0
  m_DismissPreviewPackagesInUse: 0
  oneTimeWarningShown: 0
  m_Registries:
  - m_Id: main
    m_Name: 
    m_Url: https://packages.unity.com
    m_Scopes: []
    m_IsDefault: 1
    m_Capabilities: 7
    m_ConfigSource: 0
  m_UserSelectedRegistryName: 
  m_UserAddingNewScopedRegistry: 0
  m_RegistryInfoDraft:
    m_Modified: 0
    m_ErrorMessage: 
    m_UserModificationsInstanceId: -888
    m_OriginalInstanceId: -890
  m_LoadAssets: 0

================
File: ProjectSettings/Physics2DSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!19 &1
Physics2DSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 6
  m_Gravity: {x: 0, y: -9.81}
  m_DefaultMaterial: {fileID: 0}
  m_VelocityIterations: 8
  m_PositionIterations: 3
  m_VelocityThreshold: 1
  m_MaxLinearCorrection: 0.2
  m_MaxAngularCorrection: 8
  m_MaxTranslationSpeed: 100
  m_MaxRotationSpeed: 360
  m_BaumgarteScale: 0.2
  m_BaumgarteTimeOfImpactScale: 0.75
  m_TimeToSleep: 0.5
  m_LinearSleepTolerance: 0.01
  m_AngularSleepTolerance: 2
  m_DefaultContactOffset: 0.01
  m_JobOptions:
    serializedVersion: 2
    useMultithreading: 0
    useConsistencySorting: 0
    m_InterpolationPosesPerJob: 100
    m_NewContactsPerJob: 30
    m_CollideContactsPerJob: 100
    m_ClearFlagsPerJob: 200
    m_ClearBodyForcesPerJob: 200
    m_SyncDiscreteFixturesPerJob: 50
    m_SyncContinuousFixturesPerJob: 50
    m_FindNearestContactsPerJob: 100
    m_UpdateTriggerContactsPerJob: 100
    m_IslandSolverCostThreshold: 100
    m_IslandSolverBodyCostScale: 1
    m_IslandSolverContactCostScale: 10
    m_IslandSolverJointCostScale: 10
    m_IslandSolverBodiesPerJob: 50
    m_IslandSolverContactsPerJob: 50
  m_SimulationMode: 0
  m_QueriesHitTriggers: 1
  m_QueriesStartInColliders: 1
  m_CallbacksOnDisable: 1
  m_ReuseCollisionCallbacks: 1
  m_AutoSyncTransforms: 0
  m_GizmoOptions: 10
  m_LayerCollisionMatrix: ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff

================
File: ProjectSettings/PresetManager.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!1386491679 &1
PresetManager:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  m_DefaultPresets: {}

================
File: ProjectSettings/ProjectSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!129 &1
PlayerSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 26
  productGUID: 03736164c74b51c748580d8812fc1936
  AndroidProfiler: 0
  AndroidFilterTouchesWhenObscured: 0
  AndroidEnableSustainedPerformanceMode: 0
  defaultScreenOrientation: 4
  targetDevice: 2
  useOnDemandResources: 0
  accelerometerFrequency: 60
  companyName: DefaultCompany
  productName: Prototype_Terror
  defaultCursor: {fileID: 0}
  cursorHotspot: {x: 0, y: 0}
  m_SplashScreenBackgroundColor: {r: 0.12156863, g: 0.12156863, b: 0.1254902, a: 1}
  m_ShowUnitySplashScreen: 1
  m_ShowUnitySplashLogo: 1
  m_SplashScreenOverlayOpacity: 1
  m_SplashScreenAnimation: 1
  m_SplashScreenLogoStyle: 1
  m_SplashScreenDrawMode: 0
  m_SplashScreenBackgroundAnimationZoom: 1
  m_SplashScreenLogoAnimationZoom: 1
  m_SplashScreenBackgroundLandscapeAspect: 1
  m_SplashScreenBackgroundPortraitAspect: 1
  m_SplashScreenBackgroundLandscapeUvs:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1
    height: 1
  m_SplashScreenBackgroundPortraitUvs:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1
    height: 1
  m_SplashScreenLogos: []
  m_VirtualRealitySplashScreen: {fileID: 0}
  m_HolographicTrackingLossScreen: {fileID: 0}
  defaultScreenWidth: 1920
  defaultScreenHeight: 1080
  defaultScreenWidthWeb: 960
  defaultScreenHeightWeb: 600
  m_StereoRenderingPath: 0
  m_ActiveColorSpace: 0
  unsupportedMSAAFallback: 0
  m_SpriteBatchVertexThreshold: 300
  m_MTRendering: 1
  mipStripping: 0
  numberOfMipsStripped: 0
  numberOfMipsStrippedPerMipmapLimitGroup: {}
  m_StackTraceTypes: 010000000100000001000000010000000100000001000000
  iosShowActivityIndicatorOnLoading: -1
  androidShowActivityIndicatorOnLoading: -1
  iosUseCustomAppBackgroundBehavior: 0
  allowedAutorotateToPortrait: 1
  allowedAutorotateToPortraitUpsideDown: 1
  allowedAutorotateToLandscapeRight: 1
  allowedAutorotateToLandscapeLeft: 1
  useOSAutorotation: 1
  use32BitDisplayBuffer: 1
  preserveFramebufferAlpha: 0
  disableDepthAndStencilBuffers: 0
  androidStartInFullscreen: 1
  androidRenderOutsideSafeArea: 1
  androidUseSwappy: 1
  androidBlitType: 0
  androidResizableWindow: 0
  androidDefaultWindowWidth: 1920
  androidDefaultWindowHeight: 1080
  androidMinimumWindowWidth: 400
  androidMinimumWindowHeight: 300
  androidFullscreenMode: 1
  androidAutoRotationBehavior: 1
  androidPredictiveBackSupport: 1
  defaultIsNativeResolution: 1
  macRetinaSupport: 1
  runInBackground: 0
  captureSingleScreen: 0
  muteOtherAudioSources: 0
  Prepare IOS For Recording: 0
  Force IOS Speakers When Recording: 0
  audioSpatialExperience: 0
  deferSystemGesturesMode: 0
  hideHomeButton: 0
  submitAnalytics: 1
  usePlayerLog: 1
  dedicatedServerOptimizations: 0
  bakeCollisionMeshes: 0
  forceSingleInstance: 0
  useFlipModelSwapchain: 1
  resizableWindow: 0
  useMacAppStoreValidation: 0
  macAppStoreCategory: public.app-category.games
  gpuSkinning: 0
  xboxPIXTextureCapture: 0
  xboxEnableAvatar: 0
  xboxEnableKinect: 0
  xboxEnableKinectAutoTracking: 0
  xboxEnableFitness: 0
  visibleInBackground: 1
  allowFullscreenSwitch: 1
  fullscreenMode: 1
  xboxSpeechDB: 0
  xboxEnableHeadOrientation: 0
  xboxEnableGuest: 0
  xboxEnablePIXSampling: 0
  metalFramebufferOnly: 0
  xboxOneResolution: 0
  xboxOneSResolution: 0
  xboxOneXResolution: 3
  xboxOneMonoLoggingLevel: 0
  xboxOneLoggingLevel: 1
  xboxOneDisableEsram: 0
  xboxOneEnableTypeOptimization: 0
  xboxOnePresentImmediateThreshold: 0
  switchQueueCommandMemory: 1048576
  switchQueueControlMemory: 16384
  switchQueueComputeMemory: 262144
  switchNVNShaderPoolsGranularity: 33554432
  switchNVNDefaultPoolsGranularity: 16777216
  switchNVNOtherPoolsGranularity: 16777216
  switchGpuScratchPoolGranularity: 2097152
  switchAllowGpuScratchShrinking: 0
  switchNVNMaxPublicTextureIDCount: 0
  switchNVNMaxPublicSamplerIDCount: 0
  switchNVNGraphicsFirmwareMemory: 32
  switchMaxWorkerMultiple: 8
  stadiaPresentMode: 0
  stadiaTargetFramerate: 0
  vulkanNumSwapchainBuffers: 3
  vulkanEnableSetSRGBWrite: 0
  vulkanEnablePreTransform: 0
  vulkanEnableLateAcquireNextImage: 0
  vulkanEnableCommandBufferRecycling: 1
  loadStoreDebugModeEnabled: 0
  visionOSBundleVersion: 1.0
  tvOSBundleVersion: 1.0
  bundleVersion: 1.0
  preloadedAssets: []
  metroInputSource: 0
  wsaTransparentSwapchain: 0
  m_HolographicPauseOnTrackingLoss: 1
  xboxOneDisableKinectGpuReservation: 1
  xboxOneEnable7thCore: 1
  vrSettings:
    enable360StereoCapture: 0
  isWsaHolographicRemotingEnabled: 0
  enableFrameTimingStats: 0
  enableOpenGLProfilerGPURecorders: 1
  allowHDRDisplaySupport: 0
  useHDRDisplay: 0
  hdrBitDepth: 0
  m_ColorGamuts: 00000000
  targetPixelDensity: 30
  resolutionScalingMode: 0
  resetResolutionOnWindowResize: 0
  androidSupportedAspectRatio: 1
  androidMaxAspectRatio: 2.1
  applicationIdentifier:
    Standalone: com.DefaultCompany.Prototype-Terror
  buildNumber:
    Standalone: 0
    VisionOS: 0
    iPhone: 0
    tvOS: 0
  overrideDefaultApplicationIdentifier: 0
  AndroidBundleVersionCode: 1
  AndroidMinSdkVersion: 22
  AndroidTargetSdkVersion: 0
  AndroidPreferredInstallLocation: 1
  aotOptions: 
  stripEngineCode: 1
  iPhoneStrippingLevel: 0
  iPhoneScriptCallOptimization: 0
  ForceInternetPermission: 0
  ForceSDCardPermission: 0
  CreateWallpaper: 0
  APKExpansionFiles: 0
  keepLoadedShadersAlive: 0
  StripUnusedMeshComponents: 0
  strictShaderVariantMatching: 0
  VertexChannelCompressionMask: 4054
  iPhoneSdkVersion: 988
  iOSSimulatorArchitecture: 0
  iOSTargetOSVersionString: 12.0
  tvOSSdkVersion: 0
  tvOSSimulatorArchitecture: 0
  tvOSRequireExtendedGameController: 0
  tvOSTargetOSVersionString: 12.0
  VisionOSSdkVersion: 0
  VisionOSTargetOSVersionString: 1.0
  uIPrerenderedIcon: 0
  uIRequiresPersistentWiFi: 0
  uIRequiresFullScreen: 1
  uIStatusBarHidden: 1
  uIExitOnSuspend: 0
  uIStatusBarStyle: 0
  appleTVSplashScreen: {fileID: 0}
  appleTVSplashScreen2x: {fileID: 0}
  tvOSSmallIconLayers: []
  tvOSSmallIconLayers2x: []
  tvOSLargeIconLayers: []
  tvOSLargeIconLayers2x: []
  tvOSTopShelfImageLayers: []
  tvOSTopShelfImageLayers2x: []
  tvOSTopShelfImageWideLayers: []
  tvOSTopShelfImageWideLayers2x: []
  iOSLaunchScreenType: 0
  iOSLaunchScreenPortrait: {fileID: 0}
  iOSLaunchScreenLandscape: {fileID: 0}
  iOSLaunchScreenBackgroundColor:
    serializedVersion: 2
    rgba: 0
  iOSLaunchScreenFillPct: 100
  iOSLaunchScreenSize: 100
  iOSLaunchScreenCustomXibPath: 
  iOSLaunchScreeniPadType: 0
  iOSLaunchScreeniPadImage: {fileID: 0}
  iOSLaunchScreeniPadBackgroundColor:
    serializedVersion: 2
    rgba: 0
  iOSLaunchScreeniPadFillPct: 100
  iOSLaunchScreeniPadSize: 100
  iOSLaunchScreeniPadCustomXibPath: 
  iOSLaunchScreenCustomStoryboardPath: 
  iOSLaunchScreeniPadCustomStoryboardPath: 
  iOSDeviceRequirements: []
  iOSURLSchemes: []
  macOSURLSchemes: []
  iOSBackgroundModes: 0
  iOSMetalForceHardShadows: 0
  metalEditorSupport: 1
  metalAPIValidation: 1
  metalCompileShaderBinary: 0
  iOSRenderExtraFrameOnPause: 0
  iosCopyPluginsCodeInsteadOfSymlink: 0
  appleDeveloperTeamID: 
  iOSManualSigningProvisioningProfileID: 
  tvOSManualSigningProvisioningProfileID: 
  VisionOSManualSigningProvisioningProfileID: 
  iOSManualSigningProvisioningProfileType: 0
  tvOSManualSigningProvisioningProfileType: 0
  VisionOSManualSigningProvisioningProfileType: 0
  appleEnableAutomaticSigning: 0
  iOSRequireARKit: 0
  iOSAutomaticallyDetectAndAddCapabilities: 1
  appleEnableProMotion: 0
  shaderPrecisionModel: 0
  clonedFromGUID: 00000000000000000000000000000000
  templatePackageId: 
  templateDefaultScene: 
  useCustomMainManifest: 0
  useCustomLauncherManifest: 0
  useCustomMainGradleTemplate: 0
  useCustomLauncherGradleManifest: 0
  useCustomBaseGradleTemplate: 0
  useCustomGradlePropertiesTemplate: 0
  useCustomGradleSettingsTemplate: 0
  useCustomProguardFile: 0
  AndroidTargetArchitectures: 1
  AndroidTargetDevices: 0
  AndroidSplashScreenScale: 0
  androidSplashScreen: {fileID: 0}
  AndroidKeystoreName: 
  AndroidKeyaliasName: 
  AndroidEnableArmv9SecurityFeatures: 0
  AndroidBuildApkPerCpuArchitecture: 0
  AndroidTVCompatibility: 0
  AndroidIsGame: 1
  AndroidEnableTango: 0
  androidEnableBanner: 1
  androidUseLowAccuracyLocation: 0
  androidUseCustomKeystore: 0
  m_AndroidBanners:
  - width: 320
    height: 180
    banner: {fileID: 0}
  androidGamepadSupportLevel: 0
  chromeosInputEmulation: 1
  AndroidMinifyRelease: 0
  AndroidMinifyDebug: 0
  AndroidValidateAppBundleSize: 1
  AndroidAppBundleSizeToValidate: 200
  m_BuildTargetIcons: []
  m_BuildTargetPlatformIcons: []
  m_BuildTargetBatching: []
  m_BuildTargetShaderSettings: []
  m_BuildTargetGraphicsJobs: []
  m_BuildTargetGraphicsJobMode: []
  m_BuildTargetGraphicsAPIs: []
  m_BuildTargetVRSettings: []
  m_DefaultShaderChunkSizeInMB: 16
  m_DefaultShaderChunkCount: 0
  openGLRequireES31: 0
  openGLRequireES31AEP: 0
  openGLRequireES32: 0
  m_TemplateCustomTags: {}
  mobileMTRendering:
    Android: 1
    VisionOS: 1
    iPhone: 1
    tvOS: 1
  m_BuildTargetGroupLightmapEncodingQuality: []
  m_BuildTargetGroupHDRCubemapEncodingQuality: []
  m_BuildTargetGroupLightmapSettings: []
  m_BuildTargetGroupLoadStoreDebugModeSettings: []
  m_BuildTargetNormalMapEncoding: []
  m_BuildTargetDefaultTextureCompressionFormat: []
  playModeTestRunnerEnabled: 0
  runPlayModeTestAsEditModeTest: 0
  actionOnDotNetUnhandledException: 1
  enableInternalProfiler: 0
  logObjCUncaughtExceptions: 1
  enableCrashReportAPI: 0
  cameraUsageDescription: 
  locationUsageDescription: 
  microphoneUsageDescription: 
  bluetoothUsageDescription: 
  macOSTargetOSVersion: 10.13.0
  switchNMETAOverride: 
  switchNetLibKey: 
  switchSocketMemoryPoolSize: 6144
  switchSocketAllocatorPoolSize: 128
  switchSocketConcurrencyLimit: 14
  switchScreenResolutionBehavior: 2
  switchUseCPUProfiler: 0
  switchEnableFileSystemTrace: 0
  switchLTOSetting: 0
  switchApplicationID: 0x01004b9000490000
  switchNSODependencies: 
  switchCompilerFlags: 
  switchTitleNames_0: 
  switchTitleNames_1: 
  switchTitleNames_2: 
  switchTitleNames_3: 
  switchTitleNames_4: 
  switchTitleNames_5: 
  switchTitleNames_6: 
  switchTitleNames_7: 
  switchTitleNames_8: 
  switchTitleNames_9: 
  switchTitleNames_10: 
  switchTitleNames_11: 
  switchTitleNames_12: 
  switchTitleNames_13: 
  switchTitleNames_14: 
  switchTitleNames_15: 
  switchPublisherNames_0: 
  switchPublisherNames_1: 
  switchPublisherNames_2: 
  switchPublisherNames_3: 
  switchPublisherNames_4: 
  switchPublisherNames_5: 
  switchPublisherNames_6: 
  switchPublisherNames_7: 
  switchPublisherNames_8: 
  switchPublisherNames_9: 
  switchPublisherNames_10: 
  switchPublisherNames_11: 
  switchPublisherNames_12: 
  switchPublisherNames_13: 
  switchPublisherNames_14: 
  switchPublisherNames_15: 
  switchIcons_0: {fileID: 0}
  switchIcons_1: {fileID: 0}
  switchIcons_2: {fileID: 0}
  switchIcons_3: {fileID: 0}
  switchIcons_4: {fileID: 0}
  switchIcons_5: {fileID: 0}
  switchIcons_6: {fileID: 0}
  switchIcons_7: {fileID: 0}
  switchIcons_8: {fileID: 0}
  switchIcons_9: {fileID: 0}
  switchIcons_10: {fileID: 0}
  switchIcons_11: {fileID: 0}
  switchIcons_12: {fileID: 0}
  switchIcons_13: {fileID: 0}
  switchIcons_14: {fileID: 0}
  switchIcons_15: {fileID: 0}
  switchSmallIcons_0: {fileID: 0}
  switchSmallIcons_1: {fileID: 0}
  switchSmallIcons_2: {fileID: 0}
  switchSmallIcons_3: {fileID: 0}
  switchSmallIcons_4: {fileID: 0}
  switchSmallIcons_5: {fileID: 0}
  switchSmallIcons_6: {fileID: 0}
  switchSmallIcons_7: {fileID: 0}
  switchSmallIcons_8: {fileID: 0}
  switchSmallIcons_9: {fileID: 0}
  switchSmallIcons_10: {fileID: 0}
  switchSmallIcons_11: {fileID: 0}
  switchSmallIcons_12: {fileID: 0}
  switchSmallIcons_13: {fileID: 0}
  switchSmallIcons_14: {fileID: 0}
  switchSmallIcons_15: {fileID: 0}
  switchManualHTML: 
  switchAccessibleURLs: 
  switchLegalInformation: 
  switchMainThreadStackSize: 1048576
  switchPresenceGroupId: 
  switchLogoHandling: 0
  switchReleaseVersion: 0
  switchDisplayVersion: 1.0.0
  switchStartupUserAccount: 0
  switchSupportedLanguagesMask: 0
  switchLogoType: 0
  switchApplicationErrorCodeCategory: 
  switchUserAccountSaveDataSize: 0
  switchUserAccountSaveDataJournalSize: 0
  switchApplicationAttribute: 0
  switchCardSpecSize: -1
  switchCardSpecClock: -1
  switchRatingsMask: 0
  switchRatingsInt_0: 0
  switchRatingsInt_1: 0
  switchRatingsInt_2: 0
  switchRatingsInt_3: 0
  switchRatingsInt_4: 0
  switchRatingsInt_5: 0
  switchRatingsInt_6: 0
  switchRatingsInt_7: 0
  switchRatingsInt_8: 0
  switchRatingsInt_9: 0
  switchRatingsInt_10: 0
  switchRatingsInt_11: 0
  switchRatingsInt_12: 0
  switchLocalCommunicationIds_0: 
  switchLocalCommunicationIds_1: 
  switchLocalCommunicationIds_2: 
  switchLocalCommunicationIds_3: 
  switchLocalCommunicationIds_4: 
  switchLocalCommunicationIds_5: 
  switchLocalCommunicationIds_6: 
  switchLocalCommunicationIds_7: 
  switchParentalControl: 0
  switchAllowsScreenshot: 1
  switchAllowsVideoCapturing: 1
  switchAllowsRuntimeAddOnContentInstall: 0
  switchDataLossConfirmation: 0
  switchUserAccountLockEnabled: 0
  switchSystemResourceMemory: 16777216
  switchSupportedNpadStyles: 22
  switchNativeFsCacheSize: 32
  switchIsHoldTypeHorizontal: 1
  switchSupportedNpadCount: 8
  switchEnableTouchScreen: 1
  switchSocketConfigEnabled: 0
  switchTcpInitialSendBufferSize: 32
  switchTcpInitialReceiveBufferSize: 64
  switchTcpAutoSendBufferSizeMax: 256
  switchTcpAutoReceiveBufferSizeMax: 256
  switchUdpSendBufferSize: 9
  switchUdpReceiveBufferSize: 42
  switchSocketBufferEfficiency: 4
  switchSocketInitializeEnabled: 1
  switchNetworkInterfaceManagerInitializeEnabled: 1
  switchDisableHTCSPlayerConnection: 0
  switchUseNewStyleFilepaths: 1
  switchUseLegacyFmodPriorities: 0
  switchUseMicroSleepForYield: 1
  switchEnableRamDiskSupport: 0
  switchMicroSleepForYieldTime: 25
  switchRamDiskSpaceSize: 12
  ps4NPAgeRating: 12
  ps4NPTitleSecret: 
  ps4NPTrophyPackPath: 
  ps4ParentalLevel: 11
  ps4ContentID: ED1633-NPXX51362_00-0000000000000000
  ps4Category: 0
  ps4MasterVersion: 01.00
  ps4AppVersion: 01.00
  ps4AppType: 0
  ps4ParamSfxPath: 
  ps4VideoOutPixelFormat: 0
  ps4VideoOutInitialWidth: 1920
  ps4VideoOutBaseModeInitialWidth: 1920
  ps4VideoOutReprojectionRate: 60
  ps4PronunciationXMLPath: 
  ps4PronunciationSIGPath: 
  ps4BackgroundImagePath: 
  ps4StartupImagePath: 
  ps4StartupImagesFolder: 
  ps4IconImagesFolder: 
  ps4SaveDataImagePath: 
  ps4SdkOverride: 
  ps4BGMPath: 
  ps4ShareFilePath: 
  ps4ShareOverlayImagePath: 
  ps4PrivacyGuardImagePath: 
  ps4ExtraSceSysFile: 
  ps4NPtitleDatPath: 
  ps4RemotePlayKeyAssignment: -1
  ps4RemotePlayKeyMappingDir: 
  ps4PlayTogetherPlayerCount: 0
  ps4EnterButtonAssignment: 2
  ps4ApplicationParam1: 0
  ps4ApplicationParam2: 0
  ps4ApplicationParam3: 0
  ps4ApplicationParam4: 0
  ps4DownloadDataSize: 0
  ps4GarlicHeapSize: 2048
  ps4ProGarlicHeapSize: 2560
  playerPrefsMaxSize: 32768
  ps4Passcode: 4EwVk0C2KFbDdUaCA4zNf7lIpbttlF2n
  ps4pnSessions: 1
  ps4pnPresence: 1
  ps4pnFriends: 1
  ps4pnGameCustomData: 1
  playerPrefsSupport: 0
  enableApplicationExit: 0
  resetTempFolder: 1
  restrictedAudioUsageRights: 0
  ps4UseResolutionFallback: 0
  ps4ReprojectionSupport: 0
  ps4UseAudio3dBackend: 0
  ps4UseLowGarlicFragmentationMode: 1
  ps4SocialScreenEnabled: 0
  ps4ScriptOptimizationLevel: 2
  ps4Audio3dVirtualSpeakerCount: 14
  ps4attribCpuUsage: 0
  ps4PatchPkgPath: 
  ps4PatchLatestPkgPath: 
  ps4PatchChangeinfoPath: 
  ps4PatchDayOne: 0
  ps4attribUserManagement: 0
  ps4attribMoveSupport: 0
  ps4attrib3DSupport: 0
  ps4attribShareSupport: 0
  ps4attribExclusiveVR: 0
  ps4disableAutoHideSplash: 0
  ps4videoRecordingFeaturesUsed: 0
  ps4contentSearchFeaturesUsed: 0
  ps4CompatibilityPS5: 0
  ps4AllowPS5Detection: 0
  ps4GPU800MHz: 1
  ps4attribEyeToEyeDistanceSettingVR: 0
  ps4IncludedModules: []
  ps4attribVROutputEnabled: 0
  monoEnv: 
  splashScreenBackgroundSourceLandscape: {fileID: 0}
  splashScreenBackgroundSourcePortrait: {fileID: 0}
  blurSplashScreenBackground: 1
  spritePackerPolicy: 
  webGLMemorySize: 32
  webGLExceptionSupport: 1
  webGLNameFilesAsHashes: 0
  webGLShowDiagnostics: 0
  webGLDataCaching: 1
  webGLDebugSymbols: 0
  webGLEmscriptenArgs: 
  webGLModulesDirectory: 
  webGLTemplate: APPLICATION:Default
  webGLAnalyzeBuildSize: 0
  webGLUseEmbeddedResources: 0
  webGLCompressionFormat: 1
  webGLWasmArithmeticExceptions: 0
  webGLLinkerTarget: 1
  webGLThreadsSupport: 0
  webGLDecompressionFallback: 0
  webGLInitialMemorySize: 32
  webGLMaximumMemorySize: 2048
  webGLMemoryGrowthMode: 2
  webGLMemoryLinearGrowthStep: 16
  webGLMemoryGeometricGrowthStep: 0.2
  webGLMemoryGeometricGrowthCap: 96
  webGLPowerPreference: 2
  scriptingDefineSymbols: {}
  additionalCompilerArguments: {}
  platformArchitecture: {}
  scriptingBackend: {}
  il2cppCompilerConfiguration: {}
  il2cppCodeGeneration: {}
  managedStrippingLevel: {}
  incrementalIl2cppBuild: {}
  suppressCommonWarnings: 1
  allowUnsafeCode: 0
  useDeterministicCompilation: 1
  additionalIl2CppArgs: 
  scriptingRuntimeVersion: 1
  gcIncremental: 1
  gcWBarrierValidation: 0
  apiCompatibilityLevelPerPlatform: {}
  m_RenderingPath: 1
  m_MobileRenderingPath: 1
  metroPackageName: Prototype_Terror
  metroPackageVersion: 
  metroCertificatePath: 
  metroCertificatePassword: 
  metroCertificateSubject: 
  metroCertificateIssuer: 
  metroCertificateNotAfter: 0000000000000000
  metroApplicationDescription: Prototype_Terror
  wsaImages: {}
  metroTileShortName: 
  metroTileShowName: 0
  metroMediumTileShowName: 0
  metroLargeTileShowName: 0
  metroWideTileShowName: 0
  metroSupportStreamingInstall: 0
  metroLastRequiredScene: 0
  metroDefaultTileSize: 1
  metroTileForegroundText: 2
  metroTileBackgroundColor: {r: 0.13333334, g: 0.17254902, b: 0.21568628, a: 0}
  metroSplashScreenBackgroundColor: {r: 0.12941177, g: 0.17254902, b: 0.21568628, a: 1}
  metroSplashScreenUseBackgroundColor: 0
  syncCapabilities: 0
  platformCapabilities: {}
  metroTargetDeviceFamilies: {}
  metroFTAName: 
  metroFTAFileTypes: []
  metroProtocolName: 
  vcxProjDefaultLanguage: 
  XboxOneProductId: 
  XboxOneUpdateKey: 
  XboxOneSandboxId: 
  XboxOneContentId: 
  XboxOneTitleId: 
  XboxOneSCId: 
  XboxOneGameOsOverridePath: 
  XboxOnePackagingOverridePath: 
  XboxOneAppManifestOverridePath: 
  XboxOneVersion: 1.0.0.0
  XboxOnePackageEncryption: 0
  XboxOnePackageUpdateGranularity: 2
  XboxOneDescription: 
  XboxOneLanguage:
  - enus
  XboxOneCapability: []
  XboxOneGameRating: {}
  XboxOneIsContentPackage: 0
  XboxOneEnhancedXboxCompatibilityMode: 0
  XboxOneEnableGPUVariability: 1
  XboxOneSockets: {}
  XboxOneSplashScreen: {fileID: 0}
  XboxOneAllowedProductIds: []
  XboxOnePersistentLocalStorageSize: 0
  XboxOneXTitleMemory: 8
  XboxOneOverrideIdentityName: 
  XboxOneOverrideIdentityPublisher: 
  vrEditorSettings: {}
  cloudServicesEnabled: {}
  luminIcon:
    m_Name: 
    m_ModelFolderPath: 
    m_PortalFolderPath: 
  luminCert:
    m_CertPath: 
    m_SignPackage: 1
  luminIsChannelApp: 0
  luminVersion:
    m_VersionCode: 1
    m_VersionName: 
  hmiPlayerDataPath: 
  hmiForceSRGBBlit: 1
  embeddedLinuxEnableGamepadInput: 1
  hmiLogStartupTiming: 0
  hmiCpuConfiguration: 
  apiCompatibilityLevel: 6
  activeInputHandler: 1
  windowsGamepadBackendHint: 0
  cloudProjectId: 
  framebufferDepthMemorylessMode: 0
  qualitySettingsNames: []
  projectName: 
  organizationId: 
  cloudEnabled: 0
  legacyClampBlendShapeWeights: 0
  hmiLoadingImage: {fileID: 0}
  platformRequiresReadableAssets: 0
  virtualTexturingSupportEnabled: 0
  insecureHttpOption: 0

================
File: ProjectSettings/ProjectVersion.txt
================
m_EditorVersion: 2022.3.62f3
m_EditorVersionWithRevision: 2022.3.62f3 (96770f904ca7)

================
File: ProjectSettings/QualitySettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!47 &1
QualitySettings:
  m_ObjectHideFlags: 0
  serializedVersion: 5
  m_CurrentQuality: 5
  m_QualitySettings:
  - serializedVersion: 3
    name: Very Low
    pixelLightCount: 0
    shadows: 0
    shadowResolution: 0
    shadowProjection: 1
    shadowCascades: 1
    shadowDistance: 15
    shadowNearPlaneOffset: 3
    shadowCascade2Split: 0.33333334
    shadowCascade4Split: {x: 0.06666667, y: 0.2, z: 0.46666667}
    shadowmaskMode: 0
    skinWeights: 1
    globalTextureMipmapLimit: 1
    textureMipmapLimitSettings: []
    anisotropicTextures: 0
    antiAliasing: 0
    softParticles: 0
    softVegetation: 0
    realtimeReflectionProbes: 0
    billboardsFaceCameraPosition: 0
    useLegacyDetailDistribution: 0
    vSyncCount: 0
    realtimeGICPUUsage: 25
    lodBias: 0.3
    maximumLODLevel: 0
    enableLODCrossFade: 1
    streamingMipmapsActive: 0
    streamingMipmapsAddAllCameras: 1
    streamingMipmapsMemoryBudget: 512
    streamingMipmapsRenderersPerFrame: 512
    streamingMipmapsMaxLevelReduction: 2
    streamingMipmapsMaxFileIORequests: 1024
    particleRaycastBudget: 4
    asyncUploadTimeSlice: 2
    asyncUploadBufferSize: 16
    asyncUploadPersistentBuffer: 1
    resolutionScalingFixedDPIFactor: 1
    customRenderPipeline: {fileID: 0}
    terrainQualityOverrides: 0
    terrainPixelError: 1
    terrainDetailDensityScale: 1
    terrainBasemapDistance: 1000
    terrainDetailDistance: 80
    terrainTreeDistance: 5000
    terrainBillboardStart: 50
    terrainFadeLength: 5
    terrainMaxTrees: 50
    excludedTargetPlatforms: []
  - serializedVersion: 3
    name: Low
    pixelLightCount: 0
    shadows: 0
    shadowResolution: 0
    shadowProjection: 1
    shadowCascades: 1
    shadowDistance: 20
    shadowNearPlaneOffset: 3
    shadowCascade2Split: 0.33333334
    shadowCascade4Split: {x: 0.06666667, y: 0.2, z: 0.46666667}
    shadowmaskMode: 0
    skinWeights: 2
    globalTextureMipmapLimit: 0
    textureMipmapLimitSettings: []
    anisotropicTextures: 0
    antiAliasing: 0
    softParticles: 0
    softVegetation: 0
    realtimeReflectionProbes: 0
    billboardsFaceCameraPosition: 0
    useLegacyDetailDistribution: 0
    vSyncCount: 0
    realtimeGICPUUsage: 25
    lodBias: 0.4
    maximumLODLevel: 0
    enableLODCrossFade: 1
    streamingMipmapsActive: 0
    streamingMipmapsAddAllCameras: 1
    streamingMipmapsMemoryBudget: 512
    streamingMipmapsRenderersPerFrame: 512
    streamingMipmapsMaxLevelReduction: 2
    streamingMipmapsMaxFileIORequests: 1024
    particleRaycastBudget: 16
    asyncUploadTimeSlice: 2
    asyncUploadBufferSize: 16
    asyncUploadPersistentBuffer: 1
    resolutionScalingFixedDPIFactor: 1
    customRenderPipeline: {fileID: 0}
    terrainQualityOverrides: 0
    terrainPixelError: 1
    terrainDetailDensityScale: 1
    terrainBasemapDistance: 1000
    terrainDetailDistance: 80
    terrainTreeDistance: 5000
    terrainBillboardStart: 50
    terrainFadeLength: 5
    terrainMaxTrees: 50
    excludedTargetPlatforms: []
  - serializedVersion: 3
    name: Medium
    pixelLightCount: 1
    shadows: 1
    shadowResolution: 0
    shadowProjection: 1
    shadowCascades: 1
    shadowDistance: 20
    shadowNearPlaneOffset: 3
    shadowCascade2Split: 0.33333334
    shadowCascade4Split: {x: 0.06666667, y: 0.2, z: 0.46666667}
    shadowmaskMode: 0
    skinWeights: 2
    globalTextureMipmapLimit: 0
    textureMipmapLimitSettings: []
    anisotropicTextures: 1
    antiAliasing: 0
    softParticles: 0
    softVegetation: 0
    realtimeReflectionProbes: 0
    billboardsFaceCameraPosition: 0
    useLegacyDetailDistribution: 0
    vSyncCount: 1
    realtimeGICPUUsage: 25
    lodBias: 0.7
    maximumLODLevel: 0
    enableLODCrossFade: 1
    streamingMipmapsActive: 0
    streamingMipmapsAddAllCameras: 1
    streamingMipmapsMemoryBudget: 512
    streamingMipmapsRenderersPerFrame: 512
    streamingMipmapsMaxLevelReduction: 2
    streamingMipmapsMaxFileIORequests: 1024
    particleRaycastBudget: 64
    asyncUploadTimeSlice: 2
    asyncUploadBufferSize: 16
    asyncUploadPersistentBuffer: 1
    resolutionScalingFixedDPIFactor: 1
    customRenderPipeline: {fileID: 0}
    terrainQualityOverrides: 0
    terrainPixelError: 1
    terrainDetailDensityScale: 1
    terrainBasemapDistance: 1000
    terrainDetailDistance: 80
    terrainTreeDistance: 5000
    terrainBillboardStart: 50
    terrainFadeLength: 5
    terrainMaxTrees: 50
    excludedTargetPlatforms: []
  - serializedVersion: 3
    name: High
    pixelLightCount: 2
    shadows: 2
    shadowResolution: 1
    shadowProjection: 1
    shadowCascades: 2
    shadowDistance: 40
    shadowNearPlaneOffset: 3
    shadowCascade2Split: 0.33333334
    shadowCascade4Split: {x: 0.06666667, y: 0.2, z: 0.46666667}
    shadowmaskMode: 1
    skinWeights: 2
    globalTextureMipmapLimit: 0
    textureMipmapLimitSettings: []
    anisotropicTextures: 1
    antiAliasing: 0
    softParticles: 0
    softVegetation: 1
    realtimeReflectionProbes: 1
    billboardsFaceCameraPosition: 1
    useLegacyDetailDistribution: 0
    vSyncCount: 1
    realtimeGICPUUsage: 50
    lodBias: 1
    maximumLODLevel: 0
    enableLODCrossFade: 1
    streamingMipmapsActive: 0
    streamingMipmapsAddAllCameras: 1
    streamingMipmapsMemoryBudget: 512
    streamingMipmapsRenderersPerFrame: 512
    streamingMipmapsMaxLevelReduction: 2
    streamingMipmapsMaxFileIORequests: 1024
    particleRaycastBudget: 256
    asyncUploadTimeSlice: 2
    asyncUploadBufferSize: 16
    asyncUploadPersistentBuffer: 1
    resolutionScalingFixedDPIFactor: 1
    customRenderPipeline: {fileID: 0}
    terrainQualityOverrides: 0
    terrainPixelError: 1
    terrainDetailDensityScale: 1
    terrainBasemapDistance: 1000
    terrainDetailDistance: 80
    terrainTreeDistance: 5000
    terrainBillboardStart: 50
    terrainFadeLength: 5
    terrainMaxTrees: 50
    excludedTargetPlatforms: []
  - serializedVersion: 3
    name: Very High
    pixelLightCount: 3
    shadows: 2
    shadowResolution: 2
    shadowProjection: 1
    shadowCascades: 2
    shadowDistance: 70
    shadowNearPlaneOffset: 3
    shadowCascade2Split: 0.33333334
    shadowCascade4Split: {x: 0.06666667, y: 0.2, z: 0.46666667}
    shadowmaskMode: 1
    skinWeights: 4
    globalTextureMipmapLimit: 0
    textureMipmapLimitSettings: []
    anisotropicTextures: 2
    antiAliasing: 2
    softParticles: 1
    softVegetation: 1
    realtimeReflectionProbes: 1
    billboardsFaceCameraPosition: 1
    useLegacyDetailDistribution: 0
    vSyncCount: 1
    realtimeGICPUUsage: 50
    lodBias: 1.5
    maximumLODLevel: 0
    enableLODCrossFade: 1
    streamingMipmapsActive: 0
    streamingMipmapsAddAllCameras: 1
    streamingMipmapsMemoryBudget: 512
    streamingMipmapsRenderersPerFrame: 512
    streamingMipmapsMaxLevelReduction: 2
    streamingMipmapsMaxFileIORequests: 1024
    particleRaycastBudget: 1024
    asyncUploadTimeSlice: 2
    asyncUploadBufferSize: 16
    asyncUploadPersistentBuffer: 1
    resolutionScalingFixedDPIFactor: 1
    customRenderPipeline: {fileID: 0}
    terrainQualityOverrides: 0
    terrainPixelError: 1
    terrainDetailDensityScale: 1
    terrainBasemapDistance: 1000
    terrainDetailDistance: 80
    terrainTreeDistance: 5000
    terrainBillboardStart: 50
    terrainFadeLength: 5
    terrainMaxTrees: 50
    excludedTargetPlatforms: []
  - serializedVersion: 3
    name: Ultra
    pixelLightCount: 4
    shadows: 2
    shadowResolution: 2
    shadowProjection: 1
    shadowCascades: 4
    shadowDistance: 150
    shadowNearPlaneOffset: 3
    shadowCascade2Split: 0.33333334
    shadowCascade4Split: {x: 0.06666667, y: 0.2, z: 0.46666667}
    shadowmaskMode: 1
    skinWeights: 255
    globalTextureMipmapLimit: 0
    textureMipmapLimitSettings: []
    anisotropicTextures: 2
    antiAliasing: 2
    softParticles: 1
    softVegetation: 1
    realtimeReflectionProbes: 1
    billboardsFaceCameraPosition: 1
    useLegacyDetailDistribution: 0
    vSyncCount: 1
    realtimeGICPUUsage: 100
    lodBias: 2
    maximumLODLevel: 0
    enableLODCrossFade: 1
    streamingMipmapsActive: 0
    streamingMipmapsAddAllCameras: 1
    streamingMipmapsMemoryBudget: 512
    streamingMipmapsRenderersPerFrame: 512
    streamingMipmapsMaxLevelReduction: 2
    streamingMipmapsMaxFileIORequests: 1024
    particleRaycastBudget: 4096
    asyncUploadTimeSlice: 2
    asyncUploadBufferSize: 16
    asyncUploadPersistentBuffer: 1
    resolutionScalingFixedDPIFactor: 1
    customRenderPipeline: {fileID: 0}
    terrainQualityOverrides: 0
    terrainPixelError: 1
    terrainDetailDensityScale: 1
    terrainBasemapDistance: 1000
    terrainDetailDistance: 80
    terrainTreeDistance: 5000
    terrainBillboardStart: 50
    terrainFadeLength: 5
    terrainMaxTrees: 50
    excludedTargetPlatforms: []
  m_TextureMipmapLimitGroupNames: []
  m_PerPlatformDefaultQuality:
    Android: 2
    EmbeddedLinux: 5
    GameCoreScarlett: 5
    GameCoreXboxOne: 5
    LinuxHeadlessSimulation: 5
    Nintendo Switch: 5
    PS4: 5
    PS5: 5
    QNX: 5
    Server: 5
    Stadia: 5
    Standalone: 5
    VisionOS: 5
    WebGL: 3
    Windows Store Apps: 5
    XboxOne: 5
    iPhone: 2
    tvOS: 2

================
File: ProjectSettings/SceneTemplateSettings.json
================
{
    "templatePinStates": [],
    "dependencyTypeInfos": [
        {
            "userAdded": false,
            "type": "UnityEngine.AnimationClip",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEditor.Animations.AnimatorController",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.AnimatorOverrideController",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEditor.Audio.AudioMixerController",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.ComputeShader",
            "defaultInstantiationMode": 1
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Cubemap",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.GameObject",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEditor.LightingDataAsset",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.LightingSettings",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Material",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEditor.MonoScript",
            "defaultInstantiationMode": 1
        },
        {
            "userAdded": false,
            "type": "UnityEngine.PhysicMaterial",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.PhysicsMaterial2D",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Rendering.PostProcessing.PostProcessProfile",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Rendering.PostProcessing.PostProcessResources",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Rendering.VolumeProfile",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEditor.SceneAsset",
            "defaultInstantiationMode": 1
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Shader",
            "defaultInstantiationMode": 1
        },
        {
            "userAdded": false,
            "type": "UnityEngine.ShaderVariantCollection",
            "defaultInstantiationMode": 1
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Texture",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Texture2D",
            "defaultInstantiationMode": 0
        },
        {
            "userAdded": false,
            "type": "UnityEngine.Timeline.TimelineAsset",
            "defaultInstantiationMode": 0
        }
    ],
    "defaultDependencyTypeInfo": {
        "userAdded": false,
        "type": "<default_scene_template_dependencies>",
        "defaultInstantiationMode": 1
    },
    "newSceneOverride": 0
}

================
File: ProjectSettings/TagManager.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!78 &1
TagManager:
  serializedVersion: 2
  tags: []
  layers:
  - Default
  - TransparentFX
  - Ignore Raycast
  - 
  - Water
  - UI
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  - 
  m_SortingLayers:
  - name: Default
    uniqueID: 0
    locked: 0

================
File: ProjectSettings/TimeManager.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!5 &1
TimeManager:
  m_ObjectHideFlags: 0
  Fixed Timestep: 0.02
  Maximum Allowed Timestep: 0.33333334
  m_TimeScale: 1
  Maximum Particle Timestep: 0.03

================
File: ProjectSettings/UnityConnectSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!310 &1
UnityConnectSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 1
  m_Enabled: 0
  m_TestMode: 0
  m_EventOldUrl: https://api.uca.cloud.unity3d.com/v1/events
  m_EventUrl: https://cdp.cloud.unity3d.com/v1/events
  m_ConfigUrl: https://config.uca.cloud.unity3d.com
  m_DashboardUrl: https://dashboard.unity3d.com
  m_TestInitMode: 0
  CrashReportingSettings:
    m_EventUrl: https://perf-events.cloud.unity3d.com
    m_Enabled: 0
    m_LogBufferSize: 10
    m_CaptureEditorExceptions: 1
  UnityPurchasingSettings:
    m_Enabled: 0
    m_TestMode: 0
  UnityAnalyticsSettings:
    m_Enabled: 0
    m_TestMode: 0
    m_InitializeOnStartup: 1
    m_PackageRequiringCoreStatsPresent: 0
  UnityAdsSettings:
    m_Enabled: 0
    m_InitializeOnStartup: 1
    m_TestMode: 0
    m_IosGameId: 
    m_AndroidGameId: 
    m_GameIds: {}
    m_GameId: 
  PerformanceReportingSettings:
    m_Enabled: 0

================
File: ProjectSettings/VersionControlSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!890905787 &1
VersionControlSettings:
  m_ObjectHideFlags: 0
  m_Mode: Visible Meta Files
  m_CollabEditorSettings:
    inProgressEnabled: 1

================
File: ProjectSettings/VFXManager.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!937362698 &1
VFXManager:
  m_ObjectHideFlags: 0
  m_IndirectShader: {fileID: 0}
  m_CopyBufferShader: {fileID: 0}
  m_SortShader: {fileID: 0}
  m_StripUpdateShader: {fileID: 0}
  m_EmptyShader: {fileID: 0}
  m_RenderPipeSettingsPath: 
  m_FixedTimeStep: 0.016666668
  m_MaxDeltaTime: 0.05
  m_MaxScrubTime: 30
  m_CompiledVersion: 0
  m_RuntimeVersion: 0
  m_RuntimeResources: {fileID: 0}
  m_BatchEmptyLifetime: 300

================
File: UserSettings/Layouts/CurrentMaximizeLayout.dwlt
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &1
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12010, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 3}
  - {fileID: 12}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 30
    width: 1920
    height: 863
  m_MinSize: {x: 300, y: 100}
  m_MaxSize: {x: 24288, y: 16192}
  vertical: 0
  controlID: 43
  draggingID: 0
--- !u!114 &2
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12015, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Game
    m_Image: {fileID: -6423792434712278376, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 407
    y: 125
    width: 1103
    height: 491
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
  m_SerializedViewNames: []
  m_SerializedViewValues: []
  m_PlayModeViewName: GameView
  m_ShowGizmos: 0
  m_TargetDisplay: 0
  m_ClearColor: {r: 0, g: 0, b: 0, a: 0}
  m_TargetSize: {x: 836, y: 470}
  m_TextureFilterMode: 0
  m_TextureHideFlags: 61
  m_RenderIMGUI: 1
  m_EnterPlayModeBehavior: 0
  m_UseMipMap: 0
  m_VSyncEnabled: 0
  m_Gizmos: 0
  m_Stats: 0
  m_SelectedSizes: 01000000000000000000000000000000000000000000000000000000000000000000000000000000
  m_ZoomArea:
    m_HRangeLocked: 0
    m_VRangeLocked: 0
    hZoomLockedByDefault: 0
    vZoomLockedByDefault: 0
    m_HBaseRangeMin: -418
    m_HBaseRangeMax: 418
    m_VBaseRangeMin: -235
    m_VBaseRangeMax: 235
    m_HAllowExceedBaseRangeMin: 1
    m_HAllowExceedBaseRangeMax: 1
    m_VAllowExceedBaseRangeMin: 1
    m_VAllowExceedBaseRangeMax: 1
    m_ScaleWithWindow: 0
    m_HSlider: 0
    m_VSlider: 0
    m_IgnoreScrollWheelUntilClicked: 0
    m_EnableMouseInput: 0
    m_EnableSliderZoomHorizontal: 0
    m_EnableSliderZoomVertical: 0
    m_UniformScale: 1
    m_UpDirection: 1
    m_DrawArea:
      serializedVersion: 2
      x: 0
      y: 21
      width: 1103
      height: 470
    m_Scale: {x: 1, y: 1}
    m_Translation: {x: 551.5, y: 235}
    m_MarginLeft: 0
    m_MarginRight: 0
    m_MarginTop: 0
    m_MarginBottom: 0
    m_LastShownAreaInsideMargins:
      serializedVersion: 2
      x: -551.5
      y: -235
      width: 1103
      height: 470
    m_MinimalGUI: 1
  m_defaultScale: 1
  m_LastWindowPixelSize: {x: 1103, y: 491}
  m_ClearInEditMode: 1
  m_NoCameraWarning: 1
  m_LowResolutionForAspectRatios: 01000000000000000000
  m_XRRenderMode: 0
  m_RenderTexture: {fileID: 0}
  m_showToolbar: 1
--- !u!114 &3
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12010, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 4}
  - {fileID: 9}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1512
    height: 863
  m_MinSize: {x: 200, y: 100}
  m_MaxSize: {x: 16192, y: 16192}
  vertical: 1
  controlID: 44
  draggingID: 0
--- !u!114 &4
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12010, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 5}
  - {fileID: 7}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1512
    height: 512
  m_MinSize: {x: 200, y: 50}
  m_MaxSize: {x: 16192, y: 8096}
  vertical: 0
  controlID: 45
  draggingID: 0
--- !u!114 &5
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 407
    height: 512
  m_MinSize: {x: 201, y: 221}
  m_MaxSize: {x: 4001, y: 4021}
  m_ActualView: {fileID: 6}
  m_Panes:
  - {fileID: 6}
  m_Selected: 0
  m_LastSelected: 0
--- !u!114 &6
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12061, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Hierarchy
    m_Image: {fileID: 7966133145522015247, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 0
    y: 125
    width: 406
    height: 491
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
  m_SceneHierarchy:
    m_TreeViewState:
      scrollPos: {x: 0, y: 0}
      m_SelectedIDs: 
      m_LastClickedID: 0
      m_ExpandedIDs: 02fbffff144f0000
      m_RenameOverlay:
        m_UserAcceptedRename: 0
        m_Name: 
        m_OriginalName: 
        m_EditFieldRect:
          serializedVersion: 2
          x: 0
          y: 0
          width: 0
          height: 0
        m_UserData: 0
        m_IsWaitingForDelay: 0
        m_IsRenaming: 0
        m_OriginalEventType: 11
        m_IsRenamingFilename: 0
        m_ClientGUIView: {fileID: 0}
      m_SearchString: 
    m_ExpandedScenes: []
    m_CurrenRootInstanceID: 0
    m_LockTracker:
      m_IsLocked: 0
    m_CurrentSortingName: TransformSorting
  m_WindowGUID: 4c969a2b90040154d917609493e03593
--- !u!114 &7
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: GameView
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 407
    y: 0
    width: 1105
    height: 512
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_ActualView: {fileID: 2}
  m_Panes:
  - {fileID: 8}
  - {fileID: 2}
  m_Selected: 1
  m_LastSelected: 0
--- !u!114 &8
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12013, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Scene
    m_Image: {fileID: 2593428753322112591, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 407
    y: 125
    width: 1103
    height: 491
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData:
    - dockPosition: 0
      containerId: overlay-toolbar__top
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: -174, y: -26}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 3
      id: Tool Settings
      index: 0
      layout: 1
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 0
      containerId: overlay-toolbar__top
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: -141, y: 149}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 1
      id: unity-grid-and-snap-toolbar
      index: 1
      layout: 1
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-toolbar__top
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: unity-scene-view-toolbar
      index: 0
      layout: 1
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-toolbar__top
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 1
      id: unity-search-toolbar
      index: 1
      layout: 1
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 0
      containerId: overlay-container--left
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: unity-transform-toolbar
      index: 0
      layout: 2
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 0
      containerId: overlay-container--left
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 0, y: 197}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: unity-component-tools
      index: 1
      layout: 2
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 0
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 67.5, y: 86}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Orientation
      index: 0
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Light Settings
      index: 0
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Camera
      index: 1
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Cloth Constraints
      index: 1
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Cloth Collisions
      index: 2
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Navmesh Display
      index: 4
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Agent Display
      index: 5
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Obstacle Display
      index: 6
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Occlusion Culling
      index: 3
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Physics Debugger
      index: 4
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Scene Visibility
      index: 5
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Particles
      index: 6
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Tilemap
      index: 11
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Tilemap Palette Helper
      index: 12
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 48, y: 48}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/TrailRenderer
      index: 7
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 48, y: 48}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: UnityEditor.SceneViewCameraOverlay
      index: 9
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 48, y: 48}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: AINavigationOverlay
      index: 8
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    m_OverlaysVisible: 1
  m_WindowGUID: cc27987af1a868c49b0894db9c0f5429
  m_Gizmos: 1
  m_OverrideSceneCullingMask: 6917529027641081856
  m_SceneIsLit: 1
  m_SceneLighting: 1
  m_2DMode: 0
  m_isRotationLocked: 0
  m_PlayAudio: 0
  m_AudioPlay: 0
  m_Position:
    m_Target: {x: -0.79999995, y: 0.050000012, z: -42.2}
    speed: 2
    m_Value: {x: -0.79999995, y: 0.050000012, z: -42.2}
  m_RenderMode: 0
  m_CameraMode:
    drawMode: 0
    name: Shaded
    section: Shading Mode
  m_ValidateTrueMetals: 0
  m_DoValidateTrueMetals: 0
  m_SceneViewState:
    m_AlwaysRefresh: 0
    showFog: 1
    showSkybox: 1
    showFlares: 1
    showImageEffects: 1
    showParticleSystems: 1
    showVisualEffectGraphs: 1
    m_FxEnabled: 1
  m_Grid:
    xGrid:
      m_Fade:
        m_Target: 0
        speed: 2
        m_Value: 0
      m_Color: {r: 0.5, g: 0.5, b: 0.5, a: 0.4}
      m_Pivot: {x: 0, y: 0, z: 0}
      m_Size: {x: 1, y: 1}
    yGrid:
      m_Fade:
        m_Target: 1
        speed: 2
        m_Value: 1
      m_Color: {r: 0.5, g: 0.5, b: 0.5, a: 0.4}
      m_Pivot: {x: 0, y: 0, z: 0}
      m_Size: {x: 1, y: 1}
    zGrid:
      m_Fade:
        m_Target: 0
        speed: 2
        m_Value: 0
      m_Color: {r: 0.5, g: 0.5, b: 0.5, a: 0.4}
      m_Pivot: {x: 0, y: 0, z: 0}
      m_Size: {x: 1, y: 1}
    m_ShowGrid: 1
    m_GridAxis: 1
    m_gridOpacity: 0.5
  m_Rotation:
    m_Target: {x: 0.7071068, y: 0, z: 0, w: 0.7071068}
    speed: 2
    m_Value: {x: 0.7071068, y: 0, z: 0, w: 0.7071068}
  m_Size:
    m_Target: 105.827156
    speed: 2
    m_Value: 105.827156
  m_Ortho:
    m_Target: 1
    speed: 2
    m_Value: 1
  m_CameraSettings:
    m_Speed: 1
    m_SpeedNormalized: 0.5
    m_SpeedMin: 0.001
    m_SpeedMax: 2
    m_EasingEnabled: 1
    m_EasingDuration: 0.4
    m_AccelerationEnabled: 1
    m_FieldOfViewHorizontalOrVertical: 60
    m_NearClip: 0.03
    m_FarClip: 10000
    m_DynamicClip: 1
    m_OcclusionCulling: 0
  m_LastSceneViewRotation: {x: 0, y: 0, z: 0, w: 0}
  m_LastSceneViewOrtho: 0
  m_ReplacementShader: {fileID: 0}
  m_ReplacementString: 
  m_SceneVisActive: 1
  m_LastLockedObject: {fileID: 0}
  m_ViewIsLockedToObject: 0
--- !u!114 &9
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: ConsoleWindow
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 0
    y: 512
    width: 1512
    height: 351
  m_MinSize: {x: 100, y: 100}
  m_MaxSize: {x: 4000, y: 4000}
  m_ActualView: {fileID: 11}
  m_Panes:
  - {fileID: 10}
  - {fileID: 11}
  m_Selected: 1
  m_LastSelected: 0
--- !u!114 &10
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12014, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 230, y: 250}
  m_MaxSize: {x: 10000, y: 10000}
  m_TitleContent:
    m_Text: Project
    m_Image: {fileID: -5467254957812901981, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 6
    y: 631
    width: 1502
    height: 326
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
  m_SearchFilter:
    m_NameFilter: 
    m_ClassNames: []
    m_AssetLabels: []
    m_AssetBundleNames: []
    m_ReferencingInstanceIDs: 
    m_SceneHandles: 
    m_ShowAllHits: 0
    m_SkipHidden: 0
    m_SearchArea: 1
    m_Folders:
    - Assets
    m_Globs: []
    m_OriginalText: 
    m_ImportLogFlags: 0
    m_FilterByTypeIntersection: 0
  m_ViewMode: 1
  m_StartGridSize: 64
  m_LastFolders:
  - Assets
  m_LastFoldersGridSize: -1
  m_LastProjectPath: /mnt/IgniteDrive/Proyectos_Unity/Prototype_Terror
  m_LockTracker:
    m_IsLocked: 0
  m_FolderTreeState:
    scrollPos: {x: 0, y: 5}
    m_SelectedIDs: 724f0000
    m_LastClickedID: 20338
    m_ExpandedIDs: 00000000724f0000744f0000764f000000ca9a3bffffff7f
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 9}
    m_SearchString: 
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
  m_AssetTreeState:
    scrollPos: {x: 0, y: 0}
    m_SelectedIDs: 
    m_LastClickedID: 0
    m_ExpandedIDs: 00000000724f0000744f0000764f0000
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 0}
    m_SearchString: 
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
  m_ListAreaState:
    m_SelectedInstanceIDs: 
    m_LastClickedInstanceID: 0
    m_HadKeyboardFocusLastEvent: 0
    m_ExpandedInstanceIDs: c623000022450000
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 9}
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
    m_NewAssetIndexInList: -1
    m_ScrollPosition: {x: 0, y: 0}
    m_GridSize: 64
  m_SkipHiddenPackages: 0
  m_DirectoriesAreaWidth: 207
--- !u!114 &11
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12003, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 100, y: 100}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Console
    m_Image: {fileID: -4327648978806127646, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 0
    y: 637
    width: 1511
    height: 330
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
--- !u!114 &12
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 1512
    y: 0
    width: 408
    height: 863
  m_MinSize: {x: 275, y: 50}
  m_MaxSize: {x: 4000, y: 4000}
  m_ActualView: {fileID: 13}
  m_Panes:
  - {fileID: 13}
  m_Selected: 0
  m_LastSelected: 0
--- !u!114 &13
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12019, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 275, y: 50}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Inspector
    m_Image: {fileID: -2667387946076563598, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 1512
    y: 125
    width: 407
    height: 842
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
  m_ObjectsLockedBeforeSerialization: []
  m_InstanceIDsLockedBeforeSerialization: 
  m_PreviewResizer:
    m_CachedPref: 160
    m_ControlHash: -371814159
    m_PrefName: Preview_InspectorPreview
  m_LastInspectedObjectInstanceID: -1
  m_LastVerticalScrollValue: 0
  m_GlobalObjectId: 
  m_InspectorMode: 0
  m_LockTracker:
    m_IsLocked: 0
  m_PreviewWindow: {fileID: 0}

================
File: UserSettings/Layouts/default-2022.dwlt
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &1
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12004, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_PixelRect:
    serializedVersion: 2
    x: 6
    y: 74
    width: 1908
    height: 897
  m_ShowMode: 4
  m_Title: Hierarchy
  m_RootView: {fileID: 2}
  m_MinSize: {x: 875, y: 321}
  m_MaxSize: {x: 10000, y: 10000}
  m_Maximized: 0
--- !u!114 &2
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12008, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 3}
  - {fileID: 5}
  - {fileID: 4}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1908
    height: 897
  m_MinSize: {x: 875, y: 300}
  m_MaxSize: {x: 10000, y: 10000}
  m_UseTopView: 1
  m_TopViewHeight: 30
  m_UseBottomView: 1
  m_BottomViewHeight: 20
--- !u!114 &3
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12011, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1908
    height: 30
  m_MinSize: {x: 0, y: 0}
  m_MaxSize: {x: 0, y: 0}
  m_LastLoadedLayoutName: 
--- !u!114 &4
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12042, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 0
    y: 877
    width: 1908
    height: 20
  m_MinSize: {x: 0, y: 0}
  m_MaxSize: {x: 0, y: 0}
--- !u!114 &5
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12010, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 6}
  - {fileID: 11}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 30
    width: 1908
    height: 847
  m_MinSize: {x: 300, y: 100}
  m_MaxSize: {x: 24288, y: 16192}
  vertical: 0
  controlID: 105
  draggingID: 0
--- !u!114 &6
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12010, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 7}
  - {fileID: 10}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1503
    height: 847
  m_MinSize: {x: 200, y: 100}
  m_MaxSize: {x: 16192, y: 16192}
  vertical: 1
  controlID: 46
  draggingID: 0
--- !u!114 &7
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12010, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 8}
  - {fileID: 9}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1503
    height: 500
  m_MinSize: {x: 200, y: 50}
  m_MaxSize: {x: 16192, y: 8096}
  vertical: 0
  controlID: 47
  draggingID: 0
--- !u!114 &8
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 405
    height: 500
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_ActualView: {fileID: 13}
  m_Panes:
  - {fileID: 13}
  m_Selected: 0
  m_LastSelected: 0
--- !u!114 &9
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: SceneView
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 405
    y: 0
    width: 1098
    height: 500
  m_MinSize: {x: 202, y: 221}
  m_MaxSize: {x: 4002, y: 4021}
  m_ActualView: {fileID: 14}
  m_Panes:
  - {fileID: 14}
  - {fileID: 12}
  m_Selected: 0
  m_LastSelected: 1
--- !u!114 &10
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: ConsoleWindow
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 0
    y: 500
    width: 1503
    height: 347
  m_MinSize: {x: 101, y: 121}
  m_MaxSize: {x: 4001, y: 4021}
  m_ActualView: {fileID: 16}
  m_Panes:
  - {fileID: 15}
  - {fileID: 16}
  m_Selected: 1
  m_LastSelected: 0
--- !u!114 &11
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 1503
    y: 0
    width: 405
    height: 847
  m_MinSize: {x: 276, y: 71}
  m_MaxSize: {x: 4001, y: 4021}
  m_ActualView: {fileID: 17}
  m_Panes:
  - {fileID: 17}
  m_Selected: 0
  m_LastSelected: 0
--- !u!114 &12
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12015, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Game
    m_Image: {fileID: -6423792434712278376, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 411
    y: 131
    width: 1096
    height: 479
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
  m_SerializedViewNames: []
  m_SerializedViewValues: []
  m_PlayModeViewName: GameView
  m_ShowGizmos: 0
  m_TargetDisplay: 0
  m_ClearColor: {r: 0, g: 0, b: 0, a: 0}
  m_TargetSize: {x: 814, y: 458}
  m_TextureFilterMode: 0
  m_TextureHideFlags: 61
  m_RenderIMGUI: 1
  m_EnterPlayModeBehavior: 0
  m_UseMipMap: 0
  m_VSyncEnabled: 0
  m_Gizmos: 0
  m_Stats: 0
  m_SelectedSizes: 01000000000000000000000000000000000000000000000000000000000000000000000000000000
  m_ZoomArea:
    m_HRangeLocked: 0
    m_VRangeLocked: 0
    hZoomLockedByDefault: 0
    vZoomLockedByDefault: 0
    m_HBaseRangeMin: -407
    m_HBaseRangeMax: 407
    m_VBaseRangeMin: -229
    m_VBaseRangeMax: 229
    m_HAllowExceedBaseRangeMin: 1
    m_HAllowExceedBaseRangeMax: 1
    m_VAllowExceedBaseRangeMin: 1
    m_VAllowExceedBaseRangeMax: 1
    m_ScaleWithWindow: 0
    m_HSlider: 0
    m_VSlider: 0
    m_IgnoreScrollWheelUntilClicked: 0
    m_EnableMouseInput: 0
    m_EnableSliderZoomHorizontal: 0
    m_EnableSliderZoomVertical: 0
    m_UniformScale: 1
    m_UpDirection: 1
    m_DrawArea:
      serializedVersion: 2
      x: 0
      y: 21
      width: 1096
      height: 458
    m_Scale: {x: 1, y: 1}
    m_Translation: {x: 548, y: 229}
    m_MarginLeft: 0
    m_MarginRight: 0
    m_MarginTop: 0
    m_MarginBottom: 0
    m_LastShownAreaInsideMargins:
      serializedVersion: 2
      x: -548
      y: -229
      width: 1096
      height: 458
    m_MinimalGUI: 1
  m_defaultScale: 1
  m_LastWindowPixelSize: {x: 1096, y: 479}
  m_ClearInEditMode: 1
  m_NoCameraWarning: 1
  m_LowResolutionForAspectRatios: 01000000000000000000
  m_XRRenderMode: 0
  m_RenderTexture: {fileID: 0}
  m_showToolbar: 1
--- !u!114 &13
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12061, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Hierarchy
    m_Image: {fileID: 7966133145522015247, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 6
    y: 131
    width: 404
    height: 479
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
  m_SceneHierarchy:
    m_TreeViewState:
      scrollPos: {x: 0, y: 0}
      m_SelectedIDs: 124f0000
      m_LastClickedID: 20242
      m_ExpandedIDs: 0efbffff624e00006a4e0000c44e0000d84e0000e44e00000e4f0000124f0000
      m_RenameOverlay:
        m_UserAcceptedRename: 0
        m_Name: 
        m_OriginalName: 
        m_EditFieldRect:
          serializedVersion: 2
          x: 0
          y: 0
          width: 0
          height: 0
        m_UserData: 0
        m_IsWaitingForDelay: 0
        m_IsRenaming: 0
        m_OriginalEventType: 11
        m_IsRenamingFilename: 0
        m_ClientGUIView: {fileID: 0}
      m_SearchString: 
    m_ExpandedScenes: []
    m_CurrenRootInstanceID: 0
    m_LockTracker:
      m_IsLocked: 0
    m_CurrentSortingName: TransformSorting
  m_WindowGUID: 4c969a2b90040154d917609493e03593
--- !u!114 &14
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12013, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Scene
    m_Image: {fileID: 2593428753322112591, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 411
    y: 131
    width: 1096
    height: 479
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData:
    - dockPosition: 0
      containerId: overlay-toolbar__top
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: -174, y: -26}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 3
      id: Tool Settings
      index: 0
      layout: 1
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 0
      containerId: overlay-toolbar__top
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: -141, y: 149}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 1
      id: unity-grid-and-snap-toolbar
      index: 1
      layout: 1
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-toolbar__top
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: unity-scene-view-toolbar
      index: 0
      layout: 1
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-toolbar__top
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 1
      id: unity-search-toolbar
      index: 1
      layout: 1
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 0
      containerId: overlay-container--left
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: unity-transform-toolbar
      index: 0
      layout: 2
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 0
      containerId: overlay-container--left
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 0, y: 197}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: unity-component-tools
      index: 1
      layout: 2
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 0
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 67.5, y: 86}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Orientation
      index: 0
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Light Settings
      index: 0
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Camera
      index: 1
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Cloth Constraints
      index: 1
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Cloth Collisions
      index: 2
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Navmesh Display
      index: 4
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Agent Display
      index: 5
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Obstacle Display
      index: 6
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Occlusion Culling
      index: 3
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Physics Debugger
      index: 4
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Scene Visibility
      index: 5
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Particles
      index: 6
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Tilemap
      index: 11
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 0, y: 0}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/Tilemap Palette Helper
      index: 12
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 0
      snapOffset: {x: 48, y: 48}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: Scene View/TrailRenderer
      index: 7
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 48, y: 48}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: UnityEditor.SceneViewCameraOverlay
      index: 9
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    - dockPosition: 1
      containerId: overlay-container--right
      floating: 0
      collapsed: 0
      displayed: 1
      snapOffset: {x: 48, y: 48}
      snapOffsetDelta: {x: 0, y: 0}
      snapCorner: 0
      id: AINavigationOverlay
      index: 8
      layout: 4
      size: {x: 0, y: 0}
      sizeOverriden: 0
    m_OverlaysVisible: 1
  m_WindowGUID: cc27987af1a868c49b0894db9c0f5429
  m_Gizmos: 1
  m_OverrideSceneCullingMask: 6917529027641081856
  m_SceneIsLit: 1
  m_SceneLighting: 1
  m_2DMode: 0
  m_isRotationLocked: 0
  m_PlayAudio: 0
  m_AudioPlay: 0
  m_Position:
    m_Target: {x: -0.79999995, y: 0.050000012, z: -42.2}
    speed: 2
    m_Value: {x: -0.79999995, y: 0.050000012, z: -42.2}
  m_RenderMode: 0
  m_CameraMode:
    drawMode: 0
    name: Shaded
    section: Shading Mode
  m_ValidateTrueMetals: 0
  m_DoValidateTrueMetals: 0
  m_SceneViewState:
    m_AlwaysRefresh: 0
    showFog: 1
    showSkybox: 1
    showFlares: 1
    showImageEffects: 1
    showParticleSystems: 1
    showVisualEffectGraphs: 1
    m_FxEnabled: 1
  m_Grid:
    xGrid:
      m_Fade:
        m_Target: 0
        speed: 2
        m_Value: 0
      m_Color: {r: 0.5, g: 0.5, b: 0.5, a: 0.4}
      m_Pivot: {x: 0, y: 0, z: 0}
      m_Size: {x: 1, y: 1}
    yGrid:
      m_Fade:
        m_Target: 1
        speed: 2
        m_Value: 1
      m_Color: {r: 0.5, g: 0.5, b: 0.5, a: 0.4}
      m_Pivot: {x: 0, y: 0, z: 0}
      m_Size: {x: 1, y: 1}
    zGrid:
      m_Fade:
        m_Target: 0
        speed: 2
        m_Value: 0
      m_Color: {r: 0.5, g: 0.5, b: 0.5, a: 0.4}
      m_Pivot: {x: 0, y: 0, z: 0}
      m_Size: {x: 1, y: 1}
    m_ShowGrid: 1
    m_GridAxis: 1
    m_gridOpacity: 0.5
  m_Rotation:
    m_Target: {x: 0.22078489, y: 0.25767496, z: -0.060605027, w: 0.9387179}
    speed: 2
    m_Value: {x: 0.22078416, y: 0.2576741, z: -0.060604826, w: 0.93871474}
  m_Size:
    m_Target: 4.1487246
    speed: 2
    m_Value: 4.344214
  m_Ortho:
    m_Target: 1
    speed: 2
    m_Value: 1
  m_CameraSettings:
    m_Speed: 1
    m_SpeedNormalized: 0.5
    m_SpeedMin: 0.001
    m_SpeedMax: 2
    m_EasingEnabled: 1
    m_EasingDuration: 0.4
    m_AccelerationEnabled: 1
    m_FieldOfViewHorizontalOrVertical: 60
    m_NearClip: 0.03
    m_FarClip: 10000
    m_DynamicClip: 1
    m_OcclusionCulling: 0
  m_LastSceneViewRotation: {x: 0, y: 0, z: 0, w: 0}
  m_LastSceneViewOrtho: 0
  m_ReplacementShader: {fileID: 0}
  m_ReplacementString: 
  m_SceneVisActive: 1
  m_LastLockedObject: {fileID: 0}
  m_ViewIsLockedToObject: 0
--- !u!114 &15
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12014, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 230, y: 250}
  m_MaxSize: {x: 10000, y: 10000}
  m_TitleContent:
    m_Text: Project
    m_Image: {fileID: -5467254957812901981, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 6
    y: 631
    width: 1502
    height: 326
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
  m_SearchFilter:
    m_NameFilter: 
    m_ClassNames: []
    m_AssetLabels: []
    m_AssetBundleNames: []
    m_ReferencingInstanceIDs: 
    m_SceneHandles: 
    m_ShowAllHits: 0
    m_SkipHidden: 0
    m_SearchArea: 1
    m_Folders:
    - Assets/_Scripts
    m_Globs: []
    m_OriginalText: 
    m_ImportLogFlags: 0
    m_FilterByTypeIntersection: 0
  m_ViewMode: 1
  m_StartGridSize: 64
  m_LastFolders:
  - Assets/_Scripts
  m_LastFoldersGridSize: -1
  m_LastProjectPath: /mnt/IgniteDrive/Proyectos_Unity/Prototype_Terror
  m_LockTracker:
    m_IsLocked: 0
  m_FolderTreeState:
    scrollPos: {x: 0, y: 5}
    m_SelectedIDs: 7a4f0000
    m_LastClickedID: 20346
    m_ExpandedIDs: 00000000784f00007a4f00007c4f000000ca9a3bffffff7f
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 10}
    m_SearchString: 
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
  m_AssetTreeState:
    scrollPos: {x: 0, y: 0}
    m_SelectedIDs: 
    m_LastClickedID: 0
    m_ExpandedIDs: 00000000784f00007a4f00007c4f0000
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 0}
    m_SearchString: 
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
  m_ListAreaState:
    m_SelectedInstanceIDs: 7c4e0000
    m_LastClickedInstanceID: 20092
    m_HadKeyboardFocusLastEvent: 1
    m_ExpandedInstanceIDs: c623000022450000
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 10}
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
    m_NewAssetIndexInList: -1
    m_ScrollPosition: {x: 0, y: 0}
    m_GridSize: 64
  m_SkipHiddenPackages: 0
  m_DirectoriesAreaWidth: 207
--- !u!114 &16
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12003, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 100, y: 100}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Console
    m_Image: {fileID: -4327648978806127646, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 6
    y: 631
    width: 1502
    height: 326
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
--- !u!114 &17
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12019, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 275, y: 50}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Inspector
    m_Image: {fileID: -2667387946076563598, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 1509
    y: 131
    width: 404
    height: 826
  m_SerializedDataModeController:
    m_DataMode: 0
    m_PreferredDataMode: 0
    m_SupportedDataModes: 
    isAutomatic: 1
  m_ViewDataDictionary: {fileID: 0}
  m_OverlayCanvas:
    m_LastAppliedPresetName: Default
    m_SaveData: []
    m_OverlaysVisible: 1
  m_ObjectsLockedBeforeSerialization: []
  m_InstanceIDsLockedBeforeSerialization: 
  m_PreviewResizer:
    m_CachedPref: 160
    m_ControlHash: -371814159
    m_PrefName: Preview_InspectorPreview
  m_LastInspectedObjectInstanceID: -1
  m_LastVerticalScrollValue: 0
  m_GlobalObjectId: 
  m_InspectorMode: 0
  m_LockTracker:
    m_IsLocked: 0
  m_PreviewWindow: {fileID: 0}

================
File: UserSettings/EditorUserSettings.asset
================
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!162 &1
EditorUserSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 4
  m_ConfigSettings:
    RecentlyUsedSceneGuid-0:
      value: 010856075c065f5a0b080a7447250f49104f1c792e792565797c4863e3e4676c
      flags: 0
    vcSharedLogLevel:
      value: 0d5e400f0650
      flags: 0
  m_VCAutomaticAdd: 1
  m_VCDebugCom: 0
  m_VCDebugCmd: 0
  m_VCDebugOut: 0
  m_SemanticMergeMode: 2
  m_DesiredImportWorkerCount: 1
  m_StandbyImportWorkerCount: 1
  m_IdleImportWorkerShutdownDelay: 60000
  m_VCShowFailedCheckout: 1
  m_VCOverwriteFailedCheckoutAssets: 1
  m_VCProjectOverlayIcons: 1
  m_VCHierarchyOverlayIcons: 1
  m_VCOtherOverlayIcons: 1
  m_VCAllowAsyncUpdate: 1
  m_VCScanLocalPackagesOnConnect: 1
  m_ArtifactGarbageCollection: 1

================
File: UserSettings/Search.index
================
{
    "name": "Assets",
    "roots": ["Assets"],
    "includes": [],
    "excludes": ["Assets/Temp/", "Assets/External/"],
    "options": {
        "types": true,
        "properties": true,
        "extended": false,
        "dependencies": false
    },
    "baseScore": 999
}

================
File: UserSettings/Search.settings
================
trackSelection = true
refreshSearchWindowsInPlayMode = false
pickerAdvancedUI = false
fetchPreview = true
defaultFlags = 0
keepOpen = true
queryFolder = "Assets"
onBoardingDoNotAskAgain = true
showPackageIndexes = false
showStatusBar = false
scopes = {
}
providers = {
	asset = {
		active = true
		priority = 25
		defaultAction = null
	}
	scene = {
		active = true
		priority = 50
		defaultAction = null
	}
	adb = {
		active = false
		priority = 2500
		defaultAction = null
	}
	find = {
		active = true
		priority = 25
		defaultAction = null
	}
	packages = {
		active = false
		priority = 90
		defaultAction = null
	}
	store = {
		active = false
		priority = 100
		defaultAction = null
	}
	performance = {
		active = false
		priority = 100
		defaultAction = null
	}
	profilermarkers = {
		active = false
		priority = 100
		defaultAction = null
	}
	log = {
		active = false
		priority = 210
		defaultAction = null
	}
}
objectSelectors = {
}
recentSearches = [
]
searchItemFavorites = [
]
savedSearchesSortOrder = 0
showSavedSearchPanel = false
hideTabs = false
expandedQueries = [
]
queryBuilder = true
ignoredProperties = "id;name;classname;imagecontentshash"
helperWidgetCurrentArea = "all"
disabledIndexers = ""
minIndexVariations = 2
findProviderIndexHelper = true

================
File: .gitignore
================
# This .gitignore file should be placed at the root of your Unity project directory
#
# Get latest from https://github.com/github/gitignore/blob/master/Unity.gitignore
#
/[Ll]ibrary/
/[Tt]emp/
/[Oo]bj/
/[Bb]uild/
/[Bb]uilds/
/[Ll]ogs/
/[Mm]emoryCaptures/

# Never ignore Asset meta data
!/[Aa]ssets/**/*.meta

# Uncomment this line if you wish to ignore the asset store tools plugin
# /[Aa]ssets/AssetStoreTools*

# TextMesh Pro files
[Aa]ssets/TextMesh*Pro/

# Autogenerated Jetbrains Rider plugin
[Aa]ssets/Plugins/Editor/JetBrains*

# Visual Studio cache directory
.vs/

# Gradle cache directory
.gradle/

# Autogenerated VS/MD/Consulo solution and project files
ExportedObj/
.consulo/
*.csproj
*.unityproj
*.sln
*.suo
*.tmp
*.user
*.userprefs
*.pidb
*.booproj
*.svd
*.pdb
*.mdb
*.opendb
*.VC.db

# Unity3D generated meta files
*.pidb.meta
*.pdb.meta
*.mdb.meta

# Unity3D generated file on crash reports
sysinfo.txt

# Builds
*.apk
*.unitypackage

# Crashlytics generated file
crashlytics-build.properties

================
File: .repopackignore 
================
# Excluir carpetas pesadas o inútiles de Unity
Library/
Temp/
Obj/
Logs/
UserSettings/
MemoryCaptures/
Builds/
*.meta
*.unitypackage
*.asset
*.prefab

================
File: README.md
================
# Prototype_Terror
</file>

<file path="README.md">
# Prototype_Terror
</file>

<file path="repomix-output.md">
This file is a merged representation of a subset of the codebase, containing files not matching ignore patterns, combined into a single document by Repomix.

# File Summary

## Purpose
This file contains a packed representation of a subset of the repository's contents that is considered the most important context.
It is designed to be easily consumable by AI systems for analysis, code review,
or other automated processes.

## File Format
The content is organized as follows:
1. This summary section
2. Repository information
3. Directory structure
4. Repository files (if enabled)
5. Multiple file entries, each consisting of:
  a. A header with the file path (## File: path/to/file)
  b. The full contents of the file in a code block

## Usage Guidelines
- This file should be treated as read-only. Any changes should be made to the
  original repository files, not this packed version.
- When processing this file, use the file path to distinguish
  between different files in the repository.
- Be aware that this file may contain sensitive information. Handle it with
  the same level of security as you would the original repository.

## Notes
- Some files may have been excluded based on .gitignore rules and Repomix's configuration
- Binary files are not included in this packed representation. Please refer to the Repository Structure section for a complete list of file paths, including binary files
- Files matching these patterns are excluded: repomix-output.*, Documentacion_Tecnica_Proyecto.md
- Files matching patterns in .gitignore are excluded
- Files matching default ignore patterns are excluded
- Files are sorted by Git change count (files with more changes are at the bottom)

# Directory Structure
```
Assets/
  _Scripts/
    Brains/
      EnemyBrain.cs
    Enums/
      GameEnums.cs
    Interfaces/
      IEstado.cs
    Player/
      PlayerController.cs
      PlayerFear.cs
      PlayerNoise.cs
    States/
      EstadoRastreo.cs
    Systems/
      IntuicionSystem.cs
    UI/
      UI_BarraMiedo.cs
      UI_MenuManager.cs
  Alebardium/
    Bloodlines UI/
      Fonts/
        ManufacturingConsent/
          ManufacturingConsent-Regular.ttf
          OFL.txt
        MedievalSharp/
          MedievalSharp-Regular.ttf
          OFL.txt
      Textures/
        Button/
          Button1/
            Status_Disable.png
            Status_Grey_Default.png
            Status_Grey_Hover.png
            Status_Pressed.png
            Status_Red_Default.png
            Status_Red_Hover.png
          Button2/
            Button2_Status_Disable.png
            Button2_Status_Grey_Default.png
            Button2_Status_Grey_Hover.png
            Button2_Status_Pressed.png
            Button2_Status_Red_Default.png
            Button2_Status_Red_Hover.png
          Button3/
            Button3_Status_Disable.png
            Button3_Status_Grey_Default.png
            Button3_Status_Grey_Hover.png
            Button3_Status_Pressed.png
            Button3_Status_Red_Default.png
            Button3_Status_Red_Hover.png
        Frame/
          Frame_background.png
          Frame_main_menu_red.png
          Frame_main_menu.png
          Frame_outline_red.png
          Frame_outline_v2.png
          Frame_outline.png
        Icon/
          Icons_19.png
          Icons_20.png
          Icons_settins_frame.png
          Icons-1.png
          Icons-16.png
          Icons-17.png
          Icons-18.png
          Icons-2.png
          Icons-3.png
          Icons-4.png
          Icons-5.png
          Icons.png
        Input Field/
          Cross.png
          Frame_input_red.png
          Frame_input.png
        Layout/
          CHECKBOX.png
          Colors.png
          HEALTH.png
          MENU.png
          ON_OFF.png
          PROGRESS_BAR.png
          SETTINGS.png
          TOGGLE_SWITCH.png
        Notice/
          Frame_notice_v1.png
          Frame_notice_v2.png
        Progress_Bar/
          Rectangle/
            Progress_Bar_Rectangle_empty_v1.png
            Progress_Bar_Rectangle_empty_v2.png
            Progress_Bar_Rectangle_empty_v3.png
            Progress_Bar_Rectangle_empty_v4.png
            Progress_Bar_Rectangle_empty_v5.png
            Progress_Bar_Rectangle_full_v1.png
            Progress_Bar_Rectangle_full_v2.png
            Progress_Bar_Rectangle_full_v3.png
            Progress_Bar_Rectangle_full_v4.png
            Progress_Bar_Rectangle_full_v5.png
          Rectangle (Segments)/
            Health_diamond_empty_v1.png
            Health_diamond_empty_v2.png
            Health_diamond_full_v1.png
            Health_diamond_full_v2.png
            Health_rod_empty_v1.png
            Health_rod_full.png
            Slider_5pct_v1.png
            Slider_empty.png
            Slider_full_v1.png
            Slider_toggler.png
          Round/
            Progress_Bar_Round_empty_v1_v4.png
            Progress_Bar_Round_empty_v2_v3.png
            Progress_Bar_Round_full_v1.png
            Progress_Bar_Round_full_v2.png
            Progress_Bar_Round_full_v3.png
            Progress_Bar_Round_full_v4.png
        Toggle/
          Icon Checkmark 1 (Rect).png
          Icon Checkmark 1 (Round).png
          Icon Checkmark 2 (Rect).png
          Icon Checkmark 2 (Round).png
          Icon Checkmark 3 (Rect).png
          Icon Checkmark 3 (Round).png
          Icons-10.png
          Icons-11.png
          Icons-12.png
          Icons-13.png
          Icons-14.png
          Icons-15.png
          Icons-6.png
          Icons-7.png
          Icons-8.png
          Icons-9.png
  Art/
    Material/
      New Material.mat
  Input/
    PlayerControls.cs
    PlayerControls.inputactions
  Scenes/
    Catacumbas.unity
    Escena_Inicio.unity
  Sounds/
    Player/
      caminata.wav
      grito.wav
      susurro.wav
  UI Toolkit/
    UnityThemes/
      UnityDefaultRuntimeTheme.tss
  UI_Inicio/
    MenuInicio.uss
    MenuInicio.uxml
    MenuInicioController.cs
  .cursorrules
.gitignore
.repomixignore
README.md
```

# Files

## File: Assets/_Scripts/Player/PlayerFear.cs
```csharp
// -----------------------------------------------------------------------------
//  PlayerFear.cs
//  Se suscribe a la "radio" del IntuicionSystem y ajusta el movimiento del
//  jugador basándose en los niveles de miedo del enemigo.
//  Este script DEBE estar adjunto al mismo GameObject que tiene el PlayerController 
//  (por ejemplo, la cápsula del jugador).
// -----------------------------------------------------------------------------
using UnityEngine;

namespace _Scripts.Player
{
    // Garantiza de forma segura que el GameObject tenga un PlayerController.
    // Si no existe, Unity lo añadirá automáticamente para evitar errores de referencia nula en tiempo de ejecución.
    [RequireComponent(typeof(PlayerController))]
    public class PlayerFear : MonoBehaviour
    {
        [Header("Intuicion System (Data Asset)")]
        [Tooltip("Asigna aquí el ScriptableObject de IntuicionSystem que utiliza el EnemyBrain.")]
        [SerializeField] private _Scripts.Systems.IntuicionSystem intuicionSystem;

        // Referencia interna al controlador de movimiento del jugador.
        private PlayerController playerController;
        
        // Nivel de miedo actual del jugador. Rango: 0 (calma total) hasta 4 (terror absoluto).
        private int fearLevel = 0; 
        
        // Límite máximo del nivel de miedo. Corresponde a un factor de 0.8 (80% de penalización de velocidad).
        private const int MaxFearLevel = 4; 

        /// <summary>
        /// Awake se ejecuta al cargar la instancia del script, antes de que empiece el juego.
        /// Ideal para inicializar y capturar componentes internos de forma optimizada sin usar GameObject.Find.
        /// </summary>
        private void Awake()
        {
            // Cacheamos el componente PlayerController que está en este mismo objeto.
            playerController = GetComponent<PlayerController>();
        }

        /// <summary>
        /// Se activa automáticamente cada vez que el objeto se habilita en la escena.
        /// Aquí nos "sintonizamos" a la radio del sistema de intuición (Eventos).
        /// </summary>
        private void OnEnable()
        {
            // Verificación de seguridad por si olvidaste arrastrar el ScriptableObject en el Inspector.
            if (intuicionSystem != null)
            {
                // Nos suscribimos a los eventos. Cuando la IA suba o baje de fase,
                // este script se enterará inmediatamente de forma asíncrona.
                intuicionSystem.OnSubirFase += HandleSubirFase;
                intuicionSystem.OnBajarFase += HandleBajarFase;
            }
        }

        /// <summary>
        /// Se activa automáticamente cuando el objeto se deshabilita o se destruye.
        /// CRUCIAL: Siempre hay que desvincular los eventos para evitar fugas de memoria (Memory Leaks).
        /// </summary>
        private void OnDisable()
        {
            if (intuicionSystem != null)
            {
                // Nos desuscribimos de los eventos para limpiar las referencias en memoria.
                intuicionSystem.OnSubirFase -= HandleSubirFase;
                intuicionSystem.OnBajarFase -= HandleBajarFase;
            }
        }

        /// <summary>
        /// Método manejador que se ejecuta automáticamente cuando el sistema avisa que el enemigo subió de fase.
        /// </summary>
        private void HandleSubirFase()
        {
            // Incrementamos el miedo en 1, pero usamos Mathf.Clamp para asegurar 
            // que matemáticamente nunca supere el MaxFearLevel (4) ni baje de 0.
            fearLevel = Mathf.Clamp(fearLevel + 1, 0, MaxFearLevel);
            
            // Recalculamos y aplicamos el peso del terror al jugador.
            ApplyFearPenalty();
        }

        /// <summary>
        /// Método manejador que se ejecuta automáticamente cuando el sistema avisa que el enemigo bajó de fase (se enfrió).
        /// </summary>
        private void HandleBajarFase()
        {
            // Decrementamos el miedo en 1, manteniendo el valor protegido entre 0 y 4.
            fearLevel = Mathf.Clamp(fearLevel - 1, 0, MaxFearLevel);
            
            // Recalculamos y aplicamos el peso del terror al jugador.
            ApplyFearPenalty();
        }

        /// <summary>
        /// Traduce el nivel de miedo entero (0 a 4) en un porcentaje decimal de penalización física 
        /// y se lo inyecta al PlayerController.
        /// </summary>
        private void ApplyFearPenalty()
        {
            // Control de daños: Si por alguna razón el script se rompió o no tiene el controlador, cancela la ejecución.
            if (playerController == null) return;
            
            // EXPLICACIÓN MATEMÁTICA DEL FACTOR:
            // 1. (float)fearLevel de la línea inferior convierte el entero a float para permitir divisiones decimales exactas.
            // 2. Se divide entre MaxFearLevel (4) para obtener un porcentaje normalizado de 0.0 a 1.0.
            // 3. Se multiplica por 0.8f para escalar ese porcentaje a un rango final de 0.0 a 0.8.
            // Ejemplos de resultado según la fase:
            // - Miedo 0: (0 / 4) * 0.8 = 0.0  -> 0% de reducción (Velocidad normal).
            // - Miedo 1: (1 / 4) * 0.8 = 0.2  -> 20% de reducción.
            // - Miedo 2: (2 / 4) * 0.8 = 0.4  -> 40% de reducción.
            // - Miedo 3: (3 / 4) * 0.8 = 0.6  -> 60% de reducción.
            // - Miedo 4: (4 / 4) * 0.8 = 0.8  -> 80% de reducción (El jugador apenas puede arrastrarse del susto).
            float factor = (float)fearLevel / MaxFearLevel * 0.8f;
            
            // Le enviamos este factor limpio al PlayerController para que reste velocidad o altere el movimiento.
            playerController.AplicarPenalizacionMiedo(factor);
        }
    }
}
```

## File: Assets/_Scripts/Player/PlayerNoise.cs
```csharp
using UnityEngine;
using _Scripts.Systems; // Para ver el IntuicionSystem
using _Scripts.Enums;   // Para ver el PerfilAcustico

namespace _Scripts.Player
{
    /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
     * CLASE: PlayerNoise (El Generador de Pulsos)
     * Se encarga de medir el tiempo entre pasos, reproducir el audio 
     * local para asustar al jugador humano, y enviar el "Paquete de Datos"
     * matemático al cerebro del enemigo.
     * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
    public class PlayerNoise : MonoBehaviour
    {
        [Header("Comunicaciones (Los Cables)")]
        [Tooltip("El 'buzón' central donde dejaremos el paquete de ruido")]
        /*Oye, en este espacio solo se pueden guardar cosas que tengan la estructura de IntuicionSystem
         dataIntuicion es solo un puntero inalambrico*/
        [SerializeField] private IntuicionSystem dataIntuicion; 
        
        [Tooltip("El cuerpo del enemigo para poder calcular a cuántos metros estamos")]
        [SerializeField] private Transform transformEnemigo;

        [Header("Configuración de Audio Físico")]
        [Tooltip("El parlante que reproducirá los .wav en los pies/boca del jugador")]
        [SerializeField] private AudioSource emisorDeSonido;
        
        [Tooltip("Audios para cuando el jugador va lento/agachado")]
        [SerializeField] private AudioClip audioSusurro; 
        
        [Tooltip("Audios para cuando el jugador camina normal")]
        [SerializeField] private AudioClip audioPasoNormal;
        
        [Tooltip("Audios para cuando el jugador corre asustado")]
        [SerializeField] private AudioClip audioGritoSusto;

        // --- EL ETIQUETADOR DE ESTADOS ---
        // Este enum local nos dice qué está haciendo el jugador AHORA MISMO.
        // Más adelante, el script de movimiento cambiará esta variable automáticamente.
        public enum EstadoMovimiento { Quieto, Agachado, Caminando, Corriendo }
        
        [Header("Estado Actual (Pruebas)")]
        [Tooltip("Cambia esto en Unity mientras juegas para probar los distintos ruidos")]
        public EstadoMovimiento estadoActual = EstadoMovimiento.Quieto;

        // El segundero que cuenta el tiempo entre un paso y otro
        private float _cronometroPulso = 0f;

        private void Start()
        {
            // Cláusulas de salvaguarda: Avisamos si olvidaste conectar algo en el Inspector
            if (!dataIntuicion) Debug.LogError("PlayerNoise: Falta conectar el IntuicionSystem.");
            if (!transformEnemigo) Debug.LogError("PlayerNoise: Falta el Transform del Enemigo.");
            if (!emisorDeSonido) Debug.LogError("PlayerNoise: Falta el AudioSource.");
        }

        private void Update()
        {
            // Si falta el buzón de datos, no hacemos nada, para, evitar que el juego explote
            if (!dataIntuicion || !transformEnemigo) return;

            // 1. EL RELOJ: Definimos qué tan rápido late el pulso según el estado
            float tiempoEntrePulsos = 0f;

            switch (estadoActual)
            {
                case EstadoMovimiento.Quieto: 
                    _cronometroPulso = 0f; // Reseteamos el reloj
                    return; // Salimos del Update, no hay ruido que hacer
                
                case EstadoMovimiento.Agachado: 
                    tiempoEntrePulsos = 1.2f; // Un pulso lento (mucho espacio entre pasos)
                    break;
                
                case EstadoMovimiento.Caminando: 
                    tiempoEntrePulsos = 0.7f; // Un pulso normal
                    break;
                
                case EstadoMovimiento.Corriendo: 
                    tiempoEntrePulsos = 0.3f; // Un pulso rapidísimo (pasos acelerados)
                    break;
            }

            // 2. EL SEGUNDERO AVANZA
            _cronometroPulso += Time.deltaTime;

            // 3. EL DISPARO
            if (_cronometroPulso >= tiempoEntrePulsos)
            {
                EmitirRuidoDelPulso();
                _cronometroPulso = 0f; // Vaciamos el reloj para empezar a contar el siguiente paso
            }
        }

        /* * *
         * MÉTODO: EmitirRuidoDelPulso
         * Se ejecuta solo en el frame exacto en el que el pie toca el suelo.
         * Prepara el paquete, reproduce el .wav y lo envía por correo.
         */
        // ReSharper disable Unity.PerformanceAnalysis
        private void EmitirRuidoDelPulso()
        {
            // A. Calculamos la distancia real en metros usando trigonometría de Unity
            float distanciaAlEnemigo = Vector3.Distance(transform.position, transformEnemigo.position);

            // B. Preparamos las variables que meteremos en el paquete
            float volumenPaquete = 0f;
            PerfilAcustico perfilPaquete = PerfilAcustico.GraveFisico; // Por defecto
            AudioClip clipFalsoParaHumano = null;

            // C. Rellenamos el paquete según el estado
            switch (estadoActual)
            {
                case EstadoMovimiento.Agachado:
                    volumenPaquete = 0.1f; // Muy bajito
                    perfilPaquete = PerfilAcustico.AgudoVocal; // Un susurro que se apaga rápido en la distancia
                    clipFalsoParaHumano = audioSusurro;
                    break;

                case EstadoMovimiento.Caminando:
                    volumenPaquete = 0.3f; // Medio
                    perfilPaquete = PerfilAcustico.GraveFisico; // Un paso que hace vibrar el suelo
                    clipFalsoParaHumano = audioPasoNormal;
                    break;

                case EstadoMovimiento.Corriendo:
                    volumenPaquete = 0.8f; // Escandaloso
                    perfilPaquete = PerfilAcustico.AgudoVocal; // Un grito/jadeo de pánico
                    clipFalsoParaHumano = audioGritoSusto;
                    break;
            }

            // D. LA MAGIA: Actualizamos la posición sospechosa...
            dataIntuicion.posicionSospechosa = transform.position;
            
            // ... Y enviamos el paquete matemático al IntuicionSystem
            // ¡Fíjate cómo usamos el Enum aquí como una etiqueta de envío!
            dataIntuicion.ModificarIntuicion(volumenPaquete, distanciaAlEnemigo, perfilPaquete);

            // E. EL TEATRO: Reproducimos el archivo .wav real para asustar al jugador
            if (emisorDeSonido && clipFalsoParaHumano)
            {
                emisorDeSonido.PlayOneShot(clipFalsoParaHumano);
            }
            
            // Un log para que tú como desarrollador veas que el pulso salió bien
            Debug.Log($"<color=yellow>PULSO: {estadoActual} | Vol: {volumenPaquete} | Perfil: {perfilPaquete} | Dist: {distanciaAlEnemigo:F1}m</color>");
        }
    }
}
```

## File: Assets/_Scripts/UI/UI_BarraMiedo.cs
```csharp
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
```

## File: Assets/Alebardium/Bloodlines UI/Fonts/ManufacturingConsent/OFL.txt
```
Copyright 2019 The Manufacturing Consent Project Authors (https://github.com/googlefonts/manufacturing-consent-font)

This Font Software is licensed under the SIL Open Font License, Version 1.1.
This license is copied below, and is also available with a FAQ at:
https://openfontlicense.org


-----------------------------------------------------------
SIL OPEN FONT LICENSE Version 1.1 - 26 February 2007
-----------------------------------------------------------

PREAMBLE
The goals of the Open Font License (OFL) are to stimulate worldwide
development of collaborative font projects, to support the font creation
efforts of academic and linguistic communities, and to provide a free and
open framework in which fonts may be shared and improved in partnership
with others.

The OFL allows the licensed fonts to be used, studied, modified and
redistributed freely as long as they are not sold by themselves. The
fonts, including any derivative works, can be bundled, embedded, 
redistributed and/or sold with any software provided that any reserved
names are not used by derivative works. The fonts and derivatives,
however, cannot be released under any other type of license. The
requirement for fonts to remain under this license does not apply
to any document created using the fonts or their derivatives.

DEFINITIONS
"Font Software" refers to the set of files released by the Copyright
Holder(s) under this license and clearly marked as such. This may
include source files, build scripts and documentation.

"Reserved Font Name" refers to any names specified as such after the
copyright statement(s).

"Original Version" refers to the collection of Font Software components as
distributed by the Copyright Holder(s).

"Modified Version" refers to any derivative made by adding to, deleting,
or substituting -- in part or in whole -- any of the components of the
Original Version, by changing formats or by porting the Font Software to a
new environment.

"Author" refers to any designer, engineer, programmer, technical
writer or other person who contributed to the Font Software.

PERMISSION & CONDITIONS
Permission is hereby granted, free of charge, to any person obtaining
a copy of the Font Software, to use, study, copy, merge, embed, modify,
redistribute, and sell modified and unmodified copies of the Font
Software, subject to the following conditions:

1) Neither the Font Software nor any of its individual components,
in Original or Modified Versions, may be sold by itself.

2) Original or Modified Versions of the Font Software may be bundled,
redistributed and/or sold with any software, provided that each copy
contains the above copyright notice and this license. These can be
included either as stand-alone text files, human-readable headers or
in the appropriate machine-readable metadata fields within text or
binary files as long as those fields can be easily viewed by the user.

3) No Modified Version of the Font Software may use the Reserved Font
Name(s) unless explicit written permission is granted by the corresponding
Copyright Holder. This restriction only applies to the primary font name as
presented to the users.

4) The name(s) of the Copyright Holder(s) or the Author(s) of the Font
Software shall not be used to promote, endorse or advertise any
Modified Version, except to acknowledge the contribution(s) of the
Copyright Holder(s) and the Author(s) or with their explicit written
permission.

5) The Font Software, modified or unmodified, in part or in whole,
must be distributed entirely under this license, and must not be
distributed under any other license. The requirement for fonts to
remain under this license does not apply to any document created
using the Font Software.

TERMINATION
This license becomes null and void if any of the above conditions are
not met.

DISCLAIMER
THE FONT SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO ANY WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT
OF COPYRIGHT, PATENT, TRADEMARK, OR OTHER RIGHT. IN NO EVENT SHALL THE
COPYRIGHT HOLDER BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
INCLUDING ANY GENERAL, SPECIAL, INDIRECT, INCIDENTAL, OR CONSEQUENTIAL
DAMAGES, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF THE USE OR INABILITY TO USE THE FONT SOFTWARE OR FROM
OTHER DEALINGS IN THE FONT SOFTWARE.
```

## File: Assets/Alebardium/Bloodlines UI/Fonts/MedievalSharp/OFL.txt
```
Copyright (c) 2011, wmk69 (wmk69@o2.pl),
with Reserved Font Name MedievalSharp.

This Font Software is licensed under the SIL Open Font License, Version 1.1.
This license is copied below, and is also available with a FAQ at:
https://openfontlicense.org


-----------------------------------------------------------
SIL OPEN FONT LICENSE Version 1.1 - 26 February 2007
-----------------------------------------------------------

PREAMBLE
The goals of the Open Font License (OFL) are to stimulate worldwide
development of collaborative font projects, to support the font creation
efforts of academic and linguistic communities, and to provide a free and
open framework in which fonts may be shared and improved in partnership
with others.

The OFL allows the licensed fonts to be used, studied, modified and
redistributed freely as long as they are not sold by themselves. The
fonts, including any derivative works, can be bundled, embedded, 
redistributed and/or sold with any software provided that any reserved
names are not used by derivative works. The fonts and derivatives,
however, cannot be released under any other type of license. The
requirement for fonts to remain under this license does not apply
to any document created using the fonts or their derivatives.

DEFINITIONS
"Font Software" refers to the set of files released by the Copyright
Holder(s) under this license and clearly marked as such. This may
include source files, build scripts and documentation.

"Reserved Font Name" refers to any names specified as such after the
copyright statement(s).

"Original Version" refers to the collection of Font Software components as
distributed by the Copyright Holder(s).

"Modified Version" refers to any derivative made by adding to, deleting,
or substituting -- in part or in whole -- any of the components of the
Original Version, by changing formats or by porting the Font Software to a
new environment.

"Author" refers to any designer, engineer, programmer, technical
writer or other person who contributed to the Font Software.

PERMISSION & CONDITIONS
Permission is hereby granted, free of charge, to any person obtaining
a copy of the Font Software, to use, study, copy, merge, embed, modify,
redistribute, and sell modified and unmodified copies of the Font
Software, subject to the following conditions:

1) Neither the Font Software nor any of its individual components,
in Original or Modified Versions, may be sold by itself.

2) Original or Modified Versions of the Font Software may be bundled,
redistributed and/or sold with any software, provided that each copy
contains the above copyright notice and this license. These can be
included either as stand-alone text files, human-readable headers or
in the appropriate machine-readable metadata fields within text or
binary files as long as those fields can be easily viewed by the user.

3) No Modified Version of the Font Software may use the Reserved Font
Name(s) unless explicit written permission is granted by the corresponding
Copyright Holder. This restriction only applies to the primary font name as
presented to the users.

4) The name(s) of the Copyright Holder(s) or the Author(s) of the Font
Software shall not be used to promote, endorse or advertise any
Modified Version, except to acknowledge the contribution(s) of the
Copyright Holder(s) and the Author(s) or with their explicit written
permission.

5) The Font Software, modified or unmodified, in part or in whole,
must be distributed entirely under this license, and must not be
distributed under any other license. The requirement for fonts to
remain under this license does not apply to any document created
using the Font Software.

TERMINATION
This license becomes null and void if any of the above conditions are
not met.

DISCLAIMER
THE FONT SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO ANY WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT
OF COPYRIGHT, PATENT, TRADEMARK, OR OTHER RIGHT. IN NO EVENT SHALL THE
COPYRIGHT HOLDER BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
INCLUDING ANY GENERAL, SPECIAL, INDIRECT, INCIDENTAL, OR CONSEQUENTIAL
DAMAGES, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF THE USE OR INABILITY TO USE THE FONT SOFTWARE OR FROM
OTHER DEALINGS IN THE FONT SOFTWARE.
```

## File: Assets/Art/Material/New Material.mat
```
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!21 &2100000
Material:
  serializedVersion: 8
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: New Material
  m_Shader: {fileID: 46, guid: 0000000000000000f000000000000000, type: 0}
  m_Parent: {fileID: 0}
  m_ModifiedSerializedProperties: 0
  m_ValidKeywords: []
  m_InvalidKeywords: []
  m_LightmapFlags: 4
  m_EnableInstancingVariants: 0
  m_DoubleSidedGI: 0
  m_CustomRenderQueue: -1
  stringTagMap: {}
  disabledShaderPasses: []
  m_LockedProperties: 
  m_SavedProperties:
    serializedVersion: 3
    m_TexEnvs:
    - _BumpMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailAlbedoMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailMask:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _DetailNormalMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _EmissionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MainTex:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _MetallicGlossMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _OcclusionMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    - _ParallaxMap:
        m_Texture: {fileID: 0}
        m_Scale: {x: 1, y: 1}
        m_Offset: {x: 0, y: 0}
    m_Ints: []
    m_Floats:
    - _BumpScale: 1
    - _Cutoff: 0.5
    - _DetailNormalMapScale: 1
    - _DstBlend: 0
    - _GlossMapScale: 1
    - _Glossiness: 0.5
    - _GlossyReflections: 1
    - _Metallic: 0
    - _Mode: 0
    - _OcclusionStrength: 1
    - _Parallax: 0.02
    - _SmoothnessTextureChannel: 0
    - _SpecularHighlights: 1
    - _SrcBlend: 1
    - _UVSec: 0
    - _ZWrite: 1
    m_Colors:
    - _Color: {r: 0.33404577, g: 0.735849, b: 0.16313633, a: 1}
    - _EmissionColor: {r: 0, g: 0, b: 0, a: 1}
  m_BuildTextureStacks: []
```

## File: Assets/Scenes/Escena_Inicio.unity
```
%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!29 &1
OcclusionCullingSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 2
  m_OcclusionBakeSettings:
    smallestOccluder: 5
    smallestHole: 0.25
    backfaceThreshold: 100
  m_SceneGUID: 00000000000000000000000000000000
  m_OcclusionCullingData: {fileID: 0}
--- !u!104 &2
RenderSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 9
  m_Fog: 0
  m_FogColor: {r: 0.5, g: 0.5, b: 0.5, a: 1}
  m_FogMode: 3
  m_FogDensity: 0.01
  m_LinearFogStart: 0
  m_LinearFogEnd: 300
  m_AmbientSkyColor: {r: 0.212, g: 0.227, b: 0.259, a: 1}
  m_AmbientEquatorColor: {r: 0.114, g: 0.125, b: 0.133, a: 1}
  m_AmbientGroundColor: {r: 0.047, g: 0.043, b: 0.035, a: 1}
  m_AmbientIntensity: 1
  m_AmbientMode: 0
  m_SubtractiveShadowColor: {r: 0.42, g: 0.478, b: 0.627, a: 1}
  m_SkyboxMaterial: {fileID: 10304, guid: 0000000000000000f000000000000000, type: 0}
  m_HaloStrength: 0.5
  m_FlareStrength: 1
  m_FlareFadeSpeed: 3
  m_HaloTexture: {fileID: 0}
  m_SpotCookie: {fileID: 10001, guid: 0000000000000000e000000000000000, type: 0}
  m_DefaultReflectionMode: 0
  m_DefaultReflectionResolution: 128
  m_ReflectionBounces: 1
  m_ReflectionIntensity: 1
  m_CustomReflection: {fileID: 0}
  m_Sun: {fileID: 0}
  m_UseRadianceAmbientProbe: 0
--- !u!157 &3
LightmapSettings:
  m_ObjectHideFlags: 0
  serializedVersion: 12
  m_GIWorkflowMode: 1
  m_GISettings:
    serializedVersion: 2
    m_BounceScale: 1
    m_IndirectOutputScale: 1
    m_AlbedoBoost: 1
    m_EnvironmentLightingMode: 0
    m_EnableBakedLightmaps: 1
    m_EnableRealtimeLightmaps: 0
  m_LightmapEditorSettings:
    serializedVersion: 12
    m_Resolution: 2
    m_BakeResolution: 40
    m_AtlasSize: 1024
    m_AO: 0
    m_AOMaxDistance: 1
    m_CompAOExponent: 1
    m_CompAOExponentDirect: 0
    m_ExtractAmbientOcclusion: 0
    m_Padding: 2
    m_LightmapParameters: {fileID: 0}
    m_LightmapsBakeMode: 1
    m_TextureCompression: 1
    m_FinalGather: 0
    m_FinalGatherFiltering: 1
    m_FinalGatherRayCount: 256
    m_ReflectionCompression: 2
    m_MixedBakeMode: 2
    m_BakeBackend: 1
    m_PVRSampling: 1
    m_PVRDirectSampleCount: 32
    m_PVRSampleCount: 512
    m_PVRBounces: 2
    m_PVREnvironmentSampleCount: 256
    m_PVREnvironmentReferencePointCount: 2048
    m_PVRFilteringMode: 1
    m_PVRDenoiserTypeDirect: 1
    m_PVRDenoiserTypeIndirect: 1
    m_PVRDenoiserTypeAO: 1
    m_PVRFilterTypeDirect: 0
    m_PVRFilterTypeIndirect: 0
    m_PVRFilterTypeAO: 0
    m_PVREnvironmentMIS: 1
    m_PVRCulling: 1
    m_PVRFilteringGaussRadiusDirect: 1
    m_PVRFilteringGaussRadiusIndirect: 5
    m_PVRFilteringGaussRadiusAO: 2
    m_PVRFilteringAtrousPositionSigmaDirect: 0.5
    m_PVRFilteringAtrousPositionSigmaIndirect: 2
    m_PVRFilteringAtrousPositionSigmaAO: 1
    m_ExportTrainingData: 0
    m_TrainingDataDestination: TrainingData
    m_LightProbeSampleCountMultiplier: 4
  m_LightingDataAsset: {fileID: 0}
  m_LightingSettings: {fileID: 0}
--- !u!196 &4
NavMeshSettings:
  serializedVersion: 2
  m_ObjectHideFlags: 0
  m_BuildSettings:
    serializedVersion: 3
    agentTypeID: 0
    agentRadius: 0.5
    agentHeight: 2
    agentSlope: 45
    agentClimb: 0.4
    ledgeDropHeight: 0
    maxJumpAcrossDistance: 0
    minRegionArea: 2
    manualCellSize: 0
    cellSize: 0.16666667
    manualTileSize: 0
    tileSize: 256
    buildHeightMesh: 0
    maxJobWorkers: 0
    preserveTilesOutsideBounds: 0
    debug:
      m_Flags: 0
  m_NavMeshData: {fileID: 0}
--- !u!1 &134219226
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 134219229}
  - component: {fileID: 134219228}
  - component: {fileID: 134219227}
  m_Layer: 0
  m_Name: EventSystem
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!114 &134219227
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 134219226}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 01614664b831546d2ae94a42149d80ac, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_SendPointerHoverToParent: 1
  m_MoveRepeatDelay: 0.5
  m_MoveRepeatRate: 0.1
  m_XRTrackingOrigin: {fileID: 0}
  m_ActionsAsset: {fileID: -944628639613478452, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_PointAction: {fileID: -1654692200621890270, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_MoveAction: {fileID: -8784545083839296357, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_SubmitAction: {fileID: 392368643174621059, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_CancelAction: {fileID: 7727032971491509709, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_LeftClickAction: {fileID: 3001919216989983466, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_MiddleClickAction: {fileID: -2185481485913320682, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_RightClickAction: {fileID: -4090225696740746782, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_ScrollWheelAction: {fileID: 6240969308177333660, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_TrackedDevicePositionAction: {fileID: 6564999863303420839, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_TrackedDeviceOrientationAction: {fileID: 7970375526676320489, guid: ca9f5fa95ffab41fb9a615ab714db018, type: 3}
  m_DeselectOnBackgroundClick: 1
  m_PointerBehavior: 0
  m_CursorLockBehavior: 0
  m_ScrollDeltaPerTick: 6
--- !u!114 &134219228
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 134219226}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 76c392e42b5098c458856cdf6ecaaaa1, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_FirstSelected: {fileID: 0}
  m_sendNavigationEvents: 1
  m_DragThreshold: 10
--- !u!4 &134219229
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 134219226}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 0, y: 0, z: 0}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1 &732479689
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 732479691}
  - component: {fileID: 732479690}
  - component: {fileID: 732479692}
  m_Layer: 0
  m_Name: UI_Document_Manager
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!114 &732479690
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 732479689}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 19102, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_PanelSettings: {fileID: 11400000, guid: 4425d11ec82b03b408be9b9c96826225, type: 2}
  m_ParentUI: {fileID: 0}
  sourceAsset: {fileID: 9197481963319205126, guid: 337cd63dde14bd7059adb662f049dd56, type: 3}
  m_SortingOrder: 0
--- !u!4 &732479691
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 732479689}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 1.1999894, y: 0.049994383, z: 5.089841}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!114 &732479692
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 732479689}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 2190a56341500098da2ac6305580ead0, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  escenaGameplay: Catacumbas
--- !u!1 &1118566622
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1118566624}
  - component: {fileID: 1118566623}
  m_Layer: 0
  m_Name: Directional Light
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!108 &1118566623
Light:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1118566622}
  m_Enabled: 1
  serializedVersion: 10
  m_Type: 1
  m_Shape: 0
  m_Color: {r: 1, g: 1, b: 1, a: 1}
  m_Intensity: 1
  m_Range: 10
  m_SpotAngle: 30
  m_InnerSpotAngle: 21.80208
  m_CookieSize: 10
  m_Shadows:
    m_Type: 0
    m_Resolution: -1
    m_CustomResolution: -1
    m_Strength: 1
    m_Bias: 0.05
    m_NormalBias: 0.4
    m_NearPlane: 0.2
    m_CullingMatrixOverride:
      e00: 1
      e01: 0
      e02: 0
      e03: 0
      e10: 0
      e11: 1
      e12: 0
      e13: 0
      e20: 0
      e21: 0
      e22: 1
      e23: 0
      e30: 0
      e31: 0
      e32: 0
      e33: 1
    m_UseCullingMatrixOverride: 0
  m_Cookie: {fileID: 0}
  m_DrawHalo: 0
  m_Flare: {fileID: 0}
  m_RenderMode: 0
  m_CullingMask:
    serializedVersion: 2
    m_Bits: 4294967295
  m_RenderingLayerMask: 1
  m_Lightmapping: 4
  m_LightShadowCasterMode: 0
  m_AreaSize: {x: 1, y: 1}
  m_BounceIntensity: 1
  m_ColorTemperature: 6570
  m_UseColorTemperature: 0
  m_BoundingSphereOverride: {x: 0, y: 0, z: 0, w: 0}
  m_UseBoundingSphereOverride: 0
  m_UseViewFrustumForShadowCasterCull: 1
  m_ShadowRadius: 0
  m_ShadowAngle: 0
--- !u!4 &1118566624
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1118566622}
  serializedVersion: 2
  m_LocalRotation: {x: 0.40821788, y: -0.23456968, z: 0.10938163, w: 0.8754261}
  m_LocalPosition: {x: 1.1999894, y: 0.049994383, z: 5.089841}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 50, y: -30, z: 0}
--- !u!1 &1206418219
GameObject:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  serializedVersion: 6
  m_Component:
  - component: {fileID: 1206418222}
  - component: {fileID: 1206418221}
  - component: {fileID: 1206418220}
  m_Layer: 0
  m_Name: Camera
  m_TagString: Untagged
  m_Icon: {fileID: 0}
  m_NavMeshLayer: 0
  m_StaticEditorFlags: 0
  m_IsActive: 1
--- !u!81 &1206418220
AudioListener:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1206418219}
  m_Enabled: 1
--- !u!20 &1206418221
Camera:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1206418219}
  m_Enabled: 1
  serializedVersion: 2
  m_ClearFlags: 1
  m_BackGroundColor: {r: 0.19215687, g: 0.3019608, b: 0.4745098, a: 0}
  m_projectionMatrixMode: 1
  m_GateFitMode: 2
  m_FOVAxisMode: 0
  m_Iso: 200
  m_ShutterSpeed: 0.005
  m_Aperture: 16
  m_FocusDistance: 10
  m_FocalLength: 50
  m_BladeCount: 5
  m_Curvature: {x: 2, y: 11}
  m_BarrelClipping: 0.25
  m_Anamorphism: 0
  m_SensorSize: {x: 36, y: 24}
  m_LensShift: {x: 0, y: 0}
  m_NormalizedViewPortRect:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1
    height: 1
  near clip plane: 0.3
  far clip plane: 1000
  field of view: 60
  orthographic: 0
  orthographic size: 5
  m_Depth: 0
  m_CullingMask:
    serializedVersion: 2
    m_Bits: 4294967295
  m_RenderingPath: -1
  m_TargetTexture: {fileID: 0}
  m_TargetDisplay: 0
  m_TargetEye: 3
  m_HDR: 1
  m_AllowMSAA: 1
  m_AllowDynamicResolution: 0
  m_ForceIntoRT: 0
  m_OcclusionCulling: 1
  m_StereoConvergence: 10
  m_StereoSeparation: 0.022
--- !u!4 &1206418222
Transform:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 1206418219}
  serializedVersion: 2
  m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
  m_LocalPosition: {x: 1.1999894, y: 0.049994383, z: 5.089841}
  m_LocalScale: {x: 1, y: 1, z: 1}
  m_ConstrainProportionsScale: 0
  m_Children: []
  m_Father: {fileID: 0}
  m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
--- !u!1660057539 &9223372036854775807
SceneRoots:
  m_ObjectHideFlags: 0
  m_Roots:
  - {fileID: 732479691}
  - {fileID: 1118566624}
  - {fileID: 1206418222}
  - {fileID: 134219229}
```

## File: Assets/UI Toolkit/UnityThemes/UnityDefaultRuntimeTheme.tss
```
@import url("unity-theme://default");
```

## File: Assets/UI_Inicio/MenuInicio.uss
```
.pantalla-completa {
    width: 100%;
    height: 100%;
    background-color: #000000;
    align-items: center;
    justify-content: center;
}

.contenedor-centrado {
    align-items: center;
    justify-content: center;
}

.titulo-juego {
    font-size: 72px;
    color: #AA0000;
    -unity-font-style: bold;
    margin-bottom: 50px;
}

.boton-inicio {
    background-color: #222222;
    border-width: 1px;
    border-color: #555555;
    color: #FFFFFF;
    padding-top: 15px;
    padding-bottom: 15px;
    padding-left: 40px;
    padding-right: 40px;
    font-size: 24px;
    transition-duration: 0.3s;
    transition-property: scale, background-color;
}

.boton-inicio:hover {
    scale: 1.05;
    background-color: #444444;
}
```

## File: Assets/UI_Inicio/MenuInicio.uxml
```
<ui:UXML xmlns:ui="UnityEngine.UIElements" xmlns:uie="UnityEditor.UIElements" xsi="http://www.w3.org/2001/XMLSchema-instance" editor="UnityEditor.UIElements" noNamespaceSchemaLocation="../../UIElementsSchema/UIElements.xsd" editor-extension-mode="False">
    <Style src="project://database/Assets/UI_Inicio/MenuInicio.uss?fileID=7433441132597879392&amp;guid=9655d613110827a83ae6327c73cfdb95&amp;type=3#MenuInicio" />
    <ui:VisualElement class="pantalla-completa" picking-mode="Ignore">
        <ui:VisualElement class="contenedor-centrado" picking-mode="Ignore">
            <ui:Label text="PROTOTYPE TERROR" class="titulo-juego" />
            <ui:Button text="ENTRAR AL HORROR" parse-escape-sequences="true" display-tooltip-when-elided="true" name="btnJugar" picking-mode="Position" style="position: absolute; height: 33px; top: 74px; -unity-text-align: middle-right;" />
        </ui:VisualElement>
    </ui:VisualElement>
</ui:UXML>
```

## File: Assets/UI_Inicio/MenuInicioController.cs
```csharp
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
```

## File: Assets/.cursorrules
```
# MANUAL DE OPERACIÓN DE UNITY & ANTIGRAVITY (MCP)

## 1. Directrices de Optimización de Tokens y Rendimiento
- **Diagnóstico Obligatorio:** Antes de proponer modificaciones de código o corregir errores de compilación/ejecución, DEBES inspeccionar el estado real del proyecto usando 'read_console' o los recursos de escena de GameObject. No adivines soluciones sin ver los logs.
- **Uso de Lotes (Batching):** Para cualquier tarea que implique crear, mover o modificar más de 2 objetos o componentes secuencialmente, utiliza obligatoriamente la herramienta 'batch_execute'. No realices múltiples llamadas secuenciales a herramientas individuales.
- **Modificaciones Quirúrgicas:** Para editar scripts de C#, utiliza prioritariamente la herramienta 'script_apply_edits' con operaciones enfocadas ('replace_method', 'insert_method') en lugar de reescribir o reemplazar archivos de código completos.
- **Validación de APIs en Vivo:** Si necesitas usar clases o métodos de paquetes específicos (como Cinemachine, URP o el nuevo Input System), verifica su existencia y firma exacta primero mediante 'unity_reflect' antes de escribir código.
- **Control de Capturas Visuales:** Limita el uso del parámetro 'include_image=true' en capturas de pantalla ('manage_camera' o 'manage_ui') estrictamente a validaciones visuales críticas que requiera el usuario. Prefiero comprobar jerarquías o datos puros para ahorrar contexto de tokens.

## 2. Reglas del Chasis y Arquitectura del Juego (Prototype Terror)
- **Nombres Clave Obligatorios:** Respeta minuciosamente el Diccionario de Identidad del proyecto:
  * Estados del Player (FasePlayer): Alerta, Sobresalto, Colapso, Horror.
  * Estados del Enemigo (FaseEnemigo): Rastreo, Sigilo, Persecucion, SedDeSangre.
  * Variable de Control Global: 'intuicion' (un acumulador de tipo float de 0.0 a 1.0 dentro del ScriptableObject 'IntuicionSystem').
- **Arquitectura de la IA (EnemyBrain):** Los estados de la IA del enemigo deben desacoplarse del jugador e implementar obligatoriamente la interfaz 'IEstado' (con sus contratos Entrar, Ejecutar, Salir).
- **Rendimiento de Eventos:** Prohíbe el uso de ciclos 'Update()' innecesarios en scripts de interfaz o escucha de datos; toda actualización de estado físico, de miedo o de interfaz debe responder de forma pasiva a eventos o cambios del ScriptableObject.
- **Código Limpio:** Todos los scripts generados deben incluir comentarios estructurados en español detallando la lógica del chasis y finalizar con una línea en blanco (Render Final Newline).

## 3. Interfaces con UI Toolkit
- **Estructura UXML:** Asegúrate de utilizar siempre el prefijo de namespace '<ui:Style>' para añadir hojas de estilos en los archivos UXML. Nunca uses etiquetas '<Style>' desnudas porque rompen el UI Builder de Unity.
```

## File: .gitignore
```
# This .gitignore file should be placed at the root of your Unity project directory
#
# Get latest from https://github.com/github/gitignore/blob/master/Unity.gitignore
#
/[Ll]ibrary/
/[Tt]emp/
/[Oo]bj/
/[Bb]uild/
/[Bb]uilds/
/[Ll]ogs/
/[Mm]emoryCaptures/

# Never ignore Asset meta data
!/[Aa]ssets/**/*.meta

# Uncomment this line if you wish to ignore the asset store tools plugin
# /[Aa]ssets/AssetStoreTools*

# TextMesh Pro files
[Aa]ssets/TextMesh*Pro/

# Autogenerated Jetbrains Rider plugin
[Aa]ssets/Plugins/Editor/JetBrains*

# Visual Studio cache directory
.vs/

# Gradle cache directory
.gradle/

# Autogenerated VS/MD/Consulo solution and project files
ExportedObj/
.consulo/
*.csproj
*.unityproj
*.sln
*.suo
*.tmp
*.user
*.userprefs
*.pidb
*.booproj
*.svd
*.pdb
*.mdb
*.opendb
*.VC.db

# Unity3D generated meta files
*.pidb.meta
*.pdb.meta
*.mdb.meta

# Unity3D generated file on crash reports
sysinfo.txt

# Builds
*.apk
*.unitypackage

# Crashlytics generated file
crashlytics-build.properties
```

## File: .repomixignore
```
# Excluir carpetas pesadas o inútiles de Unity
Library/
Temp/
Obj/
Logs/
UserSettings/
MemoryCaptures/
Builds/
*.meta
*.unitypackage
*.asset
*.prefab
UserSettings/
Packages/
ProjectSettings/
*.meta
```

## File: README.md
```markdown
# Prototype_Terror
```

## File: Assets/_Scripts/Enums/GameEnums.cs
```csharp
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
```

## File: Assets/_Scripts/Interfaces/IEstado.cs
```csharp
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
```

## File: Assets/_Scripts/UI/UI_MenuManager.cs
```csharp
using _Scripts.Player;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
// LINEA NUEVA: Permite al script tener acceso directo a las herramientas de cámara de Cinemachine
using Cinemachine;

namespace _Scripts.UI
{
    // Asegura que este script inicialice después de los componentes base del juego para evitar NullReference
    [DefaultExecutionOrder(100)]
    public class UI_MenuManager : MonoBehaviour
    {
        // Enums: Una lista de estados lógicos excluyentes. El juego solo puede estar en UNO de estos a la vez.
        private enum MenuState
        {
            Gameplay,
            MenuAbierto
        }

        [Header("Input (Assets/Input/PlayerControls)")]
        [Tooltip("El contenedor de mapas de control (.inputactions) de nuestro proyecto")]
        [SerializeField]
        private InputActionAsset inputActionAsset;

        [Header("UI")] [Tooltip("El objeto raíz de la interfaz que contiene los botones")] [SerializeField]
        private GameObject menuPanel;

        [SerializeField] private TextMeshProUGUI tituloTexto;
        [SerializeField] private TextMeshProUGUI botonPrincipalTexto;

        [Header("Jugador")]
        [Tooltip("Referencia al script que controla el movimiento físico de nuestro personaje")]
        [SerializeField]
        private PlayerController playerController;

        [Header("Configuración de Cámara (Cinemachine)")]
        [Tooltip("Arrastra aquí tu Virtual Camera de Cinemachine para congelar la rotación del mouse en las pausas")]
        [SerializeField]
        private CinemachineInputProvider cameraProvider;

        [SerializeField] private CinemachineVirtualCamera virtualCamera; // <-- Cambiamos el tipo aquí
        private CinemachinePOV cameraPov; // Ahora es privado, no se arrastra

        // Cache de componentes de control para evitar búsquedas repetitivas en cada frame (Ahorro de CPU)
        private InputActionMap _gameplayMap;
        private InputActionMap _uiMap;
        private InputAction _pauseAction;
        private InputAction _unpauseAction;

        // Estado actual del menú diegético (P alterna Gameplay ↔ MenuAbierto).
        private MenuState _estado = MenuState.Gameplay;

        // Constantes: Textos fijos que no van a cambiar durante la ejecución del código
        private const string TituloMenu = "Soporte";
        private const string TextoCerrar = "Cerrar";

        private void Awake()
        {
            // Validación de seguridad: Si olvidaste arrastrar los controles en el inspector, el script se apaga solo
            if (inputActionAsset == null)
            {
                Debug.LogError("UI_MenuManager: Asigna el InputActionAsset PlayerControls en el Inspector.");
                enabled = false;
                return;
            }

            if (virtualCamera != null)
            {
                // Esto extrae el módulo interno POV de la cámara virtual
                cameraPov = virtualCamera.GetCinemachineComponent<CinemachinePOV>();

                if (cameraProvider == null)
                    cameraProvider = virtualCamera.GetComponent<CinemachineInputProvider>();
            }

            // 1. Buscamos y vinculamos los Action Maps definidos en tu archivo de inputs
            _gameplayMap = inputActionAsset.FindActionMap("Gameplay", true);
            _uiMap = inputActionAsset.FindActionMap("UI", true);

            // 2. Buscamos las acciones específicas mapeadas a la tecla P
            _pauseAction = _gameplayMap.FindAction("Pause", true);
            _unpauseAction = _uiMap.FindAction("Unpause", true);

            // 3. SUSCRIPCIÓN: Conectamos físicamente las acciones a nuestras funciones de C#
            _pauseAction.performed += OnPausePerformed;
            _unpauseAction.performed += OnUnpausePerformed;

            // Búsqueda automática: Si no arrastraste el script del jugador, lo intenta buscar en la escena por sí mismo
            if (playerController == null)
                playerController = FindObjectOfType<PlayerController>();

            if (cameraProvider == null)
                cameraProvider = FindObjectOfType<CinemachineInputProvider>();

            if (cameraPov == null && cameraProvider != null)
                cameraPov = cameraProvider.GetComponentInChildren<CinemachinePOV>();
        }

        private void Start()
        {
            EntrarModoGameplay();
        }

        private void OnDestroy()
        {
            // BUENA PRÁCTICA: Rompemos la conexión con los eventos al destruir el objeto para evitar bugs de memoria
            if (_pauseAction != null)
                _pauseAction.performed -= OnPausePerformed;
            if (_unpauseAction != null)
                _unpauseAction.performed -= OnUnpausePerformed;
        }

        // --- MÉTODOS PÚBLICOS PARA LOS BOTONES (EVENTOS ONCLICK) ---

        public void OnClickJugarOReanudar()
        {
            if (_estado == MenuState.MenuAbierto)
                EntrarModoGameplay();
        }

        public void OnClickSalir()
        {
            // Compilación condicional: Detiene el juego de forma correcta según el entorno
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Detiene el Play Mode dentro de Unity
#else
            Application.Quit(); // Cierra la aplicación ejecutable (.exe o binario de Linux)
#endif
        }

        // --- RESPUESTAS A LOS INPUTS FÍSICOS (TECLA P) ---

        private void OnPausePerformed(InputAction.CallbackContext context)
        {
            // Filtro de seguridad: Si la acción no se completó o no estamos jugando, ignora el teclazo
            if (!context.performed || _estado != MenuState.Gameplay)
                return;

            EntrarModoMenuAbierto();
        }

        private void OnUnpausePerformed(InputAction.CallbackContext context)
        {
            if (!context.performed || _estado != MenuState.MenuAbierto)
                return;

            EntrarModoGameplay();
        }

        // --- MANEJADORES DE ESTADO (MÁQUINA DE ESTADOS) ---

        private void EntrarModoGameplay()
        {
            _estado = MenuState.Gameplay;

            MostrarMenu(false);
            ConfigurarCursor(false);
            ActivarMapaGameplay();
            ConfigurarJugador(true);
            ConfigurarCamara(true);
        }

        private void EntrarModoMenuAbierto()
        {
            _estado = MenuState.MenuAbierto;

            MostrarMenu(true);
            ConfigurarTextos(TituloMenu, TextoCerrar);
            ConfigurarCursor(true);
            ActivarMapaUI();
            ConfigurarJugador(false);
            ConfigurarCamara(false);
        }

        // --- SUB-FUNCIONES AUXILIARES DE CONFIGURACIÓN ---

        private void ActivarMapaUI()
        {
            _gameplayMap.Disable(); // Desactiva el mapa de juego (WASD deja de responder instantáneamente)
            _uiMap.Enable(); // Activa el mapa de UI (Permite que funcione la tecla Unpause)
        }

        private void ActivarMapaGameplay()
        {
            _uiMap.Disable(); // Desactiva el mapa de UI
            _gameplayMap.Enable(); // Activa el mapa de juego activo
        }

        private void MostrarMenu(bool visible)
        {
            if (menuPanel != null)
                menuPanel.SetActive(visible); // Enciende o apaga el GameObject completo en la jerarquía
        }

        private void ConfigurarTextos(string titulo, string botonPrincipal)
        {
            if (tituloTexto != null)
                tituloTexto.text = titulo;
            if (botonPrincipalTexto != null)
                botonPrincipalTexto.text = botonPrincipal;
        }

        private static void ConfigurarCursor(bool menuActivo)
        {
            // Si el menú está activo, el cursor se libera. Si no, se bloquea al centro de la pantalla.
            Cursor.lockState = menuActivo ? CursorLockMode.None : CursorLockMode.Locked;
            Cursor.visible = menuActivo; // Alterna la visibilidad del puntero gráfico
        }

        private void ConfigurarJugador(bool activo)
        {
            if (playerController != null)
                playerController.SetControlBlocked(!activo);
        }

        private void ConfigurarCamara(bool activo)
        {
            if (cameraProvider != null)
                cameraProvider.enabled = activo;

            if (cameraPov == null)
                return;

            var horizontal = cameraPov.m_HorizontalAxis;
            horizontal.m_InputAxisValue = 0f;
            cameraPov.m_HorizontalAxis = horizontal;

            var vertical = cameraPov.m_VerticalAxis;
            vertical.m_InputAxisValue = 0f;
            cameraPov.m_VerticalAxis = vertical;

            if (activo && Mouse.current != null)
                InputSystem.ResetDevice(Mouse.current);
        }
    }
}
```

## File: Assets/_Scripts/Player/PlayerController.cs
```csharp
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
```

## File: Assets/_Scripts/States/EstadoRastreo.cs
```csharp
using UnityEngine;
using _Scripts.Interfaces;
using _Scripts.Brains;

namespace _Scripts.States
{
    /* * ESTADO: RASTREO (FASE 1)
     * El enemigo patrulla tranquilamente entre waypoints usando NavMeshAgent.
     * Es el estado más "ciego" y lento.
     */
    public class EstadoRastreo : IEstado
    {
        private readonly EnemyBrain _brain;
        private readonly float _velocidadRastreo = 2.5f;
        
        private int _indexWaypointActual = 0;
        private Vector3 _ultimoDestinoAsignado;
        private bool _iniciando = true;

        // El constructor nos permite recibir la referencia del cerebro
        public EstadoRastreo(EnemyBrain brain)
        {
            _brain = brain;
        }

        public void Entrar()
        {
            Debug.Log("<color=green>Enemigo entrando en fase de RASTREO.</color>");
            _brain.ActualizarVelocidad(_velocidadRastreo);
            _ultimoDestinoAsignado = Vector3.zero;
            _iniciando = true;
        }

        public void Ejecutar()
        {
            // 1. Aseguramos que la velocidad actual del agente sea la de rastreo
            _brain.ActualizarVelocidad(_velocidadRastreo);

            Vector3 destinoObjetivo;
            bool esSospecha = _brain.Data.IntuicionActual > 0.2f;

            if (esSospecha)
            {
                // Si la intuición es alta, vamos a investigar la posición sospechosa
                destinoObjetivo = _brain.Data.posicionSospechosa;
            }
            else
            {
                // Si no, volvemos a la patrulla normal
                if (_brain.Waypoints == null || _brain.Waypoints.Length == 0) return;
                destinoObjetivo = _brain.Waypoints[_indexWaypointActual].position;
            }

            // 2. OPTIMIZACIÓN CRÍTICA: Solo llamamos a SetDestination si el destino ha cambiado.
            // Si llamamos a SetDestination en cada frame (Update), el agente recalcula la ruta infinitamente y se queda quieto.
            if (_iniciando || Vector3.Distance(_ultimoDestinoAsignado, destinoObjetivo) > 0.1f)
            {
                _brain.MoverHacia(destinoObjetivo);
                _ultimoDestinoAsignado = destinoObjetivo;
                _iniciando = false;
            }

            // 3. CAMBIO DE WAYPOINT: Si estamos patrullando y llegamos físicamente cerca del punto, avanzamos
            if (!esSospecha)
            {
                float distanciaFisica = Vector3.Distance(_brain.transform.position, destinoObjetivo);
                if (distanciaFisica < 0.8f)
                {
                    _indexWaypointActual = (_indexWaypointActual + 1) % _brain.Waypoints.Length;
                }
            }
        }

        public void Exit() // Cumple la interfaz si requiere Salir en español
        {
            Salir();
        }

        public void Salir()
        {
            Debug.Log("Saliendo de RASTREO: El enemigo ha cambiado de estado.");
        }
    }
}
```

## File: Assets/_Scripts/Systems/IntuicionSystem.cs
```csharp
using UnityEngine;
using System; // Necesario para usar los "Eventos" (La Radio)

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DICCIONARIO ACÚSTICO
 * Lo definimos aquí para que cualquier objeto del juego pueda
 * "etiquetar" su ruido antes de enviarlo al sistema.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
namespace _Scripts.Enums
{
    public enum PerfilAcustico
    {
        AgudoVocal, // Gritos, susurros, cristales rotos (Se ahogan rápido con la distancia)
        GraveFisico // Pasos pesados, muebles cayendo (Viajan lejos por el suelo/estructura)
    }
}

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * EL CORAZÓN DE DATOS (SISTEMA DE INTUICIÓN)
 * Actúa como un Analizador de Frecuencias Básico. Recibe paquetes 
 * de sonido, calcula su impacto real y alerta al enemigo.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
namespace _Scripts.Systems
{
    [CreateAssetMenu(fileName = "NuevaIntuicion", menuName = "Sistema/Intuicion Data")]
    public class IntuicionSystem : ScriptableObject
    {
        [Header("Datos de la Fase (Escala 0.0 a 1.0)")]
        [Tooltip("El medidor de peligro de la fase actual")]
        [SerializeField] private float intuicionActual = 0f;
        public float IntuicionActual => intuicionActual;

        [Header("Memoria de Posición")]
        [Tooltip("Última posición global donde se originó un ruido válido")]
        public Vector3 posicionSospechosa;

        // EVENTOS ("La Radio"): Avisan al enemigo cuando debe cambiar de fase
        public event Action OnSubirFase;
        public event Action OnBajarFase;

        /* * *
         * MÉTODO PARA SUBIR: LA PUERTA DE ENTRADA DEL RUIDO
         * Recibe el "Paquete de Sonido" (Volumen, Distancia y Tipo) y 
         * decide cuánto asusta realmente al monstruo.
         */
        // ReSharper disable Unity.PerformanceAnalysis
        public void ModificarIntuicion(float volumenOriginal, float distanciaAlMonstruo, _Scripts.Enums.PerfilAcustico perfil)
        {
            // Esta variable guardará el ruido final después de calcular la distancia
            float incrementoFinal = 0f;

            // 1. FILTRO MATEMÁTICO DE FRECUENCIAS (La magia del sonido)
            switch (perfil)
            { 
                case _Scripts.Enums.PerfilAcustico.AgudoVocal:
                    // REGLA AGUDA: Multiplicamos la distancia x 2.0
                    // Si el monstruo está a 10m, el divisor será 20. El sonido se vuelve diminuto muy rápido.
                    incrementoFinal = volumenOriginal / Mathf.Max(distanciaAlMonstruo * 2.0f, 0.1f);
                    break;

                case _Scripts.Enums.PerfilAcustico.GraveFisico:
                    // REGLA GRAVE: Multiplicamos la distancia x 0.3 (La reducimos)
                    // Si el monstruo está a 10m, el divisor será solo 3. La vibración llega casi intacta.
                    incrementoFinal = volumenOriginal / Mathf.Max(distanciaAlMonstruo * 0.3f, 0.1f);
                    break;
            }

            // 2. REGLA DEL 75% (Zona de Gracia)
            // Si el monstruo ya está muy alterado (>0.75), los ruidos le afectan 3 veces menos.
            // Así le damos al jugador una micro-oportunidad de escapar antes de pasar a Persecución.
            if (intuicionActual >= 0.75f && incrementoFinal > 0)
            {
                intuicionActual += (incrementoFinal / 3f);
            }
            else
            {
                intuicionActual += incrementoFinal;
            }

            // 3. REGLA DE CASCADA (SUBIDA)
            // Si el vaso se derrama, gritamos por la radio para que el EnemyBrain suba de fase.
            if (!(intuicionActual >= 1.0f)) return;
            intuicionActual = 0f; // Vaciamos el vaso para el nuevo nivel
            OnSubirFase?.Invoke(); // El '?' asegura que no haya error si nadie escucha
        }

        /* * *
         * TICK DE RECUPERACIÓN (Llamado por el EnemyBrain cada 60s)
         * Reduce el miedo con el tiempo. Es más difícil calmarlo en niveles altos.
         */
        public void EjecutarTickDeRecuperacion(int miedoLevel)
        {
            // FÓRMULA: Reducción = Intuición Actual * (1/3 * 1/Miedo)
            float factorEnfriamiento = (1f / 3f) * (1f / miedoLevel);
            float cantidadARestar = intuicionActual * factorEnfriamiento;

            intuicionActual -= cantidadARestar;

            // REGLA DE CASCADA (BAJADA)
            if (intuicionActual <= 0f)
            {
                // REGALO AL JUGADOR: Si el monstruo se calma y baja de fase, 
                // la nueva fase empieza en 0.7 (70%) en lugar de 1.0. No se olvida de ti del todo.
                intuicionActual = 0.7f; 
                OnBajarFase?.Invoke(); 
            }

            // Mantenemos el número entre 0.0 y 1.0 por seguridad del motor
            intuicionActual = Mathf.Clamp01(intuicionActual);
        }
    }
}
```

## File: Assets/Input/PlayerControls.cs
```csharp
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.14.2
//     from Assets/Input/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

/// <summary>
/// Provides programmatic access to <see cref="InputActionAsset" />, <see cref="InputActionMap" />, <see cref="InputAction" /> and <see cref="InputControlScheme" /> instances defined in asset "Assets/Input/PlayerControls.inputactions".
/// </summary>
/// <remarks>
/// This class is source generated and any manual edits will be discarded if the associated asset is reimported or modified.
/// </remarks>
/// <example>
/// <code>
/// using namespace UnityEngine;
/// using UnityEngine.InputSystem;
///
/// // Example of using an InputActionMap named "Player" from a UnityEngine.MonoBehaviour implementing callback interface.
/// public class Example : MonoBehaviour, MyActions.IPlayerActions
/// {
///     private MyActions_Actions m_Actions;                  // Source code representation of asset.
///     private MyActions_Actions.PlayerActions m_Player;     // Source code representation of action map.
///
///     void Awake()
///     {
///         m_Actions = new MyActions_Actions();              // Create asset object.
///         m_Player = m_Actions.Player;                      // Extract action map object.
///         m_Player.AddCallbacks(this);                      // Register callback interface IPlayerActions.
///     }
///
///     void OnDestroy()
///     {
///         m_Actions.Dispose();                              // Destroy asset object.
///     }
///
///     void OnEnable()
///     {
///         m_Player.Enable();                                // Enable all actions within map.
///     }
///
///     void OnDisable()
///     {
///         m_Player.Disable();                               // Disable all actions within map.
///     }
///
///     #region Interface implementation of MyActions.IPlayerActions
///
///     // Invoked when "Move" action is either started, performed or canceled.
///     public void OnMove(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnMove: {context.ReadValue&lt;Vector2&gt;()}");
///     }
///
///     // Invoked when "Attack" action is either started, performed or canceled.
///     public void OnAttack(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnAttack: {context.ReadValue&lt;float&gt;()}");
///     }
///
///     #endregion
/// }
/// </code>
/// </example>
public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    /// <summary>
    /// Provides access to the underlying asset instance.
    /// </summary>
    public InputActionAsset asset { get; }

    /// <summary>
    /// Constructs a new instance.
    /// </summary>
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""version"": 1,
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""7abfd263-bb92-434a-a6e1-384bbda27d16"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9c18749d-7a66-4e7c-a1f1-fd577b715664"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""eb10d26d-9ee2-4ae3-9e82-8874a4c3e951"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""9c4689f5-077d-4e7b-a95f-e7990376191c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""afeb5324-c85c-4351-bd99-5d6703cdb2af"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""ae16035a-5f2b-41de-a7f3-cb7b3d469034"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fa8f4d5d-a1bb-490e-9f42-760d0b8b0da7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a662e232-7817-4fbe-81c8-95daa41d475e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5114778e-34cb-4c5b-8508-c3b7d0706900"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b35f0a8f-0fe1-4b56-9e31-453e95fe1794"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""405aa2a3-f408-47d6-ba6f-b9d19c015576"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""efc3f80b-b584-4a72-9d00-4cb97d2cd1c9"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7aff7f1f-414f-47d6-a334-fedd5f7e544f"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1064827c-1861-4165-ab61-3cdd244c9d32"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""355006be-f334-47af-834a-315147fdb808"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""ca338fad-e951-45db-b139-b0296a2f9796"",
            ""actions"": [
                {
                    ""name"": ""Unpause"",
                    ""type"": ""Button"",
                    ""id"": ""550a9331-cb76-441c-9cdb-d002470bcb2b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4f82ebaa-9a03-4b18-898a-ba952e7c7bea"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Unpause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Sprint = m_Gameplay.FindAction("Sprint", throwIfNotFound: true);
        m_Gameplay_Crouch = m_Gameplay.FindAction("Crouch", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
        m_Gameplay_Look = m_Gameplay.FindAction("Look", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Unpause = m_UI.FindAction("Unpause", throwIfNotFound: true);
    }

    ~@PlayerControls()
    {
        UnityEngine.Debug.Assert(!m_Gameplay.enabled, "This will cause a leak and performance issues, PlayerControls.Gameplay.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_UI.enabled, "This will cause a leak and performance issues, PlayerControls.UI.Disable() has not been called.");
    }

    /// <summary>
    /// Destroys this asset and all associated <see cref="InputAction"/> instances.
    /// </summary>
    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindingMask" />
    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.devices" />
    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.controlSchemes" />
    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Contains(InputAction)" />
    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.GetEnumerator()" />
    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    /// <inheritdoc cref="IEnumerable.GetEnumerator()" />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Enable()" />
    public void Enable()
    {
        asset.Enable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Disable()" />
    public void Disable()
    {
        asset.Disable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindings" />
    public IEnumerable<InputBinding> bindings => asset.bindings;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindAction(string, bool)" />
    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindBinding(InputBinding, out InputAction)" />
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Sprint;
    private readonly InputAction m_Gameplay_Crouch;
    private readonly InputAction m_Gameplay_Pause;
    private readonly InputAction m_Gameplay_Look;
    /// <summary>
    /// Provides access to input actions defined in input action map "Gameplay".
    /// </summary>
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Move".
        /// </summary>
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Sprint".
        /// </summary>
        public InputAction @Sprint => m_Wrapper.m_Gameplay_Sprint;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Crouch".
        /// </summary>
        public InputAction @Crouch => m_Wrapper.m_Gameplay_Crouch;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Pause".
        /// </summary>
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Look".
        /// </summary>
        public InputAction @Look => m_Wrapper.m_Gameplay_Look;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="GameplayActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="GameplayActions" />
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @Crouch.started += instance.OnCrouch;
            @Crouch.performed += instance.OnCrouch;
            @Crouch.canceled += instance.OnCrouch;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="GameplayActions" />
        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @Crouch.started -= instance.OnCrouch;
            @Crouch.performed -= instance.OnCrouch;
            @Crouch.canceled -= instance.OnCrouch;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />.
        /// </summary>
        /// <seealso cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />
        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="GameplayActions.AddCallbacks(IGameplayActions)" />
        /// <seealso cref="GameplayActions.RemoveCallbacks(IGameplayActions)" />
        /// <seealso cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />
        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="GameplayActions" /> instance referencing this action map.
    /// </summary>
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_Unpause;
    /// <summary>
    /// Provides access to input actions defined in input action map "UI".
    /// </summary>
    public struct UIActions
    {
        private @PlayerControls m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public UIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "UI/Unpause".
        /// </summary>
        public InputAction @Unpause => m_Wrapper.m_UI_Unpause;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="UIActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="UIActions" />
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @Unpause.started += instance.OnUnpause;
            @Unpause.performed += instance.OnUnpause;
            @Unpause.canceled += instance.OnUnpause;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="UIActions" />
        private void UnregisterCallbacks(IUIActions instance)
        {
            @Unpause.started -= instance.OnUnpause;
            @Unpause.performed -= instance.OnUnpause;
            @Unpause.canceled -= instance.OnUnpause;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="UIActions.UnregisterCallbacks(IUIActions)" />.
        /// </summary>
        /// <seealso cref="UIActions.UnregisterCallbacks(IUIActions)" />
        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="UIActions.AddCallbacks(IUIActions)" />
        /// <seealso cref="UIActions.RemoveCallbacks(IUIActions)" />
        /// <seealso cref="UIActions.UnregisterCallbacks(IUIActions)" />
        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="UIActions" /> instance referencing this action map.
    /// </summary>
    public UIActions @UI => new UIActions(this);
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "Gameplay" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="GameplayActions.AddCallbacks(IGameplayActions)" />
    /// <seealso cref="GameplayActions.RemoveCallbacks(IGameplayActions)" />
    public interface IGameplayActions
    {
        /// <summary>
        /// Method invoked when associated input action "Move" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnMove(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Sprint" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnSprint(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Crouch" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnCrouch(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Pause" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPause(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Look" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnLook(InputAction.CallbackContext context);
    }
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "UI" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="UIActions.AddCallbacks(IUIActions)" />
    /// <seealso cref="UIActions.RemoveCallbacks(IUIActions)" />
    public interface IUIActions
    {
        /// <summary>
        /// Method invoked when associated input action "Unpause" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnUnpause(InputAction.CallbackContext context);
    }
}
```

## File: Assets/Input/PlayerControls.inputactions
```
{
    "version": 1,
    "name": "PlayerControls",
    "maps": [
        {
            "name": "Gameplay",
            "id": "7abfd263-bb92-434a-a6e1-384bbda27d16",
            "actions": [
                {
                    "name": "Move",
                    "type": "Value",
                    "id": "9c18749d-7a66-4e7c-a1f1-fd577b715664",
                    "expectedControlType": "Vector2",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": true
                },
                {
                    "name": "Sprint",
                    "type": "Button",
                    "id": "eb10d26d-9ee2-4ae3-9e82-8874a4c3e951",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Crouch",
                    "type": "Button",
                    "id": "9c4689f5-077d-4e7b-a95f-e7990376191c",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Pause",
                    "type": "Button",
                    "id": "afeb5324-c85c-4351-bd99-5d6703cdb2af",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Look",
                    "type": "Value",
                    "id": "ae16035a-5f2b-41de-a7f3-cb7b3d469034",
                    "expectedControlType": "Vector2",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": true
                }
            ],
            "bindings": [
                {
                    "name": "2D Vector",
                    "id": "fa8f4d5d-a1bb-490e-9f42-760d0b8b0da7",
                    "path": "2DVector",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "up",
                    "id": "a662e232-7817-4fbe-81c8-95daa41d475e",
                    "path": "<Keyboard>/w",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "down",
                    "id": "5114778e-34cb-4c5b-8508-c3b7d0706900",
                    "path": "<Keyboard>/s",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "left",
                    "id": "b35f0a8f-0fe1-4b56-9e31-453e95fe1794",
                    "path": "<Keyboard>/a",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "right",
                    "id": "405aa2a3-f408-47d6-ba6f-b9d19c015576",
                    "path": "<Keyboard>/d",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "",
                    "id": "efc3f80b-b584-4a72-9d00-4cb97d2cd1c9",
                    "path": "<XInputController>/leftTrigger",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Sprint",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "7aff7f1f-414f-47d6-a334-fedd5f7e544f",
                    "path": "<XInputController>/leftStick/down",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Crouch",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "1064827c-1861-4165-ab61-3cdd244c9d32",
                    "path": "<Keyboard>/p",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Pause",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "355006be-f334-47af-834a-315147fdb808",
                    "path": "<Mouse>/delta",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Look",
                    "isComposite": false,
                    "isPartOfComposite": false
                }
            ]
        },
        {
            "name": "UI",
            "id": "ca338fad-e951-45db-b139-b0296a2f9796",
            "actions": [
                {
                    "name": "Unpause",
                    "type": "Button",
                    "id": "550a9331-cb76-441c-9cdb-d002470bcb2b",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                }
            ],
            "bindings": [
                {
                    "name": "",
                    "id": "4f82ebaa-9a03-4b18-898a-ba952e7c7bea",
                    "path": "<Keyboard>/p",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Unpause",
                    "isComposite": false,
                    "isPartOfComposite": false
                }
            ]
        }
    ],
    "controlSchemes": []
}
```

## File: Assets/_Scripts/Brains/EnemyBrain.cs
```csharp
using UnityEngine;
using UnityEngine.AI; // Acceso al sistema de navegación
using UnityEngine.SceneManagement; // Importado para reiniciar la escena
using _Scripts.Systems;     // Acceso al corazón de datos (ScriptableObject)
using _Scripts.Interfaces;   // Acceso al contrato IEstado
using _Scripts.States;       // Acceso a las lógicas de estado (Rastreo, Sigilo...)

namespace _Scripts.Brains
{
    /* * * CLASE: EnemyBrain
     * DESCRIPCIÓN: Actúa como el "Cuerpo" y "Contexto" de la IA (Hardware). 
     * No decide qué hacer por sí mismo, sino que delega esa tarea a un objeto IEstado.
     * Mantiene vivo el cronómetro de 60s para el enfriamiento.
     * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
    public class EnemyBrain : MonoBehaviour
    {
        [Header("Referencias de Datos")]
        [Tooltip("El archivo de datos (SO) que compartimos con el jugador y el sistema")]
        [SerializeField] private IntuicionSystem data;
        public IntuicionSystem Data => data; // Propiedad pública para los Estados
        
        [Header("Configuración de Movimiento y Navegación")]
        [Tooltip("Agente de navegación del enemigo")]
        [SerializeField] private NavMeshAgent agent;
        public NavMeshAgent Agent => agent; // Propiedad pública para los Estados

        [Tooltip("Velocidad de traslación física base.")]
        [SerializeField] private float velocidadBase = 3.5f;
        
        [Tooltip("Puntos de patrulla para el movimiento perpetuo.")]
        [SerializeField] private Transform[] waypoints; 
        public Transform[] Waypoints => waypoints; // Propiedad pública para los Estados
        

        [Header("Instintos Base")]
        [Tooltip("Transform del jugador para el Olfato")]
        [SerializeField] private Transform transformJugador;
        [Tooltip("Distancia a la que el enemigo mata instantáneamente")]
        [SerializeField] private float distanciaOlfato = 1.5f;

        /* LÓGICA DE MÁQUINA DE ESTADOS e OPTIMIZACIÓN (CACHING) */
        private IEstado _estadoActual; 
        
        // Cacheamos las instancias de los estados para evitar asignaciones de memoria (GC Allocations)
        private IEstado _estadoRastreo;

        [Header("Reloj de Recuperación")]
        // Contador de segundos para llegar al minuto de enfriamiento
        private float _cronometroSesentaSeg = 0f;
        
        // Guardamos el nivel de fase actual (1, 2, 3...) para pasárselo al SO en el Tick
        private int _nivelMiedoActual = 1;

        /* * *
         * MÉTODO: Start
         * Se ejecuta al nacer. Configuramos los estados cacheando referencias y el estado inicial.
         */
        private void Start()
        {
            if (!data) return; // Si no hay datos sal de la función.
            
            // Verificación y asignación automática de componentes obligatorios
            if (!agent) agent = GetComponent<NavMeshAgent>();
            if (!agent) Debug.LogError("EnemyBrain: Falta el componente NavMeshAgent.");
            if (!transformJugador) Debug.LogError("EnemyBrain: Falta asignar el Transform del Jugador para el Olfato.");

            // Suscripción al SO
            data.OnSubirFase += HandleSubirFase;
            data.OnBajarFase += HandleBajarFase;
                
            // OPTIMIZACIÓN: Instanciamos los estados una sola vez en el inicio
            _estadoRastreo = new EstadoRastreo(this);
            
            // ESTADO INICIAL: Iniciamos usando la referencia cacheada
            CambiarEstado(_estadoRastreo);
        }

        /* * *
         * MÉTODO: Update
         * Ejecución por frame. Mantenemos el pulso de los relojes y la máquina de estados.
         */
        private void Update()
        {
            if (!data) return;

            // 1. CONDICIÓN GLOBAL (OLFATO): Instinto base primario
            if (transformJugador != null && Vector3.Distance(transform.position, transformJugador.position) <= distanciaOlfato)
            {
                EjecutarMuertePorOlfato();
                return;
            }

            // 2. Manejamos el tiempo para el enfriamiento de 60s
            ManejarCronometroRecuperacion();
            
            // 3. EJECUCIÓN DEL ESTADO: El estado controla la lógica en este frame
            _estadoActual?.Ejecutar(); 
        }

        private void EjecutarMuertePorOlfato()
        {
            Debug.Log("<color=red>¡JUGADOR ASESINADO POR OLFATO! Reiniciando escena...</color>");
            
            // Detenemos el movimiento físico inmediatamente
            if (agent != null && agent.isOnNavMesh)
            {
                agent.isStopped = true;
            }

            // Reiniciamos la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        /* * *
         * MÉTODO: ActualizarVelocidad
         * Función pública para que los ESTADOS puedan cambiar la velocidad del NavMeshAgent.
         */
        public void ActualizarVelocidad(float nuevaVelocidad)
        {
            velocidadBase = nuevaVelocidad;
            if (agent != null)
            {
                agent.speed = nuevaVelocidad;
            }
        }

        /* * *
         * MÉTODO: MoverHacia
         * Función pública para que los ESTADOS ordenen el destino al NavMeshAgent.
         */
        public void MoverHacia(Vector3 destino)
        {
            if (agent != null && agent.isOnNavMesh)
            {
                agent.SetDestination(destino);
            }
        }

        /* * *
         * MÉTODO: CambiarEstado
         * Transición limpia de estados reutilizando referencias existentes.
         */
        public void CambiarEstado(IEstado nuevoEstado)
        {
            _estadoActual?.Salir();
            _estadoActual = nuevoEstado;
            _estadoActual.Entrar();
        }

        /* * *
         * MÉTODO: ManejarCronometroRecuperacion
         * Controla el enfriamiento por Ticks.
         */
        private void ManejarCronometroRecuperacion()
        {
            _cronometroSesentaSeg += Time.deltaTime;

            if (_cronometroSesentaSeg >= 60f)
            {
                data.EjecutarTickDeRecuperacion(_nivelMiedoActual);
                _cronometroSesentaSeg = 0f;
            }
        }

        // --- MANEJADORES DE EVENTOS ---

        private void HandleSubirFase()
        {
            _nivelMiedoActual++;
            Debug.Log($"<color=orange>RADIO: El enemigo subió al Nivel {_nivelMiedoActual}</color>");
            // Nota: Aquí se cambiará al estado correspondiente cacheado en el futuro
        }

        private void HandleBajarFase()
        {
            _nivelMiedoActual = Mathf.Max(1, _nivelMiedoActual - 1);
            
            // Si bajamos al nivel base, volvemos a usar la referencia cacheada de Rastreo
            if (_nivelMiedoActual == 1) CambiarEstado(_estadoRastreo);
            
            Debug.Log($"<color=cyan>RADIO: El enemigo bajó al Nivel {_nivelMiedoActual}</color>");
        }

        /* * *
         * MÉTODO DE LIMPIEZA: OnDestroy
         * Se ejecuta si matamos al enemigo o cambiamos de escena.
         * Desconecta los cables de radio para no causar errores de memoria.
         */
        private void OnDestroy()
        {
            if (data != null)
            {
                data.OnSubirFase -= HandleSubirFase;
                data.OnBajarFase -= HandleBajarFase;
            }
        }
    }
}
```
</file>

<file path="Assets/_Scripts/Enums/GameEnums.cs">
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
</file>

<file path="Assets/_Scripts/Interfaces/IEstado.cs">
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
</file>

<file path="Assets/_Scripts/Player/PlayerController.cs">
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
</file>

<file path="Assets/_Scripts/States/EstadoRastreo.cs">
using UnityEngine;
using _Scripts.Interfaces;
using _Scripts.Brains;

namespace _Scripts.States
{
    /* * ESTADO: RASTREO (FASE 1)
     * El enemigo patrulla tranquilamente entre waypoints usando NavMeshAgent.
     * Es el estado más "ciego" y lento.
     */
    public class EstadoRastreo : IEstado
    {
        private readonly EnemyBrain _brain;
        private readonly float _velocidadRastreo = 2.5f;
        
        private int _indexWaypointActual = 0;
        private Vector3 _ultimoDestinoAsignado;
        private bool _iniciando = true;

        // El constructor nos permite recibir la referencia del cerebro
        public EstadoRastreo(EnemyBrain brain)
        {
            _brain = brain;
        }

        public void Entrar()
        {
            Debug.Log("<color=green>Enemigo entrando en fase de RASTREO.</color>");
            _brain.ActualizarVelocidad(_velocidadRastreo);
            _ultimoDestinoAsignado = Vector3.zero;
            _iniciando = true;
        }

        public void Ejecutar()
        {
            // 1. Aseguramos que la velocidad actual del agente sea la de rastreo
            _brain.ActualizarVelocidad(_velocidadRastreo);

            Vector3 destinoObjetivo;
            bool esSospecha = _brain.Data.IntuicionActual > 0.2f;

            if (esSospecha)
            {
                // Si la intuición es alta, vamos a investigar la posición sospechosa
                destinoObjetivo = _brain.Data.posicionSospechosa;
            }
            else
            {
                // Si no, volvemos a la patrulla normal
                if (_brain.Waypoints == null || _brain.Waypoints.Length == 0) return;
                destinoObjetivo = _brain.Waypoints[_indexWaypointActual].position;
            }

            // 2. OPTIMIZACIÓN CRÍTICA: Solo llamamos a SetDestination si el destino ha cambiado.
            // Si llamamos a SetDestination en cada frame (Update), el agente recalcula la ruta infinitamente y se queda quieto.
            if (_iniciando || Vector3.Distance(_ultimoDestinoAsignado, destinoObjetivo) > 0.1f)
            {
                _brain.MoverHacia(destinoObjetivo);
                _ultimoDestinoAsignado = destinoObjetivo;
                _iniciando = false;
            }

            // 3. CAMBIO DE WAYPOINT: Si estamos patrullando y llegamos físicamente cerca del punto, avanzamos
            if (!esSospecha)
            {
                float distanciaFisica = Vector3.Distance(_brain.transform.position, destinoObjetivo);
                if (distanciaFisica < 0.8f)
                {
                    _indexWaypointActual = (_indexWaypointActual + 1) % _brain.Waypoints.Length;
                }
            }
        }

        public void Exit() // Cumple la interfaz si requiere Salir en español
        {
            Salir();
        }

        public void Salir()
        {
            Debug.Log("Saliendo de RASTREO: El enemigo ha cambiado de estado.");
        }
    }
}
</file>

<file path="Assets/_Scripts/Systems/IntuicionSystem.cs">
using UnityEngine;
using System; // Necesario para usar los "Eventos" (La Radio)

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DICCIONARIO ACÚSTICO
 * Lo definimos aquí para que cualquier objeto del juego pueda
 * "etiquetar" su ruido antes de enviarlo al sistema.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
namespace _Scripts.Enums
{
    public enum PerfilAcustico
    {
        AgudoVocal, // Gritos, susurros, cristales rotos (Se ahogan rápido con la distancia)
        GraveFisico // Pasos pesados, muebles cayendo (Viajan lejos por el suelo/estructura)
    }
}

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * EL CORAZÓN DE DATOS (SISTEMA DE INTUICIÓN)
 * Actúa como un Analizador de Frecuencias Básico. Recibe paquetes 
 * de sonido, calcula su impacto real y alerta al enemigo.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
namespace _Scripts.Systems
{
    [CreateAssetMenu(fileName = "NuevaIntuicion", menuName = "Sistema/Intuicion Data")]
    public class IntuicionSystem : ScriptableObject
    {
        [Header("Datos de la Fase (Escala 0.0 a 1.0)")]
        [Tooltip("El medidor de peligro de la fase actual")]
        [SerializeField] private float intuicionActual = 0f;
        public float IntuicionActual => intuicionActual;

        [Header("Memoria de Posición")]
        [Tooltip("Última posición global donde se originó un ruido válido")]
        public Vector3 posicionSospechosa;

        // EVENTOS ("La Radio"): Avisan al enemigo cuando debe cambiar de fase
        public event Action OnSubirFase;
        public event Action OnBajarFase;

        /* * *
         * MÉTODO PARA SUBIR: LA PUERTA DE ENTRADA DEL RUIDO
         * Recibe el "Paquete de Sonido" (Volumen, Distancia y Tipo) y 
         * decide cuánto asusta realmente al monstruo.
         */
        // ReSharper disable Unity.PerformanceAnalysis
        public void ModificarIntuicion(float volumenOriginal, float distanciaAlMonstruo, _Scripts.Enums.PerfilAcustico perfil)
        {
            // Esta variable guardará el ruido final después de calcular la distancia
            float incrementoFinal = 0f;

            // 1. FILTRO MATEMÁTICO DE FRECUENCIAS (La magia del sonido)
            switch (perfil)
            { 
                case _Scripts.Enums.PerfilAcustico.AgudoVocal:
                    // REGLA AGUDA: Multiplicamos la distancia x 2.0
                    // Si el monstruo está a 10m, el divisor será 20. El sonido se vuelve diminuto muy rápido.
                    incrementoFinal = volumenOriginal / Mathf.Max(distanciaAlMonstruo * 2.0f, 0.1f);
                    break;

                case _Scripts.Enums.PerfilAcustico.GraveFisico:
                    // REGLA GRAVE: Multiplicamos la distancia x 0.3 (La reducimos)
                    // Si el monstruo está a 10m, el divisor será solo 3. La vibración llega casi intacta.
                    incrementoFinal = volumenOriginal / Mathf.Max(distanciaAlMonstruo * 0.3f, 0.1f);
                    break;
            }

            // 2. REGLA DEL 75% (Zona de Gracia)
            // Si el monstruo ya está muy alterado (>0.75), los ruidos le afectan 3 veces menos.
            // Así le damos al jugador una micro-oportunidad de escapar antes de pasar a Persecución.
            if (intuicionActual >= 0.75f && incrementoFinal > 0)
            {
                intuicionActual += (incrementoFinal / 3f);
            }
            else
            {
                intuicionActual += incrementoFinal;
            }

            // 3. REGLA DE CASCADA (SUBIDA)
            // Si el vaso se derrama, gritamos por la radio para que el EnemyBrain suba de fase.
            if (!(intuicionActual >= 1.0f)) return;
            intuicionActual = 0f; // Vaciamos el vaso para el nuevo nivel
            OnSubirFase?.Invoke(); // El '?' asegura que no haya error si nadie escucha
        }

        /* * *
         * TICK DE RECUPERACIÓN (Llamado por el EnemyBrain cada 60s)
         * Reduce el miedo con el tiempo. Es más difícil calmarlo en niveles altos.
         */
        public void EjecutarTickDeRecuperacion(int miedoLevel)
        {
            // FÓRMULA: Reducción = Intuición Actual * (1/3 * 1/Miedo)
            float factorEnfriamiento = (1f / 3f) * (1f / miedoLevel);
            float cantidadARestar = intuicionActual * factorEnfriamiento;

            intuicionActual -= cantidadARestar;

            // REGLA DE CASCADA (BAJADA)
            if (intuicionActual <= 0f)
            {
                // REGALO AL JUGADOR: Si el monstruo se calma y baja de fase, 
                // la nueva fase empieza en 0.7 (70%) en lugar de 1.0. No se olvida de ti del todo.
                intuicionActual = 0.7f; 
                OnBajarFase?.Invoke(); 
            }

            // Mantenemos el número entre 0.0 y 1.0 por seguridad del motor
            intuicionActual = Mathf.Clamp01(intuicionActual);
        }
    }
}
</file>

<file path="Assets/_Scripts/UI/UI_MenuManager.cs">
using _Scripts.Player;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
// LINEA NUEVA: Permite al script tener acceso directo a las herramientas de cámara de Cinemachine
using Cinemachine;

namespace _Scripts.UI
{
    // Asegura que este script inicialice después de los componentes base del juego para evitar NullReference
    [DefaultExecutionOrder(100)]
    public class UI_MenuManager : MonoBehaviour
    {
        // Enums: Una lista de estados lógicos excluyentes. El juego solo puede estar en UNO de estos a la vez.
        private enum MenuState
        {
            Gameplay,
            MenuAbierto
        }

        [Header("Input (Assets/Input/PlayerControls)")]
        [Tooltip("El contenedor de mapas de control (.inputactions) de nuestro proyecto")]
        [SerializeField]
        private InputActionAsset inputActionAsset;

        [Header("UI")] [Tooltip("El objeto raíz de la interfaz que contiene los botones")] [SerializeField]
        private GameObject menuPanel;

        [SerializeField] private TextMeshProUGUI tituloTexto;
        [SerializeField] private TextMeshProUGUI botonPrincipalTexto;

        [Header("Jugador")]
        [Tooltip("Referencia al script que controla el movimiento físico de nuestro personaje")]
        [SerializeField]
        private PlayerController playerController;

        [Header("Configuración de Cámara (Cinemachine)")]
        [Tooltip("Arrastra aquí tu Virtual Camera de Cinemachine para congelar la rotación del mouse en las pausas")]
        [SerializeField]
        private CinemachineInputProvider cameraProvider;

        [SerializeField] private CinemachineVirtualCamera virtualCamera; // <-- Cambiamos el tipo aquí
        private CinemachinePOV cameraPov; // Ahora es privado, no se arrastra

        // Cache de componentes de control para evitar búsquedas repetitivas en cada frame (Ahorro de CPU)
        private InputActionMap _gameplayMap;
        private InputActionMap _uiMap;
        private InputAction _pauseAction;
        private InputAction _unpauseAction;

        // Estado actual del menú diegético (P alterna Gameplay ↔ MenuAbierto).
        private MenuState _estado = MenuState.Gameplay;

        // Constantes: Textos fijos que no van a cambiar durante la ejecución del código
        

        private void Awake()
        {
            // Validación de seguridad: Si olvidaste arrastrar los controles en el inspector, el script se apaga solo
            if (inputActionAsset == null)
            {
                Debug.LogError("UI_MenuManager: Asigna el InputActionAsset PlayerControls en el Inspector.");
                enabled = false;
                return;
            }

            if (virtualCamera != null)
            {
                // Esto extrae el módulo interno POV de la cámara virtual
                cameraPov = virtualCamera.GetCinemachineComponent<CinemachinePOV>();

                if (cameraProvider == null)
                    cameraProvider = virtualCamera.GetComponent<CinemachineInputProvider>();
            }

            // 1. Buscamos y vinculamos los Action Maps definidos en tu archivo de inputs
            _gameplayMap = inputActionAsset.FindActionMap("Gameplay", true);
            _uiMap = inputActionAsset.FindActionMap("UI", true);

            // 2. Buscamos las acciones específicas mapeadas a la tecla P
            _pauseAction = _gameplayMap.FindAction("Pause", true);
            _unpauseAction = _uiMap.FindAction("Unpause", true);

            // 3. SUSCRIPCIÓN: Conectamos físicamente las acciones a nuestras funciones de C#
            _pauseAction.performed += OnPausePerformed;
            _unpauseAction.performed += OnUnpausePerformed;

            // Búsqueda automática: Si no arrastraste el script del jugador, lo intenta buscar en la escena por sí mismo
            if (playerController == null)
                playerController = FindObjectOfType<PlayerController>();

            if (cameraProvider == null)
                cameraProvider = FindObjectOfType<CinemachineInputProvider>();

            if (cameraPov == null && cameraProvider != null)
                cameraPov = cameraProvider.GetComponentInChildren<CinemachinePOV>();
        }

private void Start()
{
    if (menuPanel != null)
    {
        Button[] botones = menuPanel.GetComponentsInChildren<Button>(true);
        foreach (Button b in botones)
        {
            if (b.gameObject.name == "Boton_Jugar_Reanudar")
            {
                b.onClick.RemoveListener(OnClickJugarOReanudar);
                b.onClick.AddListener(OnClickJugarOReanudar);
                break;
            }
        }
    }

    EntrarModoGameplay();
}

        private void OnDestroy()
        {
            // BUENA PRÁCTICA: Rompemos la conexión con los eventos al destruir el objeto para evitar bugs de memoria
            if (_pauseAction != null)
                _pauseAction.performed -= OnPausePerformed;
            if (_unpauseAction != null)
                _unpauseAction.performed -= OnUnpausePerformed;
        }

        // --- MÉTODOS PÚBLICOS PARA LOS BOTONES (EVENTOS ONCLICK) ---

        public void OnClickJugarOReanudar()
        {
            if (_estado == MenuState.MenuAbierto)
                EntrarModoGameplay();
        }

        public void OnClickSalir()
        {
            // Compilación condicional: Detiene el juego de forma correcta según el entorno
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Detiene el Play Mode dentro de Unity
#else
            Application.Quit(); // Cierra la aplicación ejecutable (.exe o binario de Linux)
#endif
        }

        // --- RESPUESTAS A LOS INPUTS FÍSICOS (TECLA P) ---

        private void OnPausePerformed(InputAction.CallbackContext context)
        {
            // Filtro de seguridad: Si la acción no se completó o no estamos jugando, ignora el teclazo
            if (!context.performed || _estado != MenuState.Gameplay)
                return;

            EntrarModoMenuAbierto();
        }

        private void OnUnpausePerformed(InputAction.CallbackContext context)
        {
            if (!context.performed || _estado != MenuState.MenuAbierto)
                return;

            EntrarModoGameplay();
        }

        // --- MANEJADORES DE ESTADO (MÁQUINA DE ESTADOS) ---

        private void EntrarModoGameplay()
        {
            _estado = MenuState.Gameplay;

            MostrarMenu(false);
            ConfigurarCursor(false);
            ActivarMapaGameplay();
            ConfigurarJugador(true);
            ConfigurarCamara(true);
        }

private void EntrarModoMenuAbierto()
{
    _estado = MenuState.MenuAbierto;

    MostrarMenu(true);
    // ConfigurarTextos(TituloMenu, TextoCerrar); // Eliminado para no sobreescribir el diseño del usuario
    ConfigurarCursor(true);
    ActivarMapaUI();
    ConfigurarJugador(false);
    ConfigurarCamara(false);
}

        // --- SUB-FUNCIONES AUXILIARES DE CONFIGURACIÓN ---

        private void ActivarMapaUI()
        {
            _gameplayMap.Disable(); // Desactiva el mapa de juego (WASD deja de responder instantáneamente)
            _uiMap.Enable(); // Activa el mapa de UI (Permite que funcione la tecla Unpause)
        }

        private void ActivarMapaGameplay()
        {
            _uiMap.Disable(); // Desactiva el mapa de UI
            _gameplayMap.Enable(); // Activa el mapa de juego activo
        }

        private void MostrarMenu(bool visible)
        {
            if (menuPanel != null)
                menuPanel.SetActive(visible); // Enciende o apaga el GameObject completo en la jerarquía
        }

        private void ConfigurarTextos(string titulo, string botonPrincipal)
        {
            if (tituloTexto != null)
                tituloTexto.text = titulo;
            if (botonPrincipalTexto != null)
                botonPrincipalTexto.text = botonPrincipal;
        }

        private static void ConfigurarCursor(bool menuActivo)
        {
            // Si el menú está activo, el cursor se libera. Si no, se bloquea al centro de la pantalla.
            Cursor.lockState = menuActivo ? CursorLockMode.None : CursorLockMode.Locked;
            Cursor.visible = menuActivo; // Alterna la visibilidad del puntero gráfico
        }

        private void ConfigurarJugador(bool activo)
        {
            if (playerController != null)
                playerController.SetControlBlocked(!activo);
        }

        private void ConfigurarCamara(bool activo)
        {
            if (cameraProvider != null)
                cameraProvider.enabled = activo;

            if (cameraPov == null)
                return;

            var horizontal = cameraPov.m_HorizontalAxis;
            horizontal.m_InputAxisValue = 0f;
            cameraPov.m_HorizontalAxis = horizontal;

            var vertical = cameraPov.m_VerticalAxis;
            vertical.m_InputAxisValue = 0f;
            cameraPov.m_VerticalAxis = vertical;

            if (activo && Mouse.current != null)
                InputSystem.ResetDevice(Mouse.current);
        }
    }
}
</file>

<file path="Assets/Input/PlayerControls.cs">
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.14.2
//     from Assets/Input/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

/// <summary>
/// Provides programmatic access to <see cref="InputActionAsset" />, <see cref="InputActionMap" />, <see cref="InputAction" /> and <see cref="InputControlScheme" /> instances defined in asset "Assets/Input/PlayerControls.inputactions".
/// </summary>
/// <remarks>
/// This class is source generated and any manual edits will be discarded if the associated asset is reimported or modified.
/// </remarks>
/// <example>
/// <code>
/// using namespace UnityEngine;
/// using UnityEngine.InputSystem;
///
/// // Example of using an InputActionMap named "Player" from a UnityEngine.MonoBehaviour implementing callback interface.
/// public class Example : MonoBehaviour, MyActions.IPlayerActions
/// {
///     private MyActions_Actions m_Actions;                  // Source code representation of asset.
///     private MyActions_Actions.PlayerActions m_Player;     // Source code representation of action map.
///
///     void Awake()
///     {
///         m_Actions = new MyActions_Actions();              // Create asset object.
///         m_Player = m_Actions.Player;                      // Extract action map object.
///         m_Player.AddCallbacks(this);                      // Register callback interface IPlayerActions.
///     }
///
///     void OnDestroy()
///     {
///         m_Actions.Dispose();                              // Destroy asset object.
///     }
///
///     void OnEnable()
///     {
///         m_Player.Enable();                                // Enable all actions within map.
///     }
///
///     void OnDisable()
///     {
///         m_Player.Disable();                               // Disable all actions within map.
///     }
///
///     #region Interface implementation of MyActions.IPlayerActions
///
///     // Invoked when "Move" action is either started, performed or canceled.
///     public void OnMove(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnMove: {context.ReadValue&lt;Vector2&gt;()}");
///     }
///
///     // Invoked when "Attack" action is either started, performed or canceled.
///     public void OnAttack(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnAttack: {context.ReadValue&lt;float&gt;()}");
///     }
///
///     #endregion
/// }
/// </code>
/// </example>
public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    /// <summary>
    /// Provides access to the underlying asset instance.
    /// </summary>
    public InputActionAsset asset { get; }

    /// <summary>
    /// Constructs a new instance.
    /// </summary>
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""version"": 1,
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""7abfd263-bb92-434a-a6e1-384bbda27d16"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9c18749d-7a66-4e7c-a1f1-fd577b715664"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""eb10d26d-9ee2-4ae3-9e82-8874a4c3e951"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""9c4689f5-077d-4e7b-a95f-e7990376191c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""afeb5324-c85c-4351-bd99-5d6703cdb2af"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""ae16035a-5f2b-41de-a7f3-cb7b3d469034"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fa8f4d5d-a1bb-490e-9f42-760d0b8b0da7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a662e232-7817-4fbe-81c8-95daa41d475e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5114778e-34cb-4c5b-8508-c3b7d0706900"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b35f0a8f-0fe1-4b56-9e31-453e95fe1794"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""405aa2a3-f408-47d6-ba6f-b9d19c015576"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""efc3f80b-b584-4a72-9d00-4cb97d2cd1c9"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7aff7f1f-414f-47d6-a334-fedd5f7e544f"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1064827c-1861-4165-ab61-3cdd244c9d32"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""355006be-f334-47af-834a-315147fdb808"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""ca338fad-e951-45db-b139-b0296a2f9796"",
            ""actions"": [
                {
                    ""name"": ""Unpause"",
                    ""type"": ""Button"",
                    ""id"": ""550a9331-cb76-441c-9cdb-d002470bcb2b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4f82ebaa-9a03-4b18-898a-ba952e7c7bea"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Unpause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Sprint = m_Gameplay.FindAction("Sprint", throwIfNotFound: true);
        m_Gameplay_Crouch = m_Gameplay.FindAction("Crouch", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
        m_Gameplay_Look = m_Gameplay.FindAction("Look", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Unpause = m_UI.FindAction("Unpause", throwIfNotFound: true);
    }

    ~@PlayerControls()
    {
        UnityEngine.Debug.Assert(!m_Gameplay.enabled, "This will cause a leak and performance issues, PlayerControls.Gameplay.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_UI.enabled, "This will cause a leak and performance issues, PlayerControls.UI.Disable() has not been called.");
    }

    /// <summary>
    /// Destroys this asset and all associated <see cref="InputAction"/> instances.
    /// </summary>
    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindingMask" />
    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.devices" />
    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.controlSchemes" />
    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Contains(InputAction)" />
    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.GetEnumerator()" />
    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    /// <inheritdoc cref="IEnumerable.GetEnumerator()" />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Enable()" />
    public void Enable()
    {
        asset.Enable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Disable()" />
    public void Disable()
    {
        asset.Disable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindings" />
    public IEnumerable<InputBinding> bindings => asset.bindings;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindAction(string, bool)" />
    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindBinding(InputBinding, out InputAction)" />
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Sprint;
    private readonly InputAction m_Gameplay_Crouch;
    private readonly InputAction m_Gameplay_Pause;
    private readonly InputAction m_Gameplay_Look;
    /// <summary>
    /// Provides access to input actions defined in input action map "Gameplay".
    /// </summary>
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Move".
        /// </summary>
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Sprint".
        /// </summary>
        public InputAction @Sprint => m_Wrapper.m_Gameplay_Sprint;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Crouch".
        /// </summary>
        public InputAction @Crouch => m_Wrapper.m_Gameplay_Crouch;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Pause".
        /// </summary>
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/Look".
        /// </summary>
        public InputAction @Look => m_Wrapper.m_Gameplay_Look;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="GameplayActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="GameplayActions" />
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @Crouch.started += instance.OnCrouch;
            @Crouch.performed += instance.OnCrouch;
            @Crouch.canceled += instance.OnCrouch;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="GameplayActions" />
        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @Crouch.started -= instance.OnCrouch;
            @Crouch.performed -= instance.OnCrouch;
            @Crouch.canceled -= instance.OnCrouch;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />.
        /// </summary>
        /// <seealso cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />
        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="GameplayActions.AddCallbacks(IGameplayActions)" />
        /// <seealso cref="GameplayActions.RemoveCallbacks(IGameplayActions)" />
        /// <seealso cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />
        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="GameplayActions" /> instance referencing this action map.
    /// </summary>
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_Unpause;
    /// <summary>
    /// Provides access to input actions defined in input action map "UI".
    /// </summary>
    public struct UIActions
    {
        private @PlayerControls m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public UIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "UI/Unpause".
        /// </summary>
        public InputAction @Unpause => m_Wrapper.m_UI_Unpause;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="UIActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="UIActions" />
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @Unpause.started += instance.OnUnpause;
            @Unpause.performed += instance.OnUnpause;
            @Unpause.canceled += instance.OnUnpause;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="UIActions" />
        private void UnregisterCallbacks(IUIActions instance)
        {
            @Unpause.started -= instance.OnUnpause;
            @Unpause.performed -= instance.OnUnpause;
            @Unpause.canceled -= instance.OnUnpause;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="UIActions.UnregisterCallbacks(IUIActions)" />.
        /// </summary>
        /// <seealso cref="UIActions.UnregisterCallbacks(IUIActions)" />
        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="UIActions.AddCallbacks(IUIActions)" />
        /// <seealso cref="UIActions.RemoveCallbacks(IUIActions)" />
        /// <seealso cref="UIActions.UnregisterCallbacks(IUIActions)" />
        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="UIActions" /> instance referencing this action map.
    /// </summary>
    public UIActions @UI => new UIActions(this);
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "Gameplay" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="GameplayActions.AddCallbacks(IGameplayActions)" />
    /// <seealso cref="GameplayActions.RemoveCallbacks(IGameplayActions)" />
    public interface IGameplayActions
    {
        /// <summary>
        /// Method invoked when associated input action "Move" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnMove(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Sprint" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnSprint(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Crouch" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnCrouch(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Pause" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPause(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "Look" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnLook(InputAction.CallbackContext context);
    }
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "UI" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="UIActions.AddCallbacks(IUIActions)" />
    /// <seealso cref="UIActions.RemoveCallbacks(IUIActions)" />
    public interface IUIActions
    {
        /// <summary>
        /// Method invoked when associated input action "Unpause" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnUnpause(InputAction.CallbackContext context);
    }
}
</file>

<file path="Assets/Input/PlayerControls.inputactions">
{
    "version": 1,
    "name": "PlayerControls",
    "maps": [
        {
            "name": "Gameplay",
            "id": "7abfd263-bb92-434a-a6e1-384bbda27d16",
            "actions": [
                {
                    "name": "Move",
                    "type": "Value",
                    "id": "9c18749d-7a66-4e7c-a1f1-fd577b715664",
                    "expectedControlType": "Vector2",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": true
                },
                {
                    "name": "Sprint",
                    "type": "Button",
                    "id": "eb10d26d-9ee2-4ae3-9e82-8874a4c3e951",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Crouch",
                    "type": "Button",
                    "id": "9c4689f5-077d-4e7b-a95f-e7990376191c",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Pause",
                    "type": "Button",
                    "id": "afeb5324-c85c-4351-bd99-5d6703cdb2af",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Look",
                    "type": "Value",
                    "id": "ae16035a-5f2b-41de-a7f3-cb7b3d469034",
                    "expectedControlType": "Vector2",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": true
                }
            ],
            "bindings": [
                {
                    "name": "2D Vector",
                    "id": "fa8f4d5d-a1bb-490e-9f42-760d0b8b0da7",
                    "path": "2DVector",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "up",
                    "id": "a662e232-7817-4fbe-81c8-95daa41d475e",
                    "path": "<Keyboard>/w",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "down",
                    "id": "5114778e-34cb-4c5b-8508-c3b7d0706900",
                    "path": "<Keyboard>/s",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "left",
                    "id": "b35f0a8f-0fe1-4b56-9e31-453e95fe1794",
                    "path": "<Keyboard>/a",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "right",
                    "id": "405aa2a3-f408-47d6-ba6f-b9d19c015576",
                    "path": "<Keyboard>/d",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Move",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "",
                    "id": "efc3f80b-b584-4a72-9d00-4cb97d2cd1c9",
                    "path": "<XInputController>/leftTrigger",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Sprint",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "7aff7f1f-414f-47d6-a334-fedd5f7e544f",
                    "path": "<XInputController>/leftStick/down",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Crouch",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "1064827c-1861-4165-ab61-3cdd244c9d32",
                    "path": "<Keyboard>/p",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Pause",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "355006be-f334-47af-834a-315147fdb808",
                    "path": "<Mouse>/delta",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Look",
                    "isComposite": false,
                    "isPartOfComposite": false
                }
            ]
        },
        {
            "name": "UI",
            "id": "ca338fad-e951-45db-b139-b0296a2f9796",
            "actions": [
                {
                    "name": "Unpause",
                    "type": "Button",
                    "id": "550a9331-cb76-441c-9cdb-d002470bcb2b",
                    "expectedControlType": "",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                }
            ],
            "bindings": [
                {
                    "name": "",
                    "id": "4f82ebaa-9a03-4b18-898a-ba952e7c7bea",
                    "path": "<Keyboard>/p",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Unpause",
                    "isComposite": false,
                    "isPartOfComposite": false
                }
            ]
        }
    ],
    "controlSchemes": []
}
</file>

<file path="Assets/_Scripts/Brains/EnemyBrain.cs">
using UnityEngine;
using UnityEngine.AI; // Acceso al sistema de navegación
using UnityEngine.SceneManagement; // Importado para reiniciar la escena
using _Scripts.Systems;     // Acceso al corazón de datos (ScriptableObject)
using _Scripts.Interfaces;   // Acceso al contrato IEstado
using _Scripts.States;       // Acceso a las lógicas de estado (Rastreo, Sigilo...)

namespace _Scripts.Brains
{
    /* * * CLASE: EnemyBrain
     * DESCRIPCIÓN: Actúa como el "Cuerpo" y "Contexto" de la IA (Hardware). 
     * No decide qué hacer por sí mismo, sino que delega esa tarea a un objeto IEstado.
     * Mantiene vivo el cronómetro de 60s para el enfriamiento.
     * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
    public class EnemyBrain : MonoBehaviour
    {
        [Header("Referencias de Datos")]
        [Tooltip("El archivo de datos (SO) que compartimos con el jugador y el sistema")]
        [SerializeField] private IntuicionSystem data;
        public IntuicionSystem Data => data; // Propiedad pública para los Estados
        
        [Header("Configuración de Movimiento y Navegación")]
        [Tooltip("Agente de navegación del enemigo")]
        [SerializeField] private NavMeshAgent agent;
        public NavMeshAgent Agent => agent; // Propiedad pública para los Estados

        [Tooltip("Velocidad de traslación física base.")]
        [SerializeField] private float velocidadBase = 3.5f;
        
        [Tooltip("Puntos de patrulla para el movimiento perpetuo.")]
        [SerializeField] private Transform[] waypoints; 
        public Transform[] Waypoints => waypoints; // Propiedad pública para los Estados
        

        [Header("Instintos Base")]
        [Tooltip("Transform del jugador para el Olfato")]
        [SerializeField] private Transform transformJugador;
        [Tooltip("Distancia a la que el enemigo mata instantáneamente")]
        [SerializeField] private float distanciaOlfato = 1.5f;

        /* LÓGICA DE MÁQUINA DE ESTADOS e OPTIMIZACIÓN (CACHING) */
        private IEstado _estadoActual; 
        
        // Cacheamos las instancias de los estados para evitar asignaciones de memoria (GC Allocations)
        private IEstado _estadoRastreo;

        [Header("Reloj de Recuperación")]
        // Contador de segundos para llegar al minuto de enfriamiento
        private float _cronometroSesentaSeg = 0f;
        
        // Guardamos el nivel de fase actual (1, 2, 3...) para pasárselo al SO en el Tick
        private int _nivelMiedoActual = 1;

        /* * *
         * MÉTODO: Start
         * Se ejecuta al nacer. Configuramos los estados cacheando referencias y el estado inicial.
         */
        private void Start()
        {
            if (!data) return; // Si no hay datos sal de la función.
            
            // Verificación y asignación automática de componentes obligatorios
            if (!agent) agent = GetComponent<NavMeshAgent>();
            if (!agent) Debug.LogError("EnemyBrain: Falta el componente NavMeshAgent.");
            if (!transformJugador) Debug.LogError("EnemyBrain: Falta asignar el Transform del Jugador para el Olfato.");

            // Suscripción al SO
            data.OnSubirFase += HandleSubirFase;
            data.OnBajarFase += HandleBajarFase;
                
            // OPTIMIZACIÓN: Instanciamos los estados una sola vez en el inicio
            _estadoRastreo = new EstadoRastreo(this);
            
            // ESTADO INICIAL: Iniciamos usando la referencia cacheada
            CambiarEstado(_estadoRastreo);
        }

        /* * *
         * MÉTODO: Update
         * Ejecución por frame. Mantenemos el pulso de los relojes y la máquina de estados.
         */
        private void Update()
        {
            if (!data) return;

            // 1. CONDICIÓN GLOBAL (OLFATO): Instinto base primario
            if (transformJugador != null && Vector3.Distance(transform.position, transformJugador.position) <= distanciaOlfato)
            {
                EjecutarMuertePorOlfato();
                return;
            }

            // 2. Manejamos el tiempo para el enfriamiento de 60s
            ManejarCronometroRecuperacion();
            
            // 3. EJECUCIÓN DEL ESTADO: El estado controla la lógica en este frame
            _estadoActual?.Ejecutar(); 
        }

        private void EjecutarMuertePorOlfato()
        {
            Debug.Log("<color=red>¡JUGADOR ASESINADO POR OLFATO! Reiniciando escena...</color>");
            
            // Detenemos el movimiento físico inmediatamente
            if (agent != null && agent.isOnNavMesh)
            {
                agent.isStopped = true;
            }

            // Reiniciamos la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        /* * *
         * MÉTODO: ActualizarVelocidad
         * Función pública para que los ESTADOS puedan cambiar la velocidad del NavMeshAgent.
         */
        public void ActualizarVelocidad(float nuevaVelocidad)
        {
            velocidadBase = nuevaVelocidad;
            if (agent != null)
            {
                agent.speed = nuevaVelocidad;
            }
        }

        /* * *
         * MÉTODO: MoverHacia
         * Función pública para que los ESTADOS ordenen el destino al NavMeshAgent.
         */
        public void MoverHacia(Vector3 destino)
        {
            if (agent != null && agent.isOnNavMesh)
            {
                agent.SetDestination(destino);
            }
        }

        /* * *
         * MÉTODO: CambiarEstado
         * Transición limpia de estados reutilizando referencias existentes.
         */
        public void CambiarEstado(IEstado nuevoEstado)
        {
            _estadoActual?.Salir();
            _estadoActual = nuevoEstado;
            _estadoActual.Entrar();
        }

        /* * *
         * MÉTODO: ManejarCronometroRecuperacion
         * Controla el enfriamiento por Ticks.
         */
        private void ManejarCronometroRecuperacion()
        {
            _cronometroSesentaSeg += Time.deltaTime;

            if (_cronometroSesentaSeg >= 60f)
            {
                data.EjecutarTickDeRecuperacion(_nivelMiedoActual);
                _cronometroSesentaSeg = 0f;
            }
        }

        // --- MANEJADORES DE EVENTOS ---

        private void HandleSubirFase()
        {
            _nivelMiedoActual++;
            Debug.Log($"<color=orange>RADIO: El enemigo subió al Nivel {_nivelMiedoActual}</color>");
            // Nota: Aquí se cambiará al estado correspondiente cacheado en el futuro
        }

        private void HandleBajarFase()
        {
            _nivelMiedoActual = Mathf.Max(1, _nivelMiedoActual - 1);
            
            // Si bajamos al nivel base, volvemos a usar la referencia cacheada de Rastreo
            if (_nivelMiedoActual == 1) CambiarEstado(_estadoRastreo);
            
            Debug.Log($"<color=cyan>RADIO: El enemigo bajó al Nivel {_nivelMiedoActual}</color>");
        }

        /* * *
         * MÉTODO DE LIMPIEZA: OnDestroy
         * Se ejecuta si matamos al enemigo o cambiamos de escena.
         * Desconecta los cables de radio para no causar errores de memoria.
         */
        private void OnDestroy()
        {
            if (data != null)
            {
                data.OnSubirFase -= HandleSubirFase;
                data.OnBajarFase -= HandleBajarFase;
            }
        }
    }
}
</file>

</files>
````

## File: Assets/_Scripts/Brains/EnemyBrain.cs
````csharp
using UnityEngine;
using UnityEngine.AI; // Acceso al sistema de navegación
using UnityEngine.SceneManagement; // Importado para reiniciar la escena
using _Scripts.Systems;     // Acceso al corazón de datos (ScriptableObject)
using _Scripts.Interfaces;   // Acceso al contrato IEstado
using _Scripts.States;       // Acceso a las lógicas de estado (Rastreo, Sigilo...)

namespace _Scripts.Brains
{
    /* * * CLASE: EnemyBrain
     * DESCRIPCIÓN: Actúa como el "Cuerpo" y "Contexto" de la IA (Hardware). 
     * No decide qué hacer por sí mismo, sino que delega esa tarea a un objeto IEstado.
     * Mantiene vivo el cronómetro de 60s para el enfriamiento.
     * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
    public class EnemyBrain : MonoBehaviour
    {
        [Header("Referencias de Datos")]
        [Tooltip("El archivo de datos (SO) que compartimos con el jugador y el sistema")]
        [SerializeField] private IntuicionSystem data;
        public IntuicionSystem Data => data; // Propiedad pública para los Estados
        
        [Header("Configuración de Movimiento y Navegación")]
        [Tooltip("Agente de navegación del enemigo")]
        [SerializeField] private NavMeshAgent agent;
        public NavMeshAgent Agent => agent; // Propiedad pública para los Estados

        [Tooltip("Velocidad de traslación física base.")]
        [SerializeField] private float velocidadBase = 3.5f;
        
        [Tooltip("Puntos de patrulla para el movimiento perpetuo.")]
        [SerializeField] private Transform[] waypoints; 
        public Transform[] Waypoints => waypoints; // Propiedad pública para los Estados
        

        [Header("Instintos Base")]
        [Tooltip("Transform del jugador para el Olfato")]
        [SerializeField] private Transform transformJugador;
        [Tooltip("Distancia a la que el enemigo mata instantáneamente")]
        [SerializeField] private float distanciaOlfato = 1.5f;

        /* LÓGICA DE MÁQUINA DE ESTADOS e OPTIMIZACIÓN (CACHING) */
        private IEstado _estadoActual; 
        
        // Cacheamos las instancias de los estados para evitar asignaciones de memoria (GC Allocations)
        private IEstado _estadoRastreo;
        private IEstado _estadoSigilo;
        private IEstado _estadoPersecucion;
        private IEstado _estadoSedDeSangre;

        [Header("Reloj de Recuperación")]
        // Contador de segundos para llegar al minuto de enfriamiento
        private float _cronometroSesentaSeg = 0f;
        
        // Guardamos el nivel de fase actual (1, 2, 3...) para pasárselo al SO en el Tick
        private int _nivelMiedoActual = 1;

        /* * *
         * MÉTODO: Start
         * Se ejecuta al nacer. Configuramos los estados cacheando referencias y el estado inicial.
         */
        private void Start()
        {
            if (!data) return; // Si no hay datos sal de la función.
            
            // Verificación y asignación automática de componentes obligatorios
            if (!agent) agent = GetComponent<NavMeshAgent>();
            if (!agent) Debug.LogError("EnemyBrain: Falta el componente NavMeshAgent.");
            if (!transformJugador) Debug.LogError("EnemyBrain: Falta asignar el Transform del Jugador para el Olfato.");

            // Suscripción al SO
            data.OnSubirFase += HandleSubirFase;
            data.OnBajarFase += HandleBajarFase;
                
            // OPTIMIZACIÓN: Instanciamos los estados una sola vez en el inicio
            _estadoRastreo = new EstadoRastreo(this);
            _estadoSigilo = new EstadoSigilo(this);
            _estadoPersecucion = new EstadoPersecucion(this);
            _estadoSedDeSangre = new EstadoSedDeSangre(this);
            
            // ESTADO INICIAL: Iniciamos usando la referencia cacheada
            CambiarEstado(_estadoRastreo);
        }

        /* * *
         * MÉTODO: Update
         * Ejecución por frame. Mantenemos el pulso de los relojes y la máquina de estados.
         */
        private void Update()
        {
            if (!data) return;

            // 1. CONDICIÓN GLOBAL (OLFATO): Instinto base primario
            if (transformJugador != null && Vector3.Distance(transform.position, transformJugador.position) <= distanciaOlfato)
            {
                EjecutarMuertePorOlfato();
                return;
            }

            // 2. Manejamos el tiempo para el enfriamiento de 60s
            ManejarCronometroRecuperacion();
            
            // 3. EJECUCIÓN DEL ESTADO: El estado controla la lógica en este frame
            _estadoActual?.Ejecutar(); 
        }

        private void EjecutarMuertePorOlfato()
        {
            Debug.Log("<color=red>¡JUGADOR ASESINADO POR OLFATO! Reiniciando escena...</color>");
            
            // Detenemos el movimiento físico inmediatamente
            if (agent != null && agent.isOnNavMesh)
            {
                agent.isStopped = true;
            }

            // Reiniciamos la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        /* * *
         * MÉTODO: ActualizarVelocidad
         * Función pública para que los ESTADOS puedan cambiar la velocidad del NavMeshAgent.
         */
        public void ActualizarVelocidad(float nuevaVelocidad)
        {
            velocidadBase = nuevaVelocidad;
            if (agent != null)
            {
                agent.speed = nuevaVelocidad;
            }
        }

        /* * *
         * MÉTODO: MoverHacia
         * Función pública para que los ESTADOS ordenen el destino al NavMeshAgent.
         */
        public void MoverHacia(Vector3 destino)
        {
            if (agent != null && agent.isOnNavMesh)
            {
                agent.SetDestination(destino);
            }
        }

        /* * *
         * MÉTODO: CambiarEstado
         * Transición limpia de estados reutilizando referencias existentes.
         */
        public void CambiarEstado(IEstado nuevoEstado)
        {
            _estadoActual?.Salir();
            _estadoActual = nuevoEstado;
            _estadoActual.Entrar();
        }

        /* * *
         * MÉTODO: ManejarCronometroRecuperacion
         * Controla el enfriamiento por Ticks.
         */
        private void ManejarCronometroRecuperacion()
        {
            _cronometroSesentaSeg += Time.deltaTime;

            if (_cronometroSesentaSeg >= 60f)
            {
                data.EjecutarTickDeRecuperacion(_nivelMiedoActual);
                _cronometroSesentaSeg = 0f;
            }
        }

        // --- MANEJADORES DE EVENTOS ---

        private void HandleSubirFase()
        {
            _nivelMiedoActual = Mathf.Clamp(_nivelMiedoActual + 1, 1, 4);
            Debug.Log($"<color=orange>RADIO: El enemigo subió al Nivel {_nivelMiedoActual}</color>");
            ActualizarEstadoPorNivel();
        }

        private void HandleBajarFase()
        {
            _nivelMiedoActual = Mathf.Clamp(_nivelMiedoActual - 1, 1, 4);
            Debug.Log($"<color=cyan>RADIO: El enemigo bajó al Nivel {_nivelMiedoActual}</color>");
            ActualizarEstadoPorNivel();
        }

        private void ActualizarEstadoPorNivel()
        {
            switch (_nivelMiedoActual)
            {
                case 1:
                    CambiarEstado(_estadoRastreo);
                    break;
                case 2:
                    CambiarEstado(_estadoSigilo);
                    break;
                case 3:
                    CambiarEstado(_estadoPersecucion);
                    break;
                case 4:
                    CambiarEstado(_estadoSedDeSangre);
                    break;
            }
        }

        /* * *
         * MÉTODO DE LIMPIEZA: OnDestroy
         * Se ejecuta si matamos al enemigo o cambiamos de escena.
         * Desconecta los cables de radio para no causar errores de memoria.
         */
        private void OnDestroy()
        {
            if (data != null)
            {
                data.OnSubirFase -= HandleSubirFase;
                data.OnBajarFase -= HandleBajarFase;
            }
        }
    }
}
````

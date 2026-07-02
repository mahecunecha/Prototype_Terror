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

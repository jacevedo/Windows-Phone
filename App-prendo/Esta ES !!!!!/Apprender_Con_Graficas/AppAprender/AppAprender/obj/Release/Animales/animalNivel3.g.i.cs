﻿#pragma checksum "C:\Users\Jaime Acevedo\Documents\Visual Studio 2012\Projects\App-prendo\Esta ES !!!!!\Apprender_Con_Graficas\AppAprender\AppAprender\Animales\animalNivel3.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CFE82B203AFFCF3453A9FEA2158948D7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18051
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace AppAprender.Animales {
    
    
    public partial class animalNivel3 : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard Storyboard1;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Media.Animation.Storyboard StoryboardCorrecto;
        
        internal System.Windows.Media.Animation.Storyboard StoryboardIncorrecto;
        
        internal System.Windows.Media.Animation.Storyboard StoryboardIncorrectoBack;
        
        internal System.Windows.Controls.Button alternativa1;
        
        internal System.Windows.Controls.Button alternativa2;
        
        internal System.Windows.Controls.Button alternativa3;
        
        internal System.Windows.Controls.Image image;
        
        internal System.Windows.Controls.MediaElement sound;
        
        internal System.Windows.Controls.Image correcto;
        
        internal System.Windows.Controls.Image incorrecto;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/AppAprender;component/Animales/animalNivel3.xaml", System.UriKind.Relative));
            this.Storyboard1 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Storyboard1")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.StoryboardCorrecto = ((System.Windows.Media.Animation.Storyboard)(this.FindName("StoryboardCorrecto")));
            this.StoryboardIncorrecto = ((System.Windows.Media.Animation.Storyboard)(this.FindName("StoryboardIncorrecto")));
            this.StoryboardIncorrectoBack = ((System.Windows.Media.Animation.Storyboard)(this.FindName("StoryboardIncorrectoBack")));
            this.alternativa1 = ((System.Windows.Controls.Button)(this.FindName("alternativa1")));
            this.alternativa2 = ((System.Windows.Controls.Button)(this.FindName("alternativa2")));
            this.alternativa3 = ((System.Windows.Controls.Button)(this.FindName("alternativa3")));
            this.image = ((System.Windows.Controls.Image)(this.FindName("image")));
            this.sound = ((System.Windows.Controls.MediaElement)(this.FindName("sound")));
            this.correcto = ((System.Windows.Controls.Image)(this.FindName("correcto")));
            this.incorrecto = ((System.Windows.Controls.Image)(this.FindName("incorrecto")));
        }
    }
}


﻿#pragma checksum "C:\Users\Jaime Acevedo\Documents\Visual Studio 2012\Projects\FarmaciaTurno\FarmaciaTurno\Farmacias.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "185DA9E689CE81694C52083BC279527A"
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


namespace FarmaciaTurno {
    
    
    public partial class Farmacias : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal System.Windows.Controls.ScrollViewer mainScrollViewer;
        
        internal System.Windows.Controls.StackPanel panelCentral;
        
        internal System.Windows.Controls.TextBlock txtCargando;
        
        internal System.Windows.Controls.TextBlock txtEspere;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FarmaciaTurno;component/Farmacias.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.mainScrollViewer = ((System.Windows.Controls.ScrollViewer)(this.FindName("mainScrollViewer")));
            this.panelCentral = ((System.Windows.Controls.StackPanel)(this.FindName("panelCentral")));
            this.txtCargando = ((System.Windows.Controls.TextBlock)(this.FindName("txtCargando")));
            this.txtEspere = ((System.Windows.Controls.TextBlock)(this.FindName("txtEspere")));
        }
    }
}


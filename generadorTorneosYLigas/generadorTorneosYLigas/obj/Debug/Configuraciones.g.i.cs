﻿#pragma checksum "C:\Users\Jaime Acevedo\documents\visual studio 2012\Projects\generadorTorneosYLigas\generadorTorneosYLigas\Configuraciones.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7E0E72CAD8C5E3D0F3B2B632AF62E68C"
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


namespace generadorTorneosYLigas {
    
    
    public partial class Configuraciones : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal System.Windows.Controls.TextBox txtCantParticipantes;
        
        internal System.Windows.Controls.ScrollViewer mainScrollViewer;
        
        internal System.Windows.Controls.StackPanel stackNombres;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/generadorTorneosYLigas;component/Configuraciones.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.txtCantParticipantes = ((System.Windows.Controls.TextBox)(this.FindName("txtCantParticipantes")));
            this.mainScrollViewer = ((System.Windows.Controls.ScrollViewer)(this.FindName("mainScrollViewer")));
            this.stackNombres = ((System.Windows.Controls.StackPanel)(this.FindName("stackNombres")));
        }
    }
}


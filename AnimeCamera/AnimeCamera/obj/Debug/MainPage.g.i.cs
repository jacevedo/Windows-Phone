﻿#pragma checksum "C:\Users\Jaime Acevedo\Documents\Visual Studio 2012\Projects\AnimeCamera\AnimeCamera\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9C55A1CEBE45299714D85652E4F43944"
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


namespace AnimeCamera {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Canvas LayoutRoot;
        
        internal System.Windows.Controls.Canvas viewfinderCanvas;
        
        internal System.Windows.Media.VideoBrush viewfinderBrush;
        
        internal System.Windows.Media.CompositeTransform viewfinderTransform;
        
        internal System.Windows.Controls.Image imgFoto;
        
        internal System.Windows.Media.CompositeTransform transformImage;
        
        internal System.Windows.Controls.Canvas controlArriba;
        
        internal System.Windows.Shapes.Ellipse btnFlash;
        
        internal System.Windows.Shapes.Ellipse btnCambiarCamara;
        
        internal System.Windows.Shapes.Ellipse btnTimer;
        
        internal System.Windows.Shapes.Ellipse btnSacaNuevaFoto;
        
        internal System.Windows.Shapes.Ellipse btnAceptar;
        
        internal System.Windows.Controls.Canvas controlAbajo;
        
        internal System.Windows.Shapes.Ellipse btnTomarFoto;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AnimeCamera;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Canvas)(this.FindName("LayoutRoot")));
            this.viewfinderCanvas = ((System.Windows.Controls.Canvas)(this.FindName("viewfinderCanvas")));
            this.viewfinderBrush = ((System.Windows.Media.VideoBrush)(this.FindName("viewfinderBrush")));
            this.viewfinderTransform = ((System.Windows.Media.CompositeTransform)(this.FindName("viewfinderTransform")));
            this.imgFoto = ((System.Windows.Controls.Image)(this.FindName("imgFoto")));
            this.transformImage = ((System.Windows.Media.CompositeTransform)(this.FindName("transformImage")));
            this.controlArriba = ((System.Windows.Controls.Canvas)(this.FindName("controlArriba")));
            this.btnFlash = ((System.Windows.Shapes.Ellipse)(this.FindName("btnFlash")));
            this.btnCambiarCamara = ((System.Windows.Shapes.Ellipse)(this.FindName("btnCambiarCamara")));
            this.btnTimer = ((System.Windows.Shapes.Ellipse)(this.FindName("btnTimer")));
            this.btnSacaNuevaFoto = ((System.Windows.Shapes.Ellipse)(this.FindName("btnSacaNuevaFoto")));
            this.btnAceptar = ((System.Windows.Shapes.Ellipse)(this.FindName("btnAceptar")));
            this.controlAbajo = ((System.Windows.Controls.Canvas)(this.FindName("controlAbajo")));
            this.btnTomarFoto = ((System.Windows.Shapes.Ellipse)(this.FindName("btnTomarFoto")));
        }
    }
}


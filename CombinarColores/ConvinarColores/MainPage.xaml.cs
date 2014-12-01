using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace ConvinarColores
{
    public partial class MainPage : PhoneApplicationPage
    {
        string nombreAnterior="asd";
        CompositeTransform dragTranslation;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            dragTranslation = new CompositeTransform();
        }
        private void negro_ManipulationStarted_1(object sender, ManipulationStartedEventArgs e)
        {
            dragTranslation.TranslateX = e.ManipulationOrigin.X-45;
            dragTranslation.TranslateY = e.ManipulationOrigin.Y-45;
        }


        private void negro_ManipulationDelta_1(object sender, ManipulationDeltaEventArgs e)
        {
            
            FrameworkElement elipse = sender as FrameworkElement;
            elipse.RenderTransform = dragTranslation;
            dragTranslation.TranslateX = dragTranslation.TranslateX+ e.DeltaManipulation.Translation.X;
            dragTranslation.TranslateY = dragTranslation.TranslateY + e.DeltaManipulation.Translation.Y;
            
        }


        private void azul_ManipulationCompleted_1(object sender, ManipulationCompletedEventArgs e)
        {
            Ellipse elipse = sender as Ellipse;
            string nombreObjeto = (sender as Ellipse).Name;
            bool entroAnterior=false;
            if (elipse.Name == "negro" || elipse.Name == "blanco" || elipse.Name == "amarillo" || elipse.Name=="verde")
            {
                if ((e.TotalManipulation.Translation.Y * -1) > 127 && (e.TotalManipulation.Translation.Y * -1) < 380)
                {
                   entroAnterior= CambiarColores(nombreObjeto);
                }
           }
            else
            {
                if ((e.TotalManipulation.Translation.Y * -1) > 312 && (e.TotalManipulation.Translation.Y * -1) < 560)
                {
                  entroAnterior= CambiarColores(nombreObjeto);
                }
            }
            if (!entroAnterior)
            {
                nombreAnterior = (sender as Ellipse).Name;
            }
            elipse.RenderTransform = null;
           
        }

        private bool CambiarColores(string nombreObjeto)
        {
           
            if (nombreAnterior == "asd")
            {
                switch (nombreObjeto)
                {
                    case "negro":
                        Combinaciones.Fill = new SolidColorBrush(Colors.Black);
                        break;
                    case "blanco":
                        Combinaciones.Fill = new SolidColorBrush(Colors.White);
                        break;
                    case "rojo":
                        Combinaciones.Fill = new SolidColorBrush(Colors.Red);
                        break;
                    case "azul":
                        Combinaciones.Fill = new SolidColorBrush(Colors.Blue);
                        break;
                    case "morado":
                        Combinaciones.Fill = new SolidColorBrush(Colors.Purple);
                        break;
                    case "amarillo":
                        Combinaciones.Fill = new SolidColorBrush(Colors.Yellow);
                        break;
                    case "verde":
                        Combinaciones.Fill = new SolidColorBrush(Colors.Green);
                        break;
                    case "cyan":
                        Combinaciones.Fill = new SolidColorBrush(Colors.Cyan);
                        break;
                }
                return false;
            }
            else
            {
                switch (nombreObjeto)
                {
                    #region negro
                    case "negro":
                        switch (nombreAnterior)
                        {
                            case "negro":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Black);
                                break;
                            case "blanco":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Gray);
                                break;
                            case "rojo":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 128, 0, 32));
                                break;
                            case "azul":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 0, 128));
                                break;
                            case "morado":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Brown);
                                break;
                            case "amarillo":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 204, 119, 34));
                                break;
                            case "verde":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 11, 56, 25));
                                break;
                            case "cyan":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 98, 98));
                                break;
                            default:
                                Combinaciones.Fill = new SolidColorBrush(Colors.Black);
                                break;
                        }
                        nombreAnterior = "asd";
                        break;
                    #endregion
                    #region blanco
                    case "blanco":
                        switch (nombreAnterior)
                        {
                            case "negro":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Gray);
                                break;
                            case "blanco":
                                Combinaciones.Fill = new SolidColorBrush(Colors.White);
                                break;
                            case "rojo":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Orange);
                                break;
                            case "azul":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 137, 207, 240));
                                break;
                            case "morado":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 200, 162, 200));
                                break;
                            case "amarillo":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 255, 237));
                                break;
                            case "verde":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 77, 255, 77));
                                break;
                            case "cyan":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 214, 255, 255));
                                break;
                            default:
                                Combinaciones.Fill = new SolidColorBrush(Colors.White);
                                break;
                        }
                        nombreAnterior = "asd";
                        break;
                    #endregion
                    #region rojo
                    case "rojo":
                        switch (nombreAnterior)
                        {
                            case "negro":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 128, 0, 32));
                                break;
                            case "blanco":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 192, 203));
                                break;
                            case "rojo":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Red);
                                break;
                            case "azul":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Purple);
                                break;
                            case "morado":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 199, 21, 133));
                                break;
                            case "amarillo":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Brown);
                                break;
                            case "verde":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 77, 255, 77));
                                break;
                            case "cyan":
                                Combinaciones.Fill = new SolidColorBrush(Colors.White);
                                break;
                            default:
                                Combinaciones.Fill = new SolidColorBrush(Colors.Red);
                                break;
                        }
                        nombreAnterior = "asd";
                        break;
                    #endregion
                    #region azul
                    case "azul":
                        switch (nombreAnterior)
                        {
                            case "negro":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 0, 128));
                                break;
                            case "blanco":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 137, 207, 240));
                                break;
                            case "rojo":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Purple);
                                break;
                            case "azul":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Blue);
                                break;
                            case "morado":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 238, 130, 238));
                                break;
                            case "amarillo":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Green);
                                break;
                            case "verde":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Cyan);
                                break;
                            case "cyan":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 191, 255));

                                break;
                            default:
                                Combinaciones.Fill = new SolidColorBrush(Colors.Blue);
                                break;
                        }
                        nombreAnterior = "asd";
                        break;
                    #endregion
                    #region morado
                    case "morado":
                        switch (nombreAnterior)
                        {
                            case "negro":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Brown);
                                break;
                            case "blanco":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 200, 162, 200));
                                break;
                            case "rojo":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 199, 21, 133));
                                break;
                            case "azul":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 238, 130, 238));
                                break;
                            case "morado":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Purple);
                                break;
                            case "amarillo":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Brown);
                                break;
                            case "verde":
                                Combinaciones.Fill = new SolidColorBrush(Colors.White);
                                break;
                            case "cyan":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 205, 0, 205));
                                break;
                            default:
                                Combinaciones.Fill = new SolidColorBrush(Colors.Purple);
                                break;
                        }
                        nombreAnterior = "asd";
                        break;
                    #endregion
                    #region amarillo
                    case "amarillo":
                        switch (nombreAnterior)
                        {
                            case "negro":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 204, 119, 34));
                                break;
                            case "blanco":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 255, 237));
                                break;
                            case "rojo":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Brown);
                                break;
                            case "azul":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Green);
                                break;
                            case "morado":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Brown);
                                break;
                            case "amarillo":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Yellow);
                                break;
                            case "verde":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
                                break;
                            case "cyan":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 179, 0));
                                break;
                            default:
                                Combinaciones.Fill = new SolidColorBrush(Colors.Yellow);
                                break;
                        }
                        nombreAnterior = "asd";
                        break;
                    #endregion
                    #region verde
                    case "verde":
                        switch (nombreAnterior)
                        {
                            case "negro":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 11, 56, 25));
                                break;
                            case "blanco":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 77, 255, 77));
                                break;
                            case "rojo":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 77, 255, 77));
                                break;
                            case "azul":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Cyan);
                                break;
                            case "morado":
                                Combinaciones.Fill = new SolidColorBrush(Colors.White);
                                break;
                            case "amarillo":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
                                break;
                            case "verde":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Green);
                                break;
                            case "cyan":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 255, 128));
                                break;
                            default:
                                Combinaciones.Fill = new SolidColorBrush(Colors.Green);
                                break;
                        }
                        nombreAnterior = "asd";
                        break;
                    #endregion
                    #region cyan
                    case "cyan":
                        switch (nombreAnterior)
                        {
                            case "negro":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 98, 98));
                                break;
                            case "blanco":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 214, 255, 255));
                                break;
                            case "rojo":
                                Combinaciones.Fill = new SolidColorBrush(Colors.White);
                                break;
                            case "azul":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 191, 255));
                                break;
                            case "morado":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 205, 0, 205));
                                break;
                            case "amarillo":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 179, 0));
                                break;
                            case "verde":
                                Combinaciones.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 255, 128));
                                break;
                            case "cyan":
                                Combinaciones.Fill = new SolidColorBrush(Colors.Cyan);
                                break;
                            default:
                                Combinaciones.Fill = new SolidColorBrush(Colors.Cyan);
                                break;
                        }
                        nombreAnterior = "asd";
                        break;
                    #endregion
                }
                return true;
            }
        }

        private void Combinaciones_Tap_1(object sender, GestureEventArgs e)
        {
            Combinaciones.Fill = new SolidColorBrush(Colors.White);
            nombreAnterior = "asd";
        }   
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;

namespace Vocales
{
    public partial class ImagenesLetraE : PhoneApplicationPage
    {
        DispatcherTimer timer = new DispatcherTimer();
        int contador = 0;
        bool reprodujoInicio = false;
        bool elefante = false;
        bool estrella = false;
        public ImagenesLetraE()
        {
            InitializeComponent();
            this.Loaded += ImagenesLetraE_Loaded;
        }

        void ImagenesLetraE_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1500);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            if (!reprodujoInicio)
            {
                reprodujoInicio = true;
            }
            else
            {
                switch (contador)
                {
                    case 0:
                        break;
                    case 1:
                        animacionArbol.Begin();
                        break;
                    case 2:

                        break;
                    case 3:
                        animacionHuevo.Begin();
                        break;
                    case 4:

                        break;
                    case 5:
                        animacionGalleta.Begin();
                        break;
                    case 6:

                        break;
                    case 7:
                        animacionElefante.Begin();
                        break;
                    case 8:

                        break;
                    case 9:
                        ainimacionEstrella.Begin();
                        timer.Stop();
                        asignarEventos();
                        break;
                }
                contador++;
            }
        }

        private void asignarEventos()
        {
            imgArbol.Tap += imgArbol_Tap;
            imgElefante.Tap += imgArbol_Tap;
            imgEstrella.Tap += imgArbol_Tap;
            imgGalleta.Tap += imgArbol_Tap;
            imgHuevo.Tap += imgArbol_Tap;
        }

        void imgArbol_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Image img = sender as Image;
            if (img.Name == "imgElefante")
            {
                if (estrella)
                {
                    NavigationService.Navigate(new Uri("/../LetraI.xaml", UriKind.Relative));
                }
                else
                {
                    animacionElefante.Begin();
                    elefante = true;
                }
            }
            else if (img.Name == "imgEstrella")
            {
                if (elefante)
                {
                    NavigationService.Navigate(new Uri("/../LetraI.xaml", UriKind.Relative));
                }
                else
                {
                    ainimacionEstrella.Begin();
                    estrella = true;
                }
            }
            else
            {
            }
        }
    }
}
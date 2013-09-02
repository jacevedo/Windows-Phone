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

namespace Vocales.Letra_A
{
    public partial class ImagenesLetraA : PhoneApplicationPage
    {
        DispatcherTimer timer = new DispatcherTimer();
        int contador = 0;
        bool reprodujoInicio = false;
        bool auto = false;
        bool avion = false;
        public ImagenesLetraA()
        {
            InitializeComponent();
            this.Loaded += ImagenesLetraA_Loaded;
        }

        void ImagenesLetraA_Loaded(object sender, RoutedEventArgs e)
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
                        animacionAuto.Begin();
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        animacionTorta.Begin();
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        animacionZanahoria.Begin();
                        break;
                    case 6:
                        
                        break;
                    case 7:
                        animacionAvion.Begin();
                        break;
                    case 8:
                        
                        break;
                    case 9:
                        animacionMochila.Begin();
                        timer.Stop();
                        asignarEventos();
                        break;
                    

                }
                contador++;
            }
        }

        private void asignarEventos()
        {
            imgAuto.Tap += imgAuto_Tap_1;
            imgAvion.Tap += imgAuto_Tap_1;
            imgMochila.Tap += imgAuto_Tap_1;
            imgTorta.Tap += imgAuto_Tap_1;
            imgZanahoria.Tap += imgAuto_Tap_1;
        }

        private void imgAuto_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Image img = sender as Image;
            if (img.Name == "imgAvion")
            {
                if (auto)
                {
                    NavigationService.Navigate(new Uri("/../LetraE.xaml", UriKind.Relative));
                }
                else
                {
                    animacionAvion.Begin();
                    avion = true;
                }

            }
            else if (img.Name == "imgAuto")
            {
                if (avion)
                {
                    NavigationService.Navigate(new Uri("/../LetraE.xaml", UriKind.Relative));
                }
                else
                {
                    animacionAuto.Begin();
                    avion = true;
                }
            }
            else
            {

            }
        }
    }
}
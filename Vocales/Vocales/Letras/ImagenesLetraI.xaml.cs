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

namespace Vocales.Letras
{
    public partial class ImagenesLetraI : PhoneApplicationPage
    {
        DispatcherTimer timer = new DispatcherTimer();
        int contador = 0;
        bool reprodujoInicio = false;
        bool iglu = false;
        bool isla = false;
        public ImagenesLetraI()
        {
            InitializeComponent();
            this.Loaded += ImagenesLetraI_Loaded;
        }

        void ImagenesLetraI_Loaded(object sender, RoutedEventArgs e)
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
                        animacionIglu.Begin();
                        break;
                    case 2:

                        break;
                    case 3:
                        animacionTelefono.Begin();
                        break;
                    case 4:

                        break;
                    case 5:
                        animacionMascara.Begin();
                        break;
                    case 6:

                        break;
                    case 7:
                        animacionIsla.Begin();
                        break;
                    case 8:

                        break;
                    case 9:
                        animacionZorro.Begin();
                        timer.Stop();
                        asignarEventos();
                        break;
                }
                contador++;
            }
        }

        private void asignarEventos()
        {
            imgIglu.Tap += imgIglu_Tap;
            imgIsla.Tap += imgIglu_Tap;
            imgMascara.Tap += imgIglu_Tap;
            imgTelefono.Tap += imgIglu_Tap;
            imgZorro.Tap += imgIglu_Tap;
        }

        void imgIglu_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Image img = sender as Image;
            if (img.Name == "imgIglu")
            {
                if (isla)
                {
                    NavigationService.Navigate(new Uri("/../LetraO.xaml", UriKind.Relative));
                }
                else
                {
                    animacionIglu.Begin();
                    iglu = true;
                }
            }
            else if (img.Name == "imgIsla")
            {
                if (iglu)
                {
                    NavigationService.Navigate(new Uri("/../LetraO.xaml", UriKind.Relative));
                }
                else
                {
                    animacionIsla.Begin();
                    iglu = true;
                }
            }
            else
            {
            }
        }
    }
}
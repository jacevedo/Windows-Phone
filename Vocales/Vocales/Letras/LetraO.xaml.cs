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
    public partial class LetraO : PhoneApplicationPage
    {
        DispatcherTimer timer = new DispatcherTimer();
        int contador = 0;
        bool reprodujoInicio = false;
        bool ojos = false;
        bool oso = false;

        public LetraO()
        {
            InitializeComponent();
            this.Loaded+=LetraO_Loaded;
        }

        void LetraO_Loaded(object sender, RoutedEventArgs e)
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
                        Extintor.Begin();
                        break;
                    case 2:

                        break;
                    case 3:
                        Oso.Begin();
                        break;
                    case 4:

                        break;
                    case 5:
                        Pollito.Begin();
                        break;
                    case 6:

                        break;
                    case 7:
                        Ampolleta.Begin();
                        break;
                    case 8:

                        break;
                    case 9:
                        Ojos.Begin();
                        timer.Stop();
                        desbloquearBotones();
                        break;
                }
                contador++;
            }
        }

        private void desbloquearBotones()
        {
            imgOjos.Tap += imgAmpolleta_Tap_1;
            imgOso.Tap += imgAmpolleta_Tap_1;
            imgPollito.Tap += imgAmpolleta_Tap_1;
            imgExtintor.Tap += imgAmpolleta_Tap_1;
            imgAmpolleta.Tap += imgAmpolleta_Tap_1;
        }

       
        private void imgAmpolleta_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Image img = sender as Image;
            if (img.Name == "imgOjos")
            {
                if (oso)
                {
                    NavigationService.Navigate(new Uri("/../LetraU.xaml", UriKind.Relative));
                }
                else
                {
                    Ojos.Begin();
                    ojos = true;
                }
            }
            else if (img.Name == "imgOso")
            {
                if (ojos)
                {
                    NavigationService.Navigate(new Uri("/../LetraU.xaml", UriKind.Relative));
                }
                else
                {
                    Oso.Begin();
                    oso = true;
                }
            }
            else
            {
            }
        }
    }
}
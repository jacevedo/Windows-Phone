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
    public partial class LetraU : PhoneApplicationPage
    {
        DispatcherTimer timer = new DispatcherTimer();
        int contador = 0;
        bool reprodujoInicio = false;
        bool boolUva = false;
        bool boolUno = false;
        public LetraU()
        {
            InitializeComponent();
            this.Loaded += LetraU_Loaded;
           

        }

        void LetraU_Loaded(object sender, RoutedEventArgs e)
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
                        Helado.Begin();
                        break;
                    case 2:

                        break;
                    case 3:
                        globo.Begin();
                        break;
                    case 4:

                        break;
                    case 5:
                        televisor.Begin();
                        break;
                    case 6:

                        break;
                    case 7:
                        Uva.Begin();
                        break;
                    case 8:

                        break;
                    case 9:
                        Uno.Begin();
                        timer.Stop();
                        asignarEventos();
                        break;
                }
                contador++;
            }
        }

         private void asignarEventos()
         {
             imgGlobo.Tap += imgGlobo_Tap;
             imgHelado.Tap += imgGlobo_Tap;
             imgTele.Tap += imgGlobo_Tap;
             imgUno.Tap += imgGlobo_Tap;
             imgUva.Tap += imgGlobo_Tap;
         }

         void imgGlobo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
         {
             Image img = sender as Image;
             if (img.Name == "imgUno")
             {
                 if (boolUva)
                 {
                 }
                 else
                 {
                     Uno.Begin();
                     boolUno = true;
                 }
             }
             else if (img.Name == "imgUva")
             {
                 if (boolUno)
                 {
                 }
                 else
                 {
                     Uva.Begin();
                     boolUva = true;
                 }
             }
             else
             {
             }
         }

       
    }
}
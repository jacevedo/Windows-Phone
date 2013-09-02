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
using ControlTiltEffect;
using System.Windows.Threading;
using Microsoft.Xna.Framework;
using System.IO.IsolatedStorage;
using System.IO;
using Microsoft.Xna.Framework.Audio;
using System.Threading;
using Microsoft.Devices;
using System.ComponentModel;


namespace Animales
{

    public partial class MainPage : PhoneApplicationPage
    {
        DispatcherTimer timer = new DispatcherTimer();
        int contador = 0;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Storyboard1.Begin();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(timer_Tick);
            correcto.Opacity = 0;
            incorrecto.Opacity = 0;
            
            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            contador = contador + 1;

            if (contador > 1 && incorrecto.Opacity == 1.0)
            {
                
                timer.Stop();
                contador = 0;
                StoryboardIncorrectoBack.Begin();
            }

            if (contador > 2 && correcto.Opacity == 1.0)
            {
                NavigationService.Navigate(new Uri("/animalNivel2.xaml", UriKind.Relative));
            }
        }

        private void alternativa1_Click_1(object sender, RoutedEventArgs e)
        {
            Uri urlSound = new Uri("Sonidos/obeja.mp3", UriKind.Relative);
            sound.Source = urlSound;
            sound.AutoPlay = true;
            if(incorrecto.Opacity != 100)
            //incorrecto.Opacity = 100;
            StoryboardIncorrecto.Begin();
            timer.Start();

            if (contador == 3 && incorrecto.Opacity == 100)
            {

            }
        }

        private void alternativa2_Click_1(object sender, RoutedEventArgs e)
        {
            Uri urlSound = new Uri("Sonidos/caballo.mp3", UriKind.Relative);
            sound.Source = urlSound;
            sound.AutoPlay = true;
            StoryboardCorrecto.Begin();
            timer.Start();
            
            if (incorrecto.Opacity == 1.0)
                incorrecto.Opacity = 0;

            if (contador == 3)
            {
                correcto.Opacity = 100;
            }
        }

        private void alternativa3_Click_1(object sender, RoutedEventArgs e)
        {
            Uri urlSound = new Uri("Sonidos/pato.mp3", UriKind.Relative);
            sound.Source = urlSound;
            sound.AutoPlay = true;
            StoryboardIncorrecto.Begin();

            if (incorrecto.Opacity != 100)
                incorrecto.Opacity = 100;
            timer.Start();

            if (contador == 3 && incorrecto.Opacity == 100)
            {
                //timer.Stop();
                //contador = 0; 
            }
        }

        }
    }

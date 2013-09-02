using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;

namespace Botella
{
    public partial class Botellas : PhoneApplicationPage
    {
        IsolatedStorageSettings settings;
        public Botellas()
        {
            InitializeComponent();
            this.Loaded += Botellas_Loaded;
           
        }

        void Botellas_Loaded(object sender, RoutedEventArgs e)
        {
            settings = IsolatedStorageSettings.ApplicationSettings;
        }

        private void Rectangle_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            

            if (settings.Contains("botella"))
            {
                settings["botella"] = 1;
            }
            else
            {
                settings.Add("botella", 1);
            }
            MessageBox.Show("Botella Seleccionada, Pulsa hacia atras y selecciona jugar");
        }

        private void Rectangle_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (settings.Contains("botella"))
            {
                settings["botella"] = 2;
            }
            else
            {
                settings.Add("botella", 2);
            }
            MessageBox.Show("Botella Seleccionada, Pulsa hacia atras y selecciona jugar");
        }

        private void Rectangle_Tap_3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (settings.Contains("botella"))
            {
                settings["botella"] = 3;
            }
            else
            {
                settings.Add("botella", 3);
            }
            MessageBox.Show("Botella Seleccionada, Pulsa hacia atras y selecciona jugar");
        }

        private void Rectangle_Tap_4(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (settings.Contains("botella"))
            {
                settings["botella"] = 4;
            }
            else
            {
                settings.Add("botella", 4);
            }
            MessageBox.Show("Botella Seleccionada, Pulsa hacia atras y selecciona jugar");
        }

        private void Rectangle_Tap_5(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (settings.Contains("botella"))
            {
                settings["botella"] = 5;
            }
            else
            {
                settings.Add("botella", 5);
            }
            MessageBox.Show("Botella Seleccionada, Pulsa hacia atras y selecciona jugar");
        }

        private void Rectangle_Tap_6(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (settings.Contains("botella"))
            {
                settings["botella"] = 6;
            }
            else
            {
                settings.Add("botella", 6);
            }
            MessageBox.Show("Botella Seleccionada, Pulsa hacia atras y selecciona jugar");
        }

        private void Rectangle_Tap_7(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (settings.Contains("botella"))
            {
                settings["botella"] = 7;
            }
            else
            {
                settings.Add("botella", 7);
            }
            MessageBox.Show("Seleccionaste la Botella con los puntas, disfruta!!, pulsa hacia atra y selecciona jugar");
        }

        private void Rectangle_Tap_8(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (settings.Contains("botella"))
            {
                settings["botella"] = 8;
            }
            else
            {
                settings.Add("botella", 8);
            }
            MessageBox.Show("Botella Seleccionada, Pulsa hacia atras y selecciona jugar");
        }

        private void Rectangle_Tap_9(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (settings.Contains("botella"))
            {
                settings["botella"] = 9;
            }
            else
            {
                settings.Add("botella", 9);
            }
            MessageBox.Show("Botella Seleccionada, Pulsa hacia atras y selecciona jugar");
        }
    }
}
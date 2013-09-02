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
using Votaciones.View;

namespace Votaciones
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            Controlador control = new Controlador();
            control.GetPersonajesDefault();
            lista.DataContext = control.personajes;
        }

        private void efecto_Click_1(object sender, RoutedEventArgs e)
        {
            int contador = Convert.ToInt32(((Button)sender).Content);
            contador++;
            ((Button)sender).Content = contador;
        }
    }
}
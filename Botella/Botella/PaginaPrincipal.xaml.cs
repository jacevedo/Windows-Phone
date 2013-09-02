using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Botella
{
    public partial class PaginaPrincipal : PhoneApplicationPage
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void Rectangle_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Botellas.xaml", UriKind.Relative));
            
        }

        private void Rectangle_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Toca el boton de juego y luego toca la botella. Cuando pare la botella, "+
            "realiza la acción que la app te diga, también podras cambiar la botella dentro de las 9 opciones diferentes");
        }
    }
}
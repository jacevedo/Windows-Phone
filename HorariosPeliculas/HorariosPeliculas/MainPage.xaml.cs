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
using System.Net.NetworkInformation;

namespace HorariosPeliculas
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                NavigationService.Navigate(new Uri("/HoytsPivot.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Para poder Ver El Horario de las peliculas, debes estar conectado a internet");
            }
        }

        private void CinePlanet_Click(object sender, RoutedEventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                NavigationService.Navigate(new Uri("/CinePlanet.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Para poder Ver El Horario de las peliculas, debes estar conectado a internet");
            }
        }
    }
}
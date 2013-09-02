﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Controls.Maps;
using System.Windows.Resources;
using System.Xml.Linq;
using System.Xml;
using System.Windows.Documents;
using System.Device.Location;


namespace StarckBuks
{
    public partial class PaginaPrincipal : PhoneApplicationPage
    {
        List<Pushpin> lista = new List<Pushpin>();
        
        public PaginaPrincipal()
        {
            InitializeComponent();
            this.Loaded += PaginaPrincipal_Loaded;
        }

        void PaginaPrincipal_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

    

        private void btnMapa_Click_1(object sender, RoutedEventArgs e)
        {
            GeoCoordinateWatcher gps = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            gps.Start();
            if (gps.Permission.Equals(GeoPositionPermission.Granted))
            {
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            
            }
            else if (gps.Permission.Equals(GeoPositionPermission.Denied) || gps.Permission.Equals(GeoPositionPermission.Unknown))
            {
                MessageBox.Show("Tu GPS esta Desactivado. para habilitarlo vaya a configuracion - Ubicacion - y habilite el gps para poder ver el mapa.", "Por Favor Activar GPS", MessageBoxButton.OK);
            }
            
        }

        private void btnUbicacion_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Buscar.xaml", UriKind.Relative));
        }
       
    }
}
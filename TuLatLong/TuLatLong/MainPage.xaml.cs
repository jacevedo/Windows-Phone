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
using System.Device.Location;
using Telerik.Windows.Controls;

namespace TuLatLong
{
    public partial class MainPage : PhoneApplicationPage
    {
        GeoCoordinateWatcher gps;
        bool encendido = false;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            gps = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);
            gps.StatusChanged += gps_StatusChanged;
           
        }
        void gps_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            txtLatitud.Text = gps.Position.Location.Latitude.ToString();
            txtLongitud.Text = gps.Position.Location.Longitude.ToString();
            txtAltitud.Text = gps.Position.Location.Altitude.ToString();
           

        }

        void gps_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {

            switch (e.Status)
            {
                case GeoPositionStatus.Initializing:

                    break;

                case GeoPositionStatus.Ready:

                    try
                    {

                        // x = gps.Position.Location.Latitude;
                        // y = gps.Position.Location.Longitude;
                    }
                    catch
                    {
                        MessageBox.Show("No encontramos tu ubicacion pero te situamos en providencia ;) ");

                    }


                    break;

                case GeoPositionStatus.NoData:
                    Console.WriteLine("No podemos saber tu ubicacion, colocamos la ultima conocida");
                    break;

                case GeoPositionStatus.Disabled:
                    Console.WriteLine("Has desabilitado el GPS, para volver al mapa debes activarlo");
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gps.Start();
            if (gps.Permission.Equals(GeoPositionPermission.Granted))
            {
                if (!encendido)
                {
                    gps.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(gps_PositionChanged);
                    btnBuscar.Content = "Detener Rastreo";
                    encendido = true;
                }
                else
                {

                    gps.PositionChanged -= new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(gps_PositionChanged);
                    btnBuscar.Content = "Buscar Mi Posicion";
                    encendido = false;
                }
            }
            
            else if (gps.Permission.Equals(GeoPositionPermission.Denied) || gps.Permission.Equals(GeoPositionPermission.Unknown))
            {
                MessageBox.Show("Debes Activar el gps para saber tu posicion. . para habilitarlo vaya a configuracion - Ubicacion - y habilite el gps para poder ver el mapa.", "Por Favor Activar GPS", MessageBoxButton.OK);
            }
        
        }
        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show("Política de Privacidad", MessageBoxButtons.OK, "Los datos de Localizacion utilizados en " +
            "esta aplicacion, solo se usan para dar una mejor ubicacion de tu posicion y asi ayudate a encontrar de manera" +
            " más rápida el starkbuck mas cercano, asimismo, estos datos no son compartidos por nadie, ni tampoco salen" +
            " de la aplicacion", "Activar Servicio Localizacion", true, closedHandler: (arg) =>
            {
                if (!arg.IsCheckBoxChecked)
                {
                    gps.PositionChanged -= gps_PositionChanged;
                    encendido = false;
                }
                else
                {
                    gps.PositionChanged += gps_PositionChanged;
                    encendido = true;
                }
            });
        }
    }
}
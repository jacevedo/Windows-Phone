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
using Microsoft.Phone.Controls.Maps;
using System.Device.Location;
using System.Windows.Navigation;
using System.Xml.Linq;
using System.Windows.Resources;
using System.ComponentModel;
using Telerik.Windows.Controls;


namespace StarckBuks
{
    public partial class MainPage : PhoneApplicationPage
    {
        
        GeoCoordinateWatcher gps;
        double x; 
        double y;
        Pushpin ppin;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
                x = -33.43248;
                y = -70.621154;
                gps = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);
                gps.StatusChanged += gps_StatusChanged;
                gps.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(gps_PositionChanged);
                gps.Start();
                ppin = new Pushpin();
                ppin.Location = new GeoCoordinate(x, y);
                ppin.Content = "Estoy Aca";
                mapa.SetView(ppin.Location, 15);
                mapa.Children.Add(ppin);
                cargarPushPin();

           
        }

        void gps_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            mapa.Center = gps.Position.Location;
        
            ppin.Location = gps.Position.Location;
                
            mapa.SetView(ppin.Location, 15);
            
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

        private void cargarPushPin()
        {
            xmlReader xml = new xmlReader(Application.GetResourceStream(new Uri("lugares.xml", System.UriKind.Relative)));
            List<Pushpin> listaPushPinxml = xml.listarPushPin();
            foreach (Pushpin push in listaPushPinxml)
            {
                push.Tap += push_Tap;
                mapa.Children.Add(push);
            }
        }

        void push_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Pushpin ppin = (Pushpin)sender;
            NavigationService.Navigate(new Uri("/Local.xaml?lugar=" + ppin.Content, UriKind.Relative));
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
                }
                else
                {
                    gps.PositionChanged += gps_PositionChanged;
                }
            });
        }
    }
}
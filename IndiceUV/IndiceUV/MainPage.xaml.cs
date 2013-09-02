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
using Telerik.Windows.Controls;
using System.Net.NetworkInformation;
using System.IO.IsolatedStorage;
using System.Windows.Media.Imaging;

namespace IndiceUV
{
    public partial class MainPage : PhoneApplicationPage
    {
        IsolatedStorageSettings settings;
        int valorInicial;
        // Constructor
        public MainPage()
        {
            settings = IsolatedStorageSettings.ApplicationSettings;
           
            if (!settings.Contains("index"))
            {
                settings.Add("index", 0);
                settings.Add("primero", 0);
            }
            else
            {

               valorInicial = Convert.ToInt32(settings["index"]);
                
            }
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            
            listaLugares.ItemsSource = new listaLugares();
            listaLugares.SelectedIndex = valorInicial;
           
           
        }

        

        private void listaLugares_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProgressIndicator.IsRunning = true;
            panelCargando.Visibility = System.Windows.Visibility.Visible;
            
            RadListPicker picker = sender as RadListPicker;
         
                settings["index"] = picker.SelectedIndex;

                if (NetworkInterface.GetIsNetworkAvailable())
                {

                    Lugares lugar = picker.SelectedItem as Lugares;
                    // MessageBox.Show(lugar.NomAMandar);
                    var webClient = new WebClient();
                    webClient.DownloadStringCompleted += webClient_DownloadStringCompleted;
                    webClient.DownloadStringAsync(new Uri(lugar.UrlRadiacion));
                }
                else
                {
                    MessageBox.Show("Para poder revisar el indice UV, debes estar conectado a internet");
                }
            
        }

        void webClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            string resultado = e.Result;
           string[] listaContenido = resultado.Split(';');
            List<string> listaResultados = new List<string>();
            foreach (var item in listaContenido)
            {
                string[]items= item.Split('=');
                if (items.Count() == 2)
                {
                    listaResultados.Add(items[1]);
                }
            }
            string fechaHoyAmericana = listaResultados[0].Replace("'", "");
            string[] listaFecha = fechaHoyAmericana.Split('-');
            string fechaHoy = listaFecha[2] + "-" + listaFecha[1] + "-" + listaFecha[0];
            string indiceHoy = listaResultados[1].Replace("'", "");
            string horaHoy = listaResultados[2].Replace("'", "");
            string fechaMananaAmericana = listaResultados[4].Replace("'", "");
            string[] listaFechaManana = fechaMananaAmericana.Split('-');
            string fechaManana = listaFechaManana[2] + "-" + listaFechaManana[1] + "-" + listaFechaManana[0];
            string indiceManana = listaResultados[5].Replace("'", "");
            string [] indiceHoyArreglo = indiceHoy.Split(':');
            string[] indiceMananaArreglo = indiceManana.Split(':');
            fecha1.Text = fechaHoy;
            indice1.Text = indiceHoy;
            hora.Text = horaHoy;
            fecha2.Text = fechaManana;
            indice2.Text = indiceManana;
            colorearCuadrados(indiceHoyArreglo[1], rectanguloHoy);
            colorearCuadrados(indiceMananaArreglo[1], rectanguloManana);
            cambiarFondo(indiceHoyArreglo[1]);

            ProgressIndicator.IsRunning = false;
            panelCargando.Visibility = System.Windows.Visibility.Collapsed;
       }

        private void cambiarFondo(string p)
        {
            ImageBrush fondo = new ImageBrush();
             switch (p)
            {
                case "Bajo":
                    fondo.ImageSource = new BitmapImage(new Uri("fondos/bajo.png",UriKind.Relative));
                    
                    break;
                case "Moderado":
                    fondo.ImageSource = new BitmapImage(new Uri("fondos/moderado.png", UriKind.Relative));
                    break;
                case "Alto":
                    fondo.ImageSource = new BitmapImage(new Uri("fondos/Alto.png", UriKind.Relative));
                    break;
                case "Muy alto":
                    fondo.ImageSource = new BitmapImage(new Uri("fondos/muyAlto.png", UriKind.Relative));
                    break;
                case "Extremo":
                    fondo.ImageSource = new BitmapImage(new Uri("fondos/extremo.png", UriKind.Relative));
                    break;
            }
            LayoutRoot.Background=fondo;
        }

        private void colorearCuadrados(string p, Rectangle rectangulo)
        {
            
            switch (p)
            {
                case "Bajo":
                    rectangulo.Fill = new SolidColorBrush(Colors.Green);
                    break;
                case "Moderado":
                    rectangulo.Fill = new SolidColorBrush(Colors.Yellow);
                    break;
                case "Alto":
                    rectangulo.Fill = new SolidColorBrush(Colors.Orange);
                    break;
                case "Muy alto":
                    rectangulo.Fill = new SolidColorBrush(Colors.Red);
                    break;
                case "Extremo":
                    rectangulo.Fill = new SolidColorBrush(Colors.Purple);
                    break;
            }
        }
    }
}
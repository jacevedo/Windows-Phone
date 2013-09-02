using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace HorariosPeliculas
{
    public partial class CinePlanetClass : PhoneApplicationPage
    {
        public CinePlanetClass()
        {
            InitializeComponent();
            this.Loaded += CinePlanet_Loaded;
        }

        void CinePlanet_Loaded(object sender, RoutedEventArgs e)
        {
            ProgressIndicator.IsRunning = true;
            panelCargando.Visibility = System.Windows.Visibility.Visible;
            var webClient = new WebClient();
            webClient.DownloadStringCompleted += webClient_DownloadStringCompleted;
            webClient.DownloadStringAsync(new Uri("http://www.cineplanet.cl/"));
        }

        void webClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            ProgressIndicator.IsRunning = false;
            panelCargando.Visibility = System.Windows.Visibility.Collapsed;
            HtmlReader reader = new HtmlReader(e.Result.ToString());
           // List<string> listaPeliculas = reader.listaPeliculas();
            //cargarLista(listaPeliculas);
            ClassCinePlanet planet =  reader.listaPeliculas();
            List<string> listaIntercalada = planet.listaIntercalada();
            for (int i = 0; i < listaIntercalada.Count; i++)
            {
                if (i % 2 == 0)
                {
                    TextBlock txtTitulo = new TextBlock();
                    txtTitulo.FontSize = 25;
                    txtTitulo.TextWrapping = TextWrapping.Wrap;
                    txtTitulo.FontWeight = FontWeights.Bold;
                    txtTitulo.Text = listaIntercalada.ElementAt(i);
                    stackInfo.Children.Add(txtTitulo);

                }
                else
                {
                    TextBlock txtInfo = new TextBlock();
                    txtInfo.FontWeight = FontWeights.Bold;
                    txtInfo.TextWrapping = TextWrapping.Wrap;
                    txtInfo.Text = listaIntercalada.ElementAt(i);
                    stackInfo.Children.Add(txtInfo);
                }
                
            }
            //listaPeliculas.ItemsSource = planet.listaIntercalada();
        }


      
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;

namespace FarmaciaTurno
{
    public partial class Farmacias : PhoneApplicationPage
    {
        public Farmacias()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            //this.contenedor.Text = "DescargaComenzada";
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string region= string.Empty;
            if (NavigationContext.QueryString.TryGetValue("region", out region))
            {
                
            }
            string comuna = string.Empty;
            if (NavigationContext.QueryString.TryGetValue("comuna", out comuna))
            {

            }

            var webClient = new WebClient();
            webClient.DownloadStringCompleted += webClientDownloadStringCompleted;
            webClient.DownloadStringAsync(new Uri("http://desarrollo.redsalud.gob.cl/farmacias_turno/consultas/get_farmacias.php?region="+region+"&comuna="+comuna+"#"));
            base.OnNavigatedTo(e);
        }
        private void webClientDownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            panelCentral.Children.Remove(txtCargando);
            panelCentral.Children.Remove(txtEspere);
            string llamada = "<html><head></head><body>" + e.Result + "</body></html>";
            HTMLReader html = new HTMLReader(llamada);
            List<string> listaValoresTD = html.returnDatos() ;
           
            for (int i = 0; i < listaValoresTD.Count; i++)
            {
                TextBlock fecha = new TextBlock();
                fecha.Text = string.Format("{0}/{1}/2013",listaValoresTD.ElementAt(i),listaValoresTD.ElementAt(i+1));
                fecha.TextAlignment = TextAlignment.Center;
                fecha.FontSize = 30;
                TextBlock nomFarmaciaMostrar = new TextBlock();
                nomFarmaciaMostrar.Text = "Nombre de la farmacia:";
                TextBlock nomFarmacia = new TextBlock();
                nomFarmacia.TextWrapping = TextWrapping.Wrap;
                nomFarmacia.Text = listaValoresTD.ElementAt(i + 2);
                TextBlock nomDireccionMostrar = new TextBlock();
                nomDireccionMostrar.Text = "Direccion de la farmacia:";
                TextBlock direccion = new TextBlock();
                direccion.TextWrapping = TextWrapping.Wrap;
                direccion.Text = listaValoresTD.ElementAt(i + 3);
                TextBlock nomHorarioMostrar = new TextBlock();
                nomHorarioMostrar.Text = "Horario de atencion:";
                TextBlock horarioAtencion = new TextBlock();
                horarioAtencion.TextWrapping = TextWrapping.Wrap;
                horarioAtencion.Text = listaValoresTD.ElementAt(i + 4);
                
                TextBlock txtEmpy = new TextBlock();
                txtEmpy.Text = "\n";

                fecha.Foreground = new SolidColorBrush(Colors.Black);
                nomFarmaciaMostrar.Foreground = new SolidColorBrush(Colors.Black);
                nomFarmacia.Foreground = new SolidColorBrush(Colors.Black);
                nomDireccionMostrar.Foreground = new SolidColorBrush(Colors.Black);
                direccion.Foreground = new SolidColorBrush(Colors.Black);
                nomDireccionMostrar.Foreground = new SolidColorBrush(Colors.Black);
                direccion.Foreground = new SolidColorBrush(Colors.Black);
                nomHorarioMostrar.Foreground = new SolidColorBrush(Colors.Black);
                horarioAtencion.Foreground = new SolidColorBrush(Colors.Black);


                panelCentral.Children.Add(fecha);
                panelCentral.Children.Add(nomFarmaciaMostrar);
                panelCentral.Children.Add(nomFarmacia);
                panelCentral.Children.Add(nomDireccionMostrar);
                panelCentral.Children.Add(direccion);
                panelCentral.Children.Add(nomHorarioMostrar);
                panelCentral.Children.Add(horarioAtencion);
                panelCentral.Children.Add(txtEmpy);

                i = i + 5;
                
          
            }
        }
    }
}
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

namespace MultasImpagas
{
    public partial class MultasConsultas : PhoneApplicationPage
    {
        public MultasConsultas()
        {
            InitializeComponent();
            this.Loaded += MultasConsultas_Loaded;
        }

        void MultasConsultas_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            string ppu = string.Empty;
            if (NavigationContext.QueryString.TryGetValue("ppu", out ppu))
            {

            }
            var webClient = new WebClient();
            webClient.DownloadStringCompleted += webClient_DownloadStringCompleted;
            webClient.DownloadStringAsync(new Uri("http://consultamultas.srcei.cl/ConsultaMultas/buscarConsultaMultasExterna.do?ppu="+ppu));
            base.OnNavigatedTo(e);
        }
        void webClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            stackMulta.Children.Remove(buscando);
            stackPermiso.Children.Remove(buscando2);
            HtmlReader reader = new HtmlReader(e.Result.ToString());
            string texto2 = string.Empty;
            Multas multa = reader.returnDatos();


            if (multa.InfoNoviembre)
            {
                cantMultasNoviembre.Text = multa.CantMultasNoviembre;
                for (int i = 0; i < multa.JuzgadosNoviembre.Count; i++)
                {
                    TextBlock txtJuzgado = new TextBlock();
                    TextBlock txtCausa = new TextBlock();
                    txtJuzgado.Text = multa.JuzgadosNoviembre[i];
                    txtCausa.Text = multa.RolCausaNoviembre[i];
                    txtCausa.Foreground = new SolidColorBrush(Colors.Black);
                    txtJuzgado.Foreground = new SolidColorBrush(Colors.Black);
                    panelIzquierdaPermiso.Children.Add(txtJuzgado);
                    panelDerechaPermiso.Children.Add(txtCausa);
                }
            }
            else
            {
                cantMultasNoviembre.Text = "No posee multas para inscribir el permiso de circulacion";
            }
            if (multa.DiaHoy)
            {
                cantMultasHoy.Text = multa.CantMultasHoy;
                TextBlock txtTituloJuzgado = new TextBlock();
                TextBlock txtTituloCauza = new TextBlock();


                for (int i = 0; i < multa.JuzgadosHoy.Count; i++)
                {
                    TextBlock txtJuzgado = new TextBlock();
                    TextBlock txtCausa = new TextBlock();
                    txtJuzgado.Text = multa.JuzgadosHoy[i];
                    txtCausa.Text = multa.RolCausaHoy[i];
                    txtCausa.Foreground = new SolidColorBrush(Colors.Black);
                    txtJuzgado.Foreground = new SolidColorBrush(Colors.Black);

                    panelIzquierdaMultas.Children.Add(txtJuzgado);
                    panelDerechaMultas.Children.Add(txtCausa);
                }
            }
            else
            {
                cantMultasHoy.Text = "No posee multas hasta el dia de hoy";
            }

        }
    }
}
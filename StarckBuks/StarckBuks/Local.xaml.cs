using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using System.Windows.Resources;
using System.IO;
using System.Windows.Media;

namespace StarckBuks
{
    public partial class Local : PhoneApplicationPage
    {
        public Local()
        {
            InitializeComponent();
            this.Loaded += Local_Loaded;
        }

        void Local_Loaded(object sender, RoutedEventArgs e)
        {
           
            //SaveHTMLFile(xml.retornarHtml("Callao"));
            //navegador.Navigate(new Uri("TextFile1.htm", UriKind.Relative));
            
           
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string newText = string.Empty;
            if (NavigationContext.QueryString.TryGetValue("lugar", out newText))
            {
                //MessageBox.Show(newText);
                llenarVentana(newText);
            }
            base.OnNavigatedTo(e);
        }
        private void llenarVentana(string buscar)
        {
            xmlReader xml = new xmlReader(Application.GetResourceStream(new Uri("lugares.xml", System.UriKind.Relative)));
            List<Tienda> listaTienea = xml.retornarHtml(buscar);
            int contador = 1;
            foreach (Tienda tienda in listaTienea)
            {
                TextBlock txtTituloLocal = new TextBlock();
                txtTituloLocal.Text = "Tienda " + contador;
                txtTituloLocal.FontSize = 36;
                TextBlock txtLabelNombreLocal = new TextBlock();
                txtLabelNombreLocal.Text = "Nombre del Local:";
                TextBlock txtNombreLocal = new TextBlock();
                txtNombreLocal.Text = tienda.NomLocal;

                TextBlock txtLabelComunaLocal = new TextBlock();
                txtLabelComunaLocal.Text = "Comuna:";
                TextBlock txtComunaLocal = new TextBlock();
                txtComunaLocal.Text = tienda.NomComuna;

                TextBlock txtLabelDescripcionLocal = new TextBlock();
                txtLabelDescripcionLocal.Text = "Desripcion:";
                TextBlock txtDescripcionLocal;
                if (tienda.Descripcion != "")
                {
                    txtDescripcionLocal = new TextBlock();
                    txtDescripcionLocal.Text = tienda.Descripcion;
                }
                else
                {
                    txtDescripcionLocal = new TextBlock();
                    txtDescripcionLocal.Text = "No Existe Descripcion";
                }
                TextBlock txtHorarioLocal = new TextBlock();
                txtHorarioLocal.Text = tienda.Horario;

                TextBlock txtLabelComoLlegarLocal = new TextBlock();
                txtLabelComoLlegarLocal.Text = "Direccion:";
                TextBlock txtComoLlegarLocal = new TextBlock();
                txtComoLlegarLocal.Text = tienda.ComoLlegar;

                txtTituloLocal.Foreground = new SolidColorBrush(Colors.Black);
                txtTituloLocal.FontWeight = FontWeights.Bold;
                txtLabelNombreLocal.Foreground = new SolidColorBrush(Colors.Black);
                txtLabelNombreLocal.FontWeight = FontWeights.Bold;
                txtNombreLocal.Foreground = new SolidColorBrush(Colors.Black);
                txtNombreLocal.FontWeight = FontWeights.Bold;
                txtComunaLocal.Foreground = new SolidColorBrush(Colors.Black);
                txtComunaLocal.FontWeight = FontWeights.Bold;
                txtLabelComunaLocal.Foreground = new SolidColorBrush(Colors.Black);
                txtLabelComunaLocal.FontWeight = FontWeights.Bold;
                txtLabelDescripcionLocal.Foreground = new SolidColorBrush(Colors.Black);
                txtLabelDescripcionLocal.FontWeight = FontWeights.Bold;
                txtDescripcionLocal.Foreground = new SolidColorBrush(Colors.Black);
                txtDescripcionLocal.FontWeight = FontWeights.Bold;
                txtHorarioLocal.Foreground = new SolidColorBrush(Colors.Black);
                txtHorarioLocal.FontWeight = FontWeights.Bold;
                txtLabelComoLlegarLocal.Foreground = new SolidColorBrush(Colors.Black);
                txtLabelComoLlegarLocal.FontWeight = FontWeights.Bold;
                txtComoLlegarLocal.Foreground = new SolidColorBrush(Colors.Black);
                txtComoLlegarLocal.FontWeight = FontWeights.Bold;

                panelCentral.Children.Add(txtTituloLocal);
                panelCentral.Children.Add(txtLabelNombreLocal);
                panelCentral.Children.Add(txtNombreLocal);
                panelCentral.Children.Add(txtLabelComunaLocal);
                panelCentral.Children.Add(txtComunaLocal);
                panelCentral.Children.Add(txtLabelDescripcionLocal);
                panelCentral.Children.Add(txtDescripcionLocal);

                panelCentral.Children.Add(txtHorarioLocal);
                panelCentral.Children.Add(txtLabelComoLlegarLocal);
                panelCentral.Children.Add(txtComoLlegarLocal);
                contador++;
            }
        }
    }
}
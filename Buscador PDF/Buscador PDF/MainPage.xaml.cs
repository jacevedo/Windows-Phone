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
using Microsoft.Phone.Tasks;
using System.Net.NetworkInformation;

namespace Buscador_PDF
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
                string aAbuscar = txtPdf.Text.ToString();
                string url = string.Format("http://www.bing.com/search?q=filetype%3Apdf+{0}&go=&qs=ds&form=QBRE&filt=all", aAbuscar);
                WebBrowserTask webBrowserTask = new WebBrowserTask();

                webBrowserTask.Uri = new Uri(url, UriKind.Absolute);

                webBrowserTask.Show();
            }
            else
            {
                MessageBox.Show("Debes tener una coneccion a internet para buscar los textos en pdf");
            }
        }
    }
}
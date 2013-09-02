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

namespace queHago
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            int cantPersoans =Convert.ToInt32(txtCantPersonas.Text.ToString());
            string tiempo = txtTiempo.Text.ToString();
            NavigationService.Navigate(new Uri("/QueHago.xaml?cantPersonas=" + cantPersoans + "&tiempo=" + tiempo, UriKind.Relative));
        }
    }
}
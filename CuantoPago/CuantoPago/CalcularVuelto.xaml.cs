using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace CuantoPago
{
    public partial class CalcularVuelto : PhoneApplicationPage
    {
        public CalcularVuelto()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click_1(object sender, RoutedEventArgs e)
        {
            int cantPersonas = Convert.ToInt32(txtCantPersonas.Text);
            int valorTotal = Convert.ToInt32(txtValorTotal.Text);
            int valorVuelto = Convert.ToInt32(txtVuelto.Text);
            NavigationService.Navigate(new Uri("/SiguienteVuelto.xaml?cantidadPersonas=" + cantPersonas + "&valorTotal=" + valorTotal + "&valorVuelto="+valorVuelto, UriKind.Relative));
        }
        
        private void txtCantPersonas_LostFocus_1(object sender, RoutedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            if (string.Compare(texto.Text, string.Empty) == 0)
            {
                texto.Text = "0";
            }
        }

        private void txtCantPersonas_GotFocus_1(object sender, RoutedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            if (string.Compare(texto.Text, "0") == 0)
            {
                texto.Text = string.Empty;
            }
        }

        private void txtCantPersonas_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }
    }
}
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

namespace CuantoPago
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click_1(object sender, RoutedEventArgs e)
        {
            int cantPersonas = 0;
            int calculo = 0;
            int valorTotal = 0;
            try
            {
                valorTotal = Convert.ToInt32(txtPrecio.Text);
                cantPersonas = Convert.ToInt32(txtCantidad.Text);
                int propina = Convert.ToInt32(txtPropina.Text);
                calculo = (valorTotal + propina) / cantPersonas;
                
            }
            catch (Exception ex)
            {
                CuantoPago.Text = "Debes ingresar solo numeros";
            }
            if (valorTotal != 0)
            {
                NavigationService.Navigate(new Uri("/CantidadPago.xaml?cantidadPersonas=" + cantPersonas + "&pagoPersonas=" + calculo, UriKind.Relative));
            }
            else
            {
                CuantoPago.Text = "Debes ingresar un monto en precio";
            }
        }
        
        private void txtCantidad_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void txtCantidad_GotFocus_1(object sender, RoutedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            if (string.Compare(texto.Text,"0")==0)
            {
                texto.Text = string.Empty;
            }
        }

        private void txtCantidad_LostFocus_1(object sender, RoutedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            if (string.Compare(texto.Text, string.Empty) == 0)
            {
                texto.Text = "0";
            }
        }
    }
}
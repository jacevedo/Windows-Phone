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
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;

namespace MultasImpagas
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Patente_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace("-", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string texto = Patente.Text.ToString().Trim();
            string expresionRegular = @"^[A-ZÑ]{2}|[a-zñ]{2}[0-9]{4}$";
            string expresionRegular2 = @"^[A-ZÑ]{4}|[a-zñ]{4}\d{2}$";

            if (texto.Length == 6 && (Regex.IsMatch(texto, expresionRegular) || Regex.IsMatch(texto, expresionRegular2)))
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    NavigationService.Navigate(new Uri("/MultasConsultas.xaml?ppu=" + texto, UriKind.Relative));
                }
                else
                {
                    MessageBox.Show("Para hacer la consulta se requiere conección a internet");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una patenten valida");
            }
        }

        private void Patente_GotFocus(object sender, RoutedEventArgs e)
        {
            Patente.BorderBrush = new SolidColorBrush(Colors.Black);
        }
    }
}
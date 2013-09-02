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
    public partial class PaginaPrincipal : PhoneApplicationPage
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (sender == btnPago)
            {
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative)); 
            }
            if (sender == btnVuelto)
            {
                NavigationService.Navigate(new Uri("/CalcularVuelto.xaml", UriKind.Relative)); 
            }
        }

        private void btnAbout_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result =
            MessageBox.Show("Idea por Pablo de la Sotta \nProgramacion Jaime Acevedo",
            "About", MessageBoxButton.OKCancel);
           
            
        }
    }
}
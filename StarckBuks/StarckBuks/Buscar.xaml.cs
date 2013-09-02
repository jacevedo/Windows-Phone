using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace StarckBuks
{
    public partial class Buscar : PhoneApplicationPage
    {
        public Buscar()
        {
            InitializeComponent();
            this.Loaded += Buscar_Loaded;
        }

        void Buscar_Loaded(object sender, RoutedEventArgs e)
        {
            xmlReader xml = new xmlReader(Application.GetResourceStream(new Uri("lugares.xml", System.UriKind.Relative)));
           
            List<string> nombres = xml.listaNombreLocales();
            List<string> comunas = xml.listaComunasLocales();
           
            listaNombresVista.ItemsSource = nombres;
            listaLugarVista.ItemsSource = comunas;
            listaNombresVista.Tap += listaNombresVista_Tap;
            listaLugarVista.Tap += listaLugarVista_Tap;
        }

        void listaLugarVista_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            listaNombresVista.SelectedIndex = 0;
        }

        void listaNombresVista_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            listaLugarVista.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (listaLugarVista.Text!="")
            {
                NavigationService.Navigate(new Uri("/Local.xaml?lugar=" + listaLugarVista.Text.ToString(), UriKind.Relative));
            }
            if (listaNombresVista.SelectedIndex != 0)
            {
                NavigationService.Navigate(new Uri("/Local.xaml?lugar=" + listaNombresVista.SelectedItem.ToString(), UriKind.Relative));
            }
        }
    }
}
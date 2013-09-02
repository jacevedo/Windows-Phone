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
using System.IO.IsolatedStorage;

namespace Liquidacion_Sueldo
{
    public partial class MainPage : PhoneApplicationPage
    {
        IsolatedStorageSettings settings;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            settings = IsolatedStorageSettings.ApplicationSettings;
            if (!settings.Contains("cantCargasFamiliares"))
            {
                //MessageBox.Show("hola");
                settings.Add("cantCargasFamiliares", 0);
            }
            if (!settings.Contains("porcentajeIsapre"))
            {
                //MessageBox.Show("hola");
                settings.Add("porcentajeIsapre", 7);
            }
            if (!settings.Contains("porcentajeAFP"))
            {
                //MessageBox.Show("hola");
                settings.Add("porcentajeAFP","12,45");
            }
            if (!settings.Contains("porcentajeCesantia"))
            {
                //MessageBox.Show("hola");
                settings.Add("porcentajeCesantia", "0,6");
            }
            if (!settings.Contains("valorColacion"))
            {
                //MessageBox.Show("hola");
                settings.Add("valorColacion", 1666);
            }
            if (!settings.Contains("valorLocomosion"))
            {
                //MessageBox.Show("hola");
                settings.Add("valorLocomosion", 1666);
            }
            if (!settings.Contains("diasTrabajados"))
            {
                //MessageBox.Show("hola");
                settings.Add("diasTrabajados", 20);
            }
        }

        private void configuraciones_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Configuraciones.xaml",UriKind.Relative));
        }

        private void liquidacion_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Liquidacion.xaml", UriKind.Relative));
        }
    }
}
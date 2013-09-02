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
using Telerik.Windows.Controls;
using System.Net.NetworkInformation;

namespace FarmaciaTurno
{
    public partial class MainPage : PhoneApplicationPage
    {
        ListaRegionComuna lstRegion = new ListaRegionComuna();
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            inicializarRegiones();
           
        }

        private void inicializarRegiones()
        {
            List<String> regiones = new List<String>();
            regiones.Add("Seleccione Region");
            foreach (Regiones region in lstRegion.regiones)
            {
                regiones.Add(region.nomRegion);
            }
            this.listaRegiones.ItemsSource = regiones;
           // this.listComunas.ItemsSource = comunas;
            
        }

        private void buscar_Click(object sender, RoutedEventArgs e)
        {
            if (listaRegiones.SelectedIndex > 0)
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    string url = string.Format("/Farmacias.xaml{0}", returnStringURl());
                    NavigationService.Navigate(new Uri(url, UriKind.Relative));
                }
                else
                {
                    MessageBox.Show("Debes tener coneccion a internet para ver las farmacias de turno");
                }
            }
        }

        private void listRegiones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            RadListPicker lstPicker = sender as RadListPicker;
            List<string> comunas = new List<string>();
            switch (lstPicker.SelectedIndex)
            {
                case 0:
                    comunas.Add("Seleccione Region");
                    listComunas.ItemsSource = comunas;
                    break;
                case 1:
                    foreach (Comunas comuna in lstRegion.comunas1region)
                    {
                        comunas.Add(comuna.nomComuna);
                    }
                    listComunas.ItemsSource = comunas;
                    break;
                case 2:
                    foreach (Comunas comuna in lstRegion.comunas2region)
                    {
                        comunas.Add(comuna.nomComuna);
                    }
                    listComunas.ItemsSource = comunas;
                    break;
                case 3:
                    foreach (Comunas comuna in lstRegion.comunas3region)
                    {
                        comunas.Add(comuna.nomComuna);
                    }
                    listComunas.ItemsSource = comunas;
                    break;
                case 4:
                    foreach (Comunas comuna in lstRegion.comunas4region)
                    {
                        comunas.Add(comuna.nomComuna);
                    }
                    listComunas.ItemsSource = comunas;
                    break;
                case 5:
                    foreach (Comunas comuna in lstRegion.comunas5region)
                    {
                        comunas.Add(comuna.nomComuna);
                    }
                    listComunas.ItemsSource = comunas;
                    break;
                case 6:
                    foreach (Comunas comuna in lstRegion.comunas6region)
                    {
                        comunas.Add(comuna.nomComuna);
                    }
                    listComunas.ItemsSource = comunas;
                    break;
                case 7:
                    foreach (Comunas comuna in lstRegion.comunas7region)
                    {
                        comunas.Add(comuna.nomComuna);
                    }
                    listComunas.ItemsSource = comunas;
                    break;
                case 8:
                    foreach (Comunas comuna in lstRegion.comunas8region)
                    {
                        comunas.Add(comuna.nomComuna);
                    }
                    listComunas.ItemsSource = comunas;
                    break;
                case 9:
                    foreach (Comunas comuna in lstRegion.comunas9region)
                    {
                        comunas.Add(comuna.nomComuna);
                    }
                    listComunas.ItemsSource = comunas;
                    break;
                case 10:
                    foreach (Comunas comuna in lstRegion.comunas10region)
                    {
                        comunas.Add(comuna.nomComuna);
                    }
                    listComunas.ItemsSource = comunas;
                    break;
                case 11:
                    foreach (Comunas comuna in lstRegion.comunas11region)
                    {
                        comunas.Add(comuna.nomComuna);
                    }
                    listComunas.ItemsSource = comunas;
                    break;
                case 12:
                    foreach (Comunas comuna in lstRegion.comunas12region)
                    {
                        comunas.Add(comuna.nomComuna);
                    }
                    listComunas.ItemsSource = comunas;
                    break;
                case 13:
                    foreach (Comunas comuna in lstRegion.comunas13region)
                    {
                        comunas.Add(comuna.nomComuna);
                    }
                    listComunas.ItemsSource = comunas;
                    break;
                case 14:
                    foreach (Comunas comuna in lstRegion.comunas14region)
                    {
                        comunas.Add(comuna.nomComuna);
                    }
                    listComunas.ItemsSource = comunas;
                    break;
                case 15:
                    foreach (Comunas comuna in lstRegion.comunas15region)
                    {
                        comunas.Add(comuna.nomComuna);
                    }
                    listComunas.ItemsSource = comunas;
                    break;
            }
            
        }
        private string returnStringURl()
        {
            int index = listaRegiones.SelectedIndex - 1;
            string nomAEnviarRegion = nomAEnviarRegion = lstRegion.regiones.ElementAt(index).nomEnviar;
            string nomAEnvairComuna = string.Empty;

            switch (listaRegiones.SelectedIndex)
            {
                case 0:

                    break;
                case 1:
                    nomAEnvairComuna = lstRegion.comunas1region.ElementAt(listComunas.SelectedIndex).nomEnviar;
                    break;
                case 2:
                    nomAEnvairComuna = lstRegion.comunas2region.ElementAt(listComunas.SelectedIndex).nomEnviar;
                    break;
                case 3:
                    nomAEnvairComuna = lstRegion.comunas3region.ElementAt(listComunas.SelectedIndex).nomEnviar;
                    break;
                case 4:
                    nomAEnvairComuna = lstRegion.comunas4region.ElementAt(listComunas.SelectedIndex).nomEnviar;
                    break;
                case 5:
                    nomAEnvairComuna = lstRegion.comunas5region.ElementAt(listComunas.SelectedIndex).nomEnviar;
                    break;
                case 6:
                    nomAEnvairComuna = lstRegion.comunas6region.ElementAt(listComunas.SelectedIndex).nomEnviar;
                    break;
                case 7:
                    nomAEnvairComuna = lstRegion.comunas7region.ElementAt(listComunas.SelectedIndex).nomEnviar;
                    break;
                case 8:
                    nomAEnvairComuna = lstRegion.comunas8region.ElementAt(listComunas.SelectedIndex).nomEnviar;
                    break;
                case 9:
                    nomAEnvairComuna = lstRegion.comunas9region.ElementAt(listComunas.SelectedIndex).nomEnviar;
                    break;
                case 10:
                    nomAEnvairComuna = lstRegion.comunas10region.ElementAt(listComunas.SelectedIndex).nomEnviar;
                    break;
                case 11:
                    nomAEnvairComuna = lstRegion.comunas11region.ElementAt(listComunas.SelectedIndex).nomEnviar;
                    break;
                case 12:
                    nomAEnvairComuna = lstRegion.comunas12region.ElementAt(listComunas.SelectedIndex).nomEnviar;
                    break;
                case 13:
                    nomAEnvairComuna = lstRegion.comunas13region.ElementAt(listComunas.SelectedIndex).nomEnviar;
                    break;
                case 14:
                    nomAEnvairComuna = lstRegion.comunas14region.ElementAt(listComunas.SelectedIndex).nomEnviar;
                    break;
                case 15:
                    nomAEnvairComuna = lstRegion.comunas15region.ElementAt(listComunas.SelectedIndex).nomEnviar;
                    break;
            }
            return string.Format("?region={0}&comuna={1}", nomAEnviarRegion, nomAEnvairComuna);
        }
    }
}
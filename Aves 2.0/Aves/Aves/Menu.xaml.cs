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

namespace Aves
{
    public partial class Menu : PhoneApplicationPage
    {
        List<HabitatDB> habitat;
        List<AvesBD> aves;
        List<PorqueDB> porque;
        
        
        public Menu()
        {
            InitializeComponent();
            colocarBotones();
        }
        private void colocarBotones()
        {
            using (baseDatosDataContext contextoBD = new baseDatosDataContext("Data source='isostore:/baseDatosBD.sdf'"))
            {
                 habitat = contextoBD.HabitatDB.OrderBy(x => x.nom_Habitat).ToList();
                 aves = contextoBD.AvesBD.OrderBy(x => x.nomAve).ToList();
                 porque = contextoBD.PorqueDB.OrderBy(x => x.nomPor).ToList();
            }

            foreach (HabitatDB habita in habitat)
            {
                Button botonHabitat = new Button();
                botonHabitat.Content = habita.nom_Habitat;
                botonHabitat.Name = habita.id + "";
                botonHabitat.Click += boton_Click;
                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush.Color = Color.FromArgb(255,73,67,9);
                SolidColorBrush Border = new SolidColorBrush();
                Border.Color = Color.FromArgb(255, 118, 107, 17);
                botonHabitat.Foreground = mySolidColorBrush;
                botonHabitat.BorderBrush = Border;
                botonHabitat.Width = 393;
                controlBotonesHabitat.Children.Add(botonHabitat);
            }
            foreach (AvesBD aveLista in aves)
            {
                Button botonAve = new Button();
                botonAve.Content = aveLista.nomAve;
                botonAve.Name = aveLista.id + "-ave";
                botonAve.Click += botonAve_Click;
                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush.Color = Color.FromArgb(255, 73, 67, 9);
                SolidColorBrush Border = new SolidColorBrush();
                Border.Color = Color.FromArgb(255, 118, 107, 17);
                botonAve.Foreground = mySolidColorBrush;
                botonAve.BorderBrush = Border;
                listAveMenu.Children.Add(botonAve);
            }
            foreach (PorqueDB porLista in porque)
            {
                Button botonPorque = new Button();
                botonPorque.Content = porLista.nomPor;
                botonPorque.Name = porLista.id +"-por";
                botonPorque.Click += botonPor_Click;
                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush.Color = Color.FromArgb(255, 73, 67, 9);
                SolidColorBrush Border = new SolidColorBrush();
                Border.Color = Color.FromArgb(255, 118, 107, 17);
                botonPorque.Foreground = mySolidColorBrush;
                botonPorque.BorderBrush = Border;
                listPorMenu.Children.Add(botonPorque);
            }
            
        }
        

        void botonAve_Click(object sender, RoutedEventArgs e)
        {
            string[] idAve = ((Button)sender).Name.Split('-');
            NavigationService.Navigate(new Uri("/Aves.xaml?idAve=" + idAve[0], UriKind.Relative));

        }

        void boton_Click(object sender, RoutedEventArgs e)
        {
            Button boton = ((Button)sender);
            NavigationService.Navigate(new Uri("/Habitat.xaml?Pagina="+boton.Name, UriKind.Relative));
        }
        
        void botonPor_Click(object sender, RoutedEventArgs e)
        {
            string[] idPor = ((Button)sender).Name.Split('-');
            NavigationService.Navigate(new Uri("/Porque.xaml?idPor="+ idPor[0], UriKind.Relative));
        }
        

    }
}
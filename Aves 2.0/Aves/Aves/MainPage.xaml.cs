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
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            crearBD();
        }
        private void crearBD()
        {
            using (baseDatosDataContext contextoBD = new baseDatosDataContext("Data source='isostore:/baseDatosBD.sdf'"))
            {
                if (!contextoBD.DatabaseExists())
                {
                    contextoBD.CreateDatabase();
                    HabitatClass habit = new HabitatClass();
                    AvesClass ave = new AvesClass();
                    contextoBD.HabitatDB.InsertAllOnSubmit(habit.habitatDB);
                    contextoBD.AvesBD.InsertAllOnSubmit(ave.aves);
                    contextoBD.SubmitChanges();
                    
                }
            }
        }
       
        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Menu.xaml", UriKind.Relative));
        }
    }
}
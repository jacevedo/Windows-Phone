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
    public partial class PanoramaPage1 : PhoneApplicationPage
    {
      
        public PanoramaPage1()
        {
            InitializeComponent();
        }
        
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            stackListaAvesTotal.Children.Clear();

            string newText = string.Empty;
            int idViene=0;
            
            if (NavigationContext.QueryString.TryGetValue("Pagina", out newText))
            {
                idViene=Convert.ToInt32(newText.Trim());
            }

            using (baseDatosDataContext contextoBD = new baseDatosDataContext("Data source='isostore:/baseDatosBD.sdf'"))
            {
                HabitatDB habitat = (from x in contextoBD.HabitatDB
                                     where x.id == idViene
                                     select x).First();
                List<AvesBD> ave = (from y in contextoBD.AvesBD
                                    where y.idHabitat == habitat.id
                                    select y).ToList();
                int contador = ave.Count;
                foreach (AvesBD aves in ave)
                {
                    Button botones = new Button();
                    botones.Content=aves.nomAve;
                    botones.Name = aves.id + "";
                    botones.Click += boton_Click;
                    botones.Background = new SolidColorBrush(Colors.Black);
                    stackListaAvesTotal.Children.Add(botones);
                }
                titlee.Title = habitat.nom_Habitat;
                txtDescripcionHabitat.Text = habitat.descripcion;

                
            }
            base.OnNavigatedTo(e);

        }

        void boton_Click(object sender, RoutedEventArgs e)
        {
            String id = ((Button)sender).Name;
            NavigationService.Navigate(new Uri("/Aves.xaml?idAve=" + id, UriKind.Relative));
        }
        


    }
}
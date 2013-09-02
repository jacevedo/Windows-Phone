using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace generadorTorneosYLigas
{
    public partial class Liga : PhoneApplicationPage
    {
        List<String> listaPersonas;
        int idTorneo = -1;
        public Liga()
        {
            InitializeComponent();
            this.Loaded +=Liga_Loaded;
        }

        void Liga_Loaded(object sender, RoutedEventArgs e)
        {
            Torneo torneo = new Torneo();
            listaPersonas  =  torneo.obtenerParticipantes(idTorneo);
            for (var i = 0; i < listaPersonas.Count; i++ )
            {
                ColumnDefinition columna = new ColumnDefinition();

                columna.Width = new GridLength(1, GridUnitType.Star);
                RowDefinition fila = new RowDefinition();
                fila.Height = new GridLength(1, GridUnitType.Star);
                ContentPanel.ColumnDefinitions.Add(columna);
                ContentPanel.RowDefinitions.Add(fila);

                
                TextBlock txt1 = new TextBlock();
                TextBlock txt2 = new TextBlock();
                Grid.SetColumn(txt1,i+1);
                Grid.SetRow(txt1,0);
                Grid.SetColumn(txt2, 0);
                Grid.SetRow(txt2, i+1);
                txt1.Text = listaPersonas.ElementAt(i);
                txt2.Text = listaPersonas.ElementAt(i);
                ContentPanel.Children.Add(txt1);
                ContentPanel.Children.Add(txt2);
            }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string newText = string.Empty;
             if (NavigationContext.QueryString.TryGetValue("idTorneo", out newText))
             {
                 idTorneo = Convert.ToInt32(newText);
                 
             }
            base.OnNavigatedTo(e);
        }
    }
}
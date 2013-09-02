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
    public partial class Configuraciones : PhoneApplicationPage
    {
        Torneo torneo;
        int idTorneo = 0;
        public Configuraciones()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Torneo torneo = new Torneo();
            idTorneo = torneo.guardarTorneo();
            int cantParticipantes = Convert.ToInt32(txtCantParticipantes.Text.ToString());
            for (int i = 0; i != cantParticipantes; i++)
            {
                int x = i + 1;
                TextBlock lblPersona = new TextBlock();
                lblPersona.Text = "Persona " + x;
                TextBox txtPersona = new TextBox();
                stackNombres.Children.Add(lblPersona);
                stackNombres.Children.Add(txtPersona);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBlock txt = new TextBlock();
            List<string> participantes = new List<string>();
            foreach (var item in stackNombres.Children.ToList())
            {
                if (item.GetType() != txt.GetType())
                {
                    TextBox txtBox  = item as TextBox;
                    participantes.Add(txtBox.Text.ToString());
                }
            }
            torneo = new Torneo(participantes);
            torneo.guardarDatos(idTorneo);
            NavigationService.Navigate(new Uri("/Liga.xaml?idTorneo=" + idTorneo, UriKind.Relative));
        }

    }
}
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
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Media;
using System.Net.NetworkInformation;
using Telerik.Windows.Controls;

namespace RadioBomberil
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameworkDispatcher.Update();
            
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show("Debes tener Coneccion a internet para escuchar la radio");
            }
            if ((MediaPlayer.State == MediaState.Playing || MediaPlayer.State == MediaState.Paused) && NetworkInterface.GetIsNetworkAvailable())
            {
                
                RadMessageBox.Show("Antes que nada", MessageBoxButtons.YesNo, "Si presionas si," +
                        " se pondra en stop el reproductor de musica, " +
                        "debido a que lo necesitamos Para la radio", closedHandler: (arg) =>
                        {
                            int indexBoton = arg.ButtonIndex;
                            switch (indexBoton)
                            {
                                case 0:

                                    FrameworkDispatcher.Update();
                                    MediaPlayer.Stop();
                                    NavigationService.Navigate(new Uri("/ReproductorMusica.xaml", UriKind.Relative));
                                    break;
                                case 1:
                                  
                                    break;
                            }
                        });
            }
            if (NetworkInterface.GetIsNetworkAvailable() && MediaPlayer.State == MediaState.Stopped) 
            {
                NavigationService.Navigate(new Uri("/ReproductorMusica.xaml", UriKind.Relative));
            }
        }

       
    }
}
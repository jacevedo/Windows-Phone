using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework;
using Telerik.Windows.Controls;
using System.Net.NetworkInformation;

namespace RadioBomberil
{
    public partial class ReproductorMusica : PhoneApplicationPage
    {
        private bool reproduciendo = true;
        public ReproductorMusica()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }
        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {


            Song voz = Song.FromUri("name", new Uri("http://audio4.radioreference.com/215715007", UriKind.RelativeOrAbsolute));
            //Song voz = Song.FromUri("name", new Uri(" http://relay.broadcastify.com:80/72770562", UriKind.RelativeOrAbsolute));

            FrameworkDispatcher.Update();
            if (MediaPlayer.State == MediaState.Stopped)
            {
                MediaPlayer.Stop();
                //MediaPlayer.Volume = volumen;
                MediaPlayer.Play(voz);
            }
            else
            {
                //MediaPlayer.Volume = volumen;
                MediaPlayer.Play(voz);
            }
        }
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            FrameworkDispatcher.Update();
            if (MediaPlayer.State == MediaState.Playing || MediaPlayer.State == MediaState.Paused)
            {
                MediaPlayer.Stop();
            }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button boton = sender as Button;
            if (reproduciendo)
            {
                boton.Content = "Reproducir Radio";
                FrameworkDispatcher.Update();
                if (MediaPlayer.State == MediaState.Playing || MediaPlayer.State == MediaState.Paused)
                {
                    MediaPlayer.Stop();
                }
                reproduciendo = false;
            }
            else
            {
                boton.Content = "Parar Radio";
                Song voz = Song.FromUri("name", new Uri("http://audio4.radioreference.com/215715007", UriKind.RelativeOrAbsolute));
                FrameworkDispatcher.Update();
                FrameworkDispatcher.Update();
                if (MediaPlayer.State == MediaState.Stopped)
                {
                    MediaPlayer.Stop();
                    //MediaPlayer.Volume = volumen;
                    MediaPlayer.Play(voz);
                }
                else
                {
                    //MediaPlayer.Volume = volumen;
                    MediaPlayer.Play(voz);
                }
                reproduciendo = true;
            }
            
        }
    }
}
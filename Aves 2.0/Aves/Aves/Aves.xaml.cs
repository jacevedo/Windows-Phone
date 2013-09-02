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
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace Aves
{
    public partial class Aves : PhoneApplicationPage
    {
        string urlAudio = "";
        public Aves()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            AvesBD ave;
            int idAve = 0;
            string newText;
            if (NavigationContext.QueryString.TryGetValue("idAve", out newText))
            {
                idAve = Convert.ToInt32(newText.Trim());
            }
            using (baseDatosDataContext contextoBD = new baseDatosDataContext("Data source='isostore:/baseDatosBD.sdf'"))
            {
                ave = (from x in contextoBD.AvesBD
                       where x.id == idAve
                       select x).First();
            }
            tituloAve.Title = ave.nomAve;

            TextBlock txtNombre = new TextBlock();
            txtNombre.Text = ave.nomAve;
            txtNombre.TextWrapping = TextWrapping.Wrap;
            TextBlock txtDatos = new TextBlock();
            txtDatos.Text = ave.Datos;
            txtDatos.Foreground = new SolidColorBrush(Colors.White);
            txtDatos.TextWrapping = TextWrapping.Wrap;
            TextBlock txtFicha = new TextBlock();
            txtFicha.Text = ave.Ficha;
            txtFicha.Foreground = new SolidColorBrush(Colors.White);
            txtFicha.TextWrapping = TextWrapping.Wrap;
            contentFicha.Children.Add(txtFicha);
            contentDatos.Children.Add(txtDatos);

            urlAudio = ave.urlSonido;
            base.OnNavigatedTo(e);
        }

        private void btnReproducirSonido_Click(object sender, RoutedEventArgs e)
        {
            
            PlaySound(urlAudio);
            
        }

        public void PlaySound(String soundFile)
        {
            Song song = Song.FromUri("name",new Uri(soundFile, UriKind.Relative));
            FrameworkDispatcher.Update();
            if (MediaPlayer.State == MediaState.Stopped)
            {
                MediaPlayer.Play(song);
                btnReproducirSonido.Content = "Detener";
            }
            else
            {
                if (MediaPlayer.State == MediaState.Stopped)
                {
                    MediaPlayer.Play(song);
                    btnReproducirSonido.Content = "Detener";
                }
                else
                    MediaPlayer.Stop();
                btnReproducirSonido.Content = "Escuchar Canto";
            }
        }
    }
}

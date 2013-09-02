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
using System.Windows.Media.Imaging;

namespace Botella
{
    public partial class MainPage : PhoneApplicationPage
    {
        double valor = 0;
        bool parado = true;
        Dictionary<Int32, String> diccionario;
       
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            diccionario = new Dictionary<Int32, string>();
            llenarDiccionario();
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            ImageBrush brocha = new ImageBrush();
            brocha.Stretch = Stretch.Uniform;
                
            if(settings.Contains("botella"))
            {
                int botella = Convert.ToInt32(settings["botella"].ToString());
                
                switch (botella)
                {
                    case 1:
                        brocha.ImageSource = new BitmapImage(new Uri(@"imagenes/botella.png", UriKind.Relative));
                        botellaARotar.Fill = brocha;
                        break;
                    case 2:
                         brocha.ImageSource = new BitmapImage(new Uri(@"imagenes/imagenesBotellas/1.png",UriKind.Relative));
                        botellaARotar.Fill = brocha;
                        break;
                    case 3:
                         brocha.ImageSource = new BitmapImage(new Uri(@"imagenes/imagenesBotellas/2.png",UriKind.Relative));
                        botellaARotar.Fill = brocha;
                        break;
                    case 4:
                         brocha.ImageSource = new BitmapImage(new Uri(@"imagenes/imagenesBotellas/3.png",UriKind.Relative));
                        botellaARotar.Fill = brocha;
                        break;
                    case 5:
                         brocha.ImageSource = new BitmapImage(new Uri(@"imagenes/imagenesBotellas/4.png",UriKind.Relative));
                        botellaARotar.Fill = brocha;
                        break;
                    case 6:
                         brocha.ImageSource = new BitmapImage(new Uri(@"imagenes/imagenesBotellas/5.png",UriKind.Relative));
                        botellaARotar.Fill = brocha;
                        break;
                    case 7:
                         brocha.ImageSource = new BitmapImage(new Uri(@"imagenes/imagenesBotellas/6.png",UriKind.Relative));
                        botellaARotar.Fill = brocha;
                        break;
                    case 8:
                         brocha.ImageSource = new BitmapImage(new Uri(@"imagenes/imagenesBotellas/7.png",UriKind.Relative));
                        botellaARotar.Fill = brocha;
                        break;
                    case 9:
                        brocha.ImageSource = new BitmapImage(new Uri(@"imagenes/imagenesBotellas/8.png", UriKind.Relative));
                        botellaARotar.Fill = brocha;
                        break;
                }
            }
            else
            {
                brocha.ImageSource = new BitmapImage(new Uri(@"imagenes/botella.png", UriKind.Relative));
                botellaARotar.Fill = brocha;
            }
        }

        private void llenarDiccionario()
        {
            diccionario.Add(1, "El que toco la botella diga una verdad");
            diccionario.Add(2, "El que toco la botella debe darle un beso al que apunto la botella");
            diccionario.Add(3, "Al que apunto la botella debe decir una verdad");
            diccionario.Add(4, "El que toco la botella tiene que sacarse una prenda");
            diccionario.Add(5, "El que toco y a quien apunto la botella tienen que sacarse una prenda");
            diccionario.Add(6, "El que toco la botella tiene que tomar un trago de algo");
            diccionario.Add(7, "Al que apunto la botella tiene que tomar un trago de algo");
            diccionario.Add(8, "Al que apunto la botella tiene que hacer una penitencia a eleccion de quien toco la botella");
            diccionario.Add(9, "El que toco la botella tiene que hacer una penitencia a eleccion de quien apunto la botella");
            diccionario.Add(10, "Al que apunto la botella tiene que sacarse una prenda");
            diccionario.Add(11, "El que toco y a quien apunto la botella tienen que hacer una penitencia");
            diccionario.Add(12, "El que toco y a quien apunto la botella tienen que bailar una cancion random");
            diccionario.Add(13, "El que toco la botella puede imponer una regla para el juego");
            diccionario.Add(14, "A quien apunto la botella puede imponer una regla para el juego");
            diccionario.Add(15, "El que toco la botella tiene que hacer 10 sentadillas o 10 flexiones de brazos");
            diccionario.Add(16, "A quien apunto la botella tiene que hacer 10 sentadillas o 10 flexiones de brazos");
            diccionario.Add(17, "El que toco la botella tiene que tomar 3 tragos o dividirlo entre 3 personas");
            diccionario.Add(18, "A quien apunto la botella tiene que tomar 3 tragos o dividirlo entre 3 personas");
        }

        private void Ellipse_Tap_1(object sender, GestureEventArgs e)
        {
            if (parado)
            {
                parado = false;
                Random r = new Random();
                PerformAnimation(valor, r.Next(500, 2000), r);
            }            
        }
        private void PerformAnimation(double oldValue, double newValue,Random r)
        {
            Storyboard s = new Storyboard();
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = oldValue;
            animation.To = newValue;
            animation.Duration = new Duration(TimeSpan.FromSeconds(r.Next(1,4)));
            
            s.Children.Add(animation);


            Storyboard.SetTarget(animation, botellaARotar);
            Storyboard.SetTargetProperty(animation, new PropertyPath("(Rectangle.RenderTransform).(RotateTransform.Angle)"));

            s.Begin();
            s.Completed += s_Completed;
            valor = newValue;

        }

        void s_Completed(object sender, EventArgs e)
        {
            parado = true;
            Random r = new Random();
            MessageBox.Show(diccionario[r.Next(1,18)]);
        }
    }
}
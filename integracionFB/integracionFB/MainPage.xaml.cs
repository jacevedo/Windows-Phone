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
using Facebook;
using System.IO.IsolatedStorage;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.IO;

namespace integracionFB
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        private const string FBApi = "162150583970123";
        private FacebookClient fbClient;
        public MainPage()
        {
            InitializeComponent();
            fbClient = new FacebookClient();
            fbClient.PostCompleted += fbClient_PostCompleted;
            //Nos logeamos con el token q ya existia
            if (ObtenerToken() != null)
            {
                fbClient.AccessToken = ObtenerToken();
            }
        }

        void fbClient_PostCompleted(object sender, FacebookApiEventArgs e)
        {
            if(e.Error!=null)
            {
                if (e.Error is FacebookOAuthException)
                {
                    Dispatcher.BeginInvoke(() => MessageBox.Show("Error de Autorizacion, favor re-logearse"));
                    //se elimina el actual token de registro
                    guardarTokenRegistro(null);
                    fbClient.AccessToken = null;
                }
                else
                {
                    Dispatcher.BeginInvoke(() => MessageBox.Show(e.Error.Message));
                }
            }
            else
            {
                Dispatcher.BeginInvoke(() => MessageBox.Show("Mensaje Posteado con exito"));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Parametros del cliente de facebook
            var parametros = new Dictionary<string, object>();
            parametros["client_id"] = FBApi;
            parametros["redirect_uri"] = "https://www.facebook.com/connect/login_success.html";
            parametros["response_type"] = "token";
            parametros["display"] = "touch";
            //Ahora especificamos que datos queremos del usuario, en este caso solo publicar en el muro
            parametros["scope"] = "publish_stream";
            Browser.Visibility = System.Windows.Visibility.Visible;
            Browser.Navigate(fbClient.GetLoginUrl(parametros));
        }

        private void Browser_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            FacebookOAuthResult oauthResult;
            if (!fbClient.TryParseOAuthCallbackUrl(e.Uri, out oauthResult))
            {
                return;
            }
            //Revisamos que el usuario haya sido logueado con exito, sino mandamos un mensaje de error
            if (oauthResult.IsSuccess)
            {
                //resultado del proseso
                fbClient.AccessToken = oauthResult.AccessToken;
                //ocultamos el navegador y llamamos al metodo de posteo
                Browser.Visibility = System.Windows.Visibility.Collapsed;
                postearEnElMuro();
            }
            else
            {
                //Process Error
                MessageBox.Show(oauthResult.ErrorDescription);
                Browser.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void postearEnElMuro()
        {
            /*StreamResourceInfo sri = Application.GetResourceStream(new Uri("imagenes/iron_man.jpg", UriKind.Relative));
            
            BitmapImage src = new BitmapImage();
            src.SetSource(sri.Stream);
            
            var parametros = new Dictionary<string,object>();
            parametros["message"] = Message.Text;


            string attachementPath = "iron man";

            var file = new FacebookMediaStream
            {
                ContentType = "imagenes/iron_man.jpg",
                FileName = "iron man"
            };
            parametros["photos"] = file;*/

            //Se obtiene la imagen desde una ruta
            var res = Application.GetResourceStream(new Uri("imagenes/iron_man.jpg", UriKind.Relative));
            //se crea el streaming para leer el archivo
            var fileStream = res.Stream;
            //se crea el array de bytes con el largo del archivo
            byte[] buffer = new byte[fileStream.Length];
            //se leen los bytes del archivo y se almacena en el buffer
            fileStream.Read(buffer, 0, (int)fileStream.Length);
            //Se crea el diccionario que contiene todos los datos que seran enviados a fb
            var parameters = new Dictionary<string, object>();
           //Se coloca el texto de la imagen
            parameters["name"] = "Description for the pic";
            //se crea el tipo de imagen a postear
            parameters["TestPic"] = new FacebookMediaObject
            {
                //Tipo de objeto
                ContentType = "image/jpeg",
                //nombre del archivo para facebook
                FileName = "photo_name.jpg"

                //se setea el contenido de imagen (array de bytes)
            }.SetValue(buffer);
            //se envia la foto  (me/fotos) solo texto (me/feed)
            fbClient.PostAsync("me/photos", parameters);
        }
       
        private void guardarTokenRegistro(string token)
        {
            if (!IsolatedStorageSettings.ApplicationSettings.Contains("token"))
            {
                IsolatedStorageSettings.ApplicationSettings.Add("token", token);
            }
            else
            {
                IsolatedStorageSettings.ApplicationSettings["token"] = token;
            }
            IsolatedStorageSettings.ApplicationSettings.Save();
        }
        private string ObtenerToken()
        {
            //Si no existe el token retorna null
            if (!IsolatedStorageSettings.ApplicationSettings.Contains("token"))
            {
                return null;
            }
            else
            {
                return IsolatedStorageSettings.ApplicationSettings["token"] as string;
            }
        }
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            //Si el navegador esta visible lo oculta y cancela el sistema de logeo
            if (Browser.Visibility == System.Windows.Visibility.Visible)
            {
                Browser.Visibility = System.Windows.Visibility.Collapsed;
                e.Cancel = true;
            }
            base.OnBackKeyPress(e);
        }
       

    }
}
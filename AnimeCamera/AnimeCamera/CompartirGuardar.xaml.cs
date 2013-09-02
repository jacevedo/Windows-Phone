using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;
using System.IO.IsolatedStorage;
using Microsoft.Phone;
using System.IO;
using Facebook;
using Coding4Fun.Toolkit.Controls;
using Microsoft.Xna.Framework.Media;

namespace AnimeCamera
{
    public partial class CompartirGuardar : PhoneApplicationPage
    {
        private const string FBApi = "162150583970123";
        private FacebookClient fbClient;
        InputPrompt ip = new InputPrompt();
        private string post = "";
        MediaLibrary library = new MediaLibrary();
        public CompartirGuardar()
        {
            InitializeComponent();
            this.Loaded += CompartirGuardar_Loaded;
        }

        void CompartirGuardar_Loaded(object sender, RoutedEventArgs e)
        {
            ReadFromIsolatedStorage("FotoSacada");
            fbClient = new FacebookClient();
            fbClient.PostCompleted += fbClient_PostCompleted;
            //Nos logeamos con el token q ya existia
            if (ObtenerToken() != null)
            {
                fbClient.AccessToken = ObtenerToken();
            }
            ip.Message = "Ingresa el texto de tu post.";
            ip.Title = "Compartir en Facebook";
            ip.Completed += new EventHandler<PopUpEventArgs<string, PopUpResult>>(prompt_Completed);
            ip.Width = 470;
        }

        void fbClient_PostCompleted(object sender, FacebookApiEventArgs e)
        {
            if (e.Error != null)
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

            Dispatcher.BeginInvoke(() =>navegarCamara());
        }
        private void ReadFromIsolatedStorage(string fileName)
        {
            WriteableBitmap bitmap = new WriteableBitmap(680, 480);
            using (IsolatedStorageFile myIsolatedStorage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream fileStream = myIsolatedStorage.OpenFile(fileName, FileMode.Open, FileAccess.Read))
                {
                    // Decode the JPEG stream.
                    bitmap = PictureDecoder.DecodeJpeg(fileStream);
                }
            }
            this.imagenTotal.Source = bitmap;
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
            //IsolatedStorageFileStream fileStream ;
            using (IsolatedStorageFile myIsolatedStorage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream fileStreamm = myIsolatedStorage.OpenFile("FotoSacada", FileMode.Open, FileAccess.Read))
                {
                    //se crea el streaming para leer el archivo

                    //se crea el array de bytes con el largo del archivo
                    byte[] buffer = new byte[fileStreamm.Length];
                    //se leen los bytes del archivo y se almacena en el buffer
                    fileStreamm.Read(buffer, 0, (int)fileStreamm.Length);
                    //Se crea el diccionario que contiene todos los datos que seran enviados a fb
                    var parameters = new Dictionary<string, object>();
                    //Se coloca el texto de la imagen
                    parameters["name"] = post;
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
            }
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
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            //Si el navegador esta visible lo oculta y cancela el sistema de logeo
            if (Browser.Visibility == System.Windows.Visibility.Visible)
            {
                Browser.Visibility = System.Windows.Visibility.Collapsed;
                e.Cancel = true;
            }
            else
            {
                NavigationService.Navigate(new Uri("/FotoTomada.xaml", UriKind.Relative));
            }
            base.OnBackKeyPress(e);
        }

       

        private void prompt_Completed(object sender, PopUpEventArgs<string, PopUpResult> e)
        {
            if (ip.Value == "")
            {
                MessageBox.Show("No Ingresaste Texto, la foto no se compartira en Facebook");
            }
            else
            {
                guardarFacebook(ip.Value);
                
               
            }
        }

        private void guardarFacebook(string p)
        {
            post = p;
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

        

        private void guardarLocal()
        {
            Random r = new Random();
            int numFoto = r.Next(0, 5000);
            string fileName = numFoto + ".jpg";
            using (IsolatedStorageFile myIsolatedStorage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream fileStreamm = myIsolatedStorage.OpenFile("FotoSacada", FileMode.Open, FileAccess.Read))
                {
                    Deployment.Current.Dispatcher.BeginInvoke(delegate()
                    {
                        MessageBox.Show("Guardando Imagen.");
                    });
                    library.SavePictureToCameraRoll(fileName, fileStreamm);
                    Deployment.Current.Dispatcher.BeginInvoke(delegate()
                    {
                        MessageBox.Show("Foto Guardada en el telefono");
                    });
                }
            }
        }
        private void Ellipse_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            guardarLocal();
            navegarCamara();
        }
        private void Ellipse_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            post = "";
            ip.Show();
           
        }

        private void Ellipse_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            post = "";
            guardarLocal();
            ip.Show();
        }
        private void navegarCamara()
        {
            NavigationService.RemoveBackEntry();
            NavigationService.RemoveBackEntry();
            NavigationService.Navigate(new Uri("/MainPage.xaml",UriKind.Relative));
        }
    }
}
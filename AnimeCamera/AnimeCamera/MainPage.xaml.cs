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
using Microsoft.Devices;
using Microsoft.Xna.Framework.Media;
using System.Diagnostics;
using System.IO;
using System.IO.IsolatedStorage;
using System.Windows.Media.Imaging;
using Telerik.Windows.Controls;
using System.Windows.Threading;

namespace AnimeCamera
{
   
    public partial class MainPage : PhoneApplicationPage
    {
        private int photoCounter = 0;
        PhotoCamera cam;
        MediaLibrary library = new MediaLibrary();
        PageOrientation lastOrientation;
        private int estado = 0;
        private bool isFrontal = false;
        bool cincoSeg = true;
        bool diezSeg = true;
        bool quinceSeg = true;
        bool treintaSeg = true;
        bool sesentaSeg = true;
        DispatcherTimer dt;
        DispatcherTimer dt2;
        DispatcherTimer dt3;
        DispatcherTimer dt4;
        DispatcherTimer dt5;
        private Stream stream;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
            lastOrientation = this.Orientation;
           
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            dt = new DispatcherTimer();
            dt2 = new DispatcherTimer();
            dt3 = new DispatcherTimer();
            dt4 = new DispatcherTimer();
            dt5 = new DispatcherTimer();
            if (PhotoCamera.IsCameraTypeSupported(CameraType.FrontFacing) == false)
            {
                btnCambiarCamara.Visibility = System.Windows.Visibility.Collapsed;
            }
            
        }

        
        protected override void OnNavigatedTo (System.Windows.Navigation.NavigationEventArgs e)
        {
          
            if (NavigationService.CanGoBack)
            {
                NavigationService.RemoveBackEntry();
            }
            if (PhotoCamera.IsCameraTypeSupported(CameraType.Primary) == true)
            {
                cam = new PhotoCamera(CameraType.Primary);
                
                   
                cam.CaptureImageAvailable += new EventHandler<Microsoft.Devices.ContentReadyEventArgs>(cam_CaptureImageAvailable);
                viewfinderTransform.Rotation = cam.Orientation;
                
                viewfinderBrush.SetSource(cam);
                
            }
            else
            {
                //txtMessage.Text = "A Camera is not available on this device.";
            }
        }


      
        void cam_CaptureImageAvailable(object sender,Microsoft.Devices.ContentReadyEventArgs e)
        {
            
            stream = e.ImageStream;
            
            photoCounter++;
            
            Deployment.Current.Dispatcher.BeginInvoke(delegate()
            {
                var bitmap = new BitmapImage();
                bitmap.SetSource(e.ImageStream);
                if(transformImage.Rotation==0)
                {
                    transformImage.Rotation += 90;             
                }
                imgFoto.Source = bitmap;
                viewfinderCanvas.Visibility = System.Windows.Visibility.Collapsed;
                SaveToIsolatedStorage(stream, "FotoSacada"); 
            });
           
           
        }

        private void SaveToIsolatedStorage(Stream stream, string fileName)
        {
            using (IsolatedStorageFile myIsolatedStorage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (myIsolatedStorage.FileExists(fileName))
                {
                    myIsolatedStorage.DeleteFile(fileName);
                }

                IsolatedStorageFileStream fileStream = myIsolatedStorage.CreateFile(fileName);
                BitmapImage bitmap = new BitmapImage();
                bitmap.SetSource(stream);

                WriteableBitmap wb = new WriteableBitmap(bitmap);
                wb.SaveJpeg(fileStream, wb.PixelWidth, wb.PixelHeight, 0, 85);
                
               
                fileStream.Close();

            }
        }
        protected override void OnNavigatingFrom   (System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            if (cam != null)
            {
                cam.Dispose();
            }
        }
        protected override void OnOrientationChanged(OrientationChangedEventArgs e)
        {
            PageOrientation newOrientation = e.Orientation;
            Debug.WriteLine("New orientation: " + newOrientation.ToString());

            // Orientations are (clockwise) 'PortraitUp', 'LandscapeRight', 'LandscapeLeft'

            RotateTransition transitionElement = new RotateTransition();
            if (cam != null)
            {
                Dispatcher.BeginInvoke(() =>
                {
                    double rotation = cam.Orientation;
                    switch (this.Orientation)
                    {
                        case PageOrientation.PortraitDown:
                            cambiarProporcionesPortrait();
                            rotation = cam.Orientation + 90;
                           
                            break;
                        case PageOrientation.PortraitUp:
                            cambiarProporcionesPortrait();
                            rotation = cam.Orientation;
                            break;
                        case PageOrientation.LandscapeLeft:
                            cambiarProporcionesLandscapeIzquieda();
                            rotation = cam.Orientation - 90;
                            break;
                        case PageOrientation.LandscapeRight:
                            cambiarProporcionesLandscapeDerecha();
                            rotation = cam.Orientation + 90;
                            break;
                    }
                    viewfinderTransform.Rotation = rotation;
                });
            }
            // Execute the transition
            PhoneApplicationPage phoneApplicationPage = (PhoneApplicationPage)(((PhoneApplicationFrame)Application.Current.RootVisual)).Content;
            ITransition transition = transitionElement.GetTransition(phoneApplicationPage);
            transition.Completed += delegate
            {
                transition.Stop();
            };
            transition.Begin();

            lastOrientation = newOrientation;
            base.OnOrientationChanged(e);
        }
        #region Redimensionamiento Landscape Derecha
        private void cambiarProporcionesLandscapeDerecha()
        {
            Canvas.SetTop(controlArriba, 0);
            Canvas.SetLeft(controlArriba, 664);
            Canvas.SetTop(controlAbajo, 0);
            Canvas.SetLeft(controlAbajo, 0);
            Canvas.SetTop(viewfinderCanvas, 23);
            Canvas.SetLeft(viewfinderCanvas, 63);
            Canvas.SetTop(imgFoto, 23);
            Canvas.SetLeft(imgFoto, 63);

            Canvas.SetTop(btnTomarFoto, 207);
            Canvas.SetLeft(btnTomarFoto, 4);

            Canvas.SetTop(btnFlash, 303);
            Canvas.SetLeft(btnFlash, 4);

            Canvas.SetTop(btnCambiarCamara, 202);
            Canvas.SetLeft(btnCambiarCamara, 4);

            Canvas.SetTop(btnTimer, 101);
            Canvas.SetLeft(btnTimer, 4);

            Canvas.SetTop(btnSacaNuevaFoto, 420);
            Canvas.SetLeft(btnSacaNuevaFoto, 0);
            Canvas.SetTop(btnAceptar, 0);
            Canvas.SetLeft(btnAceptar, 4);
            

            viewfinderCanvas.Width = 600;
            viewfinderCanvas.Height = 440;

            imgFoto.Width = 600;
            imgFoto.Height = 440;
            controlArriba.Width = 64;
            controlArriba.Height = 481;
            controlAbajo.Width = 64;
            controlAbajo.Height = 481;       
        }
        #endregion
        #region Redimensionamiento Landscape Izquierda
        private void cambiarProporcionesLandscapeIzquieda()
        {

            Canvas.SetTop(controlArriba, 0);
            Canvas.SetLeft(controlArriba, 0);
            Canvas.SetTop(controlAbajo, 0);
            Canvas.SetLeft(controlAbajo, 664);
            Canvas.SetTop(viewfinderCanvas, 23);
            Canvas.SetLeft(viewfinderCanvas, 63);

            Canvas.SetTop(imgFoto, 23);
            Canvas.SetLeft(imgFoto, 63);

            Canvas.SetTop(btnTomarFoto, 208);
            Canvas.SetLeft(btnTomarFoto, 4);

            Canvas.SetTop(btnFlash, 101);
            Canvas.SetLeft(btnFlash, 4);

            Canvas.SetTop(btnCambiarCamara, 202);
            Canvas.SetLeft(btnCambiarCamara, 4);

            Canvas.SetTop(btnTimer, 303);
            Canvas.SetLeft(btnTimer, 4);

            Canvas.SetTop(btnSacaNuevaFoto, 0);
            Canvas.SetLeft(btnSacaNuevaFoto, 4);

            Canvas.SetTop(btnAceptar, 420);
            Canvas.SetLeft(btnAceptar, 0);
            
            viewfinderCanvas.Width = 600;
            viewfinderCanvas.Height = 440;
            imgFoto.Width = 600;
            imgFoto.Height = 440;
            controlArriba.Width = 64;
            controlArriba.Height = 481;
            controlAbajo.Width = 64;
            controlAbajo.Height = 481;        
   
        }
        #endregion
        #region Redimensionamiento Portrait
        private void cambiarProporcionesPortrait()
        {
            Canvas.SetTop(controlArriba, 0);
            Canvas.SetLeft(controlArriba, 0);
            Canvas.SetTop(controlAbajo, 708);
            Canvas.SetLeft(controlAbajo, 0);
            Canvas.SetTop(viewfinderCanvas, 87);
            Canvas.SetLeft(viewfinderCanvas, 15);
            Canvas.SetTop(imgFoto, 87);
            Canvas.SetLeft(imgFoto, 15);

            Canvas.SetTop(btnTomarFoto, 4);
            Canvas.SetLeft(btnTomarFoto, 208);

            Canvas.SetTop(btnFlash, 4);
            Canvas.SetLeft(btnFlash, 101);

            Canvas.SetTop(btnCambiarCamara, 4);
            Canvas.SetLeft(btnCambiarCamara, 202);

            Canvas.SetTop(btnTimer, 4);
            Canvas.SetLeft(btnTimer, 303);

            Canvas.SetTop(btnSacaNuevaFoto, 4);
            Canvas.SetLeft(btnSacaNuevaFoto, 420);

            Canvas.SetTop(btnAceptar, 4);
            Canvas.SetLeft(btnAceptar, 0);
            
            controlArriba.Width = 481;
            controlArriba.Height = 64;
            controlAbajo.Width = 481;
            controlAbajo.Height = 64;
            viewfinderCanvas.Width = 440;
            viewfinderCanvas.Height = 600;
            imgFoto.Width = 440;
            imgFoto.Height = 600;
        }
        #endregion


        private void btnTomarFoto_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            stop();
            sacarFoto();
        }
        #region flash
        private void btnFlash_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            BitmapImage btm;
            ImageBrush imagen = new ImageBrush();
           
            switch (cam.FlashMode)
            {
                case FlashMode.Off:
                    if (cam.IsFlashModeSupported(FlashMode.On))
                    {
                        // Specify that flash should be used.
                        cam.FlashMode = FlashMode.On;
                        btm = new BitmapImage(new Uri("iconos/64-Flash-On.png", UriKind.Relative));
                        imagen.ImageSource = btm;
                        btnFlash.Fill = imagen;
                     }
                    break;
                case FlashMode.On:
                    if (cam.IsFlashModeSupported(FlashMode.RedEyeReduction))
                    {
                        // Specify that the red-eye reduction flash should be used.
                        cam.FlashMode = FlashMode.RedEyeReduction;
                        btm = new BitmapImage(new Uri("iconos/64-Flash-On.png", UriKind.Relative));
                        imagen.ImageSource = btm;
                        btnFlash.Fill = imagen;
                    }
                    else if (cam.IsFlashModeSupported(FlashMode.Auto))
                    {
                        // If red-eye reduction is not supported, specify automatic mode.
                        cam.FlashMode = FlashMode.Auto;
                        btm = new BitmapImage(new Uri("iconos/64-Flash-Auto.png", UriKind.Relative));
                        imagen.ImageSource = btm;
                        btnFlash.Fill = imagen;
                      }
                    else
                    {
                        // If automatic is not supported, specify that no flash should be used.
                        cam.FlashMode = FlashMode.Off;
                        btm = new BitmapImage(new Uri("iconos/64-Flash-Off.png", UriKind.Relative));
                        imagen.ImageSource = btm;
                        btnFlash.Fill = imagen;
                      }
                    break;
                case FlashMode.RedEyeReduction:
                    if (cam.IsFlashModeSupported(FlashMode.Auto))
                    {
                        // Specify that the flash should be used in the automatic mode.
                        cam.FlashMode = FlashMode.Auto;
                        btm = new BitmapImage(new Uri("iconos/64-Flash-Auto.png", UriKind.Relative));
                        imagen.ImageSource = btm;
                        btnFlash.Fill = imagen;
                    }
                    else
                    {
                        // If automatic is not supported, specify that no flash should be used.
                        cam.FlashMode = FlashMode.Off;
                        btm = new BitmapImage(new Uri("iconos/64-Flash-Off.png", UriKind.Relative));
                        imagen.ImageSource = btm;
                        btnFlash.Fill = imagen;
                    }
                    break;
                case FlashMode.Auto:
                    if (cam.IsFlashModeSupported(FlashMode.Off))
                    {
                        // Specify that no flash should be used.
                        cam.FlashMode = FlashMode.Off;
                        btm = new BitmapImage(new Uri("iconos/64-Flash-Off.png", UriKind.Relative));
                        imagen.ImageSource = btm;
                        btnFlash.Fill = imagen;
                    }
                    break;
            }

            
        }
        #endregion
        #region cambiarCamara
        private void btnCambiarCamara_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (!isFrontal)
            {
                //cam.Dispose();
                cam = new PhotoCamera(CameraType.FrontFacing);
                cam.CaptureImageAvailable += new EventHandler<Microsoft.Devices.ContentReadyEventArgs>(cam_CaptureImageAvailable);
                viewfinderTransform.Rotation = cam.Orientation+180;

                viewfinderBrush.SetSource(cam);
                

                isFrontal = true;
            }
            else
            {
                //cam.Dispose();
                cam = new PhotoCamera(CameraType.Primary);
                cam.CaptureImageAvailable += new EventHandler<Microsoft.Devices.ContentReadyEventArgs>(cam_CaptureImageAvailable);
                viewfinderTransform.Rotation = cam.Orientation;

                viewfinderBrush.SetSource(cam);
                isFrontal = false;
            }
        }
        #endregion
        #region timer
        private void btnTimer_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            
            RadMessageBox.Show(botones(), "Tiempo del Timer", closedHandler: (arg) =>
                {
                    DialogResult resutl = arg.Result;
                    
                    int indexBoton = arg.ButtonIndex;
                    switch (indexBoton)
                    {
                        case 0:
                            cincoSeg = false;
                            estado = 1;
                            stop();
                            dt.Interval = new TimeSpan(0, 0, 0, 5);
                            dt.Tick += dt_Tick;
                            dt.Start();
                            break;
                        case 1:
                            diezSeg = false;
                            estado = 1;
                            stop();
                            dt2.Interval = new TimeSpan(0, 0, 0, 10);
                            dt2.Tick += dt_Tick;
                            dt2.Start();
                            break;
                        case 2:
                            quinceSeg = false;
                            estado = 1;
                            stop();
                            dt3.Interval = new TimeSpan(0, 0, 0, 15);
                            dt3.Tick += dt_Tick;
                            dt3.Start();
                            break;
                        case 3:
                            treintaSeg = false;
                            estado = 1;
                            stop();
                            dt4.Interval = new TimeSpan(0, 0, 0, 30);
                            dt4.Tick += dt_Tick;
                            dt4.Start();
                            break;
                        case 4:
                            sesentaSeg = false;
                            estado = 1;
                            stop();
                            dt5.Interval = new TimeSpan(0, 0, 0, 60);
                            dt5.Tick += dt_Tick;
                            dt5.Start();
                            break;
                    }
                   
                });
        }

        private string[] botones()
        {
            List<string> lista = new List<string>();

            if (cincoSeg)
            {
                lista.Add("5 seg");
            }
            if (diezSeg)
            {
                lista.Add("10 seg");
            }
            if (quinceSeg)
            {
                lista.Add("15 seg");
            }
            if (treintaSeg)
            {
                lista.Add("30 seg");
            }
            if (sesentaSeg)
            {
                lista.Add("60 seg");
            }
            return lista.ToArray();
        }
        
        private void stop()
        {
            if (dt.IsEnabled)
            {
                dt.Stop();
            }
            if (dt2.IsEnabled)
            {
                dt2.Stop();
            }
            if (dt3.IsEnabled)
            {
                dt3.Stop();
            }
            if (dt4.IsEnabled)
            {
                dt4.Stop();
            }
            if (dt5.IsEnabled)
            {
                dt5.Stop();
            }
        }
        void dt_Tick(object sender, EventArgs e)
        {
            stop();
            sacarFoto();
            
        }
        #endregion
        #region metodo Sacar Foto
        private void sacarFoto()
        {
            btnSacaNuevaFoto.Visibility = System.Windows.Visibility.Visible;
            btnAceptar.Visibility = System.Windows.Visibility.Visible;
            btnCambiarCamara.Visibility = System.Windows.Visibility.Collapsed;
            btnFlash.Visibility = System.Windows.Visibility.Collapsed;
            btnTimer.Visibility = System.Windows.Visibility.Collapsed;
            btnTomarFoto.Visibility = System.Windows.Visibility.Collapsed;
            try
            {
                cam.CaptureImage();
            }
            catch (InvalidOperationException ex)
            {
               // MessageBox.Show("Error con el timer");
            }
        }
        #endregion
        #region sacarFotoBoton
        private void btnSacaNuevaFoto_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            viewfinderCanvas.Visibility = System.Windows.Visibility.Visible;
            BitmapImage bitmap = new BitmapImage();
            imgFoto.Source = bitmap;
            btnTomarFoto.Visibility = System.Windows.Visibility.Visible;
            btnTimer.Visibility = System.Windows.Visibility.Visible;
            btnFlash.Visibility = System.Windows.Visibility.Visible; 
            if (PhotoCamera.IsCameraTypeSupported(CameraType.FrontFacing))
            {
                btnCambiarCamara.Visibility = System.Windows.Visibility.Visible;
            }
            btnAceptar.Visibility = System.Windows.Visibility.Collapsed;
            btnSacaNuevaFoto.Visibility = System.Windows.Visibility.Collapsed;
        }
        #endregion 
        private void btnAceptar_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //SaveToIsolatedStorage(stream, "FotoSacada");
            NavigationService.Navigate(new Uri("/FotoTomada.xaml", UriKind.Relative));
        }
    }
}
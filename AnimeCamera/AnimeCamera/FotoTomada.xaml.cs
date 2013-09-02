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
using System.Windows.Media;
using Telerik.Windows.Controls;

namespace AnimeCamera
{
    public partial class FotoTomada : PhoneApplicationPage
    {

        private int grilla = -1;
        IsolatedStorageSettings settings;
        public FotoTomada()
        {
            InitializeComponent();
            this.Loaded += FotoTomada_Loaded;
        }
        void FotoTomada_Loaded(object sender, RoutedEventArgs e)
        {
            ReadFromIsolatedStorage("FotoSacada");
            settings = IsolatedStorageSettings.ApplicationSettings;
            if (!settings.Contains("mostrarPopUp"))
            {
                settings.Add("mostrarPopUp","True");
            }
         
        }
        private void ReadFromIsolatedStorage(string fileName)
        {
            WriteableBitmap bitmap = new WriteableBitmap(480, 680);
            using (IsolatedStorageFile myIsolatedStorage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream fileStream = myIsolatedStorage.OpenFile(fileName, FileMode.Open, FileAccess.Read))
                {
                    // Decode the JPEG stream.
                    bitmap = PictureDecoder.DecodeJpeg(fileStream);
                }
            }
            this.imagenTomada.Source = bitmap;
            this.imagenTomada.Stretch = Stretch.Fill;
            //transformImageTomada.Rotation += 90;
        }
        #region fondos
        private void marco2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            imagenFondos.Source = new BitmapImage(new Uri("imagenes/marcos/marco2.png", UriKind.Relative));   
        }

        private void marco1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            imagenFondos.Source = new BitmapImage(new Uri("imagenes/marcos/marco1.png", UriKind.Relative));   
        }

        private void marco3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            imagenFondos.Source = new BitmapImage(new Uri("imagenes/marcos/marco3.png", UriKind.Relative));   
        }

        private void marco4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            imagenFondos.Source = new BitmapImage(new Uri("imagenes/marcos/marco4.png", UriKind.Relative));   
        }
        private void SinMarco_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            imagenFondos.Source = new BitmapImage();  
        }
        #endregion
        #region colocarimagenes
        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            CompositeTransform transform = new CompositeTransform();
            Image imagenTocada = sender as Image;
            Image imagenADibujar = new Image();
            imagenADibujar.Source = imagenTocada.Source;
            imagenADibujar.Stretch = Stretch.Fill;
            imagenADibujar.Height = 200;
            imagenADibujar.Width = 200;
            imagenADibujar.RenderTransformOrigin = new Point(0.5, 0.5);
            imagenADibujar.RenderTransform = transform;
            var gl = GestureService.GetGestureListener(imagenADibujar);
            gl.PinchDelta += gl_PinchDelta;
            gl.DoubleTap += gl_DoubleTap;
            imagenADibujar.ManipulationDelta += imagenADibujar_ManipulationDelta;
            Canvas.SetTop(imagenADibujar, 200);
            Canvas.SetLeft(imagenADibujar, 200);
            canvasFotos.Children.Add(imagenADibujar);
            
        }
        #endregion
        void gl_DoubleTap(object sender, Microsoft.Phone.Controls.GestureEventArgs e)
        {
            if (settings["mostrarPopUp"].ToString()=="True")
            {
                RadMessageBox.Show("Eliminar Objeto", MessageBoxButtons.YesNo, "¿Desea Eliminar El Objeto?", "Volver a mostrar el mensaje", true,closedHandler: (arg) =>
                {
                    DialogResult resutl = arg.Result;
                    
                    int indexBoton = arg.ButtonIndex;
                    switch (indexBoton)
                    {
                        case 0:
                            canvasFotos.Children.Remove(sender as UIElement);
                            settings["mostrarPopUp"] = arg.IsCheckBoxChecked.ToString();
                            break;
                        case 1:
                            break;
                        
                    }
                });
            }
            else
            {
                canvasFotos.Children.Remove(sender as UIElement);
            }
        }
        void gl_PinchDelta(object sender, PinchGestureEventArgs e)
        {
            UIElement element = sender as UIElement;

            //element.RenderTransform = transform;
            CompositeTransform transformm = element.RenderTransform as CompositeTransform;
            transformm.ScaleX = e.DistanceRatio;
            transformm.ScaleY = e.DistanceRatio;
            transformm.Rotation = e.TotalAngleDelta;
          
                        
        }
        void imagenADibujar_ManipulationDelta(object sender, System.Windows.Input.ManipulationDeltaEventArgs e)
        {
           // throw new NotImplementedException();
            UIElement element = sender as UIElement;

           // element.RenderTransform = transform;
            CompositeTransform transformm = element.RenderTransform as CompositeTransform;
            if (transformm != null)
            {
                transformm.TranslateX += e.DeltaManipulation.Translation.X;
                transformm.TranslateY += e.DeltaManipulation.Translation.Y;
            }
            
        }

        private void fondos_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ocultarTodo();
            if (grilla != 0)
            {
                grillaFondos.Visibility = System.Windows.Visibility.Visible;
                grilla = 0;
            }
            else
            {
                grilla = -1;
            }
        }

       
        private void pelos_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ocultarTodo();
            if (grilla != 1)
            {
                grillaPelos.Visibility = System.Windows.Visibility.Visible;
                grilla = 1;
            }
            else
            {
                grilla = -1;
            }
        }

        private void ojos_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ocultarTodo();
            if (grilla != 2)
            {
                grillaOjos.Visibility = System.Windows.Visibility.Visible;
                grilla = 2;
            }
            else
            {
                grilla = -1;
            }

        }

        private void gatos_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ocultarTodo();
            if (grilla != 3)
            {
                grillaGatos.Visibility = System.Windows.Visibility.Visible;
                grilla = 3;
            }
            else
            {
                grilla = -1;
            }
        }

        private void comida_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ocultarTodo();
            if (grilla != 4)
            {
                grillaComida.Visibility = System.Windows.Visibility.Visible;
                grilla = 4;
            }
            else
            {
                grilla = -1;
            }
        }
        private void ocultarTodo()
        {
            if (grillaComida.Visibility == System.Windows.Visibility.Visible)
            {
                grillaComida.Visibility = System.Windows.Visibility.Collapsed;
            }
            if (grillaFondos.Visibility == System.Windows.Visibility.Visible)
            {
                grillaFondos.Visibility = System.Windows.Visibility.Collapsed;
            }
            if (grillaGatos.Visibility == System.Windows.Visibility.Visible)
            {
                grillaGatos.Visibility = System.Windows.Visibility.Collapsed;
            }
            if (grillaOjos.Visibility == System.Windows.Visibility.Visible)
            {
                grillaOjos.Visibility = System.Windows.Visibility.Collapsed;
            }
            if (grillaPelos.Visibility == System.Windows.Visibility.Visible)
            {
                grillaPelos.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void siguiente_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string fileName = "FotoSacada";
            using (IsolatedStorageFile myIsolatedStorage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (myIsolatedStorage.FileExists(fileName))
                {
                    myIsolatedStorage.DeleteFile(fileName);
                }

                IsolatedStorageFileStream fileStream = myIsolatedStorage.CreateFile(fileName);


                WriteableBitmap wb = new WriteableBitmap(480, 680);
                wb.Render(canvasFotos, null);
                wb.Invalidate();
                wb.SaveJpeg(fileStream, wb.PixelWidth, wb.PixelHeight, 0, 85);


                fileStream.Close();

            }
            foreach (Image elemento in canvasFotos.Children.ToList())
            {
                if (elemento.Name != imagenFondos.Name && elemento.Name != imagenTomada.Name)
                {
                    canvasFotos.Children.Remove(elemento);
                }
            }
           NavigationService.Navigate(new Uri("/CompartirGuardar.xaml", UriKind.Relative));
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            PhoneApplicationFrame frame = (PhoneApplicationFrame)Application.Current.RootVisual;
            string pageUri = String.Empty;
            if (frame.BackStack.Count() == 3)
            {
                NavigationService.RemoveBackEntry();
                NavigationService.RemoveBackEntry();
                imagenTomada.RenderTransform = new RotateTransform() { CenterX = 0.5, CenterY = 0.5, Angle = 0 };
                Canvas.SetTop(imagenTomada, 0);
                Canvas.SetLeft(imagenTomada, 0);
                imagenTomada.Width = 480;
                imagenTomada.Height=680;
               
            }
           
            base.OnNavigatedTo(e);
        }

        private void grillaOjos_ManipulationDelta(object sender, System.Windows.Input.ManipulationDeltaEventArgs e)
        {
            Grid element = sender as Grid;

            // element.RenderTransform = transform;
            CompositeTransform transformm = element.RenderTransform as CompositeTransform;

            if (transformm != null)
            {
                if ((Canvas.GetLeft(element) + transformm.TranslateX < 0) || (Canvas.GetLeft(element) + transformm.TranslateX == 0 && e.DeltaManipulation.Translation.X < 0))
                {
                    transformm.TranslateX += e.DeltaManipulation.Translation.X;
                }
                
            }
        }

        private void grillaOjos_ManipulationCompleted(object sender, System.Windows.Input.ManipulationCompletedEventArgs e)
        {
            Grid element = sender as Grid;

            // element.RenderTransform = transform;
            CompositeTransform transformm = element.RenderTransform as CompositeTransform;
            if (transformm.TranslateX > 0)
            {
                transformm.TranslateX = 0;
            }
            int largo = element.Children.Count * 125;
            if ((transformm.TranslateX*-1) > largo-520)
            {
                transformm.TranslateX = (largo-490)*-1;
            }

        }

        private void grillaFondos_ManipulationDelta(object sender, System.Windows.Input.ManipulationDeltaEventArgs e)
        {
            Grid element = sender as Grid;

            // element.RenderTransform = transform;
            CompositeTransform transformm = element.RenderTransform as CompositeTransform;

            if (transformm != null)
            {
                if ((Canvas.GetLeft(element) + transformm.TranslateX < 0) || (Canvas.GetLeft(element) + transformm.TranslateX == 0 && e.DeltaManipulation.Translation.X < 0))
                {
                    transformm.TranslateX += e.DeltaManipulation.Translation.X;
                }

            }
        }
        private void grillaFondos_ManipulationCompleted(object sender, System.Windows.Input.ManipulationCompletedEventArgs e)
        {
            Grid element = sender as Grid;

            // element.RenderTransform = transform;
            CompositeTransform transformm = element.RenderTransform as CompositeTransform;
            if (transformm.TranslateX > 0)
            {
                transformm.TranslateX = 0;
            }
            int largo = element.Children.Count * 125;
            if ((transformm.TranslateX * -1) > largo - 520)
            {
                transformm.TranslateX = (largo - 490) * -1;
            }

        }

  
    }
}
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
using HtmlAgilityPack;

namespace HorariosPeliculas
{
    public partial class HoytsPivot : PhoneApplicationPage
    {
        public HoytsPivot()
        {
            InitializeComponent();
            this.Loaded += HoytsPivot_Loaded;
        }

        void HoytsPivot_Loaded(object sender, RoutedEventArgs e)
        {
            ProgressIndicator.IsRunning = true;
            panelCargando.Visibility = System.Windows.Visibility.Visible;
            var webClient = new WebClient();
            webClient.DownloadStringCompleted += webClientDownloadStringCompleted;
            webClient.DownloadStringAsync(new Uri("http://www.cinehoyts.cl/?mod=horarioss"));
        }
        void webClientDownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            ProgressIndicator.IsRunning = false;
            panelCargando.Visibility = System.Windows.Visibility.Collapsed;

            HtmlReader reader = new HtmlReader(e.Result.ToString());
            List<string> listaCines =  reader.returnTablas();
            
            int contador = 0;
            foreach (var item in listaCines)
            {
                String[] listaString = item.Split('\n');
                StackPanel stack = new StackPanel();
                int contador2 = 0;
                foreach (var item2 in listaString)
                {
                    TextBlock texto = new TextBlock();
                    if (contador2 % 2 == 0)
                    {
                        texto.Text = item2;
                        texto.FontSize = 25;
                        texto.TextWrapping = TextWrapping.Wrap;
                        
                    }
                    else
                    {
                        texto.Text = item2;
                        texto.FontSize = 20;
                        texto.TextWrapping = TextWrapping.Wrap;
                        texto.FontWeight = FontWeights.Bold;
                    }
                    stack.Children.Add(texto);
                    contador2++;
                }
                agregarStack(contador, stack);
                contador++;
            }            
        }

        private void agregarStack(int contador, StackPanel stack)
        {
            switch (contador)
            {
                case 0:
                    stackLaReina.Children.Add(stack);
                    break;
                case 1:
                    stackParqueArauco.Children.Add(stack);  
                    break;
                case 2:
                    stackLosTrapenses.Children.Add(stack);
                    break;
                case 3:
                    stackSanAgustin.Children.Add(stack);
                    break;
                case 4:
                    stackEstCentral.Children.Add(stack);
                    break;
                case 5:
                    stackAraucoMaipu.Children.Add(stack);
                    break;
                case 6:
                    stackPuenteAlto.Children.Add(stack);
                    break;
                case 7:
                    stackValparaiso.Children.Add(stack);
                    break;
                case 8:
                    stackMelipilla.Children.Add(stack);
                    break;
                case 9:
                    stackAntofagasta.Children.Add(stack);
                    break;
                case 10:
                    stackAntofagasta2.Children.Add(stack);
                    break;
                case 11:
                    stackCalama.Children.Add(stack);
                    break;

            }
        }

       
    }
}
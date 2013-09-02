using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;

namespace Vocales
{
    public partial class LetraI : PhoneApplicationPage
    {
        DispatcherTimer timer = new DispatcherTimer();
        public LetraI()
        {
            InitializeComponent();
            this.Loaded += LetraI_Loaded;
        }

        void LetraI_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(2000);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            siguiente.Completed += siguiente_Completed;
            siguiente.Begin();
            timer.Stop();

        }
        void siguiente_Completed(object sender, EventArgs e)
        {
            btnSiguienteA.Click += button_Click_1;
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Letras/ImagenesLetraI.xaml", UriKind.Relative));
        }
    }
}
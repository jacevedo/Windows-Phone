﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;
using AppAprender;

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
            Recursos recurso = new Recursos();
            recurso.reporducirSonido("/Sonidos/Voces/LetraI.mp3");
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(4000);
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
            NavigationService.Navigate(new Uri("/../Vocales/Letras/ImagenesLetraI.xaml", UriKind.Relative));
        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (e.Uri.ToString() != "/Vocales/LetraI.xaml")
            {
                NavigationService.RemoveBackEntry();
                NavigationService.RemoveBackEntry();
            }
            base.OnNavigatedTo(e);
        }
    }
}
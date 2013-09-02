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
using System.ComponentModel;
using Microsoft.Devices;
using System.Windows.Threading;

namespace Masajes
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        private BackgroundWorker segundoPlano = new BackgroundWorker();
        private VibrateController vibrateCont;
        DispatcherTimer dt;
        DispatcherTimer td;
        DispatcherTimer tt;

        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            td = new DispatcherTimer();
            dt = new DispatcherTimer();
            tt = new DispatcherTimer();   
        }

        void btnDetener_Click(object sender, RoutedEventArgs e)
        {
            stop();

        }
        private void stop()
        {
            if (dt.IsEnabled)
            {
                dt.Stop();
            }
            if (td.IsEnabled)
            {
                td.Stop();
            }
            if (tt.IsEnabled)
            {
                tt.Stop();
            }
        }

        void btnIntermitenteIntenso_Click(object sender, RoutedEventArgs e)
        {
            stop();
            dt.Interval = new TimeSpan(0, 0, 0, 1, 0); 
            dt.Tick += new EventHandler(dt_Tick);
            dt.Start();

        }
        
        void dt_Tick(object sender, EventArgs e)
        {
            vibrateCont = VibrateController.Default;
            vibrateCont.Start(new TimeSpan(0, 0, 0, 0, 500));
        }
        void td_Tick(object sender, EventArgs e)
        {
            vibrateCont = VibrateController.Default;
            vibrateCont.Start(new TimeSpan(0, 0, 0, 0, 250));
        }
        void tt_Tick(object sender, EventArgs e)
        {
            vibrateCont = VibrateController.Default;
            vibrateCont.Start(new TimeSpan(0, 0, 0, 0, 500));
        }

        void btnIntermitente_Click(object sender, RoutedEventArgs e)
        {
            stop();
            td.Interval = new TimeSpan(0, 0, 0, 0, 500);
            td.Tick += new EventHandler(td_Tick);
            td.Start();
        }

        void btnIntenso_Click(object sender, RoutedEventArgs e)
        {
            stop();
            tt.Interval = new TimeSpan(0, 0, 0, 0, 500);
            tt.Tick += new EventHandler(tt_Tick);
            tt.Start();
          
        }

       

       
    }
}
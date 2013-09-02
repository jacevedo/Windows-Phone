using Microsoft.Devices;
using Microsoft.Phone.Controls;
using System;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Media;


namespace Nervioso
{
    public partial class MainPage : PhoneApplicationPage
    {
        private BackgroundWorker segundoPlano = new BackgroundWorker();
        private VibrateController vibrateCont;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            segundoPlano.WorkerSupportsCancellation = true;
            segundoPlano.DoWork+=segundoPlano_DoWork;
        }

        
        private void Button_ManipulationStarted_1(object sender, ManipulationStartedEventArgs e)
        {
            elipse.Fill = new SolidColorBrush(Colors.Gray);
            inicializarTimer();
        }

        private void Button_ManipulationCompleted_1(object sender, ManipulationCompletedEventArgs e)
        {
            elipse.Fill = new SolidColorBrush(Colors.Blue);
            
        }
        private void inicializarTimer()
        {
            Random r = new Random();
            int segundos = r.Next(1, 3);
            int milesimas = r.Next(0, 99);
            segundoPlano.DoWork += segundoPlano_DoWork;
            segundoPlano.ProgressChanged += segundoPlano_ProgressChanged;
            segundoPlano.RunWorkerAsync();
           
        }

        
        void segundoPlano_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            vibrateCont = VibrateController.Default;
            vibrateCont.Start(new TimeSpan(0, 0, 0, 3, 0));
            segundoPlano.CancelAsync();
        }

        void segundoPlano_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            System.Threading.Thread.Sleep(3000);
            worker.ReportProgress(1);
        }
      
    }
}
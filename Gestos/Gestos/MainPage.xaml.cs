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
using Microsoft.Xna.Framework.Input.Touch;

namespace Gestos
{
    public partial class MainPage : PhoneApplicationPage
    {
        double x;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            //this.Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            TouchPanel.EnabledGestures = GestureType.HorizontalDrag | GestureType.VerticalDrag;
        }

        private void GestureListener_DragStarted_1(object sender, DragStartedGestureEventArgs e)
        {
            if (e.Direction.ToString() == "Horizontal")
            {
                
            }
        }

        private void GestureListener_DragCompleted_1(object sender, DragCompletedGestureEventArgs e)
        {

        }

        private void GestureListener_Flick_1(object sender, FlickGestureEventArgs e)
        {
            if (e.Direction.ToString() == "Horizontal")
            {
                if (e.HorizontalVelocity > 0)
                {
                    MessageBox.Show("Derecha");
                }
                else
                {
                    MessageBox.Show("Izquierda");
                }
            }
        }

       
    }
}
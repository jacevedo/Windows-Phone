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

namespace Calculadora
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnSumarClick(object sender, RoutedEventArgs e)
        {
            int first = Convert.ToInt32(txtFirstNumber.Text);
            int second = Convert.ToInt32(txtSecondNumber.Text);
            int result = first + second;
            txtResult.Text = "=" + result;

        }
    }
}
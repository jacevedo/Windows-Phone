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

namespace Aves
{
    public partial class Porque : PhoneApplicationPage
    {
        public Porque()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            PorqueDB porqe;
            int idPor = 0;
            string newText;
            if (NavigationContext.QueryString.TryGetValue("idPor", out newText))
            {
                idPor = Convert.ToInt32(newText.Trim());
            }
            using (baseDatosDataContext contextoBD = new baseDatosDataContext("Data source='isostore:/baseDatosBD.sdf'"))
            {
                porqe = (from x in contextoBD.PorqueDB
                         where x.id == idPor
                         select x).First();
            }
            PageTitle.Text = porqe.nomPor;

            TextBlock txtDescripcion = new TextBlock();
            txtDescripcion.Text = porqe.descripcion;
            txtDescripcion.TextWrapping = TextWrapping.Wrap;
            txtDescripcion.Foreground = new SolidColorBrush(Colors.Black);
            ContentPor.Children.Add(txtDescripcion);
            base.OnNavigatedTo(e);
        }
    }
}



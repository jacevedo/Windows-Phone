using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;

namespace Liquidacion_Sueldo
{
    public partial class Configuraciones : PhoneApplicationPage
    {
        IsolatedStorageSettings settings;
        public Configuraciones()
        {
            InitializeComponent();
            settings = IsolatedStorageSettings.ApplicationSettings;
            this.Loaded += Configuraciones_Loaded;
        }

        void Configuraciones_Loaded(object sender, RoutedEventArgs e)
        {
            txtCantHijos.Text = settings["cantCargasFamiliares"].ToString();
            txtPorcentajeAFP.Text = settings["porcentajeAFP"].ToString();
            txtPorcentajeCesantia.Text = settings["porcentajeCesantia"].ToString();
            txtPorcentajeIsapre.Text = settings["porcentajeIsapre"].ToString();
            txtValorColacion.Text = settings["valorColacion"].ToString();
            txtValorMovilizacion.Text = settings["valorLocomosion"].ToString();
            txtDiasTrabajados.Text = settings["diasTrabajados"].ToString(); 
        }

        private void txtCantHijos_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void txtValorMovilizacion_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void txtValorColacion_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void txtPorcentajeIsapre_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            string[] arregloTexto = texto.Text.Split(',');
            if (arregloTexto.Count() > 1 || texto.Text.Length == 1)
            {
                texto.Text = texto.Text.Replace(".", string.Empty);
                texto.SelectionStart = texto.Text.Length;
            }
            else
            {
                texto.Text = texto.Text.Replace(".", ",");
                texto.SelectionStart = texto.Text.Length;
            }
        }

        private void txtPorcentajeAFP_TextChanged(object sender, TextChangedEventArgs e)
        {

            TextBox texto = (TextBox)sender;
            string[] arregloTexto = texto.Text.Split(',');
            if (arregloTexto.Count() > 1 || texto.Text.Length==1)
            {
                texto.Text = texto.Text.Replace(".", string.Empty);
                texto.SelectionStart = texto.Text.Length;
            }
            else
            {
                texto.Text = texto.Text.Replace(".", ",");
                texto.SelectionStart = texto.Text.Length;
            }
            
        }

        private void txtPorcentajeCesantia_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            string[] arregloTexto = texto.Text.Split(',');
            if (arregloTexto.Count() > 1 || texto.Text.Length == 1)
            {
                texto.Text = texto.Text.Replace(".", string.Empty);
                texto.SelectionStart = texto.Text.Length;
            }
            else
            {
                texto.Text = texto.Text.Replace(".", ",");
                texto.SelectionStart = texto.Text.Length;
            }
        }
        private void txtValorMovilizacion_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            if (string.Compare(texto.Text, string.Empty) == 0)
            {
                texto.Text = "0";
            }
        }

        private void txtCantHijos_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            if (string.Compare(texto.Text, "0") == 0)
            {
                texto.Text = string.Empty;
            }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            settings["cantCargasFamiliares"] = txtCantHijos.Text;
            settings["porcentajeAFP"] =  txtPorcentajeAFP.Text;
            settings["porcentajeCesantia"] = txtPorcentajeCesantia.Text;
            settings["porcentajeIsapre"] = txtPorcentajeIsapre.Text;
            settings["valorColacion"] = txtValorColacion.Text;
            settings["valorLocomosion"] = txtValorMovilizacion.Text;
            settings["diasTrabajados"] = txtDiasTrabajados.Text;
        }

        private void txtDiasTrabajados_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            if (string.Compare(texto.Text, "0") == 0)
            {
                texto.Text = string.Empty;
            }
        }

        private void txtDiasTrabajados_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            if (string.Compare(texto.Text, string.Empty) == 0)
            {
                texto.Text = "0";
            }
        }

        private void txtDiasTrabajados_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }
    }
}
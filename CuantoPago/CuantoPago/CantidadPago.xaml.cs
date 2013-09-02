using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Input;

namespace CuantoPago
{
    public partial class CantidadPago : PhoneApplicationPage
    {
        int cantPersonas = 0;
        String valorDividido="";
        String valorDivididoPermanente;
        public CantidadPago()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string newText = string.Empty;
            
            if (NavigationContext.QueryString.TryGetValue("cantidadPersonas", out newText))
            {     
                    cantPersonas = Convert.ToInt32(newText);
                    
            }
            if (NavigationContext.QueryString.TryGetValue("pagoPersonas", out newText))
            {
                valorDividido = newText;
                valorDivididoPermanente = newText;
            }
            TextBlock textoDiferencia = new TextBlock();
            textoDiferencia.Name = "diferencia";
            
            panelControl.Children.Add(textoDiferencia);
           
            for (int i = 1; i != cantPersonas+1; i++)
            {
                InputScope scope = new InputScope();
                InputScopeName name = new InputScopeName();

                name.NameValue = InputScopeNameValue.Number;
                scope.Names.Add(name);

                TextBlock texto = new TextBlock();
                texto.Text = "Persona " + i;
                TextBox txtCampo = new TextBox();
                txtCampo.Name = "Persona" + i;
                txtCampo.Text = valorDividido;
                txtCampo.InputScope = scope;
                txtCampo.LostFocus += txtCampo_LostFocus;
                txtCampo.TextChanged += txtCampo_TextChanged;


                panelControl.Children.Add(texto);
                panelControl.Children.Add(txtCampo);
            }

            base.OnNavigatedTo(e);
        }

        void txtCampo_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        void txtCampo_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            TextBlock txtLabel = new TextBlock();
            int contador = 0;
            int contador2 = 0;
            int contPersonasNormales = 0;
            foreach(Object x in panelControl.Children.ToList())
            {
                if (x.GetType().Equals(texto.GetType()))
                {
                    if (((TextBox)x).Text.CompareTo(valorDividido) == 0)
                    {
                        contador = contador + Convert.ToInt32(((TextBox)x).Text);
                        contPersonasNormales++;
                    }
                    else
                    {
                        contador2 = contador2 + Convert.ToInt32(((TextBox)x).Text);
                    }
                }
            }
            int valorTotal = Convert.ToInt32(valorDivididoPermanente) * cantPersonas;
            int valorTotalCambiado = valorTotal - contador2;
            int nuevoValorDividido = valorTotalCambiado / contPersonasNormales;
            int diferencia = valorTotal-((nuevoValorDividido * contPersonasNormales) + contador2);
                        
            foreach(Object x in panelControl.Children.ToList())
            {
                if (x.GetType().Equals(texto.GetType()))
                {
                    if (((TextBox)x).Text.CompareTo(valorDividido) == 0)
                    {
                       ((TextBox)x).Text= nuevoValorDividido+"";
                    }
                }
                if (x.GetType().Equals(txtLabel.GetType()) && ((TextBlock)x).Name.CompareTo("diferencia") == 0)
                {
                    if (diferencia != 0)
                    {
                        ((TextBlock)x).Text = "Hubo una diferencia de:\n" + diferencia + " pesos que no pudo ser asignada";
                        ((TextBlock)x).FontSize = 24;
                    }
                    else
                    {
                        ((TextBlock)x).Text = string.Empty;
                    }
                }
                
            }
           
            valorDividido = nuevoValorDividido + "";
        }
    }
}
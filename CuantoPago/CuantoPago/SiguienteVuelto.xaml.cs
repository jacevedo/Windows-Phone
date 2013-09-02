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
    public partial class SiguienteVuelto : PhoneApplicationPage
    {
        int cantPersonas = 0;
        int valorTotal = 0;
        int valorVuelto = 0;
        StackPanel stackPanel;
        public SiguienteVuelto()
        {
            InitializeComponent();
            stackPanel = new StackPanel();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string newText;
           
            if (NavigationContext.QueryString.TryGetValue("cantidadPersonas", out newText))
            {
                cantPersonas = Convert.ToInt32(newText);
            }
            if (NavigationContext.QueryString.TryGetValue("valorTotal", out newText))
            {
                valorTotal = Convert.ToInt32(newText);   
            }
            if (NavigationContext.QueryString.TryGetValue("valorVuelto", out newText))
            {
                valorVuelto = Convert.ToInt32(newText);
            }


            for (int i = 1; i != cantPersonas + 1; i++)
            {
                InputScope scope = new InputScope();
                InputScopeName name = new InputScopeName();

                name.NameValue = InputScopeNameValue.Number;
                scope.Names.Add(name);

                TextBlock texto = new TextBlock();
                texto.Text = "Ingrese lo que Pago la Persona " + i;
                TextBox txtCampo = new TextBox();
                txtCampo.Name = "Persona" + i;
                txtCampo.Text = 0+"";
                txtCampo.InputScope = scope;
                txtCampo.GotFocus += txtCampo_GotFocus;
                txtCampo.LostFocus += txtCampo_LostFocus;
                txtCampo.TextChanged += txtCampo_TextChanged;
               
                panelControl.Children.Add(texto);
                panelControl.Children.Add(txtCampo);
            }

            Button btnCalcular = new Button();
            btnCalcular.Content="Calcular";
            btnCalcular.Click+=btnCalcular_Click;
            panelControl.Children.Add(btnCalcular);
            panelControl.Children.Add(stackPanel);
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
            if (string.Compare(texto.Text, string.Empty) == 0)
            {
                texto.Text = "0";
            }
        }

        void txtCampo_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            if (string.Compare(texto.Text, "0") == 0)
            {
                texto.Text = string.Empty;
            }
        }

        void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            TextBox txtPrueba = new TextBox();
            int contador=1;
            int valorSuma = 0;
            stackPanel.Children.Clear();
            foreach (Object x in panelControl.Children.ToList())
            {
                if (x.GetType().Equals(txtPrueba.GetType()))
                {
                    int cantidad = Convert.ToInt32(((TextBox)x).Text);

                    int valorTotalConVuelto = valorVuelto + valorTotal;
                    int valorPorcentaje = (cantidad * 100) / valorTotalConVuelto;
                    int valorVueltoPersona = (valorVuelto*valorPorcentaje)/100;

                    valorSuma = valorSuma + valorVueltoPersona;

                    TextBlock txtValorVuelto = new TextBlock();
                    txtValorVuelto.Text = "El Vuelto de la Persona " + contador + " es:\n $" + valorVueltoPersona;
                    contador++;
                    stackPanel.Children.Add(txtValorVuelto);
                    
                }
            }
            
            int diferencia = valorVuelto -valorSuma;
            TextBlock txtDiferencia = new TextBlock();
            txtDiferencia.Text = "Hubo una diferencia de: $" + diferencia;
            stackPanel.Children.Add(txtDiferencia);
            
        }
    }
}
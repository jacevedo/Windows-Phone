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
    public partial class Liquidacion : PhoneApplicationPage
    {
        IsolatedStorageSettings settings;
        public Liquidacion()
        {
            InitializeComponent();
            this.Loaded += Liquidacion_Loaded;
           
        }

        void Liquidacion_Loaded(object sender, RoutedEventArgs e)
        {
            settings = IsolatedStorageSettings.ApplicationSettings;
            obtenerValores();
            calcularTodo();
        }

        private void obtenerValores()
        {
            txtCantHijos.Text = settings["cantCargasFamiliares"].ToString();
            txtPorcentajeAFP.Text = settings["porcentajeAFP"].ToString();
            txtPorcentajeDesempleo.Text = settings["porcentajeCesantia"].ToString();
            txtPorcentajeFonasa.Text = settings["porcentajeIsapre"].ToString();
            txtCantDias.Text = settings["diasTrabajados"].ToString();
            txtCantDiasCol.Text = settings["diasTrabajados"].ToString();
            lblDiasTrabajados.Text = settings["diasTrabajados"].ToString();
        }

        private void calcularTodo()
        {
            calcularValorBruto();
            calcularImponible();
            calcularNoImponible();
            calcularDescuentos();
            calculosFinales();
            

        }

        private void calcularValorBruto()
        {
            int totalBruto = Convert.ToInt32(lblSueldoTotal.Text.ToString());
            int cantDias = Convert.ToInt32(txtCantDias.Text.ToString());
            int totalDiasDeTrabajoAlMes = Convert.ToInt32(settings["diasTrabajados"]);
            int valorSueldoACalcular = (cantDias * totalBruto) / totalDiasDeTrabajoAlMes;
            lblSueldo.Text = valorSueldoACalcular.ToString();
        }

        private void calculosFinales()
        {
            int totalImponibles = Convert.ToInt32(lblTotalImponible.Text.ToString());
            int totalNoImponibles = Convert.ToInt32(lblTotalNoImponible.Text.ToString());
            int totalDescuentos = Convert.ToInt32(lblTotalDescuentos.Text.ToString());
            int totalHaberes = totalImponibles + totalNoImponibles;
            int totalAPagar = totalHaberes - totalDescuentos;
            txtTotalHaberes.Text = totalHaberes.ToString();
            txtTotalDescuentos.Text = totalDescuentos.ToString();
            txtTotalLiquido.Text = totalAPagar.ToString();
        }

        private void calcularDescuentos()
        {
            int totalImponible = Convert.ToInt32(lblTotalImponible.Text);
            double porcentajeFonasa = Convert.ToDouble(txtPorcentajeFonasa.Text.ToString());
            double porcentajeAFP = Convert.ToDouble(txtPorcentajeAFP.Text.ToString());
            double porcentajeDesempleo = Convert.ToDouble(txtPorcentajeDesempleo.Text.ToString());
            int totalFonasa = Convert.ToInt32(Math.Round(totalImponible * (porcentajeFonasa / 100), 0));
            int totalAFP = Convert.ToInt32(Math.Round(totalImponible * (porcentajeAFP / 100), 0));
            int totalDesempleo = Convert.ToInt32(Math.Round(totalImponible * (porcentajeDesempleo / 100), 0));
            int otrosDescuentos = Convert.ToInt32(txtOtrosDescuentos.Text.ToString());
            int totalDescuentos = totalFonasa + totalAFP + totalDesempleo + otrosDescuentos;
            txtTotalAFP.Text = totalAFP.ToString();
            txtTotalDesempleo.Text = totalDesempleo.ToString();
            txtTotalFonasa.Text = totalFonasa.ToString();
            lblTotalDescuentos.Text = totalDescuentos.ToString();


        }

        private void calcularNoImponible()
        {
            int valorDiarioMovilizacion = Convert.ToInt32(settings["valorLocomosion"].ToString());
            int diarioColacion = Convert.ToInt32(settings["valorColacion"].ToString());
            int valorHijo = obtenerValorHijo();
            int cantDiasMovilizacion = Convert.ToInt32(txtCantDias.Text.ToString());
            int cantDiasColacion = Convert.ToInt32(txtCantDiasCol.Text.ToString());
            int cantHijosGratificacion = Convert.ToInt32(txtCantHijos.Text.ToString());
            int canTotalMovilizacion = valorDiarioMovilizacion * cantDiasMovilizacion;
            int canTotalColacion = diarioColacion * cantDiasColacion;
            int canTotalAsigFamiliar = valorHijo * cantHijosGratificacion;
            int totalNoImponible = canTotalAsigFamiliar + canTotalColacion + canTotalMovilizacion;

            txtAsigFamiliar.Text = canTotalAsigFamiliar.ToString();
            txtTotalColacion.Text = canTotalColacion.ToString();
            txtTotalMovilizacion.Text = canTotalMovilizacion.ToString();
            lblTotalNoImponible.Text = totalNoImponible.ToString();
        
        }

        private int obtenerValorHijo()
        {
            int valorBruto = Convert.ToInt32(lblSueldo.Text.ToString());
            int valorAsignacion = 0;
            if (valorBruto <= 220354)
            {
                valorAsignacion = 8626;
            }
            else if (valorBruto > 220354 && valorBruto <= 321851)
            {
                valorAsignacion = 5294;
            }
            else if (valorBruto < 321851 && valorBruto <= 501978)
            {
                valorAsignacion = 1673;
            }
            else
            {
                valorAsignacion = 0;
            }
            return valorAsignacion;
        }

        private void calcularImponible()
        {
            int sueldoBase = Convert.ToInt32(lblSueldo.Text.ToString());
            double gratificacionDesimal = (sueldoBase * 0.25);
            int gratificacion = Convert.ToInt32(Math.Round(gratificacionDesimal,0));
            int bonos = Convert.ToInt32(txtBonos.Text.ToString());
            int totalImponible = sueldoBase + gratificacion + bonos;

            txtGratificacion.Text = gratificacion.ToString();
            lblTotalImponible.Text = totalImponible.ToString();
        }

        private void txtBonos_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtBonosLocal = sender as TextBox;
            if (txtBonosLocal.Text.Length == 0)
            {
                txtBonosLocal.Text = "0";
            }
            int sueldoBase = Convert.ToInt32(lblSueldo.Text.ToString());
            int gratificacion = Convert.ToInt32(txtGratificacion.Text.ToString());
            int bonos = Convert.ToInt32(txtBonosLocal.Text.ToString());
            int totalImponible = sueldoBase + gratificacion + bonos;
            lblTotalImponible.Text = totalImponible.ToString();
            calcularDescuentos();
            calculosFinales();
        }

        private void txtGratificacion_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void txtBonos_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }


        private void txtCantHijos_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void txtCantHijos_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtCantHijo = sender as TextBox;
            if (txtCantHijo.Text.Length == 0)
            {
                txtCantHijo.Text = "0";
            }
            int cantHijos = Convert.ToInt32(txtCantHijo.Text.ToString());
            int valorHijo = obtenerValorHijo();
            int totalHijo = cantHijos * valorHijo;
            int valorMovilizacion = Convert.ToInt32(txtTotalMovilizacion.Text.ToString());
            int valorColacion = Convert.ToInt32(txtTotalColacion.Text.ToString());
            int totalNoImponible = totalHijo + valorMovilizacion + valorColacion;

            txtAsigFamiliar.Text = totalHijo.ToString();
            lblTotalNoImponible.Text = totalNoImponible.ToString();

            calculosFinales();
        }

        private void txtAsigFamiliar_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void txtAsigFamiliar_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtAsigFami = sender as TextBox;
            if (txtAsigFami.Text.Length == 0)
            {
                txtAsigFami.Text = "0";
            }
            int totalHijo = Convert.ToInt32(txtAsigFami.Text.ToString());
            int valorMovilizacion = Convert.ToInt32(txtTotalMovilizacion.Text.ToString());
            int valorColacion = Convert.ToInt32(txtTotalColacion.Text.ToString());
            int totalNoImponible = totalHijo + valorMovilizacion + valorColacion;

            txtAsigFamiliar.Text = totalHijo.ToString();
            lblTotalNoImponible.Text = totalNoImponible.ToString();

            calculosFinales();
        }

        private void txtCantDias_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void txtCantDias_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtCantDi = sender as TextBox;
            if (txtCantDi.Text.Length == 0)
            {
                txtCantDi.Text = "0";
            }
            int cantDias = Convert.ToInt32(txtCantDi.Text.ToString());
            int valorDia = Convert.ToInt32(settings["valorLocomosion"].ToString());
            int totalLocomocion = cantDias * valorDia;
            int asigFamiliar = Convert.ToInt32(txtAsigFamiliar.Text.ToString());
            int totalColacion = Convert.ToInt32(txtTotalColacion.Text.ToString());
            int totalNoImponible = totalLocomocion + totalColacion + asigFamiliar;

            txtTotalMovilizacion.Text = totalLocomocion.ToString();
            lblTotalNoImponible.Text = totalNoImponible.ToString();

            calculosFinales();
        }

        private void txtTotalMovilizacion_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void txtTotalMovilizacion_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtTotalMovi = sender as TextBox;
            if (txtTotalMovi.Text.Length == 0)
            {
                txtTotalMovi.Text = "0";
            }
            int totalLocomocion = Convert.ToInt32(txtTotalMovi.Text.ToString());
            int asigFamiliar = Convert.ToInt32(txtAsigFamiliar.Text.ToString());
            int totalColacion = Convert.ToInt32(txtTotalColacion.Text.ToString());
            int totalNoImponible = totalLocomocion + totalColacion + asigFamiliar;

            
            lblTotalNoImponible.Text = totalNoImponible.ToString();

            calculosFinales();
        }

        private void txtCantDiasCol_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void txtCantDiasCol_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtCantDiasColacion = sender as TextBox;
            if (txtCantDiasColacion.Text.Length == 0)
            {
                txtCantDiasColacion.Text = "0";
            }
            int cantDias = Convert.ToInt32(txtCantDiasColacion.Text.ToString());
            int valorDia = Convert.ToInt32(settings["valorColacion"].ToString());
            int totalColacion = cantDias * valorDia;
            int asigFamiliar = Convert.ToInt32(txtAsigFamiliar.Text.ToString());
            int totalLocomocion = Convert.ToInt32(txtTotalMovilizacion.Text.ToString());
            int totalNoImponible = totalLocomocion + totalColacion + asigFamiliar;

            txtTotalColacion.Text = totalColacion.ToString();
            lblTotalNoImponible.Text = totalNoImponible.ToString();

            calculosFinales();
        }

        private void txtTotalColacion_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void txtTotalColacion_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtTotalColacion = sender as TextBox;
            if (txtTotalColacion.Text.Length == 0)
            {
                txtTotalColacion.Text = "0";
            }
            int totalColacion = Convert.ToInt32(txtTotalColacion.Text.ToString());
            int asigFamiliar = Convert.ToInt32(txtAsigFamiliar.Text.ToString());
            int totalLocomocion = Convert.ToInt32(txtTotalMovilizacion.Text.ToString());
            int totalNoImponible = totalLocomocion + totalColacion + asigFamiliar;


            lblTotalNoImponible.Text = totalNoImponible.ToString();

            calculosFinales();
        }

        private void txtPorcentajeFonasa_TextChanged(object sender, TextChangedEventArgs e)
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

        private void txtPorcentajeFonasa_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtPorcentajeFonasa = sender as TextBox;
            if (txtPorcentajeFonasa.Text.Length == 0)
            {
                txtPorcentajeFonasa.Text = "0";
            }
            double valorFonasaUIsapre = Convert.ToDouble(txtPorcentajeFonasa.Text.ToString());
            int totalImponible = Convert.ToInt32(lblTotalImponible.Text.ToString());
            int calculoFonasa = Convert.ToInt32(Math.Round(totalImponible * (valorFonasaUIsapre / 100),0));
            int totalAFP = Convert.ToInt32(txtTotalAFP.Text.ToString());
            int totalCesantia = Convert.ToInt32(txtTotalDesempleo.Text.ToString());
            int OtrosDescuentos = Convert.ToInt32(txtOtrosDescuentos.Text.ToString());
            int totalDescuentos = calculoFonasa + totalAFP + totalCesantia + OtrosDescuentos;

            txtTotalFonasa.Text = calculoFonasa.ToString();
            lblTotalDescuentos.Text = totalDescuentos.ToString();

            calculosFinales();

        }

        private void txtTotalFonasa_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void txtTotalFonasa_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtTotalFonasa = sender as TextBox;
            if (txtTotalFonasa.Text.Length == 0)
            {
                txtTotalFonasa.Text = "0";
            }
            int calculoFonasa = Convert.ToInt32(txtTotalFonasa.Text.ToString());
            int totalAFP = Convert.ToInt32(txtTotalAFP.Text.ToString());
            int totalCesantia = Convert.ToInt32(txtTotalDesempleo.Text.ToString());
            int OtrosDescuentos = Convert.ToInt32(txtOtrosDescuentos.Text.ToString());
            int totalDescuentos = calculoFonasa + totalAFP + totalCesantia + OtrosDescuentos;

            lblTotalDescuentos.Text = totalDescuentos.ToString();

            calculosFinales();
        }

        private void txtPorcentajeAFP_TextChanged(object sender, TextChangedEventArgs e)
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

        private void txtPorcentajeAFP_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtPorcentajeAFP = sender as TextBox;
            if (txtPorcentajeAFP.Text.Length == 0)
            {
                txtPorcentajeAFP.Text = "0";
            }
            double valorPorcentajeAFP = Convert.ToDouble(txtPorcentajeAFP.Text.ToString());
            int totalImponible = Convert.ToInt32(lblTotalImponible.Text.ToString());
            int calculoFonasa = Convert.ToInt32(txtTotalFonasa.Text.ToString());
            int totalAFP = Convert.ToInt32(Math.Round(totalImponible * (valorPorcentajeAFP/100),0));
            int totalCesantia = Convert.ToInt32(txtTotalDesempleo.Text.ToString());
            int OtrosDescuentos = Convert.ToInt32(txtOtrosDescuentos.Text.ToString());
            int totalDescuentos = calculoFonasa + totalAFP + totalCesantia + OtrosDescuentos;

            txtTotalAFP.Text = totalAFP.ToString();
            lblTotalDescuentos.Text = totalDescuentos.ToString();

            calculosFinales();
        }

        private void txtTotalAFP_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void txtTotalAFP_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtTotalAFP = sender as TextBox;
            if (txtTotalAFP.Text.Length == 0)
            {
                txtTotalAFP.Text = "0";
            }
            int calculoFonasa = Convert.ToInt32(txtTotalFonasa.Text.ToString());
            int totalAFP = Convert.ToInt32(txtTotalAFP.Text.ToString());
            int totalCesantia = Convert.ToInt32(txtTotalDesempleo.Text.ToString());
            int OtrosDescuentos = Convert.ToInt32(txtOtrosDescuentos.Text.ToString());
            int totalDescuentos = calculoFonasa + totalAFP + totalCesantia + OtrosDescuentos;

            lblTotalDescuentos.Text = totalDescuentos.ToString();

            calculosFinales();
        }

        private void txtPorcentajeDesempleo_TextChanged(object sender, TextChangedEventArgs e)
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

        private void txtPorcentajeDesempleo_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtPorcentajeDesempleo = sender as TextBox;
            if (txtPorcentajeDesempleo.Text.Length == 0)
            {
                txtPorcentajeDesempleo.Text = "0";
            }
            double valorPorcentajeDesempleo = Convert.ToDouble(txtPorcentajeDesempleo.Text.ToString());
            int totalImponible = Convert.ToInt32(lblTotalImponible.Text.ToString());
            int calculoFonasa = Convert.ToInt32(txtTotalFonasa.Text.ToString());
            int totalAFP = Convert.ToInt32(txtTotalAFP.Text.ToString());
            int totalCesantia = Convert.ToInt32(Math.Round(totalImponible * (valorPorcentajeDesempleo / 100), 0));
            int OtrosDescuentos = Convert.ToInt32(txtOtrosDescuentos.Text.ToString());
            int totalDescuentos = calculoFonasa + totalAFP + totalCesantia + OtrosDescuentos;

            txtTotalDesempleo.Text = totalCesantia.ToString();
            lblTotalDescuentos.Text = totalDescuentos.ToString();

            calculosFinales();
        }

        private void txtTotalDesempleo_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void txtTotalDesempleo_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtTotalDesempleo = sender as TextBox;
            if (txtTotalDesempleo.Text.Length == 0)
            {
                txtTotalDesempleo.Text = "0";
            }
            int calculoFonasa = Convert.ToInt32(txtTotalFonasa.Text.ToString());
            int totalAFP = Convert.ToInt32(txtTotalAFP.Text.ToString());
            int totalCesantia = Convert.ToInt32(txtTotalDesempleo.Text.ToString());
            int OtrosDescuentos = Convert.ToInt32(txtOtrosDescuentos.Text.ToString());
            int totalDescuentos = calculoFonasa + totalAFP + totalCesantia + OtrosDescuentos;

            lblTotalDescuentos.Text = totalDescuentos.ToString();

            calculosFinales();
        }

        private void txtOtrosDescuentos_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void txtOtrosDescuentos_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtOtrosDescuentos = sender as TextBox;
            if (txtOtrosDescuentos.Text.Length == 0)
            {
                txtOtrosDescuentos.Text = "0";
            }
            int calculoFonasa = Convert.ToInt32(txtTotalFonasa.Text.ToString());
            int totalAFP = Convert.ToInt32(txtTotalAFP.Text.ToString());
            int totalCesantia = Convert.ToInt32(txtTotalDesempleo.Text.ToString());
            int OtrosDescuentos = Convert.ToInt32(txtOtrosDescuentos.Text.ToString());
            int totalDescuentos = calculoFonasa + totalAFP + totalCesantia + OtrosDescuentos;

            lblTotalDescuentos.Text = totalDescuentos.ToString();

            calculosFinales();
        }

        private void txtGratificacion_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtGratificacionLocal = sender as TextBox;
            if (txtGratificacionLocal.Text.Length == 0)
            {
                txtGratificacionLocal.Text = "0";
            }
            int sueldoBase = Convert.ToInt32(lblSueldo.Text.ToString());
            int gratificacion = Convert.ToInt32(txtGratificacionLocal.Text.ToString());
            int bonos = Convert.ToInt32(txtBonos.Text.ToString());
            int totalImponible = sueldoBase + gratificacion + bonos;
            lblTotalImponible.Text = totalImponible.ToString();
            calcularDescuentos();
            calculosFinales();
        }

        private void lblSueldo_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtSueldoBase = sender as TextBox;
            if (txtSueldoBase.Text.Length == 0)
            {
                txtSueldoBase.Text = "0";
            }
            calcularTodo();
        }

        private void lblSueldo_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void lblSueldoTotal_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtSueldoBase = sender as TextBox;
            if (txtSueldoBase.Text.Length == 0)
            {
                txtSueldoBase.Text = "0";
            }
            calcularTodo();
        }

        private void lblSueldoTotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }

        private void lblDiasTrabajados_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtDiasTrabajados = sender as TextBox;
            if (txtDiasTrabajados.Text.Length == 0)
            {
                txtDiasTrabajados.Text = "0";
            }
            int totalBruto = Convert.ToInt32(lblSueldoTotal.Text.ToString());
            int cantDias = Convert.ToInt32(txtDiasTrabajados.Text.ToString());
            int totalDiasDeTrabajoAlMes = Convert.ToInt32(settings["diasTrabajados"]);
            int valorSueldoACalcular = (cantDias * totalBruto) / totalDiasDeTrabajoAlMes;
            lblSueldo.Text = valorSueldoACalcular.ToString();
            calcularImponible();
            calcularNoImponible();
            calcularDescuentos();
            calculosFinales();
        }

        private void lblDiasTrabajados_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            texto.Text = texto.Text.Replace(".", string.Empty);
            texto.SelectionStart = texto.Text.Length;
        }
    }
}
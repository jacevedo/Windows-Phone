using Microsoft.Phone.Controls.Maps;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Resources;
using System.Xml.Linq;

namespace StarckBuks
{
    class xmlReader
    {
        XElement datos;
        StreamResourceInfo uriDatos;
        public xmlReader( StreamResourceInfo uriDatos)
        {
            this.uriDatos = uriDatos;
            datos = XElement.Load(uriDatos.Stream);
        }
        public List<Pushpin> listarPushPin()
        {
            List<Pushpin> listaPin = new List<Pushpin>();
            var datosXml = from item
                       in datos.Elements("marker")
                           select item;

            foreach (XElement elemento in datosXml)
            {
                Pushpin ppin = new Pushpin();
                String lat = elemento.Attribute("lat").Value.ToString();
                String lng = elemento.Attribute("lng").Value.ToString();
                lat = lat.Replace('.',Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator));
                lng = lng.Replace('.',Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator));
                double latDouble = Convert.ToDouble(lat);
                double lngDouble = Convert.ToDouble(lng);
                ppin.Location = new GeoCoordinate(latDouble, lngDouble);
                ppin.Content = elemento.Attribute("label").Value.ToString();
                listaPin.Add(ppin);
            }
            return listaPin;
        }
        public List<string> listaNombreLocales()
        {
            var datosXml = from item
                       in datos.Elements("marker")
                           select item;
            List<string> listaString  = new List<string>();
            listaString.Add("Seleccione un Local");
            foreach (XElement elemento in datosXml)
            {
                listaString.Add(elemento.Attribute("label").Value.ToString());
            }
            return listaString;
        }
        public List<string> listaComunasLocales()
        {
            var datosXml = from item
                                   in datos.Elements("marker")
                           select item;
            List<string> listaString = new List<string>();
            listaString.Add("Seleccione una Comuna");
            foreach (XElement elemento in datosXml)
            {
                if (!listaString.Contains(elemento.Attribute("Barrio").Value.ToString()))
                {
                    listaString.Add(elemento.Attribute("Barrio").Value.ToString());

                }
            }
            return listaString;
        }
        public List<Tienda> retornarHtml(string nombre)
        {
            string nomLocal = "";
            string comuna ="";
            string descripcion="";
            string horario="";
            string comoLlegar="";
            var datosXml = from item
                                  in datos.Elements("marker")
                           select item;
            List<string> listaDatos = new List<string>();
            List<Tienda> listaTienda = new List<Tienda>();
            foreach (XElement elemento in datosXml)
            {
                
                if (elemento.Attribute("label").Value == nombre || elemento.Attribute("Barrio").Value == nombre)
                {
                    nomLocal = elemento.Attribute("label").Value;
                    comuna = elemento.Attribute("Barrio").Value;
                    descripcion = elemento.Attribute("Desc").Value;
                    XElement datosXml2 = XElement.Parse(elemento.Element("Info").Value.ToString());
                    var datosXml3 = from item
                                          in datosXml2.Elements("div")
                                    select item;
                    foreach (XElement elemento2 in datosXml3)
                    {
                        if (elemento2.Attribute("class").Value.ToString().Trim() == "divHorariosTiendaMapa textoContenidosV2")
                        {
                            horario = elemento2.Value.ToString();
                        }
                        if (elemento2.Attribute("class").Value.ToString().Trim() == "divDescripcionTiendaMapa")
                        {
                            comoLlegar =  elemento2.Value.ToString();

                        }
                        // valores.AppendLine(elemento.Value.ToString());
                    }
                    Tienda tienda = new Tienda();
                    tienda.NomLocal = nomLocal;
                    tienda.NomComuna = comuna;
                    tienda.Descripcion = descripcion;
                    tienda.Horario = horario;
                    tienda.ComoLlegar = comoLlegar;
                    listaTienda.Add(tienda);
                }
               
            }
           
            return listaTienda;
        }
    }
}

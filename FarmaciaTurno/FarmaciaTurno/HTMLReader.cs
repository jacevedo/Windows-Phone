using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarmaciaTurno
{
    class HTMLReader
    {
        HtmlDocument doc = new HtmlDocument();

        public HtmlDocument Doc
        {
            get { return doc; }
            set { doc = value; }
        }
        public HTMLReader(string html)
        {
            doc.LoadHtml(html);
           
        }
        public List<string> returnDatos()
        {
            string texto = string.Empty;
            List<HtmlNode> tr = new List<HtmlNode>();
            tr = doc.DocumentNode.SelectNodes("//div[@class='contenedor-lista-peliculas2 clearfix']").ToList();
            List<string> listaNombre = new List<string>();
            for (int i = 0; i < tr.Count; i++)
            {
                listaNombre.Add(tr.ElementAt(i).InnerText);
            }
            
            
            return listaNombre;
        }
    }
}

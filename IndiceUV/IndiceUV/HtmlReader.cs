using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace IndiceUV
{
    class HtmlReader
    {
         HtmlDocument doc = new HtmlDocument();

        public HtmlDocument Doc
        {
            get { return doc; }
            set { doc = value; }
        }
        public HtmlReader(string html)
        {
            doc.LoadHtml(html);
           
        }
        public List<string> returnDatos()
        {
            string texto = string.Empty;
            List<HtmlNode> tr = new List<HtmlNode>();
            tr = doc.DocumentNode.SelectNodes("//table").ToList();
            List<string> listaNombre = new List<string>();
            for (int i = 0; i < tr.Count; i++)
            {
                MessageBox.Show(tr.ElementAt(i).InnerText);
                listaNombre.Add(tr.ElementAt(i).InnerText);
            }
            
            
            return listaNombre;
        }
    }
}

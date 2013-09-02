using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace MultasImpagas
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
        public Multas returnDatos()
        {
            Multas multa = new Multas();
            string texto = string.Empty;
            List<HtmlNode> tr = new List<HtmlNode>();
           // HtmlNode nodo = doc.DocumentNode.SelectSingleNode("//table[@class='grilla']");
            tr = doc.DocumentNode.SelectNodes("//td[@style='vertical-align:top;width:300px']").ToList();
            List<string> listaNombre = new List<string>();
            multa.CantMultasNoviembre = tr[0].ChildNodes[1].InnerText.ToString();
            multa.CantMultasHoy = tr[1].ChildNodes[1].InnerText.ToString();
           
            if (tr[0].ChildNodes.Count == 3)
            {
               multa.InfoNoviembre = false;
            }
            else
            {
                multa.InfoNoviembre = true;
                List<HtmlNode> td = tr[0].ChildNodes[3].ChildNodes.ToList();
                int i = 0;
                foreach (var item in td)
                {
                    if (i % 2 != 0 && i!=1)
                    {
                        List<HtmlNode> tdAbajo = item.ChildNodes.ToList();
                        multa.JuzgadosNoviembre.Add(tdAbajo[1].InnerText);
                        multa.RolCausaNoviembre.Add(tdAbajo[3].InnerText);
                    }
                    i++;
                }
            }
            if (tr[1].ChildNodes.Count == 3)
            {
                multa.DiaHoy = false;
            }
            else
            {
                multa.DiaHoy = true;
                List<HtmlNode> td = tr[1].ChildNodes[3].ChildNodes.ToList();
                int i = 0;
                foreach (var item in td)
                {
                    if (i % 2 != 0 && i != 1)
                    {
                        List<HtmlNode> tdAbajo = item.ChildNodes.ToList();
                        
                        multa.JuzgadosHoy.Add(tdAbajo[1].InnerText);
                        multa.RolCausaHoy.Add(tdAbajo[3].InnerText);
                    }
                    i++;
                }
            }
            
            return multa;
        }
    }
}

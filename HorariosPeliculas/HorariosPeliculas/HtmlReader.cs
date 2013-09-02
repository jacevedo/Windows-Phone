using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace HorariosPeliculas
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
        public List<string> returnTablas()
        {
            List<HtmlNode> tr = new List<HtmlNode>();
            // HtmlNode nodo = doc.DocumentNode.SelectSingleNode("//table[@class='grilla']");
            tr = doc.DocumentNode.SelectNodes("//table[@width='440']").ToList();
            List<Hoyts> lista = new List<Hoyts>();
            List<string> listaTextos = new List<string>();
            foreach (var item in tr)
            {
                List<HtmlNode> listaHijos = item.ChildNodes.ToList();
                StringBuilder texto = new StringBuilder();
                foreach (var item2 in listaHijos)
                {
                    if(item2.InnerText.Trim()!="")
                    {
                        List<HtmlNode> listaHijos2 = item2.ChildNodes.ToList();
                        foreach (var item3 in listaHijos2)
                        {
                            if (item3.InnerText.Trim() != "")
                            {
                                texto.AppendLine(item3.InnerText.Trim());
                               
                            }
                        }
                        
                    }
                }
                listaTextos.Add(texto.ToString());
            }
           
            return listaTextos;
        }
        public Hoyts retornaObjeto(HtmlNode nodo)
        {
            try
            {
                List<HtmlNode> HorarioPelicula = nodo.SelectNodes("//span [@class='titulos']").ToList();
                Hoyts cine = new Hoyts();
                for (int i = 0; i < HorarioPelicula.Count; i++)
                {
                    cine.Titulo.Add(HorarioPelicula.ElementAt(i).InnerText);
                    
                }

                return cine;
            }
            catch (NullReferenceException ex)
            {
                return new Hoyts();
            }
        }

        public ClassCinePlanet listaPeliculas()
        {
           
            List<HtmlNode> tr = new List<HtmlNode>();
            // HtmlNode nodo = doc.DocumentNode.SelectSingleNode("//table[@class='grilla']");
            tr = doc.DocumentNode.SelectNodes("//div[@class='cabecera']").ToList();
            List<HtmlNode> tr2 = new List<HtmlNode>();
            // HtmlNode nodo = doc.DocumentNode.SelectSingleNode("//table[@class='grilla']");
            tr2 = doc.DocumentNode.SelectNodes("//div[@class='informacion']").ToList();
            
            ClassCinePlanet planet = new ClassCinePlanet();
            
            foreach (var item in tr)
            {
                if (item.InnerText.Trim() != "" && item.InnerText.Trim() != "Los Top 10")
                {
                    planet.NomPeliculas.Add(item.InnerText.Trim().ToString());
                }
            }
            foreach (var item in tr2)
            {
                List<HtmlNode> listaNodos = item.ChildNodes.ToList();
                string informacion = string.Empty;
                foreach (var item2 in listaNodos)
                {
                    if (item2.InnerText.Trim() != "")
                    {
                        informacion = informacion + item2.InnerText.ToString().Trim().Replace("&nbsp;", " ");
                        informacion = informacion + "\n";
                    }
                }

              
                    planet.InfoPeliculas.Add(informacion);
            }
            return planet;
        }
        
        public void verHorarioPelicula()
        {
            HtmlNode tr;
            // HtmlNode nodo = doc.DocumentNode.SelectSingleNode("//table[@class='grilla']");
            tr = doc.DocumentNode.SelectSingleNode("//div[@class='contenedor-lista-peliculas2 clearfix']");
            MessageBox.Show(tr.InnerText.ToString());
        }
    }
}

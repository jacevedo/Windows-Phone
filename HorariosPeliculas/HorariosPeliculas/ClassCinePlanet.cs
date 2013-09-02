using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HorariosPeliculas
{
    class ClassCinePlanet
    {
        private List<string> nomPeliculas;
        private List<string> infoPeliculas;

        public ClassCinePlanet()
        {
            nomPeliculas = new List<string>();
            infoPeliculas = new List<string>();
        }

        public List<string> InfoPeliculas
        {
            get { return infoPeliculas; }
            set { infoPeliculas = value; }
        }
        
        public List<string> NomPeliculas
        {
            get { return nomPeliculas; }
            set { nomPeliculas = value; }
        }
        public List<string> listaIntercalada()
        {
            List<string> lista = new List<string>();
            for (int i = 0; i < nomPeliculas.Count; i++)
            {
                lista.Add(nomPeliculas.ElementAt(i));
                lista.Add(infoPeliculas.ElementAt(i));

            }
            return lista;
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarckBuks
{
    class Tienda
    {
        private string nomLocal;
        private string nomComuna;
        private string horario;
        private string descripcion;
        private string comoLlegar;

        public string NomLocal
        {
            get { return nomLocal; }
            set { nomLocal = value; }
        }
        public string NomComuna
        {
            get { return nomComuna; }
            set { nomComuna = value; }
        }
        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string ComoLlegar
        {
            get { return comoLlegar; }
            set { comoLlegar = value; }
        }




    }
}

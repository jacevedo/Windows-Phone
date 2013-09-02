using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarmaciaTurno
{
    class Comunas
    {
        public string nomComuna { get; set; }
        public int numRegion { get; set; }
        public string nomEnviar { get; set; }
        public Comunas(string nomComuna, int numRegion, string nomEnviar)
        {
            this.nomComuna = nomComuna;
            this.numRegion = numRegion;
            this.nomEnviar = nomEnviar;
        }
    }
}

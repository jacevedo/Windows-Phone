using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarmaciaTurno
{
    class Regiones
    {
        public string nomRegion { get; set; }
        public int numRegion { get; set; }
        public string nomEnviar { get; set; }
        public Regiones(string nomRegion, int numRegion,string nomEnviar)
        {
            this.nomRegion = nomRegion;
            this.numRegion = numRegion;
            this.nomEnviar = nomEnviar;
        }
    }
}

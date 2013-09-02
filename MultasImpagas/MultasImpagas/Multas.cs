using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultasImpagas
{
    class Multas
    {
        private bool infoNoviembre;
        private bool diaHoy;
        private string cantMultasNoviembre;
        private string cantMultasHoy;
        private List<string> juzgadosNoviembre;
        private List<string> rolCausaNoviembre;
        private List<string> juzgadosHoy;
        private List<string> rolCausaHoy;

        public Multas()
        {
            juzgadosHoy = new List<string>();
            rolCausaHoy = new List<string>();
            juzgadosNoviembre = new List<string>();
            rolCausaNoviembre = new List<string>();
        }


        public string CantMultasNoviembre
        {
            get { return cantMultasNoviembre; }
            set { cantMultasNoviembre = value; }
        }
        public string CantMultasHoy
        {
            get { return cantMultasHoy; }
            set { cantMultasHoy = value; }
        }
        public bool InfoNoviembre
        {
            get { return infoNoviembre; }
            set { infoNoviembre = value; }
        }
        public bool DiaHoy
        {
            get { return diaHoy; }
            set { diaHoy = value; }
        }        
        public List<string> JuzgadosNoviembre
        {
            get { return juzgadosNoviembre; }
            set { juzgadosNoviembre = value; }
        }
        public List<string> RolCausaNoviembre
        {
            get { return rolCausaNoviembre; }
            set { rolCausaNoviembre = value; }
        }
        public List<string> JuzgadosHoy
        {
            get { return juzgadosHoy; }
            set { juzgadosHoy = value; }
        }
        public List<string> RolCausaHoy
        {
            get { return rolCausaHoy; }
            set { rolCausaHoy = value; }
        }

    }
}

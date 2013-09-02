using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HorariosPeliculas
{
    class Hoyts
    {
        private List<string> titulo;
        private List<string> horario;


        public List<string> Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }


        public List<string> Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        public Hoyts()
        {
            titulo = new List<string>();
            horario = new List<string>();
        }
        public Hoyts(List<string> titulo, List<string> horario)
        {
            this.titulo = titulo;
            this.horario = horario;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generadorTorneosYLigas
{
    class Torneo
    {
        List<String> listaPersonas;
        public Torneo()
        {
            
        }
        public Torneo(List<String> listaPersonas)
        {
            this.listaPersonas = listaPersonas;
        }
      
        private void eliminarUltimo()
        {
            using (baseDatosDataContext contextoBD = new baseDatosDataContext("Data source='isostore:/baseDatosBD.sdf'"))
            {
                Torneos torneo = contextoBD.Torneos.Last();
                contextoBD.Torneos.DeleteOnSubmit(torneo);
                contextoBD.SubmitChanges();
            }
        }
        public int guardarTorneo()
        {
            Torneos torneo  = new Torneos();
            torneo.fechaTorneo = DateTime.Today;
            torneo.Id = 1;
            
            //torneo.Participantes = listaPersonas;
            int id = 1;
            using (baseDatosDataContext contextoBD = new baseDatosDataContext("Data source='isostore:/baseDatosBD.sdf'"))
            {
                if (!contextoBD.DatabaseExists())
                {
                    contextoBD.CreateDatabase();
                    
                }
                contextoBD.Torneos.InsertOnSubmit(torneo);
                contextoBD.SubmitChanges();
                id = contextoBD.Torneos.ToList().Last().Id;

            }
           
            return id;
        }
        public void guardarDatos( int idTorneo)
        {
            List<Participantes> participantes = new List<Participantes>();
            using (baseDatosDataContext contextoBD = new baseDatosDataContext("Data source='isostore:/baseDatosBD.sdf'"))
            {
                if (!contextoBD.DatabaseExists())
                {
                    contextoBD.CreateDatabase();
                }
                listaPersonas.Sort();
                foreach (string item in listaPersonas)
                {
                    Participantes participante = new Participantes();
                    participante.Id_Torneo = idTorneo;
                    participante.nom_participante = item;
                    participantes.Add(participante);
                    
                }
                contextoBD.Participantes.InsertAllOnSubmit(participantes);
                contextoBD.SubmitChanges();
            }
        }
        public List<String> obtenerParticipantes(int idTorneo)
        {
            List<string> listaParticipante = new List<string>();
            using (baseDatosDataContext contextoBD = new baseDatosDataContext("Data source='isostore:/baseDatosBD.sdf'"))
            {
                listaParticipante = (from x in contextoBD.Participantes
                                              where x.Id_Torneo == idTorneo
                                              select x.nom_participante).ToList();
                /*foreach (var item in listaPersonas)
                {
                    listaParticipante.Add(item.nom_participante);
                }*/
            }
            return listaParticipante;
        }
       
        public void agregarPersona()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndiceUV
{
    public class Lugares
    {
        private int idLugar;
        private string nomLugar;
        private string nomAMandar;
        private string urlRadiacion;
        public Lugares(int idLugar, string nomLugar, string nomAMandar,string urlRadiacion)
        {
            this.idLugar = idLugar;
            this.nomLugar = nomLugar;
            this.nomAMandar = nomAMandar;
            this.urlRadiacion = urlRadiacion;
        }

        public Lugares()
        {
            // TODO: Complete member initialization
        }

        public string UrlRadiacion
        {
            get { return urlRadiacion; }
            set { urlRadiacion = value; }
        }
        
        public int IdLugar
        {
            get { return idLugar; }
            set { idLugar = value; }
        }

        public string NomLugar
        {
            get { return nomLugar; }
            set { nomLugar = value; }
        }
        public string NomAMandar
        {
            get { return nomAMandar; }
            set { nomAMandar = value; }
        }
        public override string ToString()
        {
            return NomAMandar;
        }

    }
    public class listaLugares:List<Lugares>
    {
        public listaLugares()
        {
            Add(new Lugares(1, "ARICA", "Arica", "http://www.meteochile.gob.cl/js/uv_scar.js"));
            Add(new Lugares(2, "IQUIQUE", "Iquique", "http://www.meteochile.gob.cl/js/uv_scda.js"));
            Add(new Lugares(3, "MARIA ELENA", "Maria Elena", "http://www.meteochile.gob.cl/js/uv_mariaelena.js"));
            Add(new Lugares(4, "SAN PEDRO DE ATACAMA", "San Pedro de Atacama", "http://www.meteochile.gob.cl/js/uv_sanpedro.js"));
            Add(new Lugares(5, "ANTOFAGASTA", "Antofagasta", "http://www.meteochile.gob.cl/js/uv_scfa.js"));
            Add(new Lugares(6, "CALDERA", "Caldera", "http://www.meteochile.gob.cl/js/uv_sccl.js"));
            Add(new Lugares(7, "LA SERENA", "La Serena", "http://www.meteochile.gob.cl/js/uv_scse.js"));
            Add(new Lugares(8, "ISLA DE PASCUA", "Isla de Pascua", "http://www.meteochile.gob.cl/js/uv_scip.js"));
            Add(new Lugares(9, "LITORAL CENTRAL", "Litoral Central", "http://www.meteochile.gob.cl/js/uv_scvm.js"));
            Add(new Lugares(10, "CORDILLERA REGION METROPOLITANA", "Cordillera Region Metropolitana", "http://www.meteochile.gob.cl/js/uv_valle.js"));
            Add(new Lugares(11, "SANTIAGO", "Santiago", "http://www.meteochile.gob.cl/js/uv_scel.js"));
            Add(new Lugares(12, "RANCAGUA", "Rancagua", "http://www.meteochile.gob.cl/js/uv_rancagua.js"));
            Add(new Lugares(13, "TALCA", "Talca", "http://www.meteochile.gob.cl/js/uv_talca.js"));
            Add(new Lugares(14, "CONCEPCION", "Concepcion", "http://www.meteochile.gob.cl/js/uv_scie.js"));
            Add(new Lugares(15, "TEMUCO", "Temuco", "http://www.meteochile.gob.cl/js/uv_sctc.js"));
            Add(new Lugares(16, "VALDIVIA", "Valdivia", "http://www.meteochile.gob.cl/js/uv_scvd.js"));
            Add(new Lugares(17, "PUERTO MONTT", "Puerto Montt", "http://www.meteochile.gob.cl/js/uv_scte.js"));
            Add(new Lugares(18, "COYHAIQUE", "Coyhaique", "http://www.meteochile.gob.cl/js/uv_sccy.js"));
            Add(new Lugares(19, "PUNTA ARENAS", "Punta Arenas", "http://www.meteochile.gob.cl/js/uv_scci.js"));
            Add(new Lugares(20, "ANTARTICA", "Antartica", "http://www.meteochile.gob.cl/js/uv_scef.js"));
            
        }
    }

}

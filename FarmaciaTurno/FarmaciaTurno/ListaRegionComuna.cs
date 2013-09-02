using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarmaciaTurno
{
    class ListaRegionComuna
    {
        public List<Comunas> comunas1region {get;set;}
        public List<Comunas> comunas2region { get; set; }
        public List<Comunas> comunas3region { get; set; }
        public List<Comunas> comunas4region { get; set; }
        public List<Comunas> comunas5region { get; set; }
        public List<Comunas> comunas6region { get; set; }
        public List<Comunas> comunas7region { get; set; }
        public List<Comunas> comunas8region { get; set; }
        public List<Comunas> comunas9region { get; set; }
        public List<Comunas> comunas10region { get; set; }
        public List<Comunas> comunas11region { get; set; }
        public List<Comunas> comunas12region { get; set; }
        public List<Comunas> comunas13region { get; set; }
        public List<Comunas> comunas14region { get; set; }
        public List<Comunas> comunas15region { get; set; }
        public List<Regiones> regiones { get; set; }
        public ListaRegionComuna()
        {
            llenarRegiones();
            llenarComunas();
        }

        private void llenarComunas()
        {
            comunas1region = new List<Comunas>();
            comunas1region.Add(new Comunas("Alto Hospicio", 1, "alto hospicio"));
            comunas1region.Add(new Comunas("Iquique", 1, "iquique"));
            comunas1region.Add(new Comunas("PICA", 1, "pica"));
            comunas1region.Add(new Comunas("POZO ALMONTE", 1, "pozo almonte"));
            
            comunas2region = new List<Comunas>();
            comunas2region.Add(new Comunas("Antofagasta", 2, "antofagasta"));
            comunas2region.Add(new Comunas("Calama", 2, "calama"));
            comunas2region.Add(new Comunas("Mejillones", 2, "mejillones"));
            comunas2region.Add(new Comunas("Tal Tal", 2, "tal tal"));
            comunas2region.Add(new Comunas("Tocopilla", 2, "tocopilla"));

            comunas3region = new List<Comunas>();
            comunas3region.Add(new Comunas("CALDERA", 3, "caldera"));
            comunas3region.Add(new Comunas("CHAÑARAL", 3, "chanaral"));
            comunas3region.Add(new Comunas("COPIAPÓ", 3, "copiapo"));
            comunas3region.Add(new Comunas("HUASCO", 3, "huasco"));
            comunas3region.Add(new Comunas("TIERRA AMARILLA", 3, "tierra amarilla"));
            comunas3region.Add(new Comunas("VALLENAR", 3, "vallenar"));


            comunas4region = new List<Comunas>();
            comunas4region.Add(new Comunas("Combarbalá", 4, "combarbala"));
            comunas4region.Add(new Comunas("COQUIMBO", 4, "coquimbo"));
            comunas4region.Add(new Comunas("ILLAPEL", 4, "illapel"));
            comunas4region.Add(new Comunas("LA SERENA", 4, "la serena"));
            comunas4region.Add(new Comunas("LOS VILOS", 4, "los vilos"));
            comunas4region.Add(new Comunas("OVALLE", 4, "ovalle"));
            comunas4region.Add(new Comunas("Salamanca", 4, "salamanca"));
            comunas4region.Add(new Comunas("VICUÑA", 4, "vicuna"));

            comunas5region = new List<Comunas>();
            comunas5region.Add(new Comunas("ALGARROBO", 5, "algarrobo"));
            comunas5region.Add(new Comunas("CABILDO", 5, "cabildo"));
            comunas5region.Add(new Comunas("CALLE LARGA", 5, "calle larga"));
            comunas5region.Add(new Comunas("CARTAGENA", 5, "cartagena"));
            comunas5region.Add(new Comunas("CASABLANCA", 5, "casablanca"));
            comunas5region.Add(new Comunas("CATEMU", 5, "catemu"));
            comunas5region.Add(new Comunas("CONCON", 5, "concon"));
            comunas5region.Add(new Comunas("EL QUISCO", 5, "el quisco"));
            comunas5region.Add(new Comunas("EL TABO", 5, "el tabo"));
            comunas5region.Add(new Comunas("ISLA DE PASCUA", 5, "isla de pascua"));
            comunas5region.Add(new Comunas("JUAN FERNANDEZ", 5, "juan fernandez"));
            comunas5region.Add(new Comunas("LA CALERA", 5, "la calera"));
            comunas5region.Add(new Comunas("LA CRUZ", 5, "la cruz"));
            comunas5region.Add(new Comunas("LA LIGUA", 5, "la ligua"));
            comunas5region.Add(new Comunas("LIMACHE", 5, "limache"));
            comunas5region.Add(new Comunas("LLAY LLAY", 5, "llay llay"));
            comunas5region.Add(new Comunas("LOS ANDES", 5, "los andes"));
            comunas5region.Add(new Comunas("NOGALES", 5, "nogales"));
            comunas5region.Add(new Comunas("OLMUE", 5, "olmue"));
            comunas5region.Add(new Comunas("PAPUDO", 5, "papudo"));
            comunas5region.Add(new Comunas("PETORCA", 5, "petorca"));
            comunas5region.Add(new Comunas("PUCHUNCAVI", 5, "puchuncavi"));
            comunas5region.Add(new Comunas("PUTAENDO", 5, "putaendo"));
            comunas5region.Add(new Comunas("QUILLOTA", 5, "quillota"));
            comunas5region.Add(new Comunas("QUILPUE", 5, "quilpue"));
            comunas5region.Add(new Comunas("QUINTERO", 5, "quintero"));
            comunas5region.Add(new Comunas("SAN ANTONIO", 5, "san antonio"));
            comunas5region.Add(new Comunas("SAN FELIPE", 5, "san felipe"));
            comunas5region.Add(new Comunas("SANTA MARIA", 5, "santa maria"));
            comunas5region.Add(new Comunas("SANTO DOMINGO", 5, "santo domingo"));
            comunas5region.Add(new Comunas("VALPARAISO", 5, "valparaiso"));
            comunas5region.Add(new Comunas("VILLA ALEMANA", 5, "villa alemana"));
            comunas5region.Add(new Comunas("VIÑA DEL MAR", 5, "vina del mar"));
            comunas5region.Add(new Comunas("ZAPALLAR", 5, "zapallar"));

            comunas6region = new List<Comunas>();
            comunas6region.Add(new Comunas("Chimbarongo", 6, "chimbarongo"));
            comunas6region.Add(new Comunas("Graneros", 6, "graneros"));
            comunas6region.Add(new Comunas("Las Cabras", 6, "las cabras"));
            comunas6region.Add(new Comunas("Machalí", 6, "machali"));
            comunas6region.Add(new Comunas("Mostazal", 6, "mostazal"));
            comunas6region.Add(new Comunas("Nancagua", 6, "nancagua"));
            comunas6region.Add(new Comunas("Pichidegua", 6, "pichidegua"));
            comunas6region.Add(new Comunas("Pichilemu", 6, "pichilemu"));
            comunas6region.Add(new Comunas("Rancagua", 6, "rancagua"));
            comunas6region.Add(new Comunas("Rengo", 6, "rengo"));
            comunas6region.Add(new Comunas("Requinoa", 6, "requinoa"));
            comunas6region.Add(new Comunas("San Fernando", 6, "san fernando"));
            comunas6region.Add(new Comunas("San Vicente de Tagua Tagua", 6, "san vicente de tagua tagua"));
            comunas6region.Add(new Comunas("Santa Cruz", 6, "santa cruz"));

            comunas7region = new List<Comunas>();
            comunas7region.Add(new Comunas("CAUQUENES", 7, "cauquenes"));
            comunas7region.Add(new Comunas("CONSTITUCIÓN", 7, "constitucion"));
            comunas7region.Add(new Comunas("CURICÓ Centro", 7, "curico centro"));
            comunas7region.Add(new Comunas("CURICÓ Externo", 7, "curico externo"));
            comunas7region.Add(new Comunas("Hualañé", 7, "hualane"));
            comunas7region.Add(new Comunas("LINARES", 7, "linares"));
            comunas7region.Add(new Comunas("LONGAVÍ", 7, "longavi"));
            comunas7region.Add(new Comunas("MOLINA", 7, "molina"));
            comunas7region.Add(new Comunas("PARRAL", 7, "parral"));
            comunas7region.Add(new Comunas("Retiro", 7, "retiro"));
            comunas7region.Add(new Comunas("SAN CLEMENTE", 7, "san clemente"));
            comunas7region.Add(new Comunas("SAN JAVIER", 7, "san javier"));
            comunas7region.Add(new Comunas("TALCA Centro", 7, "talca centro"));
            comunas7region.Add(new Comunas("TALCA Externo", 7, "talca externo"));
            comunas7region.Add(new Comunas("Teno", 7, "teno"));

            comunas8region = new List<Comunas>();
            comunas8region.Add(new Comunas("ARAUCO", 8, "arauco"));
            comunas8region.Add(new Comunas("Bulnes", 8, "bulnes"));
            comunas8region.Add(new Comunas("CABRERO", 8, "cabrero"));
            comunas8region.Add(new Comunas("CAÑETE", 8, "canete"));
            comunas8region.Add(new Comunas("CHIGUAYANTE", 8, "chiguayante"));
            comunas8region.Add(new Comunas("CHILLAN", 8, "chillan"));
            comunas8region.Add(new Comunas("Coelemu", 8, "coelemu"));
            comunas8region.Add(new Comunas("CONCEPCION", 8,"concepcion"));
            comunas8region.Add(new Comunas("CORONEL", 8, "coronel"));
            comunas8region.Add(new Comunas("CURANILAHUE", 8, "curanilahue"));
            comunas8region.Add(new Comunas("LAJA", 8, "laja"));
            comunas8region.Add(new Comunas("LEBU", 8,"lebu"));
            comunas8region.Add(new Comunas("LOS ANGELES", 8,"los angeles"));
            comunas8region.Add(new Comunas("LOTA", 8, "lota"));
            comunas8region.Add(new Comunas("MULCHEN", 8, "mulchen"));
            comunas8region.Add(new Comunas("NACIMIENTO", 8, "nacimiento"));
            comunas8region.Add(new Comunas("PENCO", 8,"penco"));
            comunas8region.Add(new Comunas("Quillón", 8, "quillon"));
            comunas8region.Add(new Comunas("Quirihue", 8, "quirihue"));
            comunas8region.Add(new Comunas("San Carlos", 8, "san carlos"));
            comunas8region.Add(new Comunas("SAN PEDRO DE LA PAZ", 8,"san pedro de la paz"));
            comunas8region.Add(new Comunas("TALAHUANO-HUALPÉN", 8,"talahuano-hualpen"));
            comunas8region.Add(new Comunas("TOMÉ", 8, "tome"));
            comunas8region.Add(new Comunas("MULCHEN", 8, "mulchen"));
            comunas8region.Add(new Comunas("YUMBEL", 8, "yumbel"));
            comunas8region.Add(new Comunas("Yungay", 8, "yungay"));

            comunas9region = new List<Comunas>();
            comunas9region.Add(new Comunas("Angol", 9, "angol"));
            comunas9region.Add(new Comunas("Carahue", 9, "carahue"));
            comunas9region.Add(new Comunas("Collipulli", 9, "collipulli"));
            comunas9region.Add(new Comunas("Curacautin", 9, "curacautin"));
            comunas9region.Add(new Comunas("Lautaro", 9, "lautaro"));
            comunas9region.Add(new Comunas("Loncoche", 9, "loncoche"));
            comunas9region.Add(new Comunas("Nva Imperial", 9, "nva imperial"));
            comunas9region.Add(new Comunas("Padre las casas", 9, "padre las casas"));
            comunas9region.Add(new Comunas("Pitrufquen", 9, "pitrufquen"));
            comunas9region.Add(new Comunas("Pucon", 9, "pucon"));
            comunas9region.Add(new Comunas("Temuco", 9, "temuco"));
            comunas9region.Add(new Comunas("Traiguen", 9, "traiguen"));
            comunas9region.Add(new Comunas("Victoria", 9, "victoria"));
            comunas9region.Add(new Comunas("Villarrica", 9, "villarrica"));
            
            comunas10region = new List<Comunas>();
            comunas10region.Add(new Comunas("ACHAO", 10, "achao"));
            comunas10region.Add(new Comunas("ANCUD", 10, "ancud"));
            comunas10region.Add(new Comunas("CALBUCO", 10, "calbuco"));
            comunas10region.Add(new Comunas("CASTRO", 10, "castro"));
            comunas10region.Add(new Comunas("CHONCHI", 10, "chonchi"));
            comunas10region.Add(new Comunas("DALCAHUE", 10, "dalcahue"));
            comunas10region.Add(new Comunas("FRESIA", 10 , "fresia"));
            comunas10region.Add(new Comunas("FRUTILLAR", 10, "frutillar"));
            comunas10region.Add(new Comunas("LLANQUIHUE", 10, "llanquihue"));
            comunas10region.Add(new Comunas("LOS MUERMOS", 10, "los muermos"));
            comunas10region.Add(new Comunas("MAULLIN", 10, "maullin"));
            comunas10region.Add(new Comunas("OSORNO", 10, "osorno"));
            comunas10region.Add(new Comunas("Puerto Montt", 10, "puerto montt"));
            comunas10region.Add(new Comunas("PUERTO VARAS", 10, "puerto varas"));
            comunas10region.Add(new Comunas("PURRANQUE", 10, "purranque"));
            comunas10region.Add(new Comunas("QUELLON", 10, "quellon"));
            comunas10region.Add(new Comunas("RIO NEGRO HORNOPIREN", 10, "rio negro hornopiren"));
            
            comunas11region = new List<Comunas>();
            comunas11region.Add(new Comunas("Chile Chico", 11, "chile chico"));
            comunas11region.Add(new Comunas("Coyhaique", 11, "coyhaique"));
            comunas11region.Add(new Comunas("Puerto Aysén", 11, "puerto aysen"));

            
            comunas12region = new List<Comunas>();
            comunas12region.Add(new Comunas("PUERTO NATALES", 12, "puerto natales"));
            comunas12region.Add(new Comunas("PUNTA ARENAS", 12, "punta arenas"));

            comunas13region = new List<Comunas>();
            comunas13region.Add(new Comunas("BUIN - PAINE - CALERA DE TANGO", 13, "buin - paine - calera de tango"));
            comunas13region.Add(new Comunas("CERRO NAVIA - RENCA", 13, "cerro navia - renca"));
            comunas13region.Add(new Comunas("COLINA - LAMPA - TIL TIL", 13, "colina - lampa - til til"));
            comunas13region.Add(new Comunas("CONCHALI - HUECHURABA", 13, "conchali - huechuraba"));
            comunas13region.Add(new Comunas("CURACAVI", 13, "curacavi"));
            comunas13region.Add(new Comunas("EL BOSQUE", 13, "el bosque"));
            comunas13region.Add(new Comunas("ESTACION CENTRAL", 13, "estacion central"));
            comunas13region.Add(new Comunas("INDEPENDENCIA - RECOLETA", 13, "independencia - recoleta"));
            comunas13region.Add(new Comunas("LA CISTERNA - LO ESPEJO", 13, "la cisterna - lo espejo"));
            comunas13region.Add(new Comunas("LA FLORIDA", 13, "la florida"));
            comunas13region.Add(new Comunas("LA GRANJA - LA PINTANA - SAN RAMÓN", 13, "la granja - la pintana - san ramon"));
            comunas13region.Add(new Comunas("LA REINA - PEÑALOLEN", 13, "la reina - penalolen"));
            comunas13region.Add(new Comunas("LAS CONDES", 13, "las condes"));
            comunas13region.Add(new Comunas("LO BARNECHEA", 13, "lo barnechea"));
            comunas13region.Add(new Comunas("LO PRADO - QUINTA NORMAL", 13, "lo prado - quinta normal"));
            comunas13region.Add(new Comunas("MAIPÚ - CERRILLOS", 13, "maipu - cerrillos"));
            comunas13region.Add(new Comunas("MELIPILLA - ALHUE - MARIA PINTO", 13, "melipilla - alhue - maria pinto"));
            comunas13region.Add(new Comunas("ÑUÑOA - MACUL", 13, "nunoa - macul"));
            comunas13region.Add(new Comunas("P.A.C - SAN MIGUEL - SAN JOAQUIN", 13, "p.a.c - san miguel - san joaquin"));
            comunas13region.Add(new Comunas("PADRE HURTADO - PEÑAFLOR", 13, "padre hurtado - penaflor"));
            comunas13region.Add(new Comunas("PROVIDENCIA", 13, "providencia"));
            comunas13region.Add(new Comunas("PUDAHUEL", 13, "pudahuel"));
            comunas13region.Add(new Comunas("PUENTE ALTO - PIRQUE - SAN JOSE DE MAIPO", 13, "puente alto - pirque - san jose de maipo"));
            comunas13region.Add(new Comunas("QUILICURA", 13, "quilicura"));
            comunas13region.Add(new Comunas("SAN BERNARDO", 13, "san bernardo"));
            comunas13region.Add(new Comunas("SANTIAGO", 13, "santiago"));
            comunas13region.Add(new Comunas("TALAGANTE - EL MONTE - ISLA DE MAIPO", 13, "talagante - el monte - isla de maipo"));
            comunas13region.Add(new Comunas("VITACURA", 13, "vitacura"));
            
            comunas14region = new List<Comunas>();
            comunas14region.Add(new Comunas("Futrono", 14, "futrono"));
            comunas14region.Add(new Comunas("La Unión", 14, "la union"));
            comunas14region.Add(new Comunas("Lanco", 14, "lanco"));
            comunas14region.Add(new Comunas("Paillaco", 14, "paillaco"));
            comunas14region.Add(new Comunas("Panguipulli", 14, "Panguipulli"));
            comunas14region.Add(new Comunas("Río Bueno", 14, "rio bueno"));
            comunas14region.Add(new Comunas("Valdivia", 14, "valdivia"));
            
            comunas15region = new List<Comunas>();
            comunas15region.Add(new Comunas("ARICA", 15, "arica"));            
        }

        private void llenarRegiones()
        {
            regiones = new List<Regiones>();
            regiones.Add(new Regiones("Tarapaca", 1, "i - tarapaca"));
            regiones.Add(new Regiones("Antofagasta", 2, "ii - antofagasta"));
            regiones.Add(new Regiones("Atacama", 3, "iii - atacama"));
            regiones.Add(new Regiones("Coquimbo", 4,"iv - coquimbo"));
            regiones.Add(new Regiones("Valparaíso", 5, "v- valparaiso"));
            regiones.Add(new Regiones("O'Higgins", 6, "vi - o"));
            regiones.Add(new Regiones("Maule", 7, "vii - maule"));
            regiones.Add(new Regiones("Bio Bio", 8, "viii- bio bio"));
            regiones.Add(new Regiones("La Araucanía", 9, "ix - araucania"));
            regiones.Add(new Regiones("Los Lagos", 10, "x - los lagos"));
            regiones.Add(new Regiones("Aysén", 11, "xi - aysen del gral c.i.c."));
            regiones.Add(new Regiones("Magallanes", 12,"xii - magallanes y la antartica chilena"));
            regiones.Add(new Regiones("Metropolitana", 13, "rm - metropolitana"));
            regiones.Add(new Regiones("Los Ríos", 14, "xiv - los rios"));
            regiones.Add(new Regiones("Arica y Parinacota", 15, "xv - arica y parinacota"));
        }
    }
}

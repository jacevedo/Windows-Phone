using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aves
{
    class HabitatClass
    {
        public List<HabitatDB> habitatDB { get; set; }
        public HabitatClass()
        {
            habitatDB = new List<HabitatDB>()
            {
                    new HabitatDB()
                    {
                        id = 0,
                        nom_Habitat = "Salares del Altiplano",
                        descripcion = "El altiplano chileno se hubica entre la Primera y Tercera región, "+
                                        " entre los 3000 y 4000 m. de altura. Es una zona relativamente plana,"+
                                        " con temperaturas medias anuales bajas, vegetación de tipo esteparia y,"+
                                        " durante el llamado \"invierno altiplánico o boliviano\", con fuertes"+
                                        " presipitaciones ocacionales. Sin embargo, en sus lagos, lagunas, salares"+
                                        " y bofedales se concentra una avifauna rica en especies."


                    },
                    new HabitatDB()
                    {
                        id = 1,
                        nom_Habitat = "Oasis del norte",
                        descripcion = "El desierto del norte grande es uno de los mas sécos del mundo, con"+
                                        " presipitaciones prácticamente ausentes y grandes contrastes entre"+
                                        " las temperaturas diurnas y nocturnas. \n A lo largo de los ríos que"+
                                        " bajan de la cordillera, en los lugares donde las aguas subterráneas"+
                                        " afloran o se acercan a la superficie y muy especialmente en los"+
                                        " asentamientos humanos, se originan verdaderos oasis con una densa"+
                                        " vegetación atractiva para muchas especies de aves."
                    },
                    new HabitatDB()
                    {
                        id = 2,
                        nom_Habitat = "Jardines de la ciudad",
                        descripcion = "El desierto del norte grande es uno de los mas sécos del mundo"
                    },
                    new HabitatDB()
                    {
                        id = 3,
                        nom_Habitat = "Campos y serranías de la zona central",
                        descripcion = "El desierto del norte grande es uno de los mas sécos del mundo"
                    },
                    new HabitatDB()
                    {
                        id = 4,
                        nom_Habitat = "Playas",
                        descripcion = "El desierto del norte grande es uno de los mas sécos del mundo"
                    },
                    new HabitatDB()
                    {
                        id = 5,
                        nom_Habitat = "Humedales",
                        descripcion = "El desierto del norte grande es uno de los mas sécos del mundo"
                    },
                    new HabitatDB()
                    {
                        id = 6,
                        nom_Habitat = "Zona sur",
                        descripcion = "El desierto del norte grande es uno de los mas sécos del mundo"
                    },
                    new HabitatDB()
                    {
                        id = 7,
                        nom_Habitat = "Cordillera",
                        descripcion = "El desierto del norte grande es uno de los mas sécos del mundo"
                    }

            };
        }
    }
}

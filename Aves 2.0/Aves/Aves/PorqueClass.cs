using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aves
{
    class PorqueClass
    {
        public List<PorqueDB> Porque { get; set; }
        public PorqueClass()
        {
            Porque = new List<PorqueDB>()
            {
                    new PorqueDB()
                    {
                        id = 1,
                        nomPor= "Todas emiten sonidos?",
                        descripcion = "El altiplano chileno se hubica entre la Primera y Tercera región, "+
                                        " entre los 3000 y 4000 m. de altura. Es una zona relativamente plana,"+
                                        " con temperaturas medias anuales bajas, vegetación de tipo esteparia y,"+
                                        " durante el llamado \"invierno altiplánico o boliviano\", con fuertes"+
                                        " presipitaciones ocacionales. Sin embargo, en sus lagos, lagunas, salares"+
                                        " y bofedales se concentra una avifauna rica en especies."


                    },
                    new PorqueDB()
                    {
                        id = 2,
                        nomPor= "En donde se originan las voces?",
                        descripcion = "El desierto del norte grande es uno de los mas sécos del mundo, con"+
                                        " presipitaciones prácticamente ausentes y grandes contrastes entre"+
                                        " las temperaturas diurnas y nocturnas. \n A lo largo de los ríos que"+
                                        " bajan de la cordillera, en los lugares donde las aguas subterráneas"+
                                        " afloran o se acercan a la superficie y muy especialmente en los"+
                                        " asentamientos humanos, se originan verdaderos oasis con una densa"+
                                        " vegetación atractiva para muchas especies de aves."
                    },
                    new PorqueDB()
                    {
                        id = 3,
                        nomPor= "Emiten sonidos solo por la boca?",
                        descripcion = "El desierto del norte grande es uno de los mas sécos del mundo"
                    },
                    new PorqueDB()
                    {
                        id = 4,
                        nomPor= "Como se clasifican las voces?",
                        descripcion = "El desierto del norte grande es uno de los mas sécos del mundo"
                    },
                    new PorqueDB()
                    {
                        id = 5,
                        nomPor= "Que significan los gritos?",
                        descripcion = "El desierto del norte grande es uno de los mas sécos del mundo"
                    },
                    new PorqueDB()
                    {
                        id = 6,
                        nomPor= "Que significan los cantos?",
                        descripcion = "El desierto del norte grande es uno de los mas sécos del mundo"
                    },
                    new PorqueDB()
                    {
                        id = 7,
                        nomPor= "Todos los pajaros cantan?",
                        descripcion = "El desierto del norte grande es uno de los mas sécos del mundo"
                    },
                    new PorqueDB()
                    {
                        id = 8,
                        nomPor= "Porque hay cantos diferentes?",
                        descripcion = "El desierto del norte grande es uno de los mas sécos del mundo"
                    },
                    new PorqueDB()
                    {
                        id = 9,
                        nomPor= "Deben aprender su canto?",
                        descripcion = "El desierto del norte grande es uno de los mas sécos del mundo"
                    },
                    new PorqueDB()
                    {
                        id = 10,
                        nomPor= "Donde y a que hora cantan?",
                        descripcion = "El desierto del norte grande es uno de los mas sécos del mundo"
                    },
                    new PorqueDB()
                    {
                        id = 11,
                        nomPor= "Que es un sonograma?",
                        descripcion = "El desierto del norte grande es uno de los mas sécos del mundo"
                    }
            };
        }
    }
}

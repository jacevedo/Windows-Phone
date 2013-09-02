using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Votaciones.Model;

namespace Votaciones.View
{
    public class Controlador
    {
        public ObservableCollection<Objeto> personajes;

        public void GetPersonajesDefault()
        {
            personajes = new ObservableCollection<Objeto>();
            this.personajes.Add(new Objeto("Alamand", 0));
            this.personajes.Add(new Objeto("Bachelet", 0));
        }

       
    }
}

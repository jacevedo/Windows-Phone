using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Votaciones.Model
{
    public class Objeto : INotifyPropertyChanged
    {
        private string nomCandidato;
        private int cantVotos;

        public Objeto(string nomCandidato, int cantVotos)
        {
            this.nomCandidato = nomCandidato;
            this.cantVotos = cantVotos;
        }

        public string NomCandidato
        {
            get 
            { 
                return nomCandidato; 
            }
            set 
            { 
                nomCandidato = value;
                RaisePropertyChanged("nomCandidato");
            }
        }

        public int CantVotos
        {
            get 
            {
                return cantVotos; 
            }
            set
            {
                cantVotos = value;
                RaisePropertyChanged("cantVotos");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public Objeto GetCopy()
        {
            Objeto copy = (Objeto)this.MemberwiseClone();
            return copy;
        }

    }
}

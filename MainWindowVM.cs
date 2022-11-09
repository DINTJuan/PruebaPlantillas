using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPlantillas
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Persona> personas;

        public ObservableCollection<Persona> Personas
        {
            get { return personas; }
            set { personas = value;
                NotifyPropertyChanged("Personas");
            }
        }

        public MainWindowVM()
        {
            Personas = new ObservableCollection<Persona>();
            Personas.Add(new Persona("Pedro",23));
            Personas.Add(new Persona("Ana", 28));
            Personas.Add(new Persona("Julian", 30));
        }

        private Persona personasActual;

        public Persona PersonasActual
        {
            get { return personasActual; }
            set { personasActual = value;
                personasActual = value;
                NotifyPropertyChanged("PersonasActual");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

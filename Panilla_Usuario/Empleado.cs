using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Panilla_Usuario
{
    public class Empleado : INotifyPropertyChanged
    {
        private string nombre;
        private string identidad;
        private string horasTrabajadas;
        private string pagoPorHora;
        private string horasExtraTrabajadas;
        private string pagoPorHoraExtra;

        private string sueldoNeto;
        private string sueldoDeducciones;
        private string sueldoPorHorasTrabajadas;
        private string SueldoTotal;
        private bool valido;

        public string Nombre
        {
            get { return nombre; }
            set
            {

                OnPropertyChanged("Nombre");

            }

        }
        public string Identidad
        {
            get { return identidad; }
            set
            {
                int numero;
                bool valido = int.TryParse(value, out numero);
                if (valido) identidad = value;
                OnPropertyChanged("Identidad");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            //if(PropertyChanged!=null)
                
        }
    }
}

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
        private string sueldoTotal;
        private bool valido;

        //public string Nombre
        //{
        //    get { return nombre; }
        //    set
        //    {

        //        OnPropertyChanged("Nombre");

        //    }

        //}
        //public string Identidad
        //{
        //    get { return identidad; }
        //    set
        //    {
        //        int numero;
        //        bool valido = int.TryParse(value, out numero);
        //        if (valido) identidad = value;
        //        OnPropertyChanged("Identidad");
                
        //    }
        //}

        public string HorasTrabajadas
        {
            get { return horasTrabajadas; }
            set
            {
                int numero;
                bool valido = int.TryParse(value, out numero);
                if (valido) horasTrabajadas = value;
                OnPropertyChanged("HorasTrabajadas");
                OnPropertyChanged("SueldoNeto");
                OnPropertyChanged("HorasExtrasTrabajadas");
                OnPropertyChanged("Deducciones");
                OnPropertyChanged("SueldoTotal");
            }
        }
        public string HorasExtraTrabajadas
        {
            get { return horasExtraTrabajadas; }
            set
            {
                int numero;
                bool valido = int.TryParse(value, out numero);
                if (valido) horasExtraTrabajadas = value;
                OnPropertyChanged("HorasTrabajadas");
                OnPropertyChanged("SueldoNeto");
                OnPropertyChanged("HorasExtrasTrabajadas");
                OnPropertyChanged("Deducciones");
                OnPropertyChanged("SueldoTotal");
            }
        }

        public string PagoPoHora
        {
            get { return pagoPorHora; }
            set
            {
                int numero;
                bool valido = int.TryParse(value, out numero);
                if (valido) pagoPorHora = value;
                OnPropertyChanged("HorasTrabajadas");
                OnPropertyChanged("SueldoNeto");
                OnPropertyChanged("HorasExtrasTrabajadas");
                OnPropertyChanged("Deducciones");
                OnPropertyChanged("SueldoTotal");
            }
        }
        public string PagoPoHoraExtra
        {
            get { return pagoPorHora; }
            set
            {
                int numero;
                bool valido = int.TryParse(value, out numero);
                if (valido) pagoPorHora = value;
                OnPropertyChanged("HorasTrabajadas");
                OnPropertyChanged("SueldoNeto");
                OnPropertyChanged("HorasExtrasTrabajadas");
                OnPropertyChanged("Deducciones");
                OnPropertyChanged("SueldoTotal");
            }
        }
        public string SueldoNeto
        {
            get {

                double sueldo = double.Parse(HorasTrabajadas) * double.Parse(PagoPoHora);
                sueldoNeto = sueldo.ToString();
                return sueldoNeto;

            }
            set
            {
                double sueldo = double.Parse(HorasTrabajadas) * double.Parse(PagoPoHora);
                sueldoNeto = sueldo.ToString();

                OnPropertyChanged("SueldoNeto");
            }
        }

        public string SueldoDeducciones
        {
            get
            {
                double deduc;
                double sueldo = double.Parse(HorasTrabajadas) * double.Parse(PagoPoHora);
                deduc = (sueldo * 0.4 * 0.35);
                sueldoDeducciones = deduc.ToString();
                return sueldoDeducciones;

            }
            set
            {
                double deduc;
                double sueldo = double.Parse(HorasTrabajadas) * double.Parse(PagoPoHora);
                deduc = (sueldo * 0.4 * 0.35);
                sueldoDeducciones = deduc.ToString();
                OnPropertyChanged("SueldoDeducciones");
            }
        }

        public string SueldoHorasExtra
        {
            get
            {

                double sueldo = double.Parse(HorasExtraTrabajadas) * double.Parse(PagoPoHoraExtra);
                sueldoPorHorasTrabajadas = sueldo.ToString();
                return sueldoPorHorasTrabajadas;

            }
            set
            {
                double sueldo = double.Parse(HorasExtraTrabajadas) * double.Parse(PagoPoHoraExtra);
                sueldoPorHorasTrabajadas = sueldo.ToString();

                OnPropertyChanged("SueldoHorasExtra");
            }
        }
        public string SueldoTotal
        {
            get
            {

                double sueldo = double.Parse(SueldoNeto) + double.Parse(SueldoHorasExtra)-Double.Parse(SueldoDeducciones);
                sueldoTotal= sueldo.ToString();
                return sueldoPorHorasTrabajadas;

            }
            set
            {
                double sueldo = double.Parse(SueldoNeto) + double.Parse(SueldoHorasExtra) - Double.Parse(SueldoDeducciones);
                sueldoTotal = sueldo.ToString();

                OnPropertyChanged("SueldoTotal");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}

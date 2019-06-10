using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Panilla_Usuario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static class UIGlobal
        {
            public static MainWindow ventana { get; set; }
        }
        public Empleado losEmpleados { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            losEmpleados = new Empleado {PagoPoHora="0",PagoPoHoraExtra="0",HorasExtraTrabajadas="0",HorasTrabajadas="0",SueldoNeto="0",SueldoDeducciones="0",SueldoTotal="0",SueldoHorasExtra="0"};
            this.DataContext = losEmpleados;
        }
    }
}

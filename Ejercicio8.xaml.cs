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
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppsConsola
{
    /// <summary>
    /// Lógica de interacción para Ejercicio8.xaml
    /// </summary>
    public partial class Ejercicio8 : Window
    {
        double horasTrabajadas, tarifa, salario; 
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void btnSalario_Click(object sender, RoutedEventArgs e)
        {
            

            if (!double.TryParse(txtHorasTrabajadas.Text, out horasTrabajadas))
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!double.TryParse(txtTarifa.Text, out tarifa))
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (horasTrabajadas  > 0)
            {
                salario = horasTrabajadas * tarifa;
                txtResultado.Text = $"El salario del trabajador es: ${salario:F}";
            } else
                txtResultado.Text = $"Las horas trabajadas no pueden ser negativas";
        }
    }
}

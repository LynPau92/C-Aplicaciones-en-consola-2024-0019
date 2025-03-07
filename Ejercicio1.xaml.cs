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

namespace AppsConsola
{
    /// <summary>
    /// Lógica de interacción para Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        public Ejercicio1()
        {
            InitializeComponent();

        }

        private void btnSalario_Click(object sender, RoutedEventArgs e)
        {
            double horasTrabajadas, tarifa, horasExtra, salario, tarifaExtra;


            if (!double.TryParse(txtHorasTrabajadas.Text, out horasTrabajadas) || horasTrabajadas < 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido para las horas trabajadas.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!double.TryParse(txtTarifa.Text, out tarifa) || tarifa < 0)
            {
                MessageBox.Show("Por favor, ingrese una tarifa válida.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            if (horasTrabajadas <= 40 && horasTrabajadas >= 0)
            {
                salario = horasTrabajadas * tarifa;
                txtResultado.Text = $"El salario del trabajador es: ${salario:F}";
            }
            else if (horasTrabajadas > 40)
            {
                horasExtra = horasTrabajadas - 40;
                tarifaExtra = tarifa + 0.5 * tarifa;
                salario = horasExtra * tarifaExtra + 40 * tarifa;
                txtResultado.Text = $"El salario del trabajador es: ${salario:F}";
            }
            else
                txtResultado.Text = $"Las horas trabajadas no pueden ser negativas";
        }

    }
}

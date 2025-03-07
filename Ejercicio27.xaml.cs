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
    /// Lógica de interacción para Ejercicio27.xaml
    /// </summary>
    public partial class Ejercicio27 : Window
    {
        double caja, egreso, c, totalegresos, restocaja; 
        public Ejercicio27()
        {
            InitializeComponent();
            totalegresos = 0;
            caja = 371;
            
            c = 1;
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtegreso.Text, out egreso))
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (egreso != -1)
            {
                
                totalegresos = totalegresos + egreso;
                restocaja = caja - totalegresos;
                txtResultado.Text = $"El total de egresos es: {totalegresos}"
                                  + $"\nLo sobrante en caja es: {restocaja}";
                contadorTextBlock.Text = $"Egreso No. {c} añadido";
                c = c + 1;

            }
            if (egreso != -1)
            {
                MessageBox.Show("Ingresar nuevo egreso", "Nuevo egreso", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Final del proceso", "Aviso", MessageBoxButton.OK);
            }
            txtegreso.Clear();
        }
    }
}

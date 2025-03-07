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
    /// Lógica de interacción para Ejercicio28.xaml
    /// </summary>
    public partial class Ejercicio28 : Window
    {
        double nota1, nota2, promedio; 
        public Ejercicio28()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtNota1.Text, out nota1))
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!double.TryParse(txtNota2.Text, out nota2))
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            promedio = (nota1 + nota2) / 2;
            if (nota1 >= 0 && nota1 <= 20 && nota2 >= 0 && nota2 <= 20)
            {
                if (promedio >= 10.5 && promedio <= 20)
                {
                    txtResultado.Text = $"Promedio: " + promedio + "\nAprobado";
                }
                else
                {
                    txtResultado.Text = $"Promedio: " + promedio + "\nDesaprobado";
                }
            }
            else
            {
                MessageBox.Show("Las notas ingresadas no se encuentran en la escala vigesimal(0 - 20)", "Error", MessageBoxButton.OK);
            }
            txtNota1.Clear();
            txtNota2.Clear();
        }
    }
}

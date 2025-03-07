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
    /// Lógica de interacción para Ejercicio9.xaml
    /// </summary>
    public partial class Ejercicio9 : Window
    {

        double promedio, ca, cd, x, nota, acumuladasdesapro, acumuladasapro, acumuladas, promedioaprobadas, promediodesaprobadas;
        string resp;
        public Ejercicio9()
        {
            InitializeComponent();
            x = 1;
            ca = 0;
            cd = 0;
            acumuladas = 0;
            acumuladasapro = 0;
            acumuladasdesapro = 0;
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtNota.Text, out double nota) || nota < 0)
            {
                MessageBox.Show("Por favor, ingresa un número válido para la nota.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return; 
            }

            if (nota <= 10.5)
            {
                cd = cd + 1;
                acumuladasdesapro = acumuladasdesapro + nota;
            }
            else if (nota > 10.5 && nota < 20)
            {
                ca = ca + 1;
                acumuladasapro = acumuladasapro + nota;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una nota entre 0 y 20.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return; 
            }

            acumuladas = acumuladas + nota;
            x = cd + ca;

            if (ca > 0)
                promedioaprobadas = Math.Round(acumuladasapro / ca, 1);
            if (cd > 0)
                promediodesaprobadas = Math.Round(acumuladasdesapro / cd, 1);
            if (x > 0)
                promedio = Math.Round(acumuladas / x, 1);

            txtNota.Clear();

            MessageBox.Show("Nota ingresada correctamente. ¿Deseas ingresar otra nota?", "Confirmación", MessageBoxButton.YesNo);
        }

        private void btnResultado_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = $"Cantidad de notas desaprobadas: {cd}\n" +
                                $"Cantidad de notas aprobadas: {ca}\n" +
                                $"Promedio de las notas aprobadas: {promedioaprobadas}\n" +
                                $"Promedio de las notas desaprobadas: {promediodesaprobadas}\n" +
                               $"Promedio final: {promedio}";
        }
    }
}

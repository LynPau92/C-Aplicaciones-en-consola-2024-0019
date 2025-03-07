using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
    /// Lógica de interacción para Ejercicio18.xaml
    /// </summary>
    public partial class Ejercicio18 : Window
    {
        double coefA, coefB, coefC, disc, s1, s2, s3, raiz1, raiz2, raizima1, raizima2;

        public Ejercicio18()
        {
            InitializeComponent();
        }
        private void btnResultado_Click_1(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtCoeficienteA.Text, out coefA))
            {
                MessageBox.Show("Por favor, ingrese un número.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!double.TryParse(txtCoeficienteB.Text, out coefB))
            {
                MessageBox.Show("Por favor, ingrese un número.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!double.TryParse(txtCoeficienteC.Text, out coefC))
            {
                MessageBox.Show("Por favor, ingrese un número.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            disc = (Math.Pow(coefB, 2) - 4 * coefA * coefC);

            if (coefA == 0)
                txtResultado.Text = "Esta no es una ecuacion cuadratica \n coeficiente 'a' debe ser diferente de 0";
            else
            if (disc > 0)
            {
                s1 = Math.Round((-coefB + Math.Pow(disc, 0.5)) / (2 * coefA), 2);
                s2 = Math.Round((-coefB - Math.Pow(disc, 0.5)) / (2 * coefA), 2);
                txtResultado.Text = $"El discriminante es positivo y se han obtenido \n las siguientes soluciones: \n x1 = {s1} y x2 = {s2}";
            }
            else if (disc == 0)
            {
                s3 = Math.Round((-coefB / (2 * coefA)), 2);
                txtResultado.Text = $"El discriminante es 0 se obtiene la siguiente solucion: s = {s3}";
            }
            else if ((4 * coefA * coefC) > (Math.Pow(coefB, 2)))
            {
                raiz1 = Math.Round(-coefB / (2 * coefA), 3);
                raizima1 = Math.Round(Math.Sqrt((4 * coefA * coefC) - Math.Pow(coefB,
                2)) / (2 * coefA), 4);
                raiz2 = Math.Round(-coefB / (2 * coefA), 3);
                raizima2 = Math.Round(-Math.Sqrt((4 * coefA * coefC) - Math.Pow(coefB,
                2)) / (2 * coefA), 4);
                txtResultado.Text = $"Discriminante es {disc} se obtienen las siguientes \n raices imaginarias: x1 = {raiz1} +i({raizima1}) , \nx2 = {raiz2} +i({raizima2})";
            }
        }
        
               
    }
}

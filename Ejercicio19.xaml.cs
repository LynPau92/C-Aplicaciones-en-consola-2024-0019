using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Lógica de interacción para Ejercicio19.xaml
    /// </summary>
    public partial class Ejercicio19 : Window
    {
        double num1, num2, c, suma, resta, multiplicacion, division;

        public Ejercicio19()
        {
            InitializeComponent();
            c = 0;
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (c <= 9)
            {
                if (!double.TryParse(txtNum1.Text, out num1))
                {
                    MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (!double.TryParse(txtNum2.Text, out num2) || num2 == 0)
                {
                    MessageBox.Show("Por favor, ingrese un número válido o diferente de 0.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                suma = num1 + num2;
                resta = num1 - num2;
                multiplicacion = num1 * num2;
                division = Math.Round(num1 / num2, 2);
                c = c + 1;

                txtResultado.Text = $"La suma es: " + suma
                                    + "\nLa resta es : " + resta
                                    + "\nLa multiplicación es : " + multiplicacion
                                    + "\nLa divisón es : " + division;
                contadorTextBlock.Text = $"Proceso No. {c} finalizado";
                MessageBox.Show("Ingresar nuevos números", "Nuevo ingreso", MessageBoxButton.OK);

                txtNum1.Clear();
                txtNum2.Clear();

            }
            else
            {
                txtResultado.Text = "Fin del proceso";
            }
        }
    }
}

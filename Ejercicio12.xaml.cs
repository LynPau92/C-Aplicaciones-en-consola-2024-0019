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
    /// Lógica de interacción para Ejercicio12.xaml
    /// </summary>
    public partial class Ejercicio12 : Window
    {
        int x, numero, positivos, negativos, pares, impares;

        public Ejercicio12()
        {
            InitializeComponent();
            pares = 0;
            impares = 0;
            positivos = 0;
            negativos = 0;
            x = 0; 
        }
        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtIngresarNumero.Text, out numero))
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (int.TryParse(txtIngresarNumero.Text, out numero))
            {

                x++;


                if (numero % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                if (numero > 0)
                {
                    positivos++;
                }
                else if (numero < 0)
                {
                    negativos++;
                }


                txtIngresarNumero.Clear();

                contadorTextBlock.Text = $"Número {x} ingresado correctamente. Te quedan {50 - x} números por ingresar.";

                
                if (x >= 50)
                {
                    btnIngresarNumero.IsEnabled = false;
                    MessageBox.Show("Has ingresado 50 números. Ahora puedes ver los resultados.", "Máximo alcanzado", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButton.OK);
            }
        }

        private void btnResultado_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = $"Cantidad de números pares: {pares}\n" +
                                $"Cantidad de números impares: {impares}\n" +
                                $"Cantidad de números negativos: {negativos}\n" +
                                $"Cantidad de números positivos: {positivos}";
        }

    }
}

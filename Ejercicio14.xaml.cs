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
    /// Lógica de interacción para Ejercicio14.xaml
    /// </summary>
    public partial class Ejercicio14 : Window
    {
        double suma, media, x, numero;

       public Ejercicio14()
        {
            InitializeComponent();
            suma = 0;
            x = 1;
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            //if (!double.TryParse(txtIngresarNumero.Text, out numero))
            //{
            //    MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}

            if (double.TryParse(txtIngresarNumero.Text, out numero))
            {

               suma = suma + numero;


                txtIngresarNumero.Clear();

                contadorTextBlock.Text = $"Número {x} ingresado correctamente. Te quedan {100 - x} números por ingresar.";
                x++;

                if (x > 100)
                {
                    btnIngresarNumero.IsEnabled = false;
                    MessageBox.Show("Has ingresado 100 números. Ahora puedes ver la media.", "Máximo alcanzado", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButton.OK);
            }
            media = Math.Round(suma / 100, 2);
        }

        private void btnResultado_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = ("La media de los 100 numero ingresados es: " + media);
        }

    }
}

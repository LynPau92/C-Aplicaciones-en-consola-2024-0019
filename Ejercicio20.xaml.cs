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
    /// Lógica de interacción para Ejercicio20.xaml
    /// </summary>
    public partial class Ejercicio20 : Window
    {
        double numero, c, cubo, raizcuadrada;

        public Ejercicio20()
        {
            InitializeComponent();
            c = 0;
        }
        
        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtNum.Text, out numero))
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (numero != 0)
            {
                cubo = Math.Pow(numero, 3);
                raizcuadrada = Math.Round(Math.Pow(numero, 0.5), 2);
                c = c + 1;

                txtResultado.Text = $"El cubo es: " + cubo
                                    + "\nLa raiz cuadrada es: " + raizcuadrada;
                contadorTextBlock.Text = $"Proceso No. {c} completado";
                MessageBox.Show("Ingresa un nuevo número", "Nuevo ingreso", MessageBoxButton.OK);

                txtNum.Clear();
            } 
            else
            {
                txtResultado.Text = "Final del proceso";
            }
        }

        

    }
}

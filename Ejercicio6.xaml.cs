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
    /// Lógica de interacción para Ejercicio6.xaml
    /// </summary>
    public partial class Ejercicio6 : Window
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, RoutedEventArgs e)
        {
            int x, numero, suma;

            if (!int.TryParse(txtNumero.Text, out numero) || numero < 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            suma = 0;
            StringBuilder resultado = new StringBuilder();

           
            for (x = 1; x <= numero; x++)
            {
                suma += x;
                resultado.AppendLine($"n{x}: {x}");
            }

            resultado.AppendLine($"\nLa suma de la serie es: {suma}");
            txtResultado.Text = resultado.ToString();
        }
    }
}

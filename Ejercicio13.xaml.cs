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
    /// Lógica de interacción para Ejercicio13.xaml
    /// </summary>
    public partial class Ejercicio13 : Window
    {
        public Ejercicio13()
        {
            InitializeComponent();
        }

        private void btnFactorial_Click(object sender, RoutedEventArgs e)
        {
            int numero, factorial, i;
            int.TryParse(txtNumero.Text, out numero);

            if (!int.TryParse(txtNumero.Text, out numero))
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if ( numero < 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            factorial = 1;
            for (i = 1; i <= numero; i++)
                factorial = factorial * i;

            StringBuilder resultado = new StringBuilder();
            resultado.Append("Factorial: \n");
            resultado.Append(numero + "!" + "= " + factorial);
            txtResultado.Text = resultado.ToString();
        }
    }
}

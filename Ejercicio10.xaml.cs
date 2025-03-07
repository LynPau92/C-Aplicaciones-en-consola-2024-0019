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
    /// Lógica de interacción para Ejercicio10.xaml
    /// </summary>
    public partial class Ejercicio10 : Window
    {
        public Ejercicio10()
        {
            InitializeComponent();
        }

        private void btnSumaDigitos_Click(object sender, RoutedEventArgs e)
        {
            int numero, suma = 0, residuo;
            
            if (!int.TryParse(txtnumero.Text, out numero))
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            do
            {
                residuo = numero % 10;
                suma = suma + residuo;
                numero = (numero - (numero % 10)) / 10;
            }
            while (numero != 0);
            
            txtResultado.Text = $"La suma es de los digitos es: {suma}";
            
        }
    }
}

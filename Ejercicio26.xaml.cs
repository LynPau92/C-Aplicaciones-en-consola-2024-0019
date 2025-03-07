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
    /// Lógica de interacción para Ejercicio26.xaml
    /// </summary>
    public partial class Ejercicio26 : Window
    {
        int numero, suma, x; 
        public Ejercicio26()
        {
            InitializeComponent();
            suma = 0;
        }

        private void btnSumar_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtnumero.Text, out numero))
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (numero < 8)
            {
                txtResultado.Text = "Error el numero ingresado es menor a 8";
}
            else
            {
                for (x = 8; x <= numero; x = x + 1)
                {
                    suma = suma + x;
                }
                txtResultado.Text = $"La suma de la serie de rango 8 hasta { numero}, con un incremento de 1 es: { suma}";
            }
        }
    }
}

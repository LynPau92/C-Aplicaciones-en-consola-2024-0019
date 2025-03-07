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
    /// Lógica de interacción para Ejercicio15.xaml
    /// </summary>
    public partial class Ejercicio15 : Window
    {
        public Ejercicio15()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, RoutedEventArgs e)
        {
            int suma, producto, x;
            suma = 0;
            producto = 1;
            for (x = 20; x <= 30; x = x + 2)
            {
                suma = suma + x;
                producto = producto * x;
            }

            StringBuilder resultado = new StringBuilder();
            resultado.Append("Rango: numeros pares del 20 al 30\n");
            resultado.Append("\nLa suma es: " + suma);
            resultado.Append("\nEl producto es: " + producto);
            txtResultado.Text = resultado.ToString();
        }
    }
}

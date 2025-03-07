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
    /// Lógica de interacción para Ejercicio23.xaml
    /// </summary>
    public partial class Ejercicio23 : Window
    {
        double catetoa, catetob, hipotenusa;

        public Ejercicio23()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtcateto1.Text, out catetoa))
            {
                MessageBox.Show("Por favor, ingrese un número.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!double.TryParse(txtcateto2.Text, out catetob))
            {
                MessageBox.Show("Por favor, ingrese un número.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            hipotenusa = Math.Round(Math.Pow(Math.Pow(catetoa, 2) + Math.Pow(catetob, 2), 0.5), 2);
            txtResultado.Text = $"La hipotenusa del triángulo es: " + hipotenusa;
        }

        

    }
}

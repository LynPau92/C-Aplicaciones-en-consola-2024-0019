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
    /// Lógica de interacción para Ejercicio24.xaml
    /// </summary>
    public partial class Ejercicio24 : Window
    {
        double pi, radio, area, volumen, longitud;
        public Ejercicio24()
        {
            InitializeComponent();
            pi = 3.14;
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtradio.Text, out radio) || radio < 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            longitud = 2 * pi * radio;
            area = Math.Round(pi * Math.Pow(radio, 2), 2);
            volumen = Math.Round((4 / 3) * pi * Math.Pow(radio, 3), 2);

            txtResultado.Text = $"La longitud de la circunferencia es: " + longitud
                                + "\nEl área de la circunferencia es: " + area
                                + "\nEl volumen de la circunferencia es: " + volumen; 

        }
    }
}

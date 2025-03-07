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
    /// Lógica de interacción para Ejercicio22.xaml
    /// </summary>
    public partial class Ejercicio22 : Window
    {
        double ladoa, ladob, ladoc, sm, areatriangulo;

        public Ejercicio22()
        {
            InitializeComponent();
        }
        private void btnResultado_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtladoA.Text, out ladoa))
            {
                MessageBox.Show("Por favor, ingrese un número.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!double.TryParse(txtladoB.Text, out ladob))
            {
                MessageBox.Show("Por favor, ingrese un número.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!double.TryParse(txtladoC.Text, out ladoc))
            {
                MessageBox.Show("Por favor, ingrese un número.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            sm = (ladoa + ladob + ladoc) / 2;
            areatriangulo = Math.Round(Math.Pow(sm * (sm - ladoa) * sm * (sm - ladob) * sm * (sm - ladoc), 0.5), 2);
            txtResultado.Text = $"El área del triángulo es:  {areatriangulo}";
        }

    }
}

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
    /// Lógica de interacción para Ejercicio17.xaml
    /// </summary>
    public partial class Ejercicio17 : Window
    {
        double numero, pf;
        public Ejercicio17()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtIngresarNumero.Text, out numero))
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
           
            pf = Math.Truncate(numero);
            if (numero == pf)
                txtResultado.Text =("No tiene parte fraccionaria");
            else
                txtResultado.Text = ("Tiene parte fraccionaria");
        }
    }
}

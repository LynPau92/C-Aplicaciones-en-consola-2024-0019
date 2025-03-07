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
    /// Lógica de interacción para Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnDescuento_Click(object sender, RoutedEventArgs e)
        {
            double sueldo, sueldoneto, descuento;

            if (!double.TryParse(txtSueldo.Text, out sueldo) || sueldo < 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido para el sueldo.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (sueldo <= 1000 && sueldo >= 0)
            {
                descuento = sueldo * 0.1;
                sueldoneto = sueldo - descuento;
                txtResultado.Text = $"El descuento es: $ {descuento} y el sueldo neto es: $ {sueldoneto}";
            }
            else if (sueldo <= 2000 && sueldo >= 0)
            {
                descuento = (sueldo - 1000) * 0.05 + (1000 * 0.1);
                sueldoneto = sueldo - descuento;
                txtResultado.Text = $"El descuento es: $ {descuento} y el sueldo neto es: $ {sueldoneto}";
            }
            else if (sueldo > 2000)
            {
                descuento = (sueldo - 2000) * 0.03 + (1000 * 0.05) + (1000 * 0.10);
                sueldoneto = sueldo - descuento;
                txtResultado.Text = $"El descuento es: $ {descuento} y el sueldo neto es: $ {sueldoneto}";
            }
            else
                txtResultado.Text = "Error el sueldo no puede ser negativo";
        }
    }
}

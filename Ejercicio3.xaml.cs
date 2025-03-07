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
    /// Lógica de interacción para Ejercicio3.xaml
    /// </summary>
    public partial class Ejercicio3 : Window
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnDescuento_Click(object sender, RoutedEventArgs e)
        {
            double monto, descuento;
            if (!double.TryParse(txtMonto.Text, out monto) || monto < 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido para el monto.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (monto > 100)
            {
                descuento = monto * 0.1;
                txtResultado.Text = $"El monto ${monto} tiene un descuento de: {descuento}%";
            }
            else if (monto <= 100 && monto > 0)
            {
                descuento = monto * 0.2;
                txtResultado.Text = $"El monto ${monto} tiene un descuento de: {descuento}%";
            }
            else
            {
                txtResultado.Text = "Error, el monto no puede ser negativo";
            }
            
        }
    }
}

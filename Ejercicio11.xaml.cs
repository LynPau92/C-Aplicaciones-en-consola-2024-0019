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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppsConsola
{
    /// <summary>
    /// Lógica de interacción para Ejercicio11.xaml
    /// </summary>
    public partial class Ejercicio11 : Window
    {
        public Ejercicio11()
        {
            InitializeComponent();
        }

        private void btnFactura_Click(object sender, RoutedEventArgs e)
        {
            double precio, numeroarticulos, precioventa, descuento, preciobruto,iva, totalpagar;

            if (!double.TryParse(txtPrecio.Text, out precio) || precio < 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!double.TryParse(txtArticulos.Text, out numeroarticulos) || numeroarticulos < 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            precioventa = precio * numeroarticulos;
            iva = Math.Round(precioventa * 0.15, 2);
            preciobruto = precioventa + iva;

            StringBuilder resultado = new StringBuilder();

            if (preciobruto >= 50)
            {
                descuento = Math.Round((preciobruto * 5) / 100, 2);
            }
            else
            {
                descuento = 0;
            }
            totalpagar = preciobruto - descuento;
            resultado.AppendLine($"\n***Datos de la factura***");
            resultado.AppendLine($"\nPrecio de venta : $ " + precioventa);
            resultado.AppendLine($"\nImpuesto sobre el valor añadido (IVA) es: $ " + iva);
            resultado.AppendLine($"\nPrecio bruto es : $ " + preciobruto);
            resultado.AppendLine($"\nDescuento es : $ " + descuento);
            resultado.AppendLine($"\nTotal a pagar: $ " + totalpagar);            
            txtResultado.Text = resultado.ToString();
        }
    }
}

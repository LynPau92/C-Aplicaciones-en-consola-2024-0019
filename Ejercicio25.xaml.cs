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
    /// Lógica de interacción para Ejercicio25.xaml
    /// </summary>
    public partial class Ejercicio25 : Window
    {
        double consumo, descuento, total, c;

        public Ejercicio25()
        {
            InitializeComponent();
            c = 1;
            total = 0;
        }
        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtconsumo.Text, out consumo) || consumo < 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (c <= 130)
            {
                if (consumo > 130)
                {
                    descuento = consumo * 0.15;
                }
                else
                {
                    descuento = 0;
                }
                consumo = consumo - descuento;
                total = total + consumo;
                contadorTextBlock.Text = $"Consumo No. {c} añadido" + "\nEl total de los consumos es: " + total;

                if (consumo <= 130)
                {
                    MessageBox.Show("Ingresar nuevos consumos", "Nuevo consumo", MessageBoxButton.OK);
                }
                c = c + 1;
                txtconsumo.Clear();
            }
            else 
            {
                MessageBox.Show("Ha excedido el número de consumos", "Aviso", MessageBoxButton.OK);
                txtResultado.Text = $"Fin del proceso";
            }
                
        }

        
    }
}

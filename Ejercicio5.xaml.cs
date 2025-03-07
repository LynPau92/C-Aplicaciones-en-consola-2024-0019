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
    /// Lógica de interacción para Ejercicio5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btnMinutos_Click(object sender, RoutedEventArgs e)
        {
            int tiempo, dias, horas, minutos, x;
            
            if (!int.TryParse(txtTiempo.Text, out tiempo) || tiempo < 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (tiempo >= 0)
            {
                dias = (tiempo - (tiempo % 60)) / 1440;
                x = tiempo % 1440;
                horas = (x - (x % 60)) / 60;
                minutos = x % 60;
                txtResultado.Text = $"Tiempo equivale a: {dias} dias con {horas} horas y {minutos} minutos";
            }
            else
            {
                txtResultado.Text = "El tiempo no puede ser negativo";
            }
        }
    }
}

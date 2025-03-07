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
    /// Lógica de interacción para Ejercicio7.xaml
    /// </summary>
    public partial class Ejercicio7 : Window
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        public class Trabajador
        {
            public int Numero { get; set; }
            public double HorasTrabajadas { get; set; }
            public double Tarifa { get; set; }
            public double Salario => HorasTrabajadas * Tarifa;
        }

        private List<Trabajador> trabajadores = new List<Trabajador>();

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            trabajadores.Clear();

            if (int.TryParse(txtNumeroTrabajadores.Text, out int numTrabajadores) && numTrabajadores > 0)
            {
                for (int i = 1; i <= numTrabajadores; i++)
                {
                    trabajadores.Add(new Trabajador { Numero = i });
                }
                dataGridTrabajadores.ItemsSource = null;
                dataGridTrabajadores.ItemsSource = trabajadores;
            }
            else
            {
                MessageBox.Show("Ingrese un número válido de trabajadores.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnSumaSalarios_Click(object sender, RoutedEventArgs e)
        {
            double suma = 0;
            foreach (var trabajador in trabajadores)
            {
                suma += trabajador.Salario;
            }
            txtResultado.Text = $"Total Salarios: {suma:C}";
        }
    }
}

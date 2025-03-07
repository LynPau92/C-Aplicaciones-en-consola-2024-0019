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
    /// Lógica de interacción para Ejercicio4.xaml
    /// </summary>
    public partial class Ejercicio4 : Window
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }
        private void btnSegundos_Click(object sender, RoutedEventArgs e)
        {
            int tiemposegundos, minutos, segundosrestantes;
                      
            if (!int.TryParse(txtSegundos.Text, out tiemposegundos) || tiemposegundos < 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (tiemposegundos < 60 && tiemposegundos > 0)
            {
                segundosrestantes = 60 - tiemposegundos;
                txtResultado.Text = $"Le falta {segundosrestantes} segundos para convertirse en minuto";
            }
            else if (tiemposegundos >= 60)
            {
                minutos = (tiemposegundos - (tiemposegundos % 60)) / 60;
                segundosrestantes = tiemposegundos % 60;
                txtResultado.Text = $"Equivale a {minutos} minutos y le faltan {segundosrestantes} segundos para convertirse en minuto";
            }
            else
            {
                txtResultado.Text= "La cantidad de segundos debe ser un numero positivo";
            }
           
        }
    }
}

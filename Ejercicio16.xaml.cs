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
    /// Lógica de interacción para Ejercicio16.xaml
    /// </summary>
    public partial class Ejercicio16 : Window
    {
        string caracter;
        public Ejercicio16()
        {
            InitializeComponent();
            
        }

        private void btnVerificar_Click(object sender, RoutedEventArgs e)
        {
            caracter = txtcaracter.Text;
            if (caracter.Equals("a") || (caracter.Equals("e")) || (caracter.Equals("i")) || (caracter.Equals("o")) || (caracter.Equals("u")))
            {
                txtcaracter.Text = caracter;
                txtResultado.Text = ($"La primera vocal ingresada fue: " + caracter);
            }
            else
            {
                MessageBox.Show("No es una vocal.", "Aviso", MessageBoxButton.OK);
                return;
            }
        }
    }
    
}

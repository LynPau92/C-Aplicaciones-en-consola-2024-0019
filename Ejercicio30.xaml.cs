using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Lógica de interacción para Ejercicio30.xaml
    /// </summary>
    public partial class Ejercicio30 : Window
    {
        List<string> ClaveFiesta = new List<string> 
        { "tienes", 
            "que ser", 
            "invitado", 
            "para", 
            "ingresar" 
        };

        public Ejercicio30()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, RoutedEventArgs e)
        {
            List<string> entradasUsuario = new List<string>
        {
            txtC1.Text.Trim().ToLower(),
            txtC2.Text.Trim().ToLower(),
            txtC3.Text.Trim().ToLower(),
            txtC4.Text.Trim().ToLower(),
            txtC5.Text.Trim().ToLower()
        };

            for (int i = 0; i < ClaveFiesta.Count; i++)
            {
                if (entradasUsuario[i] != ClaveFiesta[i])
                {
                    Error();
                    return;
                }
            }
            txtRespuesta.Text = "BIENVENIDO A LA FIESTA";
        }
        public void Error()
        {
            MessageBox.Show("TE EQUIVOCASTE DE FIESTA", "Error", MessageBoxButton.OK);
        }
    
}
}

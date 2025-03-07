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
    /// Lógica de interacción para Ejercicio29.xaml
    /// </summary>
    public partial class Ejercicio29 : Window
    {
        public Dictionary<string, int> deportesCount;
        public int contadorAlumnos; 
        public Ejercicio29()
        {
            InitializeComponent();
            deportesCount = new Dictionary<string, int>
            {
                { "voley", 0 },
                { "futbol", 0 },
                { "basquet", 0 },
                { "ajedrez", 0 }
            };
            contadorAlumnos = 1;
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            string deporte = txtDeporte.Text.ToLower(); 

            if (contadorAlumnos <= 10)
            {
                if (deportesCount.ContainsKey(deporte))
                {
                    deportesCount[deporte]++;
                    contadorTextBlock.Text = $"Deporte del alumno No. {contadorAlumnos} añadido.";
                    contadorAlumnos++;
                }
                else
                {
                    MessageBox.Show("Deporte no válido. Ingrese uno de los siguientes: voley, futbol, basquet, ajedrez.", "Error", MessageBoxButton.OK);
                }
            }
            else
            {
                MostrarResultados();
                MessageBox.Show("Cantidad de alumnos completos", "Aviso", MessageBoxButton.OK);
            }
        }


        private void MostrarResultados()
        {
            txtResultado.Text = $"Cantidad de voley: {deportesCount["voley"]}\n" +
                                $"Cantidad de futbol: {deportesCount["futbol"]}\n" +
                                $"Cantidad de basquet: {deportesCount["basquet"]}\n" +
                                $"Cantidad de ajedrez: {deportesCount["ajedrez"]}";
        }
    }
    
}

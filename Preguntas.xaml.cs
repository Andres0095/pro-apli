using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JuegoInteractivo
{
    /// <summary>
    /// Lógica de interacción para Preguntas.xaml
    /// </summary>
    public partial class Preguntas : Window
    {
        public Preguntas()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int puntaje = 0;
            if (rbn1.IsChecked == true)
            {
                puntaje += 20;
            }

            if (rbn2.IsChecked == true)
            {
                puntaje += 20;
            }

            if (rbn3.IsChecked == true)
            {
                puntaje += 20;
            }

            if (rbn4.IsChecked == true)
            {
                puntaje += 20;
            }

            // ToUpper() converte a mayusculas
            if (rt5.Text.ToUpper().Equals("SINCELEJO"))
            {
                puntaje += 10;
            }

            if (rt51.Text.ToUpper().Equals("CARIBE"))
            {
                puntaje += 10;
            }

            double total = (puntaje);

            if (total <= 90)
            {
                MessageBox.Show("Puntuacion: " + total + "/100 vuelve a intentarlo, Puedes hacerlo mejor!");
                Preguntas siguiente = new Preguntas();
                siguiente.Show();
            }


            if (total == 100)
            {
                MessageBox.Show("Puntuacion: " + total + "/100 Excelente!!!");
            }


            Close();
        }
    }
}

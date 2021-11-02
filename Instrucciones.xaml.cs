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
    /// Lógica de interacción para Instrucciones.xaml
    /// </summary>
    public partial class Instrucciones : Window
    {
        public Instrucciones()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            Preguntas siguiente = new Preguntas();
            siguiente.Show();
            Close();
        }
    }
}

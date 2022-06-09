using AppHibrida_MGI_SHDB.GestionClientes;
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


namespace AppHibrida_MGI_SHDB
{
    /// <summary>
    /// Lógica de interacción para GestionClientesPc.xaml
    /// </summary>
    public partial class GestionClientesPc : Window
    {
        public GestionClientesPc()
        {
            InitializeComponent();
        }

        private void Añadir_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Añadir_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AñadirCliente ventana = new AñadirCliente();
            ventana.ShowDialog();
        }

        private void Modificar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Modificar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Parguela");
        }

        private void Eliminar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Eliminar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Parguela");
        }

        private void Guardar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Guardar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Parguela");
        }


    }
}

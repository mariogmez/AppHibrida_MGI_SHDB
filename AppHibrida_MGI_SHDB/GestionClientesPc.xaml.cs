using AppHibrida_MGI_SHDB.GestionClientes;
using AppHibrida_MGI_SHDB.ViewModel;
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
        private CollectionViewModel coleccionVM;
        public GestionClientesPc()
        {
            InitializeComponent();
            coleccionVM = (CollectionViewModel)this.Resources["ColeccionVM"];
        }

        private void Aniadir_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Aniadir_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AñadirCliente ventana = new AñadirCliente(coleccionVM);
            ventana.ShowDialog();
        }


        private void Modificar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Parguela Modifica");
        }

        private void Selecionado_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
            /*       if (listViewClientes.SelectedIndex >= 0) 
                   {
                       e.CanExecute = true;
                   } else
                   {
                       e.CanExecute = false;
                   }
            */
        }

        private void Eliminar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Parguela Elimina");
        }

        private void Guardar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Guardar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Parguela Guarda");
        }


    }
}

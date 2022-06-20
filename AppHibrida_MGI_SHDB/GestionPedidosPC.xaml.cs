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
    /// Lógica de interacción para GestionPedidosPC.xaml
    /// </summary>
    public partial class GestionPedidosPC : Window
    {
        CollectionViewModel coleccionVM;

        public GestionPedidosPC(CollectionViewModel colectionVM)
        {
            InitializeComponent();
            coleccionVM = colectionVM;
            cargarClientes();
        }

        private void cargarClientes()
        {
            cmbClientes.Items.Clear();
            foreach (var clie in coleccionVM.ListaClientes)
            {
                cmbClientes.Items.Add(clie.nombre);
            }
            cmbClientes.SelectedIndex = 0;
        }

        private void Add_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (cmbClientes.SelectedIndex >= 0)
            {
                e.CanExecute = true;
            }
        }

        private void Seleccionado_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            /*            if (listViewPedidos.SelectedIndex >= 0)
                        {
                            e.CanExecute = true;
                        }
                        else
                        {
                            e.CanExecute = false;
                        }*/
            e.CanExecute = true;
        }

        private void Add_Executed(object sender, ExecutedRoutedEventArgs e)
        {

            addPedido ventana = new addPedido();
            ventana.ShowDialog();
        }


        private void Modificar_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void Eliminar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
     //       coleccionVM.ListaPedidos.Remove((pedidos)lstPedidos.SelectedItem);
        }

        public void Guardar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        public void Guardar_Executed(object sender, ExecutedRoutedEventArgs e)
        {

           // coleccionVM.guardarDatos();
        }


    }
}

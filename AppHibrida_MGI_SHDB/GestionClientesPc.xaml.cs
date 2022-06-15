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

        public void Aniadir_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        public void Aniadir_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            AñadirCliente ventana = new AñadirCliente(coleccionVM, this);
            ventana.ShowDialog();
        }


        public void Modificar_Executed(object sender, ExecutedRoutedEventArgs e)
        {

                        
        }

        public void Selecionado_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (lstClientes != null && lstClientes.SelectedIndex >= 0) 
            {
                e.CanExecute = true;
            } else
            {
                e.CanExecute = false;
            }
            
        }

        public void Eliminar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            coleccionVM.objBD.clientes.Remove((clientes)lstClientes.SelectedItem);
            coleccionVM.ListaClientes.Remove((clientes)lstClientes.SelectedItem);
        }

        public void Guardar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        public void Guardar_Executed(object sender, ExecutedRoutedEventArgs e)
        {

            coleccionVM.guardarDatos();
        }


    }
}

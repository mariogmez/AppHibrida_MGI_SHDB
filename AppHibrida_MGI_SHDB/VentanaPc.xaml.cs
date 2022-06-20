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
    /// Lógica de interacción para VentanaPc.xaml
    /// </summary>


    public partial class VentanaPc : Window
    {
        private CollectionViewModel coleccionVM;

        public VentanaPc()
        {
            InitializeComponent();
            coleccionVM = (CollectionViewModel)this.Resources["ColeccionVM"];
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            GestionClientesPc venClie = new GestionClientesPc(coleccionVM);
            venClie.ShowDialog();
        }

        private void btnPedidos_Click(object sender, RoutedEventArgs e)
        {
            GestionPedidosPC venPed = new GestionPedidosPC(coleccionVM);
            venPed.ShowDialog();

        }
    }
}

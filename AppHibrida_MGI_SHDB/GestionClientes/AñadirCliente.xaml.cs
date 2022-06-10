using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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

namespace AppHibrida_MGI_SHDB.GestionClientes
{
    /// <summary>
    /// Lógica de interacción para AñadirCliente.xaml
    /// </summary>
    public partial class AñadirCliente : Window
    {
        CollectionViewModel coleccionVM;
        public AñadirCliente(CollectionViewModel colectionVM)
        {
            InitializeComponent();
            this.coleccionVM = colectionVM;
            cargarProvincias();
        }

        private void cargarProvincias()
        {
            this.cbxProvincia.Items.Clear();
            foreach (var provi in coleccionVM.ListaProvincias)
            {
                cbxProvincia.Items.Add(provi.nombre_provincia);
            }
            cbxProvincia.SelectedIndex = 0;
        }
    }
}
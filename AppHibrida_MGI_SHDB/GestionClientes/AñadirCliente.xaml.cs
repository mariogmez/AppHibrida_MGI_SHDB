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


        private void Aceptar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (comprobarTXT())
            {
                e.CanExecute = true;
            } else
            {
                e.CanExecute = false;
            }
        }

        private void Aceptar_Executed(object sender, ExecutedRoutedEventArgs e)
        {

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


        private Boolean comprobarTXT()
        {
            Boolean txtRellenado = false;

            if (!txtNombre.Text.Trim().Equals(""))
            {
                if (!txtApellidos.Text.Trim().Equals(""))
                {
                    if (!txtDomicilio.Text.Trim().Equals(""))
                    {
                        if (!txtEmail.Text.Trim().Equals("")) 
                        {
                            if (!txtLocalidad.Text.Trim().Equals(""))
                            {
                                txtRellenado = true;
                            }
                            else MessageBox.Show("Tienes que rellenar el campo localidad");
                        }
                        else MessageBox.Show("Tienes que rellenar el campo Email");
                    }
                    else MessageBox.Show("Tienes que rellenar el campo Domicilio");
                }
                else MessageBox.Show("Tienes que rellenar el campo Apellidos");
            }
            else MessageBox.Show("Tienes que rellenar el campo Nombre");


            return txtRellenado;
        }

    }
}
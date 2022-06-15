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
        GestionClientesPc gestor;
        public AñadirCliente(CollectionViewModel colectionVM, GestionClientesPc gestionClientesPc)
        {
            InitializeComponent();
            coleccionVM = colectionVM;
            cargarProvincias();
            gestor = gestionClientesPc;
            
        }


        private void Aceptar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;

        }

        private void Aceptar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (comprobarTXT())
            {
                clientes cliente = new clientes();
                cliente.dni = txtDni.Text.ToString();
                cliente.nombre = txtNombre.Text.ToString();
                cliente.apellidos = txtApellidos.Text.ToString();
                cliente.email = txtEmail.Text.ToString();
                cliente.domicilio = txtDomicilio.Text.ToString();
                cliente.localidad = txtLocalidad.Text.ToString();
                cliente.provincia = cbxProvincia.SelectedIndex;

                cliente.provincias = coleccionVM.ListaProvincias[cbxProvincia.SelectedIndex];
                coleccionVM.objBD.clientes.Add(cliente);
                coleccionVM.ListaClientes.Add(cliente);
                
                
                MessageBox.Show("Fresquito");
                this.Close();
            }

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

            if (!txtDni.Text.Trim().Equals(""))
            {
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
            } 
            else MessageBox.Show("Tienes que rellenar el campo Dni");




            return txtRellenado;
        }

    }
}
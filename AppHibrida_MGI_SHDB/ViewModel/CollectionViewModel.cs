using AppHibrida_MGI_SHDB.Colecciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppHibrida_MGI_SHDB.ViewModel
{
    public class CollectionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        
         // CONECTAMOS CON LA BBDD
         
        private entregasEntities _objBD = new entregasEntities();
        public entregasEntities objBD
        {
            get { return _objBD; }
            set
            {
                _objBD = value;
                notificarPropertyChanged();
            }
        }

        public void guardarDatos()
        {
            objBD.SaveChanges();
            System.Windows.MessageBox.Show("Base de Datos actualizada correctamente...", "BBDD actualizada");
        }

        public CollectionViewModel()
        {
            cargarDatos();
        }

        
        //  CARGA LOS DATOS DE LA BBDD
         
        private void cargarDatos()
        {
            //Cargamos las provincias
            ListaProvincias.Clear();
            
            var qProvincias = from prov in objBD.provincias select prov;
            foreach (var provi in qProvincias.ToList())
            {
                ListaProvincias.Add(provi);
            }


            ListaClientes.Clear();
            var qClientes = from cli in objBD.clientes orderby cli.apellidos, cli.nombre select cli;
            foreach (var client in qClientes.ToList())
            {
                ListaClientes.Add(client);
            }


            ListaPedidos.Clear();
            var qPedidos = from ped in objBD.pedidos select ped;
            foreach (var pedi in qPedidos.ToList())
            {
                ListaPedidos.Add(pedi);
            }



        }

        public void pedidosDeCliente (String dni)
        {
            ListaPedidos.Clear();
            var qPedidos = from ped in objBD.pedidos where ped.cliente == dni select ped;
            foreach (var pedi in qPedidos.ToList())
            {
                ListaPedidos.Add(pedi);
            }

        }


        //Carga los datos de provincia
        private ProvinciaCollection _listaProvincias = new ProvinciaCollection();
        public ProvinciaCollection ListaProvincias
        {
            get { return _listaProvincias; }
            set
            {
                _listaProvincias = value;
                notificarPropertyChanged();
            }
        }

    
            
        private ClienteCollection _listaClientes = new ClienteCollection();

        public ClienteCollection ListaClientes
        {
            get { return _listaClientes; }
            set
            {
                _listaClientes = value;
                notificarPropertyChanged();
            }
        }


        
        private PedidosCollection _listaPedidos = new PedidosCollection();
        public PedidosCollection ListaPedidos
        {
            get { return _listaPedidos; }
            set
            {
                _listaPedidos = value;
                notificarPropertyChanged();
            }
        }



        private void notificarPropertyChanged([CallerMemberName] string propertyName = "") {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }


}

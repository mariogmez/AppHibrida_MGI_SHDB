using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppHibrida_MGI_SHDB
{
    class Comandos
    {

        public static readonly RoutedUICommand Salir = new RoutedUICommand(
            "Cerrar la aplicación",
            "Salir",
            typeof(MainWindow),
            new InputGestureCollection()
            {
                        new KeyGesture(Key.Escape)
            }
        );

        //Comandos ventana Gestión de Clientes vista ordenador
        public static readonly RoutedUICommand Añadir = new RoutedUICommand(
           "Accion cuando se añade algo",
           "Añadir",
           typeof(MainWindow),
           new InputGestureCollection()
           {
                new KeyGesture(Key.F1)
           }
        );

        //Comandos ventana Gestión de Clientes vista ordenador
        public static readonly RoutedUICommand Modificar = new RoutedUICommand(
           "Accion cuando se añade algo",
           "Añadir",
           typeof(MainWindow),
           new InputGestureCollection()
           {
                new KeyGesture(Key.F1)
           }
        );

        //Comandos ventana Gestión de Clientes vista ordenador
        public static readonly RoutedUICommand Eliminar = new RoutedUICommand(
           "Accion cuando se añade algo",
           "Añadir",
           typeof(MainWindow),
           new InputGestureCollection()
           {
                new KeyGesture(Key.F1)
           }
        );

        //Comandos ventana Gestión de Clientes vista ordenador
        public static readonly RoutedUICommand Guardar = new RoutedUICommand(
           "Accion cuando se añade algo",
           "Añadir",
           typeof(MainWindow),
           new InputGestureCollection()
           {
                new KeyGesture(Key.F1)
           }
        );
        /*
        public static readonly RoutedUICommand AddCliente = new RoutedUICommand(
            "Cerrar la aplicación",
            "Salir",
            typeof(MainWindow),
            new InputGestureCollection()
            {
                                new KeyGesture(Key.Escape)
            }
        );*/


    }
}


//         <CommandBinding Command="local:Comandos.AddCliente" Executed="AddCliente_Executed" CanExecute="AddCliente_CanExecute"/>


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


    }
}

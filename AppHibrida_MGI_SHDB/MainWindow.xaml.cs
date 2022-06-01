﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppHibrida_MGI_SHDB
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTactil_Click(object sender, RoutedEventArgs e)
        {
            VentanaTactil venTactil = new VentanaTactil();
            venTactil.ShowDialog();

        }

        private void btn_ordenador_Click(object sender, RoutedEventArgs e)
        {
            VentanaPc venPc = new VentanaPc();
            venPc.ShowDialog();
        }

        private void Salir_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void Salir_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }


    }
}

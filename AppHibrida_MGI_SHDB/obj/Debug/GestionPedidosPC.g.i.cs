﻿#pragma checksum "..\..\GestionPedidosPC.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "41BD621E3F274A32E68412CF61BB4EEA380214F1DF32FC8593AAFA5B400AC70B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using AppHibrida_MGI_SHDB;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AppHibrida_MGI_SHDB {
    
    
    /// <summary>
    /// GestionPedidosPC
    /// </summary>
    public partial class GestionPedidosPC : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\GestionPedidosPC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbClientes;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\GestionPedidosPC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddPedido;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\GestionPedidosPC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModificarPedido;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\GestionPedidosPC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminarPedido;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\GestionPedidosPC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGuardarPedido;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\GestionPedidosPC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewPedidos;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AppHibrida_MGI_SHDB;component/gestionpedidospc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GestionPedidosPC.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\GestionPedidosPC.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Add_CanExecute);
            
            #line default
            #line hidden
            
            #line 10 "..\..\GestionPedidosPC.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Add_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 11 "..\..\GestionPedidosPC.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Seleccionado_CanExecute);
            
            #line default
            #line hidden
            
            #line 11 "..\..\GestionPedidosPC.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Modificar_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 12 "..\..\GestionPedidosPC.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Seleccionado_CanExecute);
            
            #line default
            #line hidden
            
            #line 12 "..\..\GestionPedidosPC.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Eliminar_Executed);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 13 "..\..\GestionPedidosPC.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Add_CanExecute);
            
            #line default
            #line hidden
            
            #line 13 "..\..\GestionPedidosPC.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.GuardarBBDD_Executed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmbClientes = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.btnAddPedido = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btnModificarPedido = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.btnEliminarPedido = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.btnGuardarPedido = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.listViewPedidos = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\TabelaTipova.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D334225E62272F79F4A078A81BE0FFFD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HCI;
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


namespace HCI {
    
    
    /// <summary>
    /// TabelaTipova
    /// </summary>
    public partial class TabelaTipova : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\TabelaTipova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridTipovi;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\TabelaTipova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TTbtnIzmena;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\TabelaTipova.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TTbtnObrisi;
        
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
            System.Uri resourceLocater = new System.Uri("/HCI;component/tabelatipova.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TabelaTipova.xaml"
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
            this.dataGridTipovi = ((System.Windows.Controls.DataGrid)(target));
            
            #line 19 "..\..\TabelaTipova.xaml"
            this.dataGridTipovi.Loaded += new System.Windows.RoutedEventHandler(this.dataGridTipovi_Loaded);
            
            #line default
            #line hidden
            
            #line 19 "..\..\TabelaTipova.xaml"
            this.dataGridTipovi.MouseEnter += new System.Windows.Input.MouseEventHandler(this.dataGridTipovi_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TTbtnIzmena = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\TabelaTipova.xaml"
            this.TTbtnIzmena.Click += new System.Windows.RoutedEventHandler(this.TTbtnIzmena_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TTbtnObrisi = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\TabelaTipova.xaml"
            this.TTbtnObrisi.Click += new System.Windows.RoutedEventHandler(this.TTbtnObrisi_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\Tip_Resursa.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EB5A2FA82A2F874E23D472AC007ED625"
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
    /// Tip_Resursa
    /// </summary>
    public partial class Tip_Resursa : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\Tip_Resursa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Toznaka;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Tip_Resursa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Time;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Tip_Resursa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TbtnIkonica;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Tip_Resursa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image TimgIkonica;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Tip_Resursa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Topis;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Tip_Resursa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TsaveBtn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Tip_Resursa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TcloseBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/HCI;component/tip_resursa.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Tip_Resursa.xaml"
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
            this.Toznaka = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Time = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TbtnIkonica = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\Tip_Resursa.xaml"
            this.TbtnIkonica.Click += new System.Windows.RoutedEventHandler(this.TbtnIkonica_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TimgIkonica = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.Topis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TsaveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\Tip_Resursa.xaml"
            this.TsaveBtn.Click += new System.Windows.RoutedEventHandler(this.TsaveBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TcloseBtn = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\Tip_Resursa.xaml"
            this.TcloseBtn.Click += new System.Windows.RoutedEventHandler(this.TcloseBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

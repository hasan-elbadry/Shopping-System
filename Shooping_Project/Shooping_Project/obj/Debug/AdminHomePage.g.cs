﻿#pragma checksum "..\..\AdminHomePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8ABCBAF2306BB96D73CB8BBA43CE98EBE446A89C5172511992CCE116E5D6F879"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Shooping_Project;
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


namespace Shooping_Project {
    
    
    /// <summary>
    /// AdminHomePage
    /// </summary>
    public partial class AdminHomePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\AdminHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox productNametxt;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AdminHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateData;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AdminHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataaGrid;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\AdminHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteData;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\AdminHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RefreshData;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\AdminHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProductQunititytxt;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\AdminHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InserDatabtn;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\AdminHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search_btn;
        
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
            System.Uri resourceLocater = new System.Uri("/Shooping_Project;component/adminhomepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminHomePage.xaml"
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
            this.productNametxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.UpdateData = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\AdminHomePage.xaml"
            this.UpdateData.Click += new System.Windows.RoutedEventHandler(this.UpdateData_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DataaGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.DeleteData = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\AdminHomePage.xaml"
            this.DeleteData.Click += new System.Windows.RoutedEventHandler(this.DeleteData_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RefreshData = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\AdminHomePage.xaml"
            this.RefreshData.Click += new System.Windows.RoutedEventHandler(this.RefreshData_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ProductQunititytxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.InserDatabtn = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\AdminHomePage.xaml"
            this.InserDatabtn.Click += new System.Windows.RoutedEventHandler(this.InserDatabtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Search_btn = ((System.Windows.Controls.TextBox)(target));
            
            #line 64 "..\..\AdminHomePage.xaml"
            this.Search_btn.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_btn_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


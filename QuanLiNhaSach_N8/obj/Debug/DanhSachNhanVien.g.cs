﻿#pragma checksum "..\..\DanhSachNhanVien.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "397C2E296E09DEED1924B1148167A02C95E39CB3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QuanLiNhaSach_N8;
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


namespace QuanLiNhaSach_N8 {
    
    
    /// <summary>
    /// DanhSachNhanVien
    /// </summary>
    public partial class DanhSachNhanVien : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\DanhSachNhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTitle;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\DanhSachNhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTitle1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\DanhSachNhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTitle2;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\DanhSachNhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTitle3;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\DanhSachNhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTitle4;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\DanhSachNhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTitle5;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\DanhSachNhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView itemListView;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\DanhSachNhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReturn;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLiNhaSach_N8;component/danhsachnhanvien.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DanhSachNhanVien.xaml"
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
            
            #line 8 "..\..\DanhSachNhanVien.xaml"
            ((QuanLiNhaSach_N8.DanhSachNhanVien)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblTitle1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblTitle2 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lblTitle3 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lblTitle4 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lblTitle5 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.itemListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 9:
            this.btnReturn = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\DanhSachNhanVien.xaml"
            this.btnReturn.Click += new System.Windows.RoutedEventHandler(this.BtnReturn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


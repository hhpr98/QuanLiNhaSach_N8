﻿#pragma checksum "..\..\XemTheoNgay.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BD2CB210E168CD05767C66018A87F020B809A5CE"
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
    /// XemTheoNgay
    /// </summary>
    public partial class XemTheoNgay : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\XemTheoNgay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TKNgay;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\XemTheoNgay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ThoatTr;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\XemTheoNgay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker pickerNgay;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLiNhaSach_N8;component/xemtheongay.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\XemTheoNgay.xaml"
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
            this.TKNgay = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\XemTheoNgay.xaml"
            this.TKNgay.Click += new System.Windows.RoutedEventHandler(this.TKNgay_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ThoatTr = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\XemTheoNgay.xaml"
            this.ThoatTr.Click += new System.Windows.RoutedEventHandler(this.ThoatTr_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.pickerNgay = ((System.Windows.Controls.DatePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\View\Window1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5A55ED0B8B7357F6BFFA90C53CC690DAD315D45C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Page_Navigation_App.View {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\View\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtInvestmentNumber;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\View\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCustomerName;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\View\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePicker;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\View\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBuyingRate;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\View\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtWeight;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\View\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkCompleted;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\View\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSellingRate;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\View\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePickerSellingDate;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Page Navigation App;component/view/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Window1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtInvestmentNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtCustomerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.datePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.txtBuyingRate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtWeight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.chkCompleted = ((System.Windows.Controls.CheckBox)(target));
            
            #line 41 "..\..\..\..\View\Window1.xaml"
            this.chkCompleted.Checked += new System.Windows.RoutedEventHandler(this.chkCompleted_Checked);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\..\View\Window1.xaml"
            this.chkCompleted.Unchecked += new System.Windows.RoutedEventHandler(this.chkCompleted_Unchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtSellingRate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.datePickerSellingDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            
            #line 50 "..\..\..\..\View\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Add_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

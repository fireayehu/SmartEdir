﻿#pragma checksum "..\..\..\MemberUserControl\UserControlPayment.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13B895C37A69A62F193D0B7FB1DD857C5816E056"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using SmartEdir.MemberUserControl;
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


namespace SmartEdir.MemberUserControl {
    
    
    /// <summary>
    /// UserControlPayment
    /// </summary>
    public partial class UserControlPayment : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\MemberUserControl\UserControlPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Transitions.TransitioningContent TrainsitionigContentSlide;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\MemberUserControl\UserControlPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMember;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\MemberUserControl\UserControlPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ReceiptNumber;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\MemberUserControl\UserControlPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RNErr;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\MemberUserControl\UserControlPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Receipt;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\MemberUserControl\UserControlPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RIErr;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\MemberUserControl\UserControlPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Year;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\MemberUserControl\UserControlPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Month;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\MemberUserControl\UserControlPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Day;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\MemberUserControl\UserControlPayment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PayButton;
        
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
            System.Uri resourceLocater = new System.Uri("/SmartEdir;component/memberusercontrol/usercontrolpayment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MemberUserControl\UserControlPayment.xaml"
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
            this.TrainsitionigContentSlide = ((MaterialDesignThemes.Wpf.Transitions.TransitioningContent)(target));
            return;
            case 2:
            this.GridMember = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.ReceiptNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\MemberUserControl\UserControlPayment.xaml"
            this.ReceiptNumber.KeyUp += new System.Windows.Input.KeyEventHandler(this.ReceiptNumber_KeyUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RNErr = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Receipt = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\MemberUserControl\UserControlPayment.xaml"
            this.Receipt.Click += new System.Windows.RoutedEventHandler(this.Receipt_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RIErr = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.Year = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.Month = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.Day = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.PayButton = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\MemberUserControl\UserControlPayment.xaml"
            this.PayButton.Click += new System.Windows.RoutedEventHandler(this.PayButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\MemberHome.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1AAC8FB55D046E2F16CCEE0788161D712CD999CA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FinalExamDhrutiben;
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


namespace FinalExamDhrutiben {
    
    
    /// <summary>
    /// MemberHome
    /// </summary>
    public partial class MemberHome : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\MemberHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button navigateHome;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\MemberHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchValue;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\MemberHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchMember;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\MemberHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearFilter;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\MemberHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addMember;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\MemberHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel memberListPanel;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\MemberHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridMembers;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\MemberHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel noDataPanel;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\MemberHome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label noMembers;
        
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
            System.Uri resourceLocater = new System.Uri("/FinalExamDhrutiben;V1.0.0.0;component/memberhome.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MemberHome.xaml"
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
            this.navigateHome = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\MemberHome.xaml"
            this.navigateHome.Click += new System.Windows.RoutedEventHandler(this.navigateHome_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.searchValue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.searchMember = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\MemberHome.xaml"
            this.searchMember.Click += new System.Windows.RoutedEventHandler(this.searchMember_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.clearFilter = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\MemberHome.xaml"
            this.clearFilter.Click += new System.Windows.RoutedEventHandler(this.clearFilter_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.addMember = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\MemberHome.xaml"
            this.addMember.Click += new System.Windows.RoutedEventHandler(this.addMember_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.memberListPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.dataGridMembers = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.noDataPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 9:
            this.noMembers = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


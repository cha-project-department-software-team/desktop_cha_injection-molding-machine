﻿#pragma checksum "..\..\..\..\..\Resources\Components\MachineInformationDetail.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73D5FFB6451F2B87DE4A1E93A54DF2198B12BEC6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using MayEpCHADesktopApp.Core.ValueConverter;
using MayEpCHADesktopApp.Core.ViewModels.ComponentViewModels;
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


namespace MayEpCHADesktopApp.Resources.Components {
    
    
    /// <summary>
    /// MachineInformationDetail
    /// </summary>
    public partial class MachineInformationDetail : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\..\Resources\Components\MachineInformationDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MayEpCHADesktopApp.Resources.Components.MachineInformationDetail infordetail;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\Resources\Components\MachineInformationDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid C1;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\..\..\Resources\Components\MachineInformationDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gr;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\..\..\..\Resources\Components\MachineInformationDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Griddata;
        
        #line default
        #line hidden
        
        
        #line 391 "..\..\..\..\..\Resources\Components\MachineInformationDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Row5;
        
        #line default
        #line hidden
        
        
        #line 398 "..\..\..\..\..\Resources\Components\MachineInformationDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MayEpCHADesktopApp;component/resources/components/machineinformationdetail.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Resources\Components\MachineInformationDetail.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.infordetail = ((MayEpCHADesktopApp.Resources.Components.MachineInformationDetail)(target));
            return;
            case 2:
            this.C1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.gr = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.Griddata = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.Row5 = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.bt1 = ((System.Windows.Controls.Button)(target));
            
            #line 401 "..\..\..\..\..\Resources\Components\MachineInformationDetail.xaml"
            this.bt1.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


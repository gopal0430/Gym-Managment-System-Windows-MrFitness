﻿#pragma checksum "..\..\..\..\..\Components\Clients\ClientViewUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52FE0D879090E5B97934C02EA850E0CD1BD3D9EA"
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


namespace Gym.Desktop.Components.Clients {
    
    
    /// <summary>
    /// ClientViewUserControl
    /// </summary>
    public partial class ClientViewUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\..\..\Components\Clients\ClientViewUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Gym.Desktop.Components.Clients.ClientViewUserControl userControl;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Components\Clients\ClientViewUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbId;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\Components\Clients\ClientViewUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbName;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\Components\Clients\ClientViewUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbSurname;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\..\Components\Clients\ClientViewUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbDob;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\..\Components\Clients\ClientViewUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbGender;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\..\Components\Clients\ClientViewUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbPhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\..\Components\Clients\ClientViewUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbPSN;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Gym.Desktop;component/components/clients/clientviewusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Components\Clients\ClientViewUserControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.userControl = ((Gym.Desktop.Components.Clients.ClientViewUserControl)(target));
            return;
            case 2:
            this.lbId = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lbName = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lbSurname = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lbDob = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lbGender = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lbPhoneNumber = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lbPSN = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            
            #line 132 "..\..\..\..\..\Components\Clients\ClientViewUserControl.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.deleteIcon_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 152 "..\..\..\..\..\Components\Clients\ClientViewUserControl.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.updateIcon_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\SomeSetting.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B0C2CFD3E65A6E424077F166699518CA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BrainRingGame.Ui.Wpf.Common.Recourses.Help;
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


namespace BrainRingGame.Ui.Wpf.Common.Recourses.Help {
    
    
    /// <summary>
    /// SomeSetting
    /// </summary>
    public partial class SomeSetting : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\SomeSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Createcommand;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\SomeSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CreatecommandImage;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\SomeSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSetting;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\SomeSetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Setting;
        
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
            System.Uri resourceLocater = new System.Uri("/BrainRingGame.HelpWindowForms;component/somesetting.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SomeSetting.xaml"
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
            this.Createcommand = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\SomeSetting.xaml"
            this.Createcommand.Click += new System.Windows.RoutedEventHandler(this.Createcommand_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CreatecommandImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.buttonSetting = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\SomeSetting.xaml"
            this.buttonSetting.Click += new System.Windows.RoutedEventHandler(this.Setting_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Setting = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


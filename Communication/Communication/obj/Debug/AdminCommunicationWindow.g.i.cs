﻿#pragma checksum "..\..\AdminCommunicationWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "981DA7AD5C52ADF9DF5613509C9E6C81D1D3FC6777256B44871E443B24B6A7BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Communication;
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


namespace Communication {
    
    
    /// <summary>
    /// AdminCommunicationWindow
    /// </summary>
    public partial class AdminCommunicationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\AdminCommunicationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProfileButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AdminCommunicationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextVIEW;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AdminCommunicationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox QueView;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AdminCommunicationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AllProfileButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AdminCommunicationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AnswerButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AdminCommunicationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Deletebutton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AdminCommunicationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Communication;component/admincommunicationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminCommunicationWindow.xaml"
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
            this.ProfileButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\AdminCommunicationWindow.xaml"
            this.ProfileButton.Click += new System.Windows.RoutedEventHandler(this.ProfileButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextVIEW = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.QueView = ((System.Windows.Controls.ListBox)(target));
            
            #line 28 "..\..\AdminCommunicationWindow.xaml"
            this.QueView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.QueView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AllProfileButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\AdminCommunicationWindow.xaml"
            this.AllProfileButton.Click += new System.Windows.RoutedEventHandler(this.AllProfileButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AnswerButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\AdminCommunicationWindow.xaml"
            this.AnswerButton.Click += new System.Windows.RoutedEventHandler(this.AnswerButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Deletebutton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\AdminCommunicationWindow.xaml"
            this.Deletebutton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.updateButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\AdminCommunicationWindow.xaml"
            this.updateButton.Click += new System.Windows.RoutedEventHandler(this.updateButton_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


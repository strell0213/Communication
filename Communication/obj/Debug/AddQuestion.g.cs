﻿#pragma checksum "..\..\AddQuestion.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E1DB2EB34512FD80565886D0EA32EDD333BF73246A38C244C35A35A944763C28"
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
    /// AddQuestion
    /// </summary>
    public partial class AddQuestion : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QueText;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox CommAns;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button YesMainButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AdminQueButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AddQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CommAnsButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Communication;component/addquestion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddQuestion.xaml"
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
            this.QueText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.CommAns = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.YesMainButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\AddQuestion.xaml"
            this.YesMainButton.Click += new System.Windows.RoutedEventHandler(this.YesMainButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AdminQueButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\AddQuestion.xaml"
            this.AdminQueButton.Click += new System.Windows.RoutedEventHandler(this.AdminQueButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CommAnsButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\AddQuestion.xaml"
            this.CommAnsButton.Click += new System.Windows.RoutedEventHandler(this.CommAnsButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


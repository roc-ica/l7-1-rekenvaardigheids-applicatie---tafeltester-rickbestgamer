﻿#pragma checksum "..\..\..\Pages\Questions.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6D828CFC737FA64C309278F21422FA09774D0091D9157AB843B88615C507CD0E"
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
using Tafeltester.Pages;


namespace Tafeltester.Pages {
    
    
    /// <summary>
    /// Questions
    /// </summary>
    public partial class Questions : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\Pages\Questions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock difficulty_header;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\Questions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxBlProgress;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\Questions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txbl_question;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\Questions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_questioin_input;
        
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
            System.Uri resourceLocater = new System.Uri("/Tafeltester;component/pages/questions.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Questions.xaml"
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
            this.difficulty_header = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.TxBlProgress = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txbl_question = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.txb_questioin_input = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\Pages\Questions.xaml"
            this.txb_questioin_input.KeyDown += new System.Windows.Input.KeyEventHandler(this.TXBNameInput_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 35 "..\..\..\Pages\Questions.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CheckQuestions);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 36 "..\..\..\Pages\Questions.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NextQuestion);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 37 "..\..\..\Pages\Questions.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


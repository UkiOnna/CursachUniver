﻿#pragma checksum "..\..\RedactPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DB70BF54889F30A5015593A9FA1A1DCE4DEBC0DB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MyCollection;
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


namespace MyCollection {
    
    
    /// <summary>
    /// RedactPage
    /// </summary>
    public partial class RedactPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageContainer;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxType;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock OtherTextBlock;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OtherTextBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxIsWatched;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LinkText;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RateText;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RateComboBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\RedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameText;
        
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
            System.Uri resourceLocater = new System.Uri("/MyCollection;component/redactpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RedactPage.xaml"
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
            this.imageContainer = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            
            #line 18 "..\..\RedactPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.comboBoxType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\RedactPage.xaml"
            this.comboBoxType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxTypeSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OtherTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.OtherTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.comboBoxIsWatched = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\RedactPage.xaml"
            this.comboBoxIsWatched.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxIsWatchedSelectionChange);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LinkText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.RateText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.RateComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            
            #line 29 "..\..\RedactPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveElementClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.nameText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            
            #line 32 "..\..\RedactPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


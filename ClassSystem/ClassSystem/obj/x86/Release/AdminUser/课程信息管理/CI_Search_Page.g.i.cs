﻿#pragma checksum "..\..\..\..\..\AdminUser\课程信息管理\CI_Search_Page.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F0B40C4F287A6F35240428387331F710"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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


namespace ClassSystem.AdminUser.课程信息管理 {
    
    
    /// <summary>
    /// CI_Search_Page
    /// </summary>
    public partial class CI_Search_Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\AdminUser\课程信息管理\CI_Search_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\AdminUser\课程信息管理\CI_Search_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_CI;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\AdminUser\课程信息管理\CI_Search_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\AdminUser\课程信息管理\CI_Search_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_CI_Search;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\AdminUser\课程信息管理\CI_Search_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
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
            System.Uri resourceLocater = new System.Uri("/ClassSystem;component/adminuser/%e8%af%be%e7%a8%8b%e4%bf%a1%e6%81%af%e7%ae%a1%e7" +
                    "%90%86/ci_search_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\AdminUser\课程信息管理\CI_Search_Page.xaml"
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
            this.datagrid1 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.TB_CI = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.BTN_CI_Search = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\..\AdminUser\课程信息管理\CI_Search_Page.xaml"
            this.BTN_CI_Search.Click += new System.Windows.RoutedEventHandler(this.BTN_CI_Search_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


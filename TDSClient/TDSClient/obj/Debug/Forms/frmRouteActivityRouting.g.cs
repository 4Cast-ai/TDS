#pragma checksum "..\..\..\Forms\frmRouteActivityRouting.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BD988B83CDF2445F7ACDA0D7268F8A8A"
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
using TDSClient.Properties;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace TDSClient.Forms {
    
    
    /// <summary>
    /// frmRouteActivityRouting
    /// </summary>
    public partial class frmRouteActivityRouting : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSourceX;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSourceY;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTargetX;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTargetY;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdClearAutoRoute;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdRoute;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxMapSource;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxMapTarget;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtGridRoute;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdNew;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdDelete;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkCarMostImportant;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkCarMediumImportant;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkCarLowImportant;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkConstruction;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockRouteName;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRouteName;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockRouteName_Copy;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txPlatformName;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdExit;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmdInsert;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.TimeSpanUpDown startActivity;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.TimeSpanUpDown durationActivity;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Forms\frmRouteActivityRouting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown speedUpDown;
        
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
            System.Uri resourceLocater = new System.Uri("/TDSClient;component/forms/frmrouteactivityrouting.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Forms\frmRouteActivityRouting.xaml"
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
            
            #line 7 "..\..\..\Forms\frmRouteActivityRouting.xaml"
            ((TDSClient.Forms.frmRouteActivityRouting)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 7 "..\..\..\Forms\frmRouteActivityRouting.xaml"
            ((TDSClient.Forms.frmRouteActivityRouting)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.Window_Unloaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtSourceX = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtSourceY = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtTargetX = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtTargetY = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.cmdClearAutoRoute = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Forms\frmRouteActivityRouting.xaml"
            this.cmdClearAutoRoute.Click += new System.Windows.RoutedEventHandler(this.cmdClearAutoRoute_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmdRoute = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Forms\frmRouteActivityRouting.xaml"
            this.cmdRoute.Click += new System.Windows.RoutedEventHandler(this.cmdRoute_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.checkBoxMapSource = ((System.Windows.Controls.CheckBox)(target));
            
            #line 21 "..\..\..\Forms\frmRouteActivityRouting.xaml"
            this.checkBoxMapSource.Checked += new System.Windows.RoutedEventHandler(this.checkBoxMapSource_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.checkBoxMapTarget = ((System.Windows.Controls.CheckBox)(target));
            
            #line 22 "..\..\..\Forms\frmRouteActivityRouting.xaml"
            this.checkBoxMapTarget.Checked += new System.Windows.RoutedEventHandler(this.checkBoxMapTarget_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dtGridRoute = ((System.Windows.Controls.DataGrid)(target));
            
            #line 23 "..\..\..\Forms\frmRouteActivityRouting.xaml"
            this.dtGridRoute.PreparingCellForEdit += new System.EventHandler<System.Windows.Controls.DataGridPreparingCellForEditEventArgs>(this.dtGridRoute_PreparingCellForEdit);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\Forms\frmRouteActivityRouting.xaml"
            this.dtGridRoute.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dtGridRoute_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.cmdNew = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Forms\frmRouteActivityRouting.xaml"
            this.cmdNew.Click += new System.Windows.RoutedEventHandler(this.cmdNew_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.cmdDelete = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Forms\frmRouteActivityRouting.xaml"
            this.cmdDelete.Click += new System.Windows.RoutedEventHandler(this.cmdDelete_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.chkCarMostImportant = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 14:
            this.chkCarMediumImportant = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 15:
            this.chkCarLowImportant = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 16:
            this.chkConstruction = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 17:
            this.textBlockRouteName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 18:
            this.txtRouteName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 19:
            this.textBlockRouteName_Copy = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 20:
            this.txPlatformName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 21:
            this.cmdExit = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Forms\frmRouteActivityRouting.xaml"
            this.cmdExit.Click += new System.Windows.RoutedEventHandler(this.cmdExit_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.cmdInsert = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Forms\frmRouteActivityRouting.xaml"
            this.cmdInsert.Click += new System.Windows.RoutedEventHandler(this.cmdInsert_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            this.startActivity = ((Xceed.Wpf.Toolkit.TimeSpanUpDown)(target));
            return;
            case 24:
            this.durationActivity = ((Xceed.Wpf.Toolkit.TimeSpanUpDown)(target));
            return;
            case 25:
            this.speedUpDown = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


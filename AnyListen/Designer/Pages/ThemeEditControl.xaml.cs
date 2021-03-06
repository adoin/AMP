﻿using System.Windows;
using AnyListen.Designer.Data;
using AnyListen.Designer.Data.ThemeData;

namespace AnyListen.Designer.Pages
{
    /// <summary>
    /// Interaction logic for ThemeEditControl.xaml
    /// </summary>
    public partial class ThemeEditControl
    {

        public static readonly DependencyProperty ThemeDataProperty = DependencyProperty.Register(
            "ThemeData", typeof (DataThemeBase), typeof (ThemeEditControl), new PropertyMetadata(default(DataThemeBase)));

        public DataThemeBase ThemeData
        {
            get { return (DataThemeBase) GetValue(ThemeDataProperty); }
            set { SetValue(ThemeDataProperty, value); }
        }
        
        public ThemeEditControl()
        {
            InitializeComponent();
        }
    }
}

﻿using MvvmNorthwind.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MvvmNorthwind.Views
{
    /// <summary>
    /// Interaction logic for ProductView.xaml
    /// </summary>
    public partial class ProductView : UserControl
    {
        public ProductView()
        {
            InitializeComponent();
        }

        //private void productGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if(productGrid.Items.IndexOf(productGrid.CurrentColumn) == productGrid.Items.Count)
        //    {
                
        //    }
        //}
    }
}

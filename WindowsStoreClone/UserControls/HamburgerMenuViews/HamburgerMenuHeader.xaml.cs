﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowsStoreClone.UserControls.HamburgerMenuViews
{
    /// <summary>
    /// Interaction logic for HamburgerMenuHeader.xaml
    /// </summary>
    public partial class HamburgerMenuHeader : UserControl
    {
        public delegate void OnFilterMenuItemClicked(object sender, RoutedEventArgs e);
        public event OnFilterMenuItemClicked FilterMenuItemClicked;

        public delegate void OnSortMenuItemClicked(object sender, RoutedEventArgs e);
        public event OnSortMenuItemClicked SortMenuItemClicked;

        public HamburgerMenuHeader()
        {
            InitializeComponent();
        }

        private void Filter_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FilterByTypeLabel.Content = (sender as MenuItem).Header.ToString();
            FilterMenuItemClicked?.Invoke(sender, e);   
        }

        private void Sort_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SortByLabel.Content = (sender as MenuItem).Header.ToString();
            SortMenuItemClicked?.Invoke(sender, e);
        }
    }
}

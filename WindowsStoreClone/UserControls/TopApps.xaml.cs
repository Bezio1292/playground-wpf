﻿using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WindowsStoreClone.UserControls
{
    /// <summary>
    /// Interaction logic for TopApps.xaml
    /// </summary>
    public partial class TopApps : UserControl
    {
        public delegate void OnAnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAnAppClicked AppClicked;

        public delegate void OnTopAppButtonClicked(object sender, RoutedEventArgs e);
        public event OnTopAppButtonClicked TopAppButtonClicked;

        public TopApps()
        {
            InitializeComponent();
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Image appImage = sender as Image;
            string appName = (new CultureInfo("en-US", false).TextInfo).ToTitleCase(appImage.Source.ToString().Split('/').Last().Split('-').Last().Split('.').First());

            AppClicked?.Invoke(new AnApp(appName, appImage.Source), e);
        }

        private void TopAppsButton_Click(object sender, RoutedEventArgs e)
        {
            TopAppButtonClicked?.Invoke(sender, e);
        }
    }
}

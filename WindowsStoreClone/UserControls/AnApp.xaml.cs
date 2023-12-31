﻿using MiscUtil;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
    /// Interaction logic for AnApp.xaml
    /// </summary>
    public partial class AnApp : UserControl
    {
        public string AppName { get; set; }
        public ImageSource AppImageSource { get; set; }

        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;

        public AnApp()
        {
            InitializeComponent();

            List<string> filepaths = Directory.GetFiles(Environment.CurrentDirectory + @"\..\..\Images", "*.png").ToList<string>();
            FileInfo myRandomFile = new FileInfo(filepaths[StaticRandom.Next(filepaths.Count)]);
            
            Uri appImageSourceUri = new Uri(myRandomFile.FullName, UriKind.RelativeOrAbsolute);
            AppName = (new CultureInfo("en-US", false).TextInfo).ToTitleCase(myRandomFile.Name.Split('-').Last().Split('.').First());
            AppImageSource = new BitmapImage(appImageSourceUri);

            AppNameText.Text = AppName;
            ProductImage.Source = AppImageSource;

        }

        public AnApp(string inAppName, ImageSource inImageSource)
        {
            InitializeComponent();
            ProductImage.Source = inImageSource;
            AppNameText.Text = inAppName;
            AppName = inAppName;
            AppImageSource = inImageSource;
        }

        private void ProductImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            AppClicked?.Invoke(this, e);
        }
    }
}

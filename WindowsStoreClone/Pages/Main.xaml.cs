﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using WindowsStoreClone.UserControls;

namespace WindowsStoreClone.Pages
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {

        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;

        public delegate void OnTopAppButtonClicked(object sender, RoutedEventArgs e);
        public event OnTopAppButtonClicked TopAppButtonClicked;

        public delegate void OnDownloadButtonCLick(object sender, RoutedEventArgs e);
        public event OnDownloadButtonCLick HeaderRightButtonDownloadButtonCLick;

        public Main()
        {
            InitializeComponent();

            DealsAppsViewer.AppClicked += AnAppClicked;
            ProductivityAppsViewer.AppClicked += AnAppClicked;
            EntertainmentTopFreeAppsViewer.AppClicked += AnAppClicked;
            GamingTopFreeGamesAppsViewer.AppClicked += AnAppClicked;
            AppsViewer.AppClicked += AnAppClicked;
            MostPopularAppsViewer.AppClicked += AnAppClicked;
            TopFreeAppsViewer.AppClicked += AnAppClicked;
            TopFreeGamesAppsViewer.AppClicked += AnAppClicked;

            ProductivityTopApps.AppClicked += AnAppClicked;
            TopApps.AppClicked+= AnAppClicked;

            TopApps.TopAppButtonClicked += TopApps_TopAppButtonClicked;
            RightHeaderButtons.HeaderRightButtonDownloadButtonCLick += RightHeaderButtons_HeaderRightButtonDownloadButtonCLick;
        }

        private void RightHeaderButtons_HeaderRightButtonDownloadButtonCLick(object sender, RoutedEventArgs e)
        {
            HeaderRightButtonDownloadButtonCLick?.Invoke(sender, e);
        }

        private void TopApps_TopAppButtonClicked(object sender, RoutedEventArgs e)
        {
            TopAppButtonClicked?.Invoke(sender, e);
        }

        private void AnAppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked?.Invoke(sender, e);
        }

        // c# code has LOWER priority than XAML code !!!!

        private void MainScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            UIElement element = sender as UIElement;
            element.Opacity = 0;
            DoubleAnimation animation = new DoubleAnimation()
            {
                From = 0,
                To = 1,
                Duration = new Duration(new TimeSpan(0, 0, 1))
            };
            element.BeginAnimation(UIElement.OpacityProperty, animation);

        }

    }
}

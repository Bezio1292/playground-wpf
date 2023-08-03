using System;
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
using WindowsStoreClone.UserControls;

namespace WindowsStoreClone.Pages
{
    /// <summary>
    /// Interaction logic for AppDetails.xaml
    /// </summary>
    public partial class AppDetails : Page
    {
        public delegate void OnBackButtonClicked(object sender, RoutedEventArgs e);
        public event OnBackButtonClicked BackButtonClicked;

        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;
        public AppDetails(AnApp anApp)
        {
            InitializeComponent();

            //avaliable through x:Name
            AppDetailsAndBackgroundUC.AppNameLabel.Content = anApp.AppName;
            AppDetailsAndBackgroundUC.AppImage.Source = anApp.AppImageSource;

            //avaliable through x:Name
            AppDetailsAndBackgroundUC.BackButtonClicked += AppDetailsAndBackgroundUC_BackButtonClicked;
            OverviewTabUC.AppClicked += OverviewTabUC_AppClicked;
        }

        private void OverviewTabUC_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked?.Invoke(sender, e);
        }

        private void AppDetailsAndBackgroundUC_BackButtonClicked(object sender, RoutedEventArgs e)
        {
            BackButtonClicked?.Invoke(sender, e);
        }
    }
}

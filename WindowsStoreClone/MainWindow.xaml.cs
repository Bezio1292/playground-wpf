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
using WindowsStoreClone.Pages;
using WindowsStoreClone.UserControls;

namespace WindowsStoreClone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Main mainWindowContentPage;

        public MainWindow()
        {
            InitializeComponent();
            mainWindowContentPage = new Main();
            mainWindowContentPage.AppClicked += MainWindowContentPage_AppClicked;

        }

        private void MainWindowContentPage_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppDetails appDetails = new AppDetails(sender);
            appDetails.BackButtonClicked += AppDetails_BackButtonClicked;
            appDetails.AppClicked += MainWindowContentPage_AppClicked;
            MainWindowFrame.Content = appDetails;
        }



        private void AppDetails_BackButtonClicked(object sender, RoutedEventArgs e)
        {
            if (MainWindowFrame.NavigationService.CanGoBack)
            {
                MainWindowFrame.NavigationService.GoBack();
            }
        }

        private void MainWindowFrame_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = mainWindowContentPage;
        }
    }
}

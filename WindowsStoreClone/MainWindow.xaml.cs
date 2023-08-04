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
using WindowsStoreClone.UserControls.HamburgerMenuViews;

namespace WindowsStoreClone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Main mainWindowContentPage;
        private TopAppsWrapped myTopAppsWrappedPage;

        public MainWindow()
        {
            InitializeComponent();
            mainWindowContentPage = new Main();
            mainWindowContentPage.AppClicked += MainWindowContentPage_AppClicked;

            myTopAppsWrappedPage= new TopAppsWrapped();
            myTopAppsWrappedPage.AppClicked += MainWindowContentPage_AppClicked;
            myTopAppsWrappedPage.BackButtonClicked += BackButtonClicked;
            mainWindowContentPage.TopAppButtonClicked += MainWindowContentPage_TopAppButtonClicked;

            mainWindowContentPage.HeaderRightButtonDownloadButtonCLick += MainWindowContentPage_HeaderRightButtonDownloadButtonCLick;
        }

        private void MainWindowContentPage_HeaderRightButtonDownloadButtonCLick(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = new AllOwned();
        }

        private void MainWindowContentPage_TopAppButtonClicked(object sender, RoutedEventArgs e)
        {
            //TopAppsWrapped topAppsWrapped= new TopAppsWrapped();
            //topAppsWrapped.BackButtonClicked += BackButtonClicked;
            //topAppsWrapped.AppClicked += MainWindowContentPage_AppClicked;
            MainWindowFrame.Content = myTopAppsWrappedPage;
        }

        private void MainWindowContentPage_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppDetails appDetails = new AppDetails(sender);
            appDetails.BackButtonClicked += BackButtonClicked;
            appDetails.AppClicked += MainWindowContentPage_AppClicked;
            MainWindowFrame.Content = appDetails;
        }



        private void BackButtonClicked(object sender, RoutedEventArgs e)
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

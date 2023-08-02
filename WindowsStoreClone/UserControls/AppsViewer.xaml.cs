using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WindowsStoreClone.UserControls
{
    /// <summary>
    /// Interaction logic for AppsViewer.xaml
    /// </summary>
    public partial class AppsViewer : UserControl
    {

        List<AnApp> presentedApps;

        public AppsViewer()
        {
            InitializeComponent();

            presentedApps = new List<AnApp>();
            AppsList.ItemsSource = presentedApps;
            for (int i = 0; i < 9; ++i)
            {
                AnApp app = new AnApp();
                presentedApps.Add(app);
            }
        }

        // Because we using data binding we have to use diffrent method than:
        // AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset + 4);
        private void ScrollLeftButton_Click(object sender, RoutedEventArgs e)
        {
            int widthOfOneApp = (int)(presentedApps.First().ActualWidth + 2 * presentedApps.First().Margin.Left);
            AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset - 3 * widthOfOneApp);
        }

        private void ScrollRightButton_Click(object sender, RoutedEventArgs e)
        {
            int widthOfOneApp = (int)(presentedApps.First().ActualWidth + 2 * presentedApps.First().Margin.Left);
            AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset + 3 * widthOfOneApp);
        }
    }
}

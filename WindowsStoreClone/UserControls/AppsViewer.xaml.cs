using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WindowsStoreClone.UserControls
{
    /// <summary>
    /// Interaction logic for AppsViewer.xaml
    /// </summary>
    public partial class AppsViewer : UserControl
    {

        List<AnApp> presentedApps;

        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;

        public AppsViewer()
        {
            InitializeComponent();

            presentedApps = new List<AnApp>();
            AppsList.ItemsSource = presentedApps;
            for (int i = 0; i < 9; ++i)
            {
                AnApp app = new AnApp();
                app.AppClicked += Curr_AppClicked;
                presentedApps.Add(app);
            }
        }

        private void Curr_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked?.Invoke(sender, e);
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

        private void AppsScrollView_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            e.Handled = true;
            var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
            eventArg.RoutedEvent = UIElement.MouseWheelEvent;
            eventArg.Source = sender;
            var parent = (sender as Control).Parent as UIElement;
            parent.RaiseEvent(eventArg);
        }
    }
}

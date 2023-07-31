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
            AppsList.ItemsSource= presentedApps;
            for(int i = 0; i < 9; ++i)
            {
                AnApp app = new AnApp();
                presentedApps.Add(app);
            }
        }

        private void ScrollLeftButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ScrollRightButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

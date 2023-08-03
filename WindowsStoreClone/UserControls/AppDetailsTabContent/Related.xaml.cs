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

namespace WindowsStoreClone.UserControls.AppDetailsTabContent
{
    /// <summary>
    /// Interaction logic for Related.xaml
    /// </summary>
    public partial class Related : UserControl
    {
        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;
        public Related()
        {
            InitializeComponent();
            AppViewer1.AppClicked += AppViewer1_AppClicked;
            AppViewer2.AppClicked += AppViewer1_AppClicked;
            AppViewer3.AppClicked += AppViewer1_AppClicked;

        }

        private void AppViewer1_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked?.Invoke(sender, e);
        }
    }
}

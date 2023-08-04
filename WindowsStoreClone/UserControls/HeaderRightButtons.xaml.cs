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
    /// Interaction logic for HeaderRightButtons.xaml
    /// </summary>
    public partial class HeaderRightButtons : UserControl
    {
        public delegate void OnDownloadButtonCLick(object sender, RoutedEventArgs e);
        public event OnDownloadButtonCLick HeaderRightButtonDownloadButtonCLick;

        public HeaderRightButtons()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Visibility = Visibility.Collapsed; // better use SearchButton ...
            SearchTextBox.Visibility= Visibility.Visible;
        }

        public void MouseDown_OutsideOfHeaderRightButton()
        {
            if(SearchTextBox.IsMouseOver == false)
            {
                SearchButton.Visibility = Visibility.Collapsed;
                SearchTextBox.Visibility = Visibility.Visible;
            }
        }

        private void DownloadButton_Click(object sender, RoutedEventArgs e)
        {
            HeaderRightButtonDownloadButtonCLick?.Invoke(sender, e);
        }
        private void DownloadsAndUpdatesMenuItem_CLick(object sender, RoutedEventArgs e)
        {
            HeaderRightButtonDownloadButtonCLick?.Invoke(sender, e);
        }


    }
}

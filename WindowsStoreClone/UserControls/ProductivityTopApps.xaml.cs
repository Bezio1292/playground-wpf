using MiscUtil;
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
    /// Interaction logic for ProductivityTopApps.xaml
    /// </summary>
    public partial class ProductivityTopApps : UserControl
    {
        public delegate void OnAnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAnAppClicked AppClicked;
        public ProductivityTopApps()
        {
            InitializeComponent();
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Image appImage = sender as Image;
            string appName = (new CultureInfo("en-US", false).TextInfo).ToTitleCase(appImage.Source.ToString().Split('/').Last().Split('-').Last().Split('.').First());

            AppClicked?.Invoke(new AnApp(appName, appImage.Source), e);
        }
    }
}

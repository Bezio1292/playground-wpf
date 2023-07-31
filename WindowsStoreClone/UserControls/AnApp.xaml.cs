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
    /// Interaction logic for AnApp.xaml
    /// </summary>
    public partial class AnApp : UserControl
    {
        public AnApp()
        {
            InitializeComponent();

            List<string> filepaths = Directory.GetFiles(Environment.CurrentDirectory + @"\..\..\Images", "*.png").ToList<string>();
            FileInfo myRandomFile = new FileInfo(filepaths[StaticRandom.Next(filepaths.Count)]);
            
            Uri appImageSourceUri = new Uri(myRandomFile.FullName, UriKind.RelativeOrAbsolute);
            string appName = (new CultureInfo("en-US", false).TextInfo).ToTitleCase(myRandomFile.Name.Split('-').Last().Split('.').First());

            AppNameText.Text = appName;
            ProductImage.Source = new BitmapImage(appImageSourceUri);

        }

        private void ProductImage_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}

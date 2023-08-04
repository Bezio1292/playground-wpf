using MiscUtil;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WindowsStoreClone.UserControls.HamburgerMenuViews
{
    /// <summary>
    /// Interaction logic for HamburgerMenuApp.xaml
    /// </summary>
    public partial class HamburgerMenuApp : UserControl
    {
        private List<string> AppNames;
        private List<string> AppTypes;
        public string AppName { get; private set; }
        public DateTime Purchased {get;private set;}
        public string Type { get; private set; }

        public HamburgerMenuApp()
        {
            InitializeComponent();
            AppTypes = new List<string>() { "Apps", "Games", "Movies", "Avatars" };

            List<string> filepaths = Directory.GetFiles(Environment.CurrentDirectory + @"\..\..\Images\MiniIcons", "*.png").ToList<string>();
            FileInfo myRandomFile = new FileInfo(filepaths[StaticRandom.Next(filepaths.Count)]);

            Uri appImageSourceUri = new Uri(myRandomFile.FullName, UriKind.RelativeOrAbsolute);
            AppName = (new CultureInfo("en-US", false).TextInfo).ToTitleCase(myRandomFile.Name.Split('-').Last().Split('.').First());
            AppImage.Source = new BitmapImage(appImageSourceUri);
            Type = AppTypes[StaticRandom.Next(AppTypes.Count)];
            Purchased = new DateTime(2020, 1, StaticRandom.Next(1, DateTime.Now.Day + 1));
            PurchasedLabel.Content = "Purchased " + Purchased.ToString("d");
            AppNameLabel.Content = AppName;
            
        }
    }
}

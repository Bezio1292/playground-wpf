using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace WindowsStoreClone.UserControls.HamburgerMenuViews
{
    /// <summary>
    /// Interaction logic for HamburgerMenuAppList.xaml
    /// </summary>
    public partial class HamburgerMenuAppList : UserControl
    {

        private List<HamburgerMenuApp> AllApps;
        private List<HamburgerMenuApp> AppsOnFilter;

        public HamburgerMenuAppList()
        {
            InitializeComponent();
            AllApps = new List<HamburgerMenuApp>();
            AppsOnFilter = new List<HamburgerMenuApp>();
            for (int i = 0; i < 50; ++i)
                AddNewHamApp();
        }


        private void AddNewHamApp()
        {
            HamburgerMenuApp app = new HamburgerMenuApp();
            MainStackPanel.Children.Add(app);
            AllApps.Add(app);
        }

        public void FilterByType(string inFilter)
        {
            AppsOnFilter = AllApps.Where(p => p.Type == inFilter).ToList<HamburgerMenuApp>();
            MainStackPanel.Children.Clear();
            foreach (HamburgerMenuApp item in AppsOnFilter)
            {
                MainStackPanel.Children.Add(item);
            }
        }

        public void AddAll()
        {
            MainStackPanel.Children.Clear();
            foreach (HamburgerMenuApp item in AllApps)
            {
                MainStackPanel.Children.Add(item);
            }
        }

        public void SortByName()
        {
            List<HamburgerMenuApp> AllAppsSorted = AllApps.OrderBy(p => p.AppName).ToList();
            foreach(HamburgerMenuApp item in AllAppsSorted)
            {
                MainStackPanel.Children.Add(item);
            }
        }
        public void SortByDate()
        {
            List<HamburgerMenuApp> AllAppsSorted = AllApps.OrderBy(p => p.Purchased).ToList();
            foreach (HamburgerMenuApp item in AllAppsSorted)
            {
                MainStackPanel.Children.Add(item);
            }
        }
    }
}

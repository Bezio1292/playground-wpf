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
            AddToMainStackPanel(AppsOnFilter);

        }

        public void AddAll()
        {
            AppsOnFilter = new List<HamburgerMenuApp>();
            AddToMainStackPanel(AllApps);
        }

        public void SortByName()
        {
            List<HamburgerMenuApp> AllAppsSorted = new List<HamburgerMenuApp>();
            if (AppsOnFilter.Count < 1)
                AllAppsSorted = AllApps.OrderBy(p => p.AppName).ToList();
            else
                AllAppsSorted = AppsOnFilter.OrderBy(p => p.AppName).ToList();
            AddToMainStackPanel(AllAppsSorted);
        }
        public void SortByDate()
        {
            List<HamburgerMenuApp> AllAppsSorted = new List<HamburgerMenuApp>();
            if (AppsOnFilter.Count < 1)
                AllAppsSorted = AllApps.OrderByDescending(p => p.Purchased).ToList();
            else
                AllAppsSorted = AppsOnFilter.OrderByDescending(p => p.Purchased).ToList();
            AddToMainStackPanel(AllAppsSorted);
        }

        private void AddToMainStackPanel(List<HamburgerMenuApp> inList)
        {
            MainStackPanel.Children.Clear();
            foreach(HamburgerMenuApp item in inList)
            {
                MainStackPanel.Children.Add(item);
            }
        }
    }
}

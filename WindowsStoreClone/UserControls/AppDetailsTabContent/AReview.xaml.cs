using MiscUtil;
using System.Collections.Generic;
using System.Windows.Controls;

namespace WindowsStoreClone.UserControls.AppDetailsTabContent
{
    /// <summary>
    /// Interaction logic for AReview.xaml
    /// </summary>
    public partial class AReview : UserControl
    {
        List<string> Names;
        List<string> Titles;
        public AReview()
        {
            InitializeComponent();
            Names = new List<string>() { "Vic", "Mike", "Zoltan", "Daniel", "Maria" };
            Titles = new List<string>() { "This app is awful!", "This app is bad!", "It's ok", "Nice app :D", "This app is a masterpiece" };

            string reviewerName = Names[StaticRandom.Next(Names.Count)];
            ReviewerNameLabel.Content = reviewerName;
            AvatarLabel.Content = reviewerName[0];
            NumOfStarsLabel.Content = GetRandomNumOfStars();
            ReviewTitle.Content = Titles[NumOfStarsLabel.Content.ToString().Length-1];
        }

        private string GetRandomNumOfStars()
        {
            string content = string.Empty;
            for (int i = 0; i < StaticRandom.Next(1, 5); ++i)
            {
                content += "★";
            }
            return content;
        }
    }
}

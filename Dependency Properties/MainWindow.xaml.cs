using System.Windows;

namespace Dependency_Properties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void increaseButton_Click(object sender, RoutedEventArgs e)
        {
            demoAUserControl.Awesomeness += 10;
            demoBUserControl.Awesomeness += 10;
            if (demoBUserControl.Awesomeness >= 100)
                demoBUserControl.AwesomenessOverValue = true;
            else
                demoBUserControl.AwesomenessOverValue = false;
        }
    }
}
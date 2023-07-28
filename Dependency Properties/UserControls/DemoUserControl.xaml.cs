using System.Windows;
using System.Windows.Controls;

namespace Dependency_Properties.UserControls
{
    public partial class DemoUserControl : UserControl
    {
        public DemoUserControl()
        {
            InitializeComponent();
        }

        // propdp + TAB + TAB
        // This shortcut creates default structure for custom dependency property
        public int Awesomeness
        {
            get { return (int)GetValue(AwesomenessProperty); }
            set { SetValue(AwesomenessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Awesomeness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AwesomenessProperty =
            DependencyProperty.Register("Awesomeness", typeof(int), typeof(DemoUserControl), new PropertyMetadata(0)); // new PropertyMetadata(0) == new PropertyMetadata(defalutValue: 0)




        public bool AwesomenessOverValue
        {
            get { return (bool)GetValue(AwesomenessOverValueProperty); }
            set { SetValue(AwesomenessOverValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AwesomenessOverValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AwesomenessOverValueProperty =
            DependencyProperty.Register("AwesomenessOverValue", typeof(bool), typeof(DemoUserControl), new PropertyMetadata(false));




        public string Postfix
        {
            get { return (string)GetValue(PostfixProperty); }
            set { SetValue(PostfixProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Postfix.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PostfixProperty =
            DependencyProperty.Register("Postfix", typeof(string), typeof(DemoUserControl), new PropertyMetadata(defaultValue: string.Empty, new PropertyChangedCallback(OnPostfixChanged)));

        private static void OnPostfixChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DemoUserControl? MyUCControl = d as DemoUserControl;
            MyUCControl?.OnPostfixChanged(e);
        }

        private void OnPostfixChanged(DependencyPropertyChangedEventArgs e)
        {
            customTextBlock.Text += $" {e.NewValue}";
        }

    }
}

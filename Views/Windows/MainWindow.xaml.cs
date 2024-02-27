using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace YourDreamMarketplace
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TabItem tabItem = FindParent<TabItem>((DependencyObject)sender);
            TabControl tabControl = FindParent<TabControl>(tabItem);
            tabControl.Items.Remove(tabItem);
        }
        // Метод для поиска родительского элемента заданного типа
        private T FindParent<T>(DependencyObject child) where T : DependencyObject
        {
            DependencyObject parentObject = VisualTreeHelper.GetParent(child);

            if (parentObject == null)
                return null;

            if (parentObject is T parent)
            {
                return parent;
            }
            else
            {
                return FindParent<T>(parentObject);
            }
        }
    }
}

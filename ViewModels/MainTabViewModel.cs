using System.ComponentModel;

namespace YourDreamMarketplace
{
    public class MainTabViewModel : INotifyPropertyChanged
    {
        public List<Product> Products { get; set; }

        public MainTabViewModel()
        {
            Products = new List<Product>();
            LoadData();
        }
        private void LoadData()
        {
            Products.Add(new Product(10, "Чайник", 5, 5, 1200, @"/Resources/Images/kettle.png"));
            Products.Add(new Product(10, "LG", 3.1, 10, 12000, @"/Resources/Images/televisor.png"));
            Products.Add(new Product(10, "Колонка", 4.7, 10, 699, @"/Resources/Images/speaker.png"));
            Products.Add(new Product(10, "Чайник", 3.9, 200, 1200, @"/Resources/Images/kettle.png"));
            Products.Add(new Product(10, "Чайник", 2.1, 2, 1200, @"/Resources/Images/kettle.png"));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

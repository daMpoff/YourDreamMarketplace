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
            Products.Add(new Product(10, "Чайник", 5, 1200, @"/Resources/Images/kettle.png"));
            Products.Add(new Product(10, "Чайник", 5, 1200, @"/Resources/Images/kettle.png"));
            Products.Add(new Product(10, "Колонка", 5, 1200, @"/Resources/Images/speaker.png"));
            Products.Add(new Product(10, "Чайник", 5, 1200, @"/Resources/Images/kettle.png"));
            Products.Add(new Product(10, "Чайник", 5, 1200, @"/Resources/Images/kettle.png"));
            Products.Add(new Product(10, "Чайник", 5, 1200, @"/Resources/Images/kettle.png"));
            Products.Add(new Product(10, "Чайник", 5, 1200, @"/Resources/Images/kettle.png"));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

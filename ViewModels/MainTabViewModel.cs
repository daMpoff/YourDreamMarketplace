using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace YourDreamMarketplace
{
    public class MainTabViewModel : INotifyPropertyChanged
    {
        private MySqlContext db;
        public int PageCount { get; set; }
        public ObservableCollection<Product> Products { get; set; }

        public MainTabViewModel()
        {
            Products = new ObservableCollection<Product>();
            LoadData();
        }
        private void LoadData()
        {
            using (db = new MySqlContext())
            {
                db.Database.EnsureCreated();
                //Console.WriteLine(ConfigurationManager.AppSettings
                db.Products.Skip(20 * PageCount).Take(20).Load();//Пропустили 0, так как 0 страница, взяли 20
                Products = db.Products.Local.ToObservableCollection();
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

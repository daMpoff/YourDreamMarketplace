namespace YourDreamMarketplace
{
    public class UserCartViewModel
    {
        List<Product> Products { get; set; }
        public int CountOfProducts { get; set; }
        public UserCartViewModel()
        {
            Products = new List<Product>();
        }
    }
}

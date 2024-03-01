namespace YourDreamMarketplace
{
    public class Product
    {
        private int countOfReviews;
        private double stars;
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public double Stars
        {
            get
            {
                return stars;
            }
            set
            {
                if (value > 0 && value <= 5)
                {
                    stars = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Ошибка, Рейтинг не может быть меньше 0 или меньше 5!");
                }
            }
        }
        public decimal Price { get; set; }
        public string ImgPath { get; set; }
        public int CountOfReviews
        {
            get
            {
                return countOfReviews;
            }
            set
            {
                if (value > 0)
                {
                    countOfReviews = value;
                }
            }
        }
        public List<Review> Reviews { get; set; }
        public Product(string name, double stars, int countOfReviews, decimal price, string imgPath)
        {
            Name = name;
            Stars = stars;
            CountOfReviews = countOfReviews;
            Price = price;
            ImgPath = imgPath;
        }
    }
}

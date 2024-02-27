namespace YourDreamMarketplace
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public short Stars { get; set; }
        public double Price { get; set; }
        public string ImgPath { get; set; }
        public Product(int iD, string name, short stars, double price, string imgPath)
        {
            ID = iD;
            Name = name;
            Stars = stars;
            Price = price;
            ImgPath = imgPath;
        }
    }
}

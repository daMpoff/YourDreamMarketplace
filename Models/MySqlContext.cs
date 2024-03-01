using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace YourDreamMarketplace
{
    public class MySqlContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false).Build();//создали конфиг из конфигурационного файла
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(config.GetConnectionString("DefaultConnection"), ServerVersion.Parse("8.0.36-mysql"));
            }
        }
    }
}

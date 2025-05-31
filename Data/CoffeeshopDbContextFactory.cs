using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CoffeeShop.Data
{
    public class CoffeeshopDbContextFactory : IDesignTimeDbContextFactory<CoffeeshopDbContext>
    {
        public CoffeeshopDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CoffeeshopDbContext>();

            optionsBuilder.UseSqlServer("Server=localhost;Database=CoffeeShopDB;User Id=sa;Password=123456789;Encrypt=False;TrustServerCertificate=True;");

            return new CoffeeshopDbContext(optionsBuilder.Options);
        }
    }
}

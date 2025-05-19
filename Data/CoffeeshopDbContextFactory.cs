using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CoffeeShop.Data
{
    public class CoffeeshopDbContextFactory : IDesignTimeDbContextFactory<CoffeeshopDbContext>
    {
        public CoffeeshopDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CoffeeshopDbContext>();

            optionsBuilder.UseSqlServer("Server=.;Database=CoffeeShopDB;Trusted_Connection=True;");

            return new CoffeeshopDbContext(optionsBuilder.Options);
        }
    }
}

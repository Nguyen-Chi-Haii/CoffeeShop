using CoffeShop.Models.Interfaces;

namespace CoffeShop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private List<Products> ProductsList = new List<Products>()
            {
                new Products { id = 1, name = "Espresso", Detail = "Strong and bold coffee",
                    ImageUrl = "https://www.sessioncoffeedenver.com/wp-content/uploads/2024/04/Perfecting-Espresso-Crema.jpg",
                    Price = 2.50m},
                new Products { id = 2, name = "Latte", Detail = "Smooth and creamy coffee",
                    ImageUrl = "https://th.bing.com/th/id/OIP.VUxwSKRPEaMPzPe6VabR8AHaHa?w=182&h=182&c=7&r=0&o=5&dpr=1.4&pid=1.7",
                    Price = 3.50m, IsTrendingProduct = true },
                new Products { id = 3, name = "Cappuccino", Detail = "Rich and frothy coffee",
                    ImageUrl = "https://th.bing.com/th/id/OIP.vb2cDWdWAors7gq0iQ15RQHaHa?w=210&h=210&c=7&r=0&o=5&dpr=1.4&pid=1.7",
                    Price = 3.00m},
            };

        public IEnumerable<Products> GetAllProducts()
        {
            return ProductsList;
        }

        public Products GetProducsDetail(int id)
        {
            return ProductsList.FirstOrDefault(p => p.id == id);
        }

        public IEnumerable<Products> GetTrendingProducts()
        {
            return ProductsList.Where(p => p.IsTrendingProduct);
        }

        // Fix for CS0535: Implementing the missing method from the interface
        public Products GetProductDetail(int id)
        {
            return ProductsList.FirstOrDefault(p => p.id == id);
        }
    }
}

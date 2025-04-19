namespace CoffeShop.Models
{
    public class Products
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? Detail { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        
        public bool IsTrendingProduct { get; set; }
    }
}

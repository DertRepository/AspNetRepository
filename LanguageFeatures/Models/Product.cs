namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public decimal? Price { get; set; }

        public static Product?[] GetProducts()
        {
            var coca = new Product { Name = "Coca Cola", Price = 12.05M };
            var pepsi = new Product { Name = "Pepsi Sodsa", Price = 22.05M };
            return new Product?[] { coca, pepsi, null };
        }
    }
}
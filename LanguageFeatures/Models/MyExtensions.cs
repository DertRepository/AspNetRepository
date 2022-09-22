namespace LanguageFeatures.Models
{
    public static class MyExtensions
    {
        public static decimal TotalPrices(this ShoppingCart cart)
        {
            decimal total = 0;
            if (cart.Products != null)
            {
                foreach (Product? product in cart.Products)
                {
                    total += product?.Price ?? 0;
                }
            }
            return total;
        }
    }
}
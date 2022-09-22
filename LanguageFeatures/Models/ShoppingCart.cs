namespace LanguageFeatures.Models
{
    public class ShoppingCart : IEnumerable<Product?>
    {
        public IEnumerable<Product?>? Products { get; set; }

        public IEnumerable<Product?> GetEnumerator() => Products?.GetEnumerator()
            ?? Enumerable.Empty<Product?>().GetEnumerator();
        IEnumerable IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
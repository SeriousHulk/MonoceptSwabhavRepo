namespace ShoppingCartModelApp.Model
{
    public class Product
    {
        private const decimal _discountPercenntage = 0.09M;

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPercentage { get { return _discountPercenntage; } }
        public decimal PriceAfterDiscount()
        {
            Price -= Price * DiscountPercentage;
            return Price;
        }
    }
}

namespace ShoppingCartModelApp.Model
{
    public class LineItem
    {
        public LineItem(int id, int quantity, Product product)
        {
            Id = id;
            Quantity = quantity;
            Product = product;
        }

        public int Id { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public decimal CalulateItemCost()
        {
            decimal itemCost = Quantity*Product.PriceAfterDiscount();
            return itemCost;
        }
    }
}

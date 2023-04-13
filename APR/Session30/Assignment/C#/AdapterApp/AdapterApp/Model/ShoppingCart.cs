namespace AdapterApp.Model
{
    public class ShoppingCart
    {
        
        private List<Item> products = new List<Item>();

        public void AddProduct(Item product)
        {
            products.Add(product);
        }
        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (Item item in products)
            {
                totalPrice += item.Price;
            }
            return totalPrice;
            //return products.Sum(p => p.Price);
        }
        public string GetName()
        {
            string totalPrice = null;
            foreach (Item item in products)
            {
                totalPrice = item.Name;
            }
            return totalPrice;
        }
    }
}

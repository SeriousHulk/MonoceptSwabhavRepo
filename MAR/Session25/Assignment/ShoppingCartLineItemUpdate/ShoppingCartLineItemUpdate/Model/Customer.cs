namespace ShoppingCartModelApp.Model
{
    internal class Customer
    {
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
            Orders = new List<Order>();
            LineItems = new List<LineItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
        public List<LineItem> LineItems { get; set; }

        public void AddOrder(Order order) 
        {
            Orders.Add(order);
        }
        
    }
}

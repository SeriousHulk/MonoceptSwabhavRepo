using ShoppingCartModelApp.Model;

namespace ShoppingCartLineItemUpdate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product(001, "Apple", 120.99M);
            var banana = new Product(002, "Banana", 45.79M);
            var orange = new Product(004, "Orange", 81.29M);
            var item1 = new LineItem(101, 3, apple);
            var item2 = new LineItem(102, 3, banana);
            var item3 = new LineItem(104, 3, orange);
            var order = new Order(DateTime.Now, 123);
            order.Add(item1);
            order.Add(item2);
            order.Add(item3);
            order.Add(item1);
            order.Add(item2);
            var customer = new Customer(2356, "John Doe");
            customer.AddOrder(order);
            Console.WriteLine($"Order History for {customer.Name} #{customer.Id}:");
            foreach (var o in customer.Orders)
            {
                Console.WriteLine($"Order ID: #{o.OrderId} | Date: {o.CreatedDate} | Total: {o.CheckoutPrice()}\n");
                foreach (var item in o.dynamicLineItem)
                {
                    Console.WriteLine($"Item :{item.Product.Name} No.of items :{item.Quantity} individual price :{item.Product.Price} Total: {item.CalulateItemCost()}");
                }
                Console.WriteLine();
            }
        }
    }
}
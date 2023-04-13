using ShoppingCartModelApp.Model;

namespace DynamicArray
{
    internal class Program
    {
        public static void Main()
        {
            var apple = new Product(001, "Apple", 120.99M);
            var banana = new Product(002, "Banana", 45.79M);
            var orange = new Product(004, "Orange", 81.29M);
            var item1 = new LineItem(101, 3, apple);
            var item2 = new LineItem(102, 3, banana);
            var item3 = new LineItem(104, 3, orange);
            var order = new Order(DateTime.Now, 786);
            order.Add(item1);
            order.Add(item2);
            order.Add(item3);
            var customer = new Customer(358, "John Doe");
            customer.AddOrder(order);
            Console.WriteLine($"Order History for {customer.Name} #{customer.Id}:");
            foreach (var o in customer.Orders)
            {
                Console.WriteLine($"Order ID: #{o.OrderId} | Date: {o.CreatedDate} | Total: {o.CheckoutPrice()}");
                foreach (var item in o.dynamicLineItem)
                {
                    Console.WriteLine($"{item.Quantity} x {item.Product.Name} @ {item.Product.Price} = {item.CalulateItemCost()}");
                }
                Console.WriteLine();
            }
        }
    }
}
using ShoppingCartModelApp.Model;
using System.Diagnostics;

namespace ShoppingCartModelApp.presentation
{
    internal class PrintToDebugTrace
    {
        public void OrderDetails(Customer customer)
        {
            Debug.WriteLine("Orders are:");
            foreach (Order order in customer.Orders)
            {
                Debug.WriteLine($"Order Id :{order.OrderId}, created on {order.CreatedDate}");
                Debug.WriteLine($"Order Count:{order.Count}");
            }
            //Debug.WriteLine("LineItems are:");
            //foreach (LineItem lineItem in customer.LineItems)
            //{
            //    Debug.WriteLine($"LineItem Id :{lineItem.Id}, name is {lineItem.Product.Name}");
            //    Debug.WriteLine($"Quantity Count:{lineItem.Quantity}");
            //}
        }
    }
}

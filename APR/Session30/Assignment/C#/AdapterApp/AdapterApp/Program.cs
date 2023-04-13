using AdapterApp.Model;
using FancyItemCoreLib;

namespace AdapterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cart = new ShoppingCart();
            cart.AddProduct(new HatAdapter(new Hat("Leather", "Zara Leather Hat", 9.99)));

            Console.WriteLine($"Name of product :{cart.GetName()}\n" +
                $"Total price: {cart.GetTotalPrice()}");
        }
    }
}
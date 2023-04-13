using GenericCollectionApp.Model;
using System.Collections;

namespace GenericCollectionApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<LineItem> dmartCart = new List<LineItem>();
            //ArrayList dmartCart = new ArrayList();
            dmartCart.Add(new LineItem(1, "Parle", 50, 2));
            dmartCart.Add(new LineItem(2, "Garnier", 150, 2));
            dmartCart.Add(new LineItem(3, "Book", 40, 5));
            ViewEachItem(dmartCart);
            PrintTotalCost(dmartCart);
        }

        private static void ViewEachItem(List<LineItem> dmartCart)
        {
            foreach (LineItem item in dmartCart)
            {
                if (item != null)
                    Console.WriteLine($"{item.Name} its price is ({item.UnitPrice}) and quantity ({item.Quantity})");
            }
        }
        private static void PrintTotalCost(List<LineItem> dmartCart)
        {
            double totalCost = 0;
            foreach (LineItem item in dmartCart)
            {
                if (item != null)
                    totalCost += item.ItemCost;
            }
            Console.WriteLine($"\nThe total cost of your Cart :{totalCost}");
        }
    }
}
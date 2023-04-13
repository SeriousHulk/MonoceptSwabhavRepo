using GuitarApp.Model;

namespace GuitarOOAD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            GuitarSpec spec1 = new GuitarSpec(Builder.FENDER, "Stratocaster", GuitarType.ELECTRIC, Wood.ALDER, Wood.ALDER, 6);
            inventory.AddGuitar("0001", 2199.99, spec1);

            GuitarSpec spec2 = new GuitarSpec(Builder.GIBSON, "Les Paul Standard", GuitarType.ELECTRIC, Wood.MAPLE, Wood.MAHOGANY, 6);
            inventory.AddGuitar("0002",999.99, spec2);

            GuitarSpec spec3 = new GuitarSpec(Builder.MARTIN, "D-28", GuitarType.ACOUSTIC, Wood.SITKA, Wood.ROSEWOOD, 6);
            inventory.AddGuitar("0003", 1999.99, spec3);

            GuitarSpec searchSpec = new GuitarSpec(Builder.MARTIN, "D-28", GuitarType.ACOUSTIC, Wood.SITKA, Wood.ROSEWOOD, 6);
            List<Guitar> matches = inventory.Search(searchSpec);

            Console.WriteLine("Search Results:");
            foreach (Guitar match in matches)
            {
                Console.WriteLine(match.ToString());
            }
        }
    }
}
using GuitarApp.Model;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;

namespace GuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            // Add some guitars to the inventory
            GuitarSpecBuilder specBuilder = new GuitarSpecBuilder();
            GuitarSpec spec1 = specBuilder
                .Builder(Builder.FENDER)
                .Model("Stratocaster")
                .Type(GuitarType.ELECTRIC)
                .NumStrings(6)
                .TopWood(Wood.ALDER)
                .BackWood(Wood.ALDER)
                .Build();
            inventory.AddGuitar("V00001", 1499.99, spec1);

            GuitarSpec spec2 = specBuilder
                .Builder(Builder.GIBSON)
                .Model("Les Paul Standard")
                .Type(GuitarType.ELECTRIC)
                .NumStrings(6)
                .TopWood(Wood.MAPLE)
                .BackWood(Wood.MAHOGANY)
                .Build();
            inventory.AddGuitar("V00002", 1999.99, spec2);

            GuitarSpec spec3 = specBuilder
                .Builder(Builder.MARTIN)
                .Model("D-28")
                .Type(GuitarType.ACOUSTIC)
                .NumStrings(6)
                .TopWood(Wood.SITKA)
                .BackWood(Wood.ROSEWOOD)
                .Build();
            inventory.AddGuitar("V00003", 2999.99, spec3);

            // Search for guitars with certain specifications
            GuitarSpec searchSpec = specBuilder
                .Builder(Builder.FENDER)
                .Type(GuitarType.ELECTRIC)
                .TopWood(Wood.ALDER)
                .Build();
            List<Guitar> matches = inventory.Search(searchSpec);

            // Print out the search results
            Console.WriteLine("Search Results:");
            foreach (Guitar match in matches)
            {
                Console.WriteLine(match.ToString());
            }

        }
    }
}
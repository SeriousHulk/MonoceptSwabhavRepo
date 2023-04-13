using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    internal class Inventory
    {
        private LinkedList<Guitar> inventory;
        public Inventory() { inventory = new LinkedList<Guitar>(); }
        List<Guitar> guitars = new List<Guitar>();
        public void AddGuitar(string serialNumber, double price, GuitarSpec spec) {
            Guitar guitar = new Guitar(serialNumber, price, spec);
            inventory.AddLast(guitar);
        }
        public Guitar Get(string serialNumber)
        {
            foreach (Guitar guitar in inventory)
            {
                if (guitar.GetSerialNumber() == serialNumber)
                {
                    return guitar;
                }
            }
            return null;
        }
        public List<Guitar> Search(GuitarSpec guitar) {
            List<Guitar> matches = new List<Guitar>();
            foreach (Guitar guitarList in inventory)
            {
                if (guitarList.GetSpec().Equals(guitar))
                {
                    matches.Add(guitarList);
                }
            }
            return matches.Count == 0 ? new List<Guitar>() : new List<Guitar>(matches);
        }
    }
}

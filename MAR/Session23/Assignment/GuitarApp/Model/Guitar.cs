using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    internal class Guitar
    {
        private readonly double _price;
        private readonly string _serialNumber;
        private readonly GuitarSpec _spec;
        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            _serialNumber = serialNumber;
            _price = price;
            _spec = spec;
        }
        public string GetSerialNumber() { return _serialNumber; }
        public double GetPrice() { return _price; }
        //public GetPrice(float price) { }
        public GuitarSpec GetSpec() { return _spec; }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(_serialNumber)
                .Append(_price)
                .Append(_spec);

            return builder.ToString();
        }
    }
}

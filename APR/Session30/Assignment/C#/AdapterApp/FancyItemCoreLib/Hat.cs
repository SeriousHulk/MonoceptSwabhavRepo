using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyItemCoreLib
{
    public class Hat
    {
        private string _shortName;
        private string _longName;
        private double _price;
        private double _gst;

        public Hat(string shortName, string longName, double price)
        {
            _shortName = shortName;
            _longName = longName;
            _price = price;
            _gst = price*.08;
        }
        public string GetShortName()
        {
            return _shortName;
        }
        public string GetLongName()
        {
            return _longName;
        }
        public double GetPrice()
        {
            return _price = _price * _gst;
        }
    }
}

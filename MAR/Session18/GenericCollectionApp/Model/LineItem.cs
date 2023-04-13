using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionApp.Model
{
    internal class LineItem
    {
        private int _id;
        private string _name;
        private double _unitPrice;
        private int _quantity;
        public LineItem(int id, string name, double unitPrice, int quantity)
        {
            _id = id;
            _name = name;
            _unitPrice = unitPrice;
            _quantity = quantity;
        }
        public double ItemCost { get { return  _quantity*_unitPrice; } }
        
        public int Id { get { return _id;} }
        public string Name { get { return _name;} }
        public double UnitPrice { get { return _unitPrice;} }
        public int Quantity { get { return _quantity;} }
    }
}

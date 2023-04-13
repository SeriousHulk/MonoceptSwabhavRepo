using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactorApp.Model
{
    internal class Invoice
    {
        private readonly int _id;
        private readonly string _description;
        private readonly double _discount;
        private readonly double _cost;
        private const double TAX = .10;

        public object Id { get { return _id; } }
        public object Description { get { return _description; } }
        public object Cost { get { return _cost; } }
        public Invoice(int id, string description, double discount, double cost)
        {
            _id = id;
            _description = description;
            _discount = discount;
            _cost = cost;
        }
        public double CalculateTax()
        {
            return _cost * TAX;
        }
        public double CalculateDiscount()
        {
            return _cost * _discount;
        }
        public double CalculateFinalCost() { return _cost + CalculateTax() - CalculateDiscount(); }
        
    }
}

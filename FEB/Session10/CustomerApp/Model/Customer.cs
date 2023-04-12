using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Model
{
    internal class Customer
    {
        private int _id;
        private string _name;
        private static int _orderCount;
        private static int _nextId;
        static Customer()
        {
            _nextId = 1000;
            Random random = new Random();
            int num = random.Next(33333,44444);
            _orderCount = num;
        }
        public Customer(string name) 
        {
            _nextId++;
            _id = _nextId;
            _name = name;
            _orderCount++;
        }
        public int Id { get { return _id; } }  
        public string Name { get { return _name;} set { _name = value; } }  
        public int OrderCount { get { return _orderCount; } }
    }
}

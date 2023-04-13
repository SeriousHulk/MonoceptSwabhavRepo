using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLib.Model
{
    [Serializable]
    public class Customer
    {
        private int _id;
        private string _name;
        private int _ordersPlaced;
        private long _contactNo;
        public Customer() { }
        public Customer(int id, string name, int ordersPlaced, long contactNo)
        {
            _id = id;
            _name = name;
            _ordersPlaced = ordersPlaced;
            _contactNo = contactNo;
        }
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name;} set { _name = value; } }
        public int OrdersPlaced { get { return _ordersPlaced; } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartModelApp.Model
{
    internal class Order
    {
        private int _COUNT = 0;
        public int Count { get { return _COUNT; } }
        public DateTime CreatedDate {  get; set; }
        public int OrderId { get; set; }
        public List<LineItem> Items;

        public Order(DateTime createdDate, int orderId)
        {
            CreatedDate = createdDate;
            OrderId = orderId;
            Items = new List<LineItem>() ;
        }

        public void Add(LineItem lineItem)
        {
            Items.Add(lineItem);
            _COUNT++;
        }
        public decimal CheckoutPrice() 
        {
            decimal checkOutPrice =0;
            foreach (LineItem lineItem in Items)
            {
                checkOutPrice += lineItem.CalulateItemCost();
            }
            return checkOutPrice;
        }

    }
}

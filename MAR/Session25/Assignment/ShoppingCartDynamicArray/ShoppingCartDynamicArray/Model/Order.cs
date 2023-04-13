using ShoppingCartDynamicArray.Model;
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
        public DynamicArray<LineItem> dynamicLineItem;

        public Order(DateTime createdDate, int orderId)
        {
            CreatedDate = createdDate;
            OrderId = orderId;
            dynamicLineItem = new DynamicArray<LineItem>();
        }

        public void Add(LineItem lineItem)
        {
            dynamicLineItem.Add(lineItem);
            _COUNT++;
        }
        public decimal CheckoutPrice() 
        {
            decimal checkOutPrice =0;
            foreach (LineItem line in dynamicLineItem)
            {
                checkOutPrice += line.CalulateItemCost();
            }
            return checkOutPrice;
        }

    }
}

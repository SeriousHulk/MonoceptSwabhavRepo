using ShoppingCartDynamicArray.Model;
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
            foreach (LineItem item in dynamicLineItem)
            {
                if (item.Id == lineItem.Id)
                {
                    item.Quantity += lineItem.Quantity;
                    return;
                }
            }
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

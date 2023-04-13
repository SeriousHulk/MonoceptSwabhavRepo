using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartModelApp.Model;
using ShoppingCartModelApp.presentation;

namespace ShoppingCartModelApp
{
    [TestClass]
    public class ShoppingCartModelUnitTest
    {
        [TestMethod]
        public void Product_class_should_create_proper_product_object()
        {
            Product mobile = new Product(2023, "iPhone 14", 799.99M);
            decimal expectedPrice = 799.99M;
            Assert.AreEqual(expectedPrice, mobile.Price);
        }
        [TestMethod]
        public void LineItem_class_should_create_proper_LineItem_object()
        {
            Product mobile = new Product(2023, "iPhone 14", 799.99M);
            LineItem mobiles = new LineItem(2023, 10, mobile);
            int expectedId = 2023;
            Assert.AreEqual(expectedId, mobiles.Id);
        }
        [TestMethod]
        public void Order_class_should_create_proper_Order_object()
        {
            Product mobile = new Product(2023, "iPhone 14", 799.99M);
            LineItem mobiles = new LineItem(2023, 10, mobile);
            Order order = new Order(DateTime.Now, 1001);
            order.Add(mobiles);
            decimal expectedPrice = 7279.909M;
            Assert.AreEqual(expectedPrice, order.CheckoutPrice());
        }
        [TestMethod]
        public void Customer_class_should_create_proper_product_object()
        {
            Product mobile = new Product(2023, "iPhone 14", 799.99M);
            LineItem mobiles = new LineItem(2023, 10, mobile);
            Order order = new Order(DateTime.Now, 1001);
            Product book = new Product(2018, "ikigai", 90);
            LineItem books = new LineItem(2018, 10, book);
            order.Add(books);
            order.Add(mobiles);
            Customer vikrant = new Customer(1, "Vikrant");
            vikrant.AddOrder(order);
            decimal expectedPrice = 8098.9090M;
            PrintToDebugTrace printToDebugTrace = new PrintToDebugTrace();
            printToDebugTrace.OrderDetails(vikrant);
            Assert.AreEqual(expectedPrice, order.CheckoutPrice());
        }
        [TestMethod]
        public void Product_class_should_return_proper_product_properties()
        {
            Product mobile = new Product(2023, "iPhone 14", 799.99M);
            string expectedName = "iPhone 14";
            int expectedId = 2023;
            decimal expectedPrice = 799.99M;
            Assert.AreEqual(expectedId, mobile.Id);
            Assert.AreEqual(expectedName, mobile.Name);
            Assert.AreEqual(expectedPrice, mobile.Price);
        }
        [TestMethod]
        public void LineItem_class_should_return_proper_LineItem_properties()
        {
            Product mobile = new Product(2023, "iPhone 14", 799.99M);
            LineItem mobiles = new LineItem(2023, 10, mobile);
            string expectedName = "iPhone 14";
            int expectedId = 2023;
            int expectedQuantity = 10;
            Assert.AreEqual(expectedId, mobiles.Id);
            Assert.AreEqual(expectedName, mobiles.Product.Name);
            Assert.AreEqual(expectedQuantity, mobiles.Quantity);
        }
        [TestMethod]
        public void Order_class_should_return_proper_Order_properties()
        {
            Product mobile = new Product(2023, "iPhone 14", 799.99M);
            LineItem mobiles = new LineItem(2023, 10, mobile);
            Order order = new Order(DateTime.Now, 1001);
            order.Add(mobiles);
            int expectedId = 1001;
            int expectedQuantity = 1;
            Assert.AreEqual(expectedId, order.OrderId);
            Assert.AreEqual(expectedQuantity, order.Count);
        }

        [TestMethod]
        public void PriceAfterDiscount_should_return_proper_product_price()
        {
            Product mobile = new Product(2023, "iPhone 14", 799.99M);
            decimal expectedPrice = 727.9909M;
            Assert.AreEqual(expectedPrice, mobile.PriceAfterDiscount());
        }
        [TestMethod]
        public void CalulateItemCost_should_return_total_LineItem_price()
        {
            Product mobile = new Product(2023, "iPhone 14", 799.99M);
            LineItem mobiles = new LineItem(2023, 10, mobile);
            decimal expectedPrice = 7279.909M;
            Assert.AreEqual(expectedPrice, mobiles.CalulateItemCost());
        }
        [TestMethod]
        public void CheckoutPrice_should_return_Total_Order_price()
        {
            Product mobile = new Product(2023, "iPhone 14", 799);
            LineItem mobiles = new LineItem(2023, 10, mobile);
            Product book = new Product(2018, "ikigai", 90);
            LineItem books = new LineItem(2018, 10, book);
            Order order = new Order(DateTime.Now, 1001);
            order.Add(mobiles);
            order.Add(books);
            //double expectedPrice = 7279.909;
            decimal expectedPrice = 8089.90M;
            Assert.AreEqual(expectedPrice, order.CheckoutPrice());
        }
    }
}
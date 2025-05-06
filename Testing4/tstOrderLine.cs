using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK1()
        {
            // create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            // test that it exists
            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void OrderLineIDPropertyOK()
        {
            clsOrderLine AnOrder = new clsOrderLine();
            int TestData = 1;
            AnOrder.OrderLineID = TestData;
            Assert.AreEqual(AnOrder.OrderLineID, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrderLine AnOrder = new clsOrderLine();
            int TestData = 1;
            AnOrder.OrderID = TestData;
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void StockIDPropertyOK()
        {
            clsOrderLine AnOrder = new clsOrderLine();
            int TestData = 1;
            AnOrder.StockID = TestData;
            Assert.AreEqual(AnOrder.StockID, TestData);
        }

        [TestMethod]
        public void ProductNamePropertyOK()
        {
            clsOrderLine AnOrder = new clsOrderLine();
            string TestData = "Test Product";
            AnOrder.ProductName = TestData;
            Assert.AreEqual(AnOrder.ProductName, TestData);
        }

        [TestMethod]
        public void DispatchDatePropertyOK()
        {
            clsOrderLine AnOrder = new clsOrderLine();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.DispatchDate = TestData;
            Assert.AreEqual(AnOrder.DispatchDate, TestData);
        }

        [TestMethod]
        public void UnitPricePropertyOK()
        {
            clsOrderLine AnOrder = new clsOrderLine();
            decimal TestData = 19.99m;
            AnOrder.UnitPrice = TestData;
            Assert.AreEqual(AnOrder.UnitPrice, TestData);
        }

        [TestMethod]
        public void IsBackOrderedPropertyOK()
        {
            clsOrderLine AnOrder = new clsOrderLine();
            Boolean TestData = true;
            AnOrder.IsBackOrdered = TestData;
            Assert.AreEqual(AnOrder.IsBackOrdered, TestData);
        }
    }
}

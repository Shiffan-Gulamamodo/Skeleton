using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderID = 1;
            TestItem.StaffID = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderLineID = 1;
            TestItem.CustomerID = 1;
            TestItem.IsPaid = true;
            TestItem.DeliveryAddress = "123 Test St";
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderID = 1;
            TestOrder.StaffID = 1;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.OrderLineID = 1;
            TestOrder.CustomerID = 1;
            TestOrder.IsPaid = true;
            TestOrder.DeliveryAddress = "123 Test St";
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderID = 1;
            TestItem.StaffID = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderLineID = 1;
            TestItem.CustomerID = 1;
            TestItem.IsPaid = true;
            TestItem.DeliveryAddress = "123 Test St";
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        
    }
}

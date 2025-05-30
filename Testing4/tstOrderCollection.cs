﻿using System;
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

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.StaffID = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderLineID = 1;
            TestItem.CustomerID = 1;
            TestItem.IsPaid = true;
            TestItem.DeliveryAddress = "123 Test St";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            TestItem.StaffID = 2;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderLineID = 2;  
            TestItem.CustomerID = 2;
            TestItem.IsPaid = false;
            TestItem.DeliveryAddress = "456 Test St";
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.StaffID = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderLineID = 1;
            TestItem.CustomerID = 1;
            TestItem.IsPaid = true;
            TestItem.DeliveryAddress = "123 Test St";
            TestItem.OrderID = 1;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        
        [TestMethod]
        public void ReportByDeliveryAddressMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByDeliveryAddress("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByDeliveryAddressNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByDeliveryAddress("xxx xxxx xx");
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByDeliveryAddressTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByDeliveryAddress("123 Test St");
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].OrderID != 6 || FilteredOrders.OrderList[1].OrderID != 121)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}

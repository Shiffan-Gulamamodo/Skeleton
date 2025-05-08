using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.OrderID = TestData;
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.StaffID = TestData;
            Assert.AreEqual(AnOrder.StaffID, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.CustomerID = TestData;
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void IsPaidPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.IsPaid = TestData;
            Assert.AreEqual(AnOrder.IsPaid, TestData);
        }

        [TestMethod]
        public void DeliveryAddressPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "123 Main St";
            AnOrder.DeliveryAddress = TestData;
            Assert.AreEqual(AnOrder.DeliveryAddress, TestData);
        }

        [TestMethod]
        public void OrderLineIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.OrderLineID = TestData;
            Assert.AreEqual(AnOrder.OrderLineID, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method

            int OrderID = 1;

            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestOrderIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.StaffID != 101)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderDate != Convert.ToDateTime("01/05/2025"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.CustomerID != 1001)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsPaidFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.IsPaid != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderLineIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderLineID != 5001)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryAddressFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.DeliveryAddress != "123 Main St")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}

using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class TestingSupplier
    {
        private const bool v = true;

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(ASupplier);
        }

        [TestMethod]
        public void IsAvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            bool TestData = true;  // Change to match your actual test data for availability
                                   //assign the data to the property
            ASupplier.IsAvailable = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.IsAvailable, TestData);
        }

        [TestMethod]
        public void StockIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            int TestData = 1;  // Test value for StockID
                               //assign the data to the property
            ASupplier.StockID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.StockID, TestData);
        }

        [TestMethod]
        public void SupplyIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            int TestData = 1;  // Test value for SupplyId (identity column)
                               //assign the data to the property
            ASupplier.SupplyId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplyId, TestData);
        }

        [TestMethod]
        public void PhoneNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "iPhone 14 Pro Max";  // Test value for PhoneName
                                                    //assign the data to the property
            ASupplier.PhoneName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.PhoneName, TestData);
        }

        [TestMethod]
        public void DeliveryDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now;  // Test value for DeliveryDate
                                               //assign the data to the property
            ASupplier.DeliveryDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.DeliveryDate, TestData);
        }
    }
}

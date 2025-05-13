using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class TestingSupplier
    {

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
            Boolean TestData = true;  // Change to match your actual test data for availability
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

        //Creating Method tests for Supplier 
        [TestMethod]
        public void FindMethodOk()
        {
            //Create an instance of the class Supplier 
            clsSupplier ASupplier = new clsSupplier();
            //Create a Boolean Variable to store the results of the validation 
            Boolean Found = false;
            //Create Some test data to use with the method 
            Int32 SupplyId = 4;
            //Invoke the method 
            Found = ASupplier.Find(SupplyId);
            //Test to see if the result is true 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSupplyIdFound()
        {
            //Create an instance of the class Supplier 
            clsSupplier ASupplier = new clsSupplier();
            //Create a Boolean Variable to store the results of the validation 
            Boolean Found = false;
            //Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create Some test data to use with the method 
            Int32 SupplyId = 4;
            //Invoke the method 
            Found = ASupplier.Find(SupplyId);
            //Checking the Address Id 
            if (ASupplier.SupplyId != 4)
            {
                OK = false;
            }
            //Test to see if the result is true 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryDateFound()
        {
            //Create an instance of the class Supplier 
            clsSupplier ASupplier = new clsSupplier();
            //Create a Boolean Variable to store the results of the search
            Boolean Found = false;
            //Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create Some test data to use with the method 
            Int32 SupplyId = 4;
            //Invoke the method 
            Found = ASupplier.Find(SupplyId);
            //Checking the Address Id 
            if (ASupplier.DeliveryDate != Convert.ToDateTime("25/05/2025 00:00:00"))
            {
                OK = false;
            }
            //Test to see if the result is true 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsAvailableFound()
        {
            //Create an instance of the class Supplier
            clsSupplier ASupplier = new clsSupplier();
            //Create a Boolean Variable to store the results of the search
            Boolean Found = false;
            //Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create Some test data to use with the method 
            Int32 SupplyId = 4;
            //Invoke the method 
            Found = ASupplier.Find(SupplyId);
            //check the active property
            if (ASupplier.IsAvailable != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNameFound()
        {
            //Create an instance of the class Supplier 
            clsSupplier ASupplier = new clsSupplier();
            //Create a Boolean Variable to store the results of the search
            Boolean Found = false;
            //Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create Some test data to use with the method 
            Int32 SupplyId = 4;
            //Invoke the method 
            Found = ASupplier.Find(SupplyId);
            //check the street property
            if (ASupplier.PhoneName!= "Iphone 14")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockIdFound()
        {
            //Create an instance of the class Supplier 
            clsSupplier ASupplier = new clsSupplier();
            //Create a Boolean Variable to store the results of the validation 
            Boolean Found = false;
            //Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create Some test data to use with the method 
            Int32 SupplyId = 4;
            //Invoke the method 
            Found = ASupplier.Find(SupplyId);
            //Checking the Address Id 
            if (ASupplier.StockID != 3)
            {
                OK = false;
            }
            //Test to see if the result is true 
            Assert.IsTrue(OK);
        }




    }
}

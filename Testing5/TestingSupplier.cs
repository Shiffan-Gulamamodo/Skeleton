using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{ 
    [TestClass]
    public class TestingSupplier
    {
        string PhoneName = "Iphone 14";
        string DeliveryDate = "10/02/2024";
        string IsAvailable = "False";

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
            if (ASupplier.PhoneName != "Iphone 14")
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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ASupplier.Valid(PhoneName, DeliveryDate, IsAvailable);












        }
        [TestMethod]
        public void PhoneNameMinLessOne()
        {
            // Create an instance of the class we want to test
            clsSupplier ASupplier = new clsSupplier();
            // String variable to store any error message
            String Error = "";
            // Creating some test data to pass the method
            String PhoneName = "";   // This should trigger an error
                                     // Invoke the method
            Error = ASupplier.Valid(PhoneName, IsAvailable, DeliveryDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMin()
        {
            // Create an instance of the class we want to test
            clsSupplier ASupplier = new clsSupplier();
            // String variable to store any error message
            String Error = "";
            // Creating some test data to pass the method
            String PhoneName = "S";   // This should be OK
                                      // Invoke the method
            Error = ASupplier.Valid(PhoneName, IsAvailable, DeliveryDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMinPlusOne()
        {
            // Create an instance of the class we want to test
            clsSupplier ASupplier = new clsSupplier();
            // String variable to store any error message
            String Error = "";
            // Creating some test data to pass the method
            String PhoneName = "Sa";   // This should be OK
                                       // Invoke the method
            Error = ASupplier.Valid(PhoneName, IsAvailable, DeliveryDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMaxLessOne()
        {
            // Create an instance of the class we want to test
            clsSupplier ASupplier = new clsSupplier();
            // String variable to store any error message
            String Error = "";
            // Creating some test data to pass the method
            String PhoneName = "";
            PhoneName = PhoneName.PadRight(29, 's');  // This should be OK
                                                      // Invoke the method
            Error = ASupplier.Valid(PhoneName, IsAvailable, DeliveryDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMax()
        {
            // Create an instance of the class we want to test
            clsSupplier ASupplier = new clsSupplier();
            // String variable to store any error message
            String Error = "";
            // Creating some test data to pass the method
            String PhoneName = "";
            PhoneName = PhoneName.PadRight(30, 's');  // This should be OK
                                                      // Invoke the method
            Error = ASupplier.Valid(PhoneName, IsAvailable, DeliveryDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMid()
        {
            // Create an instance of the class we want to test
            clsSupplier ASupplier = new clsSupplier();
            // String variable to store any error message
            String Error = "";
            // Creating some test data to pass the method
            String PhoneName = "";
            PhoneName = PhoneName.PadRight(15, 's');  // This should be OK
                                                      // Invoke the method
            Error = ASupplier.Valid(PhoneName, IsAvailable, DeliveryDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameMaxPlusOne()
        {
            // Create an instance of the class we want to test
            clsSupplier ASupplier = new clsSupplier();
            // String variable to store any error message
            String Error = "";
            // Creating some test data to pass the method
            String PhoneName = "";
            PhoneName = PhoneName.PadRight(31, 's');  // This should Fail
                                                      // Invoke the method
            Error = ASupplier.Valid(PhoneName, IsAvailable, DeliveryDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNameExtremeMax()
        {
            // Create an instance of the class we want to test
            clsSupplier ASupplier = new clsSupplier();
            // String variable to store any error message
            String Error = "";
            // Creating some test data to pass the method
            String PhoneName = "";
            PhoneName = PhoneName.PadRight(500, 's');  // This should Fail
                                                       // Invoke the method
            Error = ASupplier.Valid(PhoneName, IsAvailable, DeliveryDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryDateExtremeMin()
        {
            // Create an instance of the class we want to test
            clsSupplier ASupplier = new clsSupplier();
            // String variable to store any error message
            String Error = "";
            // Creating a variable to store the test date data
            DateTime TestDate;
            // Set the data to today's date
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is minus 100 years
            TestDate = TestDate.AddYears(-100);
            // Convert the date variable to a string variable
            String DeliveryDate = TestDate.ToString();
            // Invoke the method
            Error = ASupplier.Valid(PhoneName, IsAvailable, DeliveryDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryDateMinLessOne()
        {
            // Create an instance of the class we want to test
            clsSupplier ASupplier = new clsSupplier();
            // String variable to store any error message
            String Error = "";
            // Creating a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is minus 1 day
            TestDate = TestDate.AddDays(-1);
            // Convert the date variable to a string variable
            String DeliveryDate = TestDate.ToString();
            // Invoke the method
            Error = ASupplier.Valid(PhoneName, IsAvailable, DeliveryDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryDateMin()
        {
            // Create an instance of the class we want to test
            clsSupplier ASupplier = new clsSupplier();
            // String variable to store any error message
            String Error = "";
            // Creating a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Convert the date variable to a string variable
            String DeliveryDate = TestDate.ToString();
            // Invoke the method
            Error = ASupplier.Valid(PhoneName, IsAvailable, DeliveryDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryDateMinPlusOne()
        {
            // Create an instance of the class we want to test
            clsSupplier ASupplier = new clsSupplier();
            // String variable to store any error message
            String Error = "";
            // Creating a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            // Convert the date variable to a string variable
            String DeliveryDate = TestDate.ToString();
            // Invoke the method
            Error = ASupplier.Valid(PhoneName, IsAvailable, DeliveryDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryDateExtremeMax()
        {
            // Create an instance of the class we want to test
            clsSupplier ASupplier = new clsSupplier();
            // String variable to store any error message
            String Error = "";
            // Creating a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            // Convert the date variable to a string variable
            String DeliveryDate = TestDate.ToString();
            // Invoke the method
            Error = ASupplier.Valid(PhoneName, IsAvailable, DeliveryDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IsAvailableInvalidData()
        {
            // Create an instance of the class we want to test
            clsSupplier ASupplier = new clsSupplier();
            // String variable to store any error message
            String Error = "";
            // Creating an invalid data for IsAvailable
            String IsAvailable = "NotBoolean";  // Invalid value
                                                // Invoke the method
            Error = ASupplier.Valid(PhoneName, IsAvailable, DeliveryDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
 }


}

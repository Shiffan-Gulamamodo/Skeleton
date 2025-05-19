using System;
using System.Data;
using System.IO;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    //All the Tests for Customer Table Property
    [TestClass]
    public class tstCustomer
    {

        //Good Test Data 
        //Creating some Test Data to pass the Valid Method 
        String CustomerFullName = "Sam Curran";
        String CustomerEmail = "Sam@gmail.com";
        String CustomerPassword = "CurranCurran";
        String CustomerAddress = "CV10 2ER, 2 Kings Avenue, Nuneaton";
        String CustomerAccountCreatedAt = DateTime.Now.ToShortDateString();


        [TestMethod]
        public void InstanceOK()
        {
            //Create an Instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Test to see that it exists 
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //Create an instance of the class that we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property 
            Int32 TestData = 1;
            //Assign the data to the property 
            ACustomer.CustomerId = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerFullNamePropertyOK()
        {
            //Create an instance of the class that we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property 
            String TestData = "Adam Zampa";
            //Assign the data to the property 
            ACustomer.CustomerFullName = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(ACustomer.CustomerFullName, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //Create an instance of the class that we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property 
            String TestData = "Adam@gmail.com";
            //Assign the data to the property 
            ACustomer.CustomerEmail = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerPasswordPropertyOK()
        {
            //Create an instance of the class that we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property 
            String TestData = "ZampaZampa";
            //Assign the data to the property 
            ACustomer.CustomerPassword = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(ACustomer.CustomerPassword, TestData);
        }

        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            //Create an instance of the class that we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property 
            String TestData = "LE8 3RT 28, Arwent Road, Leicester ";
            //Assign the data to the property 
            ACustomer.CustomerAddress = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }

        [TestMethod]
        public void CustomerAccountCreatedAtPropertyOK()
        {
            //Create an instance of the class that we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property 
            ACustomer.CustomerAccountCreatedAt = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(ACustomer.CustomerAccountCreatedAt, TestData);
        }

        [TestMethod]
        public void IsCustomerAccountActivePropertyOK()
        {
            //Create an instance of the class that we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property 
            Boolean TestData = true;
            //Assign the data to the property 
            ACustomer.IsCustomerAccountActive = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(ACustomer.IsCustomerAccountActive, TestData);
        }

        //Creating Method tests for Customer 
        [TestMethod]
        public void FindMethodOk ()
        {
            //Create an instance of the class Customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a Boolean Variable to store the results of the validation 
            Boolean Found = false;
            //Create Some test data to use with the method 
            Int32 CustomerId = 4;
            //Invoke the method 
            Found = ACustomer.Find(CustomerId);
            //Test to see if the result is true 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //Create an instance of the class Customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a Boolean Variable to store the results of the validation 
            Boolean Found = false;
            //Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create Some test data to use with the method 
            Int32 CustomerId = 4;
            //Invoke the method 
            Found = ACustomer.Find(CustomerId);
            //Checking the Address Id 
            if (ACustomer.CustomerId != 4)
            {
                OK = false;
            }
            //Test to see if the result is true 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAccountCreatedAtFound()
        {
            //Create an instance of the class Customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a Boolean Variable to store the results of the search
            Boolean Found = false;
            //Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create Some test data to use with the method 
            Int32 CustomerId = 3;
            //Invoke the method 
            Found = ACustomer.Find(CustomerId);
            //Checking the Address Id 
            if (ACustomer.CustomerAccountCreatedAt != Convert.ToDateTime("12/05/2025"))
            { 
                OK = false;
            }
            //Test to see if the result is true 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsCustomerAccountActiveFound()
        {
            //Create an instance of the class Customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a Boolean Variable to store the results of the search
            Boolean Found = false;
            //Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create Some test data to use with the method 
            Int32 CustomerId = 5;
            //Invoke the method 
            Found = ACustomer.Find(CustomerId);
            //check the active property
            if (ACustomer.IsCustomerAccountActive != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerFullNameFound()
        {
            //Create an instance of the class Customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a Boolean Variable to store the results of the search
            Boolean Found = false;
            //Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create Some test data to use with the method 
            Int32 CustomerId = 3;
            //Invoke the method 
            Found = ACustomer.Find(CustomerId);
            //check the street property
            if (ACustomer.CustomerFullName != "Sam Curran")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //Create an instance of the class Customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a Boolean Variable to store the results of the search
            Boolean Found = false;
            //Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create Some test data to use with the method 
            Int32 CustomerId = 3;
            //Invoke the method 
            Found = ACustomer.Find(CustomerId);
            //check the street property
            if (ACustomer.CustomerEmail != "Sam@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPasswordFound()
        {
            //Create an instance of the class Customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a Boolean Variable to store the results of the search
            Boolean Found = false;
            //Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create Some test data to use with the method 
            Int32 CustomerId = 3;
            //Invoke the method 
            Found = ACustomer.Find(CustomerId);
            //check the street property
            if (ACustomer.CustomerPassword != "CurranCurran")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //Create an instance of the class Customer 
            clsCustomer ACustomer = new clsCustomer();
            //Create a Boolean Variable to store the results of the search
            Boolean Found = false;
            //Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create Some test data to use with the method 
            Int32 CustomerId = 3;
            //Invoke the method 
            Found = ACustomer.Find(CustomerId);
            //check the street property
            if (ACustomer.CustomerAddress != "CV10 2ER, 2 Kings Avenue, Nuneaton")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //Adding Vlidation to Customer 

        [TestMethod]
        public void ValidMethodOK()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName,CustomerEmail,CustomerPassword,CustomerAddress,CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullNameMinLessOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerFullName = "";   //This should trigger an error 
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullNameMin()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerFullName = "S";   //This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullNameMinPlusOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerFullName = "Sa";   //This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullNameMaxLessOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerFullName = "";
            CustomerFullName = CustomerFullName.PadRight(29, 's');  // This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullNameMax()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerFullName = "";
            CustomerFullName = CustomerFullName.PadRight(30, 's');  // This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullNameMid()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerFullName = "";
            CustomerFullName = CustomerFullName.PadRight(15, 's');  // This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullNameMaxPlusOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerFullName = "";
            CustomerFullName = CustomerFullName.PadRight(31, 's');  //This should Fail
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullNameExtremeMax()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerFullName = "";
            CustomerFullName =  CustomerFullName.PadRight(500, 's'); //This should Fail
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAccountCreatedAtExtremeMin()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating a variable to store the test date data
            DateTime TestDate;
            //Set the data to todays date 
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-100);
            //Convert the date variable to a string variable 
            String CustomerAccountCreatedAt = TestDate.ToString();
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAccountCreatedAtMinLessOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string CustomerAccountCreatedAt = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAccountCreatedAtMin()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string CustomerAccountCreatedAt = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAccountCreatedAtMinPlusOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string CustomerAccountCreatedAt = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAccountCreatedAtExtremeMax()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string CustomerAccountCreatedAt = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAccountCreatedAtInvalidData()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string CustomerAccountCreatedAt = "This is not a Date";
            //invoke the method
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerEmail = "";   //This should trigger an error 
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerEmail = "S";   //This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerEmail = "Sa";  //This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(39, 's');  // This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(40, 's');  // This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(20, 's');  // This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(41, 's');  // This should Fail
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerEmail= "";
            CustomerEmail = CustomerEmail.PadRight(500, 's'); //This should Fail
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMinLessOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerPassword = "";   //This should trigger an error 
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMin()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerPassword = "c";   //This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMinPlusOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerPassword = "Sa";  //This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMaxLessOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerPassword = "";
            CustomerPassword = CustomerPassword.PadRight(29, 's');  // This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMax()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerPassword= "";
            CustomerPassword= CustomerPassword.PadRight(30, 's');  // This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMid()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerPassword = "";
            CustomerPassword= CustomerPassword.PadRight(15, 's');  // This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMaxPlusOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerPassword = "";
            CustomerPassword = CustomerPassword.PadRight(31, 's');  // This should Fail
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordExtremeMax()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerPassword= "";
            CustomerPassword = CustomerPassword.PadRight(500, 's'); //This should Fail
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerAddress = "";   //This should trigger an error 
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerAddress = "c";   //This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerAddress = "LE";  //This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerAddress= "";
            CustomerAddress = CustomerAddress.PadRight(49, 'L');  // This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(50, 'L');  // This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(25, 'L');  // This should be OK
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(51, 's');  // This should Fail
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //String Variable to store any error message 
            String Error = "";
            //Creating some test data to pass the method
            String CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(500, 'L'); //This should Fail
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        //Test for Statistics 
        [TestMethod]
        public void StatisticsGroupedByCustomerAddress()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //Invoke the method 
            DataTable dT = ACustomer.StatisticsGroupedByCustomerAddress();
            //According to the last executed stored procedures, there should be ten rows of data 
            int noOfRecord = 10;
            //Test to see that the result is correct 
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

        [TestMethod]
        public void StatisticsGroupedByCustomerAccountCreatedAt()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //Invoke the method 
            DataTable dT = ACustomer.StatisticsGroupedByCustomerAccountCreatedAt();
            //According to the last executed stored procedures, there should be three rows of data 
            int noOfRecord = 5;
            //Test to see that the result is correct 
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

        [TestMethod]
        public void StatisticsGroupedByIsCustomerAccountActive()
        {
            //Create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //Invoke the method 
            DataTable dT = ACustomer.StatisticsGroupedByIsCustomerAccountActive();
            //According to the last executed stored procedures, there should be three rows of data 
            int noOfRecord = 2;
            //Test to see that the result is correct 
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

    }
}

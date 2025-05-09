using System;
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
            if (ACustomer.CustomerAccountCreatedAt != Convert.ToDateTime("27/04/2025"))
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
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
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
            String CustomerFullName = "SamCu";   //This should be OK
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
            String CustomerFullName = "sssssssssssssss";   //This should be OK
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
            CustomerFullName = CustomerFullName.PadRight(500, 's'); //This should Fail
            //Invoke the methood 
            Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
            //Test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

    }
}

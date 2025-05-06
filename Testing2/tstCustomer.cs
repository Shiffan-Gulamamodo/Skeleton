using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
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

    }
}

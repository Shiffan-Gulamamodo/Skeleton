using System;
using System.Collections.Generic;
using System.Security.Policy;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Test to see that it exists 
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //Create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Create some test data to assign to the property 
            //In this case the data needs to be a list of objects 
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the List 
            //Create the item of the Customer Test Data 
            clsCustomer CustomerTestItem = new clsCustomer();
            //Set its properties 
            CustomerTestItem.IsCustomerAccountActive = true;
            CustomerTestItem.CustomerId = 1;
            CustomerTestItem.CustomerFullName = "Adam Zampa";
            CustomerTestItem.CustomerEmail = "Adam@gmail.com";
            CustomerTestItem.CustomerPassword = "ZampaZampa";
            CustomerTestItem.CustomerAddress = "LE8 3RT, 28 Arwent Road, Leicester ";
            CustomerTestItem.CustomerAccountCreatedAt = DateTime.Now;
            //Add the item to the test list
            TestList.Add(CustomerTestItem);
            //Assign the data to the property 
            AllCustomers.CustomerList = TestList;
            //Test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //Create an instance of the class we want to create 
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //Create some Test data to assign to the property 
            clsCustomer TestCustomer = new clsCustomer();
            //Set the properties of the test object
            TestCustomer.IsCustomerAccountActive = true;
            TestCustomer.CustomerId = 1;
            TestCustomer.CustomerFullName = "Adam Zampa";
            TestCustomer.CustomerEmail = "Adam@gmail.com";
            TestCustomer.CustomerPassword = "ZampaZampa";
            TestCustomer.CustomerAddress = "LE8 3RT, 28 Arwent Road, Leicester ";
            TestCustomer.CustomerAccountCreatedAt = DateTime.Now;
            //Assign the data to the property
            AllCustomer.ThisCustomer = TestCustomer;
            //Test to see that the two values are the same 
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Create some test data to assign to the property 
            //In this case the data needs to be a list of objects 
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the List 
            //Create the item of the Customer Test Data 
            clsCustomer CustomerTestItem = new clsCustomer();
            //Set its properties 
            CustomerTestItem.IsCustomerAccountActive = true;
            CustomerTestItem.CustomerId = 1;
            CustomerTestItem.CustomerFullName = "Adam Zampa";
            CustomerTestItem.CustomerEmail = "Adam@gmail.com";
            CustomerTestItem.CustomerPassword = "ZampaZampa";
            CustomerTestItem.CustomerAddress = "LE8 3RT, 28 Arwent Road, Leicester ";
            CustomerTestItem.CustomerAccountCreatedAt = DateTime.Now;
            //Add the item to the test list
            TestList.Add(CustomerTestItem);
            //Assign the data to the property 
            AllCustomers.CustomerList = TestList;
            //Test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

    }
}

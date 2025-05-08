using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class TestingStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.DateAdded, TestData);
        }

        [TestMethod]
        public void StockIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AStock.StockId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockId, TestData);
        }

        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AStock.SupplierId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.SupplierId, TestData);
        }

        [TestMethod]
        public void ProductNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "iPhone 14 Pro Max";
            //assign the data to the property
            AStock.ProductName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.ProductName, TestData);
        }

        [TestMethod]
        public void StockQuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 10;
            //assign the data to the property
            AStock.StockQuantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockQuantity, TestData);
        }

        [TestMethod]
        public void InStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            bool TestData = true;
            //assign the data to the property
            AStock.InStock = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.InStock, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            decimal TestData = 9999.99m;
            //assign the data to the property
            AStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Price, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {   //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StockId = 9;
            //invoke the method
            Found = AStock.Find(StockId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockIDFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 9;
            //invoke the method
            Found = AStock.Find(StockId);
            //check the stock ID
            if (AStock.StockId != 9)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierIDFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 9;
            //invoke the method
            Found = AStock.Find(StockId);
            //check the stock ID
            if (AStock.SupplierId != 5)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 9;
            //invoke the method
            Found = AStock.Find(StockId);
            //check the dateAdded property
            if (AStock.DateAdded != Convert.ToDateTime("10/03/2025"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 9;
            //invoke the method
            Found = AStock.Find(StockId);
            //check the stock ID
            if (AStock.ProductName != "Samsung Galaxy S23")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 9;
            //invoke the method
            Found = AStock.Find(StockId);
            //check the stock ID
            if (AStock.Price != 850)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStockQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 9;
            //invoke the method
            Found = AStock.Find(StockId);
            //check the stock ID
            if (AStock.StockQuantity != 40)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 9;
            //invoke the method
            Found = AStock.Find(StockId);
            //check the stock ID
            if (AStock.InStock != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

    }

}





































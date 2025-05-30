﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStocks);
        }


        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.InStock = true;
            TestItem.StockId = 5;
            TestItem.SupplierId = 1;
            TestItem.ProductName = "iPhone 14 Pro Max";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Price = 947;
            TestItem.StockQuantity = 25;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.StockList, TestList);
        }


        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.InStock = true;
            TestStock.StockId = 5;
            TestStock.SupplierId = 1;
            TestStock.ProductName = "iPhone 14 Pro Max";
            TestStock.DateAdded = DateTime.Now;
            TestStock.Price = 947;
            TestStock.StockQuantity = 25;
            //assign the data to the property
            AllStocks.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.InStock = true;
            TestItem.StockId = 5;
            TestItem.SupplierId = 1;
            TestItem.ProductName = "iPhone 14 Pro Max";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Price = 947;
            TestItem.StockQuantity = 25;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its proterties
            TestItem.InStock = true;
            TestItem.StockId = 5;
            TestItem.SupplierId = 1;
            TestItem.ProductName = "iPhone 14 Pro Max";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Price = 947;
            TestItem.StockQuantity = 25;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.StockId = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its proterties
            TestItem.InStock = true;
            TestItem.SupplierId = 1;
            TestItem.ProductName = "iPhone 14 Pro Max";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Price = 947;
            TestItem.StockQuantity = 25;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.StockId = PrimaryKey;
            //modify the test data
            TestItem.InStock = false;
            TestItem.SupplierId = 2;
            TestItem.ProductName = "Samsung Galaxy S23 Ultra";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Price = 1099;
            TestItem.StockQuantity = 30;
            //set the record based on the new test data
            AllStocks.ThisStock = TestItem;
            //update the record
            AllStocks.Update();
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see if ThisStock matches the test data
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its proterties
            TestItem.InStock = true;
            TestItem.StockId = 5;
            TestItem.SupplierId = 1;
            TestItem.ProductName = "iPhone 14 Pro Max";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Price = 947;
            TestItem.StockQuantity = 25;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.StockId = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStocks.Delete();
            //now find the record
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            //test to see if it was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByProductNameMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a blank string (should return all records)
            FilteredStocks.ReportByProductName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByProductNameNoneFound()
        {
            //create an instance of the class we want to create
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a post code that doesn't exist
            FilteredStocks.ReportByProductName("xxxxxxxxxxxxxxxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByProductNameTestDataFound()
        {
            //create an instance of the class filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a product name that doesn't exist
            FilteredStocks.ReportByProductName("Nintendo Switch");
            //check that the correct number of records are found
            if (FilteredStocks.Count == 2)
            {
                //check too see that the first record is 10
                if (FilteredStocks.StockList[0].StockId != 227)
                {
                    OK = false;
                }
                //check too see that the first record is 11
                if (FilteredStocks.StockList[1].StockId != 229)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

    }

}
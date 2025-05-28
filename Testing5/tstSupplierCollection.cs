using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    namespace ClassLibrary
    {
        [TestClass]
        public class tstSupplierCollection
        {
            [TestMethod]
            public void InstanceOK()
            {
                //Create an instance of the class we want to create 
                clsSupplierCollection AllSuppliers = new clsSupplierCollection();
                //Test to see that it exists 
                Assert.IsNotNull(AllSuppliers);
            }
            [TestMethod]
            public void SupplierListOK()
            {

                //create and instance of the class we want to create
                clsSupplierCollection AllSupplier = new clsSupplierCollection();
                //create some test data to assing to the property
                //in this case the data needs to be a list of objects
                List<clsSupplier> TestList = new List<clsSupplier>();
                //Add an item to the list
                //create the item of test data
                clsSupplier TestSupplier = new clsSupplier();
                //Set its properties 
                TestSupplier.SupplyId = 4;
                TestSupplier.PhoneName = "Iphone 14";
                TestSupplier.DeliveryDate = DateTime.Now;
                TestSupplier.IsAvailable = false;
                //Add the item to the test list
                TestList.Add(TestSupplier);
                //Assign the data to the property 
                AllSupplier.SupplierList = TestList;
                //Test to see that the two values are the same 
                Assert.AreEqual(AllSupplier.SupplierList, TestList);
            }

            [TestMethod]
            public void SupplierPropertyOK()
            {
                //Create an instance of the class we want to create 
                clsSupplierCollection AllSupplier = new clsSupplierCollection();
                //Create some Test data to assign to the property 
                clsSupplier TestSupplier = new clsSupplier();
                //Set the properties of the test object
                TestSupplier.SupplyId = 4;
                TestSupplier.PhoneName = "Iphone 14";
                TestSupplier.DeliveryDate = DateTime.Now;
                TestSupplier.IsAvailable = false;
                //Assign the data to the property
                AllSupplier.ThisSupplier = TestSupplier;
                //Test to see that the two values are the same 
                Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);

            }


            [TestMethod]
            public void ListAndCountOK()
            {
                //Create an instance of the class we want to create
                clsSupplierCollection AllSupplier = new clsSupplierCollection();
                //Create some test data to assign to the property 
                //In this case the data needs to be a list of objects 
                List<clsSupplier> TestList = new List<clsSupplier>();
                //Add an item to the List 
                //Create the item of the Supplier Test Data 
                clsSupplier TestSupplier = new clsSupplier();
                //Set its properties 
                TestSupplier.SupplyId = 4;
                TestSupplier.PhoneName = "Iphone 14";
                TestSupplier.DeliveryDate = DateTime.Now;
                TestSupplier.IsAvailable = false;
                //Add the item to the test list
                TestList.Add(TestSupplier);
                //Assign the data to the property 
                AllSupplier.SupplierList = TestList;
                //Test to see that the two values are the same 
                Assert.AreEqual(AllSupplier.Count, TestList.Count);
            }

            [TestMethod]
            public void AddMethodOK()
            {
                //create an instance of the class we want to create
                clsSupplierCollection AllSupplier = new clsSupplierCollection();
                //create an instance of the class we want to create
                clsSupplier TestSupplier = new clsSupplier();
                Int32 Primarykey = 0;
                //set its properties
                TestSupplier.SupplyId = 4;
                TestSupplier.PhoneName = "Iphone 14";
                TestSupplier.DeliveryDate = DateTime.Now;
                TestSupplier.IsAvailable = false;
                //set ThisSupplier to the test data
                AllSupplier.ThisSupplier = TestSupplier;
                //add the record
                Primarykey = AllSupplier.Add();
                //set the primary key of the test data
                TestSupplier.SupplyId = Primarykey;
                //find the record
                AllSupplier.ThisSupplier.Find(Primarykey);
                //test to see that the two values are the same 
                Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);
            }
            

            [TestMethod]
            public void UpdateMethodOK()
            {
                //create an instance of the class we want to create
                clsSupplierCollection AllSupplier = new clsSupplierCollection();
                clsSupplier TestSupplier = new clsSupplier();
                Int32 Primarykey = 0;
                TestSupplier.SupplyId = 4;
                TestSupplier.PhoneName = "Iphone 14";
                TestSupplier.DeliveryDate = DateTime.Now;
                TestSupplier.IsAvailable = false;
                AllSupplier.ThisSupplier = TestSupplier;
                Primarykey = AllSupplier.Add();
                TestSupplier.SupplyId = Primarykey;
                TestSupplier.SupplyId = 3;
                TestSupplier.PhoneName = "Iphone 13";
                TestSupplier.DeliveryDate = DateTime.Now;
                TestSupplier.IsAvailable = true;
                AllSupplier.ThisSupplier = TestSupplier;
                AllSupplier.Update();
                AllSupplier.ThisSupplier.Find(Primarykey);
                Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);

            }

            [TestMethod]
            public void DeleteMethodOK()
            {   //create an instance of the class we want to create
                clsSupplierCollection AllSupplier = new clsSupplierCollection();
                clsSupplier TestSupplier = new clsSupplier();
                Int32 Primarykey = 0;
                TestSupplier.SupplyId = 4;
                TestSupplier.PhoneName = "Iphone 14";
                TestSupplier.DeliveryDate = DateTime.Now;
                TestSupplier.IsAvailable = false;
                AllSupplier.ThisSupplier = TestSupplier;
                Primarykey = AllSupplier.Add();
                AllSupplier.ThisSupplier.Find(Primarykey);
                AllSupplier.Delete();
                Boolean Found = AllSupplier.ThisSupplier.Find(Primarykey);
                Assert.IsFalse(Found);
            }

            [TestMethod]
            public void ReportByPhoneNameMethodOK()
            {
                clsSupplierCollection AllSupplier = new clsSupplierCollection();
                clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
                FilteredSupplier.ReportByPhoneName("");
                Assert.AreEqual(AllSupplier.Count, FilteredSupplier.Count);

            }
        

        [TestMethod]
            public void ReportByPhoneNameNoneFound()
            {
                //create an instance of the class we want to create
                clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
                //apply a blank string to the filter to test it works
                FilteredSupplier.ReportByPhoneName("Switch");
                //test to see that there are no records found
                Assert.AreEqual(0, FilteredSupplier.Count);
            }

        }
    }
}


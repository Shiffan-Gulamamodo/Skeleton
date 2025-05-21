using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffId = 1;
            TestItem.StaffFullName = "Cristiano Ronaldo";
            TestItem.StaffPassword = "CR7Goat";
            TestItem.Email = "cr7ball@hotmail.com";
            TestItem.lastUpdated = DateTime.Now;
            TestItem.isActive = true;
            TestItem.Role = "Stock Manager";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.StaffId = 1;
            TestStaff.StaffFullName = "Cristiano Ronaldo";
            TestStaff.StaffPassword = "CR7Goat";
            TestStaff.Email = "cr7ball@hotmail.com";
            TestStaff.lastUpdated = DateTime.Now;
            TestStaff.isActive = true;
            TestStaff.Role = "Stock Manager";
            //asign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffId = 1;
            TestItem.StaffFullName = "Cristiano Ronaldo";
            TestItem.StaffPassword = "CR7Goat";
            TestItem.Email = "cr7ball@hotmail.com";
            TestItem.lastUpdated = DateTime.Now;
            TestItem.isActive = true;
            TestItem.Role = "Stock Manager";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffId = 7;
            TestItem.StaffFullName = "Aizen Sosuke";
            TestItem.StaffPassword = "SoulSociety99";
            TestItem.Email = "bankai123@hotmail.com";
            TestItem.lastUpdated = DateTime.Now;
            TestItem.isActive = true;
            TestItem.Role = "Stock Manager";
            //asign the data to the property
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffFullName = "Aizen Sosuke";
            TestItem.StaffPassword = "SoulSociety99";
            TestItem.Email = "bankai123@hotmail.com";
            TestItem.lastUpdated = DateTime.Now;
            TestItem.isActive = true;
            TestItem.Role = "Stock Manager";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //modify the test record
            TestItem.StaffFullName = "Kyoraku Shunsui";
            TestItem.StaffPassword = "SoulSociety11";
            TestItem.Email = "bankai789@hotmail.com";
            TestItem.lastUpdated = DateTime.Now;
            TestItem.isActive = false;
            TestItem.Role = "Staff Manager";
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see if ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffId = 7;
            TestItem.StaffFullName = "Asta";
            TestItem.StaffPassword = "magicmagic";
            TestItem.Email = "blackclover@hotmail.com";
            TestItem.lastUpdated = DateTime.Now;
            TestItem.isActive = true;
            TestItem.Role = "Supplier Manager";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByRoleMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records);
            FilteredStaff.ReportByRole("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByRoleNoneFound()
        {
            //create an instance of the class we want to create
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a role that doesnt exist
            FilteredStaff.ReportByRole("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByRoleTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a role that doesn't exist
            FilteredStaff.ReportByRole("yyy yyyy");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check to see that the first record is 119
                if (FilteredStaff.StaffList[0].StaffId != 141)
                {
                    OK = false;
                }
                //check to see that the first record is 120
                if (FilteredStaff.StaffList[1].StaffId != 144)
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

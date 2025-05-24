using System;
using System.Threading;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass the method
        string StaffFullName = "Max Payne";
        string StaffPassword = "brazilRio778";
        string Email = "MPayne@hotmail.com";
        string lastUpdated = DateTime.Now.ToShortDateString();
        string Role = "Order Manager";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see if it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void isActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //Assign the data to the property
            AStaff.isActive = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.isActive, TestData);
        }

        [TestMethod]
        public void lastUpdatedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            AStaff.lastUpdated = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.lastUpdated, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            AStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffId, TestData);
        }

        [TestMethod]
        public void StaffFullNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Cristiano Ronaldo";
            //Assign the data to the property
            AStaff.StaffFullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffFullName, TestData);
        }

        [TestMethod]
        public void StaffPasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "CR7Goat";
            //Assign the data to the property
            AStaff.StaffPassword= TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffPassword, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "cr7ball@hotmail.com";
            //Assign the data to the property
            AStaff.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Email, TestData);
        }

        [TestMethod]
        public void RolePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Stock Manager";
            //Assign the data to the property
            AStaff.Role = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Role, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create a new instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean Variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 3;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the Staff ID
            if (AStaff.StaffId != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastUpdatedFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 3;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the lastUpdated property
            if (AStaff.lastUpdated != Convert.ToDateTime("09/08/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffFullNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 3;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the lastUpdated property
            if (AStaff.StaffFullName != "Max Payne")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPasswordFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 3;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the lastUpdated property
            if (AStaff.StaffPassword != "brazilRio778")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 3;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the lastUpdated property
            if (AStaff.Email != "MPayne@hotmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRoleFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 3;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the lastUpdated property
            if (AStaff.Role != "Order Manager")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsActiveFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 3;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the lastUpdated property
            if (AStaff.isActive != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error messages
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(StaffFullName,StaffPassword,Email,lastUpdated,Role);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string StaffFullName = "";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword,Email,lastUpdated,Role);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string StaffFullName = "a";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string StaffFullName = "aa";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string StaffFullName = "aaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string StaffFullName = "aaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string StaffFullName = "aaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string StaffFullName = "aaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string StaffFullName = "";
            StaffFullName = StaffFullName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void lastUpdatedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string to store error message
            String Error = "";
            //created a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string lastUpdated = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void lastUpdatedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string to store error message
            String Error = "";
            //created a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string lastUpdated = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void lastUpdatedMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string to store error message
            String Error = "";
            //created a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string lastUpdated = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void lastUpdatedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string to store error message
            String Error = "";
            //created a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string lastUpdated = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void lastUpdatedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string to store error message
            String Error = "";
            //created a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string lastUpdated = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void lastUpdatedInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set lastUpdated to a non data value
            string lastUpdated = "this is not a date";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string StaffPassword = "";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string StaffPassword = "a";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string StaffPassword = "aa";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(15, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(29, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(30, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(31, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string Email = "";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string Email = "a";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string Email = "aa";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string Email = "";
            Email = Email.PadRight(20, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string Email = "";
            Email = Email.PadRight(39, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string Email = "";
            Email = Email.PadRight(40, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string Email = "";
            Email = Email.PadRight(41, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string Email = "";
            Email = Email.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoleMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string Role = "";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoleMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string Role = "a";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string Role = "aa";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string Role = "";
            Role = Role.PadRight(15, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string Role = "";
            Role = Role.PadRight(29, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string Role = "";
            Role = Role.PadRight(30, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string Role = "";
            Role = Role.PadRight(31, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoleExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //variable to store any error message
            String Error = "";
            string Role = "";
            Role = Role.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
            //test to see the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StatStatisticsGroupedByStaffFullName()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //invoke the method
            DataTable dT = AStaff.StatisticsGroupedByStaffFullName();
            //According to the last executed stored procedure, there should be 13 rows of data.
            int noOfRecord = 13;

            //test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

        [TestMethod]
        public void StatStatisticsGroupedByRole()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //invoke the method
            DataTable dT = AStaff.StatisticsGroupedByRole();
            //According to the last executed stored procedure, there should be 6 rows of data.
            int noOfRecord = 6;

            //test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

        [TestMethod]
        public void StatStatisticsGroupedByIsActive()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //invoke the method
            DataTable dT = AStaff.StatisticsGroupedByIsActive();
            //According to the last executed stored procedure, there should be 2 rows of data.
            int noOfRecord = 2;

            //test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }
    }
}

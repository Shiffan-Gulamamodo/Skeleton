using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        //Private Data Member for the List 
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //Private Data Member for this Customer 
        clsCustomer mThisCustomer = new clsCustomer();

        //Constructor for the Class 
        public clsCustomerCollection()
        {
            //Variable for the Index 
            Int32 Index = 0;
            //Variable to store the record Count 
            Int32 RecordCount = 0;
            //Create an instance of the Data Connection 
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure 
            DB.Execute("sproc_tblCustomer_SelectAll");
            //Get the count of the records 
            RecordCount = DB.Count;
            //If one record is found (there should be either one or zero)
            while (Index < RecordCount)
            {
                //Create a blank Address 
                clsCustomer ACustomer = new clsCustomer();
                //Copying the data from the database to the private data members
                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.CustomerAccountCreatedAt = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerAccountCreatedAt"]);
                ACustomer.IsCustomerAccountActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsCustomerAccountActive"]);
                ACustomer.CustomerFullName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFullName"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.CustomerPassword = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPassword"]);
                ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                //Add the Record to the private Data Member 
                mCustomerList.Add(ACustomer);
                //Point at the next Record 
                Index++;
            }
        }

        public List<clsCustomer> CustomerList 
        {
            get
            {
                //Return the Private Data 
                return mCustomerList;
            }
            set
            {
                //Set the Private Data 
                mCustomerList = value;
            }
        
        }
        public int Count {
            get
            {
                //Return the Count of the list
                return mCustomerList.Count;
            }
            set
            {
                //We shall worry about this later 
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                //Return theprivate Data
                return mThisCustomer;
            }
            set
            {
               //Set the Private Data 
               mThisCustomer = value;
            }
        }

        //Add Method
        public int Add()
        {
            //Add a record to the Database on the values of mThisCustomer
            //Connect to the DataBase 
            clsDataConnection DB = new clsDataConnection();
            //Set the Parameters for the stored Procedure 
            DB.AddParameter("@CustomerFullName", mThisCustomer.CustomerFullName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPassword", mThisCustomer.CustomerPassword);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerAccountCreatedAt", mThisCustomer.CustomerAccountCreatedAt);
            DB.AddParameter("@IsCustomerAccountActive", mThisCustomer.IsCustomerAccountActive);

            //Execute the Query returning the primary key value 
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        //Delete Method
        public void Delete()
        {
            //Delete the record pointed to by ThisCustomer 
            //Connect to Database 
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the Stored Procedure 
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            //Execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        //Update Method 
        public void Update()
        {
            //Update an existing record based on the values of ThisCustomer
            //Connect to the DataBase 
            clsDataConnection DB = new clsDataConnection();
            //Set the Parameters for the stored Procedure 
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerFullName", mThisCustomer.CustomerFullName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPassword", mThisCustomer.CustomerPassword);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerAccountCreatedAt", mThisCustomer.CustomerAccountCreatedAt);
            DB.AddParameter("@IsCustomerAccountActive", mThisCustomer.IsCustomerAccountActive);
            //Execute the Stored Procedure
            DB.Execute("sproc_tblCustomer_Update");
        }
    }
}
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        //Private Data Member for the List 
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

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

        public clsCustomer ThisCustomer { get; set; }
    }
}
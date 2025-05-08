using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //Creating Private Data Member for the Customer Id Property 
        private Int32 mCustomerId;
        //Creating Private Data Member for the Customer Account Created At Property 
        private DateTime mCustomerAccountCreatedAt;
        //Creating Private Data Member for the Is Customer Account Active Property 
        private Boolean mIsCustomerAccountActive;
        //Creating Private Data Member for the Customer FullName Property
        private String mCustomerFullName;
        //Creating Private Data Member for the Customer Email Property
        private String mCustomerEmail;
        //Creating Private Data Member for the Customer Password Property
        private String mCustomerPassword;
        //Creating Private Data Member for the Customer Address Property
        private String mCustomerAddress;

        public Boolean IsCustomerAccountActive 
        {
            get
            {
                //this line of code sends data out of the property
                return mIsCustomerAccountActive;
            }
            set
            {
                //this line of code allows data into the property
                mIsCustomerAccountActive = value;
            }
        }

        public DateTime CustomerAccountCreatedAt {
            get 
            { 
                //This line of code sends data out of the property
                return mCustomerAccountCreatedAt;
            }
            set 
            { 
                //This line of code allows Data into the property
                mCustomerAccountCreatedAt = value;
            } 
        }

        public int CustomerId 
        {
            get
            {
                //This Line of code sends Data out of the property 
                return mCustomerId;
            }
            set 
            { 
                //This Line of Code allows data into the property
                mCustomerId = value;
            } 
        }

        public string CustomerFullName {
            get
            {
                //this line of code sends data out of the property
                return mCustomerFullName;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerFullName = value;
            }
        }

        public string CustomerEmail {
            get
            {
                //this line of code sends data out of the property
                return mCustomerEmail;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerEmail = value;
            }
        }

        public string CustomerPassword {
            get
            {
                //this line of code sends data out of the property
                return mCustomerPassword;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerPassword = value;
            }
        }
        public string CustomerAddress {
            get
            {
                //this line of code sends data out of the property
                return mCustomerAddress;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerAddress = value;
            }
        }

        public bool Find(int CustomerId)
        {

            //Create an instance of the Data Connection 
            clsDataConnection DB = new clsDataConnection();
            //Add the Parameter for the Customer Id to search for 
            DB.AddParameter("@CustomerId", CustomerId);
            //Execute the stored procedure 
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //Copying the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCustomerAccountCreatedAt = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerAccountCreatedAt"]);
                mIsCustomerAccountActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsCustomerAccountActive"]);
                mCustomerFullName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFullName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["CustomerPassword"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                //Always returns true
                return true;
            }
            //If no record was found 
            else
            {
                //Return false indicating there is a problem 
                return false;
            }

        }
    }
}
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

        public string Valid(string customerFullName, string customerEmail, string customerPassword, string customerAddress, string customerAccountCreatedAt)
        {
            //Creating a String Variable to store the error 
            String Error = "";
            //Create a temporary variable to store the date value
            DateTime DateTemp;

            //If the Customer Full Name is blank 
            if (customerFullName.Length == 0)
            {
                //Record the error
                Error = Error + "The Customer Full Name may not be blank : ";
            }

            //If the Customer Full Name is greater than 30 characters 
            if (customerFullName.Length > 30)
            {
                Error = Error + "The Customer Full Name must be less than 30 characters : ";
            }

            //Create an instance of Date Time to compare to compare with DateTemp
            DateTime DateComp = DateTime.Now.Date;
            //Check to see if the date is less than today's date 
            try
            {
                //Copy the date added value to the DateTemp variable 
                DateTemp = Convert.ToDateTime(customerAccountCreatedAt);

                if (DateTemp < DateComp) //Compare CustomerAccountCreatedAt 
                {
                    //Record the error 
                    Error = Error + "The Date cannot be in the past : ";
                }

                //Check to see if the date is greater than today's date 
                if (DateTemp > DateComp)
                {
                    //Record the error 
                    Error = Error + "The date cannot be in the future : ";
                }

            }

            catch
            {
                //Record the Error 
                Error = Error + "The Date cannot be in the past : "; 
            }

            //If the Customer Email is blank 
            if (customerEmail.Length == 0)
            {
                //Record the error
                Error = Error + "The Customer Email may not be blank : ";
            }

            //If the Customer Email is greater than 40 characters 
            if (customerEmail.Length > 40)
            {
                Error = Error + "The Customer Email must be less than 40 characters : ";
            }

            //If the Customer Password is blank 
            if (customerPassword.Length == 0)
            {
                //Record the error -
                Error = Error + "The Customer Password may not be blank : ";
            }

            //If the Customer Password is greater than 30 characters 
            if (customerPassword.Length > 30)
            {
                Error = Error + "The Customer Password must be less than 30 characters : ";
            }

            //If the Customer Address is blank 
            if (customerAddress.Length == 0)
            {
                //Record the error -
                Error = Error + "The Customer Address may not be blank : ";
            }

            //If the Customer Address is greater than 50 characters 
            if (customerAddress.Length > 50)
            {
                Error = Error + "The Customer Address must be less than 50 characters : ";
            }

            //Return any error messages 
            return Error;

        }

    }
}
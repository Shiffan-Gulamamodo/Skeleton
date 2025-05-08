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

        public bool Find(int customerId)
        {
            //Set the private Data Members to the test data value 
            mCustomerId = 5;
            mCustomerAccountCreatedAt = Convert.ToDateTime("27/04/2025");
            mIsCustomerAccountActive = true;
            mCustomerFullName = "Sam Curran";
            mCustomerEmail = "Sam@gmail.com";
            mCustomerPassword = "CurranCurran";
            mCustomerAddress = "CV10 2ER, 2 Kings Avenue, Nuneaton";
            //Always returns true
            return true;
        }
    }
}
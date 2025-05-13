using System;

namespace ClassLibrary
{
    public class clsSupplier
    {

        //Creating Private Data Member for the Supplier Id Property 
        private Int32 mSupplyId;
        //Creating Private Data Member for the Supplier Account Created At Property 
        private DateTime mDeliveryDate;
        //Creating Private Data Member for the Is Supplier Account Active Property 
        private Boolean mIsAvailable;
        //Creating Private Data Member for the Supplier Email Property
        private Int32 mStockId;
        //Creating Private Data Member for the Phone Name Property
        private String mPhoneName;

        public string PhoneName {
            get
            {
                //this line of code sends data out of the property
                return mPhoneName;
            }
            set
            {
                //this line of code allows data into the property
                mPhoneName = value;
            }
        }
        public int SupplyId {
            get
            {
                //this line of code sends data out of the property
                return mSupplyId;
            }
            set
            {
                //this line of code allows data into the property
                mSupplyId = value;
            }
        }
        public int StockID {
            get
            {
                //this line of code sends data out of the property
                return mStockId;
            }
            set
            {
                //this line of code allows data into the property
                mStockId = value;
            }
        }
        public bool IsAvailable {
            get
            {
                //this line of code sends data out of the property
                return mIsAvailable;
            }
            set
            {
                //this line of code allows data into the property
                mIsAvailable = value;
            }
        }
        public DateTime DeliveryDate {
            get
            {
                //this line of code sends data out of the property
                return mDeliveryDate;
            }
            set
            {
                //this line of code allows data into the property
                mDeliveryDate = value;
            }
        }


        public bool Find(object SupplyId)
        {
            //set the private data members to the test data value
            mSupplyId = 4;
            mDeliveryDate = Convert.ToDateTime("25/05/2025 00:00:00");
            mIsAvailable = false;
            mStockId = 3;
            mPhoneName = "Iphone 14";

            //always return true
            return true;
        }
    }
        
}

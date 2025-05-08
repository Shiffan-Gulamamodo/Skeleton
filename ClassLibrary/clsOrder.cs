using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private int mOrderID;
        private int mStaffID;
        private DateTime mOrderDate;
        private int mCustomerID;
        private bool mIsPaid;
        private string mDeliveryAddress;
        private int mOrderLineID;
        public int OrderID 
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;

            }
        }
        public int StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;

            }
        }
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }

        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        public bool IsPaid
        {
            get
            {
                return mIsPaid;
            }
            set
            {
                mIsPaid = value;
            }
        }

        public string DeliveryAddress
        {
            get
            {
                return mDeliveryAddress;
            }
            set
            {
                mDeliveryAddress = value;
            }
        }

        public int OrderLineID
        {
            get
            {
                return mOrderLineID;
            }
            set
            {
                mOrderLineID = value;
            }
        }


        public bool Find(int orderID)
        {
            mOrderID = 21;
            mStaffID = 21;
            mOrderDate = Convert.ToDateTime("21/12/2025");
            mCustomerID = 21;
            mIsPaid = true;
            mDeliveryAddress = "123 Test Street";
            mOrderLineID = 21;
            return true;
        }
            
        
    }
}
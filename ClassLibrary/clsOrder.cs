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
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", orderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mIsPaid = Convert.ToBoolean(DB.DataTable.Rows[0]["IsPaid"]);
                mDeliveryAddress = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAddress"]);
                mOrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineID"]);
                return true;
            }
            else
            {
                return false;
            }
        }
            
      
    }
}
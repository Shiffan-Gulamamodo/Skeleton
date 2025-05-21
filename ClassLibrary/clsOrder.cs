using System;
using System.Data;

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

        public string Valid(string deliveryAddress, string orderDate)
        {
            string Error = "";
            DateTime DateTemp;
            DateTime DateComp = DateTime.Now.Date;
            if (deliveryAddress.Length == 0)
            {
                Error = Error + "The delivery address may not be blank : ";
            }
            if (deliveryAddress.Length > 50)
            {
                Error = Error + "The delivery address must be less than 50 characters : ";
            }    
            try
            { 
                DateTemp = Convert.ToDateTime(orderDate);
                if(DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if(DateTemp >  DateComp)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            return Error;
        }

        // statistics methods //
        public DataTable StatisticsGroupedByCustomerID()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_Count_GroupByCustomerID");
            return DB.DataTable;
        }

        public DataTable StatisticsGroupedByOrderDate()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_Count_GroupByOrderDate");
            return DB.DataTable;
        }

        public DataTable StatisticsGroupedByStaffID()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_Count_GroupByStaffID");
            return DB.DataTable;
        }
    }
}
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {

        clsOrder mThisOrder = new clsOrder();
        List<clsOrder> mOrderList = new List<clsOrder>();
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //coming back to this
            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        // constructor
        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                var row = DB.DataTable.Rows[Index];

                AnOrder.OrderDate = row["OrderDate"] != DBNull.Value ? Convert.ToDateTime(row["OrderDate"]) : default(DateTime);
                AnOrder.OrderID = row["OrderID"] != DBNull.Value ? Convert.ToInt32(row["OrderID"]) : 0;
                AnOrder.OrderLineID = row["OrderLineID"] != DBNull.Value ? Convert.ToInt32(row["OrderLineID"]) : 0;
                AnOrder.CustomerID = row["CustomerID"] != DBNull.Value ? Convert.ToInt32(row["CustomerID"]) : 0;
                AnOrder.StaffID = row["StaffID"] != DBNull.Value ? Convert.ToInt32(row["StaffID"]) : 0;
                AnOrder.IsPaid = row["IsPaid"] != DBNull.Value ? Convert.ToBoolean(row["IsPaid"]) : false;
                AnOrder.DeliveryAddress = row["DeliveryAddress"] != DBNull.Value ? Convert.ToString(row["DeliveryAddress"]) : string.Empty;

                mOrderList.Add(AnOrder);
                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DeliveryAddress", mThisOrder.DeliveryAddress);
            DB.AddParameter("@StaffID", mThisOrder.StaffID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@OrderLineID", mThisOrder.OrderLineID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@IsPaid", mThisOrder.IsPaid);

            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DeliveryAddress", mThisOrder.DeliveryAddress);
            DB.AddParameter("@StaffID", mThisOrder.StaffID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@OrderLineID", mThisOrder.OrderLineID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@IsPaid", mThisOrder.IsPaid);
            DB.AddParameter("@OrderID", mThisOrder.OrderID);

            DB.Execute("sproc_tblOrder_Update");
        }
    }
}


using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
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
        public clsOrder ThisOrder { get; set; }

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
    }
}
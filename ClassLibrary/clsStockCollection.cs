using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the stock list
        List<clsStock> mStockList = new List<clsStock>();

        //public property for the stock list
        public List<clsStock> StockList
        {
            get
            {
                //return the provate data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }

        public clsStock ThisStock { get; set; }

        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }

            set
            {
                //we shall worry about this later
            }
        }

        //constructor for the class
        public clsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock item
                clsStock TestItem = new clsStock();
                //read in the fields from the current record
                TestItem.StockId = Convert.ToInt32(DB.DataTable.Rows[Index]["StockId"]);
                TestItem.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                TestItem.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                TestItem.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                TestItem.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                TestItem.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
                TestItem.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                //add the item to the test list
                mStockList.Add(TestItem);
                //increment the index
                Index++;
            }

        }

    }

}
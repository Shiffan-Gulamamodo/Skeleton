using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the stock id property
        private Int32 mStockId;

        //stockID public property
        public int StockId
        {
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

        //private data member for the supplier id property
        private Int32 mSupplierId;

        //stockID public property
        public int SupplierId
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplierId;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierId = value;
            }
        }

        //private data member for the date added property
        private DateTime mDateAdded;
        //dateAdded public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }

        //private data member for the product name property
        private string mProductName;
        //productName public property
        public string ProductName
        {
            get
            {
                //this line of code sends data out of the property
                return mProductName;
            }
            set
            {
                //this line of code allows data into the property
                mProductName = value;
            }
        }

        //private data member for the price property
        private decimal mPrice;
        //price public property
        public decimal Price
        {
            get
            {
                //this line of code sends data out of the property
                return mPrice;
            }
            set
            {
                //this line of code allows data into the property
                mPrice = value;
            }
        }

        //private data member for the stock quantity property
        private int mStockQuantity;
        //stockQuantity public property
        public int StockQuantity
        {
            get
            {
                //this line of code sends data out of the property
                return mStockQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mStockQuantity = value;
            }
        }

        //private data member for the in stock property
        private bool mInStock;
        //inStock public property
        public bool InStock
        {
            get
            {
                //this line of code sends data out of the property
                return mInStock;
            }
            set
            {
                //this line of code allows data into the property
                mInStock = value;
            }
        }

        /****** FIND METHOD ******/
        public bool Find(int StockID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the stock id to search for
            DB.AddParameter("@StockId", StockID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //get the data from the database
                mStockId = Convert.ToInt32(DB.DataTable.Rows[0]["StockId"]);
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
         
        }

    }

}


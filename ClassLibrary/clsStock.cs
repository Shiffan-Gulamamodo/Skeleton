using System;
using System.Data;

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

        public string Valid(string productName, string dateAdded)
        {
            //create a string variable to store the error
            string Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the ProductName is blank
            if (productName.Length == 0)
            {
                //record the error
                Error = Error + "The Product Name may not be blank : ";
            }
            //if the ProductName is greater than 20 characters
            if (productName.Length > 20)
            {
                //record the error
                Error = Error + "The Product Name must be less than 20 characters : ";
            }

            //create an instance of DateTime to compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);

                if (DateTemp < DateComp) //compare dateAdded with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }


                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }

            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //return any error messages
            return Error;
        }

        /****** Statistics Grouped by Supplier id Method ******/
        public DataTable StatisticsGroupedBySupplierId()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStock_Count_GroupBySupplierId");
            //There should be either zero, one, or more records
            return DB.DataTable;
        }

        /****** Statistics Grouped by Product Name Method ******/
        public DataTable StatisticsGroupedByProductName()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStock_Count_GroupByProductName");
            //There should be either zero, one, or more records
            return DB.DataTable;
        }

        /****** Statistics Grouped by Date Addded Method ******/
        public DataTable StatisticsGroupedByDateAdded()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStock_Count_GroupByDateAdded");
            //There should be either zero, one, or more records
            return DB.DataTable;
        }

    }

}




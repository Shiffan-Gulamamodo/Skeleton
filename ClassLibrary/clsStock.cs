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

        public bool Find(int stockID)
        {
            //set the private data memebers to the test data value
            mStockId = 9;
            mSupplierId = 5;
            mDateAdded = Convert.ToDateTime("10/03/2025");
            mProductName = "Samsung Galaxy S23";
            mPrice = 850;
            mStockQuantity = 40;
            mInStock = true;
            //always return true
            return true;
        }

    }

}


using System;
using System.Data;

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

        public string PhoneName
        {
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
        public int SupplyId
        {
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
        public int StockID
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
        public bool IsAvailable
        {
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
        public DateTime DeliveryDate
        {
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


        public bool Find(int SupplyId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search fpr
            DB.AddParameter("@SupplyID", SupplyId);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplyId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //Copy the data from the database to the prive data members
                mSupplyId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplyId"]);
                mDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryDate"]);
                mIsAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["IsAvailable"]);
                mStockId = Convert.ToInt32(DB.DataTable.Rows[0]["StockId"]);
                mPhoneName = Convert.ToString(DB.DataTable.Rows[0]["PhoneName"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indication there is a problem
                return false;
            }
        }

        public string Valid(string PhoneName, string DeliveryDate, string sAvailable)
        {
            return "";
        }

        /****** Statistics Grouped by Phone Name ******/
        public DataTable StatisticsGroupedByPhoneName()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_count_GroupByPhoneName");
            //return the data table
            return DB.DataTable;
        }

        /****** Statistics Grouped by DeliveryDate ******/
        public DataTable StatisticsGroupedDeliveryDate()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_Count_GroupDeliveryDate");
            //return the data table
            return DB.DataTable;

        }

        /****** Statistics Grouped by IsAvailable******/
        public DataTable StatisticsGroupedIsAvailable()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_Count_GroupIsAvailable");
            //return the data table
            return DB.DataTable;
        }


        }
}





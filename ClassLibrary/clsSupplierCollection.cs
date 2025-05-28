using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();

        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }

        public clsSupplier ThisSupplier {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }

        public int Count
        {
            get
            {
                return SupplierList.Count;
            }
            set
            {

                //Do Later
            }
        }
        public clsSupplierCollection()
        {   //constructor for the class
            //initialise the data connection object
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get all records
            DB.Execute("sproc_tblSupplier_SelectAll");
            PopulateArray(DB);
        }

    

 
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DeliveryDate", mThisSupplier.DeliveryDate);
            DB.AddParameter("@IsAvailable", mThisSupplier.IsAvailable);
            DB.AddParameter("@PhoneName", mThisSupplier.PhoneName);
            DB.AddParameter("@StockId", mThisSupplier.StockID);

            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplyId", mThisSupplier.SupplyId);
            DB.AddParameter("@DeliveryDate", mThisSupplier.DeliveryDate);
            DB.AddParameter("@IsAvailable", mThisSupplier.IsAvailable);
            DB.AddParameter("@PhoneName", mThisSupplier.PhoneName);
            DB.AddParameter("@StockId", mThisSupplier.StockID);
            DB.Execute("sproc_tblSupplier_Update");

        }


        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplyId", mThisSupplier.SupplyId);
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void ReportByPhoneName(string PhoneName)
        {
            //filters the records nased on a full or partial phone name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the postcode parameter to the databse
            DB.AddParameter("@PhoneName", PhoneName);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterByPhoneName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mSupplierList = new List<clsSupplier>();
            while (Index < RecordCount)
            {
                //create a new instance of the supplier class
                clsSupplier ASupplier = new clsSupplier();
                //get the data from the database and copy it to the class
                ASupplier.SupplyId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplyId"]);
                ASupplier.PhoneName = Convert.ToString(DB.DataTable.Rows[Index]["PhoneName"]);
                ASupplier.DeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DeliveryDate"]);
                ASupplier.IsAvailable = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAvailable"]);
                ASupplier.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockId"]);
                //add the record to the private data member
                mSupplierList.Add(ASupplier);
                //point to the next record  
                Index++;
            }
        }

    }
}
    









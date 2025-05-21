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


        
            
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection(); 
            DB.AddParameter("@DeliveryDate", mThisSupplier.DeliveryDate);
            DB.AddParameter("@IsAvailable", mThisSupplier.IsAvailable);  
            DB.AddParameter("@PhoneName", mThisSupplier.PhoneName);
            DB.AddParameter("@StockId", mThisSupplier.StockID);

            return DB.Execute("sproc_tblSupplier_Insert");
        }
     
          
        
    } 

    
}
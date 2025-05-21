using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
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
        public clsSupplier ThisSupplier { get; set; }
        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {

            }
        }
        List<clsSupplier> mSupplierList = new List<clsSupplier>();



    }
}
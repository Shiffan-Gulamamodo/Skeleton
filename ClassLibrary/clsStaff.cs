using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the Staff ID property
        private Int32 mStaffId;
        private DateTime mLastUpdated;
        private String mStaffFullName;
        private String mStaffPassword;
        private String mEmail;
        private Boolean mIsActive;
        private String mRole;

        //Staff ID public property
        public int StaffId {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            } set
            {
                //this line of code allows data into the property
                mStaffId = value;
            } 
        }
        
        public DateTime lastUpdated
        {
            get
            {
                //this line of code sends data out of the property
                return mLastUpdated;
            }
            set
            {
                //this line of code allows data into the property
                mLastUpdated = value;
            }
        }
        public bool isActive {
            get
            {
                //this line of code sends data out of the property
                return mIsActive;
            }
            set 
            {
                //this line of code allows data into the property
                mIsActive = value;
            } 
        }
        
        public string StaffFullName {
            get 
            {
                //this line of code sends data out of the property
                return mStaffFullName;
            }
            set
            {
                //this line of code allows data into the property
                mStaffFullName = value;
            }
        }
        public string StaffPassword 
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffPassword;
            }
            set
            {
                //this line of code allows data into the property
                mStaffPassword = value;
            }
        }
        public string Email 
        {
            get
            { 
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            { 
                //this line of code allows data into the property
                mEmail = value;
            } 
        }
        public string Role 
        {
            get
            {
                //this line of code sends data out of the property
                return mRole;
            }
            set
            { 
                //this line of code allows data into the property
                mRole = value;
            } }

        public bool Find(int StaffId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Staff Id to search for
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStaffFullName = Convert.ToString(DB.DataTable.Rows[0]["StaffFullName"]);
                mStaffPassword = Convert.ToString(DB.DataTable.Rows[0]["StaffPassword"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mLastUpdated = Convert.ToDateTime(DB.DataTable.Rows[0]["lastUpdated"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["isActive"]);
                mRole = Convert.ToString(DB.DataTable.Rows[0]["Role"]);
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
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

        public bool Find(int staffId)
        {
            //set the private data members to the test data value
            mStaffId = 3;
            mStaffFullName = "Max Payne";
            mStaffPassword = "brazilRio778";
            mEmail = "MPayne@hotmail.com";
            mLastUpdated = Convert.ToDateTime("09/08/2024");
            mIsActive = true;
            mRole = "Order Manager";
            //always return true
            return true;
        }
    }
}
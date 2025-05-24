using System;
using System.Data;

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

        public string Valid(string staffFullName, string staffPassword, string email, string lastUpdated, string role)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the Staff FullName is blank
            if (staffFullName.Length == 0)
            {
                //record the error
                Error = Error + "The Staff Full Name may not be blank : </br>";
            }
            if (staffFullName.Length > 20)
            {
                Error = Error + "The Staff Full Name must be less than 20 : </br>";
            }

            //Staff Password
            if (staffPassword.Length == 0)
            {
                //record the error
                Error = Error + "The Staff Password may not be blank : </br>";
            }
            if (staffPassword.Length > 30)
            {
                Error = Error + "The Staff Password must be less than 30 : </br>";
            }

            //Email
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The Email may not be blank : </br>";
            }
            if (email.Length > 40)
            {
                Error = Error + "The Email must be less than 40 : </br>";
            }

            //lastUpdated
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the lastUpdated value to the DateTemp variable
                DateTemp = Convert.ToDateTime(lastUpdated);
                //check to see if the date is less than todays date
                if (DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past : </br>";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in the future : </br>";
                }
            }

            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : </br>";
            }
            //Role
            if (role.Length == 0)
            {
                //record the error
                Error = Error + "The Role may not be blank : </br>";
            }
            if (role.Length > 30)
            {
                Error = Error + "The Role must be less than 30 : </br>";
            }
            //return any error messages
            return Error;
        }

        /***** Statistics Grouped by Role METHOD *****/
        public DataTable StatisticsGroupedByStaffFullName()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Count_GroupByStaffFullName");
            //there should either zero, one, or more records
            return DB.DataTable;
        }

        public DataTable StatisticsGroupedByRole()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Count_GroupByRole");
            //there should either zero, one, or more records
            return DB.DataTable;
        }

        public DataTable StatisticsGroupedByIsActive()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Count_GroupIsActive");
            //there should either zero, one, or more records
            return DB.DataTable;
        }
    }
}
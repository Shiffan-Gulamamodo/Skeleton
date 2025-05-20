using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private member data for thisStaff
        clsStaff mThisStaff = new clsStaff();

        public clsStaffCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsStaff AStaff = new clsStaff();
                //read in the fields for the current record
                AStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AStaff.StaffFullName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFullName"]);
                AStaff.StaffPassword = Convert.ToString(DB.DataTable.Rows[Index]["StaffPassword"]);
                AStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AStaff.lastUpdated = Convert.ToDateTime(DB.DataTable.Rows[Index]["lastUpdated"]);
                AStaff.isActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["isActive"]);
                AStaff.Role = Convert.ToString(DB.DataTable.Rows[Index]["Role"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }

        public List<clsStaff> StaffList 
        {
            get
            { 
                //return the private data
                return mStaffList;
            } 
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        public int Count 
        {
            get
            { 
                //return the count of the list
                return mStaffList.Count;
            } 
            set
            {

            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters
            DB.AddParameter("@StaffFullName", mThisStaff.StaffFullName);
            DB.AddParameter("@StaffPassword", mThisStaff.StaffPassword);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Role", mThisStaff.Role);
            DB.AddParameter("@lastUpdated", mThisStaff.lastUpdated);
            DB.AddParameter("@isActive", mThisStaff.isActive);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@StaffFullName", mThisStaff.StaffFullName);
            DB.AddParameter("@StaffPassword", mThisStaff.StaffPassword);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Role", mThisStaff.Role);
            DB.AddParameter("@lastUpdated", mThisStaff.lastUpdated);
            DB.AddParameter("@isActive", mThisStaff.isActive);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }
    }
}
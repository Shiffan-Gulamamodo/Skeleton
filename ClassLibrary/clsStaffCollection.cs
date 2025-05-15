using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();

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
        public clsStaff ThisStaff { get; set; }
    }
}
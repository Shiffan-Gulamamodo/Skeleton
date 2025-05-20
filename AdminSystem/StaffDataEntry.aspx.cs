using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Staff to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffId != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        //create an instance of the Staff
        clsStaffCollection Staff = new clsStaffCollection();
        //find the record to update
        Staff.ThisStaff.Find(StaffId);
        //display the data for the record
        txtStaffId.Text = Staff.ThisStaff.StaffId.ToString();
        txtStaffFullName.Text = Staff.ThisStaff.StaffFullName.ToString();
        txtStaffPassword.Text = Staff.ThisStaff.StaffPassword.ToString();
        txtEmail.Text = Staff.ThisStaff.Email.ToString();
        txtLastUpdated.Text = Staff.ThisStaff.lastUpdated.ToString();
        chkActive.Checked = Staff.ThisStaff.isActive;
        txtRole.Text = Staff.ThisStaff.Role.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
   
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the Staff's FullName
        string StaffFullName = txtStaffFullName.Text;
        //capture the Staff's Password
        string StaffPassword = txtStaffPassword.Text;
        //capture the Staff's Email
        string Email = txtEmail.Text;
        //capture the Staff's Last Updated changes
        string lastUpdated = txtLastUpdated.Text;
        //capture the Staff's Role
        string Role = txtRole.Text;
        //capture isActive checkbox
        string isActive = chkActive.Text;
        //store the Staff Data in the session object
        string Error = "";
        //validate the data
        Error = AStaff.Valid(StaffFullName, StaffPassword, Email, lastUpdated, Role);
        if (Error == "")
        {
            //capture the Staff's ID
            AStaff.StaffId = StaffId;
            //capture the Staff's Full Name
            AStaff.StaffFullName = StaffFullName;
            //capture the Staff's Password
            AStaff.StaffPassword = StaffPassword;
            //capture the Staff's Email
            AStaff.Email = Email;
            //capture the Staff's lastUpdated changes
            AStaff.lastUpdated = Convert.ToDateTime(lastUpdated);
            //capture the Staff's Role
            AStaff.Role = Role;
            //capture if the Staff is Active
            AStaff.isActive = chkActive.Checked;
            //create a new instance of the Staff collection
            clsStaffCollection StaffList = new clsStaffCollection();
            
            //if this is a new record i.e. StaffId = -1 then add the data
            if (StaffId == -1)
            {
                //set the ThisStaff property
                StaffList.ThisStaff = AStaff;
                //add the new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else 
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffId);
                //set the ThisAddress property
                StaffList.ThisStaff = AStaff;
                //update the record
                StaffList.Update();
            }
            //redirect back to the list page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff class
        clsStaff AStaff = new clsStaff();
        //create a variable to store the primary key
        Int32 StaffId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = AStaff.Find(StaffId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaffFullName.Text = AStaff.StaffFullName;
            txtStaffPassword.Text = AStaff.StaffPassword;
            txtEmail.Text = AStaff.Email;
            txtLastUpdated.Text = AStaff.lastUpdated.ToString();
            txtRole.Text = AStaff.Role;
            chkActive.Checked = AStaff.isActive;
        }
    }
}
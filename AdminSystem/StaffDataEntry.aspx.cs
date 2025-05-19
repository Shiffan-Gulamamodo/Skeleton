using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
            //set the ThisStaff property
            StaffList.ThisStaff = AStaff;
            //add the new record
            StaffList.Add();
            //redirect to the list page
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
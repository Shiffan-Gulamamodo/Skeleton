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
        txtStaffId1.Text = Staff.ThisStaff.StaffId.ToString();
        txtStaffFullName1.Text = Staff.ThisStaff.StaffFullName.ToString();
        txtStaffPassword1.Text = Staff.ThisStaff.StaffPassword.ToString();
        txtEmail1.Text = Staff.ThisStaff.Email.ToString();
        txtLastUpdated1.Text = Staff.ThisStaff.lastUpdated.ToString();
        chkActive1.Checked = Staff.ThisStaff.isActive;
        txtRole1.Text = Staff.ThisStaff.Role.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
   
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the Staff's FullName
        string StaffFullName = txtStaffFullName1.Text;
        //capture the Staff's Password
        string StaffPassword = txtStaffPassword1.Text;
        //capture the Staff's Email
        string Email = txtEmail1.Text;
        //capture the Staff's Last Updated changes
        string lastUpdated = txtLastUpdated1.Text;
        //capture the Staff's Role
        string Role = txtRole1.Text;
        //capture isActive checkbox
        string isActive = chkActive1.Text;
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
            AStaff.isActive = chkActive1.Checked;
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
            lblError1.Text = Error;
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
        StaffId = Convert.ToInt32(txtStaffId1.Text);
        //find the record
        Found = AStaff.Find(StaffId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaffFullName1.Text = AStaff.StaffFullName;
            txtStaffPassword1.Text = AStaff.StaffPassword;
            txtEmail1.Text = AStaff.Email;
            txtLastUpdated1.Text = AStaff.lastUpdated.ToString();
            txtRole1.Text = AStaff.Role;
            chkActive1.Checked = AStaff.isActive;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to the list page
        Response.Redirect("StaffList.aspx");
    }


    protected void btnReturnToMM_Click(object sender, EventArgs e)
    {
        //redirect to the Main Menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}
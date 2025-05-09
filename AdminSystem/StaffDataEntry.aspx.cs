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
        //capture the Staff's ID
        AStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
        //capture the Staff's FullName
        AStaff.StaffFullName = txtStaffFullName.Text;
        //capture the Staff's Password
        AStaff.StaffPassword = txtStaffPassword.Text;
        //capture the Staff's Email
        AStaff.Email = txtEmail.Text;
        //capture the Staff's Last Updated changes
        AStaff.lastUpdated = DateTime.Now;
        //capture the Staff's Role
        AStaff.Role = txtRole.Text;
        //caoture isActive checkbox
        AStaff.isActive = chkActive.Checked;
        //store the Staff Data in the session object
        Session["AStaff"] = AStaff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
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
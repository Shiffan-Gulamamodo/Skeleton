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
}
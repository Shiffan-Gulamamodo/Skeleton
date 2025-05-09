using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //get the data from the session object
        AStaff = (clsStaff)Session["AStaff"];
        //display the Staff's Id
        Response.Write(AStaff.StaffId + "<br/>");
        //display the FullName for this entry
        Response.Write(AStaff.StaffFullName + "<br/>");
        //display the Email for this entry
        Response.Write(AStaff.Email + "<br/>");
        //display the Last Updated Changes
        Response.Write(AStaff.lastUpdated + "<br/>");
        //display the Staff's role
        Response.Write(AStaff.Role + "<br/>");
        //display whether the staff is active or not
        Response.Write(AStaff.isActive + "<br/>");
    }
}
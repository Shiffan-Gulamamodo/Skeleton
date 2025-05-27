using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaffs();
        }
    }

    void DisplayStaffs()
    {
        //create an instance of the Staff Collection
        clsStaffCollection Staffs = new clsStaffCollection();
        //set the data source to list of addresses in the collection
        lstStaffList1.DataSource = Staffs.StaffList;
        //set the name of the primary key
        lstStaffList1.DataValueField = "StaffId";
        //set the data field to display
        lstStaffList1.DataTextField = "StaffFullName";
        //bind the data to the list
        lstStaffList1.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StaffId;
        //if a record has been selected from the list
        if (lstStaffList1.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList1.SelectedValue);
            //store the data in the session object
            Session["StaffId"] = StaffId;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else        //if no record has been selected
        {
            lblError1.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 StaffId;
        //if a record has been selected from the list
        if (lstStaffList1.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            StaffId = Convert.ToInt32(lstStaffList1.SelectedValue);
            //store the data in the session object
            Session["StaffId"] = StaffId;
            //redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error message
            lblError1.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsStaffCollection AStaff = new clsStaffCollection();
        //retrieve the value of role from the presentation layer
        AStaff.ReportByRole(txtFilter1.Text);
        //set the data source to the list of addresses in the collection
        lstStaffList1.DataSource = AStaff.StaffList;
        //set the name of the primary key
        lstStaffList1.DataValueField = "StaffId";
        //set the name of the field to display
        lstStaffList1.DataTextField = "Role";
        //bind the data to the list
        lstStaffList1.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsStaffCollection AStaff = new clsStaffCollection();
        //set an empty string
        AStaff.ReportByRole("");
        //clear any existing filter to tidy up the interface
        txtFilter1.Text = "";
        //set the data source to the list of staff in the collection
        lstStaffList1.DataSource = AStaff.StaffList;
        //set the name of the primary key
        lstStaffList1.DataValueField = "StaffId";
        //set the name of the field to display
        lstStaffList1.DataTextField = "Role";
        //bind the data to the list
        lstStaffList1.DataBind();
    }
    protected void btnStatistics_Click(object sender, EventArgs e)
    {
        //redirect to the Statistics page
        Response.Redirect("StaffStatistics.aspx");
    }

    protected void btnReturnToMM_Click(object sender, EventArgs e)
    {
        //redirect to Main Menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}
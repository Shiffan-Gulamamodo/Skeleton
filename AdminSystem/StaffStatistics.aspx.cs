using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StaffStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff clsstaff = new clsStaff();

        //retrieve data from the database
        DataTable dT = clsstaff.StatisticsGroupedByStaffFullName();

        //upload dT into GridView
        GridViewStGroupByStaffFullName.DataSource = dT;
        GridViewStGroupByStaffFullName.DataBind();

        //change the header of the first column
        GridViewStGroupByStaffFullName.HeaderRow.Cells[0].Text = " Total ";


        //retrieve data from the database
        DataTable dT2 = clsstaff.StatisticsGroupedByRole();

        //upload dT into GridView
        GridViewStGroupByRole.DataSource = dT2;
        GridViewStGroupByRole.DataBind();

        //change the header of the first column
        GridViewStGroupByRole.HeaderRow.Cells[0].Text = " Total ";

        //retrieve data from the database
        DataTable dT3 = clsstaff.StatisticsGroupedByIsActive();

        //upload dT into GridView
        GridViewStGroupByIsActive.DataSource = dT3;
        GridViewStGroupByIsActive.DataBind();

        //change the header of the first column
        GridViewStGroupByIsActive.HeaderRow.Cells[0].Text = " Total ";
    }

    protected void BtnPrv_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}
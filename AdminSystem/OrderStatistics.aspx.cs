using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class OrderStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder clsorder = new clsOrder();
        DataTable dT = clsorder.StatisticsGroupedByCustomerID();

        GridViewStCustomerID.DataSource = dT;
        GridViewStCustomerID.DataBind();

        GridViewStCustomerID.HeaderRow.Cells[0].Text = " Total ";
        dT = clsorder.StatisticsGroupedByStaffID();

        GridViewStStaffID.DataSource = dT;
        GridViewStStaffID.DataBind();

        GridViewStStaffID.HeaderRow.Cells[0].Text = " Total ";
        dT = clsorder.StatisticsGroupedByOrderDate();

        GridViewStOrderDate.DataSource = dT;
        GridViewStOrderDate.DataBind();

        GridViewStOrderDate.HeaderRow.Cells[0].Text = " Total ";
    }


    protected void BtnPrv_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderDataEntry.aspx");
    }
}
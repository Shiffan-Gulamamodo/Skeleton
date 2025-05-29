​using ClassLibrary;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _SupplierStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSupplier clsSupplier = new clsSupplier();
        //retrieve data from the database
        DataTable dT = clsSupplier.StatisticsGroupedDeliveryDate();

        //upload dT into GridView
        GridViewStGroupByDeliveryDate.DataSource = dT;
        GridViewStGroupByDeliveryDate.DataBind();

        //change the header of the first column
        GridViewStGroupByDeliveryDate.HeaderRow.Cells[0].Text = " Total ";

        //retrieve data from the database
        dT = clsSupplier.StatisticsGroupedIsAvailable();

        //upload dT into GridView
        GridViewStGroupByIsAvailable.DataSource = dT;
        GridViewStGroupByIsAvailable.DataBind();

        //change the header of the first column
        GridViewStGroupByIsAvailable.HeaderRow.Cells[0].Text = " Total ";
    }


    protected void btnBack_Click(object sender, EventArgs e)
    {
        //redirect to the stock list
        Response.Redirect("SupplierList.aspx");
    }
}
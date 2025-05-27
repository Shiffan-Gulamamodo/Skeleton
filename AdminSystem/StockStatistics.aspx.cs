using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StockStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock clsstock = new clsStock();

        //retrieve data from the database
        DataTable dT = clsstock.StatisticsGroupedBySupplierId();

        //upload dT into GridView
        GridViewStGroupBySupplierId.DataSource = dT;
        GridViewStGroupBySupplierId.DataBind();

        //change the header of the first column
        GridViewStGroupBySupplierId.HeaderRow.Cells[0].Text = " Total ";


        //retrieve data from the database
        DataTable dT2 = clsstock.StatisticsGroupedByProductName();

        //upload dT into GridView
        GridViewStGroupByProductName.DataSource = dT2;
        GridViewStGroupByProductName.DataBind();

        //change the header of the first column
        GridViewStGroupByProductName.HeaderRow.Cells[0].Text = " Total ";

        //retrieve data from the database
        DataTable dT3 = clsstock.StatisticsGroupedByDateAdded();

        //upload dT into GridView
        GridViewStGroupByDateAdded.DataSource = dT3;
        GridViewStGroupByDateAdded.DataBind();

        //change the header of the first column
        GridViewStGroupByDateAdded.HeaderRow.Cells[0].Text = " Total ";
    }


    protected void BtnPrv_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}
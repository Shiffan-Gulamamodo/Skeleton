using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer clsCustomer = new clsCustomer();

        //Retrieve Data from the Database 
        DataTable dT = clsCustomer.StatisticsGroupedByCustomerAddress();

        //Upload dT into GridView
        GridViewStGroupByAddress.DataSource = dT;
        GridViewStGroupByAddress.DataBind();

        //Change the Header of the first Column 
        GridViewStGroupByAddress.HeaderRow.Cells[0].Text = "Total";

        //Retrieve Data from Database 
        dT = clsCustomer.StatisticsGroupedByCustomerAccountCreatedAt();

        //Upload dT into GridView
        GridViewStGroupByCreatedDate.DataSource = dT;
        GridViewStGroupByCreatedDate.DataBind();

        //Change the Header of the first Column 
        GridViewStGroupByCreatedDate.HeaderRow.Cells[0].Text = "Total";

        //Retrieve Data from Database 
        dT = clsCustomer.StatisticsGroupedByIsCustomerAccountActive();

        //Upload dT into GridView
        GridViewStGroupByActive.DataSource = dT;
        GridViewStGroupByActive.DataBind();

        //Change the Header of the first Column 
        GridViewStGroupByActive.HeaderRow.Cells[0].Text = "Total";
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        //Redirects back to List Page
        Response.Redirect("CustomerList.aspx");
    }
}
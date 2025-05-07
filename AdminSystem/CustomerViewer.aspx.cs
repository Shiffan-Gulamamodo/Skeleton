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
        //Create a new Instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //Get the Data form the session Object 
        ACustomer = (clsCustomer)Session["ACustomer"];
        //Display the Customer Full Name for this entry
        Response.Write(ACustomer.CustomerId + "<br />");
        Response.Write(ACustomer.CustomerFullName + "<br />");
        Response.Write(ACustomer.CustomerEmail + "<br />");
        Response.Write(ACustomer.CustomerPassword + "<br />");
        Response.Write(ACustomer.CustomerAddress + "<br />");
        Response.Write(ACustomer.CustomerAccountCreatedAt + "<br />");
        Response.Write(ACustomer.IsCustomerAccountActive);

    }
}
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
        Response.Write("Customer ID: " + ACustomer.CustomerId + "<br />");
        Response.Write("Customer FullName: " + ACustomer.CustomerFullName + "<br />");
        Response.Write("Customer Email: " + ACustomer.CustomerEmail + "<br />");
        Response.Write("Customer Password: " + ACustomer.CustomerPassword + "<br />");
        Response.Write("Customer Address: " + ACustomer.CustomerAddress + "<br />");
        Response.Write("Customer Account Created At: " + ACustomer.CustomerAccountCreatedAt + "<br />");
        Response.Write("Is Customer Account Active: " + ACustomer.IsCustomerAccountActive);

    }
}
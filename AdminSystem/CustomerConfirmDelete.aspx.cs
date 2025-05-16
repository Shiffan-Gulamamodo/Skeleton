using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //Variable to store the primary key value of the record to be deleted 
    Int32 CustomerId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //Get the number of the Customer to be deleted from the session object
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //Create a new Instance of the Customer Collection Class 
        clsCustomerCollection Customer = new clsCustomerCollection();
        //Find the record to Delete 
        Customer.ThisCustomer.Find(CustomerId);
        //Delete the Record 
        Customer.Delete();
        //Redirect back to the Main Page 
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //Redirect back to the main Page 
        Response.Redirect("CustomerList.aspx");
    }
}
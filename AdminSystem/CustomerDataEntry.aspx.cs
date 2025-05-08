using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtCustomerPassword_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsCustomer 
        clsCustomer ACustomer = new clsCustomer();
        //Capture the Customer Id 
        ACustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //Capture the Customer FullName 
        ACustomer.CustomerFullName = txtCustomerFullName.Text;
        //Capture the Customer Email
        ACustomer.CustomerEmail = txtCustomerEmail.Text;
        //Capture the Customer Password
        ACustomer.CustomerPassword = txtCustomerPassword.Text;
        //Capture the Customer Address
        ACustomer.CustomerAddress = txtCustomerAddress.Text;
        //Capture the Customer Account Created At
        ACustomer.CustomerAccountCreatedAt = Convert.ToDateTime(txtCustomerAccountCreatedAt.Text);
        //Capture Active Check Box 
        ACustomer.IsCustomerAccountActive= chkIsCustomerAccountActive.Checked;
        //Stores the Customer Full Name in the session Object 
        Session["ACustomer"] = ACustomer;
        //Navigate to the View Page
        Response.Redirect("CustomerViewer.aspx");
    }
}
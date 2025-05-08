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
        ACustomer.CustomerAccountCreatedAt = Convert.ToDateTime(DateTime.Now);
        //Capture Active Check Box 
        ACustomer.IsCustomerAccountActive= chkIsCustomerAccountActive.Checked;
        //Stores the Customer Full Name in the session Object 
        Session["ACustomer"] = ACustomer;
        //Navigate to the View Page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsCustomer 
        clsCustomer ACustomer = new clsCustomer();
        //Create a variable to store the primary key 
        Int32 CustomerId;
        //Create a variable to store the result of the find operation 
        Boolean Found = false;
        //Get the primary key entered by the user 
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //Find the record 
        Found = ACustomer.Find(CustomerId);
        //If Found 
        if (Found == true) 
        {
            //Displaying the values of the properties in the form 
            txtCustomerFullName.Text = ACustomer.CustomerFullName;
            txtCustomerEmail.Text = ACustomer.CustomerEmail.ToString();
            txtCustomerPassword.Text = ACustomer.CustomerPassword;
            txtCustomerAddress.Text = ACustomer.CustomerAddress.ToString();
            txtCustomerAccountCreatedAt.Text = ACustomer.CustomerAccountCreatedAt.ToString();
            chkIsCustomerAccountActive.Checked = ACustomer.IsCustomerAccountActive;
        }
    }
}
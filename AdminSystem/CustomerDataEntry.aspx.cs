﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //Variable to store the primary key with page level scope
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Get the number of the Customer to be processed 
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            //If this Customer is not a new record 
            if (CustomerId != -1)
            {
                //Display the Current data for the record 
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        //Create an instance of the Customer 
        clsCustomerCollection Customer = new clsCustomerCollection();
        //Find the record to update 
        Customer.ThisCustomer.Find(CustomerId);
        
        //Display the Data for the Record 
        txtCustomerId.Text = Customer.ThisCustomer.CustomerId.ToString();
        txtCustomerFullName.Text = Customer.ThisCustomer.CustomerFullName.ToString();
        txtCustomerEmail.Text = Customer.ThisCustomer.CustomerEmail.ToString();
        txtCustomerPassword.Text = Customer.ThisCustomer.CustomerPassword.ToString();
        txtCustomerAddress.Text = Customer.ThisCustomer.CustomerAddress.ToString();
        txtCustomerAccountCreatedAt.Text = Customer.ThisCustomer.CustomerAccountCreatedAt.ToString();
        chkIsCustomerAccountActive.Checked = Customer.ThisCustomer.IsCustomerAccountActive;
        
        
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
        //Capture the Customer FullName 
        string CustomerFullName = txtCustomerFullName.Text;
        //Capture the Customer Email
        string CustomerEmail = txtCustomerEmail.Text;
        //Capture the Customer Password
        string CustomerPassword = txtCustomerPassword.Text;
        //Capture the Customer Address
        string CustomerAddress = txtCustomerAddress.Text;
        //Capture the Customer Account Created At
        string CustomerAccountCreatedAt = txtCustomerAccountCreatedAt.Text;
        //Capture Active Check Box 
        string IsCustomerAccountActive= chkIsCustomerAccountActive.Text;
        //Variable to store any error messages
        string Error = "";
        //Validate the data 
        Error = ACustomer.Valid(CustomerFullName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerAccountCreatedAt);
        if (Error == "")
        {
            //Capture the Customer Id
            ACustomer.CustomerId = CustomerId; //Importamt Part
            //Capture the Customer Full Name 
            ACustomer.CustomerFullName = CustomerFullName;
            //Capture the Customer Email 
            ACustomer.CustomerEmail = CustomerEmail;
            //Capture the Customer Password 
            ACustomer.CustomerPassword = CustomerPassword;
            //Capture the Customer Address 
            ACustomer.CustomerAddress = CustomerAddress;
            //Capture the Customer Account Created At 
            ACustomer.CustomerAccountCreatedAt = Convert.ToDateTime(CustomerAccountCreatedAt);
            //Capture the IsCustomerAccountActive Property
            ACustomer.IsCustomerAccountActive = chkIsCustomerAccountActive.Checked;
            //Create a new instance of the Customer Collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //If this is a new record i.e. CustomerId  = -1 then add the data 
            if (CustomerId == -1)
            {
                //Set the ThisCustomer Property 
                CustomerList.ThisCustomer = ACustomer;
                //Add the new record 
                CustomerList.Add();
            }
            //Otherwise it must be an Update 
            else
            {
                //Find the record to Update 
                CustomerList.ThisCustomer.Find(CustomerId);
                //Set the ThisCustomer Property 
                CustomerList.ThisCustomer = ACustomer;
                //Update the Record 
                CustomerList.Update();
            }
            //Navigate to the List Page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //Display the Error Message 
            lblError.Text = Error;
        }

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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //Redirect the user back to the List Page 
        Response.Redirect("CustomerList.aspx");
    }
}
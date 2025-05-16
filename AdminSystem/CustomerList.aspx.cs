using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //If this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            //Update the List Box 
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //Create an instance of the Customer Collection 
        clsCustomerCollection Customers = new clsCustomerCollection();
        //Set the Data source to list of Customers in the Collection 
        lstCustomerList.DataSource = Customers.CustomerList;
        //Set the name of the primary key 
        lstCustomerList.DataValueField = "CustomerId";
        //Set the Data field to Display 
        lstCustomerList.DataTextField = "CustomerFullName";
        //Bind the Data to the List 
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Store -1 into the session Object to indicate this is a new record 
        Session["CustomerId"] = -1;
        //Redirect to the Data Entry Page 
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Variable to store the primary key value of the record to be edited 
        Int32 CustomerId;
        //If a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //Get the primary key value of the record to edit 
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //Store the data in the session object 
            Session["CustomerId"] = CustomerId;
            //Redirect to the Edit Page 
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else   //If no record has been selected to edit 
        {
            lblError.Text = "Please Select a record from the Customer List to edit";
        }
    }
}
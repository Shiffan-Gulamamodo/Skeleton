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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //capture the supplier id
        string SupplierId = txtSupplierID.Text;
        //capture the Product Name
        string ProductName = txtProductName.Text;
        //capture the price
        string Price = txtPrice.Text;
        //capture the stock quantity
        string StockQuantity = txtStockQuantity.Text;
        //capture the Date Added
        string DateAdded = txtDateAdded.Text;
        //capture the in stock check box
        string InStock = chkInStock.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStock.Valid(ProductName, DateAdded);
        if (Error == "")
        {
            //capture the Product Name
            AStock.ProductName = ProductName;
            //capture the Date Added
            AStock.DateAdded = Convert.ToDateTime(DateAdded);
            //store the stock in the session object
            Session["AStock"] = AStock;
            //navigate to the view page
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create a new instance of stock class
        clsStock AStock = new clsStock();
        //variable to store the primary key
        Int32 StockId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StockId = Convert.ToInt32(txtStockID.Text);
        //find the record
        Found = AStock.Find(StockId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtProductName.Text = AStock.ProductName;
            txtStockQuantity.Text = AStock.StockQuantity.ToString();
            txtSupplierID.Text = AStock.SupplierId.ToString();
            txtDateAdded.Text = AStock.DateAdded.ToString();
            txtPrice.Text = AStock.Price.ToString();
            chkInStock.Checked = AStock.InStock;
        }
    }
}

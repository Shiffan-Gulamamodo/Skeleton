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
        //capture the product name
        AStock.ProductName = txtProductName.Text;
        //capture the stock quantity
        AStock.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);
        //capture the stock ID
        AStock.StockId = Convert.ToInt32(txtStockID.Text);
        //capture the supplier ID
        AStock.SupplierId = Convert.ToInt32(txtSupplierID.Text);
        //capture the date added
        AStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        //capture the price
        AStock.Price = Convert.ToDecimal(txtPrice.Text);
        //capture the in stock status
        AStock.InStock = chkInStock.Checked;
        //store the stock data in the session object
        Session["AStock"] = AStock;
        //navigate to the view page
        Response.Redirect("StockViewer.aspx");
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

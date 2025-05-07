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
        AStock.StockID = Convert.ToInt32(txtStockID.Text);
        //capture the supplier ID
        AStock.SupplierID = Convert.ToInt32(txtSupplierID.Text);
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
}
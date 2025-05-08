using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //get the data from the session object
        AStock = (clsStock)Session["AStock"];
        //display the product name
        Response.Write("Product Name: "+AStock.ProductName + "<br/>");
        //display the stock quantity
        Response.Write("Stock Quantity: "+AStock.StockQuantity + "<br/>");
        //display the stock ID
        Response.Write("Stock Id: "+AStock.StockID + "<br/>");
        //display the supplier ID
        Response.Write("Supplier Id: "+AStock.SupplierID + "<br/>");
        //display the date added
        Response.Write("Date Added: "+AStock.DateAdded + "<br/>");
        //display the price
        Response.Write("Price: "+AStock.Price + "<br/>");
        //display the in stock status
        Response.Write("Stock Status: "+AStock.InStock + "<br/>");
        
    }
}
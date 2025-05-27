using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StockId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to be processed
        StockId = Convert.ToInt32(Session["StockId"]);
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (StockId != -1)
            {
                //display the current data for the record
                DisplayStock();
            }
        }
    }
    void DisplayStock()
    {
        //create an instance of the stock 
        clsStockCollection Stock = new clsStockCollection();
        //find the record to update
        Stock.ThisStock.Find(StockId);
        //display the data for the record
        txtStockID.Text = Stock.ThisStock.StockId.ToString();
        txtSupplierID.Text = Stock.ThisStock.SupplierId.ToString();
        txtProductName.Text = Stock.ThisStock.ProductName;
        txtPrice.Text = Stock.ThisStock.Price.ToString();
        txtStockQuantity.Text = Stock.ThisStock.StockQuantity.ToString();
        txtDateAdded.Text = Stock.ThisStock.DateAdded.ToString();
        chkInStock.Checked = Stock.ThisStock.InStock;
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
            //capture the stock id
            AStock.StockId = StockId;
            //capture the Product Name
            AStock.ProductName = ProductName;
            //capture the price
            AStock.Price = Convert.ToDecimal(Price);
            //capture the stock quantity
            AStock.StockQuantity = Convert.ToInt32(StockQuantity);
            //capture the supplier id
            AStock.SupplierId = Convert.ToInt32(SupplierId);
            //capture the in stock value
            AStock.InStock = chkInStock.Checked;
            //capture the Date Added
            AStock.DateAdded = Convert.ToDateTime(DateAdded);
            //create a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record i. e. StockId = -1 then add the data
            if (StockId == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //add the new record
                StockList.Add();
            }
            //otherwise it must be an update 
            else
            {
                //find the record to update
                StockList.ThisStock.Find(StockId);
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //update the record
                StockList.Update();
            }

            //redirect back to the list page
            Response.Redirect("StockList.aspx");
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
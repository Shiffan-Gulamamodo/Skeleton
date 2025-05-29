using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 SupplyId;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplyId = Convert.ToInt32(Session["SupplyID"]);
        if (IsPostBack == false)
        {
            if (SupplyId != -1)
            {
                DisplaySupplier();
            }
        }
    }

    void DisplaySupplier()
    {
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        SupplierBook.ThisSupplier.Find(SupplyId);
        txtSupplierID.Text = SupplierBook.ThisSupplier.SupplyId.ToString();
        txtDeliveryDate.Text = SupplierBook.ThisSupplier.DeliveryDate.ToShortDateString();
        txtPhoneName.Text = SupplierBook.ThisSupplier.PhoneName;
        chkIsAvailable.Text = SupplierBook.ThisSupplier.IsAvailable.ToString();
        txtStockID.Text = SupplierBook.ThisSupplier.StockID.ToString();

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsSupplier ASupplier = new clsSupplier();
        string PhoneName = txtPhoneName.Text;
        string DeliveryDate = txtDeliveryDate.Text;
        string IsAvailable = chkIsAvailable.Text;
        string StockId = txtStockID.Text;
        
        string Error = "";
        Error = ASupplier.Valid( PhoneName,  DeliveryDate,  IsAvailable);
        if (Error == "")
        {
            ASupplier.SupplyId = SupplyId;
            ASupplier.PhoneName = PhoneName;
            ASupplier.DeliveryDate = Convert.ToDateTime(DeliveryDate);
            ASupplier.IsAvailable = Convert.ToBoolean(IsAvailable);
            ASupplier.StockID = Convert.ToInt32(StockId);
           clsSupplierCollection SupplierList = new clsSupplierCollection();

            if (SupplyId == -1)
            {
                SupplierList.ThisSupplier = ASupplier;
                SupplierList.Add();
            }

            else
            {
                SupplierList.ThisSupplier.Find(SupplyId);
                SupplierList.ThisSupplier = ASupplier;
                SupplierList.Update();
            }
             Response.Redirect("SupplierList.aspx");
            
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtDeliveryDate_TextChanged(object sender, EventArgs e)
    {


    }

    protected void chkIsAvailable_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("");
    }
}
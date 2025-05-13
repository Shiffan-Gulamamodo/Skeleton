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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsSupplier ASupplier = new clsSupplier();
        ASupplier.SupplyId = Convert.ToInt32(txtSupplierID.Text);
        ASupplier.StockID = Convert.ToInt32(txtStockID.Text);
        ASupplier.PhoneName = txtPhoneName.Text;
        ASupplier.DeliveryDate = Convert.ToDateTime(txtDeliveryDate.Text);
        ASupplier.IsAvailable = chkIsAvailable.Checked;
        Session["ASupplier"] = ASupplier;
        Response.Redirect("SupplierViewer.aspx");
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
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
        string PhoneName = txtPhoneName.Text;
        string DeliveryDate = txtDeliveryDate.Text;
        bool IsAvailable = chkIsAvailable.Checked;
        string Error = "";
        if (Error == "")
        {
            ASupplier.PhoneName = PhoneName;
            ASupplier.DeliveryDate = Convert.ToDateTime(DeliveryDate);
            ASupplier.IsAvailable = Convert.ToBoolean(IsAvailable);
            Session["ASupplier"] = ASupplier;
            Response.Redirect("SupplierViewer.aspx");
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
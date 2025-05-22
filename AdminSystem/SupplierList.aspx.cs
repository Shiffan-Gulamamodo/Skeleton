using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {


    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierId"] = -1;
        Response.Redirect("SupplierBookDatEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 SupplyId;
        if (lstSupplierList.SelectedIndex != -1)
        {
            SupplyId = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierId"] = SupplyId;
            Response.Redirect("SupplierDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }

    }




}

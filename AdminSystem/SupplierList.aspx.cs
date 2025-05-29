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
        if (IsPostBack == false)

        {
            DisplaySupplier();
        }
    }
    void DisplaySupplier()
    {
        // Create an instance of the supplier collection
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        //set the data source of the list box to the supplier list
        lstSupplierList.DataSource = ASupplier.SupplierList;
        //set the name of the primary key
        lstSupplierList.DataValueField = "SupplyId";
        //set the data field to display
        lstSupplierList.DataTextField = "PhoneName";
        //bind the data to the list box
        lstSupplierList.DataBind();
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {


    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierId"] = -1;
        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnEdit_Click1(object sender, EventArgs e)
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





    protected void btnDelete_Click(object sender, EventArgs e)
    { 
        Int32 SupplyId;
        if (lstSupplierList.SelectedIndex != -1)
        {
            SupplyId = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierId"] = SupplyId;
            Response.Redirect("SupplierDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }

    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // Create an instance of the supplier object
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        //retrieve the value of the phone name from the presentation layer
        ASupplier.ReportByPhoneName(txtFilter.Text);
        //set the data source of the list box to the filtered supplier list
        lstSupplierList.DataSource = ASupplier.SupplierList;
        //set the name of the primary key
        lstSupplierList.DataValueField = "SupplyId";
        //set the data field to display
        lstSupplierList.DataTextField = "PhoneName";
        //bind the data to the list box
        lstSupplierList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // Create an instance of the supplier object
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        //set an empty string
        ASupplier.ReportByPhoneName("");
        //clear any existing filter to tidy up interface
        txtFilter.Text = "";
        //set the data source of the list box to the filtered supplier list
        lstSupplierList.DataSource = ASupplier.SupplierList;
        //set the name of the primary key
        lstSupplierList.DataValueField = "SupplyId";
        //set the data field to display
        lstSupplierList.DataTextField = "PhoneName";
        //bind the data to the list box
        lstSupplierList.DataBind();
    }

}

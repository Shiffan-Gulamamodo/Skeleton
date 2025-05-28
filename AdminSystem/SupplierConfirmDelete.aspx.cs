using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{ 
    Int32 SupplyId;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplyId = Convert.ToInt32(Session["SupplierId"]);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the supplier collection
        ClassLibrary.clsSupplierCollection SupplierBook = new ClassLibrary.clsSupplierCollection();
        //find the record to delete
        SupplierBook.ThisSupplier.Find(SupplyId);
        //delete the record
        SupplierBook.Delete();
        //redirect back to the main page
        Response.Redirect("SupplierList.aspx");
    }
    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("SupplierList.aspx");
    }




}

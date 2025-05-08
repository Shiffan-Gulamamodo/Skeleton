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
        clsOrder AnOrder = new clsOrder();
        AnOrder.DeliveryAddress = txtDeliveryAddress.Text;
        Response.Redirect("OrderViewer.aspx");
        AnOrder.OrderID = Convert.ToInt32(txtOrderId.Text);
        AnOrder.StaffID = Convert.ToInt32(txtStaffId.Text);
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        AnOrder.CustomerID = Convert.ToInt32(txtCustomerId.Text);
        AnOrder.OrderLineID = Convert.ToInt32(txtOrderLineId.Text);
        AnOrder.IsPaid = chkIsPaid.Checked;
    }
}
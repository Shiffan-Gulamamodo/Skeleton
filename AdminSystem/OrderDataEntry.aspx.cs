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
        string DeliveryAddress = txtDeliveryAddress.Text;
        string OrderID = txtOrderId.Text;
        string StaffID = txtStaffId.Text;
        string OrderDate = txtOrderDate.Text;
        string CustomerID = txtCustomerId.Text;
        string OrderLineID = txtOrderLineId.Text;
        string IsPaid = chkIsPaid.Text;
        string Error = "";
        Error = AnOrder.Valid(DeliveryAddress, OrderDate);
        if (Error == "")
        {
            AnOrder.DeliveryAddress = DeliveryAddress;
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            Session["AnOrder"] = AnOrder;
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        int OrderId;
        Boolean Found = false;
        OrderId = Convert.ToInt32(txtOrderId.Text);
        Found = AnOrder.Find(OrderId);
        if (Found == true)
        {
            txtStaffId.Text = AnOrder.StaffID.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtCustomerId.Text = AnOrder.CustomerID.ToString();
            txtDeliveryAddress.Text = AnOrder.DeliveryAddress;
            txtOrderLineId.Text = AnOrder.OrderLineID.ToString();
            chkIsPaid.Checked = AnOrder.IsPaid;
        }
    }
}
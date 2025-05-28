using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID =Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                DisplayOrder();
            }
        }
    }

    private void DisplayOrder()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderID);
        txtOrderId.Text = OrderBook.ThisOrder.OrderID.ToString();
        txtStaffId.Text = OrderBook.ThisOrder.StaffID.ToString();
        txtOrderDate.Text = OrderBook.ThisOrder.OrderDate.ToString();
        txtCustomerId.Text = OrderBook.ThisOrder.CustomerID.ToString();
        txtDeliveryAddress.Text = OrderBook.ThisOrder.DeliveryAddress;
        txtOrderLineId.Text = OrderBook.ThisOrder.OrderLineID.ToString();
        chkIsPaid.Checked = OrderBook.ThisOrder.IsPaid;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        string DeliveryAddress = txtDeliveryAddress.Text;
        int OrderID = int.Parse(txtOrderId.Text);
        string StaffID = txtStaffId.Text;
        string OrderDate = txtOrderDate.Text;
        string CustomerID = txtCustomerId.Text;
        string OrderLineID = txtOrderLineId.Text;
        bool IsPaid = chkIsPaid.Checked;
        string Error = "";
        Error = AnOrder.Valid(DeliveryAddress, OrderDate);
        if (Error == "")
        {
            AnOrder.OrderID = OrderID;
            AnOrder.DeliveryAddress = DeliveryAddress;
            AnOrder.StaffID = Convert.ToInt32(StaffID);
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            AnOrder.OrderLineID = Convert.ToInt32(OrderLineID);
            AnOrder.IsPaid = IsPaid;
            AnOrder.IsPaid = Convert.ToBoolean(IsPaid);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            clsOrderCollection OrderList = new clsOrderCollection();
            if (OrderID == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
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


    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}
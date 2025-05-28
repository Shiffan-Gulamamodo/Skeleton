using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];

        if (AnOrder != null)
        {
            Response.Write(AnOrder.DeliveryAddress);
        }
        else
        {
            Response.Write("Order not found in session.");
        }
    }
}
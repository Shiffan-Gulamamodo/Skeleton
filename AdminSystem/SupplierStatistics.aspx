<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierStatistics.aspx.cs" Inherits="_SupplierStatistics" %>

<!DOCTYPE html>
<script runat="server">

    protected void btnBack_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                Statistics Page
            </h1>
        </div>
        <div>
            <h3>
                Supplier List- Grouped by DeliveryDate
            </h3>
            <asp:GridView ID="GridViewStGroupByDeliveryDate" runat="server" ></asp:GridView>
        </div>
        <div>
            <h3>
                Supplier List- Grouped by IsAvailable
            </h3>
            <asp:GridView ID="GridViewStGroupByIsAvailable" runat="server"></asp:GridView>
            <asp:Button runat="server" Text="Back to Supplier List" ID="btnBack" OnClick="btnBack_Click"></asp:Button>
        </div>
    </form>
</body>
</html>


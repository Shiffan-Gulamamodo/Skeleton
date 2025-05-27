<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body style="background-color: #FF9900">
    <form id="form1" runat="server">
        <div>
        </div>
        <p style="background-color: #FF9900">
            &nbsp;</p>
        <p class="auto-style1">
            <asp:Label ID="lblMenuTitle" runat="server" Font-Bold="True" Font-Size="24pt" style="z-index: 1; left: 566px; top: 75px; position: absolute" Text="NextGen Phones Main Menu"></asp:Label>
            <asp:Button ID="btnStock" runat="server" height="26px" OnClick="btnStock_Click" style="z-index: 1; left: 549px; top: 148px; position: absolute" Text="Stock" width="101px" />
        </p>
        <p class="auto-style1">
            <asp:Button ID="btnStaff" runat="server" OnClick="btnStaff_Click" style="z-index: 1; left: 422px; top: 148px; position: absolute; width: 101px" Text="Staff" />
            <asp:Button ID="btnOrders" runat="server" OnClick="btnOrders_Click" style="margin-top: 20px; margin-bottom: 0px" Text="Orders" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnCustomer" runat="server" height="26px" OnClick="btnCustomer_Click" style="z-index: 1; left: 685px; top: 148px; position: absolute" Text="Customer" width="101px" />
        <asp:Button ID="btnOrder" runat="server" height="26px" OnClick="btnOrder_Click" style="z-index: 1; left: 818px; top: 148px; position: absolute" Text="Order" width="101px" />
        <asp:Button ID="btnSupplier" runat="server" height="26px" OnClick="btnSupplier_Click" style="z-index: 1; left: 951px; top: 147px; position: absolute" Text="Supplier" width="101px" />
    </form>
</body>
</html>

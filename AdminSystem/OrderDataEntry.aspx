<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 12px; top: 33px; position: absolute" Text="Order ID" width="105px"></asp:Label>
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 148px; top: 32px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 13px; top: 70px; position: absolute" Text="Staff ID" width="105px"></asp:Label>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 12px; top: 107px; position: absolute" Text="Order Date" width="105px"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 148px; top: 69px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 148px; top: 104px; position: absolute; margin-bottom: 0px"></asp:TextBox>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 11px; top: 143px; position: absolute" Text="Customer ID" width="105px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 148px; top: 141px; position: absolute; margin-bottom: 0px"></asp:TextBox>
        <asp:Label ID="lblDeliveryAddress" runat="server" style="z-index: 1; left: 11px; top: 179px; position: absolute" Text="Delivery Address"></asp:Label>
        <asp:Label ID="lblOrderLineId" runat="server" style="z-index: 1; left: 12px; top: 215px; position: absolute" Text="OrderLine ID" width="105px"></asp:Label>
        <asp:TextBox ID="txtOrderLineId" runat="server" style="z-index: 1; left: 148px; top: 218px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDeliveryAddress" runat="server" style="z-index: 1; left: 148px; top: 180px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:CheckBox ID="chkIsPaid" runat="server" style="z-index: 1; left: 347px; top: 218px; position: absolute; margin-bottom: 0px" Text="Is Paid" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 269px; position: absolute"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 32px; top: 307px; position: absolute; height: 26px;" Text="OK" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 136px; top: 307px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 326px; top: 31px; position: absolute" Text="Find" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="margin-top: 2px" Text="Return to Main Menu" />
        </p>
    </form>
</body>
</html>

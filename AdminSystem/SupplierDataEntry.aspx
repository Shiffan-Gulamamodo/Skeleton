<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 11px; top: 34px; position: absolute; " Text="Supplier ID" height="19px" width="79px"></asp:Label>
            <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; left: 98px; top: 34px; position: absolute; width: 116px"></asp:TextBox>
            <asp:Label ID="lblStockID" runat="server" style="z-index: 1; left: 11px; top: 91px; position: absolute" Text="Stock ID" height="19px" width="79px"></asp:Label>
            <asp:TextBox ID="txtStockID" runat="server" OnTextChanged="TextBox2_TextChanged" style="z-index: 1; left: 98px; top: 91px; position: absolute; width: 116px"></asp:TextBox>
            <asp:Label ID="lblPhoneName" runat="server" style="z-index: 1; left: 11px; top: 135px; position: absolute" Text="Phone Name"></asp:Label>
            <asp:CheckBox ID="chkIsAvailable" runat="server" OnCheckedChanged="chkIsAvailable_CheckedChanged" style="z-index: 1; left: 103px; top: 235px; position: absolute" Text="Is Available" />
            <asp:Label ID="lblDeliveryDate" runat="server" style="z-index: 1; left: 11px; top: 184px; position: absolute" Text="DeliveryDate" height="19px" width="79px"></asp:Label>
            <asp:TextBox ID="txtPhoneName" runat="server" OnTextChanged="TextBox2_TextChanged" style="z-index: 1; left: 98px; top: 142px; position: absolute; height: 18px; width: 116px"></asp:TextBox>
            <asp:TextBox ID="txtDeliveryDate" runat="server" style="z-index: 1; left: 98px; top: 182px; position: absolute" OnTextChanged="txtDeliveryDate_TextChanged" width="116px"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 44px; top: 273px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 10px; top: 333px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 84px; top: 333px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>

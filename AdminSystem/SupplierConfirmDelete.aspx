<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Label"></asp:Label>
        <p>
            <asp:TextBox ID="txtconfrim" runat="server" style="z-index: 1; left: 155px; top: 149px; position: absolute; width: 244px; height: 21px">Are you sure you wish to confirm delete?</asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnyes" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 215px; top: 194px; position: absolute; height: 18px; width: 46px" Text="Yes" />
        </p>
        <asp:Button ID="BtnNo" runat="server" style="z-index: 1; left: 278px; top: 194px; position: absolute; height: 21px; width: 48px" Text="No" />
    </form>
</body>
</html>

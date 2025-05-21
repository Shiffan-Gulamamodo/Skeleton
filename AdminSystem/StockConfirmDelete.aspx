<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 84px; top: 58px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 229px; top: 106px; position: absolute; width: 61px" Text="No" OnClick="btnNo_Click" />
        </p>
        <p>
            <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 117px; top: 107px; position: absolute; width: 65px; right: 578px;" Text="Yes" OnClick="btnYes_Click" />
        </p>
    </form>
</body>
</html>

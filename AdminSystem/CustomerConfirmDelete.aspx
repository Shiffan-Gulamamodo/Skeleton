<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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
            &nbsp;</p>
        <p>
            &nbsp;<asp:Button ID="btnNo" runat="server" height="26px" OnClick="btnNo_Click" style="z-index: 1; left: 243px; top: 97px; position: absolute" Text="No" width="82px" />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 124px; top: 97px; position: absolute; width: 82px" Text="Yes" />
            <asp:Label ID="lblConfirm" runat="server" Font-Bold="True" style="z-index: 1; left: 94px; top: 52px; position: absolute; text-align: justify" Text="Are you sure you want to Delete this record?"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

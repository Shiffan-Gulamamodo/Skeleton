<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 751px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:ListBox ID="lstSupplierList" runat="server" style="z-index: 1; left: 16px; top: 16px; position: absolute; height: 272px; width: 336px"></asp:ListBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; top: 307px; position: absolute; height: 23px; width: 40px; left: 129px" Text="Edit" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 29px; top: 357px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 66px; top: 307px; position: absolute; height: 22px;" Text="Add" />
    </form>
</body>
</html>

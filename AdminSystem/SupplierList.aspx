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
            <asp:ListBox ID="lstSupplierList" runat="server" style="z-index: 1; left: 24px; top: 23px; position: absolute; height: 271px; width: 316px"></asp:ListBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; top: 307px; position: absolute; height: 23px; width: 40px; left: 129px" Text="Edit" OnClick="btnEdit_Click1" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 212px; top: 308px; position: absolute; width: 57px; height: 24px" Text="Delete" />
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter a Phone Name &nbsp;<asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 196px; top: 357px; position: absolute"></asp:TextBox>
        </p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 66px; top: 307px; position: absolute; height: 22px;" Text="Add" />
        <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 186px; top: 399px; position: absolute; width: 96px; height: 25px" Text="Clear Filter" />
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 71px; top: 397px; position: absolute; width: 85px" Text="Apply Filter" />
        </p>
            <asp:TextBox ID="lblError" runat="server" Width="80px" Height="16px">[lblError]</asp:TextBox>
    </form>
</body>
</html>

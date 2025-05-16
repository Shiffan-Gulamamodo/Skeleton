<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="344px" Width="479px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 31px; top: 394px; position: absolute; height: 29px; width: 91px; right: 755px;" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" height="29px" OnClick="btnEdit_Click" style="z-index: 1; top: 394px; position: absolute; left: 146px" Text="Edit" width="91px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red" style="z-index: 1; left: 37px; top: 471px; position: absolute"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

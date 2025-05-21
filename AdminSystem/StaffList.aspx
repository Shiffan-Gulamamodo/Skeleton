<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="338px" Width="356px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <br />
&nbsp;<p style="width: 626px; height: 28px">
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblFilter" runat="server" Text="Enter a Role"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; top: 421px; position: absolute; left: 141px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply Filter" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear Filter" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>

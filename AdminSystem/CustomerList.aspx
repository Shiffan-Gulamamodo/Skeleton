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
            <asp:Button ID="btnDelete" runat="server" height="29px" OnClick="btnDelete_Click" style="z-index: 1; left: 260px; top: 394px; position: absolute" Text="Delete" width="91px" />
        </p>
        <p>
            <asp:Label ID="lblCustomerAddressFilter" runat="server" style="z-index: 1; left: 34px; top: 467px; position: absolute" Text="Enter Customer Address"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 74px; top: 510px; position: absolute; width: 98px" Text="Apply Filter" height="26px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red" style="z-index: 1; left: 41px; top: 584px; position: absolute"></asp:Label>
            <asp:Button ID="btnStats" runat="server" height="26px" OnClick="btnStats_Click" style="z-index: 1; left: 332px; top: 510px; position: absolute; right: 1394px; width: 113px" Text="Check Statistics" />
        </p>
        <p>
            <asp:Button ID="btnClearFilter" runat="server" height="26px" OnClick="btnClearFilter_Click" style="z-index: 1; left: 206px; top: 510px; position: absolute; width: 98px" Text="Clear Filter" />
        </p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtFilterCustomerAddress" runat="server" style="z-index: 1; left: 210px; top: 464px; position: absolute; width: 275px"></asp:TextBox>
    </form>
</body>
</html>

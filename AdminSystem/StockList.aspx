<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" Height="275px" Width="333px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" style="position: absolute; top: 328px; left: 10px; width: 45px; z-index: 1" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 205px; top: 328px; position: absolute; width: 61px;" Text="Delete" height="26px" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" height="26px" style="position: absolute; top: 327px; left: 102px; width: 44px; z-index: 1" />
        </p>
    <p style="margin-left: 40px">
        <asp:Label ID="lblEnterProductName" runat="server" style="position: relative" Text="Enter a Product Name"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="position: relative; top: 7px; left: 33px; margin-bottom: 0px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnStatisticsPage" runat="server" OnClick="btnStatisticsPage_Click" style="z-index: 1; left: 296px; top: 418px; position: absolute" Text="Statistics Page" />
            <asp:Button ID="btnApplyFilter" runat="server" height="26px" OnClick="btnApplyFilter_Click" style="position: absolute; top: 419px; left: 19px; z-index: 1" Text="Apply Filter" width="95px" />
        </p>
        <p style="margin-left: 40px">
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 153px; top: 418px; position: absolute" Text="Clear Filter" />
        <asp:Label ID="lblError" runat="server" style="position: relative"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" style="z-index: 1; left: 487px; top: 419px; position: absolute" Text="Return to Main Menu" />
    </form>
    </body>
</html>

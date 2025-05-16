<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerStatistics.aspx.cs" Inherits="CustomerStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="GridViewStGroupByActive">
            <asp:Label ID="lblStatsHeading" runat="server" Font-Bold="True" Font-Size="18pt" Font-Underline="True" style="z-index: 1; left: 729px; top: 28px; position: absolute" Text="Customer Statistics Page "></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustomerAddressList" runat="server" Font-Size="14pt" style="z-index: 1; left: 35px; top: 68px; position: absolute" Text="Customer List - Group by Customer Address"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridViewStGroupByAddress" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="z-index: 1; left: 13px; top: 107px; position: absolute; height: 366px; width: 468px">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" style="z-index: 1; left: 761px; top: 503px; position: absolute; width: 159px" Text="Back" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridViewStGroupByCreatedDate" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" style="z-index: 1; left: 1015px; top: 104px; position: absolute; height: 366px; width: 468px">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustomerAccountActiveList" runat="server" Font-Size="14pt" style="z-index: 1; left: 546px; top: 71px; position: absolute" Text="Customer List - Group By Is Account Active or Not"></asp:Label>
            <br />
            <asp:Label ID="lblCustomerAccountCreatedAtList" runat="server" Font-Size="14pt" style="z-index: 1; left: 1075px; top: 68px; position: absolute" Text="Customer List - Group by Account Created Date"></asp:Label>
            <asp:GridView ID="GridViewStGroupByActive" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" style="z-index: 1; left: 509px; top: 106px; position: absolute; height: 366px; width: 468px">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

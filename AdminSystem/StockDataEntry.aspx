<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 520px;
        }
    </style>
</head>
<body style="height: 519px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:TextBox ID="txtStockID" runat="server" style="z-index: 1; left: 137px; top: 33px; position: absolute; bottom: 811px;" height="22px" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStockID" runat="server" style="z-index: 1; left: 14px; top: 34px; position: absolute" Text="Stock ID" width="102px"></asp:Label>
            <asp:Label ID="lblSupplierID" runat="server" style="z-index: 1; left: 14px; top: 72px; position: absolute" Text="Supplier ID" width="102px"></asp:Label>
            <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; left: 137px; top: 70px; position: absolute" height="22px" width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblProductName" runat="server" style="z-index: 1; left: 14px; top: 109px; position: absolute; width: 102px;" Text="Product Name"></asp:Label>
        <asp:TextBox ID="txtProductName" runat="server" style="z-index: 1; left: 137px; top: 107px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <p>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 14px; top: 148px; position: absolute; bottom: 499px" Text="Price" width="102px"></asp:Label>
        </p>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 137px; top: 146px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblStockQuantity" runat="server" style="z-index: 1; left: 14px; top: 186px; position: absolute" Text="Stock Quantity" width="102px"></asp:Label>
        <br />
        <asp:TextBox ID="txtStockQuantity" runat="server" style="z-index: 1; left: 137px; top: 185px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 14px; top: 226px; position: absolute; width: 102px;" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 137px; top: 225px; position: absolute" TextMode="DateTime"></asp:TextBox>
        <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 137px; top: 267px; position: absolute" Text="In Stock" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 23px; top: 301px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 23px; top: 345px; position: absolute" Text="OK" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 344px; position: absolute; left: 137px" Text="Cancel" />
    </form>
</body>
</html>

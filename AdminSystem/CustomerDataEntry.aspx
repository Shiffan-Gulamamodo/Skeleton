<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 379px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 17px">
            <br />
            <asp:TextBox ID="txtCustomerAccountCreatedAt" runat="server" BorderColor="Black" style="z-index: 1; left: 222px; top: 259px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblCustomerId" runat="server" Font-Bold="False" Font-Italic="False" Font-Strikeout="False" style="z-index: 1; left: 9px; top: 73px; position: absolute" Text="Customer ID" width="186px"></asp:Label>
            <br />
            <asp:Label ID="lblCustomerFullName" runat="server" Font-Bold="False" style="z-index: 1; left: 10px; top: 111px; position: absolute" Text="Customer Full Name" width="186px"></asp:Label>
            <br />
            <asp:TextBox ID="txtCustomerAddress" runat="server" BorderColor="Black" style="z-index: 1; left: 220px; top: 222px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <br />
        </div>
        <p>
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Underline="True" Text="Customer Data Entry Form" style=""></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblCustomerPassword" runat="server" style="z-index: 1; left: 10px; top: 185px; position: absolute" Text="Customer Password" width="186px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkIsCustomerAccountActive" runat="server" BorderColor="Black" style="z-index: 1; left: 218px; top: 298px; position: absolute" Text="Is Customer Account Active" />
            <asp:Label ID="lblCustomerAccountCreatedAt" runat="server" style="z-index: 1; left: 10px; top: 261px; position: absolute" Text="Customer Account Created At"></asp:Label>
            <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 10px; top: 147px; position: absolute" Text="Customer Email" width="186px"></asp:Label>
            <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 10px; top: 223px; position: absolute" Text="Customer Address" width="186px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 337px; position: absolute" Font-Bold="True" ForeColor="Red"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 111px; top: 479px; position: absolute; width: 123px" Text="Ok" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 274px; top: 477px; position: absolute; width: 123px" Text="Cancel" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtCustomerId" runat="server" BorderColor="Black" style="z-index: 1; left: 221px; top: 74px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerFullName" runat="server" BorderColor="Black" style="z-index: 1; left: 221px; top: 107px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerEmail" runat="server" BorderColor="Black" style="z-index: 1; left: 221px; top: 147px; position: absolute" height="22px" TextMode="Email" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerPassword" runat="server" BorderColor="Black" style="z-index: 1; left: 220px; top: 184px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 426px; top: 72px; position: absolute; height: 24px; width: 123px" Text="Find Record" />
    </form>
</body>
</html>

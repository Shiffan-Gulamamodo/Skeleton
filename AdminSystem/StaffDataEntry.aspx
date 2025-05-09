<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p style="width: 1382px">
            <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute; right: 1285px" Text="Staff ID" width="101px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 122px; top: 53px; position: absolute; width: 120px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
        <p>
            <asp:Label ID="lblStaffFullName" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute; width: 101px;" Text="Staff FullName"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
&nbsp;<asp:Label ID="lblStaff" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="Staff Password" width="101px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtStaffFullName" runat="server" style="z-index: 1; left: 122px; top: 91px; position: absolute; width: 120px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffPassword" runat="server" style="z-index: 1; left: 122px; top: 129px; position: absolute; width: 120px" TextMode="Password"></asp:TextBox>
&nbsp;
        </p>
        <p>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 10px; top: 167px; position: absolute" Text="Email" width="101px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 122px; top: 167px; position: absolute; width: 120px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblLastUpdated" runat="server" style="z-index: 1; left: 10px; top: 205px; position: absolute; right: 1309px" Text="Last Updated" width="101px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtLastUpdated" runat="server" style="z-index: 1; left: 122px; top: 205px; position: absolute; width: 120px" TextMode="DateTime"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblRole" runat="server" style="z-index: 1; left: 10px; top: 243px; position: absolute" Text="Role" width="101px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtRole" runat="server" style="z-index: 1; left: 122px; top: 243px; position: absolute; width: 120px"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 121px; top: 281px; position: absolute; " Text="Active" width="130" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 19px; top: 319px; position: absolute"></asp:Label>
        </p>
        <p>
            &nbsp;
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 19px; top: 357px; position: absolute" Text="OK" width="60px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 121px; top: 357px; position: absolute" Text="Cancel" />
        </p>
    </form>
</body>
</html>

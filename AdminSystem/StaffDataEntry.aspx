<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    #form1 {
        background-color: #9A4C30;
    }
    </style>
</head>
<body style="background-color: #9A4C30">
    <form id="form1" runat="server">
        <div>
       
            <asp:Label ID="lblStaffId1" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute; color:white; right: 952px;" Text="Staff ID" width="112px" Font-Bold="True"></asp:Label>
            <asp:Button ID="btnReturnToMM" runat="server" OnClick="btnReturnToMM_Click" style="z-index: 1; left: 276px; top: 414px; position: absolute" Text="Return to Main Menu" />
            <asp:TextBox ID="txtStaffId1" runat="server" style="z-index: 1; left: 128px; top: 53px; position: absolute; width: 120px; right: 818px;"></asp:TextBox>
            <asp:Button ID="btnFind1" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 308px; top: 50px; position: absolute" Text="Find" width="60px" />
       
            <asp:Label ID="lblStaffFullName1" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute; width: 112px; color:white; right: 952px;" Text="Staff FullName" Font-Bold="True"></asp:Label>
       
&nbsp;<asp:Label ID="lblStaffPassword" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute; color:white" Text="Staff Password" width="112px" Font-Bold="True"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtStaffFullName1" runat="server" style="z-index: 1; left: 128px; top: 91px; position: absolute; width: 120px"></asp:TextBox>
            <asp:TextBox ID="txtStaffPassword1" runat="server" style="z-index: 1; left: 128px; top: 129px; position: absolute; width: 120px" TextMode="Password"></asp:TextBox>
&nbsp;
       
            <asp:Label ID="lblEmail1" runat="server" style="z-index: 1; left: 10px; top: 167px; position: absolute; color:white" Text="Email" width="112px" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="txtEmail1" runat="server" style="z-index: 1; left: 128px; top: 167px; position: absolute; width: 120px"></asp:TextBox>
       
            <asp:Label ID="lblLastUpdated1" runat="server" style="z-index: 1; left: 10px; top: 206px; position: absolute; color:white" Text="Last Updated" width="112px" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="txtLastUpdated1" runat="server" style="z-index: 1; left: 128px; top: 205px; position: absolute; width: 120px" TextMode="DateTime"></asp:TextBox>
        
            <asp:Label ID="lblRole1" runat="server" style="z-index: 1; left: 10px; top: 244px; position: absolute; color:white" Text="Role" width="112px" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="txtRole1" runat="server" style="z-index: 1; left: 128px; top: 243px; position: absolute; width: 120px"></asp:TextBox>
       
            <asp:CheckBox ID="chkActive1" runat="server" style="z-index: 1; left: 128px; top: 281px; position: absolute; color:white" Text="Active" width="130" Font-Bold="True" />
       
            <asp:Label ID="lblError1" runat="server" style="z-index: 1; left: 19px; top: 319px; position: absolute; color:white" Font-Bold="True"></asp:Label>
   
            &nbsp;
            <asp:Button ID="btnOK1" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 128px; top: 414px; position: absolute" Text="OK" width="60px" />
            <asp:Button ID="btnCancel1" runat="server" style="z-index: 1; left: 201px; top: 414px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        </div> 
    </form>
</body>
</html>

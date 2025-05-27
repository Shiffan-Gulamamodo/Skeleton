<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

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
            <asp:ListBox ID="lstStaffList1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 364px; width: 378px"></asp:ListBox>
        
        
            <asp:Button ID="btnAdd1" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 404px; position: absolute" Text="Add" width="55px" />
            <asp:Button ID="btnEdit1" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 79px; top: 404px; position: absolute; right: 940px" Text="Edit" width="55px" />
            <asp:Button ID="btnDelete1" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 147px; top: 404px; position: absolute" Text="Delete" />
        
        
            <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 10px; top: 442px; position: absolute; right: 968px; color:white" Text="Enter A Role" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="txtFilter1" runat="server" style="z-index: 1; left: 132px; top: 441px; position: absolute; right: 797px; width: 145px;"></asp:TextBox>
        
        
            <asp:Button ID="btnApply1" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 10px; top: 480px; position: absolute" Text="Apply Filter" height="26px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClear1" runat="server" OnClick="btnClear_Click" height="26px" style="z-index: 1; left: 132px; top: 479px; position: absolute" Text="Clear Filter" width="100px" />
        
        
            <asp:Label ID="lblError1" runat="server" style="z-index: 1; left: 10px; top: 518px; position: absolute; color:white" Font-Bold="True"></asp:Label>
        </div>
        <asp:Button ID="btnStatistics" runat="server" OnClick="btnStatistics_Click" style="z-index: 1; top: 479px; position: absolute; left: 257px" Text="Go To Statistics Page" height="26px" />
        <asp:Button ID="btnReturnToMM" runat="server" height="26px" OnClick="btnReturnToMM_Click" style="z-index: 1; left: 478px; top: 479px; position: absolute" Text="Return to Main Menu" width="194px" />
    </form>
</body>
</html>

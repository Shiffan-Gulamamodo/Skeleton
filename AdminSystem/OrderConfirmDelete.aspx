﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: large;
        }
    </style>
</head>
<body style="height: 365px">
    &nbsp;<form id="form1" runat="server">
        <div>
        </div>
        <p class="auto-style1" style="height: 24px">
            Are you sure you want to delete this record?</p>
        <p class="auto-style1" style="height: 24px">
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" />
        </p>
    </form>
</body>
</html>

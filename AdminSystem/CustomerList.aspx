﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<script runat="server">



</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:ListBox ID="lstCustomersList" runat="server" Height="324px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="433px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>

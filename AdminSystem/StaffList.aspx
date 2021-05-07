<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

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
        <asp:ListBox ID="lstStaffList" runat="server" Height="324px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="433px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" Height="28px" OnClick="btnEdit_Click1" style="margin-left: 30px" Text="Edit" Width="51px" />
        <asp:Button ID="btnDelete" runat="server" style="margin-left: 30px" Text="Delete" Width="73px" OnClick="btnDelete_Click1" />
        <p style="width: 266px">
            <asp:Label ID="LblName" runat="server" Text="Enter Name"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="margin-left: 28px" Width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="margin-left: 24px" Text="Clear" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
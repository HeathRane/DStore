<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstSuppliers" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 424px; width: 503px" OnSelectedIndexChanged="lstSuppliers_SelectedIndexChanged"></asp:ListBox>
        <div>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 467px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 52px; top: 466px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 31px; top: 506px; position: absolute"></asp:Label>
        <asp:Button ID="btnDeletete" runat="server" OnClick="btnDeletete_Click" style="z-index: 1; left: 90px; top: 465px; position: absolute" Text="Delete" />
    </form>
</body>
</html>

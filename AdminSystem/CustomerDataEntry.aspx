<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="CustomerId" runat="server" Text="Customer Id  " height="19px" width="130px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="margin-left: 14px" Width="253px" height="22px" ></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="CustomerFullName" runat="server" Text="Customer Full Name  "></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server" style="margin-left: 13px" Width="253px" Height="22px"></asp:TextBox>
        </p>
        <asp:Label ID="RegisteredDate" runat="server" Text="Registered Date " height="19px" width="130px"></asp:Label>
        <asp:TextBox ID="txtRegisteredDate" runat="server" style="margin-left: 11px" height="22px" width="253px"></asp:TextBox>
        <p>
            <asp:Label ID="CustomerPoint" runat="server" Text="Customer Point " height="19px" width="130px"></asp:Label>
            <asp:TextBox ID="txtCustomerPoint" runat="server" style="margin-left: 8px" height="22px" width="253px"></asp:TextBox>
        </p>
        <asp:Label ID="ProductId" runat="server" Text="Product Id " height="19px" width="130px"></asp:Label>
        <asp:TextBox ID="txtProductId" runat="server" style="margin-left: 10px" Width="253px" height="22px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="Active" runat="server" />
        </p>
        <p>
        <asp:Label ID="ErrorMessages" runat="server" Text="lblError"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="margin-left: 34px" Text="Cancel" />
        </p>
    </form>
</body>
</html>

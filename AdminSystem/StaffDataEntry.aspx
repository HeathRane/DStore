<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblStaffNumber" runat="server" Text="StaffNumber"></asp:Label>
        <asp:TextBox ID="txtStaffNumber" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lbStaffName" runat="server" Text="StaffName"></asp:Label>
            <asp:TextBox ID="txtStaffName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblStaffSalary" runat="server" Text="StaffSalary"></asp:Label>
        <asp:TextBox ID="txtStaffStatus" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblStaffCredit" runat="server" Text="StaffCredit"></asp:Label>
            <asp:TextBox ID="txtStaffCredit" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblStaffDate" runat="server" Text="StaffDate"></asp:Label>
        <asp:TextBox ID="txtStaffDate" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkStatus" runat="server" Text="Full-time" />
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>

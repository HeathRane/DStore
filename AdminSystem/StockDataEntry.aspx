<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblProductId" runat="server" Text="Product ID " width="139px"></asp:Label>
        <asp:TextBox ID="txtProductId" runat="server" type="number"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="lblProductName" runat="server" Text="Product Name " width="139px"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblProductDescription" runat="server" Text="Product Description "></asp:Label>
        <asp:TextBox ID="txtProductDescription" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblReleaseDate" runat="server" Text="Release Date" width="139px"></asp:Label>
            <asp:TextBox ID="txtReleaseDate" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="139px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <p>
            <asp:CheckBox ID="chkInStock" runat="server" Text="In Stock" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>

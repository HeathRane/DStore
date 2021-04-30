<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 348px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 20px; width: 684px">
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 111px; top: 39px; position: absolute; margin-top: 1px" width="128px" height="22px"></asp:TextBox>
            <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 16px; top: 42px; position: absolute" Text="Product ID"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 110px; top: 76px; position: absolute; margin-top: 5px; right: 554px;" width="128px" height="22px"></asp:TextBox>
            <asp:TextBox ID="txtDeliveryDate" runat="server" style="z-index: 1; left: 109px; top: 128px; position: absolute; height: 21px;" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 107px; top: 172px; position: absolute; bottom: 437px;" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 73px; top: 282px; position: absolute"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 313px; position: absolute; left: 117px; margin-top: 0px" Text="cancel" />
            <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 16px; top: 224px; position: absolute" Text="Name"></asp:Label>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 16px; top: 180px; position: absolute" Text="Price"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 107px; top: 220px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 259px; top: 40px; position: absolute" Text="Find" OnClick="btnFind_Click" />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 73px; top: 313px; position: absolute; width: 28px;" Text="ok" />
            <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 153px; top: 260px; position: absolute" Text="in Stock" />
        </div>
        <asp:Label ID="lblDeliveryDate" runat="server" style="z-index: 1; left: 13px; top: 128px; position: absolute; height: 24px; right: 704px" Text="Delivery Date"></asp:Label>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 19px; top: 85px; position: absolute" Text="Quantity"></asp:Label>
    </form>
</body>
</html>

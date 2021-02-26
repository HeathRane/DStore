<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 362px; width: 684px">
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 111px; top: 39px; position: absolute; margin-top: 1px" width="128px"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 110px; top: 76px; position: absolute; margin-top: 5px" width="128px"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 108px; top: 131px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 108px; top: 182px; position: absolute"></asp:TextBox>
            <asp:CheckBox ID="chckInStock" runat="server" style="z-index: 1; left: 68px; top: 252px; position: absolute; margin-top: 0px" Text="In Stock" width="86px" />
            <asp:Label ID="txtQuantity" runat="server" style="z-index: 1; left: 37px; top: 80px; position: absolute; bottom: 340px" Text="Quantity:" width="86px"></asp:Label>
            <asp:Label ID="txtDeliveryDate" runat="server" style="z-index: 1; left: 16px; top: 132px; position: absolute; margin-top: 2px; bottom: 286px;" Text="Delivery Date:"></asp:Label>
            <asp:Label ID="txtPrice" runat="server" style="z-index: 1; left: 36px; top: 187px; position: absolute; right: 968px; height: 11px;" Text="Price:"></asp:Label>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 73px; top: 282px; position: absolute"></asp:Label>
            <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 62px; top: 315px; position: absolute; height: 21px;" Text="OK" OnClick="btnOk_Click1" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 313px; position: absolute; left: 117px; margin-top: 0px" Text="cancel" />
            <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 33px; top: 224px; position: absolute" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 105px; top: 224px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 29px; top: 41px; position: absolute; bottom: 297px;" Text="ProductID:" width="86px"></asp:Label>
    </form>
</body>
</html>

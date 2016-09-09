<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WindowCalculator.aspx.cs" Inherits="WindowCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="input">
        <!-- these should be done with table in order to align properly -->
        <asp:Label ID="lblWidth" runat="server" Text="Window width:"></asp:Label>
        <asp:TextBox ID="txtWidth" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblHeight" runat="server" Text="Window height:"></asp:Label>
        <asp:TextBox ID="txtHeight" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblBorderWidth" runat="server" Text="Border width:"></asp:Label>
        <asp:TextBox ID="txtBorderWidth" runat="server"></asp:TextBox><br />
    </div>
    <div>
        <asp:Button ID="btnCalculate" runat="server" Text="Calculate price" OnClick="btnCalculate_Click" />
    </div>
    <div id="output">
        <asp:Label ID="lblArea" runat="server" Text="Window area:"></asp:Label>
        <asp:TextBox ID="txtArea" runat="server" Enabled="false"></asp:TextBox><br />
        <asp:Label ID="lblCirc" runat="server" Text="Border circumference:"></asp:Label>
        <asp:TextBox ID="txtCirc" runat="server" Enabled="false"></asp:TextBox><br />
        <asp:Label ID="lblPrice" runat="server" Text="Price (w/o VAT):"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" Enabled="false"></asp:TextBox><br />
    </div>
    </form>
</body>
</html>

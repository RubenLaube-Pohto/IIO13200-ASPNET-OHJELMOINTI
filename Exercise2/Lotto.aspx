<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Lotto.aspx.cs" Inherits="Lotto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lottokone</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Lotto</h1>
        <asp:DropDownList ID="ddlType" runat="server"></asp:DropDownList>
        <p>Montako riviä arvotaan:</p>
        <asp:TextBox ID="txtLines" runat="server"></asp:TextBox>
        <asp:Button ID="btnDraw" runat="server" Text="Draw numbers" OnClick="btnDraw_Click"/><br />
        <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>

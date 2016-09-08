<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HelloEvening.aspx.cs" Inherits="HelloEvening" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hello Evening Stars</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Hello</h1>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Button ID="btnSayHello" runat="server" Text="Greet" OnClick="btnSayHello_Click" />
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>

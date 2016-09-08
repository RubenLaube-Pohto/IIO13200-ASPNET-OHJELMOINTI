<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GetWorkersEvening.aspx.cs" Inherits="GetWorkersEvening" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Workers of the Company</title>
    <link rel="stylesheet" href="http://www.w3schools.com/lib/w3.css">
</head>
<body>
    <form id="form1" runat="server">
        <div id="buttons">
            <asp:Button ID="btnGet" CssClass="w3-btn w3-green" runat="server" Text="Get workers" OnClick="btnGet_Click" />
        </div>
        <div id="presentation" class="w3-green">
            <asp:GridView ID="gvData" runat="server"></asp:GridView>
        </div>
        <div id="footer" class="w3-container w3-teal">
            <asp:Label ID="lblMsg" runat="server" Text="..."></asp:Label>
        </div>
    </form>
</body>
</html>

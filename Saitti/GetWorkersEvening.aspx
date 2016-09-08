<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GetWorkersEvening.aspx.cs" Inherits="GetWorkersEvening" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Workers of the Company</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="buttons">
            <asp:Button ID="btnGet" runat="server" Text="Get workers" OnClick="btnGet_Click" />
        </div>
        <div id="presentation">
            <asp:GridView ID="gvData" runat="server"></asp:GridView>
        </div>
        <div id="footer">
            <asp:Label ID="lblMsg" runat="server" Text="..."></asp:Label>
        </div>
    </form>
</body>
</html>

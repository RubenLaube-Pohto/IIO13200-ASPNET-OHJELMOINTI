<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Source.aspx.cs" Inherits="Source" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data Transfer Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Source Page</h1>
        Message to send: <asp:TextBox ID="txtMessage" runat="server"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Message is required" ControlToValidate="txtMessage"></asp:RequiredFieldValidator>
        <asp:DropDownList ID="ddlMessages" runat="server" OnSelectedIndexChanged="ddlMessages_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList><br />
        <asp:Button ID="btnQuery" runat="server" Text="Case 1: Query string" OnClick="btnQuery_Click"/><br />
        <asp:Button ID="btnSession" runat="server" Text="Case 2: Session" OnClick="btnSession_Click"/><br />
        <asp:Button ID="btnCookie" runat="server" Text="Case 3: Cookie" OnClick="btnCookie_Click"/><br />
        <asp:Button ID="btnPublicProperty" runat="server" Text="Case 4: Property" OnClick="btnPublicProperty_Click"/>
    </div>
    </form>
</body>
</html>

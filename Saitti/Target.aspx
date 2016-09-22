<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Target.aspx.cs" Inherits="Target" %>
<%@ PreviousPageType VirtualPath="~/Source.aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data Transfer Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Target Page</h1>
        The message sent to this page was: <div id="myText" runat="server"></div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Source.aspx">Back</asp:HyperLink>
    </div>
    </form>
</body>
</html>

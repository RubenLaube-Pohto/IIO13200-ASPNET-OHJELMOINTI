<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GetStudentsEvening.aspx.cs" Inherits="GetStudentsEvening" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Students 16S</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Students Autumn 2016</h1>
        <div id="buttons">
            <asp:Button ID="btnGet3" runat="server" Text="Get three students" OnClick="btnGet3_Click" />
            <asp:Button ID="btnGetAll" runat="server" Text="Get students from db" OnClick="btnGetAll_Click"/>
            <asp:Button ID="btnGet4" runat="server" Text="Get four student objects" OnClick="btnGet4_Click"/>
        </div>
        <div id="data">
            <asp:GridView ID="gvStudents" runat="server"></asp:GridView>
        </div>
        <div id="footer">
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
    </div>
    </form>
</body>
</html>

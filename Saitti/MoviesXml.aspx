<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MoviesXml.aspx.cs" Inherits="MoviesXml" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        img {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <h1>Esa's Movies from XML File</h1>
    <!-- define XMLDataSource -->
    <asp:XmlDataSource ID="srcMovies" runat="server" DataFile="~/App_Data/Movies.xml" XPath="//Movie"></asp:XmlDataSource>
    <!-- GridView displays data -->
    <asp:GridView 
        ID="gvMovies" 
        DataSourceID="srcMovies"
        HeaderStyle-BackColor="Blue" 
        HeaderStyle-ForeColor="White" 
        runat="server">
    </asp:GridView>
    <!-- display data in html -->
    <h1>Movies in list</h1>
    <asp:Repeater ID="Repeater1" DataSourceID="srcMovies" runat="server">
        <HeaderTemplate>
            <ul class="w3-ul w3-hoverable">
        </HeaderTemplate>
        <ItemTemplate>
            <li> <%# Eval("Name") %>, director: <%# Eval("Director") %> </li>
        </ItemTemplate>
        <FooterTemplate>
            </ul>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>


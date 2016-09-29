<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MoviesSql.aspx.cs" Inherits="MoviesSql" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        img {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <h1>Esa's Movies from SQL Server</h1>
    <!-- define data source -->
    <asp:SqlDataSource 
        ID="srcMovies"
        runat="server" 
        ConnectionString="<%$ ConnectionStrings:Movies %>" 
        SelectCommand="SELECT [title], [director], [year], [url] FROM [Movies]">
    </asp:SqlDataSource>
    <!-- diplay data in gridview -->
    <asp:GridView 
        ID="gvMovies" 
        DataSourceID="srcMovies"
        HeaderStyle-BackColor="Blue" 
        HeaderStyle-ForeColor="White" 
        runat="server"
        AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
            <asp:BoundField DataField="director" HeaderText="director" SortExpression="director" />
            <asp:BoundField DataField="year" HeaderText="year" SortExpression="year" />
        </Columns>
        <HeaderStyle BackColor="Blue" ForeColor="White"></HeaderStyle>
    </asp:GridView>
    <!-- diplay movie posters with repeater -->
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="srcMovies">
        <HeaderTemplate>
            <div class="w3-row-padding">
        </HeaderTemplate>
        <ItemTemplate>
            <div class="w3-third w3-card-12">
                <img src="<%# Eval("url") %>" alt="kuva puuttuu" />
                <div class="w3-container w3-center">
                    <h2><%# Eval("title") %></h2>
                </div>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>


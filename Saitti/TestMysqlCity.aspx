<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TestMysqlCity.aspx.cs" Inherits="TestMysqlCity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        img {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <h2>Cities with SqlDataSource</h2>
    <asp:SqlDataSource
        ID="srcMysql"
        runat="server"
        ConnectionString="<%$ ConnectionStrings:Mysql %>"
        ProviderName="MySql.Data.MySqlClient"
        DeleteCommand="DELETE FROM Pelaaja WHERE PelaajaID=@PelaajaID"
        InsertCommand=""
        SelectCommand="SELECT * FROM Pelaaja"
        UpdateCommand="UPDATE Pelaaja SET Nimi=@Nimi, Seura=@Seura, Pelipaikka=@Pelipaikka, Nro=@Nro, Maalit=@Maalit, Syotot=@Syotot WHERE (PelaajaID=@PelaajaID)">
    </asp:SqlDataSource>
    <asp:GridView ID="gvPlayers" runat="server" DataSourceID="srcMysql" CssClass="w3-table w3-hoverable">
        <Columns>
            <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
    <h2>Cities with class method</h2>
    <asp:Button ID="btnGetCities" runat="server" Text="Get cities with MySQL" OnClick="btnGetCities_Click"/>
    <asp:GridView ID="gvCities" runat="server" CssClass="w3-table"></asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
    <asp:Label ID="lblMessages" runat="server" Text=""></asp:Label>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Localization.aspx.cs" Inherits="Localization" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        img {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <h1>
        <asp:Literal ID="ltHello" runat="server" meta:resourcekey="ltHelloResource1"></asp:Literal>
        Tänään on <%=DateTime.Today.ToShortDateString() %>
    </h1>
    <div class="w3-container">
        <asp:Label ID="lblHello" runat="server" Text="Tähän vaihtuva teksti" meta:resourcekey="lblHelloResource1"></asp:Label>
        <asp:Image ID="imgFlag" runat="server" ImageUrl="<%$ Resources:Flag %>" Width="100"/>
        <asp:Button ID="btnSayHello" runat="server" Text="<%$ Resources:Button %>" OnClick="btnSayHello_Click"/>
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="Server">
</asp:Content>


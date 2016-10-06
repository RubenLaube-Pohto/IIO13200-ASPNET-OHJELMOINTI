<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DemoJSON.aspx.cs" Inherits="DemoJSON" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        img {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:Button ID="btnGet" runat="server" Text="Get JSON text" OnClick="btnGet_Click"/>
    <asp:Button ID="btnGetPerson" runat="server" Text="Get JSON to object" OnClick="btnGetPerson_Click"/>
    <asp:Button ID="btnGetPoliticians" runat="server" Text="Get JSON to object collection" OnClick="btnGetPoliticians_Click" /><br />
    <asp:Literal ID="ltResult" runat="server"></asp:Literal>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>


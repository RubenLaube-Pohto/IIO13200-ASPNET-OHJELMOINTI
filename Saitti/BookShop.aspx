<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookShop.aspx.cs" Inherits="BookShop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        img {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <h1>My Book Shop</h1>
    <div class="w3-row">
        <!-- customers -->
        <div class="w3-container w3-third">
            <asp:Button ID="btnGetCustomers" CssClass="w3-btn w3-blue" runat="server" Text="Get customers" OnClick="btnGetCustomers_Click" />
            <asp:DropDownList ID="ddlCustomers" runat="server" OnSelectedIndexChanged="ddlCustomers_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            <asp:GridView ID="gvCustomers" CssClass="w3-table" runat="server"></asp:GridView>
        </div>
        <!-- books -->
        <div class="w3-container w3-twothird">
            <asp:Button ID="btnGetBooks" CssClass="w3-btn w3-blue" runat="server" Text="Get books" OnClick="btnGetBooks_Click"/>
            <asp:GridView ID="gvBooks" CssClass="w3-table" runat="server"></asp:GridView>
        </div>
    </div>
    <div class="w3-row">
        <asp:Literal ID="ltResult" runat="server"></asp:Literal>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
</asp:Content>


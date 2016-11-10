<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookShop.aspx.cs" Inherits="BookShop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        img {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <h1>My Book Shop</h1>
    <div class="w3-row">
        <!-- customers -->
        <div class="w3-container w3-third">
            <asp:Button ID="btnGetCustomers" CssClass="w3-btn w3-blue" runat="server" Text="Get customers" OnClick="btnGetCustomers_Click" />
            <asp:GridView ID="gvCustomers" CssClass="w3-table" runat="server"></asp:GridView>
        </div>
        <!-- customer crud -->
        <div class="w3-container w3-third">
            <h2>CRUD operations</h2>
            <asp:DropDownList ID="ddlCustomers" runat="server" OnSelectedIndexChanged="ddlCustomers_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList><br />
            firstname:
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><br />
            lastname:
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnNew" CssClass="w3-btn" runat="server" Text="New" OnClick="btnNew_Click"/>
            <asp:Button ID="btnSave" CssClass="w3-btn" runat="server" Text="Save" OnClick="btnSave_Click"/>
            <asp:Button ID="btnDelete" CssClass="w3-btn" runat="server" Text="Delete" />
        </div>
        <!-- books -->
        <div class="w3-container w3-third">
            <asp:Button ID="btnGetBooks" CssClass="w3-btn w3-blue" runat="server" Text="Get books" OnClick="btnGetBooks_Click" />
            <asp:GridView ID="gvBooks" CssClass="w3-table" runat="server"></asp:GridView>
        </div>
    </div>
    <div class="w3-row">
        <asp:Literal ID="ltResult" runat="server"></asp:Literal>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="Server">
    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
</asp:Content>

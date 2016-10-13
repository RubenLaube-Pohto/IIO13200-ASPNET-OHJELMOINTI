<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Feed.aspx.cs" Inherits="Feed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        img {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:Button ID="btnGetFeed" runat="server" Text="Get Yle Uutiset Feed" OnClick="btnGetFeed_Click"/>
    <asp:Button ID="btnGetFeedWired" runat="server" Text="Get Wired Feed" OnClick="btnGetFeedWired_Click"/>
    <asp:XmlDataSource ID="myDataSource" runat="server"></asp:XmlDataSource>
    <div id="feedContent" runat="server"></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="WorkersXML2.aspx.cs" Inherits="WorkersXML" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        img {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:Xml
        ID="Xml1"
        DocumentSource="~/App_Data/Työntekijät2013.xml"
        TransformSource="~/App_Data/Demo2.xsl"
        runat="server"></asp:Xml>
    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

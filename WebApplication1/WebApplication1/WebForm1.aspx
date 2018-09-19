<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headContent" runat="server">
    <style type="text/css">
        .myInput{
            font-size: 18pt;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContent" runat="server">
    <asp:Label ID="NameLabel" runat="server">Name:</asp:Label>
    <asp:TextBox ID="TxtName" runat="server" maxLength="50" CssClass="myInput">
    </asp:TextBox>
    <hr />
    <asp:Button ID="ClickMe" runat="server" Text="Click Me" CssClass="myInput" OnClick="ClickMe_Click" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="bodyScriptContent" runat="server">
</asp:Content>

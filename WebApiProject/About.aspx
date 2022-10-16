<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApiProject.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>
        <asp:HyperLink runat="server" NavigateUrl="~/WebForm1.aspx" BackColor="#99FFCC" ForeColor="Yellow" Text="ShowImage" ImageUrl="~/Image/Image1.jpg">ShowContact</asp:HyperLink>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
</asp:Content>

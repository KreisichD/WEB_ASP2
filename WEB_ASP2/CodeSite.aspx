<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CodeSite.aspx.cs" Inherits="CodeSite" MasterPageFile="~/Site.master" %>

<asp:Content ID="codeSiteHead" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/CodeSite.css" />
</asp:Content>

<asp:Content ID="codeSiteMainContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="off7 col1">
        <a href="Cart.aspx">Cart </a>
    </div>

    <div class="off1 col3">
        <asp:RadioButtonList ID="categoriesRBL" runat="server" RepeatDirection="Vertical">
            <asp:ListItem>JavaScript</asp:ListItem>
            <asp:ListItem>Python</asp:ListItem>
            <asp:ListItem>Java</asp:ListItem>
            <asp:ListItem>C#</asp:ListItem>
        </asp:RadioButtonList>
    </div>

    <div class="col4">
        <asp:CheckBoxList ID="jsCBL" runat="server" RepeatDirection="Vertical" Visible="false">
            <asp:ListItem>"JavaScript for Kids: A Playful Introduction to Programming"</asp:ListItem>
            <asp:ListItem>"Composing Software"</asp:ListItem>
            <asp:ListItem>"Eloquent JavaScript: A Modern Introduction to Programming"</asp:ListItem>
        </asp:CheckBoxList>
    </div>
</asp:Content>
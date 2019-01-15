<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CodeSite.aspx.cs" Inherits="CodeSite" MasterPageFile="~/Site.master" %>

<asp:Content ID="codeSiteHead" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/CodeSite.css" />
</asp:Content>

<asp:Content ID="codeSiteMainContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="off7 col1">
        <a href="Cart.aspx"><asp:Label ID="cartLabel" runat="server"></asp:Label> </a>
    </div>

    <div class="row">
       
        <div class="off1 col7" style="min-height:50px;">
            <asp:RadioButtonList ID="categoriesRBL" runat="server" RepeatDirection="Horizontal" AutoPostBack="true">
                <asp:ListItem>JavaScript</asp:ListItem>
                <asp:ListItem>Python</asp:ListItem>
                <asp:ListItem>Java</asp:ListItem>
                <asp:ListItem>C#</asp:ListItem>
            </asp:RadioButtonList>
        </div>

        <div class="off1 col7" style="min-height:120px;">
            <asp:CheckBoxList ID="jsCBL" runat="server" RepeatDirection="Vertical" Visible="false">
                <asp:ListItem>0_0</asp:ListItem>
                <asp:ListItem>0_1</asp:ListItem>
                <asp:ListItem>0_2</asp:ListItem>
            </asp:CheckBoxList>

            <asp:CheckBoxList ID="pyCBL" runat="server" RepeatDirection="Vertical" Visible="false">
                <asp:ListItem>1_0</asp:ListItem>
                <asp:ListItem>1_1</asp:ListItem>
                <asp:ListItem>1_2</asp:ListItem>
            </asp:CheckBoxList>

            <asp:CheckBoxList ID="javaCBL" runat="server" RepeatDirection="Vertical" Visible="false">
                <asp:ListItem>2_0</asp:ListItem>
                <asp:ListItem>2_1</asp:ListItem>
                <asp:ListItem>2_2</asp:ListItem>
            </asp:CheckBoxList>

            <asp:CheckBoxList ID="csCBL" runat="server" RepeatDirection="Vertical" Visible="false">
                <asp:ListItem>3_0</asp:ListItem>
                <asp:ListItem>3_1</asp:ListItem>
            </asp:CheckBoxList>
        </div>

        <div class="off3 col2">
            <asp:Button ID="addBTN" Text="ADD TO CART" OnClick="AddBtn_Click" runat="server" />
        </div>

    </div>
</asp:Content>

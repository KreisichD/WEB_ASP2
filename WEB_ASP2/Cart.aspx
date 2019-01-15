<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="Cart" MasterPageFile="~/Site.master" %>

<asp:Content ID="cartHead" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="cartMainContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row" style="min-height: 80px;">
        <div class="off2 col4">
            <asp:BulletedList ID="productsList" runat="server">
            </asp:BulletedList>

            <asp:Label ID="emptyLabel" runat="server"><h3>Nie ma nic w koszyku</h3></asp:Label>
        </div>

        <div class="off2 col4">
            Dostawa:
        <asp:RadioButtonList ID="deliveryRBL" runat="server" RepeatDirection="Vertical" AutoPostBack="true">
            <asp:ListItem Selected="True">Odbior osobisty - 0.00 zł</asp:ListItem>
            <asp:ListItem>Poczta polska - 6.50 zł</asp:ListItem>
            <asp:ListItem>Kurier - 15.00 zł</asp:ListItem>
        </asp:RadioButtonList>
        </div>

        <div class="off4 col5">
            <asp:Label ID="sumLabel" runat="server">Suma: </asp:Label>
        </div>

        <div class="off2 col2">
            <a href="CodeSite.aspx">Kontynuuj zakupy</a>
        </div>

        <div class="off1 col1">
            <a href="Summary.aspx"><asp:Label ID="confirmLabel" runat="server" Visible="true">Potwierdz</asp:Label></a>
        </div>
    </div>
</asp:Content>


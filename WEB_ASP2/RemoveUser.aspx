<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RemoveUser.aspx.cs" Inherits="_RemoveUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
	<div class="row">
	<table style="width:100%;" class="off2 col4 push2">
		<tr>
			<td>Id</td>
			<td>
				<asp:TextBox ID="TextBox1" runat="server" Width="94px"></asp:TextBox>
			</td>
		</tr>
	</table>
	<asp:Button ID="Button1" runat="server" Text="Remove" CssClass="off2 col1" OnClick="Button1_Click"/>
	</div>
</asp:Content>


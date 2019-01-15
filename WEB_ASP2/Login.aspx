<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Login" %>

<asp:Content ID="LoginHead" ContentPlaceHolderID="head" Runat="Server">
	<style type="text/css">
		.auto-style1 {
			width: 179px;
		}
		.auto-style2 {
			width: 241px;
		}
	</style>
</asp:Content>
<asp:Content ID="LoginContent" ContentPlaceHolderID="MainContent" Runat="Server">
	



	<table style="width: 100%;">
		<tr>
			<td class="auto-style1">Email:</td>
			<td class="auto-style2">
				<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
			</td>
			<td>&nbsp;</td>
		</tr>
		<tr>
			<td class="auto-style1">Password</td>
			<td class="auto-style2">
				<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBox1" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
			</td>
			<td>&nbsp;</td>
		</tr>
		<tr>
			<td class="auto-style1">&nbsp;</td>
			<td class="auto-style2">
				<asp:Button ID="LoginButton" runat="server" OnClick="Button1_Click1" Text="Login" Width="128px" />
			</td>
			<td>
				<asp:Label ID="Label1" runat="server" Text=""></asp:Label>
			</td>
		</tr>
	</table>
	



	</asp:Content>


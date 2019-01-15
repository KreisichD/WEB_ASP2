<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="_AddUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
	</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
	<div class="row">
	<table style="width:100%;" class="off1 col6 push1">
		<tr>
			<td>Id</td>
			<td>
				<asp:TextBox ID="IdBox" runat="server" Width="53px" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
			</td>

		</tr>
		<tr>
			<td>First Name:</td>
			<td>
				<asp:TextBox ID="FirstNameBox" runat="server" Width="167px"></asp:TextBox>
			</td>

		</tr>
		<tr>
			<td>Last Name:</td>
			<td>
				<asp:TextBox ID="LastNameBox" runat="server" Width="165px"></asp:TextBox>
			</td>

		</tr>
		<tr>
			<td>Date Of Birth:</td>
			<td>
				<asp:Calendar ID="BirthDateBox" runat="server"></asp:Calendar>
			</td>

		</tr>
		<tr>
			<td>Email:</td>
			<td>
				<asp:TextBox ID="EmailBox" runat="server" Width="168px"></asp:TextBox>
			</td>

			<tr>
			<td>Password:</td>
			<td>
				<asp:TextBox ID="PasswordBox" runat="server" Width="165px"></asp:TextBox>
				</td>

		</tr>
		<tr>
			<td>Phone:</td>
			<td>
				<asp:TextBox ID="PhoneBox" runat="server" Width="166px"></asp:TextBox>
			</td>

		
	</table>
		<asp:Button ID="Button1" runat="server" Text="Insert" CssClass="off2 col2" OnClick="Button1_Click"/>
	</div>

</asp:Content>


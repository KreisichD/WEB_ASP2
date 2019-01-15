<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProtectedForm.aspx.cs" Inherits="SecretFolder_ProtectedForm"
	MasterPageFile="~/Site.master"%>


<asp:Content ID="ProtectedHead" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="ProtectedContent" ContentPlaceHolderID="MainContent" Runat="Server">
	<div class="row">
	<asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="DataClassesDataContext" EntityTypeName="" Select="new (FirstName, LastName, DateOfBirth, Email, Password, Phone, Id)" TableName="uzytkownik">
	</asp:LinqDataSource>
	<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1" CssClass="off1 col6 push1">
		<Columns>
			<asp:BoundField DataField="FirstName" HeaderText="FirstName" ReadOnly="True" SortExpression="FirstName" />
			<asp:BoundField DataField="LastName" HeaderText="LastName" ReadOnly="True" SortExpression="LastName" />
			<asp:BoundField DataField="DateOfBirth" HeaderText="DateOfBirth" ReadOnly="True" SortExpression="DateOfBirth" />
			<asp:BoundField DataField="Email" HeaderText="Email" ReadOnly="True" SortExpression="Email" />
			<asp:BoundField DataField="Password" HeaderText="Password" ReadOnly="True" SortExpression="Password" />
			<asp:BoundField DataField="Phone" HeaderText="Phone" ReadOnly="True" SortExpression="Phone" />
			<asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
		</Columns>
	</asp:GridView>
		<asp:Button CssClass="off2 col2" ID="Button1" runat="server" Text="Add User" OnClick="Button1_Click" />
		<asp:Button CssClass="col2 push2" ID="Button2" runat="server" Text="Remove User" OnClick="Button2_Click" style="left: 0px; top: 0px" />
	</div>
</asp:Content>

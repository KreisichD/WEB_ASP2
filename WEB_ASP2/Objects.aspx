<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Objects.aspx.cs" Inherits="Objects" MasterPageFile="~/Site.master"%>

<asp:Content ID="objectsHead" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="objectsMainContent" ContentPlaceHolderID="MainContent" runat="server">


	<div class="row">
	<asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="off1 col6 push1">
	</asp:GridView>
	</div>

	<asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="DataClassesDataContext" EntityTypeName="" OnSelecting="LinqDataSource1_Selecting" Select="new (Id, Name, Description, Cost)" TableName="kurs">
	</asp:LinqDataSource>
</asp:Content>


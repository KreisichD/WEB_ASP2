<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" MasterPageFile="~/Site.master" %>

<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/Register.css" />
</asp:Content>

<asp:Content ID="formContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
				<div class="col8">
					<div class="off1 col3">
						First name:
					</div>
					<div class="col4">
						&nbsp;
						<asp:TextBox ID="firstNameTB" runat="server" CssClass="col4"></asp:TextBox>
						<asp:RequiredFieldValidator ID="firstNameValidator" ControlToValidate="firstNameTB" runat="server" ErrorMessage="This field is required" Display="Dynamic"></asp:RequiredFieldValidator>
					</div>

					<div class="off1 col3">
						Last name:
					</div>
					<div class="col4">
						&nbsp;
						<asp:TextBox ID="lastNameTB" runat="server" CssClass="col4"></asp:TextBox>
						<asp:RequiredFieldValidator ID="lastNameValidator" ControlToValidate="lastNameTB" runat="server" ErrorMessage="This filed is required" Display="Dynamic"></asp:RequiredFieldValidator>
					</div>

					<div class="off1 col7">
						Date of birth:
					</div>
					<div class="col8">
						<div class="col5"></div>
						<asp:Calendar ID="dateCal" runat="server" Height="130px"></asp:Calendar>
						&nbsp;&nbsp;
					</div>
					<div class="off1 col3">
						Email adress:

					</div>
					<div class="col4">
						&nbsp;<asp:TextBox ID="emailTB" runat="server" CssClass="col4"></asp:TextBox>
						<asp:RegularExpressionValidator ID="emailRegexpValidator" runat="server" ErrorMessage="Wrong email format" ControlToValidate="emailTB" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
						<asp:RequiredFieldValidator ID="emailRequiredValidator" ControlToValidate="emailTB" runat="server" ErrorMessage="This field is required" Display="Dynamic"></asp:RequiredFieldValidator>
					</div>
					<div class="off1 col3">
						Phone number:
					</div>
					<div class="col4">
						&nbsp;<asp:TextBox ID="phoneTB" runat="server" CssClass="col4"></asp:TextBox>
						<asp:RangeValidator ID="phoneRangeValidator" runat="server" ErrorMessage="Wrong number (use 9 digits)" ControlToValidate="phoneTB" Display="Dynamic" MaximumValue="999999999" MinimumValue="100000000" Type="Integer"></asp:RangeValidator>
						<asp:RequiredFieldValidator ID="phoneRequiredValidator" ControlToValidate="phoneTB" runat="server" ErrorMessage="This field is required" Display="Dynamic"></asp:RequiredFieldValidator>
					</div>

                    <div class="off1 col3">
                        Password:
                    </div>
                    <div class="col4">
                        <asp:TextBox ID="passTB" runat="server" CssClass="col4" TextMode="Password"></asp:TextBox>
                    </div>
				</div>

				<div class="off4 col2">
					<input class="col3" type="submit" value="Send" />
				</div>
				<%--<div class="col3 push1">
					<input class="col6" type="reset" value="Clear" />
				</div>--%>

			</div>

		<div class="off2 col4">
			<asp:Label ID="outputLabel" runat="server" Text=""></asp:Label>
		</div>
</asp:Content>

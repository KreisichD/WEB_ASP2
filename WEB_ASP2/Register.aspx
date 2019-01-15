<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" MasterPageFile="~/Site.master" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp_ajax" %>

<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/Register.css" />
</asp:Content>

<asp:Content ID="formContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <asp_ajax:ToolkitScriptManager ID="ScriptManager" runat="server">
        </asp_ajax:ToolkitScriptManager>

        <asp_ajax:TabContainer ID="tabContainer" runat="server" ActiveTabIndex="0" Width="450px">
            <asp_ajax:TabPanel ID="tab1" HeaderText="Name" runat="server">
                <ContentTemplate>
                    <div class="off1 col3">
                        First name:
                    </div>
                    <div class="col4">
                        <asp:TextBox ID="firstNameTB" runat="server" CssClass="col4"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="firstNameValidator" ControlToValidate="firstNameTB" runat="server" ErrorMessage="This field is required" Display="None"></asp:RequiredFieldValidator>
                        <asp_ajax:ValidatorCalloutExtender ID="firstNameValidator_calloutExtender" runat="server" Enabled="true" TargetControlID="firstNameValidator"></asp_ajax:ValidatorCalloutExtender>
                    </div>

                    <div class="off1 col3">
                        Last name:
                    </div>
                    <div class="col4">
                        <asp:TextBox ID="lastNameTB" runat="server" CssClass="col4"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="lastNameValidator" ControlToValidate="lastNameTB" runat="server" ErrorMessage="This filed is required" Display="None"></asp:RequiredFieldValidator>
                        <asp_ajax:ValidatorCalloutExtender ID="lastNameValidator_calloutExtender" runat="server" Enabled="true" TargetControlID="lastNameValidator"></asp_ajax:ValidatorCalloutExtender>
                    </div>
                </ContentTemplate>
            </asp_ajax:TabPanel>

            <asp_ajax:TabPanel ID="tab2" HeaderText="Contact" runat="server">
                <ContentTemplate>
                    <div class="off1 col3">
                        Email adress:
                    </div>
                    <div class="col4">
                        <asp:TextBox ID="emailTB" runat="server" CssClass="col4"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="emailRegexpValidator" runat="server" ErrorMessage="Wrong email format" ControlToValidate="emailTB" Display="None" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        <asp_ajax:ValidatorCalloutExtender ID="emailRegexpValidator_calloutExtender" runat="server" Enabled="true" TargetControlID="emailRegexpValidator"></asp_ajax:ValidatorCalloutExtender>
                    </div>
                    <div class="off1 col3">
                        Phone number:
                    </div>
                    <div class="col4">
                        <asp:TextBox ID="phoneTB" runat="server" CssClass="col4"></asp:TextBox>
                        <asp:RangeValidator ID="phoneRangeValidator" runat="server" ErrorMessage="Wrong number (use 9 digits)" ControlToValidate="phoneTB" Display="None" MaximumValue="999999999" MinimumValue="100000000" Type="Integer"></asp:RangeValidator>
                        <asp_ajax:ValidatorCalloutExtender ID="phoneRangeValidator_calloutExtender" runat="server" Enabled="true" TargetControlID="phoneRangeValidator"></asp_ajax:ValidatorCalloutExtender>
                    </div>
                </ContentTemplate>
            </asp_ajax:TabPanel>
        </asp_ajax:TabContainer>

        <asp:UpdatePanel ID="updatePanel" runat="server">
            <ContentTemplate>
                <div class="off4 col2">
                    <asp:Button ID="submitBtn" runat="server" Text="Send" />
                </div>

                <div class="off2 col4">
                    <asp:Label ID="outputLabel" runat="server" Visible="false"></asp:Label>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="submitBtn" EventName="click" />
            </Triggers>
        </asp:UpdatePanel>
    </div>
</asp:Content>


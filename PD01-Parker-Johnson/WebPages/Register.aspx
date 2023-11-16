<%@ Page Title="" Language="C#" MasterPageFile="~/UlsterFly.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PD01_Parker_Johnson.WebPages.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="login">
        <div class="login-wrapper">

            <table cellpadding="1" cellspacing="0" style="border-collapse: collapse;">
                <tr>
                    <td align="center" colspan="2" class="login-head">Register</td>
                </tr>

                <tr>
                    <td align="right">
                        <asp:Label ID="lblEmail" CssClass="mb-2 login-font" runat="server" AssociatedControlID="txtEmail">Email:</asp:Label>
                    </td>

                    <td>
                        <asp:TextBox ID="txtEmail" CssClass="login-form mb-2" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="fvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is required." ToolTip="Email is required." style="color: crimson;">*</asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td align="right">
                        <asp:Label ID="lblName" CssClass="mb-2 login-font" runat="server" AssociatedControlID="txtEmail">Full Name:</asp:Label>
                    </td>

                    <td>
                        <asp:TextBox ID="txtName" CssClass="login-form mb-2" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Name is required." ToolTip="Name is required." style="color: crimson;">*</asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td align="right">
                        <asp:Label ID="lblPass" CssClass="mb-2 login-font" runat="server" AssociatedControlID="txtEmail">Password:</asp:Label>
                    </td>

                    <td>
                        <asp:TextBox ID="txtPass" CssClass="login-form mb-2" runat="server" TextMode="Password" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPass" ErrorMessage="Name is required." ToolTip="Password is required." style="color: crimson;">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                
                <tr>
                    <td align="center" colspan="2" class="mb-2">
                        <asp:Label ID="lblFail" runat="server" style="color: crimson; font-size: small;"></asp:Label>
                    </td>
                </tr>

                <tr >
                    <td align="right" colspan="2" style="height: auto;" class="mt=3;">
                        <asp:Button ID="regButton" CssClass="login-btn" runat="server" CommandName="Register" Text="Create Account" OnClick="regButton_Click" />
                    </td>
                </tr>
            </table>

        </div>
    </div>
</asp:Content>

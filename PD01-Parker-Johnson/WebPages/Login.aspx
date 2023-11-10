<%@ Page Title="" Language="C#" MasterPageFile="~/UlsterFly.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PD01_Parker_Johnson.WebPages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="login">
        <div class="login-wrapper">

            <asp:Login ID="Login1" runat="server">
                <LayoutTemplate>
                    <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                        <tr>
                            <td>
                                <table cellpadding="1">
                                    
                                    <tr>
                                        <td align="center" colspan="2" class="login-head">Log In</td>
                                    </tr>

                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="UserNameLabel" CssClass="mb-2 login-font" runat="server" AssociatedControlID="txtUserEmail">Email:</asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtUserEmail" CssClass="login-form mb-2" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="txtUserEmail" ErrorMessage="Email is required." ToolTip="Email is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="PasswordLabel" CssClass="mb-2 login-font" runat="server" AssociatedControlID="txtPassword">Password:</asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtPassword" CssClass="login-form mb-2" runat="server" TextMode="Password"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td colspan="2">
                                            <asp:CheckBox ID="RememberMe" CssClass="login-font" runat="server" Text=" Remember me." />
                                        </td>
                                    </tr>

                                    <tr>
                                        <td colspan="2">
                                            <asp:HyperLink ID="HyperLink1" CssClass="login-reg login-font" runat="server">Create an account</asp:HyperLink>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td align="center" colspan="2" style="color: crimson;">
                                            <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td align="right" colspan="2" style="height: auto;" class="mt=3;">
                                            <asp:Button ID="LoginButton" CssClass="login-btn" runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login1" OnClick="LoginButton_Click" />
                                        </td>
                                    </tr>

                                </table>
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
            </asp:Login>

        </div>
    </div>

</asp:Content>

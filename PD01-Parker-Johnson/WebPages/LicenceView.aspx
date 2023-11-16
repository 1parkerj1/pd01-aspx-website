<%@ Page Title="" Language="C#" MasterPageFile="~/UlsterFly.Master" AutoEventWireup="true" CodeBehind="LicenceView.aspx.cs" Inherits="PD01_Parker_Johnson.WebPages.LicenceView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="login">
        <div class="login-wrapper">


            <table cellpadding="1" cellspacing="0" style="border-collapse: collapse;">

                <tr align="left">
                    <td>
                        <img src="../Images/logo.png" />
                    </td>
                    <td>
                        <h4>Fishing Licence</h4>
                    </td>
                </tr>

                <tr>
                    <td align="left">
                        <asp:Label ID="lblLicence" CssClass="mb-2 login-font" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblExpiry" CssClass="mb-2 login-font" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblName" CssClass="mb-2 login-font" runat="server" Text="Label"></asp:Label>
                    </td>
                     <td>
                        <asp:Label ID="lblAddress" CssClass="mb-2 login-font" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>

            </table>


            </div>
        </div>
</asp:Content>

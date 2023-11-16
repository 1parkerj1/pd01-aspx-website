<%@ Page Title="Licences" Language="C#" MasterPageFile="~/UlsterFly.Master" AutoEventWireup="true" CodeBehind="Licenses.aspx.cs" Inherits="PD01_Parker_Johnson.WebPages.Licenses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid page-background">
        <div class="content">
            <h1 class="pt-4">Purchase Fishing Licences</h1>

            <h3 class="pb-3">Types of Licenses:</h3>

            <table align="center" class="table">
                <tr class="alt1">
                    <th>Angler Age</th>
                    <th>Type of rod licence</th>
                    <th>Number of rods allowed</th>
                    <th>Price:</th>
                </tr>
                <tr style="color: black;">
                    <th class="alt1">Under 18</th>
                    <td>No Rod licence needed</td>
                    <td>One rod at any time</td>
                    <th>£10</th>
                </tr>
                <tr>
                    <th class="alt1">18-60</th>
                    <td>Season Game/Rod licence</td>
                    <td>Two rods at any time</td>
                    <th>£50</th>
                </tr>
                <tr>
                    <th class="alt1">Over 60</th>
                    <td>Conessionary season Game/Rod licence</td>
                    <td>Two rods at any time</td>
                    <th>£15</th>
                </tr>
                <tr>
                    <th class="alt1">Disabled</th>
                    <td>Conessionary season Game/Rod licence</td>
                    <td>Two rods at any time</td>
                    <th>£10</th>
                </tr>
            </table>

            <h3 style="margin-top: 3%;">Documents you need</h3>
            <p>To fish in Northern Ireland you need:</p>

            <div class="smolul">
                <ul style="color: white;">
                    <li>
                        <p>rod licence plus</p>
                    </li>
                    <li>
                        <p>a fishing permit</p>
                    </li>
                </ul>
            </div>

            <p>
                The Yearly Permit/Rod licence gives the angler permission to fish in the chosen water.<br />
            </p>

            <h3 style="margin-top: 3%;">Have proof to show you're fishing legally</h3>
            <p>
                DAERA Fishery Protection Officers do carry out licence checks so make sure all rod<br />licences and permits are valid.
                If it is found that the information received is incorrect, DAERA  will cancel the licence and<br />
                offer the holder the opportunity to buy a non concessionary rod licence/ permit.<br />
                No refund will be given.  For more information visit <a class="link" href="https://www.nidirect.gov.uk/articles/have-proof-show-youre-fishing-legally">'Have proof to show you're fishing legally'</a>.
            </p>



            <div class="bigul">

                <table cellpadding="1" cellspacing="0" style="border-collapse: collapse;">
                    <tr>
                        <td align="center" colspan="2" class="login-head">Purchase Licence</td>
                    </tr>

                    <tr>
                        <td align="center">
                            <asp:Label ID="lblEmail" CssClass="mb-2 login-font" runat="server" AssociatedControlID="txtEmail">Email:</asp:Label>
                        </td>

                        <td align="center">
                            <asp:TextBox ID="txtEmail" CssClass="login-form mb-2" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="fvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is required." ToolTip="Email is required." Style="color: crimson;">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>

                    <tr>
                        <td align="center">
                            <asp:Label ID="lblFname" CssClass="mb-2 login-font" runat="server" AssociatedControlID="txtFname">First Name:</asp:Label>
                        </td>

                        <td align="center">
                            <asp:TextBox ID="txtFname" CssClass="login-form mb-2" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFname" ErrorMessage="First Name is required." ToolTip="First Name is required." Style="color: crimson;">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>

                    <tr>
                        <td align="center">
                            <asp:Label ID="lblSname" CssClass="mb-2 login-font" runat="server" AssociatedControlID="txtSname">Second Name:</asp:Label>
                        </td>

                        <td align="center">
                            <asp:TextBox ID="txtSname" CssClass="login-form mb-2" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtSname" ErrorMessage="Second Name is required." ToolTip="Second Name is required." Style="color: crimson;">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>

                    <tr align="center">
                        <td>
                            <asp:Label ID="lblAddress" CssClass="mb-2 login-font" runat="server" AssociatedControlID="txtAddress">Address:</asp:Label>
                        </td>

                        <td>
                            <asp:TextBox ID="txtAddress" CssClass="login-form mb-2" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAddress" ErrorMessage="Address is required." ToolTip="Address is required." Style="color: crimson;">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>

                    <tr>
                        <td align="center" colspan="2" class="mb-2">
                            <asp:Label ID="lblDOB" CssClass="login-font" runat="server" AssociatedControlID="txtEmail">Date Of Birth:</asp:Label>
                        </td>
                    </tr>

                    <%--<tr align="center">
                        <td align="center" colspan="2" class="mb-2">
                            <asp:Calendar ID="Calendar1" class="mb-2" runat="server" BackColor="White" AutoPostBack="False" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="monospace" Font-Size="11pt" ForeColor="Black" Height="180px" OnSelectionChanged="Calendar1_SelectionChanged" Width="213px">
                                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="10pt" />
                                <NextPrevStyle VerticalAlign="Bottom" />
                                <OtherMonthDayStyle ForeColor="#808080" />
                                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                <SelectorStyle BackColor="#CCCCCC" />
                                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                <WeekendDayStyle BackColor="#FFFFCC" />
                            </asp:Calendar>
                        </td>
                    </tr>--%>

                    <%--<tr>                        
                        <td align="center" colspan="2" class="mb-2">
                            <asp:TextBox ID="txtDtp" CssClass="login-form mb-2" runat="server"></asp:TextBox>
                            <asp:LinkButton ID="lnkPickDate" CssClass="login-btn" runat="server">Get Date</asp:LinkButton>
                        </td>
                    </tr>--%>

                    <tr>
                        <td align="center" colspan="2" class="mb-2">
                            <asp:DropDownList ID="ddlDay" CssClass="login-form mb-1" runat="server"></asp:DropDownList>
                            <asp:DropDownList ID="ddlMonth" CssClass="login-form mb-1" runat="server"></asp:DropDownList>
                            <asp:DropDownList ID="ddlYear" CssClass="login-form mb-1" runat="server"></asp:DropDownList> &nbsp;
                            <asp:Button ID="ddlUpdate" CssClass="login-btn mb-2" runat="server" OnClick="ddlUpdate_Click" Text="add date" Width="85px" />
                        </td>
                    </tr>

                    <tr>
                        <td align="center" colspan="2" class="mb-2">
                            <asp:CheckBox ID="txtDisabled" Style="font-family: monospace; color: white;" runat="server" Text="are yew recognized as Disabled?" />
                        </td>
                    </tr>

                    <tr>
                        <td align="center" colspan="2" class="mb-2">
                            <asp:Label ID="lblFail" class="mb-4" runat="server" Style="color: crimson; font-size: small;"></asp:Label>
                        </td>
                    </tr>


                    <tr>
                        <td align="right" colspan="2" style="height: auto;" class="mt=3;">
                            <asp:Label CssClass="typeLabel" ID="lblLicenceType" runat="server"></asp:Label>
                            &nbsp;
                            <asp:Label CssClass="typeLabel" ID="lblLicencePrice" runat="server" Style="margin-right: 3%"></asp:Label>

                            <asp:Button ID="btnLicence" CssClass="login-btn" runat="server" CommandName="Register" Text="Purchase" OnClick="btnLicence_Click" />
                        </td>
                    </tr>
                </table>

            </div>



        </div>
    </div>

</asp:Content>

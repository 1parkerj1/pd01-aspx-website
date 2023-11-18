<%@ Page Title="" Language="C#" MasterPageFile="~/UlsterFly.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="PD01_Parker_Johnson.SecurePages.Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container" style="height: 100vh;">

        <h1 class="text-center new">Admin View</h1>

        <div class="gridview" style="text-align: center;">


            <h3 class="new mb-3">All Users:</h3>

            <asp:Label class="login-font" runat="server">Remove User: </asp:Label> &nbsp;
            <asp:TextBox class="login-form" runat="server" ID="txtRemove"></asp:TextBox>&nbsp;
            <asp:Button class="login-btn" runat="server" ID="btnRemoveUser" Text="Remove" OnClick="btnRemoveUser_Click" /> &nbsp;
            <asp:Label class="login-font" runat="server" ID="lblFail" Visible="False" style="color: crimson;"></asp:Label>
            
            <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center" CssClass="gridview mt-3" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="UserID" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" ReadOnly="True" SortExpression="UserID" />
                    <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                    <asp:BoundField DataField="UserEmail" HeaderText="UserEmail" SortExpression="UserEmail" />
                    <asp:BoundField DataField="UserExpiry" HeaderText="UserExpiry" SortExpression="UserExpiry" />
                    <asp:BoundField DataField="LicenceType" HeaderText="LicenceType" SortExpression="LicenceType" />
                    <asp:BoundField DataField="UserAddress" HeaderText="UserAddress" SortExpression="UserAddress" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#001D4A" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F0BE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F0BE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [UserID], [UserName], [UserEmail], [UserExpiry], [LicenceType], [UserAddress] FROM [Users] ORDER BY [UserExpiry] DESC"></asp:SqlDataSource>



            <h3 class="new">Expired Licences:</h3>
            <asp:GridView ID="GridView2" runat="server" HorizontalAlign="center" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="UserID" DataSourceID="SqlDataSource2" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" ReadOnly="True" SortExpression="UserID" />
                    <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                    <asp:BoundField DataField="UserEmail" HeaderText="UserEmail" SortExpression="UserEmail" />
                    <asp:BoundField DataField="UserExpiry" HeaderText="UserExpiry" SortExpression="UserExpiry" />
                    <asp:BoundField DataField="LicenceType" HeaderText="LicenceType" SortExpression="LicenceType" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#001D4A" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F0BE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F0BE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [expiry]"></asp:SqlDataSource>


        </div>
    </div>


</asp:Content>

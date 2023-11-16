<%@ Page Title="Index" Async="true" Language="C#" MasterPageFile="~/UlsterFly.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PD01_Parker_Johnson.WebPages.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid page-background">
        <div class="content">
            <h1 class="pt-4">Ulster Fly</h1>
            <h3 class="pt-4">Fly Fishing - Northern Ireland</h3>

            <div class="row">
                <div class="col-md-6">

                    <div class="left-column mt-6 mb-5 weatherWrapper">
                        <br />
                        <br />
                        <h3 class="mb-6">Weather Information:</h3>

                        <table align="center" class="">

                            <tr>
                                <td align="center" colspan="2" class="mb-2">
                                    <p class="mb-3">Enter City for weather information:</p>
                                </td>
                            </tr>

                            <tr>
                                <td align="center" colspan="2" class="mb-2">
                                    <asp:TextBox ID="txtCity" CssClass="login-form" runat="server"></asp:TextBox>
                                    &nbsp;
                                    <asp:Button ID="btnCity" CssClass="login-btn mb-1" runat="server" Text="Search" OnClick="btnCity_Click" />
                                </td>
                            </tr>

                            <tr>
                                <td align="center" colspan="2" class="mb-2">
                                    <asp:Label ID="lblFail" class="mb-4" runat="server" Style="color: crimson; font-size: small;"></asp:Label>
                                </td>
                            </tr>

                            <tr>
                                <td align="left" colspan="2" class="mb-2 mt-3">
                                    <p style="font-size: 1em;">
                                        City name:
                                        <asp:Label ID="lblCity" runat="server"></asp:Label>
                                    </p>

                                </td>
                            </tr>

                            <tr>
                                <td align="left" colspan="2" class="mb-2">
                                    <p style="font-size: 1em;">
                                        Tempature:
                                        <asp:Label ID="lblTemp" runat="server"></asp:Label>
                                    </p>

                                </td>
                            </tr>

                            <tr>
                                <td align="left" colspan="2" class="">
                                    <p style="font-size: 1em;">
                                        Forecast:
                                        <asp:Label ID="lblForecast" runat="server"></asp:Label>
                                    </p>

                                </td>
                            </tr>


                        </table>


                    </div>

                </div>

                <div class="col-md-6">
                    <br />
                    <br />
                    <div class="right-column">
                        <p>Discover the serene beauty and exceptional angling experiences nestled in the heart of Northern Ireland's stunning landscapes. Our passion for fly fishing is matched only by the breathtaking scenery and abundant waters that make this region a paradise for anglers.</p>

                        <div id="demo" class="carousel slide" data-bs-ride="carousel">

                            <!-- The slideshow/carousel -->
                            <div class="carousel-inner">
                                <div class="carousel-item active">
                                    <img src="../Images/Ballykeel.jpg" class="d-block w-100">
                                </div>
                                <div class="carousel-item">
                                    <img src="../Images/Bantry.jpg" class="d-block w-100">
                                </div>
                                <div class="carousel-item">
                                    <img src="../Images/LoughErne.jpg" class="d-block w-100">
                                </div>
                                <div class="carousel-item">
                                    <img src="../Images/Stoneyford.jpg"  class="d-block w-100">
                                </div>
                            </div>

                            <!-- Left and right controls/icons -->
                            <button class="carousel-control-prev" type="button" data-bs-target="#demo" data-bs-slide="prev">
                                <span class="carousel-control-prev-icon"></span>
                            </button>
                            <button class="carousel-control-next" type="button" data-bs-target="#demo" data-bs-slide="next">
                                <span class="carousel-control-next-icon"></span>
                            </button>
                        </div>

                        <p class="mt-3">We hold a profound respect for the environment and the species that inhabit these waters. As stewards of this natural beauty, we emphasize responsible fishing practices to preserve these ecosystems for future generations of anglers.</p>
                        <br />
                        <p>On this website, you will find a great deal of information about the Ulster fishing scene and tecniques used by anglers across the area.</p>
                    </div>

                </div>

            </div>

        </div>
    </div>



</asp:Content>



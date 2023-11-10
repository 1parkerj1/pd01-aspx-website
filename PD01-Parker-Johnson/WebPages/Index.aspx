<%@ Page Title="" Language="C#" MasterPageFile="~/UlsterFly.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PD01_Parker_Johnson.WebPages.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid page-background">
        <div class="row justify-content-center">
            <div class="col-xxl-10 text-center">


                <div style="height: 100vh;">

                    <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
                        <div class="carousel-inner">
                            <div class="carousel-item active">
                                <img class="d-block w-100" src="" alt="First slide">
                            </div>
                            <div class="carousel-item">
                                <img class="d-block w-100" src="" alt="Second slide">
                            </div>
                            <div class="carousel-item">
                                <img class="d-block w-100" src="" alt="Third slide">
                            </div>
                        </div>
                        <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="sr-only">Previous</span>
                        </a>
                        <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="sr-only">Next</span>
                        </a>
                    </div>


                </div>



            </div>
        </div>
    </div>


</asp:Content>



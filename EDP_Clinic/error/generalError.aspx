﻿<%@ Page Title="General Error" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="generalError.aspx.cs" Inherits="EDP_Clinic.generalError" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <section class="w3l-contact py-5" id="generalError">
        <div class="container py-lg-3">
            <div class="mt-5 text-center">
                <h1 class="title mb-4">Hmmmmmm</h1>
                <p class="mb-4">It seems something went wrong somewhere</p>
                <p class="mb-4">Don't worry as you can go back easily to where you are!</p>
                <div style="display: flex; justify-content: center;">
                    <asp:Button ID="goHomeBtn" runat="server" Text="Go back home" CssClass="btn btn-primary btn-style" OnClick="goHomeBtn_Click" />
                </div>
            </div>
        </div>
    </section>
</asp:Content>

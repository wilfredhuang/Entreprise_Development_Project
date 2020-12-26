﻿<%@ Page Title="Payment Information" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaymentInformation.aspx.cs" Inherits="EDP_Clinic.PaymentInformation" %>
<asp:Content ID="head" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="w3l-contact py-5" id="paymentInfo" style="height:100vh;">
          <div class="container py-lg-3">
              <button class="btn btn-primary btn-style">Back
              </button>
              <br />
              <br />
              <h1 class="title mb-4">Payment Information</h1>
              <h4 class="mb-4">Name on Card: Hasan</h4>
              <h4 class="mb-4">Card Number: 12345678</h4>
              <h4 class="mb-4">Card Expiry: 12/2020</h4>
              <h4 class="mb-4">CVV Number: 0123</h4>
              <div class="row">
                  <div class="col-9"></div>
                  <div class="col-1">
                      <button class="btn btn-primary btn-style mr-5">Delete
                      </button>
                  </div>
                  <div class="col-2">
                      <button class="btn btn-primary btn-style ml-5">Update
                      </button>
                  </div>
              </div>
<%--              <button class="btn btn-primary btn-style mr-5">delete
              </button>
              <button class="btn btn-primary btn-style ml-5">update
              </button>--%>
          </div>
    </section>
</asp:Content>
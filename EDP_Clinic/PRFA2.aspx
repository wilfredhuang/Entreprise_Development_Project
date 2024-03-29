﻿<%@ Page Title="View Appointments" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PRFA2.aspx.cs" Inherits="EDP_Clinic.PRFA2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .btn_mka {
            border-radius: 15px;
        }

        .btn_Cancel {
            border-radius: 15px;
        }

        .btn_Rsch {
            border-radius: 15px;
        }

        .breadcrumb-item + .breadcrumb-item::before {
            content: ">";
        }

        .hyperlink_breadcrumb {
            color: black;
            text-decoration: none;
        }

        .lbtn_inactive {
            color: black;
            text-decoration: none;
        }
    </style>

    <script>
        function showModal() {
            $('#cancelModal').modal('show');
        }

        $(function () {
            $("#cancelBtn").click(function () {
                showModal();
            });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <!-- Breadcrumb -->
        <nav aria-label="breadcrumb">
            <ol class="breadcrumb">
                <li class="breadcrumb-item active">
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="hyperlink_breadcrumb" NavigateUrl="~/UserPage.aspx">User Page</asp:HyperLink>
                </li>
                <li class="breadcrumb-item active">
                    <asp:HyperLink ID="hl_bc_appt" runat="server" CssClass="hyperlink_breadcrumb" NavigateUrl="~/PFA.aspx">Appointments</asp:HyperLink>
                </li>
                <li class="breadcrumb-item active" aria-current="page">
                    <asp:HyperLink ID="hl_bc_profileName" runat="server" CssClass="hyperlink_breadcrumb_active"></asp:HyperLink>
                </li>
            </ol>
        </nav>
        <h2 class="mb-3">View Appointments</h2>
        <div class="card-header mb-5">
            <div class="row">
                <div class="col-sm-8">
                    <asp:ImageButton ID="leftArrow_redirect" runat="server" Height="50px" ImageAlign="Left" ImageUrl="~/assets/images/leftArrow.png" Width="50px" OnClick="leftArrow_redirect_Click" />
                    <asp:Image ID="profilePfp" runat="server" ImageUrl="~/assets/images/pfp_placeholder.png" Height="50px" Width="50px" />
                    <asp:Label ID="lbl_profileName" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-sm-4">
                    <asp:Button runat="server" Text="Make New Appointment" CssClass="btn_mka btn btn-primary text-white" ID="btn_makeAppt" OnClick="btn_makeAppt_Click" />
                </div>
            </div>
            <div class="row mt-2">
                <div class="col-4 upcoming text-primary">
                    <asp:LinkButton ID="lbtn_upcoming" runat="server" OnClick="lbtn_upcoming_Click" CssClass="test">Upcoming</asp:LinkButton>
                </div>
                <div class="col-4 missed">
                    <asp:LinkButton ID="lbtn_past" runat="server" CssClass="lbtn_inactive test" OnClick="lbtn_past_Click">Past</asp:LinkButton>
                </div>
                <div class="col-4 missed">
                    <asp:LinkButton ID="lbtn_missed" runat="server" OnClick="lbtn_missed_Click" CssClass="lbtn_inactive test">Missed</asp:LinkButton>
                </div>
            </div>
        </div>
        <asp:ListView ID="listview_appts" runat="server" OnPagePropertiesChanging="listview_appts_PagePropertiesChanging" OnSelectedIndexChanged="listview_appts_SelectedIndexChanged">
            <ItemTemplate>
                <div class="card">
                    <div class="card-header">
                        <p>
                            Date Time:
                        <asp:Label ID="lbl_c_dt" runat="server" Text='<%# Eval("dateTime") %>'></asp:Label>
                        </p>
                        <p>
                            Type:
                        <asp:Label ID="lbl_c_at" runat="server" Text='<%# Eval("appointmentType") %>'></asp:Label>
                        </p>
                        <p>
                            Doctor:
                        <asp:Label ID="lbl_c_dn" runat="server" Text='<%# Convert_ID_To_Name( Eval("doctorID") ) %>'></asp:Label>
                        </p>
                        <% if (Session["appt_viewstate"].ToString() == "upcoming")
                            { %>
                        <div class="row mt-1 mx-2">
                            <asp:Button ID="btn_Rsch" runat="server" Text="Reschedule" CssClass="btn_Rsch btn btn-primary col-3 align-content-end" OnClick="btn_RschOnClick" />
                            <span class="col-3"></span>
                            <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CssClass="btn_Cancel btn btn-danger col-3" OnClick="btn_CancelOnClick" />
                            <span class="col-3"></span>
                        </div>
                        <% } %>

                        <% else if (Session["appt_viewstate"].ToString() == "past")
                            {  %>
                        <div class="row mt-1 mx-2">
                            <asp:Button ID="Button1" runat="server" Text="Payment" CssClass="btn_Rsch btn btn-primary col-3 align-content-end" OnClick="btn_PaymentOnClick" />
                            <span class="col-3"></span>
                            <!-- <asp:Button ID="Button2" runat="server" Text="Cancel2" CssClass="btn_Cancel bg-white text-primary btn-outline-primary col-3" OnClick="btn_CancelOnClick" /> -->
                            <span class="col-3"></span>
                        </div>
                        <%} %>
                    </div>
                </div>
            </ItemTemplate>
            <EmptyDataTemplate>
                <div class="mt-5 mb-3 text-center">
                    <h5>No Record Found</h5>
                </div>
            </EmptyDataTemplate>
        </asp:ListView>
        <div class="mt-5 text-center">
            <asp:DataPager ID="dp_listview_appt" runat="server" PagedControlID="listview_appts" PageSize="2">
                <Fields>
                    <asp:NextPreviousPagerField ButtonCssClass="btn btn-primary" ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                    <asp:NumericPagerField ButtonType="Link" />
                    <asp:NextPreviousPagerField ButtonCssClass="btn btn-primary" ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                </Fields>
            </asp:DataPager>
        </div>
        <!-- Modal -->
        <div class="modal fade" id="cancelModal" tabindex="-1" role="dialog" aria-labelledby="cancelModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Cancel Appointment?</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                        <button type="button" class="btn btn-primary">Cancel</button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- OLD CARD HEADER, LEAVE FOR POTENTIAL FUTURE RE-USE
        <div class="card-header">
            <div class="row">
                <div class="col-8">                            <h4> Date Time: 02 December 2020 (WED) 02:30PM</h4></h4> </div>
                                <div class="col-4"></div>
            </div>
            <div class="row">
                      <div class="col-8">      <h4> Type: Consultation </h4> </div>
                <div class="col-4"></div>
            </div>

            <div class="row">
                <div class="col-8 col-sm-12">            <h4> Doctor: Johnson Tan </h4> </div>
                </div>
            <div class="row">
                <div class="col-8 col-lg-6"></div>
                <div class="col-2 col-sm-6 mt-2 col-lg-3">
                    <asp:Button ID="btn_Rsch" runat="server" Text="Reschedule" CssClass="btn_Rsch bg-primary text-white" /> </div>
                                <div class="col-2 col-sm-6 mt-2 col-lg-3"> 
                                    <button class="btn_Cancel bg-white text-primary btn-outline-primary"  data-toggle="modal" data-target="#cancelModal" onclick="btn_cancel_click" id="cancelBtn"> Cancel  </button>

                                </div>
                </div>
            </div>
        -->
    <!-- 
        <div class="card-header">
            <h4>Date Time: 02 December 2020 (WED) 02:30PM </h4>
            <h4> Type: Consultation </h4>
            <h4> Doctor: Johnson Tan </h4>
            <div class="row">
                                    <asp:Button ID="btn_Rsch3" runat="server" Text="Reschedule" CssClass="btn_Rsch bg-primary text-white col-3 align-content-end ml-2" />
                                    <span class="col-3"></span>
                                    <button class="btn_Cancel bg-white text-primary btn-outline-primary col-3"  data-toggle="modal" data-target="#cancelModal" onclick="btn_cancel_click" id="cancelBtn"> Cancel  </button>
                         <span class="col-3"></span>
            </div>
        </div>
        -->
</asp:Content>

﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="jobSearch.aspx.cs" Inherits="JobFair.Forms.JobSeeker.jobSearch" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="JobsearchCnt" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <!DOCTYPE html>
    <%--<script runat="server">
        protected void chkFreshness_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Label1.Text = "You Selected:<br /><i>";
            foreach (ListItem li in chkFreshness.Items)
            {
                if (li.Selected == true)
                {
                    Label1.Text += li.Text + "<br />";
                }
            }
            Label1.Text += "</i>";
        }
    </script>--%>
    <script>
        $('#checkbox_filter').click(function () { oTable.fnDraw(); });
        /* Custom filtering function which will filter data in column four between two values */
        $.fn.dataTableExt.afnFiltering.push(
            function (oSettings, aData, iDataIndex) {

                if ($('#starfilter').attr('checked')) {
                    if ($('input', oTable.fnGetNodes(iDataIndex)).is(':checked')) {
                        return true
                    }
                }
                else {
                    return true
                }
            }
        );
    </script>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="container">
        <div class="row vdivide">
            <div class="col-md-2 text-left pull-left">
                <div class="h4"><span>Refine Request</span> </div>
                <hr />
                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelFreshness">Job Freshness</button>
                <div id="PanelFreshness" class="collapse">
                    <asp:CheckBoxList ID="chkFreshness" runat="server" AutoPostBack="True" OnSelectedIndexChanged="chkFreshness_SelectedIndexChanged">
                        <asp:ListItem>30 Days</asp:ListItem>
                        <asp:ListItem>25 Days</asp:ListItem>
                        <asp:ListItem>20 Days</asp:ListItem>
                        <asp:ListItem>15 Days</asp:ListItem>
                        <asp:ListItem>10 Days</asp:ListItem>
                        <asp:ListItem>7 Days</asp:ListItem>
                        <asp:ListItem>1 Day</asp:ListItem>
                    </asp:CheckBoxList>
                </div>

                <hr />
                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelLoaction">Job Location</button>
                <div id="PanelLoaction" class="collapse">
                    <asp:CheckBoxList ID="chkLocation" runat="server" OnSelectedIndexChanged="chkLocation_SelectedIndexChanged"></asp:CheckBoxList>
                </div>
                <hr />

                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelRole">Role</button>
                <div id="PanelRole" class="collapse">
                    <asp:CheckBoxList ID="chkRole" runat="server" OnSelectedIndexChanged="chkRole_SelectedIndexChanged"></asp:CheckBoxList>
                </div>
                <hr />

                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelFunctArea">Functional Area</button>
                <div id="PanelFunctArea" class="collapse">
                    <asp:CheckBoxList ID="chkFunctArea" runat="server"></asp:CheckBoxList>
                </div>
                <hr />

                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelCompanyLevel">Company Level</button>
                <div id="PanelCompanyLevel" class="collapse">
                    <asp:CheckBoxList ID="chkCompanyLevel" runat="server" AutoPostBack="true" OnSelectedIndexChanged="chkCompanyLevel_SelectedIndexChanged">
                        <asp:ListItem Text="Start level Company" Value="Start level Company"></asp:ListItem>
                        <asp:ListItem Text="Small Scale Company" Value="Small Scale Company"></asp:ListItem>
                        <asp:ListItem Text="Mid Level Company" Value="Mid Level Company"></asp:ListItem>
                        <asp:ListItem Text="MNC" Value="MNC"></asp:ListItem>
                    </asp:CheckBoxList>
                </div>
                <hr />
                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelIndustry">Industry</button>
                <div id="PanelIndustry" class="collapse">
                    <asp:CheckBoxList ID="chkIndustry" runat="server" AutoPostBack="true" OnSelectedIndexChanged="chkIndustry_SelectedIndexChanged"></asp:CheckBoxList>
                </div>
                <hr />
                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelSalary">Salary</button>
                <div id="PanelSalary" class="collapse">
                    <asp:CheckBoxList ID="chkSalary" runat="server">
                        <asp:ListItem>0-3 Lakhs</asp:ListItem>
                        <asp:ListItem>3-6 Lakhs</asp:ListItem>
                        <asp:ListItem>6-10 Lakhs</asp:ListItem>
                        <asp:ListItem>10-15 Lakhs</asp:ListItem>
                        <asp:ListItem>15- 20 Lakhs</asp:ListItem>
                        <asp:ListItem>20-25 Lakhs</asp:ListItem>
                        <asp:ListItem>more</asp:ListItem>
                    </asp:CheckBoxList>
                </div>
                <hr />
                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelEducation">Education</button>
                <div id="PanelEducation" class="collapse">
                    <asp:CheckBoxList ID="chkEducation" runat="server"></asp:CheckBoxList>
                </div>
                <hr />
                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelStatus">Employment Status</button>

                <div id="PanelStatus" class="collapse">
                    <asp:CheckBoxList ID="chkStatus" runat="server">
                        <asp:ListItem>Full Time</asp:ListItem>
                        <asp:ListItem>Part Time</asp:ListItem>
                    </asp:CheckBoxList>
                </div>
                <hr />
                <button type="button" class="btn btn-link" data-toggle="collapse" data-target="#PanelJobType">Job Type</button>

                <div id="PanelJobType" class="collapse">

                    <asp:CheckBoxList ID="chkJobType" runat="server">
                        <asp:ListItem>Permanent</asp:ListItem>
                        <asp:ListItem>Temporary</asp:ListItem>
                        <asp:ListItem>Freelancing</asp:ListItem>
                    </asp:CheckBoxList>
                    <hr />
                </div>
            </div>
            <div class="col-md-10">
                <asp:Repeater ID="rptrJobPost" runat="server">
                    <HeaderTemplate>

                        <table style="border: 1px solid #0000FF">
                            <tr style="font-size: large; font-weight: bold; margin-bottom: 5px">
                                <td colspan="2">
                                    <b>Job Post</b>
                                </td>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <table>
                                    <tr>
                                        <td>Job Title:
                                 <asp:Label ID="lblSubject" runat="server" Text='<%#Eval("JobTitle") %>' Font-Bold="true" ForeColor="#09c" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label1" runat="server" Text="Logos Solutions Pvt Limited"></asp:Label>
                                            &nbsp; [<asp:Label ID="lblRecruitmentType" runat="server" Text='<%#Eval("RecruitmentType")%>'></asp:Label>]
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblWorkExperience" runat="server" Text='<%#Eval("WorkExperience")%>'></asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="lblComment" runat="server" Text='<%#Eval("JobLocationCity") %>' />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>Key Skills :
                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("KeywordsTechnical") %>' /><br />

                                Job Description :
                            <asp:Label ID="Label4" runat="server" Text='<%#Eval("JobDescription")%>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table style="background-color: #f9f9f9; border-top: 1px dotted; border-bottom: 1px solid; width: 500px">
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblMinSalary" runat="server" Text='<%#Eval("OfferedAnnualSalaryMin") %>' />-
                                        <asp:Label ID="lblMaxSalary" runat="server" Text='<%#Eval("OfferedAnnualSalaryMax")%>'></asp:Label>
                                        </td>
                                        <td>Posted Date:<asp:Label ID="lblDate" runat="server" Font-Bold="true" Text='<%#Eval("PostedDate","{0:dd MMM yyyy}")%>' /></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">&nbsp;</td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
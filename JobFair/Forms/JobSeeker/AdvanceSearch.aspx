<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="AdvanceSearch.aspx.cs" Inherits="JobFair.Forms.JobSeeker.AdvanceSearch" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%@ Register Assembly="DropDownCheckBoxes" Namespace="Saplin.Controls" TagPrefix="asp" %>

<asp:Content ID="JobsearchCnt" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <%--  <style type="text/css">
        .style1 {
            clear: both;
            position: relative;
            width: 100%;
            background-color: #fff;
            margin-bottom: 5px;
        }
    </style>--%>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <form class="form-horizontal">
                    <fieldset>
                        <div class="h3"><span>Advance Search</span></div>
                        <br />

                        <div class="control-group">
                            <label for="key" class="control-label">KeySkill</label>
                            <div class="controls">
                                <asp:TextBox ID="txtkeyskill" runat="server" placeholder="KeySkills"></asp:TextBox>
                                <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtkeyskill" MinimumPrefixLength="1"
                                    EnableCaching="true" CompletionSetCount="1" CompletionInterval="1000" ServiceMethod="GetKeySkills">
                                </cc1:AutoCompleteExtender>
                            </div>
                        </div>
                        <div class="control-group">
                            <label for="" class="control-label">State</label>
                            <div class="controls">
                                <%--  <asp:UpdatePanel ID="pnlState" runat="server">
                                <ContentTemplate>--%>
                                <asp:DropDownList ID="ddlState" runat="server" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" AutoPostBack="True">
                                </asp:DropDownList>
                                <%-- </ContentTemplate>
                            </asp:UpdatePanel>--%>
                            </div>
                        </div>
                        <div class="control-group">
                            <label for="" class="control-label">City</label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlCity" runat="server" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged" AutoPostBack="True">
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="control-group">
                            <label for="" class="control-label">Area</label>
                            <div class="controls">
                                <asp:DropDownCheckBoxes ID="ddlLocation" runat="server">
                                    <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                                </asp:DropDownCheckBoxes>
                            </div>
                        </div>

                        <div class="control-group">
                            <label for="" class="control-label">Work Exprience</label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlWorkExperience" runat="server">
                                    <asp:ListItem>0.5</asp:ListItem>
                                    <asp:ListItem>1.0</asp:ListItem>
                                    <asp:ListItem>1.5</asp:ListItem>
                                    <asp:ListItem>2.0</asp:ListItem>
                                    <asp:ListItem>2.5</asp:ListItem>
                                    <asp:ListItem>3.0</asp:ListItem>
                                    <asp:ListItem>3.5</asp:ListItem>
                                    <asp:ListItem>4.0</asp:ListItem>
                                    <asp:ListItem>4.5</asp:ListItem>
                                    <asp:ListItem>5.0</asp:ListItem>
                                    <asp:ListItem>5.5</asp:ListItem>
                                    <asp:ListItem>6.0</asp:ListItem>
                                    <asp:ListItem>6.5</asp:ListItem>
                                    <asp:ListItem>7.0</asp:ListItem>
                                    <asp:ListItem>7.5</asp:ListItem>
                                    <asp:ListItem>8.0</asp:ListItem>
                                    <asp:ListItem>8.5</asp:ListItem>
                                    <asp:ListItem>9.0</asp:ListItem>
                                    <asp:ListItem>9.5</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="control-group">
                            <label for="" class="control-label ">Expected Salary</label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlMinSalary" runat="server">
                                    <asp:ListItem>Min</asp:ListItem>
                                    <asp:ListItem>50,000</asp:ListItem>
                                    <asp:ListItem>1,00,000</asp:ListItem>
                                    <asp:ListItem>1,50,000</asp:ListItem>
                                    <asp:ListItem>2,00,000</asp:ListItem>
                                    <asp:ListItem>2,50,000</asp:ListItem>
                                    <asp:ListItem>3,00,000</asp:ListItem>
                                    <asp:ListItem>3,50,000</asp:ListItem>
                                    <asp:ListItem>4,00,000</asp:ListItem>
                                    <asp:ListItem>4,50,000</asp:ListItem>
                                    <asp:ListItem>5,00,000</asp:ListItem>
                                    <asp:ListItem>5,50,000</asp:ListItem>
                                    <asp:ListItem>6,00,000</asp:ListItem>
                                    <asp:ListItem>6,50,000</asp:ListItem>
                                    <asp:ListItem>7,00,000</asp:ListItem>
                                    <asp:ListItem>7,50,000</asp:ListItem>
                                    <asp:ListItem>8,00,000</asp:ListItem>
                                    <asp:ListItem>8,50,000</asp:ListItem>
                                    <asp:ListItem>9,00,000</asp:ListItem>
                                    <asp:ListItem>9,50,000</asp:ListItem>
                                    <asp:ListItem>10,00,000</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;To
                        <asp:DropDownList ID="ddlMaxSalary" runat="server">
                            <asp:ListItem>Max</asp:ListItem>
                            <asp:ListItem>&lt;50,000</asp:ListItem>
                            <asp:ListItem>1,00,000</asp:ListItem>
                            <asp:ListItem>1,50,000</asp:ListItem>
                            <asp:ListItem>2,00,000</asp:ListItem>
                            <asp:ListItem>2,50,000</asp:ListItem>
                            <asp:ListItem>3,00,000</asp:ListItem>
                            <asp:ListItem>3,50,000</asp:ListItem>
                            <asp:ListItem>4,00,000</asp:ListItem>
                            <asp:ListItem>4,50,000</asp:ListItem>
                            <asp:ListItem>5,00,000</asp:ListItem>
                            <asp:ListItem>5,50,000</asp:ListItem>
                            <asp:ListItem>6,00,000</asp:ListItem>
                            <asp:ListItem>6,50,000</asp:ListItem>
                            <asp:ListItem>7,00,000</asp:ListItem>
                            <asp:ListItem>7,50,000</asp:ListItem>
                            <asp:ListItem>8,00,000</asp:ListItem>
                            <asp:ListItem>8,50,000</asp:ListItem>
                            <asp:ListItem>9,00,000</asp:ListItem>
                            <asp:ListItem>9,50,000</asp:ListItem>
                            <asp:ListItem>10,00,000</asp:ListItem>
                        </asp:DropDownList>
                            </div>
                        </div>

                        <div class="control-group">
                            <label for="" class="control-label">Industry</label>
                            <div class="controls">
                                <asp:DropDownCheckBoxes ID="ddlIndustry" runat="server" UseSelectAllNode="false" style="top: 1px; left: 0px; width: 186px">
                                    <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                                </asp:DropDownCheckBoxes>
                            </div>
                        </div>

                        <div class="control-group">
                            <label for="" class="control-label">JobCategory</label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlJobCategory" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="control-group">
                            <label for="" class="control-label">Employement Status</label>
                            <div class="controls">
                                <asp:CheckBox ID="chkFullTime" runat="server" Text="Full Time" />
                                <asp:CheckBox ID="chkPartTime" runat="server" Text="Part Time" />
                            </div>
                        </div>

                        <div class="control-group">
                            <label for="" class="control-label ">Job Type</label>
                            <div class="controls">
                                <asp:CheckBox ID="chkPermanant" runat="server" Text="Permanant" />
                                <asp:CheckBox ID="chkTemporary" runat="server" Text="Temporary" />
                                <asp:CheckBox ID="chkFreelancing" runat="server" Text="Freelancing" />
                            </div>
                        </div>

                        <div class="control-group">
                            <label for="" class="control-label ">Recruitment Type</label>
                            <div class="controls">
                                <asp:CheckBox ID="chkInhouse" runat="server" Text="Inhouse" />
                                <asp:CheckBox ID="chkClient" runat="server" Text="Client" />
                            </div>
                        </div>

                        <div class="control-group">
                            <label for="" class="control-label">Job Freshness</label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlJobFreshness" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="control-group">
                            <div class="col-xs-offset-2 col-xs-10">
                                <asp:Button ID="btnsearch" runat="server" Text="Search" class="btn btn-primary" OnClick="btnsearch_Click" Width="97px" />
                                <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
                            </div>
                        </div>
                    </fieldset>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
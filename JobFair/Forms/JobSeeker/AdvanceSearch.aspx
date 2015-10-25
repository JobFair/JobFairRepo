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
      <%--  <div class="row">--%>
           <%-- <div class="col-md-12">--%>
         <div class="h3"><span>Advance Search</span></div>
                <form class="form-horizontal">
                
                    
         
                        <div class="form-group">
                            <label for="KeySkill" class="control-label col-md-6">KeySkill</label>
                            <div class="controls col-xs-3"> 
                                <asp:TextBox ID="txtkeyskill" runat="server" placeholder="KeySkills" CssClass="form-control"></asp:TextBox>
                                <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtkeyskill" MinimumPrefixLength="1"
                                    EnableCaching="true" CompletionSetCount="1" CompletionInterval="1000" ServiceMethod="GetKeySkills">
                                </cc1:AutoCompleteExtender>
                            </div>
                        </div><br />
                        <div class="form-group">
                            <label for="" class="control-label col-md-6">State</label>
                            <div class="controls col-xs-3">
                                 <%-- <asp:UpdatePanel ID="pnlState" runat="server">
                                <ContentTemplate>--%>
                                <asp:DropDownList ID="ddlState" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" AutoPostBack="True">
                                </asp:DropDownList>
                                <%-- </ContentTemplate>
                            </asp:UpdatePanel>--%>
                            </div>
                        </div><br />
                        <div class="form-group">
                            <label for="" class="control-label col-md-6">City</label>
                            <div class="controls col-xs-3">
                                <asp:DropDownList ID="ddlCity" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged" AutoPostBack="True">
                                </asp:DropDownList>
                            </div>
                        </div><br />

                        <div class="form-group">
                            <label for="" class="control-label col-md-6">Area</label>
                            <div class="controls col-xs-3">
                                <asp:DropDownCheckBoxes ID="ddlLocation" runat="server" CssClass="form-control">
                                  
                                </asp:DropDownCheckBoxes>
                            </div>
                        </div><br />

                        <div class="form-group">
                            <label for="" class="control-label col-md-6">Work Exprience</label>
                            <div class="controls col-xs-3">
                                <asp:DropDownList ID="ddlWorkExperience" runat="server" CssClass="form-control">
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
                        </div><br />

                        <div class="form-group">
                            <label for="" class="control-label col-md-6 ">Expected Salary</label>
                            <div class="controls col-xs-2">
                                <asp:DropDownList ID="ddlMinSalary" runat="server" CssClass="form-control">
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
                                </asp:DropDownList></div>
&nbsp;<div class="controls col-xs-2">
                        <asp:DropDownList ID="ddlMaxSalary" runat="server" CssClass="form-control">
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
                        </div><br />

                        <div class="form-group">
                            <label for="" class="control-label col-md-6">Industry</label>
                            <div class="controls col-xs-3">
                                <asp:DropDownCheckBoxes ID="ddlIndustry" runat="server" CssClass="form-control" UseSelectAllNode="false" style="top: 1px; left: 0px; width: 186px">
                                  <%--  <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />--%>
                                </asp:DropDownCheckBoxes>
                            </div>
                        </div><br />

                        <div class="form-group">
                            <label for="" class="control-label col-md-6">JobCategory</label>
                            <div class="controls col-xs-3">
                                <asp:DropDownList ID="ddlJobCategory" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                            </div>
                        </div><br />

                        <div class="form-group">
                            <label for="" class="control-label col-md-6 checkbox-inline">Employement Status</label>
                            <div class="controls col-xs-3">
                                <asp:CheckBox ID="chkFullTime" runat="server" Text="Full Time"/>
                                <asp:CheckBox ID="chkPartTime" runat="server" Text="Part Time"/>
                            </div>
                        </div>
                    <br />
                        <div class="form-group">
                            <label for="" class="control-label col-md-6 checkbox-inline">Job Type</label>
                            <div class="controls col-xs-3">
                                <asp:CheckBox ID="chkPermanant" runat="server" Text="Permanant" />
                                <asp:CheckBox ID="chkTemporary" runat="server" Text="Temporary"/>
                                <asp:CheckBox ID="chkFreelancing" runat="server" Text="Freelancing"/>
                            </div>
                        </div>
                    <br />
                        <div class="form-group">
                            <label for="" class="control-label col-md-6 checkbox-inline">Recruitment Type</label>
                            <div class="controls col-xs-3">
                                <asp:CheckBox ID="chkInhouse" runat="server" Text="Inhouse"/>
                                <asp:CheckBox ID="chkClient" runat="server" Text="Client"/>
                            </div>
                        </div>
                    <br />
                        <div class="form-group">
                            <label for="" class="control-label col-md-6">Job Freshness</label>
                            <div class="controls col-xs-3">
                                <asp:DropDownList ID="ddlJobFreshness" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                            </div>
                        </div>
                    <br /><br>
                        <div class="form-group">
                            <div class="col-xs-offset-2 col-xs-10">
                                <asp:Button ID="btnsearch" runat="server" Text="Search" class="btn btn-primary form-control" OnClick="btnsearch_Click" Width="97px" />
                                <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
                            </div>
                        </div>
                    
                </form>
           <%-- </div>--%>
      <%--  </div>--%>
    </div>
</asp:Content>
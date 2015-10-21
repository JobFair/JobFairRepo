<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="jobSearch.aspx.cs" Inherits="JobFair.Forms.JobSeeker.jobSearch" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="JobsearchCnt" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <!DOCTYPE html>
    <script runat="server">
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
    </script>
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
   
    <div style="width: 100%;">
        <div style="width: 40%; float: left">
            <table>
                <tr>
                    <td class="auto-style1">
                        <fieldset>
                            <legend>Div 1</legend>
                            <div class="left">

                                <div>
                                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                                    <asp:LinkButton ID="lblFreshness" runat="server" Text="By Freshness"></asp:LinkButton>

                                    <asp:Panel ID="PanelFreshness" runat="server">
                                        <asp:CheckBoxList ID="chkFreshness" runat="server" AutoPostBack="True" OnSelectedIndexChanged="chkFreshness_SelectedIndexChanged">
                                            <asp:ListItem>30 Days</asp:ListItem>
                                            <asp:ListItem>25 Days</asp:ListItem>
                                            <asp:ListItem>20 Days</asp:ListItem>
                                            <asp:ListItem>15 Days</asp:ListItem>
                                            <asp:ListItem>10 Days</asp:ListItem>
                                            <asp:ListItem>7 Days</asp:ListItem>
                                            <asp:ListItem>1 Day</asp:ListItem>
                                        </asp:CheckBoxList>
                                        <br />
                                    </asp:Panel>
                                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                                    <cc1:CollapsiblePanelExtender ID="CPEfreshness" runat="server" TargetControlID="PanelFreshness" TextLabelID="lblFreshness" CollapseControlID="lblFreshness" ExpandControlID="lblFreshness" Collapsed="true" />
                                </div>

                                <br />
                                <div>
                                    <asp:LinkButton ID="lblLocation" runat="server" Text="By Location"></asp:LinkButton>

                                    <asp:Panel ID="PanelLoaction" runat="server">
                                        <asp:CheckBoxList ID="chkLocation" runat="server" OnSelectedIndexChanged="chkLocation_SelectedIndexChanged"></asp:CheckBoxList>
                                        <br />
                                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                                    </asp:Panel>
                                    <cc1:CollapsiblePanelExtender ID="CPELocation" runat="server" TargetControlID="PanelLoaction" TextLabelID="lblLocation" CollapseControlID="lblFreshness" ExpandControlID="lblLocation" Collapsed="true" />
                                </div>
                                <br />
                                <div>
                                    <asp:LinkButton ID="lblRole" runat="server" Text="Role" CssClass="label"></asp:LinkButton>

                                    <asp:Panel ID="PanelRole" runat="server">
                                        <asp:CheckBoxList ID="chkRole" runat="server" OnSelectedIndexChanged="chkRole_SelectedIndexChanged"></asp:CheckBoxList>
                                        <br />
                                        <br />
                                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                                    </asp:Panel>
                                    <cc1:CollapsiblePanelExtender ID="CPERole" runat="server" TargetControlID="PanelRole" TextLabelID="lblRole" CollapseControlID="lblRole" ExpandControlID="lblRole" Collapsed="true" />
                                </div>
                                <br />
                                <div>
                                    <asp:LinkButton ID="lblFunctionalArea" runat="server" Text="Functional Area "></asp:LinkButton>

                                    <asp:Panel ID="PanelFunctArea" runat="server">
                                        <asp:CheckBoxList ID="chkFunctArea" runat="server"></asp:CheckBoxList>
                                    </asp:Panel>
                                    <cc1:CollapsiblePanelExtender ID="CPEFunctArea" runat="server" TargetControlID="PanelFunctArea" TextLabelID="lblFunctionalArea" CollapseControlID="lblFunctionalArea" ExpandControlID="lblFunctionalArea" Collapsed="true" />
                                </div>
                                <br />
                                <div>
                                    <asp:LinkButton ID="lblCompanyLevel" runat="server" Text="Company Level "></asp:LinkButton>

                                    <asp:Panel ID="PanelCompanyLevel" runat="server">
                                        <asp:CheckBoxList ID="chkCompanyLevel" runat="server">
                                            <asp:ListItem>Start Up Company</asp:ListItem>
                                            <asp:ListItem>Small Scale Company</asp:ListItem>
                                            <asp:ListItem>Mid Level Company</asp:ListItem>
                                            <asp:ListItem>MNC</asp:ListItem>
                                        </asp:CheckBoxList>
                                    </asp:Panel>
                                    <cc1:CollapsiblePanelExtender ID="CPECompnyLevel" runat="server" TargetControlID="PanelCompanyLevel" TextLabelID="lblCompanyLevel" CollapseControlID="lblCompanyLevel" ExpandControlID="lblCompanyLevel" Collapsed="true" />
                                </div>
                                <br />
                                <div>
                                    <asp:LinkButton ID="lblIndustry" runat="server" Text="Industry "></asp:LinkButton>

                                    <asp:Panel ID="PanelIndustry" runat="server">
                                        <asp:CheckBoxList ID="chkIndustry" runat="server"></asp:CheckBoxList>
                                    </asp:Panel>
                                    <cc1:CollapsiblePanelExtender ID="CPEIndustry" runat="server" TargetControlID="PanelIndustry" TextLabelID="lblIndustry" CollapseControlID="lblIndustry" ExpandControlID="lblIndustry" Collapsed="true" />
                                </div>
                                <br />
                                <div>
                                    <asp:LinkButton ID="lblSalary" runat="server" Text="By Salary "></asp:LinkButton>

                                    <asp:Panel ID="PanelSalary" runat="server">
                                        <asp:CheckBoxList ID="chkSalary" runat="server">
                                            <asp:ListItem>0-3 Lakhs</asp:ListItem>
                                            <asp:ListItem>3-6 Lakhs</asp:ListItem>
                                            <asp:ListItem>6-10 Lakhs</asp:ListItem>
                                            <asp:ListItem>10-15 Lakhs</asp:ListItem>
                                            <asp:ListItem>15- 20 Lakhs</asp:ListItem>
                                            <asp:ListItem>20-25 Lakhs</asp:ListItem>
                                            <asp:ListItem>more</asp:ListItem>
                                        </asp:CheckBoxList>
                                    </asp:Panel>
                                    <cc1:CollapsiblePanelExtender ID="CPESalary" runat="server" TargetControlID="PanelSalary" TextLabelID="lblSalary" CollapseControlID="lblSalary" ExpandControlID="lblSalary" Collapsed="true" />
                                </div>

                                <br />
                                <div>
                                    <asp:LinkButton ID="lblEducation" runat="server" Text="By Education "></asp:LinkButton>

                                    <asp:Panel ID="PanelEducation" runat="server">
                                        <asp:CheckBoxList ID="chkEducation" runat="server"></asp:CheckBoxList>
                                    </asp:Panel>
                                    <cc1:CollapsiblePanelExtender ID="CPEEducation" runat="server" TargetControlID="PanelEducation" TextLabelID="lblEducation" CollapseControlID="lblEducation" ExpandControlID="lblEducation" Collapsed="true" />
                                </div>

                                <div>
                                    <asp:LinkButton ID="lblStatus" runat="server" Text="By Employment Status"></asp:LinkButton>

                                    <asp:Panel ID="PanelStatus" runat="server">
                                        <asp:CheckBoxList ID="chkStatus" runat="server">
                                            <asp:ListItem>Full Time</asp:ListItem>
                                            <asp:ListItem>Part Time</asp:ListItem>
                                        </asp:CheckBoxList>
                                    </asp:Panel>
                                    <cc1:CollapsiblePanelExtender ID="CPEStatus" runat="server" TargetControlID="PanelStatus" TextLabelID="lblStatus" CollapseControlID="lblStatus" ExpandControlID="lblStatus" Collapsed="true" />
                                </div>
                                <br />
                                <div>
                                    <asp:LinkButton ID="lblJobType" runat="server" Text="Job Type "></asp:LinkButton>

                                    <asp:Panel ID="PanelJobType" runat="server" Height="118px" Width="264px">
                                        <asp:CheckBoxList ID="chkJobType" runat="server">
                                            <asp:ListItem>Permanent</asp:ListItem>
                                            <asp:ListItem>Temporary</asp:ListItem>
                                            <asp:ListItem>Freelancing</asp:ListItem>
                                        </asp:CheckBoxList>
                                        <br />
                                        <br />
                                    </asp:Panel>
                                    <cc1:CollapsiblePanelExtender ID="CPEJobType" runat="server" TargetControlID="PanelJobType" TextLabelID="lblJobType" CollapseControlID="lblJobType" ExpandControlID="lblJobType" Collapsed="true" />
                                </div>
                            </div>
                        </fieldset>
                    </td>
            </table>
        </div>
        <div style="width: 50%; float: right; margin-right: 100px">
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
                                    <td> 
                                        Posted Date:<asp:Label ID="lblDate" runat="server" Font-Bold="true" Text='<%#Eval("PostedDate","{0:dd MMM yyyy}")%>'/></td>
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
</asp:Content>
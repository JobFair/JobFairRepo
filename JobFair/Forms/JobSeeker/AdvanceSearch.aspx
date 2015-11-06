<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="AdvanceSearch.aspx.cs" Inherits="JobFair.Forms.JobSeeker.AdvanceSearch" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%@ Register Assembly="DropDownCheckBoxes" Namespace="Saplin.Controls" TagPrefix="asp" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1 {
            clear: both;
            position: relative;
            width: 100%;
            background-color: #fff;
            margin-bottom: 5px;
               }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lbladvancesearch" runat="server" Text="AdvanceSearch"></asp:Label>

            &nbsp;
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
            <br />
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblkeyskill" runat="server" Text="KeySkill"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtkeyskill" runat="server"></asp:TextBox>
                        <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtkeyskill" MinimumPrefixLength="1"
                            EnableCaching="true" CompletionSetCount="1" CompletionInterval="1000" ServiceMethod="GetKeySkills">
                        </cc1:AutoCompleteExtender>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                    </td>
                    <td rowspan="3">
                        <asp:UpdatePanel ID="pnlState" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList ID="ddlState" runat="server" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" AutoPostBack="True">
                                </asp:DropDownList>
                                <br />
                                <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged">
                                </asp:DropDownList>
                                <br />
                                <br />
                              <div>
                                  <asp:Button  runat="server" ID="btnarea" Text="go" OnClick="btnarea_Click" Height="23px" Width="106px" />
                                  &nbsp;&nbsp;
                                  <asp:Panel ID="Panelarea" runat="server" Visible="false">
                                      <asp:TextBox runat="server" ID="txtarea" ReadOnly="true" Height="23px" Width="436px" />
                                    <asp:CheckBoxList ID="chkarea" runat="server" AutoPostBack="true" width="100px" Height="50px" OnSelectedIndexChanged="chkarea_SelectedIndexChanged"></asp:CheckBoxList>
                                      &nbsp;
                                </asp:Panel>
                                  <cc1:CollapsiblePanelExtender ID="CPELocation" runat="server" TargetControlID="Panelarea" TextLabelID="btnarea" CollapseControlID="btnarea" ExpandControlID="btnarea" Collapsed="true" ScrollContents="true" ExpandedText="Hide" />
                              </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblArea" runat="server" Text="Area"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblworkexprience" runat="server" Text="Work Exprience"></asp:Label>
                    </td>
                    <td>&nbsp;<asp:DropDownList ID="ddlWorkExperience" runat="server">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>0.5</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>1.5</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>2.5</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>3.5</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>4.5</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>5.5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>6.5</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>7.5</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>8.5</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>9.5</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                    </asp:DropDownList>
                        &nbsp;&nbsp;

                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbsalary" runat="server" Text="Expected Salary"></asp:Label>
                    </td>
                    <td>
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
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblindustry" runat="server" Text="Industry"></asp:Label>
                    </td>
                    <td>
                        <div>
                            <asp:Button  ID="btnselect" runat="server" Text="Select"/>
                            <asp:Panel ID="panellindustry" runat="server">
                            <asp:TextBox ID="txtindusry" runat="server"></asp:TextBox>
                                <asp:CheckBoxList ID="CheckBoxList1" runat="server"></asp:CheckBoxList>
                            </asp:Panel>




                            <cc1:CollapsiblePanelExtender ID="CollapsiblePanelExtender1" runat="server" TargetControlID="panellindustry" TextLabelID="btnselect" CollapseControlID="btnselect" ExpandControlID="btnselect" Collapsed="true" ScrollContents="true" ExpandedText="Hide" />
                        </div>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbljobcategory" runat="server" Text="JobCategory"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlJobCategory" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEmploymentStatus" runat="server" Text="Employement Status"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkFullTime" runat="server" Text="Full Time" />
                        <asp:CheckBox ID="chkPartTime" runat="server" Text="Part Time" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblJobType" runat="server" Text="Job Type"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkPermanant" runat="server" Text="Permanant" />
                        <asp:CheckBox ID="chkTemporary" runat="server" Text="Temporary" />
                        <asp:CheckBox ID="chkFreelancing" runat="server" Text="Freelancing" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblRecruitmentType" runat="server" Text="Recruitment Type"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkInhouse" runat="server" Text="Inhouse" />
                        <asp:CheckBox ID="chkClient" runat="server" Text="Client" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblSortBy" runat="server" Text="Job Freshness"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlJobFreshness" runat="server">
                            <asp:ListItem>1 month</asp:ListItem>
                            <asp:ListItem>2 months</asp:ListItem>
                            <asp:ListItem>3 months</asp:ListItem>
                            <asp:ListItem>4 months</asp:ListItem>
                            <asp:ListItem>5 months</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" Width="97px" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
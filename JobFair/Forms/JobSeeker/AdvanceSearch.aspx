<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="AdvanceSearch.aspx.cs" Inherits="JobFair.Forms.JobSeeker.AdvanceSearch" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %> 

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
                    <td class="auto-style1">
                        <asp:Label ID="lblkeyskill" runat="server" Text="KeySkill"></asp:Label>
                    </td>
                    <td>
                        <%--<asp:TextBox ID="txtkeyskill" runat="server"></asp:TextBox>--%>
                        <asp:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtskill" MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="1000" ServiceMethod="GetSkills"></asp:AutoCompleteExtender>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                    </td>
                    <td rowspan="3">
                          <asp:UpdatePanel ID="pnlState" runat="server">
                <ContentTemplate>
                        <asp:DropDownList ID="ddlState" runat="server" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList>
                     <br />
                        <asp:DropDownList ID="ddlCity" runat="server" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList>  
                <br />
                        <asp:DropDownCheckBoxes ID="ddlLocation" runat="server">
                             <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                        </asp:DropDownCheckBoxes>
                    </ContentTemplate>
            </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblArea" runat="server" Text="Area"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblworkexprience" runat="server" Text="Work Exprience"></asp:Label>
                    </td>
                    <td>
                        &nbsp;<asp:DropDownList ID="ddlWorkExperience" runat="server">
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
                        &nbsp;&nbsp;

                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lbsalary" runat="server" Text="Expected Salary"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlMinSalary" runat="server">
                            <asp:ListItem>Min</asp:ListItem>
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
                    <td >
                        <asp:Label ID="lblindustry" runat="server" Text="Industry"></asp:Label>
                    </td>
                    <td>

                        <asp:DropDownCheckBoxes ID="ddlIndustry" runat="server" UseSelectAllNode="false" style="top: 1px; left: 0px; width: 186px">
                            <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                        </asp:DropDownCheckBoxes>
                    </td>
                </tr>
                <tr>
                    <td >
                        <asp:Label ID="lbljobcategory" runat="server" Text="JobCategory"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlJobCategory" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Employement Status"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkFullTime" runat="server" Text="Full Time" />
                        <asp:CheckBox ID="chkPartTime" runat="server" Text="Part Time" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Job Type"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkPermanant" runat="server" Text="Permanant" />
                        <asp:CheckBox ID="chkTemporary" runat="server" Text="Temporary" />
                        <asp:CheckBox ID="chkFreelancing" runat="server" Text="Freelancing" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblJobType" runat="server" Text="Recruitment Type"></asp:Label>
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
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" Width="97px" />
                    </td>
                </tr>
            </table>
         
        </div>
    </form>
</body>
</html>
<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="AdvanceSearch.aspx.cs" Inherits="JobFair.Forms.JobSeeker.AdvanceSearch" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="DropDownCheckBoxes" Namespace="Saplin.Controls" TagPrefix="asp" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 176px;
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
                        <asp:TextBox ID="txtkeyskill" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlCity" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblArea" runat="server" Text="Area"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownCheckBoxes ID="ddlLocation" runat="server">
                             <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                        </asp:DropDownCheckBoxes></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblworkexprience" runat="server" Text="Work Exprience"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFromdate" runat="server" placeholder="From Year"></asp:TextBox>
                        <cc1:CalendarExtender ID="txtFromdate_CalendarExtender" runat="server" BehaviorID="txtFromdate_CalendarExtender" TargetControlID="txtFromdate"></cc1:CalendarExtender>

                        &nbsp;&nbsp;&nbsp; To
                        <asp:TextBox ID="txtTill" runat="server" placeholder="To Year"></asp:TextBox>
                        <cc1:CalendarExtender ID="txtTill_CalendarExtender" runat="server" BehaviorID="txtTill_CalendarExtender" TargetControlID="txtTill"></cc1:CalendarExtender>

                        &nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lbsalary" runat="server" Text="Expected Salary"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlMinSalary" runat="server">
                            <asp:ListItem>Min</asp:ListItem>
                            <asp:ListItem>&lt;0.5</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                            <asp:ListItem>13</asp:ListItem>
                            <asp:ListItem>14</asp:ListItem>
                            <asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>16</asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                            <asp:ListItem>19</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddlMaxSalary" runat="server">
                            <asp:ListItem>Max</asp:ListItem>
                            <asp:ListItem>&lt;0.5</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                            <asp:ListItem>13</asp:ListItem>
                            <asp:ListItem>14</asp:ListItem>
                            <asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>16</asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                            <asp:ListItem>19</asp:ListItem>
                            <asp:ListItem>&gt;20</asp:ListItem>
                        </asp:DropDownList>
                        in Lakhs</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblindustry" runat="server" Text="Industry"></asp:Label>
                    </td>
                    <td>

                        <asp:DropDownCheckBoxes ID="ddlIndustry" runat="server" UseSelectAllNode="false" style="top: 0px; left: 44px; width: 186px">
                            <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                        </asp:DropDownCheckBoxes>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lbljobcategory" runat="server" Text="JobCategory"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlJobCategory" runat="server">
                            
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <span style="font-size: 11.0pt; line-height: 115%; font-family: &quot;Calibri&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: Calibri; mso-bidi-font-family: &quot;Times New Roman&quot;; background: silver; mso-highlight: silver; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">&nbsp;</span><asp:Label ID="Label2" runat="server" Text="Employement Status"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkFullTime" runat="server" Text="Full Time" />
                        <asp:CheckBox ID="chkPartTime" runat="server" Text="Part Time" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Job Type"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkPermanant" runat="server" Text="Permanant" />
                        <asp:CheckBox ID="chkTemporary" runat="server" Text="Temporary" />
                        <asp:CheckBox ID="chkFreelancing" runat="server" Text="Freelancing" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblJobType" runat="server" Text="Recruitment Type"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkInhouse" runat="server" Text="Inhouse" />
                        <asp:CheckBox ID="chkClient" runat="server" Text="Client" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblSortBy" runat="server" Text="Job Freshness"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlJobFreshness" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" Width="97px" />
                    </td>
                </tr>
            </table>
            <asp:GridView ID="GridView1" runat="server" Visible="false"></asp:GridView>
        </div>
    </form>
</body>
</html>
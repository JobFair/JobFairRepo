<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResumeFormating.aspx.cs" Inherits="JobFair.Forms.JobSeeker.ResumeFormating" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblUserType" runat="server" Text="You are"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButton ID="rbtIntern" runat="server" GroupName="Type" Text="Intern" ValidationGroup="Type" />
                        <asp:RadioButton ID="rbtFreshar" runat="server" GroupName="Type" Text="Freshar" />
                        <asp:RadioButton ID="rbtExperience" runat="server" GroupName="Type" Text="Experience" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblObjective" runat="server" Text="Objective"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtObjective" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblSummary" runat="server" Text="Profile Summary"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSummary" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblKeyArea" runat="server" Text="Key Result Area"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtKeyArea" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <div>
                <table>
                    <tr>
                        <td>Project Details for </td>
                        <td>
                            <asp:RadioButtonList ID="rbtProjectTypeList" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>Academic</asp:ListItem>
                                <asp:ListItem>Intern</asp:ListItem>
                                <asp:ListItem>Professional</asp:ListItem>
                                <asp:ListItem>FreeLancing</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblProjectTitle" runat="server" Text="Project Title"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtProjectTitle" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblCompanyName" runat="server" Text="Company Name"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCompanyName" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblRole" runat="server" Text="Your Role"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlRole" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblClientName" runat="server" Text="Client Name"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtClientName" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                   
                    <tr>
                        <td>
                            <asp:Label ID="lblDuration" runat="server" Text="Duration"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFromDate" runat="server"></asp:TextBox><cc1:CalendarExtender ID="CalendarExtender1" runat="server" PopupButtonID="txtFromDate" TargetControlID="txtFromDate" Format="dd/MM/yyyy" />
                            To<asp:TextBox ID="txtTodate" runat="server"></asp:TextBox><cc1:CalendarExtender ID="CalendarExtender2" runat="server" PopupButtonID="txtTodate" TargetControlID="txtTodate" Format="dd/MM/yyyy" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblLocation" runat="server" Text="Project Location"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblEmploymentType" runat="server" Text="Employment Type"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButton ID="rbtFullTime" runat="server" GroupName="Employee" Text="Full Time" />
                            <asp:RadioButton ID="rbtPartTime" runat="server" GroupName="Employee" Text="Part Time" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblProjectDetails" runat="server" Text="Project Details"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtProjectDetails" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblResponsibility" runat="server" Text="Roles And Responsibility"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtRolesAndResponsibility" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblTeamSize" runat="server" Text="Team Size"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTeamSize" runat="server">
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
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblSkillUsed" runat="server" Text="Skill Used"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtSkillUsed" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td >
                            Project Live</td><td><asp:RadioButton ID="rbtYes" runat="server" GroupName="Live" Text="Yes" />
            <asp:RadioButton ID="rbtNo" runat="server" GroupName="Live" Text="No" /></td>
                    </tr>
                     <tr>
                        <td>
                            <asp:Label ID="lblLinkUrl" runat="server" Text="Project Link/URL"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtLink" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                     <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Degree"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr><td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="#">Add More Projects</asp:HyperLink></td></tr>
                    <%-- <tr>
                        <td colspan="2">
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                        </td>
                    </tr>--%>
                </table>
            </div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblAwards" runat="server" Text="Awards And Recognition"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAwards" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblExtraActivities" runat="server" Text="Extra curricular/Social Activities"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtExtraActivities" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblHobbies" runat="server" Text="Hobbies"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtHobbies" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
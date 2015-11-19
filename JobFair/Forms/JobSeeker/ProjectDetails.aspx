<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProjectDetails.aspx.cs" Inherits="JobFair.Forms.JobSeeker.ProjectDetails" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       
<script  type="text/javascript" src="../../Scripts/ValidationAll.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table>
                <tr>
                    <td>Project Details for </td>

                    <td>

                        <asp:RadioButtonList ID="rbtProjectTypeList" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" OnSelectedIndexChanged="rbtProjectTypeList_SelectedIndexChanged">
                            <asp:ListItem Value="1">Academic</asp:ListItem>
                            <asp:ListItem Value="2">Intern</asp:ListItem>
                            <asp:ListItem Value="3">Professional</asp:ListItem>
                            <asp:ListItem Value="4">FreeLancing</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblProjectTitle" runat="server" Text="Project Title"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtProjectTitle" runat="server" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCompanyName" runat="server" Text="Company Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCompanyName" runat="server" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
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
                        <asp:TextBox ID="txtClientName" runat="server" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblDuration" runat="server" Text="Duration"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFromDate" runat="server"></asp:TextBox><cc1:CalendarExtender ID="CalendarExtender1" runat="server" PopupButtonID="txtFromDate" TargetControlID="txtFromDate" Format="dd/MM/yyyy" />

                        To<asp:TextBox ID="txtTodate" runat="server"></asp:TextBox><cc1:CalendarExtender ID="CalendarExtender2" runat="server" PopupButtonID="txtTodate" TargetControlID="txtTodate" Format="dd/MM/yyyy" />
                         <%--onblur="return CheckValidDate(this.id);"--%>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblLocation" runat="server" Text="Project Location"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLocation" runat="server" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
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
                        <asp:TextBox ID="txtProjectDetails" runat="server" TextMode="MultiLine" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblResponsibility" runat="server" Text="Roles And Responsibility"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtRolesAndResponsibility" runat="server" TextMode="MultiLine" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblTeamSize" runat="server" Text="Team Size"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlTeamSize" runat="server">
                            <asp:ListItem>Select</asp:ListItem>
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
                        <asp:TextBox ID="txtSkillUsed" runat="server" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Project Live</td>
                    <td>
                        <asp:RadioButton ID="rbtYes" runat="server" GroupName="Live" Text="Yes" AutoPostBack="True" />
                        <asp:RadioButton ID="rbtNo" runat="server" GroupName="Live" Text="No" AutoPostBack="True" /></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblLinkUrl" runat="server" Text="Project Link/URL" Visible="false"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLink" runat="server" Visible="false"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblAcademicLevel" runat="server" Text="Academic Level" Visible="false"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlAcademicLevel" runat="server" Visible="false">
                            <asp:ListItem Value="0">Select</asp:ListItem>
                            <asp:ListItem Value="1">PG Project</asp:ListItem>
                            <asp:ListItem Value="2">UG Project</asp:ListItem>
                            <asp:ListItem Value="3">PG Diploma</asp:ListItem>
                            <asp:ListItem Value="4">Diploma</asp:ListItem>
                            <asp:ListItem Value="5">Certification</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <%--<tr><td>
                       <%-- <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="#">Add More Projects</asp:HyperLink></td></tr>
                     <tr>--%>
                    <td colspan="2">
                        <asp:Button ID="btnSubmit" runat="server" Text="Add Project" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
            </table>
        </div>

        <div style="margin-top: 20px; margin-left: 10px;">
            <asp:HiddenField ID="hfCandidateId" runat="server" />
            <asp:GridView ID="grdProjectDetails" AutoGenerateColumns="false" runat="server" ForeColor="#333333"
                GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField Visible="false" HeaderText="CandidateId" DataField="CandidateId" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Project For" DataField="ProjectFor" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Project Title" DataField="ProjectTitle" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Company Name" DataField="CompanyName" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Role" DataField="Role" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Client Name" DataField="ClientName" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Duration" DataField="Duration" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Project Location" DataField="ProjectLocation" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Employment Type" DataField="EmploymentType" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Project Details" DataField="ProjectDetails" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Roles and Responsibility" DataField="RolesandResponsibility" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Team Size" DataField="TeamSize" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Skill Used" DataField="SkillUsed" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Project Live" DataField="ProjectLive" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Project Link/URL" DataField="ProjectLink" />
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Degree" DataField="Degree" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
        <div style="margin-top: 10px; margin-left: 350px">
            <asp:Button ID="btnsubmitProject" runat="server" Style="color: White"
                Text="Save Project" BackColor="#999966" OnClick="btnsubmitProject_Click" />
        </div>
    </form>
</body>
</html>
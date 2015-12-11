<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProjectDetails.aspx.cs" Inherits="JobFair.Forms.JobSeeker.ProjectDetails" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script src="../../Scripts/ValidationAll.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="pnlInsert" runat="server" Visible="false">
            <div>
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <table>
                    <tr>
                        <td>Project Details for </td>

                        <td>
                            <asp:RadioButtonList ID="rbtProjectTypeList" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" OnSelectedIndexChanged="rbtProjectTypeList_SelectedIndexChanged" OnClientClick="return IsSelectedDDL(this.id,'Radio Button')">
                                <asp:ListItem Value="1">Academic</asp:ListItem>
                                <asp:ListItem Value="2">Intern</asp:ListItem>
                                <asp:ListItem Value="3">Professional</asp:ListItem>
                                <asp:ListItem Value="4">FreeLancing</asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:RequiredFieldValidator ID="rfvProjectTypeList" runat="server" ErrorMessage="*" ForeColor="Red" ValidationGroup="vgProjectDetails" ControlToValidate="rbtProjectTypeList"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblProjectTitle" runat="server" Text="Project Title"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtProjectTitle" runat="server" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvProjectTitle" runat="server" ErrorMessage="*" ForeColor="Red" ValidationGroup="vgProjectDetails" ControlToValidate="txtProjectTitle"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblCompanyName" runat="server" Text="Company Name"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCompanyName" runat="server" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvCompanyName" runat="server" ErrorMessage="*" ValidationGroup="vgProjectDetails" ForeColor="Red" ControlToValidate="txtCompanyName"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblRole" runat="server" Text="Your Role"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlRole" runat="server" OnBlur="return IsSelectedDDL(this.id,'Radio Button')">
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="rfvRole" runat="server" ErrorMessage="*" ForeColor="Red" ValidationGroup="vgProjectDetails" ControlToValidate="ddlRole"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblClientName" runat="server" Text="Client Name"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtClientName" runat="server" onblur="return CheckOnlyChar(this.id);"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="lblDuration" runat="server" Text="Duration"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFromDate" runat="server"></asp:TextBox><cc1:CalendarExtender ID="CalendarExtender1" runat="server" PopupButtonID="txtFromDate" TargetControlID="txtFromDate" Format="dd/MM/yyyy" />
                            <asp:RequiredFieldValidator ID="rfvFromDate" runat="server" ErrorMessage="*" ForeColor="Red" ValidationGroup="vgProjectDetails" ControlToValidate="txtFromDate"></asp:RequiredFieldValidator>

                            To<asp:TextBox ID="txtTodate" runat="server"></asp:TextBox><cc1:CalendarExtender ID="CalendarExtender2" runat="server" PopupButtonID="txtTodate" TargetControlID="txtTodate" Format="dd/MM/yyyy" />
                            <asp:RequiredFieldValidator ID="rfvTodate" runat="server" ErrorMessage="*" ForeColor="Red" ValidationGroup="vgProjectDetails" ControlToValidate="txtTodate"></asp:RequiredFieldValidator>
                            <%--onblur="return CheckValidDate(this.id);"--%>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblLocation" runat="server" Text="Project Location"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtLocation" runat="server" onblur="return CheckOnlyChar(this.id);"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvLocation" runat="server" ErrorMessage="*" ValidationGroup="vgProjectDetails" ForeColor="Red" ControlToValidate="txtLocation"></asp:RequiredFieldValidator>
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
                            <asp:RequiredFieldValidator ID="rfvProjectDetails" runat="server" ErrorMessage="*" ValidationGroup="vgProjectDetails" ForeColor="Red" ControlToValidate="txtProjectDetails"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblResponsibility" runat="server" Text="Roles And Responsibility"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtRolesAndResponsibility" runat="server" TextMode="MultiLine" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvRolesAndResponsibility" runat="server" ErrorMessage="*" ValidationGroup="vgProjectDetails" ForeColor="Red" ControlToValidate="txtRolesAndResponsibility"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblTeamSize" runat="server" Text="Team Size"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTeamSize" runat="server" onchange="IsSelectedDDL(ddlTeamSize.id);">
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
                            <asp:RequiredFieldValidator ID="rfvTeamSize" runat="server" ErrorMessage="*" ForeColor="Red" ValidationGroup="vgProjectDetails" ControlToValidate="ddlTeamSize"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblSkillUsed" runat="server" Text="Skill Used"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtSkillUsed" runat="server" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvSkillUsed" runat="server" ErrorMessage="*" ValidationGroup="vgProjectDetails" ForeColor="Red" ControlToValidate="txtSkillUsed"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Project Live</td>
                        <td>
                            <asp:RadioButton ID="rbtYes" runat="server" GroupName="Live" Text="Yes" AutoPostBack="True" />
                            <asp:RadioButton ID="rbtNo" runat="server" GroupName="Live" Text="No" AutoPostBack="True" /></td>
                    </tr>
                    <asp:Panel ID="panelProjectLink" runat="server" Visible="false">
                        <tr>
                            <td>
                                <asp:Label ID="lblLinkUrl" runat="server" Text="Project Link/URL"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtLink" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvLink" runat="server" ErrorMessage="*" ValidationGroup="vgProjectDetails" ForeColor="Red" ControlToValidate="txtLink"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="revLink" runat="server" ErrorMessage="Please Enter Proper URL/Link" ValidationGroup="vgProjectDetails" ForeColor="Red" ControlToValidate="txtLink" ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                    </asp:Panel>
                    <asp:Panel ID="panelAcademicLevel" runat="server" Visible="false">
                        <tr>
                            <td>
                                <asp:Label ID="lblAcademicLevel" runat="server" Text="Academic Level"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlAcademicLevel" runat="server">
                                    <asp:ListItem Value="0">Select</asp:ListItem>
                                    <asp:ListItem Value="1">PG Project</asp:ListItem>
                                    <asp:ListItem Value="2">UG Project</asp:ListItem>
                                    <asp:ListItem Value="3">PG Diploma</asp:ListItem>
                                    <asp:ListItem Value="4">Diploma</asp:ListItem>
                                    <asp:ListItem Value="5">Certification</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfvAcademicLevel" runat="server" ErrorMessage="*" ValidationGroup="vgProjectDetails" ForeColor="Red" ControlToValidate="ddlAcademicLevel"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </asp:Panel>
                    <tr>
                        <%--<tr><td>
                       <%-- <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="#">Add More Projects</asp:HyperLink></td></tr>
                     <tr>--%>
                        <td colspan="2">
                            <asp:Button ID="btnSubmit" runat="server" Text="Add Project" ValidationGroup="vgProjectDetails" OnClick="btnSubmit_Click" OnClientClick="IsSelected(ddlTeamSize.id,DropDownList,'DropDownList');" />
                            Kindly save the project once you add the project</td>
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
                        <asp:BoundField HeaderStyle-Width="120px" HeaderText="RoleId" DataField="RoleId" Visible="false" />
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
        </asp:Panel>
        <asp:Panel ID="pnlEdit" runat="server" Visible="false">
            <div>
                <asp:Repeater ID="rptrProjectDetails" runat="server"
                    OnItemCommand="rptrProjectDetails_ItemCommand"
                    OnItemDataBound="rptrProjectDetails_ItemDataBound">
                    <HeaderTemplate>
                        <table width="500px" border="1px">
                            <tr style="background-color: #fb7700">
                                <%-- <td>Check</td>
                            <td>Project For</td>
                            <td>Project Title</td>
                            <td>Company Name</td>
                            <td>Role</td>
                            <td>Client Name</td>
                            <td>Duration</td>
                            <td>Project Location</td>
                            <td>Employment Type</td>
                            <td>Project Details</td>
                            <td>Roles and Responsibility</td>
                            <td>Team Size</td>
                            <td>Skill Used</td>
                            <td>Project Live</td>
                            <td>Project Link</td>
                            <td>Degree</td>
                            <td>Options</td>--%>
                                <h1>Project Details</h1>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr style="background-color: #ffffff">
                            <%--<td>
                          <center>  <asp:CheckBox ID="chkDelete" runat="server" /></center>
                        </td></tr>--%>
                            <td>
                                <table>
                                    <tr>
                                        <td>Project For </td>
                                        <td>
                                            <asp:Label ID="lblID" Visible="false" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectId") %>'></asp:Label>
                                            <asp:Label ID="lblProjectFor" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectFor")%>'></asp:Label>
                                            <asp:DropDownList ID="ddlProjectFor" runat="server" Visible="false">
                                                <asp:ListItem Value="Academic">Academic</asp:ListItem>
                                                <asp:ListItem Value="Intern">Intern</asp:ListItem>
                                                <asp:ListItem Value="Professional">Professional</asp:ListItem>
                                                <asp:ListItem Value="FreeLancing">FreeLancing</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Project Title</td>
                                        <td>
                                            <asp:Label ID="lblProjectTiltle" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectTitle")%>'></asp:Label>
                                            <asp:TextBox ID="txtProjectTiltle" BackColor="#d4d0c8" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectTitle")%>' Visible="false"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Company Name</td>
                                        <td>
                                            <asp:Label ID="lblCompanyName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "CompanyName")%>'></asp:Label>
                                            <asp:TextBox ID="txtCompanyName" BackColor="#d4d0c8" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "CompanyName")%>' Visible="false"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Role </td>
                                        <td>
                                            <asp:DropDownList ID="ddlRole" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Client Name </td>
                                        <td>
                                            <asp:Label ID="lblClientName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ClientName")%>'></asp:Label>
                                            <asp:TextBox ID="txtClientName" BackColor="#d4d0c8" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ClientName")%>' Visible="false"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Duration </td>
                                        <td>
                                            <asp:Label ID="lblDuration" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Duration")%>'></asp:Label>
                                            <asp:TextBox ID="txtDuration" BackColor="#d4d0c8" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Duration")%>' Visible="false"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Project Location </td>
                                        <td>
                                            <asp:Label ID="lblProjectLocation" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectLocation")%>'></asp:Label>
                                            <asp:TextBox ID="txtProjectLocation" BackColor="#d4d0c8" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectLocation")%>' Visible="false"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Employment Type </td>
                                        <td>
                                            <asp:Label ID="lblEmploymentType" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "EmploymentType")%>'></asp:Label>
                                            <asp:TextBox ID="txtEmploymentType" BackColor="#d4d0c8" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "EmploymentType")%>' Visible="false"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Project Details </td>
                                        <td>
                                            <asp:Label ID="lblProjectDetails" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectDetails")%>'></asp:Label>
                                            <asp:TextBox ID="txtProjectDetails" BackColor="#d4d0c8" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectDetails")%>' Visible="false"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Roles and Responsibility </td>
                                        <td>
                                            <asp:Label ID="lblRolesandResponsibility" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "RolesandResponsibility")%>'></asp:Label>
                                            <asp:TextBox ID="txtRolesandResponsibility" BackColor="#d4d0c8" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "RolesandResponsibility")%>' Visible="false"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Team Size </td>
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
                                        <td>Skill Used </td>
                                        <td>
                                            <asp:Label ID="lblSkillUsed" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "SkillUsed")%>'></asp:Label>
                                            <asp:TextBox ID="txtSkillUsed" BackColor="#d4d0c8" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "SkillUsed")%>' Visible="false"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Project Live </td>
                                        <td>
                                            <asp:Label ID="lblProjectLive" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectLive")%>'></asp:Label>
                                            <asp:TextBox ID="txtProjectLive" BackColor="#d4d0c8" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectLive")%>' Visible="false"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Project Link </td>
                                        <td>
                                            <asp:Label ID="lblProjectLink" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectLink")%>'></asp:Label>
                                            <asp:TextBox ID="txtProjectLink" BackColor="#d4d0c8" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectLink")%>' Visible="false"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Degree </td>
                                        <td>
                                            <asp:DropDownList ID="ddlDegree" runat="server">
                                                <asp:ListItem>Select</asp:ListItem>
                                                <asp:ListItem>PG Project</asp:ListItem>
                                                <asp:ListItem>UG Project</asp:ListItem>
                                                <asp:ListItem>PG Diploma</asp:ListItem>
                                                <asp:ListItem>Diploma</asp:ListItem>
                                                <asp:ListItem>Certification</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                    </tr>

                                    <table style="background-color: #f9f9f9; border-top: 1px dotted; border-bottom: 1px solid; width: 500px">
                                        <tr>
                                            <td>
                                                <asp:LinkButton ID="lnkEdit" runat="server" CommandName="edit" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "ProjectId") %>'>Edit</asp:LinkButton>
                                                <asp:LinkButton Visible="false" ID="lnkUpdate" runat="server" CommandName="update" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "ProjectId") %>'>Update</asp:LinkButton>
                                                <asp:LinkButton Visible="false" ID="lnkCancel" runat="server" CommandName="cancel" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "ProjectId") %>'>Cancel</asp:LinkButton>
                                                <asp:LinkButton ID="lnkDelete" runat="server" CommandName="delete" OnClientClick='javascript:return confirm("Are you sure you want to delete?")'
                                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "ProjectId") %>'>Delete</asp:LinkButton>
                                            </td>
                                        </tr>
                                    </table>
                                    <tr>
                                        <td colspan="2">&nbsp;</td>
                                    </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
                <%--<asp:LinkButton ID="lnkDelSelected" ForeColor="White" runat="server" OnClick="LinkButton1_Click" OnClientClick='javascript:return confirm("Are you sure you want to delete?")'>Delete Selected</asp:LinkButton>--%>
            </div>
        </asp:Panel>
    </form>
</body>
</html>
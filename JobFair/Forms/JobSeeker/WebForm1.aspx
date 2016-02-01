  
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webform1.aspx.cs" Inherits="JobFair.Forms.JobSeeker.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="~/UserControls/Recruiter/PersonalDetails.ascx" TagPrefix="uc1" TagName="PersonalDetails" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <script src="../../Scripts/jquery-2.1.4.min.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form runat="server">
       
    <div style="margin-left: 60px; margin-right: 60px" id="divRoleSkillsInsert" runat="server">
    <h3>Role Skills</h3>
    <table>
        <tr>
            <th>Role Skills
            </th>
            <th colspan="2">Using Year<br />
                From&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Till<th>Proficiency
                </th>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="ddlRoleSkills" runat="server" OnSelectedIndexChanged="ddlRoleSkills_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                <br />
            <div id="divAddMoreSkills" runat="server" visible="false">
                    <table>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtAddSkill" runat="server"></asp:TextBox>
                                <asp:Button ID="btnAdd" runat="server" Text="Add Skill" OnClick="btnAdd_Click"/>
                            &nbsp;</td>
                        </tr>
                    </table>
                </div></td>
            <td>
                <asp:DropDownList ID="ddlFromMonth" runat="server">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvFromMonth" runat="server" ControlToValidate="ddlFromMonth" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

                <asp:DropDownList ID="ddlFromYear" runat="server">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvFromYear" runat="server" ControlToValidate="ddlFromYear" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:DropDownList ID="ddlTillMonth" runat="server">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvTillMonth" runat="server" ControlToValidate="ddlTillMonth" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

                <asp:DropDownList ID="ddlTillYear" runat="server">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvTillYear" runat="server" ControlToValidate="ddlTillYear" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:DropDownList ID="ddlProficiency" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>Beginner</asp:ListItem>
                    <asp:ListItem>Intermediate</asp:ListItem>
                    <asp:ListItem>Expert</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvProficiency" runat="server" ControlToValidate="ddlProficiency" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Button ID="btnAddMoreSkills" runat="server" Text="Add More Skills" OnClick="btnAddMoreSkills_Click"  />
                Hint: If your Skills are not available in this List, Select &quot;Other&quot; and add your Skills
                    <br />
                <asp:HiddenField ID="hfCandidateId" Visible="false" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="gvSkillsDetails" AutoGenerateColumns="false" runat="server">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField HeaderText="RecruiterId" DataField="RecruiterId" Visible="false" />
                        <asp:BoundField HeaderText="RoleSkills" DataField="RoleSkills" />
                        <asp:BoundField HeaderText="FromDate" DataField="FromDate" />
                        <asp:BoundField HeaderText="TillDate" DataField="TillDate" />
                        <asp:BoundField HeaderText="Proficiency" DataField="Proficiency" />
                        <asp:BoundField HeaderText="TotalYear" DataField="TotalYear" />
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
            </td>
        </tr>
        <tr>
            <td colspan="4">
                
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Button ID="btnSaveSkills" runat="server" Text="Save" OnClick="btnSaveSkills_Click" />
            </td>
        </tr>
    </table>
</div>

<div id="divRoleSkillsEdit" runat="server" visible="false">

    <asp:Repeater ID="rptrRoleSkills" runat="server" OnItemCommand="rptrRoleSkills_ItemCommand">
        <HeaderTemplate>
            <table>
                <tr>
                    <td colspan="2">
                        <h1>Rolles Skills</h1>
                    </td>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>

            <tr style="background-color: #EBEFF0">
                <td>
                    <table style="background-color: #EBEFF0; border-top: 1px dotted #c1650f; width: 300px">
                        <tr>
                            <td>
                                <b>Role Skill</b>
                                <asp:Label ID="lblRoleSkill" runat="server" Text='<%#Eval("RoleName") %>' />
                                <asp:DropDownList ID="ddlRoleSkill" runat="server" Visible="false"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <b>FromDate</b>
                                <asp:Label ID="lblFromDate" runat="server" Text='<%#Eval("FromDate") %>' />
                                <asp:DropDownList ID="ddlFromMonth" runat="server" Visible="false"></asp:DropDownList>
                                <asp:DropDownList ID="ddlFromYear" runat="server" Visible="false"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <b>TillDate</b>
                                <asp:Label ID="lblTillDate" runat="server" Text='<%#Eval("TillDate") %>' />
                                <asp:DropDownList ID="ddlTillMonth" runat="server" Visible="false"></asp:DropDownList>
                                <asp:DropDownList ID="ddlTillYear" runat="server" Visible="false"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <b>Proficiency</b>
                                <asp:Label ID="lblProficiency" runat="server" Text='<%#Eval("Proficiency") %>' />
                                <asp:DropDownList ID="ddlProficiency" runat="server" Visible="false">
                                    <asp:ListItem>Select</asp:ListItem>
                                    <asp:ListItem>Beginner</asp:ListItem>
                                    <asp:ListItem>Intermediate</asp:ListItem>
                                    <asp:ListItem>Expert</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table style="background-color: #EBEFF0; border-top: 1px dotted #c1650f; border-bottom: 1px solid #c1650f; width: 300px">
                        <tr>
                            <td>
                                <asp:LinkButton ID="lnkEdit" runat="server" CommandArgument='<%#Eval("RoleskillId") %>' CommandName="edit">Edit</asp:LinkButton>
                                <asp:LinkButton ID="lnkDelete" runat="server" CommandArgument='<%#Eval("RoleskillId") %>' CommandName="delete" OnClientClick="return confirm('Are you sure you want to delete?')">Delete</asp:LinkButton>
                                <asp:LinkButton ID="lnkUpdate" runat="server" CommandArgument='<%#Eval("RoleskillId") %>' CommandName="update" Visible="false">Update</asp:LinkButton>
                                <asp:LinkButton ID="lnkCancel" runat="server" CommandArgument='<%#Eval("RoleskillId") %>' CommandName="cancel" Visible="false">Cancel</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            </table>
        </ItemTemplate>
    </asp:Repeater>
</div>
        </form>
    
</body>
</html>
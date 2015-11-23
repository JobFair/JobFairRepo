<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RoleSkillsDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.RoleSkillsDetails" %>
<div style="border: solid; margin-left: 150px; margin-right: 150px">
    <div style="margin-left: 60px; margin-right: 60px">
        <h3>Role Skills</h3>
        <table>
            <tr>
                <th>
                    Role Skills
                </th>
                <th colspan="2">
                    Using Year<br />
                    From&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Till<th>
                    Proficiency
                </th>
            </tr>
            <tr>
                <td>
        <asp:DropDownList ID="ddlRoleSkills" runat="server"></asp:DropDownList>
                    </td>
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
                    <asp:Button ID="btnAddMoreSkills" runat="server" Text="Add More Skills" OnClick="btnAddMoreSkills_Click" />
                    <br />
                                <asp:HiddenField ID="hfCandidateId" Visible="false" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:GridView ID="gvSkillsDetails" AutoGenerateColumns="false" runat="server">
                         <AlternatingRowStyle BackColor="White" />
                        <Columns>
                                        <asp:BoundField HeaderText="CandidateId" DataField="CandidateId" Visible="false" />
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
                    <asp:Button ID="btnSaveSkills" runat="server" Text="Save" OnClick="btnSaveSkills_Click" />

                </td>
            </tr>
            </table>
    </div>
</div>

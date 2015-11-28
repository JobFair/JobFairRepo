<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TechnicalSkillsDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.TechnicalSkillsDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<div style="border: solid; margin-left: 150px; margin-right: 150px">
    <div style="margin-left: 60px; margin-right: 60px">
        <h3>Technical Skills</h3>
        <table>
            <tr>
                <th>
                   Technical Skills
                </th>
                <th colspan="2">
                    Using Year<br />
                    From&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Till<th>
                    Proficiency
                </th>
            </tr>
            <tr>
                <td>
        <asp:DropDownList ID="ddlTechnicalSkills" runat="server"></asp:DropDownList>
                    </td>
                <td>
                    <asp:DropDownList ID="ddlFromMonth" runat="server">
                      
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlFromYear" runat="server"></asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="ddlTillMonth" runat="server"></asp:DropDownList>
                    <asp:DropDownList ID="ddlTillYear" runat="server"></asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="ddlProficiency" runat="server">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Beginner</asp:ListItem>
                        <asp:ListItem>Intermediate</asp:ListItem>
                        <asp:ListItem>Expert</asp:ListItem>
                    </asp:DropDownList>
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
                                        <asp:BoundField HeaderText="TechnicalSkills" DataField="TechnicalSkills" />
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
                                    <asp:Repeater ID="rptrTechnicalSkills" runat="server" OnItemCommand="rptrTechnicalSkills_ItemCommand" OnItemDataBound="rptrTechnicalSkills_ItemDataBound">
                                        <HeaderTemplate>
                                            <table>
                                                <tr>
                                                    <td colspan="2">
                                                        <h1>Your Technical Skills</h1>
                                                    </td>
                                                </tr>
                                        </HeaderTemplate>
                                        <ItemTemplate>

                                            <tr style="background-color: #EBEFF0">
                                                <td>
                                                    <table style="background-color: #EBEFF0; border-top: 1px dotted #c1650f; width: 300px">
                                                        <tr>
                                                            <td>
                                                                <b>Technical Skill</b>
                                                                <asp:Label ID="lblTechnicalSkill" runat="server" Text='<%#Eval("TechnicalSkillName") %>' />
                                                                <asp:DropDownList ID="ddlTechnicalSkill" runat="server" Visible="false"></asp:DropDownList>
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
                                                                <asp:LinkButton ID="lnkEdit" runat="server" CommandArgument='<%#Eval("SkillId") %>' CommandName="edit">Edit</asp:LinkButton>
                                                                <asp:LinkButton ID="lnkDelete" runat="server" CommandArgument='<%#Eval("SkillId") %>' CommandName="delete" OnClientClick="return confirm('Are you sure you want to delete?')">Delete</asp:LinkButton>
                                                                <asp:LinkButton ID="lnkUpdate" runat="server" CommandArgument='<%#Eval("SkillId") %>' CommandName="update" Visible="false">Update</asp:LinkButton>
                                                                <asp:LinkButton ID="lnkCancel" runat="server" CommandArgument='<%#Eval("SkillId") %>' CommandName="cancel" Visible="false">Cancel</asp:LinkButton>
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
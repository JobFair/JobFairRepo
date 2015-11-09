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
                    <th>
                    Proficiency
                </th>
            </tr>
            <tr>
                <td>
        <asp:DropDownList ID="ddlTechnicalSkills" runat="server"></asp:DropDownList>
                    </td>
                <td>
                    <asp:DropDownList ID="ddlDromMonth" runat="server"></asp:DropDownList>
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
                    <asp:Button ID="btnAddMoreSkills" runat="server" Text="Add More Skills" />
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:GridView ID="gvSkillsDetails" runat="server"></asp:GridView>
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Button ID="btnSaveSkills" runat="server" Text="Save" />

                </td>
            </tr>
            </table>
    </div>
</div>
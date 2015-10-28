<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EducationalProjectDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.EducationalProjectDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<table class="auto-style1">
    <tr>
        <td colspan="2"><h2>Academic Projects</h2></td>
    </tr>
    <tr>
        <td class="auto-style2">Project Title</td>
        <td>
            <asp:TextBox ID="txtProjectTitle" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Duration</td>
        <td>
            <asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
            <cc1:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtFrom" PopupButtonID="txtFrom" Format="dd/MM/yyyy" />
&nbsp;To
            <asp:TextBox ID="txtTo" runat="server"></asp:TextBox>
            <cc1:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtTo" PopupButtonID="txtTo" Format="dd/MM/yyyy" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Project Details</td>
        <td>&nbsp;<asp:TextBox ID="txtProjectDetails" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Roles And Responsibility</td>
        <td>
            <asp:TextBox ID="txtResponsibility" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Team Size</td>
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
        <td class="auto-style2">Skill Used</td>
        <td>
            <asp:TextBox ID="txtSkillUsed" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Project Live</td>
        <td>
            <asp:RadioButton ID="rbtYes" runat="server" GroupName="Live" Text="Yes" />
            <asp:RadioButton ID="rbtNo" runat="server" GroupName="Live" Text="No" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Project URL</td>
        <td>
            <asp:TextBox ID="txtProjectURL" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>


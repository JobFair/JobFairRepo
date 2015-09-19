<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LiveProjectDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.LiveProjectDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<style type="text/css">
    .auto-style1 {
        width: 60%;
        height: 457px;
    }
    .auto-style2 {
        width: 281px;
    }
</style>
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<table class="auto-style1">
    <tr>
        <td colspan="2"><h1>Live Project Details</h1></td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblCompanyName" runat="server" Text="Company Name"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtCompanyName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblProjectTitle" runat="server" Text="Project Title"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtProjectTitle" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblRole" runat="server" Text="Your Role"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlRole" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblClientName" runat="server" Text="Client Name"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtClientName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblLinkUrl" runat="server" Text="Project Link/URL"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtLink" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblDuration" runat="server" Text="Duration"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFromDate" runat="server"></asp:TextBox><cc1:CalendarExtender ID="CalendarExtender1" runat="server" PopupButtonID="txtFromDate" TargetControlID="txtFromDate" Format="dd/MM/yyyy" />
            To<asp:TextBox ID="txtTodate" runat="server"></asp:TextBox><cc1:CalendarExtender ID="CalendarExtender2" runat="server" PopupButtonID="txtTodate"  TargetControlID="txtTodate" Format="dd/MM/yyyy"/>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblLocation" runat="server" Text="Project Location"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblEmploymentType" runat="server" Text="Employment Type"></asp:Label>
        </td>
        <td>
            <asp:RadioButton ID="rbtFullTime" runat="server" GroupName="Employee" Text="Full Time" />
            <asp:RadioButton ID="rbtPartTime" runat="server" GroupName="Employee" Text="Part Time" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblProjectDetails" runat="server" Text="Project Details"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtProjectDetails" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblResponsibility" runat="server" Text="Roles And Responsibility"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtRolesAndResponsibility" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
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
        <td class="auto-style2">
            <asp:Label ID="lblSkillUsed" runat="server" Text="Skill Used"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtSkillUsed" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </td>
    </tr>
</table>


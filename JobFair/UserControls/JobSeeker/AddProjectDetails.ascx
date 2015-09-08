<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddProjectDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.AddProjectDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<style type="text/css">
    .auto-style1 {
        width: 57%;
        height: 472px;
    }
    .auto-style2 {
    }
</style>
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<table class="auto-style1">
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
            <asp:Label ID="lblClientName" runat="server" Text="Client Name"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtClientName" runat="server"></asp:TextBox>
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
            <asp:Label ID="lblDuration" runat="server" Text="Duration"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFormDate" runat="server"></asp:TextBox><cc1:CalendarExtender ID="CalendarExtender1" runat="server" PopupButtonID="txtFormDate" TargetControlID="txtFormDate" />
&nbsp; To&nbsp;&nbsp;
            <asp:TextBox ID="txtToDate" runat="server"></asp:TextBox><cc1:CalendarExtender ID="CalendarExtender2" runat="server" PopupButtonID="txtToDate" TargetControlID="txtToDate" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblLocation" runat="server" Text="Project Location"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtProjectLocation" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblEmpType" runat="server" Text="Employment Type"></asp:Label>
        </td>
        <td>
            <asp:RadioButton ID="rbtFulTime" runat="server" GroupName="EmpoymentType" Text="Full Time" />
            <asp:RadioButton ID="rbtPartTme" runat="server" GroupName="EmpoymentType" Text="Part Time" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblProjectDetails" runat="server" Text="Project Details"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtProjectDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblRole" runat="server" Text="Role"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlRole" runat="server">
            </asp:DropDownList>
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
            <asp:Label ID="lblSkill" runat="server" Text="Skill Used"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtSkill" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2" colspan="2">
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Button" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    </table>


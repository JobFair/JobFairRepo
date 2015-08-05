<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddNewRequirementOfClient.ascx.cs" Inherits="JobFair.Forms.Recruiter.AddNewRequirementOfClient" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<link href="../../Style.css" rel="stylesheet" />
<table >
    <tr>
        <td colspan="2"><h1>Add New Requirement</h1></td>
        
    </tr>
    <tr>
        <td>Client Name</td>
        <td>
            <asp:DropDownList ID="ddlClientName" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>Position</td>
        <td>
            <asp:TextBox ID="txtPosition" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Job Description</td>
        <td>
            <asp:TextBox ID="txtJobDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Gender</td>
        <td>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td>Date Of Requirement Sent</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <cc1:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" BehaviorID="TextBox2_CalendarExtender" TargetControlID="TextBox2">
            </cc1:CalendarExtender>
        </td>
    </tr>
    <tr>
        <td>Due Date</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <cc1:CalendarExtender ID="TextBox3_CalendarExtender" runat="server" BehaviorID="TextBox3_CalendarExtender" TargetControlID="TextBox3">
            </cc1:CalendarExtender>
        </td>
    </tr>
    <tr>
        <td>Number of Vacancy</td>
        <td>
            <asp:TextBox ID="txtNoOfVacancy" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Position Closed</td>
        <td>
            <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True" Height="79px">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="btnAdd" runat="server" Text="Add" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </td>
    </tr>
</table>


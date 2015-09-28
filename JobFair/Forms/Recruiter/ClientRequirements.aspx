<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Recruiter/RecruiterHome.Master" AutoEventWireup="true" CodeBehind="ClientRequirements.aspx.cs" Inherits="JobFair.Forms.Recruiter.ClientRequirements" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajax" %>
<%@ Register Src="~/UserControls/Recruiter/AddOfferedCandidates.ascx" TagPrefix="UserControl" TagName="AddOfferedCandidates" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<link href="../../Css/Style.css" rel="stylesheet" />
<link href="../../Css/Common.css" rel="stylesheet" />

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div id="divMain" runat="server" style="min-height: 500px; padding: 10px">

    <h2>
        Add New Requirement &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </h2>
        <table style="margin-left: 10px">
            <tr>
                <td><asp:Label ID="lblClientName" runat="server" Text=" Client Name" CssClass="label"></asp:Label></td>
                <td>
                   <asp:DropDownList ID="ddlClientName" runat="server">
                    </asp:DropDownList> 
                </td>
            </tr>
        <tr>
            <td><asp:Label ID="lblPosition" runat="server" Text="Position" CssClass="label"></asp:Label></td>
            <td><asp:TextBox ID="txtPosition" runat="server" Width="100px"></asp:TextBox></td>
        </tr>           
        <tr>
            <td><asp:Label ID="lblJobDescription" runat="server" Text="Job Description" CssClass="label"></asp:Label></td>
            <td><asp:TextBox ID="txtJobDescription" runat="server" Width="100px"></asp:TextBox></td>
        </tr>
            <tr>
                <td><asp:Label ID="lblGender" runat="server" Text="Gender" CssClass="label"></asp:Label></td>
                <td>
                    <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal" CssClass="MultipleSelectionDDL" Width="100px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblDateOfReqSent" runat="server" Text="Date of Requirement Sent" CssClass="label"></asp:Label></td>
                <td><asp:TextBox ID="txtDateOfReqSent" runat="server" Width="100px"></asp:TextBox>
                    <ajax:CalendarExtender ID="txtDateOfReqSent_CalendarExtender" runat="server" BehaviorID="txtDateOfReqSent_CalendarExtender" TargetControlID="txtDateOfReqSent" Format="dd/MM/yyyy"></ajax:CalendarExtender></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblDueDate" runat="server" Text="Due Date" CssClass="label"></asp:Label></td>
                <td><asp:TextBox ID="txtDueDate" runat="server" Width="100px"></asp:TextBox>
                    <ajax:CalendarExtender ID="txtDueDate_CalendarExtender" runat="server" BehaviorID="txtDueDate_CalendarExtender" TargetControlID="txtDueDate" Format="dd/MM/yyyy"></ajax:CalendarExtender></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblNumberOfVacancy" runat="server" Text="Number of Vacancy" CssClass="label"></asp:Label></td>
                <td><asp:TextBox ID="txtNumberOfVacancy" runat="server" Width="100px"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblPositionClosed" runat="server" Text="Position Closed" CssClass="label"></asp:Label></td>
                <td><asp:RadioButtonList ID="rblPositionClosed" runat="server" RepeatDirection="Horizontal" CssClass="MultipleSelectionDDL" Width="100px">
                    <asp:ListItem Value="1">Yes</asp:ListItem>
                    <asp:ListItem Value="0">No</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btn" runat="server" OnClick="btnSubmit" Text="Submit" />
                </td>
            </tr>
        </table>
    </div>
     
       <div id="divView" runat="server">
           <UserControl:AddOfferedCandidates runat="server" ID="AddOfferedCandidates" />
       </div>

</asp:Content>
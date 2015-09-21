<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Recruiter/RecruiterHome.Master" AutoEventWireup="true" CodeBehind="PostNewJob.aspx.cs" Inherits="JobFair.Forms.Recruiter.PostNewJob1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style7 {
            width: 214px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <table class="auto-style6">
        <tr>
            <td colspan="2">
                <h1>Post New Job</h1>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Job Title/Designation</td>
            <td>
                <asp:TextBox ID="txtJobtitle" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Job Locations</td>
            <td>
                <asp:TextBox ID="txtJobLocation" runat="server"></asp:TextBox>
                <br /></td>
        </tr>
        <tr>
            <td class="auto-style7">Job Locations Area</td>
            <td>
                <asp:TextBox ID="txtJobLocationArea" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Company Level</td>
            <td>
                <asp:DropDownList ID="ddlCompanyLevel" runat="server" AutoPostBack="True">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>Startup Company</asp:ListItem>
                    <asp:ListItem>Small Scale Company</asp:ListItem>
                    <asp:ListItem>Mid Level Company</asp:ListItem>
                    <asp:ListItem>MNC</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Industry</td>
            <td>
                <asp:DropDownList ID="ddlIndustry" runat="server" Height="19px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Department</td>
            <td>
                <asp:DropDownList ID="ddlDepartment" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Functional Area</td>
            <td>
                <asp:DropDownList ID="ddlFunArea" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Job Description</td>
            <td>
                <asp:TextBox ID="txtJobDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Keywords/Skillsets Roles</td>
            <td>
                <asp:TextBox ID="txtKeyRoles" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Keywords/Skillsets Technical</td>
            <td>
                <asp:TextBox ID="txtKeyTechnical" runat="server" Height="22px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Work Experience</td>
            <td><asp:TextBox ID="txtWorkExp" runat="server"></asp:TextBox>
                <cc1:CalendarExtender ID="txtWorkExp_CalendarExtender" runat="server" BehaviorID="txtWorkExp_CalendarExtender" TargetControlID="txtWorkExp">
                </cc1:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Gender</td>
            <td>
                <asp:RadioButton ID="rdbmale" runat="server" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="rdbFemale" runat="server" Text="Female" />
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Offered Anual Salary</td>
            <td>
                <asp:TextBox ID="txtAnnualSalary" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Other Salary Details</td>
            <td>
                <asp:TextBox ID="txtOtherSalary" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Number of Vacancies</td>
            <td>
                <asp:TextBox ID="txtVacancies" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                &nbsp;</td>
            <td>
                <asp:Button ID="btnPostJob" runat="server" Text="Post Job" OnClick="btnPostJob_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            &nbsp;
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

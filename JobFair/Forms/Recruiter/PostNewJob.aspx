<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Recruiter/RecruiterHome.Master" AutoEventWireup="true" CodeBehind="PostNewJob.aspx.cs" Inherits="JobFair.Forms.Recruiter.PostNewJob1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <table>
        <tr>
            <td>
                <h1>Post New Job</h1>
            </td>
        </tr>
        <tr>
            <td>Job Title/Designation</td>
            <td>
                <asp:TextBox ID="txtJobtitle" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Job Locations</td>
            <td>
                <asp:TextBox ID="txtJobLocation" runat="server"></asp:TextBox>
                <br /></td>
        </tr>
        <tr>
            <td>Job Locations Area</td>
            <td>
                <asp:TextBox ID="txtJobLocationArea" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Company Level</td>
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
            <td>Industry</td>
            <td>
                <asp:DropDownList ID="ddlIndustry" runat="server" Height="19px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Department</td>
            <td>
                <asp:DropDownList ID="ddlDepartment" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Functional Area</td>
            <td>
                <asp:DropDownList ID="ddlFunArea" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Job Description</td>
            <td>
                <asp:TextBox ID="txtJobDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Keywords/Skillsets Roles</td>
            <td>
                <asp:TextBox ID="txtKeyRoles" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Keywords/Skillsets Technical</td>
            <td>
                <asp:TextBox ID="txtKeyTechnical" runat="server" Height="22px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Work Experience</td>
            <td><asp:TextBox ID="txtWorkExp" runat="server"></asp:TextBox>
                 <cc1:CalendarExtender ID="CalendarExtender1" TargetControlID="txtWorkExp" Format="dd/MM/yyyy" runat="server">
</cc1:CalendarExtender> 
            </td>
        </tr>
        <tr>
            <td>Gender</td>
            <td>
                <asp:RadioButton ID="rdbmale" runat="server" Text="Male" />
                <asp:RadioButton ID="rdbFemale" runat="server" Text="Female" />
            </td>
        </tr>
        <tr>
            <td>Offered Anual Salary</td>
            <td>
                <asp:TextBox ID="txtAnnualSalary" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Other Salary Details</td>
            <td>
                <asp:TextBox ID="txtOtherSalary" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Number of Vacancies</td>
            <td>
                <asp:TextBox ID="txtVacancies" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" />
             </td>
            <td>
                <asp:Button ID="btnPostJob" runat="server" Text="Post Job" OnClick="btnPostJob_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

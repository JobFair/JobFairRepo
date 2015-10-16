<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ResumeFormating.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.ResumeFormating" %>

<table>
    <tr>
        <td>
            <asp:Label ID="lblUserType" runat="server" Text="You are"></asp:Label>
        </td>
        <td>
            <asp:RadioButton ID="rbtIntern" runat="server" GroupName="Type" Text="Intern" ValidationGroup="Type" />
            <asp:RadioButton ID="rbtFreshar" runat="server" GroupName="Type" Text="Freshar" />
            <asp:RadioButton ID="rbtExperience" runat="server" GroupName="Type" Text="Experience" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblObjective" runat="server" Text="Objective"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtObjective" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblSummary" runat="server" Text="Profile Summary"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtSummary" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblKeyArea" runat="server" Text="Key Result Area"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtKeyArea" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblRolesAndResopnsibility" runat="server" Text="Roles And Responsibility"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtRoles" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCompanyName" runat="server" Text="Company Name"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlCompanyName" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblAwards" runat="server" Text="Awards And Recognition"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtAwards" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblExtraActivities" runat="server" Text="Extra curricular/Social Activities"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtExtraActivities" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblHobbies" runat="server" Text="Hobbies"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtHobbies" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
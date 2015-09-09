<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Employer/HomePage.Master" AutoEventWireup="true" CodeBehind="AffirmativeDetails.aspx.cs" Inherits="JobFair.Forms.JobSeeker.OtherDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style4">
        <tr>
            <td>
                <asp:Label ID="LblLanguages" runat="server" Text="Languages Known"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LblLanguages1" runat="server" Text="Languages"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LblProficincy" runat="server" Text="Proficiency"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LblRead" runat="server" Text="Read"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LblWrite" runat="server" Text="Write"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LblSpeak" runat="server" Text="Speak"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:TextBox ID="TxtLanguage" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:DropDownList ID="DDLProficiency" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:CheckBox ID="ChkWrite" runat="server" />
            </td>
            <td>
                <asp:CheckBox ID="ChkRead0" runat="server" />
            </td>
            <td>
                <asp:CheckBox ID="ChkSpeak" runat="server" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:TextBox ID="TxtLanguage0" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:DropDownList ID="DDLProficiency0" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:CheckBox ID="ChkWrite0" runat="server" />
            </td>
            <td>
                <asp:CheckBox ID="ChkRead1" runat="server" />
            </td>
            <td>
                <asp:CheckBox ID="ChkSpeak0" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblEmploymentType" runat="server" Text="Employment Type"></asp:Label>
            </td>
            <td colspan="5">
                <asp:TextBox ID="TxtJobType" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblPhysicallyChallenged" runat="server" Text="Physically Challenged"></asp:Label>
            </td>
            <td colspan="5">
                <asp:RadioButton ID="RdbYes" runat="server" Text="Yes" />
&nbsp;&nbsp;
                <asp:RadioButton ID="RdbNo" runat="server" Text="No" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblDescription" runat="server" Text="Description"></asp:Label>
            </td>
            <td colspan="5">
                <asp:TextBox ID="TxtDescription" runat="server">Description</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblUSaPermit" runat="server" Text="USAPermit"></asp:Label>
            </td>
            <td colspan="5">
                <asp:RadioButton ID="RdbYesUSA" runat="server" Text="Yes" />
&nbsp;&nbsp;
                <asp:RadioButton ID="RdbNOUSA" runat="server" Text="Yes" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblOtherPermit0" runat="server" Text="Other Permit"></asp:Label>
            </td>
            <td colspan="5">
                <asp:TextBox ID="TxtOtherPermit" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="5">
                <asp:Button ID="BtnSubmit" runat="server" Text="Submit" />
            </td>
        </tr>
    </table>
</asp:Content>

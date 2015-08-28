<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="JobSeekerForgetPassword.aspx.cs" Inherits="JobFair.Forms.JobSeeker.JobSeeker" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        height: 30px;
    }
    .watermark{
        color:gray;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <table>
        <tr>
            <td colspan="2"><h1>Forget Password</h1></td>            
        </tr>
        <tr>
            <td>Enter your MailId here</td>
            <td><asp:TextBox ID="txtEmailId" runat="server" CssClass="watermark"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" runat="server" WatermarkText="Enter Email ID" TargetControlID="txtEmailId" />
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>            
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1"><asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="Submit_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
        </tr>
    </table>

        </asp:Content>

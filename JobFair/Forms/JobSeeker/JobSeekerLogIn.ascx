<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="JobSeekerLogIn.ascx.cs" Inherits="JobFair.Forms.JobSeeker.JobSeekerLogIn" %>
<style type="text/css">

   
</style>
<div>
<link href="../../Style.css" rel="stylesheet" type="text/css" />
<link href="../../Css/Common.css" rel="stylesheet" />
<table >
    <tr>
        <td >&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblUserName" runat="server" Text="User Name" CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblPassword" runat="server" Text="Password" CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td>
            <asp:Button ID="btnLogin" runat="server" Text="LogIn" CssClass="button" OnClick="btnLogin_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel"  CssClass="button"/>
            <asp:HyperLink ID="hlForgetpwd" runat="server" NavigateUrl="~/Forms/JobSeeker/ForgetPassword.ascx">Forget Password?</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td>
            <asp:HyperLink ID="hlRegister" NavigateUrl="~/Forms/JobSeeker/JobSeekerRegister.aspx" runat="server">New User? Please Register click here</asp:HyperLink>
        </td>
    </tr>
</table></div>


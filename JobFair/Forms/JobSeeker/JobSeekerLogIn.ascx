<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="JobSeekerLogIn.ascx.cs" Inherits="JobFair.Forms.JobSeeker.JobSeekerLogIn" %>
<style type="text/css">

   
</style>

<link href="../../Style.css" rel="stylesheet" type="text/css" />

<table >
    <tr>
        <td >&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblUserId" runat="server" Text="User Id"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td>
            <asp:Button ID="btnLogin" runat="server" Text="LogIn" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <asp:HyperLink ID="hlForgetpwd" runat="server" NavigateUrl="~/Forms/JobSeeker/ForgetPassword.ascx">Forget Password?</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td>
            <asp:HyperLink ID="hlRegister" runat="server">New User? Please Register click here</asp:HyperLink>
        </td>
    </tr>
</table>


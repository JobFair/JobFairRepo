<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="JobFair.Forms.JobSeeker.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div></div>
    <table>
        <tr>
            <td colspan="2"><h1>Login</h1></td>
        </tr>
        <tr>
            <td>User Name</td>
            <td><asp:TextBox ID="txtUserName" runat="server" placeholder="User Name" onfocus="this.placeholder = ''" onblur="this.placeholder = 'User Name'"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Password</td>
            <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Password'"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><asp:CheckBox ID="cbRememberMe" runat="server" Text="Remember Me" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnLogIn" runat="server" Text="LogIn" OnClick="btnLogIn_Click" /><asp:Button ID="btnCancel" runat="server" Text="Cancel" /></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:HyperLink ID="hlForgetPassword" NavigateUrl="~/Forms/JobSeeker/JobSeekerForgetPassword.aspx" runat="server">Forget Password?</asp:HyperLink>
                <br />
                <asp:HyperLink ID="hlNewRegister" NavigateUrl="~/Forms/JobSeeker/JobSeekerRegister.aspx" runat="server">New User click here</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>

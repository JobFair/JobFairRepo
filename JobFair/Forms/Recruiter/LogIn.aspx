<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Recruiter/RecruiterHome.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="JobFair.Forms.Recruiter.LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table>
            <tr>
                <td colspan="2">
                    <h1>Recruiter Login</h1>
                </td>
            </tr>
            <tr>
                <td>Login Id(Mail id)</td>
                <td>
                    <asp:TextBox ID="txtLoginid" runat="server" ></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td><asp:Button ID="btnLogin" runat="server"  Text="Login" OnClick="btnLogin_Click"/>
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td><asp:HyperLink ID="hlForgetPassword" runat="server" NavigateUrl="~/Forms/Common/ForgetPassword.aspx">Forget Password?</asp:HyperLink></td>
            </tr>
        </table>
    </div>
</asp:Content>
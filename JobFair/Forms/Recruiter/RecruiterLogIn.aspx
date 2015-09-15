<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Recruiter/RecruiterHome.Master" AutoEventWireup="true" CodeBehind="RecruiterLogIn.aspx.cs" Inherits="JobFair.Forms.Recruiter.RecruiterLogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">



A:link  {
	font-size : 10pt;
	font-family : Arial, Verdana, sans-serif;
	font-weight : normal;
	font-style : normal;
	color :  #3D99F5;
}


    </style>
    <link href="../../Style.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table >
        <tr>
            <td colspan="2"><h1>Recruiter LogIn</h1></td>
            
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
                <asp:HyperLink ID="hlRegister" NavigateUrl="~/Forms/Recruiter/RecruiterLogIn.aspx" runat="server">New User? Please Register click here</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>

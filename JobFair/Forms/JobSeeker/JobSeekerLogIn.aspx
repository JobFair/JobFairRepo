<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="JobSeekerLogIn.aspx.cs" Inherits="JobFair.Forms.JobSeeker.JobSeekerLogIn1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajax" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
.VeryPoorStrength
{
background: Red;
color:White;
font-weight:bold;
}
.WeakStrength
{
background: Gray;
color:White;
font-weight:bold;
}
.AverageStrength
{
background: orange;
color:black;
font-weight:bold;
}
.GoodStrength

{
background: blue;
color:White;
font-weight:bold;
}
.ExcellentStrength

{
background: Green;
color:White;
font-weight:bold;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div></div>
   <asp:ScriptManager runat="server"></asp:ScriptManager>
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
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Password'"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
            </td>
            <td>
               <ajax:PasswordStrength ID="pwdStrength" TargetControlID="txtPassword" StrengthIndicatorType="Text" PrefixText="Strength:" HelpStatusLabelID="lblhelp" 
            PreferredPasswordLength="8" MinimumNumericCharacters="1" MinimumSymbolCharacters="1" TextStrengthDescriptions="Very Poor;Weak;Average;Good;Excellent"
            TextStrengthDescriptionStyles="VeryPoorStrength;WeakStrength;AverageStrength;GoodStrength;ExcellentStrength" runat="server" />
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</td>
            <td>
                <asp:Label ID="lblhelp" runat="server"/>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><asp:CheckBox ID="cbRememberMe" runat="server" Text="Remember Me" /></td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnLogIn" runat="server" Text="LogIn" OnClick="btnLogIn_Click" /><asp:Button ID="btnCancel" runat="server" Text="Cancel" /></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="hlForgetPassword" NavigateUrl="~/Forms/JobSeeker/JobSeekerForgetPassword.aspx" runat="server">Forget Password?</asp:HyperLink>
                <br />
                <asp:HyperLink ID="hlNewRegister" NavigateUrl="~/Forms/JobSeeker/JobSeekerRegister.aspx" runat="server">New User click here</asp:HyperLink>
            </td>
        </tr>
    </table>

     
        
</asp:Content>

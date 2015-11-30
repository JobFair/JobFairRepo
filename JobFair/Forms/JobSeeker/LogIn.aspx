<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="JobFair.Forms.JobSeeker.LogIn" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Scripts/ValidationAll.js"></script>
    <%--      <link href="../../Css/bootstrap.min.css" rel="stylesheet" />
      <script src="../../Scripts/bootstrap.min.js"></script>
      <script src="../../Scripts/jquery.min.js"></script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
   <%-- <div class="container" style="padding:3px">
        <div class="row">
            <div class="col-md-12">
                <div class="col-md-3">
                    <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
                </div>
                <div class="col-md-9">
                    <%-- <asp:TextBox ID="TextBox1" runat="server" CssClass="col-sm-4"></asp:TextBox>--%>
                    <%--<input class="form-control" id="txtUserId" runat="server" type="text" />
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="row">
                <div class="col-md-3">
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                </div>
                <div class="col-md-9">--%>
                    <%--  <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>--%>
                  <%--  <input class="form-control" id="txtUserPassword" runat="server" type="text" />
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-default" Text="Login" />
            </div>
        </div>
    </div>--%>


    <table>
        <tr>
            <td colspan="2">
                <h1>Login</h1>
            </td>
        </tr>
        <tr>
            <td>User Name  </td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server" onblur="return CheckEmail(this.id)"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="rfvUserName" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>--%>
                <%--<asp:RegularExpressionValidator ID="revUserName" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtUserName" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>--%>
            </td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="validate[required]"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="refPassword" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:CheckBox ID="cbRememberMe" runat="server" Text="Remember Me" /></td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnLogIn" runat="server" Text="LogIn" OnClick="btnLogIn_Click" /><asp:Button ID="btnCancel" runat="server" Text="Cancel" /></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:HyperLink ID="hlForgetPassword" NavigateUrl="~/Forms/Common/ForgetPassword.aspx" runat="server">Forget Password?</asp:HyperLink>
                <br />
                <asp:HyperLink ID="hlNewRegister" NavigateUrl="~/Forms/JobSeeker/JobSeekerRegister.aspx" runat="server">New User click here</asp:HyperLink>
            </td>
        </tr>
    </table>

</asp:Content>

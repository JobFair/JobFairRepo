<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Employer/HomePageEmployer.Master" AutoEventWireup="true" CodeBehind="EmployerRegister.aspx.cs" Inherits="JobFair.Forms.Employeer.EmployeeRegister" %>

<%@ Register Src="~/UserControls/Recruiter/ClientDetails.ascx" TagPrefix="uc1" TagName="ClientDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Style.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table  >
        <tr>
            <td colspan="2"><h1>Employer Registration</h1></td>
            
        </tr>
        <tr>
            <td >Company</td>
            <td>
                <asp:TextBox ID="txtCompnyName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >HR&#39;s Full Name</td>
            <td>
                <asp:TextBox ID="txtHrName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Mobile Number</td>
            <td>
                <asp:TextBox ID="txtMobNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Official Email Id</td>
            <td>
                <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >City</td>
            <td>
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Create Password</td>
            <td>
                <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Confirm Password</td>
            <td>
                <asp:TextBox ID="txtConPwd" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Photo</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td>
                <asp:Button ID="btnRegister" runat="server" Text="Button" />
                <asp:HyperLink ID="hlForgetPassword" runat="server">Forget Password</asp:HyperLink>
            </td>
        <%--</tr>--%>
    </table>
    <uc1:ClientDetails runat="server" ID="ClientDetails" />
</asp:Content>

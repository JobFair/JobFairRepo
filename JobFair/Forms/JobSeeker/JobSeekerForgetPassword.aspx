<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="JobSeekerForgetPassword.aspx.cs" Inherits="JobFair.Forms.JobSeeker.JobSeeker" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table>
        <tr>
            <td colspan="2"><h1>Forget Password</h1></td>            
        </tr>
        <tr>
            <td>Enter your MailId here</td>
            <td><asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>            
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="Submit" Text="Submit" runat="server" OnClick="Submit_Click"/></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
        </tr>
    </table>

        <table >
            <tr>
                <td colspan="2"  ><strong><h1>FeedBack</h1></strong></td>
                
            </tr>
            <tr>
                <td >User Name</td>
                <td>
                    <asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >Email Id</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >Feedback</td>
                <td>
                    <asp:TextBox ID="txtFeedback" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >&nbsp;</td>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
                </td>
            </tr>
            <tr>
                <td >&nbsp;</td>
                <td>
                    <asp:Label ID="lblMsg0" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td >&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        
</asp:Content>

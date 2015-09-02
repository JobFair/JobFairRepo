<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgetPassword.aspx.cs" Inherits="JobFair.Forms.Common.ForgetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <table>
        <tr>
            <td colspan="2"><h1>Forget Password</h1></td>            
        </tr>
        <tr>
            <td>Enter your MailId here</td>
            <td><asp:TextBox ID="txtEmailId" runat="server" CssClass="watermark"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>            
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1"><asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="Submit_Click"/>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><asp:Label ID="lblMsg" runat="server"></asp:Label>
                <br />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="JobFair.Forms.Common.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    

   
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
<table>
    <tr>
        <td colspan="2"><h1>Change Your Password</h1></td></tr>
        
    <tr>
        <td >
            &nbsp;</td>
        <td style="margin-left: 40px">
            &nbsp;</td>
    </tr>
        
    <tr>
        <td >
            <asp:Label ID="lblOldpwd" runat="server" Text="Enter Your Old Password"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtOldpwd" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtOldpwd" ErrorMessage="Enter your old password correct">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblNewpwd" runat="server" Text="Enter New Password"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtNewpwd" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNewpwd" ErrorMessage="Enter New Password">*</asp:RequiredFieldValidator>

        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblConpwd" runat="server" Text="Confirm New Password"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtConpwd" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtNewpwd" ControlToValidate="txtConpwd" ErrorMessage="ReEnter Correct New Password">*</asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td colspan="2">&nbsp;</td>
        
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td>
            <asp:Button ID="btnChangePassword" runat="server" Text="Change Password" OnClick="btnOk_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </td>
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
    </tr>
</table>
    
    </div>
    </form>
</body>
</html>

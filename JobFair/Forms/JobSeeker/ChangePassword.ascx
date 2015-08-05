<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.ascx.cs" Inherits="JobFair.Forms.JobSeeker.ChangePassword" %>
<link href="../../Style.css" rel="stylesheet" />

<table >
    <tr>
        <td >
            <asp:Label ID="lblOldpwd" runat="server" Text="Enter Your Old Password"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtOldpwd" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblNewpwd" runat="server" Text="Enter New Password"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtNewpwd" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblConpwd" runat="server" Text="Confirm New Password"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtConpwd" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td>
            <asp:Button ID="btnOk" runat="server" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </td>
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>


<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ContactInformation.ascx.cs" Inherits="JobSeeker_Forms_ContactInformation" %>
<link href="../../Style.css" rel="stylesheet" />
<table >
    <tr>
        <td colspan="2">&nbsp;</td>
    </tr>
    <tr>
        <td colspan="2"><h1>Contact Information</h1></td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblaltmob" runat="server" Text="Alternate Mobile No"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtAltNo" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblLandno" runat="server" Text="Landline No"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtLandno" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblWhatapp" runat="server" Text="Whats app No"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtWhatsappNo" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblLinkedIn" runat="server" Text="LinkedIn Profile Link"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtLinkedIn" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblFacebook" runat="server" Text="Facebook Profile Link"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtFacebook" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblTwitter" runat="server" Text="Twitter Profile Link"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtTwitter" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblGTalk" runat="server" Text="GTalk Profile Id"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtGTalk" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblSkype" runat="server" Text="Skype Id"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtSkype" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="Label1" runat="server" Text="Google+ Profile Link"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtGooglePlus" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" Width="132px" />
        </td>
        <td >
            <asp:Button ID="Button2" runat="server" Text="Cancel" Width="115px" />
        </td>
    </tr>
</table>

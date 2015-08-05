<%@ Control Language="C#" AutoEventWireup="true" CodeFile="contactInfo.ascx.cs" Inherits="contactInfo" %>
<style type="text/css">
    .style1
    {
        width: 100px;
    }
</style>
<h2>
    Contact Information</h2>
<br />
<div>
    <table class="style1" cellpadding="5px" cellspacing="5px" frame="border" dir="ltr"
        width="100%">
        <tr>
            <td width="40%" align="left" valign="top">
                <asp:Label ID="lblaltmob" runat="server" Text="Alternate Mobile No"></asp:Label>
            </td>
            <td width="60%" align="left" valign="top">
                <asp:TextBox ID="txtAltNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="40%" align="left" valign="top">
                <asp:Label ID="lblLandno" runat="server" Text="Landline No"></asp:Label>
            </td>
            <td width="60%" align="left" valign="top">
                <asp:TextBox ID="txtLandno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="40%" align="left" valign="top">
                <asp:Label ID="lblWhatapp" runat="server" Text="Whats app No"></asp:Label>
            </td>
            <td width="60%" align="left" valign="top">
                <asp:TextBox ID="txtWhatsappNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="40%" align="left" valign="top">
                <asp:Label ID="lblLinkedIn" runat="server" Text="LinkedIn Profile Link"></asp:Label>
            </td>
            <td width="60%" align="left" valign="top">
                <asp:TextBox ID="txtLinkedIn" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="40%" align="left" valign="top">
                <asp:Label ID="lblFacebook" runat="server" Text="Facebook Profile Link"></asp:Label>
            </td>
            <td width="60%" align="left" valign="top">
                <asp:TextBox ID="txtFacebook" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="40%" align="left" valign="top">
                <asp:Label ID="lblTwitter" runat="server" Text="Twitter Profile Link"></asp:Label>
            </td>
            <td width="60%" align="left" valign="top">
                <asp:TextBox ID="txtTwitter" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="40%" align="left" valign="top">
                <asp:Label ID="lblGTalk" runat="server" Text="GTalk Profile Id"></asp:Label>
            </td>
            <td width="60%" align="left" valign="top">
                <asp:TextBox ID="txtGTalk" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="40%" align="left" valign="top">
                <asp:Label ID="lblSkype" runat="server" Text="Skype Id"></asp:Label>
            </td>
            <td width="60%" align="left" valign="top">
                <asp:TextBox ID="txtSkype" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="40%" align="left" valign="top">
                <asp:Label ID="Label1" runat="server" Text="Google+ Profile Link"></asp:Label>
            </td>
            <td width="60%" align="left" valign="top">
                <asp:TextBox ID="txtGooglePlus" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="40%" align="left" valign="top">
                <asp:Button ID="Button1" runat="server" Text="Save" Width="132px" OnClick="Button1_Click" />
            </td>
            <td width="60%" align="left" valign="top">
                <asp:Button ID="Button2" runat="server" Text="Cancel" Width="115px" />
            </td>
        </tr>
    </table>
</div>

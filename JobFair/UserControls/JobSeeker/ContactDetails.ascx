<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContactDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.ContactDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

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
            <asp:TextBox ID="txtAltNo" runat="server" ></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" runat="server" WatermarkText="Alternate Number" TargetControlID="txtAltNo"  />
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblLandno" runat="server" Text="Landline No"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtLandno" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender2" runat="server" WatermarkText="Landline No" TargetControlID="txtLandno" />
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblWhatapp" runat="server" Text="Whats App No"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtWhatsappNo" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender3" runat="server" WatermarkText="Whatsapp Number" TargetControlID="txtWhatsappNo"  />
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblLinkedIn" runat="server" Text="LinkedIn Profile Link"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtLinkedIn" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender4" runat="server" WatermarkText="LinkedIn ID" TargetControlID="txtLinkedIn" />
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblFacebook" runat="server" Text="Facebook Profile Link"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtFacebook" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender5" runat="server" WatermarkText="Facebook ID" TargetControlID="txtFacebook" />
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblTwitter" runat="server" Text="Twitter Profile Link"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtTwitter" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender6" runat="server" WatermarkText="Twitter ID" TargetControlID="txtTwitter" />
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblGTalk" runat="server" Text="GTalk Profile Id"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtGTalk" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender7" runat="server" WatermarkText="GTalk ID" TargetControlID="txtGTalk" />
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblSkype" runat="server" Text="Skype Profile Id"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtSkype" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender8" runat="server" WatermarkText="Skype ID" TargetControlID="txtSkype"/>
        </td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblGooglePlus" runat="server" Text="Google+ Profile Link"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtGooglePlus" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender9" runat="server" WatermarkText="GooglePlus ID" TargetControlID="txtGooglePlus"  />
        </td>
    </tr>
    <tr>
        <td >
            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" Width="132px" />
        </td>
        <td >
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="115px" />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
</table>

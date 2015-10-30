<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContactDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.ContactDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
 <script src="../../Scripts/jquery-2.1.4.min.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />

<div class="container">
    <div class="table">
    <table>
    <tr>
        <td colspan="2">&nbsp;</td>
    </tr>
    <tr>
        <td colspan="2"><h1>Contact Information</h1></td>
    </tr>
    <tr>
        <td >
           <span>Alternate Mobile No</span> 
        </td>
        <td >
            <asp:TextBox ID="txtAltNo" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
           <span>Landline No</span>
        </td>
        <td >
            <asp:TextBox ID="txtLandno" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
           <span>Whats App No</span> 
        </td>
        <td >
            <asp:TextBox ID="txtWhatsappNo" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
           <span>LinkedIn Profile Link</span>
        </td>
        <td >
            <asp:TextBox ID="txtLinkedIn" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
           <span>Facebook Profile Link</span>
        </td>
        <td >
            <asp:TextBox ID="txtFacebook" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
           <span>Twitter Profile Link</span>
        </td>
        <td >
            <asp:TextBox ID="txtTwitter" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
           <span>GTalk Profile Id</span>
        </td>
        <td >
            <asp:TextBox ID="txtGTalk" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
            <span>Skype Profile Id</span>
        </td>
        <td >
            <asp:TextBox ID="txtSkype" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >
           <span>Google+ Profile Link</span> 
        </td>
        <td >
            <asp:TextBox ID="txtGooglePlus" runat="server"></asp:TextBox>
        </td>
    </tr>
        <tr>
            <td><br /></td>
        </tr>
    <tr>
        <td >
            <asp:Button ID="btnSave" runat="server" CssClass="btn-success" OnClick="btnSave_Click" Text="Save" />
        </td>
        <td >
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn-danger"/>
        </td>
    </tr>
</table>
        </div>
    </div>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RecruiterForgetPwd.ascx.cs" Inherits="JobFair.Forms.Recruiter.RecruiterForgetPwd" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<link href="../../Style.css" rel="stylesheet" type="text/css" />

<table >
    <tr>
        <td >&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblUidMail" runat="server" Text="Enter Your Email Id/User Id"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUidMail" runat="server"></asp:TextBox>
            <cc1:TextBoxWatermarkExtender ID="txtUidMail_TextBoxWatermarkExtender" runat="server" BehaviorID="txtUidMail_TextBoxWatermarkExtender" TargetControlID="txtUidMail" WatermarkText="Please enter mail Id">
            </cc1:TextBoxWatermarkExtender>
        </td>
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </td>
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    </table>



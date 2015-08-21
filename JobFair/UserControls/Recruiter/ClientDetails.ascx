<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClientDetails.ascx.cs" Inherits="JobFair.Forms.Recruiter.ClientDetails" %>


<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<link href="../../Style.css" rel="stylesheet" />

<table  >
    <tr>
        <td colspan="2"><h1>Client Details</h1></td>
        
    </tr>
    <tr>
        <td >Client Name</td>
        <td >
            <asp:TextBox ID="txtClientName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Industry</td>
        <td>
            <asp:DropDownList ID="ddlIndustry" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td >Functional Area</td>
        <td>
            <asp:TextBox ID="txtFunctionalArea" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Location</td>
        <td>
            <asp:DropDownList ID="ddlLocation" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td >Official Email Id</td>
        <td>
            <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
            <cc1:TextBoxWatermarkExtender ID="txtEmailId_TextBoxWatermarkExtender" runat="server" BehaviorID="txtEmailId_TextBoxWatermarkExtender" TargetControlID="txtEmailId" WatermarkText="Official mail id">
            </cc1:TextBoxWatermarkExtender>
        </td>
    </tr>
    <tr>
        <td >Website</td>
        <td>
            <asp:TextBox ID="txtWebsite" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Official Contact</td>
        <td>
            <asp:TextBox ID="txtOfficialContact" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Official Address</td>
        <td>
            <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Agreement Date</td>
        <td>
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <cc1:TextBoxWatermarkExtender ID="TextBox8_TextBoxWatermarkExtender" runat="server" BehaviorID="TextBox8_TextBoxWatermarkExtender" TargetControlID="TextBox8" WatermarkText="From Date">
            </cc1:TextBoxWatermarkExtender>
            <cc1:CalendarExtender ID="TextBox8_CalendarExtender" runat="server" BehaviorID="TextBox8_CalendarExtender" TargetControlID="TextBox8" />
        </td>
    </tr>
    <tr>
        <td >Due Date</td>
        <td>
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            <cc1:CalendarExtender ID="TextBox9_CalendarExtender" runat="server" BehaviorID="TextBox9_CalendarExtender" TargetControlID="TextBox9" />
            <cc1:TextBoxWatermarkExtender ID="TextBox9_TextBoxWatermarkExtender" runat="server" BehaviorID="TextBox9_TextBoxWatermarkExtender" TargetControlID="TextBox9" WatermarkText="Due Date">
            </cc1:TextBoxWatermarkExtender>
        </td>
    </tr>
    <tr>
        <td >Payment Details</td>
        <td>
            <asp:CheckBoxList ID="chklistPaymentDetails" runat="server" AutoPostBack="True">
                <asp:ListItem>Self</asp:ListItem>
                <asp:ListItem>Candidate</asp:ListItem>
                <asp:ListItem>Both</asp:ListItem>
            </asp:CheckBoxList>
        </td>
    </tr>
    <tr>
        <td >Payment Terms</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </td>
    </tr>
</table>



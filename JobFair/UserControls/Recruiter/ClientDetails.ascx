<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClientDetails.ascx.cs" Inherits="JobFair.Forms.Recruiter.ClientDetails" %>


<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1"  %>

<link href="../../Style.css" rel="stylesheet" />

<table  >
    <tr>
        <td colspan="2"><h1>
            Client Details</h1></td>
        
    </tr>
    <tr>
        <td >Client Name</td>
        <td >
            <asp:TextBox ID="txtClientName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Industry<br />
            Functional Area</td>
        <td>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlIndustry" runat="server" OnSelectedIndexChanged="ddlIndustry_SelectedIndexChanged">
                    </asp:DropDownList>
                    <br />
                    <asp:DropDownList ID="ddlFunctionalArea" runat="server"  AutoPostBack="True" >
                    </asp:DropDownList>
                    
                    <asp:TextBox ID="txtAddfunctionalarea" runat="server" Visible="false" ></asp:TextBox><asp:Button ID="btnAdd" runat="server" Text="Add" Visible="false" OnClick="btnAdd_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td >Country<br />
            State<br />
            City</td>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlCountry" runat="server" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                    <br />
                    <asp:DropDownList ID="ddlState" runat="server" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                    <br />
                    <asp:DropDownList ID="ddlCity" runat="server">
                    </asp:DropDownList>
                </ContentTemplate>
            </asp:UpdatePanel>
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
            <asp:TextBox ID="txtWebsite" runat="server" ></asp:TextBox>
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
            <asp:TextBox ID="txtAgreementdate" runat="server"></asp:TextBox>
            <cc1:TextBoxWatermarkExtender ID="txtAgreementdate_TextBoxWatermarkExtender" runat="server" BehaviorID="TextBox8_TextBoxWatermarkExtender" TargetControlID="txtAgreementdate" WatermarkText="From Date">
            </cc1:TextBoxWatermarkExtender>
            <cc1:CalendarExtender ID="txtAgreementdate_CalendarExtender" runat="server" BehaviorID="TextBox8_CalendarExtender" TargetControlID="txtAgreementdate" />
        </td>
    </tr>
    <tr>
        <td >Due Date</td>
        <td>
            <asp:TextBox ID="txtDueDate" runat="server"></asp:TextBox>
            <cc1:CalendarExtender ID="txtDueDate_CalendarExtender" runat="server" BehaviorID="TextBox9_CalendarExtender" TargetControlID="txtDueDate" />
            <cc1:TextBoxWatermarkExtender ID="txtDueDate_TextBoxWatermarkExtender" runat="server" BehaviorID="TextBox9_TextBoxWatermarkExtender" TargetControlID="txtDueDate" WatermarkText="Due Date">
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
        <td>
            <asp:TextBox ID="txtPaymentTerms" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td>
            <%--<asp:Button ID="btnSubmit" runat="server" Text="Submit"  />--%>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click1" Text="Submit" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </td>
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td>
            <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
</table>



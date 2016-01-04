<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientDetails.aspx.cs" Inherits="JobFair.Forms.HR.ClientDetails" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Css/Style.css" rel="stylesheet" />
    <link href="../../Css/Common.css" rel="stylesheet" />
</head>
<body>
    <form id="ClientDetails" runat="server">
        <div id="divMain" runat="server" style="min-height: 500px; padding: 10px">

    <center><h2>
        Client Details
    </h2></center>
        <table style="margin-left: 10px">
            <tr>
                <td><asp:Label ID="lblClientName" runat="server" Text=" Client Name " CssClass="label"></asp:Label></td>
                <td>
                   <asp:DropDownList ID="ddlClientName" runat="server"></asp:DropDownList> 
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblIndustry" runat="server" Text=" Industry " CssClass="label"></asp:Label></td>
                <td>
                   <asp:DropDownList ID="ddlIndustry" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblFunctionalArea" runat="server" Text=" Functional Area " CssClass="label"></asp:Label></td>
                <td>
                 <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                    <br />
                    <asp:DropDownList ID="ddlFunctionalArea" runat="server"  AutoPostBack="True" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlFunctionalArea_SelectedIndexChanged" >
                    </asp:DropDownList>
                    
                    <asp:TextBox ID="txtAddfunctionalarea" runat="server" Visible="false" ></asp:TextBox><asp:Button ID="btnAdd" runat="server" Text="Add" Visible="false" OnClick="btnAdd_Click" />
                    <asp:Label ID="lblmsg2" runat="server" Text="Label"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblAddress" runat="server" Text=" Address " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </td>
            </tr>           
            <tr>
                <td><asp:Label ID="lblCountry" runat="server" Text=" Country " CssClass="label"></asp:Label></td>
                <td>
                   <asp:DropDownList ID="ddlCountry" runat="server" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblState" runat="server" Text=" State " CssClass="label"></asp:Label></td>
                <td>
                   <asp:DropDownList ID="ddlState" runat="server" OnSelectedIndexChanged="ddlState_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>            
            <tr>
                <td><asp:Label ID="lblCity" runat="server" Text=" City " CssClass="label"></asp:Label></td>
                <td>
                   <asp:DropDownList ID="ddlCity" runat="server" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblArea" runat="server" Text=" Area " CssClass="label"></asp:Label></td>
                <td>
                   <asp:DropDownList ID="ddlArea" runat="server"></asp:DropDownList>
                </td>
            </tr> 
            <tr>
                <td><asp:Label ID="lblPincode" runat="server" Text=" Pincode " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtPincode" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td><asp:Label ID="lblOfficialMail" runat="server" Text=" Official Mail " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtOfficialMail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblWebsite" runat="server" Text=" Website " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="Website" runat="server"></asp:TextBox>
                </td>
            </tr>            
            <tr>
                <td><asp:Label ID="lblOfficialContact" runat="server" Text=" Official Contact " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtOfficialContact" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblActive" runat="server" Text=" Active / InActive " CssClass="label"></asp:Label></td>
                <td>
                    <asp:RadioButtonList ID="rbtlistActive" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>Active</asp:ListItem>
                    <asp:ListItem>Inactive</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblAgreementDate" runat="server" Text=" Agreement Date " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtAgreementDate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblDueDate" runat="server" Text=" Due Date " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtDueDate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblPaymentDetails" runat="server" Text=" Payment Details " CssClass="label"></asp:Label></td>
                <td>
                    <asp:CheckBoxList ID="chklistPaymentDetails" runat="server">
                    <asp:ListItem>Self</asp:ListItem>
                    <asp:ListItem>Candidate</asp:ListItem>
                    <asp:ListItem>Both</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblPaymentTerms" runat="server" Text=" Payment Terms " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtPaymentTerms" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblPercentageAmount" runat="server" Text=" Percentage Amount " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtPercentageAmount" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="button" OnClick="btnSubmit_Click"/>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="button" OnClick="btnSubmit_Click" OnClientClick="this.form.reset();return false;"/>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

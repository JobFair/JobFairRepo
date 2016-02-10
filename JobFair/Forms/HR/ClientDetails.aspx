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
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div id="divMain" runat="server" style="min-height: 500px; padding: 10px">

    <h2 style="align-content:center">
        Client Details
    </h2>
        <table style="margin-left: 10px">
            <tr>
                <td><asp:Label ID="lblClientName" runat="server" Text=" Client Name " CssClass="label"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtClientName" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td><asp:Label ID="lblClientProfile" runat="server" Text=" Client Profile " CssClass="label"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtClientProfile" runat="server" TextMode="MultiLine"></asp:TextBox>
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
                 <asp:UpdatePanel ID="uppnlAddfunctionalarea" runat="server">
                    <ContentTemplate>
                        <asp:DropDownList ID="ddlFunctionalArea" runat="server" AutoPostBack="True" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlFunctionalArea_SelectedIndexChanged" >
                        </asp:DropDownList>
                        <asp:TextBox ID="txtAddfunctionalarea" runat="server" Visible="false" ></asp:TextBox>
                        <asp:Button ID="btnAdd" runat="server" Text="Add" Visible="false" OnClick="btnAdd_Click" />
                        <asp:Label ID="lblmsg2" runat="server"></asp:Label>
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
                   <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblState" runat="server" Text=" State " CssClass="label"></asp:Label></td>
                <td>
                   <asp:DropDownList ID="ddlState" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" ></asp:DropDownList>
                </td>
            </tr>            
            <tr>
                <td><asp:Label ID="lblCity" runat="server" Text=" City " CssClass="label"></asp:Label></td>
                <td>
                   <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblArea" runat="server" Text=" Area " CssClass="label"></asp:Label></td>
                <td>
                   <asp:DropDownList ID="ddlArea" runat="server" AutoPostBack="True"></asp:DropDownList>
                </td>
            </tr> 
            <tr>
                <td><asp:Label ID="lblPincode" runat="server" Text=" Pincode " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtPincode" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td><asp:Label ID="lblOfficialEMailId" runat="server" Text=" Official E-Mail " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtOfficialEMailId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblWebsite" runat="server" Text=" Website " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtWebsite" runat="server"></asp:TextBox>
                </td>
            </tr>            
            <tr>
                <td><asp:Label ID="lblOfficialContact" runat="server" Text=" Official Contact " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtOfficialContact" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblStatus" runat="server" Text=" Status " CssClass="label"></asp:Label></td>
                <td>
                    <asp:RadioButtonList ID="rbtlistStatus" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Value="1" Text="Active"></asp:ListItem>
                    <asp:ListItem Value="0" Text="Inactive"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblAgreementDate" runat="server" Text=" Agreement Date " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtAgreementDate" runat="server" TextMode="Date"></asp:TextBox>
                   <%--<ajax:CalendarExtender ID="caltxtAgreementDate" runat="server" PopupButtonID="txtAgreementDate" TargetControlID="txtAgreementDate" Format="dd/MM/yyyy" />--%>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblDueDate" runat="server" Text=" Due Date " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtDueDate" runat="server" TextMode="Date"></asp:TextBox>
                   <%--<ajax:CalendarExtender ID="caltxtDueDate" runat="server" PopupButtonID="txtDueDate" TargetControlID="txtDueDate" Format="dd/MM/yyyy" />--%>
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
                <asp:Label ID="lblPayment" runat="server" Visible="false"></asp:Label>
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
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="button" OnClick="btnUpdate_Click" Visible="false"/>
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="button" OnClick="btnCancel_Click" OnClientClick="this.form.reset();return false;"/>
                </td>  
                <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
            </tr>
        </table>
    </div>



<div id="divView" runat="server" style="min-height: 500px; padding: 10px" visible="false">

    <h2 style="align-content:center">
        Client Details
    </h2>
        <table style="margin-left: 10px; width: 350px;">
           <%-- <asp:HiddenField ID="hfClientId" runat="server" db="<%#Eval("ClientId")%>" />
            <asp:HiddenField ID="hfHrId" runat="server" db="<%#Eval("HrId")%>" />--%>
             <asp:Label ID="lblClientId" runat="server" Text='<%#Eval("ClientId")%>' Visible="false" />
            <asp:Label ID="lblHrId" runat="server" Text='<%#Eval("HrId")%>' Visible="false" />
            <tr>
                <td>Client Name</td>
                <td>
                    <asp:Label ID="lblViewClientName" runat="server" Text='<%#Eval("ClientName")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
             <tr>
                <td colspan="1">Client Profile</td>
                <td>
                    <asp:Label ID="lblViewClientProfile" runat="server" Text='<%#Eval("ClientProfile")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Industry</td>
                <td>
                    <asp:Label ID="lblViewIndustry" runat="server" Text='<%#Eval("IndustryName")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Functional Area</td>
                <td>
                    <asp:Label ID="lblViewFunctionalArea" runat="server" Text='<%#Eval("FunctionalArea")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Address</td>
                <td>
                    <asp:Label ID="lblViewAddress" runat="server" Text='<%#Eval("Address")%>' CssClass="label"></asp:Label>
                </td>
            </tr>           
            <tr>
                <td>Country</td>
                <td>
                    <asp:Label ID="lblViewCountry" runat="server" Text='<%#Eval("CountryName")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>State</td>
                <td>
                    <asp:Label ID="lblViewState" runat="server" Text='<%#Eval("StateName")%>' CssClass="label"></asp:Label>
                </td>
            </tr>            
            <tr>
                <td>City</td>
                <td>
                    <asp:Label ID="lblViewCity" runat="server" Text='<%#Eval("CityName")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Area</td>
                <td>
                    <asp:Label ID="lblViewArea" runat="server" Text='<%#Eval("AreaName")%>' CssClass="label"></asp:Label>
                </td>
            </tr> 
            <tr>
                <td>Pincode</td>
                <td>
                    <asp:Label ID="lblViewPincode" runat="server" Text='<%#Eval("Pincode")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
             <tr>
                <td>Official E-Mail</td>
                <td>
                    <asp:Label ID="lblViewOfficialEMail" runat="server" Text='<%#Eval("OfficialEmailId")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Website</td>
                <td>
                    <asp:Label ID="lblViewWebsite" runat="server" Text='<%#Eval("Website")%>' CssClass="label"></asp:Label>
                </td>
            </tr>            
            <tr>
                <td>Official Contact</td>
                <td>
                    <asp:Label ID="lblViewOfficialContact" runat="server" Text='<%#Eval("OfficialContact")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Status</td>
                <td>
                    <asp:Label ID="lblViewStatus" runat="server" Text='<%#Eval("Status")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Agreement Date</td>
                <td>
                    <asp:Label ID="lblViewAgreementDate" runat="server" Text='<%#Eval("AgreementDate")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Due Date</td>
                <td>
                    <asp:Label ID="lblViewDueDate" runat="server" Text='<%#Eval("DueDate")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Payment Details</td>
                <td>
                    <asp:Label ID="lblViewPaymentDetails" runat="server" Text='<%#Eval("PaymentDetails")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Payment Terms</td>
                <td>
                    <asp:Label ID="lblViewPaymentTerms" runat="server" Text='<%#Eval("PaymentTerms")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Percentage Amount</td>
                <td>
                    <asp:Label ID="lblViewPercentageAmount" runat="server" Text='<%#Eval("PercentageAmount")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
       </table>
  </div>
</form>
</body>
</html>

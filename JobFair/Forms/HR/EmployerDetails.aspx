<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployerDetails.aspx.cs" Inherits="JobFair.Forms.HR.EmployerDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="../../Css/Style.css" rel="stylesheet" />
    <link href="../../Css/Common.css" rel="stylesheet" />
</head>
<body>
    <form id="EmployerDetails" runat="server">
    <div id="divMain" runat="server" style="min-height: 500px; padding: 10px">

    <h2 style="align-content:center">
        Employer Details
    </h2>
        <table style="margin-left: 10px">
            <tr>
                <td><asp:Label ID="lblCompany" runat="server" Text=" Company " CssClass="label"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtCompany" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td><asp:Label ID="lblFullName" runat="server" Text=" Employer’s HR Full Name " CssClass="label"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtFullName" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblContactNo" runat="server" Text=" Company contact number " CssClass="label"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtContactNo" runat="server" TextMode="Phone"></asp:TextBox>
                </td>
            </tr>
            <%--<%--<tr>
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
               <%-- </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblDueDate" runat="server" Text=" Due Date " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtDueDate" runat="server" TextMode="Date"></asp:TextBox>
                   <%--<ajax:CalendarExtender ID="caltxtDueDate" runat="server" PopupButtonID="txtDueDate" TargetControlID="txtDueDate" Format="dd/MM/yyyy" />--%>
               <%-- </td>
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
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="button" OnClick="btnSubmit_Click" OnClientClick="this.form.reset();return false;"/>
                </td>  
                <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
            </tr>--%>
        </table>
    </div>
    </form>
</body>
</html>

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RecruiterRegistration.ascx.cs" Inherits="JobFair.UserControls.Recruiter.RecruiterRegistration" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<table border="0">
    <tr>
        <td colspan="2" >
            <h1>Recruiter Registration</h1>
        </td>
    </tr>
    <tr>
        <td >Recruiters Full Name</td>
        <td>
            <asp:TextBox ID="txtFullName"  runat="server"></asp:TextBox>
           
        </td>
    </tr>
    <tr>
        <td >Company</td>
        <td>
            <asp:TextBox ID="txtCompany"  runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Mobile No</td>
        <td>
            <asp:TextBox ID="txtMobNo" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter 10 digit mobile number" ValidationExpression="[0-9]{10}" ControlToValidate="txtMobNo">*</asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td >Official Email Id</td>
        <td>
            <asp:TextBox ID="txtOffEmailid" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >City</td>
        <td>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Password</td>
        <td>
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Confirm Password</td>
        <td>
            <asp:TextBox ID="txtConPassword" TextMode="Password" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConPassword" ErrorMessage="Password is not matching with above password">*</asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td >Photo</td>
        <td>
            <asp:FileUpload ID="FileUploadRecruiterPhoto" runat="server" />
        </td>
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td>
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
</table>
    
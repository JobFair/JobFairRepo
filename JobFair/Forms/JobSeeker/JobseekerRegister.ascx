<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="JobseekerRegister.ascx.cs" Inherits="JobFair.Forms.JobSeeker.JobseekerRegister" %>
<table >
    <tr>
        <td colspan="4" >
            <h2><b>Logos Solutions</b></h2>
&nbsp;</td>
    </tr>
    <tr>
        <td >
            <asp:Label ID="lblName" runat="server" Text="First Name"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
        </td>
        <td >
            <asp:Label ID="lblName0" runat="server" Text="Last Name"></asp:Label>
        </td>
        <td >
            <asp:TextBox ID="txtLastname" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td  colspan="2">
            <asp:Label ID="lblMailid" runat="server" Text="Email Id"></asp:Label>
        </td>
        <td colspan="2">
            <asp:TextBox ID="txtMailid" runat="server"></asp:TextBox>
            <asp:Label ID="lblerrorMail" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td  colspan="2">Gender</td>
        <td>
            <asp:RadioButtonList ID="rdoGender" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="1">Female</asp:ListItem>
                <asp:ListItem Value="2">Male</asp:ListItem>
            </asp:RadioButtonList>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="rdoGender" ErrorMessage="Select your Gender"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td  colspan="2">
            <asp:Label ID="lblMobNo" runat="server" Text="Mobile No"></asp:Label>
        </td>
        <td colspan="2">
            <asp:TextBox ID="txtMobno" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td  colspan="2">
            <asp:Label ID="City" runat="server" BackColor="White" EnableTheming="True" EnableViewState="False" Text="Current City"></asp:Label>
        </td>
        <td colspan="2">
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td  colspan="2">
            <asp:Label ID="Label2" runat="server" Text="Current Address"></asp:Label>
        </td>
        <td colspan="2">
            <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td  colspan="2">
            <asp:Label ID="lblpwd" runat="server" Text="Password"></asp:Label>
            &nbsp;&nbsp; </td>
        <td colspan="2">
            <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td  colspan="2">
            <asp:Label ID="lblConpwd" runat="server" Text="Confirm Password"></asp:Label>
        </td>
        <td colspan="2">
            <asp:TextBox ID="txtConpwd" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td  colspan="2">
            <asp:Label ID="lblResume" runat="server" Text="Upload Resume"></asp:Label>
        </td>
        <td colspan="2">
            <div>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </div>
        </td>
    </tr>
    <tr>
        <td  colspan="2">&nbsp;</td>
        <td colspan="2">
            <asp:Button ID="btnRegister" runat="server" class="animation" onclick="btnRegister_Click" OnClientClick="Validation()" Text="Register" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </td>
    </tr>
</table>


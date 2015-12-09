<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" CodeBehind="Register.aspx.cs" Inherits="JobFair.Forms.JobSeeker.JobSeekerRegister" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<script  type="text/javascript" src="../../Scripts/ValidationAll.js"></script>

    <div class="container">
        <div class="jumbotron">
            <h1>Register</h1>
        </div> 
    <div>

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    &nbsp;</td>
            </tr>

            <tr>
                <td>First name</td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server" onblur="return CheckOnlyChar(this.id);"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtFirstName"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server" onblur="return CheckOnlyChar(this.id);"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtLastName"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Email Id</td>
                <td>
                    <asp:TextBox ID="txtEmailId" runat="server" onblur="return IsValidEmail(this.id);"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEmailId" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtEmailId"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revEmailId" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtEmailId" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvGender" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="rblGender"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Mobile No</td>
                <td>
                    <asp:TextBox ID="txtMobileNo" runat="server" onblur="return IsValidMobNumber(this.id);"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvMobileNo" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtMobileNo"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" placeholder="Password" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Password'"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Confirm Password</td>
                <td>
                    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" placeholder="Confirm Password" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Confirm Password'"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvConfirmPassword" runat="server" ErrorMessage="Password does not match" ForeColor="Red" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>Current City</td>
                <td>
                    <asp:TextBox ID="txtCurrCity" runat="server" onblur="return CheckOnlyChar(this.id);"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCurrentCity" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtCurrCity"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Current Address</td>
                <td>
                    <asp:TextBox ID="txtCurrAddress" runat="server" TextMode="MultiLine" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCurrentAddress" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtCurrAddress"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Upload Resume</td>
                <td>
                    <asp:FileUpload ID="FileUploadResume" runat="server" />
                    <asp:RequiredFieldValidator ID="rfvUploadResume" runat="server" ErrorMessage="Please upload your resume" ForeColor="Red" ControlToValidate="FileUploadResume"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Reference Id<br />
                    (If any)</td>
                <td>
                    <asp:TextBox ID="txtRefCandidateId" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revRefCandidateId" runat="server" ErrorMessage="Please Enter Valid Candidate Mail Id" ForeColor="Red" ControlToValidate="txtRefCandidateId" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
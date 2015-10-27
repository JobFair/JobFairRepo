<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Forms/JobSeeker/Home.Master" CodeBehind="Register.aspx.cs" Inherits="JobFair.Forms.JobSeeker.JobSeekerRegister" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="jumbotron">
            <h1>Register</h1>
        </div>
        <div class="row">
            <div class="col-md-4">
                First name
            </div>
            <div class="col-md-4">
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            Last Name
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-4">
            Email Id
        </div>
        <div class="col-lg-4">
            <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-4">
            Gender
        </div>
        <div class="col-lg-4">
            <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>

    <div>

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    <img alt="" src="../../Images/L1-whte.jpg" /></td>
            </tr>

            <tr>
                <td></td>
               
            </tr>
            <tr>
                <td></td>
               
            </tr>
            <tr>
                <td>Mobile No</td>
                <td>
                    <asp:TextBox ID="txtMobileNo" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvMobileNo" runat="server" ErrorMessage="Enter your mobile number" ForeColor="#FF3300" ControlToValidate="txtMobileNo">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" placeholder="Password" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Password'"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Enter your password" ForeColor="#FF3300" ControlToValidate="txtPassword">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Confirm Password</td>
                <td>
                    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" placeholder="Confirm Password" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Confirm Password'"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password does not match" ForeColor="#FF3300" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>Current City</td>
                <td>
                    <asp:TextBox ID="txtCurrCity" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCurrentCity" runat="server" ErrorMessage="Enter your city" ForeColor="#FF3300" ControlToValidate="txtCurrCity">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Current Address</td>
                <td>
                    <asp:TextBox ID="txtCurrAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCurrentAddress" runat="server" ErrorMessage="Enter your address" ForeColor="#FF3300" ControlToValidate="txtCurrAddress">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Upload Resume</td>
                <td>
                    <asp:FileUpload ID="FileUploadResume" runat="server" />
                    <asp:RequiredFieldValidator ID="rfvUploadResume" runat="server" ErrorMessage="Please upload your resume" ForeColor="#FF3300" ControlToValidate="FileUploadResume">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Reference Id<br />
                    (If any)</td>
                <td>
                    <asp:TextBox ID="txtRefCandidateId" runat="server"></asp:TextBox>
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
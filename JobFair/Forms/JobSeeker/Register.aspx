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
                    <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtFirstName" ValidationGroup="vgRegister"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server" onblur="return CheckOnlyChar(this.id);"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtLastName" ValidationGroup="vgRegister"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Email Id</td>
                <td>
                    <asp:TextBox ID="txtEmailId" runat="server" onblur="return IsValidEmail(this.id);"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEmailId" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtEmailId" ValidationGroup="vgRegister"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revEmailId" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtEmailId" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vgRegister"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvGender" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="rblGender" ValidationGroup="vgRegister"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Mobile No</td>
                <td>
                    <asp:TextBox ID="txtMobileNo" runat="server" onblur="return IsValidMobNumber(this.id);"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvMobileNo" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtMobileNo" ValidationGroup="vgRegister"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" placeholder="Password" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Password'"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtPassword" ValidationGroup="vgRegister"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Confirm Password</td>
                <td>
                    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" placeholder="Confirm Password" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Confirm Password'"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtPassword" ValidationGroup="vgRegister"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvConfirmPassword" runat="server" ErrorMessage="Password does not match" ForeColor="Red" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ValidationGroup="vgRegister"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>Current Address</td>
                <td>
                    <asp:TextBox ID="txtCurrAddress" runat="server" TextMode="MultiLine" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCurrentAddress" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtCurrAddress" ValidationGroup="vgRegister"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Country<br />
                    State<br />
                    City<br />
                    City Area</td>
                <td>
                    <asp:UpdatePanel ID="pnlPresentAddress" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlCountryPresent" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCountryPresent_SelectedIndexChanged">
                    </asp:DropDownList><br />
                    <asp:RequiredFieldValidator ID="rfvCountryPresent" runat="server" ControlToValidate="ddlCountryPresent" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

                    <asp:DropDownList ID="ddlStatePresent" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlStatePresent_SelectedIndexChanged">
                    </asp:DropDownList><br />
                    <asp:RequiredFieldValidator ID="rfvStatePresent" runat="server" ControlToValidate="ddlStatePresent" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

                    <asp:DropDownList ID="ddlCityPresent" runat="server" OnSelectedIndexChanged="ddlCityPresent_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList><br />
                    <asp:RequiredFieldValidator ID="rfvCityPresent" runat="server" ControlToValidate="ddlCityPresent" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

                    <asp:DropDownList ID="ddlAreaPresent" runat="server">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvAreaPresent" runat="server" ControlToValidate="ddlAreaPresent" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </ContentTemplate>
            </asp:UpdatePanel></td>
            </tr>
            <tr>
                <td>Pin Code</td>
                <td>
                    <asp:TextBox ID="txtPincode" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Upload Resume</td>
                <td>
                    <asp:FileUpload ID="FileUploadResume" runat="server" />
                    <asp:RequiredFieldValidator ID="rfvUploadResume" runat="server" ErrorMessage="Please upload your resume" ForeColor="Red" ControlToValidate="FileUploadResume" ValidationGroup="vgRegister"></asp:RequiredFieldValidator>
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
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" ValidationGroup="vgRegister" />
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
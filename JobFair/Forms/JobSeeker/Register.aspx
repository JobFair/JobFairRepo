<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="JobFair.Forms.JobSeeker.JobSeekerRegister" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .c {
            color: gray;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

            <table class="auto-style1">
                <tr>
                    <td colspan="2">
                        <img alt="" class="auto-style2" src="../../Images/L1-whte.jpg" /></td>
                </tr>
                <tr>
                    <td>First Name</td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" runat="server" TargetControlID="txtFirstName" WatermarkText="First Name" WatermarkCssClass="c" />
                        <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ErrorMessage="Enter your first name" ForeColor="#FF3300" ControlToValidate="txtFirstName">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Last Name</td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender2" runat="server" TargetControlID="txtLastName" WatermarkText="Last Name" WatermarkCssClass="c" />
                        <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ErrorMessage="Enter your Last Name" ForeColor="#FF3300" ControlToValidate="txtLastName">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Email Id</td>
                    <td>
                        <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender3" runat="server" TargetControlID="txtEmailId" WatermarkText="Enter Your Email" WatermarkCssClass="c" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmailId" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="EmailId is not in correct format">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Select Gender" ControlToValidate="rblGender" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Mobile No</td>
                    <td>
                        <asp:TextBox ID="txtMobileNo" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender5" runat="server" TargetControlID="txtMobileNo" WatermarkText="Mobile Number" WatermarkCssClass="c" />
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
                        <asp:TextBox ID="txtCurrCity" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender8" runat="server" WatermarkText="Enter City" TargetControlID="txtCurrCity" WatermarkCssClass="c" />
                        <asp:RequiredFieldValidator ID="rfvCurrentCity" runat="server" ErrorMessage="Enter your city" ForeColor="#FF3300" ControlToValidate="txtCurrCity">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Current Address</td>
                    <td>
                        <asp:TextBox ID="txtCurrAddress" runat="server" TextMode="MultiLine"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender9" runat="server" WatermarkText="Address" TargetControlID="txtCurrAddress" WatermarkCssClass="c" />
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
                        <asp:TextBox ID="txtRefCandidateId" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender10" runat="server" WatermarkText="Reference Mail Id" TargetControlID="txtRefCandidateId" WatermarkCssClass="c" />
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
       
    </form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterJobSeeker.aspx.cs" Inherits="JobFair.Forms.JobSeeker.RegisterJobSeeker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1"   runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    <img alt="" class="auto-style2" src="../../Images/L1-whte.jpg" /></td>
                
            </tr>
            <tr>
                <td>First Name</td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ErrorMessage="*" ForeColor="#FF3300" ControlToValidate="txtFirstName"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td >Last Name</td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ErrorMessage="*" ForeColor="#FF3300" ControlToValidate="txtLastName"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td >Email Id</td>
                <td>
                    <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmailId" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td >Desired User Name</td>
                <td>
                    <asp:TextBox ID="txtDesiredUserName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvDesiredUserName" runat="server" ErrorMessage="*" ForeColor="#FF3300" ControlToValidate="txtDesiredUserName"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td >Gender</td>
                <td>
                    <asp:RadioButtonList ID="rblGender" runat="server"  RepeatDirection="Horizontal">
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="rblGender" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td >Mobile No</td>
                <td>
                    <asp:TextBox ID="txtMobileNo" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvMobileNo" runat="server" ErrorMessage="*" ForeColor="#FF3300" ControlToValidate="txtMobileNo"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td >Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="*" ForeColor="#FF3300" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td >Confirm Password</td>
                <td>
                    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="*" ForeColor="#FF3300" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td >Current City</td>
                <td>
                    <asp:TextBox ID="txtCurrCity" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCurrentCity" runat="server" ErrorMessage="*" ForeColor="#FF3300" ControlToValidate="txtCurrCity"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td >Current Address</td>
                <td>
                    <asp:TextBox ID="txtCurrAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCurrentAddress" runat="server" ErrorMessage="*" ForeColor="#FF3300" ControlToValidate="txtCurrAddress"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td >Upload Resume</td>
                <td>
                    <asp:FileUpload ID="FileUploadResume" runat="server" />
                    <asp:RequiredFieldValidator ID="rfvUploadResume" runat="server" ErrorMessage="*" ForeColor="#FF3300" ControlToValidate="FileUploadResume"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td >&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td >&nbsp;</td>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Label ID="Label1" runat="server" Visible="true"></asp:Label>
                </td>
            </tr>
            
        </table>
    
    </div>
    </form>
</body>
</html>

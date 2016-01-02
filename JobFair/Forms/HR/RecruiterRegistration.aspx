<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecruiterRegistration.aspx.cs" Inherits="JobFair.Forms.HR.RecruiterRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="0">
    <tr>
        <td colspan="2" >
            <h1>
                &nbsp;Recruiter Registration</h1>
            <p>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </p>
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
                    <asp:DropDownList ID="ddlCountryCode" runat="server">
                    </asp:DropDownList>
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
        <td >Freelance/Employee</td>
        <td>
            <asp:RadioButton ID="rbtFreelance" runat="server" AutoPostBack="true" Text="Freelance" GroupName="FreelanceOREmployee" OnCheckedChanged="rbtFreelance_CheckedChanged" />
            <asp:RadioButton ID="rbtEmployee" runat="server" Text="Employee" AutoPostBack="true" GroupName="FreelanceOREmployee" OnCheckedChanged="rbtEmployee_CheckedChanged" />
            <br />
            <asp:Panel ID="PanelFreelance" runat="server" Visible="false">
                <asp:RadioButton ID="rbtAmount" runat="server" Text="Amount" AutoPostBack="true" OnCheckedChanged="rbtAmount_CheckedChanged" GroupName="FreelancerSalary" />
                &nbsp;Per Month&nbsp;<asp:TextBox ID="txtAmount" runat="server" AutoPostBack="true" Visible="false"></asp:TextBox>
                <br />
                <asp:RadioButton ID="rbtPercentagePerClosure" runat="server" AutoPostBack="true" Text="Percentage Per Closure" OnCheckedChanged="rbtPercentagePerClosure_CheckedChanged" GroupName="FreelancerSalary" />
                &nbsp;<asp:TextBox ID="txtPercentagePerClosure" runat="server" Visible="false"></asp:TextBox>
            </asp:Panel>
            <asp:Panel ID="PanelEmployee" runat="server" Visible="false">
                Salary
                <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td >Current Address</td>
        <td>
            <asp:TextBox ID="txtAddress" TextMode="MultiLine" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Present Address</td>
        <td>
            <asp:UpdatePanel ID="pnlPresentAddress" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlCountryPresent" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCountryPresent_SelectedIndexChanged">
                    </asp:DropDownList><br />
                   
                    <asp:DropDownList ID="ddlStatePresent" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlStatePresent_SelectedIndexChanged">
                    </asp:DropDownList><br />
                    
                    <asp:DropDownList ID="ddlCityPresent" runat="server" OnSelectedIndexChanged="ddlCityPresent_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList><br />
                   
                    <asp:DropDownList ID="ddlAreaPresent" runat="server">
                    </asp:DropDownList>
                  </ContentTemplate>
            </asp:UpdatePanel>&nbsp;</td>
    </tr>
    <tr>
        <td >PinCode</td>
        <td>
            <asp:TextBox ID="txtPincode" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Employment Status</td>
        <td>
            <asp:RadioButtonList ID="rbtlEmploymentStatus" runat="server">
                <asp:ListItem>Full Time</asp:ListItem>
                <asp:ListItem>Part Time</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td >Job Type</td>
        <td>
            <asp:RadioButtonList ID="rbtlJobType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rbtlJobType_SelectedIndexChanged">
                <asp:ListItem>Permanent</asp:ListItem>
                <asp:ListItem>Temporary</asp:ListItem>
                <asp:ListItem>Freelancing</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Panel ID="PanelTemporary" runat="server" Visible="false">
                Client/Emplyer Site
                <asp:TextBox ID="txtClientSite" runat="server"></asp:TextBox>
                <br />
                Client Name
                <asp:TextBox ID="txtClientName" runat="server"></asp:TextBox>
                
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td >PAN Card</td>
        <td>
            <asp:TextBox ID="txtPANCard" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Create Password</td>
        <td>
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Confirm Password</td>
        <td>
            <asp:TextBox ID="txtConPassword" TextMode="Password" runat="server"></asp:TextBox>
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
    
    </div>
    </form>
</body>
</html>

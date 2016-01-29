<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecruiterRegistration.aspx.cs" Inherits="JobFair.Forms.HR.RecruiterRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
             <link href="../../Css/bootstrap.min.css" rel="stylesheet" />
      <script src="../../Scripts/bootstrap.min.js"></script>
      <script src="../../Scripts/jquery.min.js"></script>
</head>
    <style>
        h1{
            text-align:center;
        }
        .form-group{
            padding-bottom:20px;
            padding-top:20px;
        }
        label{
            text-align:right;
        }
    </style>
<body>

    <form id="form1" runat="server">
    <div class="container">
    <!--<table border="0" >-->
    <tr>
        <td colspan="2" >
            <h1 class="aligned-center">
                &nbsp;Recruiter Registration</h1>
            <p>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </p>
        </td>
    </tr>
    <div class="form-group">
        <label class="col-lg-4">Recruiters Full Name</label>
        <div class="col-lg-6 ">
            <asp:TextBox ID="txtFullName"  runat="server" CssClass="form-control"></asp:TextBox>
           
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-4">Company</label>
        <div class="col-lg-6 ">
            <asp:TextBox ID="txtCompany"  runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
      
    <div class="form-group">
        <label class="col-lg-4">Official Contact No</label>
        <div class="col-lg-6">
                    <asp:TextBox ID="txtOfficialContact" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        </div>
   <div class="form-group">
        <label class="col-lg-4">Mobile No</label>
        <div class="col-lg-6">
                    <asp:DropDownList ID="ddlCountryCode" runat="server" CssClass="col-lg-6">
                    </asp:DropDownList>
            <asp:TextBox ID="txtMobNo" runat="server" CssClass="col-lg-4" ></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter 10 digit mobile number" ValidationExpression="[0-9]{10}" ControlToValidate="txtMobNo" >*</asp:RegularExpressionValidator>
        </div>
    </div>
       <div class="form-group">
        <label class="col-lg-4">Alternate Contact No</label>
        <div class="col-lg-6 ">
                    <asp:TextBox ID="txtAlternateContactNo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        </div>
   <div class="form-group">
        <label class="col-lg-4">Official Email ID</label>
        <div class="col-lg-6">
            <asp:TextBox ID="txtOffEmailid" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
        <div class="form-group">
        <label class="col-lg-4">Personal Email ID</label>
        <div class="col-lg-6 ">
            <asp:TextBox ID="txtPersonalMailid" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        </div>
    <div class="form-group">
        <label class="col-lg-4">Freelance/Employee</label>
        <div class="col-lg-6">
         <div class="col-lg-3">  <asp:RadioButton ID="rbtFreelance" runat="server" AutoPostBack="true" Text="Freelance" GroupName="FreelanceOREmployee" OnCheckedChanged="rbtFreelance_CheckedChanged" /> </div> 
          <div class="col-lg-3">  <asp:RadioButton ID="rbtEmployee" runat="server" Text="Employee" AutoPostBack="true" GroupName="FreelanceOREmployee" OnCheckedChanged="rbtEmployee_CheckedChanged" /> </div>
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
        </div>
    </div>
    <div class="form-group clearfix">
        <label class="col-lg-4">Current Address</label>
        <div class="col-lg-6">
            <asp:TextBox ID="txtAddress" TextMode="MultiLine" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
     <div class="form-group clearfix">
        <label class="col-lg-4">Present Address</label>
        <div class="col-lg-6 ">
            <asp:UpdatePanel ID="pnlPresentAddress" runat="server" CssClass="form-control">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlCountryPresent" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCountryPresent_SelectedIndexChanged" CssClass="form-control">
                    </asp:DropDownList><br />
                   
                    <asp:DropDownList ID="ddlStatePresent" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlStatePresent_SelectedIndexChanged" CssClass="form-control">
                    </asp:DropDownList><br />
                    
                    <asp:DropDownList ID="ddlCityPresent" runat="server" OnSelectedIndexChanged="ddlCityPresent_SelectedIndexChanged" AutoPostBack="True" CssClass="form-control">
                    </asp:DropDownList><br />
                   
                    <asp:DropDownList ID="ddlAreaPresent" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                  </ContentTemplate>
            </asp:UpdatePanel>&nbsp;</div>
    </div>
    <div class="form-group">
        <label class="col-lg-4">Pincode</label>
        <div class="col-lg-6">
            <asp:TextBox ID="txtPincode" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    
    <div class="form-group">
        <label class="col-lg-4">Employment Status</label>
        <div class="col-lg-6">
            <asp:RadioButtonList ID="rbtlEmploymentStatus" runat="server" CssClass="">
                <asp:ListItem class="col-lg-12">Full Time</asp:ListItem>
                <asp:ListItem >Part Time</asp:ListItem>
            </asp:RadioButtonList>
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-4">Job Type</label>
        <div class="col-lg-6 form-control">
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
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-4">PAN Card</label>
        <div class="col-lg-6 ">
            <asp:TextBox ID="txtPANCard" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-4">Create Password</label>
        <div class="col-lg-6 ">
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
   <div class="form-group">
        <label class="col-lg-4">Confirm Password</label>
        <div class="col-lg-6 ">
            <asp:TextBox ID="txtConPassword" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
    </div>
    <div class="form-group">
        <label class="col-lg-4">Photo</label>
        <div class="col-lg-6 ">
            <asp:FileUpload ID="FileUploadRecruiterPhoto" runat="server" CssClass="form-control"/>
        </div>
    </div>
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

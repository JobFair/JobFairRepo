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
                <td><asp:Label ID="lblCompanyName" runat="server" Text=" Company Name" CssClass="label"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtCompanyName" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td><asp:Label ID="lblEmployerHRFullName" runat="server" Text=" Employer’s HR Full Name " CssClass="label"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtEmployerHRFullName" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblCompanyContactNo" runat="server" Text=" Company contact number " CssClass="label"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtCompanyContactNo" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblMobileNumber" runat="server" Text=" Mobile Number " CssClass="label"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtMobileNumber" runat="server" TextMode="Number"></asp:TextBox>
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
                   <asp:dropdownlist id="ddlState" runat="server" autopostback="true" onselectedindexchanged="ddlState_SelectedIndexChanged" ></asp:dropdownlist>
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
                   <asp:TextBox ID="txtPincode" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td><asp:Label ID="lblOfficialEMailId" runat="server" Text=" Official E-Mail " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtOfficialEMailId" runat="server" TextMode="Email"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblPassword" runat="server" Text=" Create a Password for Login " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>            
            <tr>
                <td><asp:Label ID="lblConfirmPassword" runat="server" Text=" Confirm the Password for Login " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
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
                <td><asp:Label ID="lblPhoto" runat="server" Text=" Photo " CssClass="label"></asp:Label></td>
                <td>
                    <asp:FileUpload ID="FileUploadPhoto" runat="server" />
                    <asp:Image ID="imgPersonalPhoto" runat="server" Height="100px" Width="100px" ImageAlign="Top" Visible="false" />
                    <asp:LinkButton ID="lnkbtnEdit" runat="server" OnClick="lnkbtnEdit_Click" Visible="false">Edit Photo</asp:LinkButton>
                    <asp:LinkButton ID="lnkbtnCancel" runat="server" Visible="false" OnClick="lnkbtnCancel_Click">Cancel</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="button" OnClick="btnSubmit_Click"/>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="button" OnClick="btnUpdate_Click" Visible="false"/>
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="button" OnClick="btnCancel_Click" OnClientClick="this.form.reset();return false;"/>
                </td>  
                <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
            </tr>
        </table>
    </div>


    <div id="divView" runat="server" style="min-height: 500px; padding: 10px" visible="false">
    <h2 style="align-content:center">
        Employer Details
    </h2>
        <table style="margin-left: 10px; width: 350px;">
           <%-- <asp:HiddenField ID="hfClientId" runat="server" db="<%#Eval("ClientId")%>" />
            <asp:HiddenField ID="hfHrId" runat="server" db="<%#Eval("HrId")%>" />--%>
             <asp:Label ID="lblEmployerId" runat="server" Text='<%#Eval("EmployerId")%>' Visible="false" />
            <asp:Label ID="lblHrId" runat="server" Text='<%#Eval("HrId")%>' Visible="false" />
            <tr>
                <td>Company Name</td>
                <td>
                    <asp:Label ID="lblViewCompanyName" runat="server" Text='<%#Eval("CompanyName")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
             <tr>
                <td colspan="1">Employer's HR Full Name</td>
                <td>
                    <asp:Label ID="lblViewEmployerHRFullName" runat="server" Text='<%#Eval("EmployerHRFullName")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Company Contact No</td>
                <td>
                    <asp:Label ID="lblViewCompanyContactNo" runat="server" Text='<%#Eval("CompanyContactNumber")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Mobile Number</td>
                <td>
                    <asp:Label ID="lblViewMobileNumber" runat="server" Text='<%#Eval("MobileNumber")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Address</td>
                <td>
                    <asp:Label ID="lblViewAddress" runat="server" Text='<%#Eval("Address")%>' CssClass="label"></asp:Label>
                </td>
            </tr>           
            <tr>
                <td>Country</td>
                <td>
                    <asp:Label ID="lblViewCountry" runat="server" Text='<%#Eval("CountryName")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>State</td>
                <td>
                    <asp:Label ID="lblViewState" runat="server" Text='<%#Eval("StateName")%>' CssClass="label"></asp:Label>
                </td>
            </tr>            
            <tr>
                <td>City</td>
                <td>
                    <asp:Label ID="lblViewCity" runat="server" Text='<%#Eval("CityName")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Area</td>
                <td>
                    <asp:Label ID="lblViewArea" runat="server" Text='<%#Eval("AreaName")%>' CssClass="label"></asp:Label>
                </td>
            </tr> 
            <tr>
                <td>Pincode</td>
                <td>
                    <asp:Label ID="lblViewPincode" runat="server" Text='<%#Eval("Pincode")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
             <tr>
                <td>Official E-Mail</td>
                <td>
                    <asp:Label ID="lblViewOfficialEMail" runat="server" Text='<%#Eval("OfficialEmailId")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Status</td>
                <td>
                    <asp:Label ID="lblViewStatus" runat="server" Text='<%#Eval("Status")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Photo</td>
                <td>
                    <asp:Label ID="lblViewPhoto" runat="server" Text='<%#Eval("Photo")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Created Date</td>
                <td>
                    <asp:Label ID="lblViewCreatedDate" runat="server" Text='<%#Eval("CreatedDate")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Modified Date</td>
                <td>
                    <asp:Label ID="lblViewModifiedDate" runat="server" Text='<%#Eval("ModifiedDate")%>' CssClass="label"></asp:Label>
                </td>
            </tr>
       </table>
  </div>
    </form>
</body>
</html>

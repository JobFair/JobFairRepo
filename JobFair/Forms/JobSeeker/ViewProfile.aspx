<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="JobFair.Forms.JobSeeker.ViewProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <table>
            <tr>
                <td>
                    <asp:Image ID="imgCandidate" runat="server" />
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                </td>
            </tr>
            <tr>
                <td>Candidate Name
                </td>
                <td>
                    <asp:Label ID="lblName" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>EmailId
                </td>
                <td>
                    <asp:Label ID="lblEmailId" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Contact details
                </td>
                <td>
                    <div id="divContact" runat="server" visible="false">
                        <asp:TextBox ID="txtContact" runat="server">
                        </asp:TextBox>
                        <asp:Button ID="btnOk" runat="server" Text="Ok" OnClick="btnOk_Click" />
                    </div>
                    <asp:Label ID="lblContact" runat="server" Text="contact"></asp:Label>

                    <asp:LinkButton ID="lbEditContact" runat="server" OnClick="lbEditContact_Click">Edit</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td>Education
                </td>
                <td>
                    <asp:Label ID="lblEducation" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">Last Upadated on
                    <asp:Label ID="lblLastupdated" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    <br />
    ----------------------------------------------------------------------------------------------------------------------------------------------------
    <asp:UpdatePanel ID="upSkills" runat="server">
        <ContentTemplate>
            <div id="Skills" runat="server">

            <table>
                <tr>
                    <td colspan="3">
                        <b>Resume Title & Key skills</b>
                    </td>
                </tr>
                <tr>
                    <td>Resume Title
                        <br />
                        Key Skills<br />
                        <br />
                    </td>
                    <td>
                        <div id="divLabelSkills" runat="server">
                            <asp:Label ID="lblResumeTitle" runat="server"></asp:Label>
                            <br />
                            <asp:Label ID="lblSkills" runat="server"></asp:Label>
                            <br />
                            <asp:Button runat="server" ID="btnResumeskills" Text="Update" OnClick="btnResumeskills_Click" />
                        </div>
                    </td>
                    <td>
                        <div id="divTextSkills" runat="server" visible="false">
                            <asp:TextBox ID="txtResumeTitle" runat="server"></asp:TextBox>
                            <br />
                            <asp:TextBox ID="txtkeyskills" runat="server"></asp:TextBox>
                            <br />
                            <asp:Button ID="btnAddResumeSkills" runat="server" Text="Add" OnClick="btnAddResumeSkills_Click" />
                            <asp:Button ID="btnCancelResumeSkills" runat="server" Text="Cancel" OnClick="btnCancelResumeSkills_Click" />
                        </div>
                    </td>
                </tr>
            </table>
        </div>
        </ContentTemplate>
    </asp:UpdatePanel>   
     

    <br />
    <asp:UpdatePanel ID="upLocation" runat="server">
        <ContentTemplate>
<div id="Location" runat="server">

        <div id="divLabelLocation" runat="server">
            <table>
                <tr>
                    <td colspan="2"><b>Location</b></td>
                </tr>
                <tr>
                    <td>Current Location
                    </td>
                    <td>
                        <asp:Label ID="lblCurrentLocation" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Preferred Location
                    </td>
                    <td>
                        <asp:Label ID="lblPreferredLoaction" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnLoaction" runat="server" Text="Update" OnClick="btnLoaction_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <div id="divTexBoxtLocation" runat="server" visible="false">
            <table>
                <tr>
                    <td colspan="2"><b>Location</b></td>
                </tr>
                <tr>
                    <td>Current Location
                    </td>
                    <td>
                        <asp:TextBox ID="txtCurrentLocation" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Preferred Location
                    </td>
                    <td>
                        <asp:TextBox ID="txtPreferredLoacation" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnAddLocation" runat="server" Text="Add" OnClick="btnAddLocation_Click" />
                        <asp:Button ID="btnCancelLocation" runat="server" Text="Cancel" OnClick="btnCancelLocation_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
<div id="PersonalDetails" runat="server">

        <div id="divLabelPersonal" runat="server">
            <table>
                <tr>
                    <td colspan="2">
                        <b>Personal Details</b>
                    </td>
                </tr>
                <tr>
                    <td>Name
                    </td>
                    <td>
                        <asp:Label ID="lblName1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>EmailId for communication</td>
                    <td>
                        <asp:Label ID="lblCommunicationEmailId" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Login Mail Id</td>
                    <td>
                        <asp:Label ID="lblLoginMailId" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Mobile No
                    </td>
                    <td>
                        <asp:Label ID="lblMobileNo" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Age
                    </td>
                    <td>
                        <asp:Label ID="lblAge" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Address
                    </td>
                    <td>
                        <asp:Label ID="lblAdress" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnUpdatePersonal" runat="server" Text="Update" OnClick="btnUpdatePersonal_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <div id="divTextBoxPersonal" runat="server" visible="false">
            <table>
                <tr>
                    <td colspan="2">
                        <b>Personal Details</b>
                    </td>
                </tr>
                <tr>
                    <td>Name
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>EmailId for communication</td>
                    <td>
                        <asp:TextBox ID="txtComEmailid" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Login Mail Id</td>
                    <td>
                        <asp:TextBox ID="txtLoginmailId" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mobile No
                    </td>
                    <td>
                        <asp:TextBox ID="txtMobileNo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Age
                    </td>
                    <td>
                        <asp:TextBox ID="txtAgeDate" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Address
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnAddPersonal" runat="server" Text="Add" OnClick="btnAddPersonal_Click" />
                        <asp:Button ID="btnCancelPersonal" runat="server" Text="Cancel" OnClick="btnCancelPersonal_Click" />
                    </td>
                </tr>
            </table>
        </div>

        <br />
    </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
    
    <asp:UpdatePanel ID="upEmployerDetails" runat="server">
        <ContentTemplate>
<div id="EmployerDetails" runat="server">
    <div id="divLabelEmployer" runat="server">
        <table>
            <tr>
                <td colspan="2">
                    <b>Employement Details</b>
                </td>
            </tr>
            <tr>
                <td>Work Experience
                </td>
                <td>
                    <asp:Label ID="lblWorkexperience" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Current Employer
                </td>
                <td>
                    <asp:Label ID="lblCurrentEmployer" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Designation
                </td>
                <td>
                    <asp:Label ID="lblDesignationCurrent" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Annual Salary
                </td>
                <td>
                    <asp:Label ID="lblAnnualSalary" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Last Employer
                </td>
                <td>
                    <asp:Label ID="lblLastEmployer1" runat="server"></asp:Label>
                    as
                <asp:Label ID="lblDesignation1" runat="server"></asp:Label>
                    <br />
                    from
                    <asp:Label ID="lblTotalExp1" runat="server"></asp:Label>

                    <br />

                    <br />
                    <asp:Label ID="lblLastEmployer2" runat="server"></asp:Label>
                    as
                    <asp:Label ID="lblDesignation2" runat="server"></asp:Label>
                    <br />
                    from
                    <asp:Label ID="lblTotalExp2" runat="server"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblLastEmployer3" runat="server"></asp:Label>
                    as
                    <asp:Label ID="lblDesignation3" runat="server"></asp:Label>
                    <br />
                    from
                    <asp:Label ID="lblTotalExp3" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnUpdateEmployerDetails" runat="server" Text="Update" OnClick="btnUpdateEmployerDetails_Click" />
                </td>
            </tr>
        </table>
        </div>
    <div id="divTextBoxEmployer" runat="server" visible="false">
        <table>
            <tr>
                <td colspan="2">
                    <b>Employement Details</b>
                </td>
            </tr>
            <tr>
                <td>Work Experience
                </td>
                <td>
                    <asp:TextBox ID="txtWorkExp" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Current Employer
                </td>
                <td>
                    <asp:TextBox ID="txtCurrentEmployer" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Designation
                </td>
                <td>
                    <asp:TextBox ID="txtDesignationCurrent" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Annual Salary
                </td>
                <td>
                    <asp:TextBox ID="txtAnnualSalary" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Last Employer
                </td>
                <td>

                    <asp:LinkButton ID="lbPreviousEmployment" runat="server" OnClick="lbPreviousEmployment_Click">AddPreviousEmployment</asp:LinkButton>
<div id="divPreviousEmployment" runat="server" visible="false">
    <table>
        <tr>
            <td>
                Company
            </td>
            <td>
                <asp:TextBox ID="txtCompany1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Designation
            </td>
            <td>
                <asp:TextBox ID="txtDesignation1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Duration
            </td>
            <td>
                <asp:TextBox ID="txtDuration" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
</div>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnAddEmployerDetails" runat="server" OnClick="btnAddEmployerDetails_Click" Text="Add" />
                    <asp:Button ID="btnCancelEmployerDetails" runat="server" Text="Cancel" OnClick="btnCancelEmployerDetails_Click" />
                </td>
            </tr>
        </table>
    </div>
    </div>
        </ContentTemplate>
    </asp:UpdatePanel>    
    <br />
    <asp:UpdatePanel ID="upEducational" runat="server">
        <ContentTemplate>
    <div id="EducationDetails" runat="server">
        <div id="divLabelEducation" runat="server">
        <table>
            <tr>
<td colspan="2">
    <b>Educational Details</b>
</td>
            </tr>
            <tr>
                <td>
                    Qualification1
                </td>
                <td>
                    <asp:Label ID="lblQualification1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    Qualification2
                </td>
                <td>
                    <asp:Label ID="lblQualification2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
               <td colspan="2"> <asp:Button ID="btnUpdateEducation" runat="server" Text="Update" /></td>
            </tr>
        </table>
    </div>
        <br />
        <div id="divTextBoxQualification" runat="server">
            <table>
                <tr>
<td colspan="2"> <b>Educational Details</b></td>
                </tr>
                <tr>
                    <td>

                        Graduation</td>
                    <td>
                        <asp:DropDownList ID="ddlGraduation" runat="server"></asp:DropDownList>                       
                    </td>
                </tr>
                <tr>
                    <td>
                        Passing Year
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlPassingYearGraduate" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Post Graduation
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlPostGraduation1" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Passing Year
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlPassingYearPostGraduate1" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        PG Diploma
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlPgDiploma" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Passing Year
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlPGDiplomaPassingYear1" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        UG Diploma
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlUGDiploma1" runat="server"></asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
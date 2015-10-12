<%@ Page Title="" Language="C#"  AutoEventWireup="true" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" CodeBehind="ViewProfile.aspx.cs" Inherits="JobFair.Forms.JobSeeker.ViewProfile" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div>

        <table>
            <tr>
                <td>
                    <asp:Image ID="imgCandidate" ImageUrl='<%#Eval("JS12","~/Images/{0}") %>' runat="server" />
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                   
                </td>
            </tr>
            <tr>
                <td>Candidate Name
                </td>
                <td>
                    <asp:Label ID="lblFullName" runat="server"></asp:Label>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>EmailId
                </td>
                <td>
                    <asp:Label ID="lblEmailId" runat="server" Text='<%#Eval("EmailId") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Contact details
                </td>
                <td>
                    <div id="divContact" runat="server" visible="false">
                        <asp:TextBox ID="txtContact" runat="server" CausesValidation="true" Text='<%#Eval("MobileNo") %>'>
                        </asp:TextBox>
                        <asp:Button ID="btnOk" runat="server" Text="Ok" OnClick="btnOk_Click" />
                    </div>
                    <asp:Label ID="lblContact" runat="server" Text='<%#Eval("MobileNo") %>'></asp:Label>

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
                            <td>Login Mail Id</td>
                            <td>
                                <asp:Label ID="lblLoginMailId" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Birth Date</td>
                            <td>
                                <asp:Label ID="lblBirthDate" runat="server"></asp:Label>
                                &nbsp;
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
                                <asp:TextBox ID="txtFirstNamePersonalDetails"  CausesValidation="true" AutoPostBack="true" runat="server"></asp:TextBox>
                                <asp:TextBox ID="txtLastNamePersonalDetails" CausesValidation="true"  runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Login Mail Id</td>
                            <td>
                                <asp:TextBox ID="txtLoginmailId" CausesValidation="true" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Birth Date</td>
                            <td>
                                <asp:TextBox ID="txtBirthdate" CausesValidation="true" runat="server"></asp:TextBox>
                                <cc1:CalendarExtender ID="txtBirthdate_CalendarExtender" runat="server" BehaviorID="txtBirthdate_CalendarExtender" TargetControlID="txtBirthdate" />
                            </td>
                        </tr>
                        <tr>
                            <td>Address
                            </td>
                            <td>
                                <asp:TextBox ID="txtAddress" runat="server" CausesValidation="true" TextMode="MultiLine"></asp:TextBox>
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
                            <td>Expected Salary</td>
                            <td><asp:Label ID="lblExpectedSalary" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Company Type</td>
                            <td><asp:Label ID="lblCompanyType" runat="server"></asp:Label></td>
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
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
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
                            <td>Expected Salary</td>
                            <td>
                                <asp:TextBox ID="txtExpectedAnualSalary" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Company Type</td>
                            <td>
                                <asp:DropDownList ID="ddlCompanyType" runat="server">
                                    <asp:ListItem>Select</asp:ListItem>
                                    <asp:ListItem>Small</asp:ListItem>
                                    <asp:ListItem>Middle</asp:ListItem>
                                    <asp:ListItem>MNC</asp:ListItem>
                                </asp:DropDownList>
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
                                            <td>Company
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtCompany1" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>Designation
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtDesignation1" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>Duration
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtDuration" runat="server"></asp:TextBox>
                                                &nbsp;</td>
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
                            <td>Qualification1
                            </td>
                            <td>
                                <asp:Label ID="lblQualification1" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Qualification2
                            </td>
                            <td>
                                <asp:Label ID="lblQualification2" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="btnUpdateEducation" runat="server" Text="Update" OnClick="btnUpdateEducation_Click" /></td>
                        </tr>
                    </table>
                </div>
                <br />
                <div id="divTextBoxEducation" runat="server" visible="false">
                    <table>
                        <tr>
                            <td colspan="2"><b>Educational Details</b></td>
                        </tr>
                        <tr>
                            <td>Graduation</td>
                            <td>
                                <asp:DropDownList ID="ddlGraduation" runat="server"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Passing Year
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlPassingYearGraduate" runat="server"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Percentage / Grade
                            </td>
                            <td>
                                <asp:TextBox ID="txtGraduationPercentage1" runat="server"></asp:TextBox>
                                OR
                        <asp:TextBox ID="txtGraduationGrade1" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        </caption>
                <caption>
                    <br />
                    <br />
                    <tr>
                        <td>Post Graduation </td>
                        <td>
                            <asp:DropDownList ID="ddlPostGraduation1" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Passing Year </td>
                        <td>
                            <asp:DropDownList ID="ddlPassingYearPostGraduate1" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Percentage/ Grade </td>
                        <td>
                            <asp:TextBox ID="txtPGPercentage1" runat="server"></asp:TextBox>
                            OR
                            <asp:TextBox ID="txtPGGrade1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>PG Diploma </td>
                        <td>
                            <asp:DropDownList ID="ddlPgDiploma" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Passing Year </td>
                        <td>
                            <asp:DropDownList ID="ddlPGDiplomaPassingYear1" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Percentage/Grade </td>
                        <td>
                            <asp:TextBox ID="txtPGDiplomaPercentage1" runat="server"></asp:TextBox>
                            OR
                            <asp:TextBox ID="txtPGDiplomaGrade1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>UG Diploma </td>
                        <td>
                            <asp:DropDownList ID="ddlUGDiploma1" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>PassingYear </td>
                        <td>
                            <asp:DropDownList ID="ddlPGDiplomaPassingYear" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Percentage/Grade </td>
                        <td>
                            <asp:TextBox ID="txtUGDiplomaPercentage1" runat="server"></asp:TextBox>
                            OR
                            <asp:TextBox ID="txtUGDiplomaGrade1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>H.S.C. </td>
                        <td>
                            <asp:DropDownList ID="ddlHSCSpecialization" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Passing Year </td>
                        <td>
                            <asp:DropDownList ID="ddlHSCPassingYear" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Percentage/Grade </td>
                        <td>
                            <asp:TextBox ID="txtHSCPercentage" runat="server"></asp:TextBox>
                            OR
                            <asp:TextBox ID="txtHSCGrade" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>S.S.C. </td>
                        <td>
                            <asp:DropDownList ID="ddlSSCMedium" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Percentage/Grade </td>
                        <td>
                            <asp:TextBox ID="txtSSCPercentage" runat="server"></asp:TextBox>
                            OR
                            <asp:TextBox ID="txtSSCGrade" runat="server"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="btnAddEduaction" runat="server" Text="Add" OnClick="btnAddEduaction_Click" />
                            <asp:Button ID="btnCancelEducation" runat="server" Text="Cancel" OnClick="btnCancelEducation_Click" />
                        </td>
                    </tr>
                    </table>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
    <asp:UpdatePanel ID="upProjectDetails" runat="server">
        <ContentTemplate>
            <div id="ProjectDetails" runat="server">
                <div id="divLabelProjectDetails" runat="server">
                    <table>
                        <tr>
                            <td colspan="2">
                                <b>Project Details
                                </b>
                            </td>
                        </tr>
                        <tr>
                            <td>Project 1
                            </td>
                            <td>
                                <asp:Label ID="lblProjectName" runat="server"></asp:Label>
                                &nbsp;In
            <asp:Label ID="lblCompName" runat="server"></asp:Label>
                                &nbsp;for<br />
                                &nbsp;
            <asp:Label ID="lblClientName1" runat="server"></asp:Label>
                                &nbsp;with
            <asp:Label ID="lblSkillsUsed" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="btnUpdateProject" runat="server" Text="Update" OnClick="btnUpdateProject_Click" />
                            </td>
                        </tr>
                    </table>
                </div>
                <br />
                <div id="divTextBoxProjectDetails" runat="server" visible="false">
                    <table>
                        <tr>
                            <td colspan="2">
                                <b>Project Details</b>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblCompanyName" runat="server" Text="Company Name"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtCompanyName" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblClientName" runat="server" Text="Client Name"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtClientName" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblProjectTitle" runat="server" Text="Project Title"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtProjectTitle" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblDuration" runat="server" Text="Duration"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtFormDate" runat="server"></asp:TextBox><cc1:CalendarExtender ID="CalendarExtender1" runat="server" PopupButtonID="txtFormDate" TargetControlID="txtFormDate" Format="dd/MM/yyyy" />
                                &nbsp; To&nbsp;&nbsp;
            <asp:TextBox ID="txtToDate" runat="server"></asp:TextBox><cc1:CalendarExtender ID="CalendarExtender2" runat="server" PopupButtonID="txtToDate" TargetControlID="txtToDate" Format="dd/MM/yyyy" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblLocation" runat="server" Text="Project Location"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtProjectLocation" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblEmpType" runat="server" Text="Employment Type"></asp:Label>
                            </td>
                            <td>
                                <asp:RadioButton ID="rbtFulTime" runat="server" GroupName="EmpoymentType" Text="Full Time" />
                                <asp:RadioButton ID="rbtPartTme" runat="server" GroupName="EmpoymentType" Text="Part Time" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblProjectDetails" runat="server" Text="Project Details"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtProjectDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblRole" runat="server" Text="Role"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlRole" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblTeamSize" runat="server" Text="Team Size"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlTeamSize" runat="server">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                    <asp:ListItem>6</asp:ListItem>
                                    <asp:ListItem>7</asp:ListItem>
                                    <asp:ListItem>8</asp:ListItem>
                                    <asp:ListItem>9</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                                    <asp:ListItem>11</asp:ListItem>
                                    <asp:ListItem>12</asp:ListItem>
                                    <asp:ListItem>13</asp:ListItem>
                                    <asp:ListItem>14</asp:ListItem>
                                    <asp:ListItem>15</asp:ListItem>
                                    <asp:ListItem>16</asp:ListItem>
                                    <asp:ListItem>17</asp:ListItem>
                                    <asp:ListItem>18</asp:ListItem>
                                    <asp:ListItem>19</asp:ListItem>
                                    <asp:ListItem>20</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblSkill" runat="server" Text="Skill Used"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtSkill" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="btnAddProject" runat="server" Text="Add" OnClick="btnAddProject_Click" />
                                <asp:Button ID="btnCancelProject" runat="server" Text="Cancel" OnClick="btnCancelProject_Click" />
                                <br />
                                <asp:LinkButton ID="lbAddmoreProject1" runat="server" OnClick="lbAddmoreProject1_Click">Add More Project</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
    <asp:UpdatePanel ID="upIndustry" runat="server">
        <ContentTemplate>
            <div id="Industry" runat="server">
                <div id="divLabelIndustry" runat="server">
                    <table>
                        <tr>
                            <td colspan="2">
                                <b>Industry</b>
                            </td>
                        </tr>
                        <tr>
                            <td>Current Industry
                            </td>
                            <td>
                                <asp:Label ID="lblCurrentIndustry" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Desired Industry
                            </td>
                            <td>
                                <asp:Label ID="lblDesiredIndustry" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="btnUpdateIndustry" runat="server" Text="Update" OnClick="btnUpdateIndustry_Click" />
                            </td>
                        </tr>
                    </table>
                </div>
                <br />
                <div id="divTextBoxIndustry" runat="server" visible="false">
                    <table>
                        <tr>
                            <td colspan="2">
                                <b>Industry</b>
                            </td>
                        </tr>
                        <tr>
                            <td>Current Industry
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlCurrentIndustry" runat="server"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Desired Industry
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlDesiredIndustry" runat="server"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="btnAddIndustry" runat="server" Text="Add" OnClick="btnAddIndustry_Click" />
                                <asp:Button ID="btnCancelIndustry" runat="server" Text="Cancel" OnClick="btnCancelIndustry_Click" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdatePanel ID="upResume" runat="server">
        <ContentTemplate>
            <div id="Resume" runat="server"></div>
            <table>
                <tr>
                    <td colspan="2">
                        <b>
                            Resume Details
                        </b>
                    </td>
                </tr>
                <tr>
                    <td>
                        Upload Fresh New Resume
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUploadResume" runat="server" />
                        <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:TextBox ID="txtResume" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
    





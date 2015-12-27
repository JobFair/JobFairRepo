<%@ Page Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="JSViewProfile.aspx.cs" Inherits="JobFair.Forms.JobSeeker.JSViewProfile" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
        });
    </script>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <%-- <div class="container">
            <h2>Complete Your Profile</h2>
            <ul class="nav nav-tabs">
                <li class="active"><a data-toggle="tab" href="#menu0">Profile Summary</a></li>
                <li><a data-toggle="tab" href="#menu6">Personal Details</a>
                    <ul class="nav nav-tab">
                        <li><a data-toggle="tab" href="#menu7">Contact Details</a></li>
                        <li><a data-toggle="tab" href="#menu8">Personal Details</a></li>
                        <li><a data-toggle="tab" href="#menu9">Affirmative Details</a></li>
                    </ul>
                </li>

                <li><a data-toggle="tab" href="#menu2">Professional Details</a></li>
                <li><a data-toggle="tab" href="#menu3">Technical Details</a></li>
                <li><a data-toggle="tab" href="#menu4">Project Details</a></li>
                <li><a data-toggle="tab" href="#menu5">Educational Details</a></li>
            </ul>

            <div class="tab-content">
                <div id="menu0" class="tab-pane fade in active">
                    <h3>Profile Summary</h3>
                    <table><tr><td></td><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Image ID="imgProfilePhoto" runat="server" Height="100px" Width="100px" ImageAlign="Top" />&nbsp;</td></tr><tr><td>Name</td><td><asp:Label ID="lblName" runat="server"></asp:Label></td></tr><tr><td>Candidate ID (Reference ID)</td><td><asp:Label ID="lblCandidateID" runat="server"  data-toggle="tooltip" data-placement="right" title="Use this ID to refer your friend for job!" ></asp:Label></td></tr><tr><td>Primary Email ID</td><td><asp:Label ID="lblEmailId" runat="server"></asp:Label></td></tr><tr><td>Primary Mobile No</td><td><asp:Label ID="lblMobNo" runat="server"></asp:Label></td></tr><tr><td>Gender</td><td><asp:Label ID="lblGender" runat="server"></asp:Label></td></tr><tr><td>Higest Qualification</td><td><asp:Label ID="lblQualification" runat="server"></asp:Label></td></tr><tr><td>Work Status</td><td><asp:Label ID="lblWorkStatus" runat="server"></asp:Label></td></tr><tr><td>Total Experience</td><td><asp:Label ID="lblExperience" runat="server"></asp:Label></td></tr><tr><td>Current City</td><td><asp:Label ID="lblCurrentCity" runat="server"></asp:Label></td></tr><tr><td>Prefered City</td><td><asp:Label ID="lblPreferedCity" runat="server"></asp:Label></td></tr><tr><td>Current CTC</td><td><asp:Label ID="lblCurrentCTC" runat="server"></asp:Label></td></tr><tr><td>Expected CTC</td><td><asp:Label ID="lblExpectedCTC" runat="server"></asp:Label></td></tr><tr><td>Notice Period</td><td><asp:Label ID="lblNoticePeriod" runat="server"></asp:Label></td></tr><tr><td>Availability for the Personal Round on Working Day</td><td><asp:Label ID="lblInterview" runat="server"></asp:Label></td></tr><tr><td>Availabilty in Week Days(Monday to Friday)</td><td><asp:Label ID="lblAvailabilityInWeek" runat="server"></asp:Label></td></tr><tr><td>Job Post looking for</td><td><asp:Label ID="lblJobPostLooking" runat="server"></asp:Label></td></tr><tr><td>Employee Status</td><td><asp:Label ID="lblEmployeeStatus" runat="server"></asp:Label></td></tr><tr><td>Job Type</td><td><asp:Label ID="lblJobType" runat="server"></asp:Label></td></tr><tr><td>Company Type</td><td><asp:Label ID="lblCompanyType" runat="server"></asp:Label></td></tr></table>
                </div>

                <div id="menu2" class="tab-pane fade">
                    <h3>Technical Skills</h3>
                </div>
                <div id="menu3" class="tab-pane fade">
                    <h3>Technical Skills Details</h3>
                    <asp:Repeater ID="rptrTechnicalSkills" runat="server"><HeaderTemplate><table width="500px" border="1px"><tr style="background-color: #fb7700"><td>Technical Skills</td><td>From Date</td><td>Till Date</td><td>Proficiency</td><td>Total Year</td></tr></HeaderTemplate><ItemTemplate><tr style="background-color: #ffffff"><td><asp:Label ID="lblTechnicalSkills" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "TechnicalSkillName")%>'></asp:Label></td><td><asp:Label ID="lblFromDate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "FromDate")%>'></asp:Label></td><td><asp:Label ID="lblTillDate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "TillDate")%>'></asp:Label></td><td><asp:Label ID="lblProficiency" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Proficiency")%>'></asp:Label></td><td><asp:Label ID="lblTotalYear" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "TotalYear")%>'></asp:Label></td></tr></ItemTemplate><FooterTemplate><tr style="background-color: #15880a"><td colspan="5"></FooterTemplate></asp:Repeater>
                </div>
                <div id="menu4" class="tab-pane fade">
                    <h3>Project Details</h3>
                    <asp:Repeater ID="rptrProjectDetails" runat="server"><HeaderTemplate><table border="1px"></HeaderTemplate><ItemTemplate><tr style="background-color: #ffffff"><td><table><tr><td>Project For </td><td><asp:Label ID="lblID" Visible="false" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectId") %>'></asp:Label><asp:Label ID="lblProjectFor" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectFor")%>'></asp:Label></td></tr><tr><td>Project Title</td><td><asp:Label ID="lblProjectTiltle" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectTitle")%>'></asp:Label></td></tr><tr><td>Company Name</td><td><asp:Label ID="lblCompanyName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "CompanyName")%>'></asp:Label></td></tr><tr><td>Role </td><td><asp:Label ID="lblRole" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "RoleName") %>'></asp:Label></td></tr><tr><td>Client Name </td><td><asp:Label ID="lblClientName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ClientName")%>'></asp:Label></td></tr><tr><td>Duration </td><td><asp:Label ID="lblDuration" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Duration")%>'></asp:Label></td></tr><tr><td>Project Location </td><td><asp:Label ID="lblProjectLocation" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectLocation")%>'></asp:Label></td></tr><tr><td>Employment Type </td><td><asp:Label ID="lblEmploymentType" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "EmploymentType")%>'></asp:Label></td></tr><tr><td>Project Details </td><td><asp:Label ID="lblProjectDetails" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectDetails")%>'></asp:Label></td></tr><tr><td>Roles and Responsibility </td><td><asp:Label ID="lblRolesandResponsibility" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "RolesandResponsibility")%>'></asp:Label></td></tr><tr><td>Team Size </td><td><asp:Label ID="lblTeamSize" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "TeamSize")%>'></asp:Label></td></tr><tr><td>Skill Used </td><td><asp:Label ID="lblSkillUsed" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "SkillUsed")%>'></asp:Label></td></tr><tr><td>Project Live </td><td><asp:Label ID="lblProjectLive" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectLive")%>'></asp:Label></td></tr><tr><td>Project Link </td><td><asp:Label ID="lblProjectLink" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectLink")%>'></asp:Label></td></tr><tr><td>Degree </td><td><asp:Label ID="lblDegree" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectLink")%>'></asp:Label></td></tr></table><tr><td colspan="2">&nbsp;</td></tr></ItemTemplate><FooterTemplate></table></FooterTemplate></asp:Repeater>
                </div>
                <div id="menu5" class="tab-pane fade">
                    <h3>Professional Details</h3>
                </div>

                  <div id="menu7" class="tab-pane fade">
                    <h3>Contact Details</h3>
                     <table><tr><td><span>Alternate Mobile No</span></td><td><asp:Label ID="lblAltMobNo" runat="server"></asp:Label></td></tr><tr><td><span>Landline No</span></td><td><asp:Label ID="lblLandLineNo" runat="server"></asp:Label></td></tr><tr><td><span>Whats App No</span></td><td><asp:Label ID="lblWhatsAppNo" runat="server"></asp:Label></td></tr><tr><td><span>LinkedIn Profile Link</span></td><td><asp:Label ID="lblLinkIn" runat="server"></asp:Label></td></tr><tr><td><span>Facebook Profile Link</span></td><td><asp:Label ID="lblFacebook" runat="server"></asp:Label></td></tr><tr><td><span>Twitter Profile Link</span>&nbsp;</td><td><asp:Label ID="lblTwitter" runat="server"></asp:Label></td></tr><tr><td><span>GTalk Profile Id</span></td><td><asp:Label ID="lblGtalk" runat="server"></asp:Label></td></tr><tr><td><span>Skype Profile Id</span></td><td><asp:Label ID="lblSkype" runat="server"></asp:Label></td></tr><tr><td><span>Google+ Profile Link</span></td><td><asp:Label ID="lblGooglePlus" runat="server"></asp:Label></td></tr></table>
                </div>
                  <div id="menu8" class="tab-pane fade">
                    <h3>Personal Details</h3>
                      <table>
                           <tr><td>Photo</td><td colspan="2"><asp:Image ID="Image1" runat="server" Height="100px" Width="100px" ImageAlign="Top" /></td></tr><tr><td rowspan="6">Address</td><td>Present Address</td><td><asp:Label ID="lblPresentAddress" runat="server"></asp:Label></td></tr><tr><td>Country</td><td><asp:Label ID="lblPresentCountry" runat="server"></asp:Label></td></tr><tr><td>State</td><td><asp:Label ID="lblPresentState" runat="server"></asp:Label></td></tr><tr><td>City</td><td><asp:Label ID="lblPresentCity" runat="server"></asp:Label></td></tr><tr><td>Area</td><td><asp:Label ID="lblPresentArea" runat="server"></asp:Label></td></tr><tr><td>Pincode</td><td><asp:Label ID="lblPresentPincode" runat="server"></asp:Label></td></tr><tr><td rowspan="6">Permanent Address</td><td>Address</td><td><asp:Label ID="lblPermanentAddress" runat="server"></asp:Label></td></tr><tr><td>Country</td><td><asp:Label ID="lblPermanentCountry" runat="server"></asp:Label></td></tr><tr><td>State</td><td><asp:Label ID="lblPermanentState" runat="server"></asp:Label></td></tr><tr><td>City</td><td><asp:Label ID="lblPermanentCity" runat="server"></asp:Label></td></tr><tr><td>Area</td><td><asp:Label ID="lblPermanentArea" runat="server"></asp:Label></td></tr><tr><td>Pincode</td><td><asp:Label ID="lblPermanentPincode" runat="server"></asp:Label></td></tr><tr><td>Date Of Birth</td><td colspan="2"><asp:Label ID="lblDateOfBirth" runat="server"></asp:Label></td></tr><tr><td>Marital Status</td><td colspan="2"><asp:Label ID="lblMaritalState" runat="server"></asp:Label></td></tr><tr><td rowspan="2">Passport Issued</td><td>Passport No.</td><td><asp:Label ID="lblPassportNo" runat="server"></asp:Label></td></tr><tr><td>Passport Validity</td><td><asp:Label ID="lblPassportValidity" runat="server"></asp:Label></td></tr></table>
                </div>
                  <div id="menu9" class="tab-pane fade">
                    <h3>Affirmative Details</h3>
                      <table><tr><td rowspan="4">Languages </td><td>Languages</td><td>Proficiency</td><td>Read</td><td>Write</td><td>Speak</td></tr><tr><td><asp:Label ID="lblLanguageFirst" runat="server"></asp:Label></td><td><asp:Label ID="lblProficiencyFirst" runat="server"></asp:Label></td><td><asp:CheckBox ID="chkReadFirst" runat="server" Enabled="False" /></td><td><asp:CheckBox ID="chkWriteFirst" runat="server" Enabled="False" /></td><td><asp:CheckBox ID="chkSpeakFirst" runat="server" Enabled="False" /></td></tr><tr><td><asp:Label ID="lblLanguageSecond" runat="server"></asp:Label></td><td><asp:Label ID="lblProficiencySecond" runat="server"></asp:Label></td><td><asp:CheckBox ID="chkReadSecond" runat="server" Enabled="False" /></td><td><asp:CheckBox ID="chkWriteSecond" runat="server" Enabled="False" /></td><td><asp:CheckBox ID="chkSpeakSecond" runat="server" Enabled="False" /></td></tr><tr><td><asp:Label ID="lblLanguageThird" runat="server"></asp:Label></td><td><asp:Label ID="lblProficiencyThird" runat="server"></asp:Label></td><td><asp:CheckBox ID="chkReadThird" runat="server" Enabled="False" /></td><td><asp:CheckBox ID="chkWriteThird" runat="server" Enabled="False" /></td><td><asp:CheckBox ID="chkSpeakThird" runat="server" Enabled="False" /></td></tr><tr><td>Physically Challenged</td><td colspan="5"><asp:Label ID="lblPhysicallyChallenged" runat="server"></asp:Label></td></tr><tr><td>Description</td><td colspan="5"><asp:Label ID="lblDescription" runat="server"></asp:Label></td></tr><tr><td>Sports</td><td colspan="5"><asp:Label ID="lblSports" runat="server"></asp:Label></td></tr><tr><td>Description/Awards</td><td colspan="5"><asp:Label ID="lblSportsDescription" runat="server"></asp:Label></td></tr><tr><td>Hobbies</td><td colspan="5"><asp:Label ID="lblHobbies" runat="server"></asp:Label></td></tr><tr><td>Extra Curricular Activity</td><td colspan="5"><asp:Label ID="lblActivity" runat="server"></asp:Label></td></tr><tr><td>USA Permit</td><td colspan="5"><asp:Label ID="lblUSAPermit" runat="server"></asp:Label></td></tr><tr><td>Other Permit</td><td colspan="5"><asp:Label ID="lblOtherPermit" runat="server"></asp:Label></td></tr></table>
                </div>
            </div>
        </div>--%>

    <div>
        <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="5" Width="900px">
            <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Profile Summary">
                <ContentTemplate>
                    <table>
                        <tr>
                            <td>
                                <h1>Profile Summary</h1>
                                &nbsp;</td>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Image ID="imgProfilePhoto" runat="server" Height="100px" Width="100px" ImageAlign="Top" />&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Name</td>
                            <td>
                                <asp:Label ID="lblName" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Candidate ID (Reference ID)</td>
                            <td>
                                <asp:Label ID="lblCandidateID" runat="server" data-toggle="tooltip" data-placement="right" title="Use this ID to refer your friend for job!"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Primary Email ID</td>
                            <td>
                                <asp:Label ID="lblEmailId" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Primary Mobile No</td>
                            <td>
                                <asp:Label ID="lblMobNo" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Gender</td>
                            <td>
                                <asp:Label ID="lblGender" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Higest Qualification</td>
                            <td>
                                <asp:Label ID="lblQualification" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Work Status</td>
                            <td>
                                <asp:Label ID="lblWorkStatus" runat="server"></asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:LinkButton ID="lnkbtnWorkStatus" runat="server">Update</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>Total Experience</td>
                            <td>
                                <asp:Label ID="lblExperience" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Current City</td>
                            <td>
                                <asp:Label ID="lblCurrentCity" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Prefered City</td>
                            <td>
                                <asp:Label ID="lblPreferedCity" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Current CTC</td>
                            <td>
                                <asp:Label ID="lblCurrentCTC" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Expected CTC</td>
                            <td>
                                <asp:Label ID="lblExpectedCTC" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Notice Period</td>
                            <td>
                                <asp:Label ID="lblNoticePeriod" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Availability for the Personal Round on Working Day</td>
                            <td>
                                <asp:Label ID="lblInterview" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Availabilty in Week Days(Monday to Friday)</td>
                            <td>
                                <asp:Label ID="lblAvailabilityInWeek" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Job Post looking for</td>
                            <td>
                                <asp:Label ID="lblJobPostLooking" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Employee Status</td>
                            <td>
                                <asp:Label ID="lblEmployeeStatus" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Job Type</td>
                            <td>
                                <asp:Label ID="lblJobType" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Company Type</td>
                            <td>
                                <asp:Label ID="lblCompanyType" runat="server"></asp:Label></td>
                        </tr>
                    </table>
                </ContentTemplate>
            </cc1:TabPanel>
            <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Personal Details">
                <ContentTemplate>
                    <cc1:TabContainer ID="TabContainer2" runat="server" ActiveTabIndex="0" Width="500px">
                        <cc1:TabPanel ID="TabPanel7" runat="server" HeaderText="Contact Details">
                            <ContentTemplate>
                                <table>
                                    <tr>
                                        <td>
                                            <h2>Contact Details</h2>
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="lnkEditConacts" runat="server" OnClick="lnkEditConacts_Click">Edit</asp:LinkButton></td>
                                    </tr>
                                    <tr>
                                        <td>Alternate Email ID</td>
                                        <td>
                                            <asp:Label ID="lblAltEmailId" runat="server" Text="Label"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td><span>Alternate Mobile No</span></td>
                                        <td>
                                            <asp:Label ID="lblAltMobNo" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td><span>Landline No</span></td>
                                        <td>
                                            <asp:Label ID="lblLandLineNo" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td><span>Whats App No</span></td>
                                        <td>
                                            <asp:Label ID="lblWhatsAppNo" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td><span>LinkedIn Profile Link</span></td>
                                        <td>
                                            <asp:Label ID="lblLinkIn" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td><span>Facebook Profile Link</span></td>
                                        <td>
                                            <asp:Label ID="lblFacebook" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td><span>Twitter Profile Link</span>&nbsp;</td>
                                        <td>
                                            <asp:Label ID="lblTwitter" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td><span>GTalk Profile ID</span></td>
                                        <td>
                                            <asp:Label ID="lblGtalk" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td><span>Skype Profile ID</span></td>
                                        <td>
                                            <asp:Label ID="lblSkype" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td><span>Google+ Profile Link</span></td>
                                        <td>
                                            <asp:Label ID="lblGooglePlus" runat="server"></asp:Label></td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </cc1:TabPanel>
                        <cc1:TabPanel ID="TabPanel8" runat="server" HeaderText="Personal Details">
                            <ContentTemplate>
                                <table>
                                    <tr>
                                        <td colspan="3">
                                            <asp:LinkButton ID="lnkEditPersonalDetails" runat="server" OnClick="lnkEditPersonalDetails_Click">Edit</asp:LinkButton></td>
                                    </tr>
                                    <tr>
                                        <td>Photo</td>
                                        <td colspan="2">
                                            <asp:Image ID="Image1" runat="server" Height="100px" Width="100px" ImageAlign="Top" /></td>
                                    </tr>
                                    <tr>
                                        <td rowspan="6">Address</td>
                                        <td>Present Address</td>
                                        <td>
                                            <asp:Label ID="lblPresentAddress" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Country</td>
                                        <td>
                                            <asp:Label ID="lblPresentCountry" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>State</td>
                                        <td>
                                            <asp:Label ID="lblPresentState" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>City</td>
                                        <td>
                                            <asp:Label ID="lblPresentCity" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Area</td>
                                        <td>
                                            <asp:Label ID="lblPresentArea" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Pincode</td>
                                        <td>
                                            <asp:Label ID="lblPresentPincode" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td rowspan="6">Permanent Address</td>
                                        <td>Address</td>
                                        <td>
                                            <asp:Label ID="lblPermanentAddress" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Country</td>
                                        <td>
                                            <asp:Label ID="lblPermanentCountry" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>State</td>
                                        <td>
                                            <asp:Label ID="lblPermanentState" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>City</td>
                                        <td>
                                            <asp:Label ID="lblPermanentCity" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Area</td>
                                        <td>
                                            <asp:Label ID="lblPermanentArea" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Pincode</td>
                                        <td>
                                            <asp:Label ID="lblPermanentPincode" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Date Of Birth</td>
                                        <td colspan="2">
                                            <asp:Label ID="lblDateOfBirth" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Marital Status</td>
                                        <td colspan="2">
                                            <asp:Label ID="lblMaritalState" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td rowspan="2">Passport Issued</td>
                                        <td>Passport No.</td>
                                        <td>
                                            <asp:Label ID="lblPassportNo" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Passport Validity</td>
                                        <td>
                                            <asp:Label ID="lblPassportValidity" runat="server"></asp:Label></td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </cc1:TabPanel>
                        <cc1:TabPanel ID="TabPanel9" runat="server" HeaderText="Affirmative Details">
                            <ContentTemplate>
                                <table class="auto-style1">
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td colspan="5">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td rowspan="4">Languages </td>
                                        <td>Languages</td>
                                        <td>Proficiency</td>
                                        <td>Read</td>
                                        <td>Write</td>
                                        <td>Speak</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblLanguageFirst" runat="server"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="lblProficiencyFirst" runat="server"></asp:Label></td>
                                        <td>
                                            <asp:CheckBox ID="chkReadFirst" runat="server" Enabled="False" /></td>
                                        <td>
                                            <asp:CheckBox ID="chkWriteFirst" runat="server" Enabled="False" /></td>
                                        <td>
                                            <asp:CheckBox ID="chkSpeakFirst" runat="server" Enabled="False" /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblLanguageSecond" runat="server"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="lblProficiencySecond" runat="server"></asp:Label></td>
                                        <td>
                                            <asp:CheckBox ID="chkReadSecond" runat="server" Enabled="False" /></td>
                                        <td>
                                            <asp:CheckBox ID="chkWriteSecond" runat="server" Enabled="False" /></td>
                                        <td>
                                            <asp:CheckBox ID="chkSpeakSecond" runat="server" Enabled="False" /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblLanguageThird" runat="server"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="lblProficiencyThird" runat="server"></asp:Label></td>
                                        <td>
                                            <asp:CheckBox ID="chkReadThird" runat="server" Enabled="False" /></td>
                                        <td>
                                            <asp:CheckBox ID="chkWriteThird" runat="server" Enabled="False" /></td>
                                        <td>
                                            <asp:CheckBox ID="chkSpeakThird" runat="server" Enabled="False" /></td>
                                    </tr>
                                    <tr>
                                        <td>Physically Challenged</td>
                                        <td colspan="5">
                                            <asp:Label ID="lblPhysicallyChallenged" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Description</td>
                                        <td colspan="5">
                                            <asp:Label ID="lblDescription" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Sports</td>
                                        <td colspan="5">
                                            <asp:Label ID="lblSports" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Description/Awards</td>
                                        <td colspan="5">
                                            <asp:Label ID="lblSportsDescription" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Hobbies</td>
                                        <td colspan="5">
                                            <asp:Label ID="lblHobbies" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Extra Curricular Activity</td>
                                        <td colspan="5">
                                            <asp:Label ID="lblActivity" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>USA Permit</td>
                                        <td colspan="5">
                                            <asp:Label ID="lblUSAPermit" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Other Permit</td>
                                        <td colspan="5">
                                            <asp:Label ID="lblOtherPermit" runat="server"></asp:Label></td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </cc1:TabPanel>
                    </cc1:TabContainer>
                </ContentTemplate>
            </cc1:TabPanel>
            <cc1:TabPanel ID="TabPanel3" runat="server" HeaderText="Project Details">
                <ContentTemplate>
                    <h4>
                        <asp:LinkButton ID="lnkEditProject" runat="server" PostBackUrl='<%# "ProjectDetails.aspx?isCheck=1" %>' OnClick="lnkEditProject_Click">Edit</asp:LinkButton></h4>
                    <br />
                    <asp:Repeater ID="rptrProjectDetails" runat="server">
                        <HeaderTemplate>
                            <table border="1px">
                                <tr style="background-color: #fb7700">
                                    <h1>Project Details</h1>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr style="background-color: #ffffff">
                                <td>
                                    <table>
                                        <tr>
                                            <td>Project For </td>
                                            <td>
                                                <asp:Label ID="lblID" Visible="false" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectId") %>'></asp:Label><asp:Label ID="lblProjectFor" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectFor")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>Project Title</td>
                                            <td>
                                                <asp:Label ID="lblProjectTiltle" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectTitle")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>Company Name</td>
                                            <td>
                                                <asp:Label ID="lblCompanyName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "CompanyName")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>Role </td>
                                            <td>
                                                <asp:Label ID="lblRole" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "RoleName") %>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>Client Name </td>
                                            <td>
                                                <asp:Label ID="lblClientName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ClientName")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>Duration </td>
                                            <td>
                                                <asp:Label ID="lblDuration" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Duration")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>Project Location </td>
                                            <td>
                                                <asp:Label ID="lblProjectLocation" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectLocation")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>Employment Type </td>
                                            <td>
                                                <asp:Label ID="lblEmploymentType" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "EmploymentType")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>Project Details </td>
                                            <td>
                                                <asp:Label ID="lblProjectDetails" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectDetails")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>Roles and Responsibility </td>
                                            <td>
                                                <asp:Label ID="lblRolesandResponsibility" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "RolesandResponsibility")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>Team Size </td>
                                            <td>
                                                <asp:Label ID="lblTeamSize" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "TeamSize")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>Skill Used </td>
                                            <td>
                                                <asp:Label ID="lblSkillUsed" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "SkillUsed")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>Project Live </td>
                                            <td>
                                                <asp:Label ID="lblProjectLive" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectLive")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>Project Link </td>
                                            <td>
                                                <asp:Label ID="lblProjectLink" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectLink")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>Degree </td>
                                            <td>
                                                <asp:Label ID="lblDegree" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ProjectLink")%>'></asp:Label></td>
                                        </tr>
                                    </table>
                                    <tr>
                                        <td colspan="2">&nbsp;</td>
                                    </tr>
                        </ItemTemplate>
                        <FooterTemplate></table></FooterTemplate>
                    </asp:Repeater>
                </ContentTemplate>
            </cc1:TabPanel>
            <cc1:TabPanel ID="TabPanel4" runat="server" HeaderText="Educational Details">
                <ContentTemplate>
                     <asp:Repeater ID="rptrEducationalDetails" runat="server" 
                         OnItemCommand="rptrEducationalDetails_ItemCommand">
                        <HeaderTemplate>
                            <table border="1px">
                                <tr style="background-color: #fb7700">
                                    <h1>Educational Details</h1>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr style="background-color: #ffffff">
                                <td>
                                    <table>
                                           <tr>
                                            <td>Highest Qualification </td>
                                            <td>
                                                <%--<asp:Label ID="lblHighestQualification" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "HighestQualificationName")%>'></asp:Label></td>--%>
                                        </tr>
                                            <tr>
                                            <td>Degree Name </td>
                                            <td>
                                                <asp:Label ID="lblDegreeType" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "DegreeName")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>Medium of Education </td>
                                            <td>
                                                <asp:Label ID="lblEducation" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "MediumOfEducation") %>'></asp:Label>
                                        </tr>
                                        <tr>
                                            <td>Status</td>
                                            <td>
                                                <asp:Label ID="lblStatus" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Status")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>From</td>
                                            <td>
                                                <asp:Label ID="lblFrom" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "FromYear")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>To </td>
                                            <td>
                                                <asp:Label ID="lblTo" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ToYear") %>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>School/College </td>
                                            <td>
                                                <asp:Label ID="lblCollege" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "College")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>Board/University </td>
                                            <td>
                                                <asp:Label ID="lblBoard" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "University")%>'></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>Percentage </td>
                                            <td>
                                                <asp:Label ID="lblPercentage" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Percantage")%>'></asp:Label></td>
                                        </tr>
                                    
                                     
                                        <tr>
                                            <td></td>
                                            <td>
                                                <asp:Label ID="lblDegreeId"  Visible="false" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "DegreeId")%>'></asp:Label></td>
                                        </tr>
                                     
                                          <table style="background-color: #f9f9f9; border-top: 1px dotted; border-bottom: 1px solid; width: 500px">
                                        <tr>
                                            <td>
                                                <asp:LinkButton ID="lnkEdit" runat="server" CommandName="edit" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "DegreeId") %>'>Edit</asp:LinkButton>
                                            </td>
                                        </tr>
                                    </table>
                                    </table>
                                    <tr>
                                        <td colspan="2">&nbsp;</td>
                                    </tr>
                        </ItemTemplate>
                        <FooterTemplate></table></FooterTemplate>
                    </asp:Repeater>
                </ContentTemplate>
            </cc1:TabPanel>
            <cc1:TabPanel ID="TabPanel5" runat="server" HeaderText="TechnicalSkills Details">
                <ContentTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server">Edit</asp:LinkButton><asp:Repeater ID="rptrTechnicalSkills" runat="server">
                        <HeaderTemplate>
                            <table width="500px" border="1px">
                                <tr style="background-color: #fb7700">
                                    <td>Technical Skills</td>
                                    <td>From Date</td>
                                    <td>Till Date</td>
                                    <td>Proficiency</td>
                                    <td>Total Year</td>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr style="background-color: #ffffff">
                                <td>
                                    <asp:Label ID="lblTechnicalSkills" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "TechnicalSkillName")%>'></asp:Label></td>
                                <td>
                                    <asp:Label ID="lblFromDate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "FromDate")%>'></asp:Label></td>
                                <td>
                                    <asp:Label ID="lblTillDate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "TillDate")%>'></asp:Label></td>
                                <td>
                                    <asp:Label ID="lblProficiency" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Proficiency")%>'></asp:Label></td>
                                <td>
                                    <asp:Label ID="lblTotalYear" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "TotalYear")%>'></asp:Label></td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                            <tr style="background-color: #15880a">
                                <td colspan="5">
                        </FooterTemplate>
                    </asp:Repeater>
                </ContentTemplate>
            </cc1:TabPanel>
            <cc1:TabPanel ID="TabPanel6" runat="server" HeaderText="Educational Details">
                <ContentTemplate>
                     
                </ContentTemplate>
            </cc1:TabPanel>
        </cc1:TabContainer>
    </div>
</asp:Content>
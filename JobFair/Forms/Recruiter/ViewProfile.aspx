<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="JobFair.Forms.Recruiter.ViewProfile" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <%-- <table>
                <tr>
                    <asp:Image ID="Image1" runat="server" Height="100px" Width="100px" />
                </tr>
                <tr>
                    <td>
                        <span>Name </span></td>
                    <td>
                        <asp:Label ID="lblRecruiterName" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <span>Company Name </span></td>
                    <td>
                        <asp:Label ID="lblCompanyName" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <span>Mobile</span></td>
                    <td>
                        <asp:Label ID="lblMobile" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <span>E-Mail</span></td>
                    <td>
                        <asp:Label ID="lblEmail" runat="server">
                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span>City</span></td>
                    <td>
                        <asp:Label ID="lblCity" runat="server"></asp:Label></td>
                </tr>
            </table>
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table style="border: 1px solid #0000FF; width: 500px">
                        <tr style="background-color: #FF6600; color: #000000; font-size: large; font-weight: bold;">
                            <td colspan="2">
                                <b>Job Post</b>
                            </td>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr style="background-color: #EBEFF0">
                        <td>
                            <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; width: 500px">
                                <tr>
                                    <td>Job Title:
                                 <asp:Label ID="lblSubject" runat="server" Text='<%#Eval("JobTitle") %>' Font-Bold="true" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblComment" runat="server" Text='<%#Eval("JobLocationCity") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("KeywordsTechnical") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; border-bottom: 1px solid #df5015; width: 500px">
                                <tr>
                                    <td>Post By:
                                        <asp:Label ID="lblUser" runat="server" Font-Bold="true" Text='<%#Eval("NumberOfVacancies") %>' /></td>
                                    <td>Created Date:<asp:Label ID="lblDate" runat="server" Font-Bold="true" Text='<%#Eval("PostedDate") %>' /></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>--%>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="4" Width="900px" Height="600px">
                <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="View Profile">
                    <ContentTemplate>
                        <table>
                            <tr>
                                <td>
                                    <h1>View Profile</h1>
                                    &nbsp;</td>
                                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Image ID="imgProfilePhoto" runat="server" Height="100px" Width="100px" ImageAlign="Top" />&nbsp;</td>
                            </tr>
                            <tr>
                                <td>Recruiters Full Name</td>
                                <td>
                                    <asp:Label ID="lblFullName" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Recruiter&#39;s ID</td>
                                <td>
                                    <asp:Label ID="lblRecruiterId" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Company</td>
                                <td>
                                    <asp:Label ID="lblCompany" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Official Contact Number</td>
                                <td>
                                    <asp:Label ID="lblOfficicalNumber" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Mobile Number</td>
                                <td>
                                    <asp:Label ID="lblMobileNumber" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Official Email ID</td>
                                <td>
                                    <asp:Label ID="lblOfficialEmailId" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Freelancer/Employee</td>
                                <td>
                                    <asp:Label ID="lblFreelancer" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Present Address</td>
                                <td>
                                    <asp:Label ID="lblAddress" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Present City</td>
                                <td>
                                    <asp:Label ID="lblCity" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Present Area</td>
                                <td>
                                    <asp:Label ID="lblArea" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Pincode</td>
                                <td>
                                    <asp:Label ID="lblPincode" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Employment Status</td>
                                <td>
                                    <asp:Label ID="lblEmployeeStatus" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Job Type</td>
                                <td>
                                    <asp:Label ID="lblJobType" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>PAN Number</td>
                                <td>
                                    <asp:Label ID="lblPanNumber" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Personal Details">
                    <ContentTemplate>
                        <table>
                            <tr>
                                <td rowspan="6">Present Address</td>
                                <td>Address</td>
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
                                <td>Passport Issue </td>
                                <td>
                                    <asp:Label ID="lblPassportIssue" runat="server"></asp:Label></td>
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
                <cc1:TabPanel ID="TabPanel3" runat="server" HeaderText="Conatact Details">
                    <ContentTemplate>
                        <table>
                            <tr>
                                <td>
                                    <h2>Contact Details</h2>
                                </td>
                                <td>
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
                <cc1:TabPanel ID="TabPanel4" runat="server" HeaderText="Professional Details">
                    <ContentTemplate>
                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="TabPanel5" runat="server" HeaderText="Affirmative Details">
                    <ContentTemplate>
                        <table>
                            <tr>
                                <td>&nbsp;</td>
                                <td colspan="5">
                                    &nbsp;</td>
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
        </div>
    </form>
</body>
</html>
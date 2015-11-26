<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JSViewProfile.aspx.cs" Inherits="JobFair.Forms.JobSeeker.JSViewProfile" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Width="900px">
                <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="View Profile">
                    <ContentTemplate>
                        <table>
                            <tr>
                                <td>
                                    <h1>Profile Summary</h1>
                                    &nbsp;</td>
                                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Image ID="imgProfilePhoto" runat="server" Height="100px" Width="100px" ImageAlign="Top" />
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>Name</td>
                                <td>
                                    <asp:Label ID="lblName" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Candidate ID (Reference ID)</td>
                                <td>
                                    <asp:Label ID="lblCandidateID" runat="server" ToolTip="Use this ID to refer your friend for job"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Primary Email ID</td>
                                <td>
                                    <asp:Label ID="lblEmailId" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Primary Mobile No</td>
                                <td>
                                    <asp:Label ID="lblMobNo" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Gender</td>
                                <td>
                                    <asp:Label ID="lblGender" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Higest Qualification</td>
                                <td>
                                    <asp:Label ID="lblQualification" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Work Status</td>
                                <td>
                                    <asp:Label ID="lblWorkStatus" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Total Experience</td>
                                <td>
                                    <asp:Label ID="lblExperience" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Current City</td>
                                <td>
                                    <asp:Label ID="lblCurrentCity" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Prefered City</td>
                                <td>
                                    <asp:Label ID="lblPreferedCity" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Current CTC</td>
                                <td>
                                    <asp:Label ID="lblCurrentCTC" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Expected CTC</td>
                                <td>
                                    <asp:Label ID="lblExpectedCTC" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Notice Period</td>
                                <td>
                                    <asp:Label ID="lblNoticePeriod" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Availability for the Personal Round on Working Day</td>
                                <td>
                                    <asp:Label ID="lblInterview" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Availabilty in Week Days(Monday to Friday)</td>
                                <td>
                                    <asp:Label ID="lblAvailabilityInWeek" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Job Post looking for</td>
                                <td>
                                    <asp:Label ID="lblJobPostLooking" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>Employee Status</td>
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
                                <td>Company Type</td>
                                <td>
                                    <asp:Label ID="lblCompanyType" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Personal Details">
                    <ContentTemplate>
                         <cc1:TabContainer ID="TabContainer2" runat="server" ActiveTabIndex="0" Width="400px">
                              <cc1:TabPanel ID="TabPanel7" runat="server" HeaderText="Contact Details">
                                  <ContentTemplate>

                                      <table>
                                          <tr>
                                              <td>&nbsp;</td>
                                              <td>&nbsp;</td>
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
                                                  <asp:Label ID="lblLandLineNo" runat="server" ></asp:Label>
                                              </td>
                                          </tr>
                                          <tr>
                                              <td><span>Whats App No</span></td>
                                              <td>
                                                  <asp:Label ID="lblWhatsAppNo" runat="server"></asp:Label>
                                              </td>
                                          </tr>
                                          <tr>
                                              <td><span>LinkedIn Profile Link</span></td>
                                              <td>
                                                  <asp:Label ID="lblLinkIn" runat="server"></asp:Label>
                                              </td>
                                          </tr>
                                          <tr>
                                              <td><span>Facebook Profile Link</span></td>
                                              <td>
                                                  <asp:Label ID="lblFacebook" runat="server"></asp:Label>
                                              </td>
                                          </tr>
                                          <tr>
                                              <td><span>Twitter Profile Link</span>&nbsp;</td>
                                              <td>
                                                  <asp:Label ID="lblTwitter" runat="server"></asp:Label>
                                              </td>
                                          </tr>
                                          <tr>
                                              <td><span>GTalk Profile Id</span></td>
                                              <td>
                                                  <asp:Label ID="lblGtalk" runat="server"></asp:Label>
                                              </td>
                                          </tr>
                                          <tr>
                                              <td><span>Skype Profile Id</span></td>
                                              <td>
                                                  <asp:Label ID="lblSkype" runat="server" ></asp:Label>
                                              </td>
                                          </tr>
                                          <tr>
                                              <td><span>Google+ Profile Link</span></td>
                                              <td>
                                                  <asp:Label ID="lblGooglePlus" runat="server" ></asp:Label>
                                              </td>
                                          </tr>
                                      </table>

                                  </ContentTemplate>
                              </cc1:TabPanel>
                              <cc1:TabPanel ID="TabPanel8" runat="server" HeaderText="Personal Details">
                                  <ContentTemplate>

                                  </ContentTemplate>
                              </cc1:TabPanel>
                              <cc1:TabPanel ID="TabPanel9" runat="server" HeaderText="Affirmative Details">
                                  <ContentTemplate>

                                  </ContentTemplate>
                              </cc1:TabPanel>
                             </cc1:TabContainer>
                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="TabPanel3" runat="server" HeaderText="Professional Details">
                    <ContentTemplate>
                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="TabPanel4" runat="server" HeaderText="Technical Details">
                    <ContentTemplate>
                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="TabPanel5" runat="server" HeaderText="Project Details">
                    <ContentTemplate>
                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="TabPanel6" runat="server" HeaderText="Educational Details">
                    <ContentTemplate>
                    </ContentTemplate>
                </cc1:TabPanel>
            </cc1:TabContainer>
        </div>
    </form>
</body>
</html>
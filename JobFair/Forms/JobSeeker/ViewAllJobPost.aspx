<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAllJobPost.aspx.cs" Inherits="JobFair.Forms.JobSeeker.ViewAllJobPost" %>


    <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <div>
            <table style="width: 800px">
                

                <tr style="background-color: #EBEFF0; color:#ff0000">
                    <td>
                        <table style=" width: 800px">
                            <tr>
                                <td><b>Job Title:</b>
                                 <asp:Label ID="lblTitle" runat="server"  Font-Bold="true" />
                                    <%--<asp:Label ID="lblId" runat="server" Text='<%#Eval("JobPostId")%>' Visible="false"></asp:Label>--%>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCompanyName" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblExperience" runat="server"></asp:Label>
                        years
                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblCity" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCompanyLevel" runat="server"  />

                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblVacancies" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEmplymentStatus" runat="server"  />

                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblJobType" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblGender" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblIndustry" runat="server" ></asp:Label>-
                        <asp:Label ID="lblDepartmet" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblFunctionalArea" runat="server" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; border-bottom: 1px solid #df5015; width: 800px">
                            <tr>
                                <td>
                                    <asp:Label ID="lblMinSalary" runat="server" ></asp:Label>
                                    &nbsp;To
                                       <asp:Label ID="lblMaxSalary" runat="server"></asp:Label>&nbsp;P.A
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblClientName" runat="server" Visible="false" ></asp:Label><asp:Label ID="lblRequirementId" runat="server" Visible="false"></asp:Label><asp:Label ID="lblRecruiterId" runat="server" visible="false"></asp:Label>
                        <asp:Label ID="lblRecruiterName" runat="server" Visible="false"></asp:Label>
                    </td>
                </tr>
                <table style=" width: 800px">
                    <tr>
                        <td><b>Job Description:</b></td></tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblJobDesc" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td><b>SkillSets Roles :</b></td></tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblRoles" runat="server" ></asp:Label></td>
                    </tr>
                    <tr>
                        <td><b>SkillSets Technical :</b></td></tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblTechnicalSkills" runat="server" ></asp:Label></td>
                    </tr>
                </table>
                <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; border-bottom: 1px solid #df5015; width: 800px">
                    <tr>
                        <td>
                            <asp:Panel ID="pnlApply" runat="server" Visible="false">
                                 <asp:Button ID="btnApply" runat="server" OnClientClick="document.forms[0].target='_blank';"  UseSubmitBehavior="false" Text="Apply" OnClick="btnApply_Click1" />
                            </asp:Panel>
                            <asp:Panel ID="pnlApplyLogin" runat="server" Visible="false">
                                 <asp:Button ID="btnApplyLogin" runat="server" Text="Login To Apply" OnClick="btnApplyLogin_Click" />
                            <asp:Button ID="btnApplyRegistration" runat="server" OnClientClick="document.forms[0].target='_blank';"  UseSubmitBehavior="false" Text="Register And Apply" OnClick="btnApplyRegistration_Click" />
                            </asp:Panel>
                           
                        </td>
                    </tr>
                </table>
            </table>
        </div>
    </div>
</form>
    </body>
    </html>
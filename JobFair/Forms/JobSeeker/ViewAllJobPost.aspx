<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAllJobPost.aspx.cs" Inherits="JobFair.Forms.JobSeeker.ViewAllJobPost" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .Background {
            background-color: Black;
            filter: alpha(opacity=90);
            opacity: 0.8;
        }

        .Popup {
            background-color: #FFFFFF;
            border-width: 3px;
            border-style: solid;
            border-color: black;
            padding-top: 10px;
            padding-left: 10px;
            width: 400px;
            height: 350px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <div>
                <table style="width: 800px">

                    <tr style="background-color: #EBEFF0; color: #ff0000">
                        <td>
                            <table style="width: 800px">
                                <tr>
                                    <td><b>Job Title:</b>
                                        <asp:Label ID="lblTitle" runat="server" Font-Bold="true" />
                                       <%-- <asp:Label ID="lblId" runat="server" Text='<%#Eval("JobPostId")%>' Visible="false"></asp:Label>--%>
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
                        <asp:Label ID="lblCity" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblCompanyLevel" runat="server" />

                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblVacancies" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblEmplymentStatus" runat="server" />

                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblJobType" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblGender" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblIndustry" runat="server"></asp:Label>-
                        <asp:Label ID="lblDepartmet" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblFunctionalArea" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; border-bottom: 1px solid #df5015; width: 800px">
                                <tr>
                                    <td>
                                        <asp:Label ID="lblMinSalary" runat="server"></asp:Label>
                                        &nbsp;To
                                       <asp:Label ID="lblMaxSalary" runat="server"></asp:Label>&nbsp;P.A
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblClientName" runat="server" Visible="false"></asp:Label><asp:Label ID="lblRequirementId" runat="server" Visible="false"></asp:Label><asp:Label ID="lblRecruiterId" runat="server" Visible="false"></asp:Label>
                            <asp:Label ID="lblRecruiterName" runat="server" Visible="false"></asp:Label>
                        </td>
                    </tr>
                    <table style="width: 800px">
                        <tr>
                            <td><b>Job Description:</b></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblJobDesc" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td><b>SkillSets Roles :</b></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblRoles" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td><b>SkillSets Technical :</b></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblTechnicalSkills" runat="server"></asp:Label></td>
                        </tr>
                    </table>
                    <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; border-bottom: 1px solid #df5015; width: 800px">
                        <tr>
                            <td>
                                <asp:Panel ID="pnlApply" runat="server" Visible="false">
                                    <asp:Button ID="btnApply" runat="server" OnClientClick="document.forms[0].target='_blank';" UseSubmitBehavior="false" Text="Apply" OnClick="btnApply_Click1" />
                                </asp:Panel>
                                <asp:Panel ID="pnlApplyLogin" runat="server" Visible="false">
                                    <asp:Button ID="btnApplyLogin" runat="server" Text="Login To Apply" OnClick="btnApplyLogin_Click" />
                                    <asp:Button ID="btnApplyRegistration" runat="server" OnClientClick="document.forms[0].target='_blank';" UseSubmitBehavior="false" Text="Register And Apply" OnClick="btnApplyRegistration_Click" />
                                </asp:Panel>
                                <asp:ImageButton ID="ImageButton1" runat="server" Style="height:50px" ImageUrl="~/Images/email.png" OnClick="ImageButton1_Click" />
                               <%-- <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="Panel1" TargetControlID="ImageButton1" CancelControlID="Button2" BackgroundCssClass="Background">
                                </cc1:ModalPopupExtender>
                                <asp:Panel ID="Panel1" runat="server" CssClass="Popup" align="center" Style="display: none;">
                                    <iframe style="width: 350px; height: 300px;" id="irm1" src="ForwardJobToFriend.aspx" runat="server"></iframe>
                                    <br />
                                    <asp:Button ID="Button2" runat="server" Text="Close" />
                                </asp:Panel>--%>
                            </td>
                        </tr>
                    </table>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
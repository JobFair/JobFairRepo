<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="PostNewJob.aspx.cs" Inherits="JobFair.Forms.Recruiter.PostNewJob" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="DropDownCheckBoxes" Namespace="Saplin.Controls" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery.min.js"></script>
</head>
<script type="text/javascript">
    $(function () {
        $('#DropDownCheckBoxes1').multiselect({
            includeSelectAllOption: true
        });
    });
</script>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <h2>Post New Job</h2>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <table>
                        <tr>
                            <td>Select the Requirement</td>
                            <td>
                                <asp:DropDownList ID="ddlRequirementName" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlRequirementName_SelectedIndexChanged"></asp:DropDownList></td>
                        </tr>

                        <tr>
                            <td>Client Name
                            </td>
                            <td>
                                <asp:Label ID="lblClientName" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>

                            <td>Position
                            </td>
                            <td>
                                <asp:Label ID="lblPosition" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Requirement ID</td>
                            <td>
                                <asp:Label ID="lblRequirementId" runat="server"></asp:Label></td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
            <br />

            <table>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lbltitle" Text="Job Title/Designation"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtJobtitle" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>

                        <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                    </td>
                    <td>
                        <asp:UpdatePanel ID="pnlstate" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList ID="ddlState" runat="server" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" AutoPostBack="True">
                                </asp:DropDownList>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                    </td>
                    <td>
                        <asp:UpdatePanel ID="pnlCity" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList ID="ddlCity" runat="server" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged" AutoPostBack="True">
                                </asp:DropDownList>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblArea" runat="server" Text="Area"></asp:Label>
                    </td>
                    <td>

                        <asp:UpdatePanel ID="pnlarea" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList ID="ddllocation" runat="server"></asp:DropDownList>

                                <asp:Label ID="lbllocation" runat="server"></asp:Label>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblcompanyname" runat="server" Text="CompanyType"></asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddlCompanytype" runat="server" AutoPostBack="True">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Startup Company</asp:ListItem>
                            <asp:ListItem>Small Scale Company</asp:ListItem>
                            <asp:ListItem>Mid Level Company</asp:ListItem>
                            <asp:ListItem>MNC</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblindustry" runat="server" Text="Industry"> </asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddlIndustry" runat="server" Height="19px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbldepartment" runat="server" Text="Department"> </asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddlDepartment" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblfunctionalarea" runat="server" Text="Functional Area"></asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddlFunArea" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbljobdescription" runat="server" Text="Job Description"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtJobDescription" runat="server" Width="350px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblkeyroles" runat="server" Text="Keywords/Skillsets Roles"></asp:Label></td>
                    <td>

                        <asp:TextBox ID="txtKeyRoles" runat="server"></asp:TextBox>
                        <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtKeyRoles" MinimumPrefixLength="1"
                            EnableCaching="true" CompletionSetCount="1" CompletionInterval="1000" ServiceMethod="GetRoles">
                        </cc1:AutoCompleteExtender>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblkeytechnical" runat="server" Text="Keywords/Skillsets Technical"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtKeyTechnical" runat="server"></asp:TextBox>
                        <cc1:AutoCompleteExtender ID="AutoCompleteExtender2" runat="server" TargetControlID="txtKeyTechnical" MinimumPrefixLength="1" EnableCaching="true"
                            CompletionSetCount="1" CompletionInterval="1000" ServiceMethod="GetTechnicalskill">
                        </cc1:AutoCompleteExtender>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblworkexprience" runat="server" Text="Work Experience"></asp:Label></td>
                    <td>&nbsp;
                        <asp:DropDownList ID="ddlworkexprience" runat="server">
                            <asp:ListItem>0.5</asp:ListItem>
                            <asp:ListItem>1.0</asp:ListItem>
                            <asp:ListItem>1.5</asp:ListItem>
                            <asp:ListItem>2.0</asp:ListItem>
                            <asp:ListItem>2.5</asp:ListItem>
                            <asp:ListItem>3.0</asp:ListItem>
                            <asp:ListItem>3.5</asp:ListItem>
                            <asp:ListItem>4.0</asp:ListItem>
                            <asp:ListItem>4.5</asp:ListItem>
                            <asp:ListItem>5.0</asp:ListItem>
                            <asp:ListItem>5.5</asp:ListItem>
                            <asp:ListItem>6.0</asp:ListItem>
                            <asp:ListItem>6.5</asp:ListItem>
                            <asp:ListItem>7.0</asp:ListItem>
                            <asp:ListItem>7.5</asp:ListItem>
                            <asp:ListItem>8.0</asp:ListItem>
                            <asp:ListItem>8.5</asp:ListItem>
                            <asp:ListItem>9.0</asp:ListItem>
                            <asp:ListItem>9.5</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblgender" runat="server" Text="Gender"></asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddlgender" runat="server" AutoPostBack="True">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Both [Male/Female]</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblofferedsalary" runat="server" Text="Offered Anual Salary"></asp:Label></td>
                    <td>&nbsp;<asp:DropDownList ID="ddlsalarymin" runat="server">
                        <asp:ListItem>Min</asp:ListItem>
                        <asp:ListItem>50,000</asp:ListItem>
                        <asp:ListItem>1,00,000</asp:ListItem>
                        <asp:ListItem>1,50,000</asp:ListItem>
                        <asp:ListItem>2,00,000</asp:ListItem>
                        <asp:ListItem>2,50,000</asp:ListItem>
                        <asp:ListItem>3,00,000</asp:ListItem>
                        <asp:ListItem>3,50,000</asp:ListItem>
                        <asp:ListItem>4,00,000</asp:ListItem>
                        <asp:ListItem>4,50,000</asp:ListItem>
                        <asp:ListItem>5,00,000</asp:ListItem>
                        <asp:ListItem>5,50,000</asp:ListItem>
                        <asp:ListItem>6,00,000</asp:ListItem>
                        <asp:ListItem>6,50,000</asp:ListItem>
                        <asp:ListItem>7,00,000</asp:ListItem>
                        <asp:ListItem>7,50,000</asp:ListItem>
                        <asp:ListItem>8,00,000</asp:ListItem>
                        <asp:ListItem>8,50,000</asp:ListItem>
                        <asp:ListItem>9,00,000</asp:ListItem>
                        <asp:ListItem>9,50,000</asp:ListItem>
                        <asp:ListItem>10,00,000</asp:ListItem>
                    </asp:DropDownList>
                        <asp:DropDownList ID="ddlsalarymax" runat="server">
                            <asp:ListItem>Max</asp:ListItem>
                            <asp:ListItem>&lt;50,000</asp:ListItem>
                            <asp:ListItem>1,00,000</asp:ListItem>
                            <asp:ListItem>1,50,000</asp:ListItem>
                            <asp:ListItem>2,00,000</asp:ListItem>
                            <asp:ListItem>2,50,000</asp:ListItem>
                            <asp:ListItem>3,00,000</asp:ListItem>
                            <asp:ListItem>3,50,000</asp:ListItem>
                            <asp:ListItem>4,00,000</asp:ListItem>
                            <asp:ListItem>4,50,000</asp:ListItem>
                            <asp:ListItem>5,00,000</asp:ListItem>
                            <asp:ListItem>5,50,000</asp:ListItem>
                            <asp:ListItem>6,00,000</asp:ListItem>
                            <asp:ListItem>6,50,000</asp:ListItem>
                            <asp:ListItem>7,00,000</asp:ListItem>
                            <asp:ListItem>7,50,000</asp:ListItem>
                            <asp:ListItem>8,00,000</asp:ListItem>
                            <asp:ListItem>8,50,000</asp:ListItem>
                            <asp:ListItem>9,00,000</asp:ListItem>
                            <asp:ListItem>9,50,000</asp:ListItem>
                            <asp:ListItem>10,00,000</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblsalrydetails" runat="server" Text="OtherSalaryDetails"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtsalarydetaills" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblvacancies" runat="server" Text="Number Of Vacancies"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtVacancies" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbljobtype" Text="Job Type" runat="server"></asp:Label></td>
                    <td>
                        <asp:UpdatePanel ID="pnljobtype" runat="server">
                            <ContentTemplate>
                                <asp:CheckBoxList ID="chkjobtype" runat="server" AutoPostBack="True" OnSelectedIndexChanged="chkjobtype_SelectedIndexChanged">
                                    <asp:ListItem>Part Time</asp:ListItem>
                                    <asp:ListItem>Full Time</asp:ListItem>
                                </asp:CheckBoxList>
                                &nbsp;
                        <asp:Label ID="lblselectedjobtype" runat="server"></asp:Label>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblrecruitmenttype" Text="Employment Status" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:UpdatePanel ID="pnlemploymenttype" runat="server">
                            <ContentTemplate>
                                <asp:CheckBoxList ID="chkemploymenttype" runat="server" AutoPostBack="True" OnSelectedIndexChanged="chkemploymenttype_SelectedIndexChanged">
                                    <asp:ListItem>Temporarily</asp:ListItem>
                                    <asp:ListItem>Permanant</asp:ListItem>
                                    <asp:ListItem>Freelancing</asp:ListItem>
                                </asp:CheckBoxList>
                                <asp:Label ID="lblemploymentstatus" runat="server"></asp:Label>
                                <br />
                                </td>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
              
                        <tr>
                            <td>
                                <asp:Label ID="lblRecruitment" runat="server" Text="Recruitment Type"></asp:Label>
                            </td>
                            <td>
                                  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                                <asp:RadioButtonList ID="rdbrecruitmenttype" runat="server" AutoPostBack="true" OnSelectedIndexChanged="rdbrecruitmenttype_SelectedIndexChanged">
                                    <asp:ListItem Text="In-House"></asp:ListItem>
                                    <asp:ListItem Text="Client"></asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <asp:Panel ID="pnlInHouse" runat="server" Visible="false">
                            <tr>
                                <td>
                                    <asp:Label ID="lblcompanyclient" runat="server" Text="Company Name"></asp:Label>&nbsp;&nbsp;&nbsp;:
                                </td>
                                <td>
                                    <%-- <asp:UpdatePanel ID="pnlcompanyName" runat="server">
                                        <ContentTemplate>--%>
                                    <asp:RadioButtonList ID="rblCompanyName" runat="server" AutoPostBack="true" OnSelectedIndexChanged="rblCompanyName_SelectedIndexChanged">
                                        <asp:ListItem>Logos Corporate Solutions</asp:ListItem>
                                        <asp:ListItem>Logos iTech Solutions</asp:ListItem>
                                    </asp:RadioButtonList>
                                    <br />
                                    <%--  </ContentTemplate>
                                    </asp:UpdatePanel>--%>
                                </td>
                            </tr>
                        </asp:Panel>

                        <asp:Panel ID="pnlCompanyProfile" runat="server" Visible="false">
                            <tr>
                                <td>Company Profile</td>&nbsp;&nbsp;&nbsp;:
                                <td>
                                    <asp:Label ID="lblCompanyProfile" runat="server" Text="Logos Solutions" Visible="false"></asp:Label>
                                    <asp:Label ID="lblCompanyProfileiTech" runat="server" Text="Logos iTech" Visible="false"></asp:Label>
                                </td>
                            </tr>
                        </asp:Panel>
                        <asp:Panel ID="pnlClient" runat="server" Visible="false">
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Label ID="lblClient" runat="server" Text="Client of Logos Solutions"></asp:Label><br />
                                </td>
                            </tr>

                            <tr>
                                <td>Client Company Profile</td>&nbsp;&nbsp;&nbsp;:
                                <td>
                                    <asp:TextBox ID="txtClientCompanyProfile" runat="server" TextMode="MultiLine"></asp:TextBox>
                                </td>
                            </tr>
                        </asp:Panel>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </table>
        </div>

        <h2>Desired Candidate Profile &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h2>
        <table>
            <tr>
                <td>Specify Qualification</td>
                <td>
                    <asp:TextBox ID="txtQualification" runat="server" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
        </table>
        <div>
            <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                <ContentTemplate>
                    <asp:CheckBox ID="chkCandidateProfile" runat="server" Text="Describe Candidate Profile" AutoPostBack="True" OnCheckedChanged="chkCandidateProfile_CheckedChanged" />
                    <div>
                        <asp:Panel ID="pnlCandidateProfile" runat="server" Visible="false">
                            Candidate Profile :<asp:TextBox ID="txtCandidateProfile" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </asp:Panel>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

        <div>
            <h2>Select Questionnaire</h2>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblselectquestionrie" runat="server" Text="Select  Questionnaire"></asp:Label>
                    </td>
                    <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                        <ContentTemplate>
                            <td>
                                <asp:DropDownList ID="ddlquestionnaire" runat="server" Style="margin-left: 47px"></asp:DropDownList>
                                <asp:LinkButton ID="lnkbtnRefresh" runat="server" OnClick="lnkbtnRefresh_Click"><span class="glyphicon glyphicon-refresh"></span></asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnQuestionary" runat="server" OnClick="lnkbtnQuestionary_Click1">Create Your Questionary</asp:LinkButton>
                            </td>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnPostJob" runat="server" Text="Post Job" OnClick="btnPostJob_Click" Width="77px" />
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
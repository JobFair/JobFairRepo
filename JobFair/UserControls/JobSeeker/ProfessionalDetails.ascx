<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProfessionalDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.ProfessionalDetails" %>
<%@ Register Assembly="DropDownCheckBoxes" Namespace="Saplin.Controls" TagPrefix="asp" %>

<script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
<link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.11.2/themes/smoothness/jquery-ui.css" />
<script src="//ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.11.2/jquery-ui.min.js"></script>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="DropDownCheckBoxes" Namespace="Saplin.Controls" TagPrefix="asp" %>

<style type="text/css">
    .auto-style3 {
        width: 404px;
    }
</style>

<div>
    &nbsp;<table id="TableCurrentJob" runat="server">
        <tr>
            <td colspan="2">
                <h1>&nbsp;Job Details</h1>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Resume Headline</td>
            <td>
                <asp:TextBox ID="txtResumeHeadline" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Objective</td>
            <td>
                <asp:TextBox ID="txtObjective" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Profile Summary</td>
            <td>
                <asp:TextBox ID="txtProfileSummary" runat="server" Height="111px" TextMode="MultiLine" Width="375px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Total Experience</td>
            <td>
                <asp:Label ID="lblTotalExp" runat="server"></asp:Label>
                &nbsp;Years
            </td>
        </tr>
        <tr>
            <td>Currently You Are?</td>
            <td>
                <asp:RadioButton ID="rbtEmployed" Text="Employed" runat="server" AutoPostBack="True" GroupName="EmplyeeORNot" OnCheckedChanged="rbtEmployed_CheckedChanged" />
                &nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="rbtUnEmployed" Text="Un-Employed" runat="server" AutoPostBack="True" GroupName="EmplyeeORNot" OnCheckedChanged="rbtUnEmployed_CheckedChanged" />
            </td>
        </tr>

        <tr>
            <td colspan="2">
                <hr />
            </td>
        </tr>

        <tr>
            <td colspan="2">

                <div id="divCurrentEmployer" runat="server" >
                    <table>
                        <tr>
                            <td colspan="2">
                                <h1>&nbsp;Employer Details</h1>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Employer/Company Name</td>
                            <td>
                                <asp:TextBox ID="txtCurrentEmployer" runat="server"></asp:TextBox>
                                <asp:CheckBox ID="chkCurrentYes" runat="server" Text="Current Company" />

                            </td>
                        </tr>
                        <tr>
                            <td>Designation</td>
                            <td>
                                <asp:TextBox ID="txtDesignation" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Roles &amp; Responsibilities</td>
                            <td>
                                <asp:TextBox ID="txtRollesResponsibilities" runat="server" Height="117px" TextMode="MultiLine" Width="366px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Duration</td>
                            <td>From
                                <asp:DropDownList ID="ddlFromMonth" runat="server">
                                </asp:DropDownList>
                                <asp:DropDownList ID="ddlFromYear" runat="server">
                                </asp:DropDownList>
                                &nbsp;Till<asp:DropDownList ID="ddlTillMonth" runat="server">
                                </asp:DropDownList>
                                <asp:DropDownList ID="ddlTillYear" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Industry</td>
                            <td>
                                <asp:DropDownList ID="ddlIndustry" runat="server">
                                </asp:DropDownList>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>Department</td>
                            <td>
                                <asp:DropDownList ID="ddlDepartment" runat="server" DataTextField="DepartmentName" DataValueField="DepartmentId">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Employment Status</td>
                            <td>
                                <asp:RadioButtonList ID="rblEmployeStatus" runat="server">
                                    <asp:ListItem>Full Time</asp:ListItem>
                                    <asp:ListItem>Part Time</asp:ListItem>
                                </asp:RadioButtonList>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>Job Type</td>
                            <td>
                                <asp:RadioButtonList ID="rblJobType" runat="server">
                                    <asp:ListItem>Permanent</asp:ListItem>
                                    <asp:ListItem>Temporary</asp:ListItem>
                                    <asp:ListItem>Freelancing</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td>Company Type</td>
                            <td>
                                <asp:RadioButtonList ID="rblCompanyType" runat="server">
                                    <asp:ListItem>Small</asp:ListItem>
                                    <asp:ListItem>Middle</asp:ListItem>
                                    <asp:ListItem>MNC</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td>Reason For JobChange</td>
                            <td>
                                <asp:TextBox ID="txtReasonforJobchange" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnAddExperience" runat="server" Text="Add Experience" OnClick="btnAddExperience_Click" />
                            </td>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:HiddenField ID="hfCandidateId" runat="server" />
                                <asp:GridView ID="gvExperience" AutoGenerateColumns="false" runat="server">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:BoundField HeaderText="CandidateId" DataField="CandidateId" Visible="false" />
                                        <asp:BoundField HeaderText="CompanyCurrentOrPast" DataField="CompanyCurrentOrPast" />
                                        <asp:BoundField HeaderText="ComapnyName" DataField="ComapnyName" />
                                        <asp:BoundField HeaderText="Designation" DataField="Designation" />
                                        <asp:BoundField HeaderText="RolesResponsibilities" DataField="RolesResponsibilities" />
                                        <asp:BoundField HeaderText="FromMonth" DataField="FromMonth" />
                                        <asp:BoundField HeaderText="FromYear" DataField="FromYear" />
                                        <asp:BoundField HeaderText="TillMonth" DataField="TillMonth" />
                                        <asp:BoundField HeaderText="TillYear" DataField="TillYear" />
                                        <asp:BoundField HeaderText="Industry" DataField="Industry" />
                                        <asp:BoundField HeaderText="Department" DataField="Department" />
                                        <asp:BoundField HeaderText="EmploymentStatus" DataField="EmploymentStatus" />
                                        <asp:BoundField HeaderText="JobType" DataField="JobType" />
                                        <asp:BoundField HeaderText="CompanyType" DataField="CompanyType" />
                                        <asp:BoundField HeaderText="Reason" DataField="Reason" />
                                    </Columns>
                                    <EditRowStyle BackColor="#2461BF" />
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EFF3FB" />
                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">

                                <asp:Repeater ID="rptrPastCurrentJobDetails" runat="server" OnItemDataBound="rptrPastCurrentJobDetails_ItemDataBound" OnItemCommand="rptrPastCurrentJobDetails_ItemCommand">
                                    <HeaderTemplate>
                                        <table>
                                            <tr>
                                                <td colspan="2">
                                                    <h1>Your Past & Current Experience</h1>
                                                </td>
                                            </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr style="background-color: #EBEFF0">
                                            <td>
                                                <table style="background-color: #EBEFF0; border-top: 1px dotted #c1650f; width: 300px">
                                                    <tr>
                                                        <td>
                                                            <b>Current Company</b>
                                                            <asp:Label ID="lblCurrentComapny" runat="server" Text='<%#Eval("CompanyCurrentOrPast") %>'></asp:Label>
                                                            <asp:CheckBox ID="chkCurrentYes" runat="server" Text="Current Company" Visible="false" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Employer/Company Name</b>
                                                            <asp:Label ID="lblCompanyName" runat="server" Text='<%#Eval("ComapnyName") %>' />
                                                            <asp:TextBox ID="txtComapnyName" runat="server" Text='<%#Eval("ComapnyName") %>' Visible="false"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Designation</b>
                                                            <asp:Label ID="lblDesignation" runat="server" Text='<%#Eval("Designation") %>' />
                                                            <asp:TextBox ID="txtDesignation" runat="server" Text='<%#Eval("Designation") %>' Visible="false"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Roles & Responsibilities</b>
                                                            <asp:Label ID="lblRolesResponsibility" runat="server" Text='<%#Eval("RolesResponsibilities") %>' />
                                                            <asp:TextBox ID="txtRolesResponsibility" runat="server" Text='<%#Eval("RolesResponsibilities") %>' Visible="false"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Duration</b>
                                                            <asp:Label ID="lblFromMonth" runat="server" Text='<%#Eval("FromMonth") %>' />
                                                            <asp:Label ID="lblFromYear" runat="server" Text='<%#Eval("FromYear") %>'></asp:Label>
                                                            Till
                                                                 <asp:Label ID="lblTillMonth" runat="server" Text='<%#Eval("TillMonth") %>' />
                                                            <asp:Label ID="lblTillYear" runat="server" Text='<%#Eval("TillYear") %>'></asp:Label>

                                                            <asp:DropDownList ID="ddlFromMonth" runat="server" Visible="false">
                                                            </asp:DropDownList>
                                                            <asp:DropDownList ID="ddlFromYear" runat="server" Visible="false">
                                                            </asp:DropDownList>
                                                            <asp:Label ID="lbltillword" runat="server" Text="Till" Visible="false"></asp:Label>
                                                            <asp:DropDownList ID="ddlTillMonth" runat="server" Visible="false">
                                                            </asp:DropDownList>
                                                            <asp:DropDownList ID="ddlTillYear" runat="server" Visible="false">
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Industry</b>
                                                            <asp:Label ID="lblIndustry" runat="server" Text='<%#Eval("IndustryName") %>' />
                                                            <asp:DropDownList ID="ddlIndustry" runat="server" Visible="false"></asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Department</b>
                                                            <asp:Label ID="lblDepartment" runat="server" Text='<%#Eval("DepartmentName") %>' />
                                                            <asp:DropDownList ID="ddlDepartment" runat="server" Visible="false"></asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Employment Status</b>
                                                            <asp:Label ID="lblEmploymentStatus" runat="server" Text='<%#Eval("EmploymentStatus") %>'></asp:Label>
                                                            <asp:RadioButtonList ID="rbtlEmployementStatus" runat="server" Visible="false">
                                                                <asp:ListItem>Full Time</asp:ListItem>
                                                                <asp:ListItem>Part Time</asp:ListItem>
                                                            </asp:RadioButtonList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Job Type
                                                            </b>
                                                            <asp:Label ID="lblJobType" runat="server" Text='<%#Eval("JobType") %>'></asp:Label>
                                                            <asp:RadioButtonList ID="rblJobType" runat="server" Visible="false">
                                                                <asp:ListItem>Permanent</asp:ListItem>
                                                                <asp:ListItem>Temporary</asp:ListItem>
                                                                <asp:ListItem>Freelancing</asp:ListItem>
                                                            </asp:RadioButtonList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Company Type
                                                            </b>
                                                            <asp:Label ID="lblCompanyType" runat="server" Text='<%#Eval("CompanyType") %>'></asp:Label>
                                                            <asp:RadioButtonList ID="rblCompanyType" runat="server" Visible="false">
                                                                <asp:ListItem>Small</asp:ListItem>
                                                                <asp:ListItem>Middle</asp:ListItem>
                                                                <asp:ListItem>MNC</asp:ListItem>
                                                            </asp:RadioButtonList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <b>Reason For JobChange
                                                            </b>
                                                            <asp:Label ID="lblReasonforjobchange" runat="server"></asp:Label>
                                                            <asp:TextBox ID="txtReasonforJobchange" runat="server" TextMode="MultiLine" Text='<%#Eval("Reason") %>' Visible="false"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table style="background-color: #EBEFF0; border-top: 1px dotted #c1650f; border-bottom: 1px solid #c1650f; width: 300px">
                                                    <tr>
                                                        <td>
                                                            <asp:LinkButton ID="lnkEdit" runat="server" CommandArgument='<%#Eval("Id") %>' CommandName="edit">Edit</asp:LinkButton>
                                                            <asp:LinkButton ID="lnkDelete" runat="server" CommandArgument='<%#Eval("Id") %>' CommandName="delete" OnClientClick="return confirm('Are you sure you want to delete?')">Delete</asp:LinkButton>
                                                            <asp:LinkButton ID="lnkUpdate" runat="server" CommandArgument='<%#Eval("Id") %>' CommandName="update" Visible="false">Update</asp:LinkButton>
                                                            <asp:LinkButton ID="lnkCancel" runat="server" CommandArgument='<%#Eval("Id") %>' CommandName="cancel" Visible="false">Cancel</asp:LinkButton>
                                                        </td>
                                                    </tr>
                                                </table>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="btnSaveCurrentJob" runat="server" Text="Save" OnClick="btnSaveCurrentJob_Click" />
                                <asp:Button ID="btncancelCurrentJob" runat="server" Text=" Cancel" />
                                <asp:Label ID="lblmsgsave" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <div id="divPastCurrentJobDetails" runat="server">
                                    <!--Textboxes will be added here -->
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
    </table>
</div>
<div id="divDesireJobDetails" runat="server">
    <table id="TableDesiredJob" runat="server">
        <tr>
            <td colspan="2">
                <h1>Desired Job Details</h1>
            </td>
        </tr>
        <tr>
            <td>Current Work Status</td>
            <td>
                <asp:DropDownList ID="ddlWorkStatus" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>Looking For The Job</asp:ListItem>
                    <asp:ListItem>Offer Accepted</asp:ListItem>
                    <asp:ListItem>Joined New Job</asp:ListItem>
                    <asp:ListItem>Satisfied in the Current Job</asp:ListItem>
                    <asp:ListItem>Looking For the Freelancing Work</asp:ListItem>
                    <asp:ListItem>Looking for the Part Time Work</asp:ListItem>
                    <asp:ListItem>Serving Notice Period</asp:ListItem>
                    <asp:ListItem>Unemployed</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">

                <div id="divAddMoreJob" runat="server">
                    <table>
                        <tr>
                            <td colspan="2">
                                <h1>Add Jobs</h1>
                            </td>
                        </tr>
                        <tr>
                            <td>Job Post Looking For</td>
                            <td>
                                <asp:TextBox ID="txtJobPostLookingFor" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Industry</td>
                            <td>
                                <asp:DropDownList ID="ddlIndustry123" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Department</td>
                            <td>
                                <asp:DropDownList ID="ddlDepartment123" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Functional Role</td>
                            <td>&nbsp;<asp:DropDownList ID="ddlFunctionalRole" runat="server">
                            </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Relevant Experience</td>
                            <td>
                                <asp:TextBox ID="txtRelevantExp" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnAddMoreJobPost" runat="server" Text="Add More Jobs" OnClick="btnAddMoreJobPost_Click" />
                            </td>
                            <td>
                                <asp:Label ID="lblSuggestion" runat="server" Text="You can Add 5 Jobs"></asp:Label>&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:GridView ID="gvJobsLookingFor" AutoGenerateColumns="false" runat="server">
                                    <Columns>
                                        <asp:BoundField HeaderText="CandidateId" DataField="CandidateId" Visible="false" />
                                        <asp:BoundField HeaderText="JobPostLookingFor" DataField="JobPostLookingFor" />
                                        <asp:BoundField HeaderText="Industry" DataField="Industry" />
                                        <asp:BoundField HeaderText="Department" DataField="Department" />
                                        <asp:BoundField HeaderText="FunctionalRole" DataField="FunctionalRole" />
                                        <asp:BoundField HeaderText="RelevantExperience" DataField="RelevantExperience" />
                                    </Columns>
                                    <EditRowStyle BackColor="#2461BF" />
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EFF3FB" />
                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <div id="divJobPostLookingForRepeater" runat="server">
                                    <asp:Repeater ID="rptrJobPostLookinFor" runat="server" OnItemCommand="rptrJobPostLookinFor_ItemCommand" OnItemDataBound="rptrJobPostLookinFor_ItemDataBound">
                                        <HeaderTemplate>
                                            <table>
                                                <tr>
                                                    <td colspan="2">
                                                        <h1>Your are looking for this Jobs</h1>
                                                    </td>
                                                </tr>
                                        </HeaderTemplate>
                                        <ItemTemplate>

                                            <tr style="background-color: #EBEFF0">
                                                <td>
                                                    <table style="background-color: #EBEFF0; border-top: 1px dotted #c1650f; width: 300px">
                                                        <tr>
                                                            <td>
                                                                <b>Job Post Looking For</b>
                                                                <asp:Label ID="lblJobPostLooking" runat="server" Text='<%#Eval("JobPostLookingFor") %>' />
                                                                <asp:TextBox ID="txtJobPostLooking" runat="server" Text='<%#Eval("JobPostLookingFor") %>' Visible="false"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <b>Industry</b>
                                                                <asp:Label ID="lblIndustry" runat="server" Text='<%#Eval("IndustryName") %>' />
                                                                <asp:DropDownList ID="ddlIndustry123" runat="server" Visible="false"></asp:DropDownList>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <b>Department</b>
                                                                <asp:Label ID="lblDepartment" runat="server" Text='<%#Eval("DepartmentName") %>' />
                                                                <asp:DropDownList ID="ddlDepartment123" runat="server" Visible="false"></asp:DropDownList>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <b>Functional Role</b>
                                                                <asp:Label ID="lblFunctionalRole" runat="server" Text='<%#Eval("FunctionalArea") %>' />
                                                                <asp:DropDownList ID="ddlFunctionalRole" runat="server" Visible="false"></asp:DropDownList>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <b>Relevant Experience</b>
                                                                <asp:Label ID="lblRelevantExperience" runat="server" Text='<%#Eval("RelevantExperience") %>' />
                                                                <asp:TextBox ID="txtRelevantExperience" runat="server" Text='<%#Eval("RelevantExperience") %>' Visible="false"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <table style="background-color: #EBEFF0; border-top: 1px dotted #c1650f; border-bottom: 1px solid #c1650f; width: 300px">
                                                        <tr>
                                                            <td>
                                                                <asp:LinkButton ID="lnkEdit" runat="server" CommandArgument='<%#Eval("JobPostLookingForId") %>' CommandName="edit">Edit</asp:LinkButton>
                                                                <asp:LinkButton ID="lnkDelete" runat="server" CommandArgument='<%#Eval("JobPostLookingForId") %>' CommandName="delete" OnClientClick="return confirm('Are you sure you want to delete?')">Delete</asp:LinkButton>
                                                                <asp:LinkButton ID="lnkUpdate" runat="server" CommandArgument='<%#Eval("JobPostLookingForId") %>' CommandName="update" Visible="false">Update</asp:LinkButton>
                                                                <asp:LinkButton ID="lnkCancel" runat="server" CommandArgument='<%#Eval("JobPostLookingForId") %>' CommandName="cancel" Visible="false">Cancel</asp:LinkButton>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">&nbsp;</td>
                                            </tr>
                                            </table>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>

        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2"></td>
        </tr>
        <tr>
            <td>Current Anual Salary(Yearly)</td>
            <td>
                <asp:TextBox ID="txtcurrentannualsalary" runat="server"></asp:TextBox>
                lpa</td>
        </tr>
        <tr>
            <td>Expected Anual Salary(Yearly)</td>
            <td>
                <asp:TextBox ID="txtexpectedsalary" runat="server"></asp:TextBox>
                lpa</td>
        </tr>
        <tr>
            <td>Notice Period</td>
            <td>
                <asp:DropDownList ID="ddlNoticePeriod" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>1 Months</asp:ListItem>
                    <asp:ListItem>2 Months</asp:ListItem>
                    <asp:ListItem>3 Months</asp:ListItem>
                    <asp:ListItem>6 Months</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Employment status</td>
            <td>
                <asp:RadioButtonList ID="rblEmploymentStatus" runat="server">
                    <asp:ListItem>Full Time</asp:ListItem>
                    <asp:ListItem>Part Time</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>Job Type</td>
            <td>
                <asp:RadioButtonList ID="rblJobType123" runat="server">
                    <asp:ListItem>Permanent</asp:ListItem>
                    <asp:ListItem>Temporary</asp:ListItem>
                    <asp:ListItem>Freelancing</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>Company Type</td>
            <td>
                <asp:RadioButtonList ID="rblCompanyType123" runat="server">
                    <asp:ListItem>Small</asp:ListItem>
                    <asp:ListItem>Middle</asp:ListItem>
                    <asp:ListItem>MNC</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:UpdatePanel ID="panelLocation" runat="server">
                    <ContentTemplate>
                        <table style="width: 688px">
                            <tr>
                                <td class="auto-style3">Preferred Country</td>
                                <td>
                                    <asp:DropDownList ID="ddlPreferredCountry" OnSelectedIndexChanged="ddlPreferredCountry_SelectedIndexChanged" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">Preferred State</td>
                                <td>
                                    <br />
                                    <asp:TextBox ID="txtPreferredState" runat="server" ReadOnly="true" TextMode="MultiLine" Width="300px"></asp:TextBox>
                                    <asp:Button ID="btnState" runat="server" Text="Select State" OnClick="btnState_Click" />
                                    <asp:Panel ID="PanelState" runat="server" Visible="false" Width="444px">
                                        <asp:CheckBoxList ID="chklState" runat="server" OnSelectedIndexChanged="chklState_SelectedIndexChanged" AutoPostBack="True">
                                        </asp:CheckBoxList>
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td>PreferredCity
                                </td>
                                <td>
                                    <br />
                                    <asp:TextBox ID="txtCity" runat="server" ReadOnly="true" TextMode="MultiLine" Width="300px"></asp:TextBox>
                                    <asp:Button ID="btnCity" runat="server" Text="Select City" OnClick="btnCity_Click" />
                                    <asp:Panel ID="Panelcity" runat="server" Visible="false" Width="444px">
                                        <asp:CheckBoxList ID="chklCity" runat="server" OnSelectedIndexChanged="chklCity_SelectedIndexChanged" AutoPostBack="True">
                                        </asp:CheckBoxList>
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td>PreferredArea
                                </td>
                                <td>
                                    <asp:TextBox ID="txtarea" runat="server" ReadOnly="true" TextMode="MultiLine" Width="300px"></asp:TextBox>
                                    <asp:Button runat="server" ID="btnarea" Text="Select Area" OnClick="btnarea_Click" />
                                    <asp:Panel ID="PanelArea" runat="server" Visible="false" Width="444px">
                                        <asp:CheckBoxList ID="chklArea" runat="server" AutoPostBack="true" RepeatColumns="6" OnSelectedIndexChanged="chklArea_SelectedIndexChanged"></asp:CheckBoxList>
                                    </asp:Panel>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>

        <tr>
            <td>Availability for these Personal Round on Working Day</td>
            <td>
                <asp:RadioButtonList ID="rblYesNo" runat="server">
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>

        <tr>
            <td>Availabilty in Week Days(Monday to Friday)</td>
            <td>Before<asp:DropDownList ID="ddlBeforeHours" runat="server">
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
            </asp:DropDownList>
                <asp:DropDownList ID="ddlBeforeMinutes" runat="server">
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
                    <asp:ListItem>21</asp:ListItem>
                    <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                    <asp:ListItem>24</asp:ListItem>
                    <asp:ListItem>25</asp:ListItem>
                    <asp:ListItem>26</asp:ListItem>
                    <asp:ListItem>27</asp:ListItem>
                    <asp:ListItem>28</asp:ListItem>
                    <asp:ListItem>29</asp:ListItem>
                    <asp:ListItem>31</asp:ListItem>
                    <asp:ListItem>32</asp:ListItem>
                    <asp:ListItem>33</asp:ListItem>
                    <asp:ListItem>34</asp:ListItem>
                    <asp:ListItem>35</asp:ListItem>
                    <asp:ListItem>36</asp:ListItem>
                    <asp:ListItem>37</asp:ListItem>
                    <asp:ListItem>38</asp:ListItem>
                    <asp:ListItem>39</asp:ListItem>
                    <asp:ListItem>40</asp:ListItem>
                    <asp:ListItem>41</asp:ListItem>
                    <asp:ListItem>42</asp:ListItem>
                    <asp:ListItem>43</asp:ListItem>
                    <asp:ListItem>44</asp:ListItem>
                    <asp:ListItem>45</asp:ListItem>
                    <asp:ListItem>46</asp:ListItem>
                    <asp:ListItem>47</asp:ListItem>
                    <asp:ListItem>48</asp:ListItem>
                    <asp:ListItem>49</asp:ListItem>
                    <asp:ListItem>50</asp:ListItem>
                    <asp:ListItem>51</asp:ListItem>
                    <asp:ListItem>52</asp:ListItem>
                    <asp:ListItem>53</asp:ListItem>
                    <asp:ListItem>54</asp:ListItem>
                    <asp:ListItem>55</asp:ListItem>
                    <asp:ListItem>56</asp:ListItem>
                    <asp:ListItem>57</asp:ListItem>
                    <asp:ListItem>58</asp:ListItem>
                    <asp:ListItem>59</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="ddlBeforeTime" runat="server">
                    <asp:ListItem>AM</asp:ListItem>
                    <asp:ListItem>PM</asp:ListItem>
                </asp:DropDownList>
                After<asp:DropDownList ID="ddlAfterHours" runat="server">
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
                </asp:DropDownList>
                <asp:DropDownList ID="ddlAfterMinutes" runat="server">
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
                    <asp:ListItem>21</asp:ListItem>
                    <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                    <asp:ListItem>24</asp:ListItem>
                    <asp:ListItem>25</asp:ListItem>
                    <asp:ListItem>26</asp:ListItem>
                    <asp:ListItem>27</asp:ListItem>
                    <asp:ListItem>28</asp:ListItem>
                    <asp:ListItem>29</asp:ListItem>
                    <asp:ListItem>31</asp:ListItem>
                    <asp:ListItem>32</asp:ListItem>
                    <asp:ListItem>33</asp:ListItem>
                    <asp:ListItem>34</asp:ListItem>
                    <asp:ListItem>35</asp:ListItem>
                    <asp:ListItem>36</asp:ListItem>
                    <asp:ListItem>37</asp:ListItem>
                    <asp:ListItem>38</asp:ListItem>
                    <asp:ListItem>39</asp:ListItem>
                    <asp:ListItem>40</asp:ListItem>
                    <asp:ListItem>41</asp:ListItem>
                    <asp:ListItem>42</asp:ListItem>
                    <asp:ListItem>43</asp:ListItem>
                    <asp:ListItem>44</asp:ListItem>
                    <asp:ListItem>45</asp:ListItem>
                    <asp:ListItem>46</asp:ListItem>
                    <asp:ListItem>47</asp:ListItem>
                    <asp:ListItem>48</asp:ListItem>
                    <asp:ListItem>49</asp:ListItem>
                    <asp:ListItem>50</asp:ListItem>
                    <asp:ListItem>51</asp:ListItem>
                    <asp:ListItem>52</asp:ListItem>
                    <asp:ListItem>53</asp:ListItem>
                    <asp:ListItem>54</asp:ListItem>
                    <asp:ListItem>55</asp:ListItem>
                    <asp:ListItem>56</asp:ListItem>
                    <asp:ListItem>57</asp:ListItem>
                    <asp:ListItem>58</asp:ListItem>
                    <asp:ListItem>59</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="ddlAfterTime" runat="server">
                    <asp:ListItem>AM</asp:ListItem>
                    <asp:ListItem>PM</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="ddlISTETE" runat="server" ToolTip="Please Select TimeZone(IST/EST)">
                    <asp:ListItem>IST</asp:ListItem>
                    <asp:ListItem>EST</asp:ListItem>
                </asp:DropDownList>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hrs&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Min&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hrs&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Min</td>
        </tr>

        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnSaveMoreJobs" runat="server" Text="Save" OnClick="btnSaveMoreJobs_Click" Style="height: 26px" />
                <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
</div>
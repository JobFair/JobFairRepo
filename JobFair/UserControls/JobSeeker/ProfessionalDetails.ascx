<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProfessionalDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.ProfessionalDetails" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
 <div>
     <table id="TableCurrentJob" runat="server" >
        <tr>
            <td   colspan="2" style="font-weight: 700; font-style: italic; text-decoration: underline">
                <h1>Current Job Details</h1>
            </td>
        </tr>
        <tr>
            <td >Resume Headline</td>
            <td >
                <asp:TextBox ID="txtResumeHeadline" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Total Experience</td>
            <td >From<asp:TextBox ID="txtFromdate" runat="server"></asp:TextBox>
                <cc1:CalendarExtender ID="txtFromdate_CalendarExtender" runat="server" BehaviorID="txtFromdate_CalendarExtender" TargetControlID="txtFromdate">
                </cc1:CalendarExtender>
                <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender2" runat="server"  WatermarkText="From Year" TargetControlID="txtFromdate" WatermarkCssClass="c"/>
            To<asp:TextBox ID="txtTill" runat="server"></asp:TextBox>
                <cc1:CalendarExtender ID="txtTill_CalendarExtender" runat="server" BehaviorID="txtTill_CalendarExtender" TargetControlID="txtTill">
                </cc1:CalendarExtender>
                <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender3" runat="server"  WatermarkText="To Year" TargetControlID="txtTill" WatermarkCssClass="c"/>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                

            </td>
        </tr>
        <tr>
            <td >Industry</td>
            <td >
                <asp:DropDownList ID="ddlIndustry" runat="server">
                </asp:DropDownList>
                <br /></td>
        </tr>
        <tr>
            <td >Department</td>
            <td >
                <asp:DropDownList ID="ddlDepartment" runat="server" DataTextField="DepartmentName" DataValueField="DepartmentId">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >Current Job Role</td>
            <td >
                <asp:TextBox ID="txtCurrentJobRole" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender4" runat="server"  WatermarkText="Enter Current Job Role" TargetControlID="txtCurrentJobRole" WatermarkCssClass="c"/>
            </td>
        </tr>
        <tr>
            <td >Primary Functional Role</td>
            <td >
                <asp:DropDownList ID="ddlPrimaryRole" runat="server">
                    <asp:ListItem>Development</asp:ListItem>
                    <asp:ListItem>Testing</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td >
                <table >
                    <tr>
                        <td >Job Description(Role)</td>
                        <td>
                            <asp:TextBox ID="txtJobdescriptionPrimar" runat="server" ></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td >Technical Skills</td>
                        <td>
                            <asp:TextBox ID="txtTechnicalskillPrimary" runat="server" ></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td >Secondary Functional Roles</td>
            <td >
                <asp:DropDownList ID="ddlSecRole" runat="server">
                    <asp:ListItem>Testing</asp:ListItem>
                    <asp:ListItem>Developement</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td >
                <table >
                    <tr>
                        <td >Job Description(Role)</td>
                        <td>
                            <asp:TextBox ID="txtjobdescriptionSec" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td >Technical Skills</td>
                        <td>
                            <asp:TextBox ID="txtTechnicalskillSec" runat="server" ></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td >Designation</td>
            <td >
                <asp:TextBox ID="txtDesignation" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" ></td>
            <td class="auto-style1" ></td>
        </tr>
        <tr>
            <td >Current Employer/Last Employer</td>
            <td >
                <asp:TextBox ID="txtemployeer" runat="server" TextMode="MultiLine" ToolTip="Please Enter Current Employer/Last Employer"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td >&nbsp;</td>
        </tr>
        <tr>
            <td >Reason for Job change</td>
            <td >
                <asp:TextBox ID="txtReasonforJobchange" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Technical skills/Key Skills</td>
            <td >
                <asp:TextBox ID="txtTechSkills" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td >
                <asp:Button ID="btnSaveCurrentJob" runat="server" Text="Save" OnClick="btnSave_Click" />
            &nbsp;
                <asp:Button ID="btncancelCurrentJob" runat="server" Text=" Cancel" />
                <asp:Label ID="lblmsgsave" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
        </div>
    <hr />
    <div>
    <table id="TableDesiredJob" runat="server">
        <tr>
            <td   colspan="2">
                <h1>Desired Job Details</h1>
            </td>
        </tr>
        <tr>
            <td >Job Post Looking for</td>
            <td >
                <asp:TextBox ID="txtJobPostLooking" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Relevant Experience</td>
            <td >
                <asp:TextBox ID="txtReleventExp" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Current Anual Salary(Yearly)</td>
            <td >
                <asp:TextBox ID="txtcurrentannualsalary" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Expected Anual Salary(Yearly)</td>
            <td >
                <asp:TextBox ID="txtexpectedsalary" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Notice Period</td>
            <td >
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
            <td >Employment status</td>
            <td >
                <asp:CheckBoxList ID="cblEmploymentStatus" runat="server">
                    <asp:ListItem>Full Time</asp:ListItem>
                    <asp:ListItem>Part Time</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td >Job Type</td>
            <td >
                <asp:CheckBoxList ID="cblJobType" runat="server" >
                    <asp:ListItem>Permanent</asp:ListItem>
                    <asp:ListItem>Temporary</asp:ListItem>
                    <asp:ListItem>Freelancing</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td >Work Area</td>
            <td >
                <asp:TextBox ID="txtworkarea" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Prefered Country<br />
                Prefered State<br />
                Prefered City</td>
            <td >
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged">
                        </asp:DropDownList>
                        <br />
                        <asp:DropDownList ID="ddlState" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlState_SelectedIndexChanged">
                        </asp:DropDownList>
                        <br />
                        <asp:DropDownList ID="ddlCity" runat="server" Width="69px">
                        </asp:DropDownList>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td >
                <asp:Button ID="btnsaveDesJob" runat="server" Text="Save" OnClick="btnsaveDesJob_Click" />
            &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelDesJob" runat="server" Text="Cancel" />
            </td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td >
                <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
        </div>
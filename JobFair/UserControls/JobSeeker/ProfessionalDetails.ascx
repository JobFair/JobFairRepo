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
                <asp:TextBox ID="txtResumeHeadline" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" runat="server"  WatermarkText="Enter Resume Headline" TargetControlID="txtResumeHeadline" WatermarkCssClass="c"/>
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
                <asp:DropDownList ID="ddlDepartment" runat="server">
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
                            <asp:TextBox ID="txtJobdescriptionPrimar" runat="server" ></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender5" runat="server"  WatermarkText="Enter Job Description(Role)" TargetControlID="txtJobdescriptionPrimar" WatermarkCssClass="c"/>
                        </td>
                    </tr>
                    <tr>
                        <td >Technical Skills</td>
                        <td>
                            <asp:TextBox ID="txtTechnicalskillPrimary" runat="server" ></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender6" runat="server"  WatermarkText="Enter Technical Skills" TargetControlID="txtTechnicalskillPrimary" WatermarkCssClass="c"/>
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
                            <asp:TextBox ID="txtjobdescriptionSec" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender7" runat="server"  WatermarkText="Enter Job Description(Role)" TargetControlID="txtjobdescriptionSec" WatermarkCssClass="c"/>
                        </td>
                    </tr>
                    <tr>
                        <td >Technical Skills</td>
                        <td>
                            <asp:TextBox ID="txtTechnicalskillSec" runat="server" ></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender8" runat="server"  WatermarkText="Enter Technical Skills" TargetControlID="txtTechnicalskillSec" WatermarkCssClass="c"/>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td >Designation</td>
            <td >
                <asp:TextBox ID="txtDesignation" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender9" runat="server"  WatermarkText="Enter Designation" TargetControlID="txtDesignation" WatermarkCssClass="c"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" ></td>
            <td class="auto-style1" ></td>
        </tr>
        <tr>
            <td >Current Employer/Last Employer</td>
            <td >
                <asp:TextBox ID="txtemployeer" runat="server" TextMode="MultiLine" ToolTip="Please Enter Current Employer/Last Employer"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender10" runat="server"  WatermarkText="Enter Current Employer/Last Employer" TargetControlID="txtemployeer" WatermarkCssClass="c"/>
            </td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td >&nbsp;</td>
        </tr>
        <tr>
            <td >Reason for Job change</td>
            <td >
                <asp:TextBox ID="txtReasonforJobchange" runat="server" TextMode="MultiLine"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender11" runat="server"  WatermarkText="Enter Reason for Job change" TargetControlID="txtReasonforJobchange" WatermarkCssClass="c"/>
            </td>
        </tr>
        <tr>
            <td >Technical skills/Key Skills</td>
            <td >
                <asp:TextBox ID="txtTechSkills" runat="server" TextMode="MultiLine"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender12" runat="server"  WatermarkText="Enter Technical skills/Key Skills" TargetControlID="txtTechSkills" WatermarkCssClass="c"/>
            </td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td >
                <asp:Button ID="btnSaveCurrentJob" runat="server" Text="Save" OnClick="btnSave_Click" />
            &nbsp;
                <asp:Button ID="btncancelCurrentJob" runat="server" Text=" Cancel" />
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
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
                <asp:TextBox ID="txtJobPostLooking" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender13" runat="server"  WatermarkText="Enter Job Post Looking for" TargetControlID="txtJobPostLooking" WatermarkCssClass="c"/>
            </td>
        </tr>
        <tr>
            <td >Relevant Experience</td>
            <td >
                <asp:TextBox ID="txtReleventExp" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender14" runat="server"  WatermarkText="Enter Relevant Experience" TargetControlID="txtReleventExp" WatermarkCssClass="c"/>
            </td>
        </tr>
        <tr>
            <td >Current Anual Salary(Yearly)</td>
            <td >
                <asp:TextBox ID="txtcurrentannualsalary" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender15" runat="server"  WatermarkText="Enter Current Anual Salary(Yearly)" TargetControlID="txtcurrentannualsalary" WatermarkCssClass="c"/>
            </td>
        </tr>
        <tr>
            <td >Expected Anual Salary(Yearly)</td>
            <td >
                <asp:TextBox ID="txtexpectedsalary" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender16" runat="server"  WatermarkText="Enter Expected Anual Salary(Yearly)" TargetControlID="txtexpectedsalary" WatermarkCssClass="c"/>
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
                <asp:TextBox ID="txtworkarea" runat="server"></asp:TextBox><cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender17" runat="server"  WatermarkText="Eg. South India etc." TargetControlID="txtworkarea" WatermarkCssClass="c"/>
            </td>
        </tr>
        <tr>
            <td >Prefered Country</td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td >Prefered State</td>
            <td >
                <asp:DropDownList ID="ddlPreferedState" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >Prefered Job Location</td>
            <td >
                <asp:DropDownList ID="ddlPreferedJobLocation" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td >
                <asp:Button ID="btnsaveDesJob" runat="server" Text="Save" />
            &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelDesJob" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
        </div>
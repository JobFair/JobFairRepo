<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProfessionalDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.ProfessionalDetails" %>
<script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
<script type="text/javascript">
    
    $("#lbPastEmployer").bind("click", function () {
        var div = $("<div />");
        div.html(GetDynamicTextBox(""));
        $("#TextBoxContainer").append(div);
    });
   
    function GetDynamicTextBox(value) {
        return 'Company<input name = "CompanyName" type="text" value = "' + value.value1 + '" /><br/>' +
                'Designation<input type="text" name="designation"  value="'+value.value2+'" /><br/>'+
                'Duration<input type="text" name="From" value="' + value.value3 + '"/>&nbsp;'+
            '<input type="text" name="From" value="' + value.value4 + '"/>'
    }
</script>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<div>
    <table id="TableCurrentJob" runat="server">
        <tr>
            <td colspan="2">
                <h1>Current Job Details</h1>
            </td>
        </tr>
        <tr>
            <td>Resume Headline</td>
            <td>
                <asp:TextBox ID="txtResumeHeadline" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Total Experience</td>
            <td>
                <asp:Label ID="lblYear" runat="server" Text=""></asp:Label>
                &nbsp;Years &amp;
                <asp:Label ID="lblMonth" runat="server" Text=""></asp:Label>
                &nbsp;Months</td>
        </tr>
        <tr>
            <td>Currently You Are?</td>
            <td>
                <asp:RadioButton ID="rbtEmployed" Text="Employed" runat="server" OnCheckedChanged="rbtEmployed_CheckedChanged" AutoPostBack="True" GroupName="EmplyeeORNot" />
                &nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="rbtUnEmployed" Text="UnEmployed" runat="server" AutoPostBack="True" GroupName="EmplyeeORNot" OnCheckedChanged="rbtUnEmployed_CheckedChanged" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <div id="divExperience" runat="server" visible="false">
                    <table>
                        <tr>
                            <td>Do You Have?
                            </td>
                            <td>
                                <asp:RadioButton ID="rbtPastExperience" Text="Past Experience" runat="server" AutoPostBack="True" GroupName="ExperienceOrNot" OnCheckedChanged="rbtPastExperience_CheckedChanged" />
                                <asp:RadioButton ID="rbtNoExpeience" runat="server" Text="No Experience" AutoPostBack="True" GroupName="ExperienceOrNot" OnCheckedChanged="rbtNoExpeience_CheckedChanged" />
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <div id="divCurrentEmployer" visible="false" runat="server">
                    <table>
                        <tr>
                            <td colspan="2">
                                <h1>Current Employer</h1>
                            </td>
                        </tr>
                        <tr>
                            <td>Current Designation</td>
                            <td>
                                <asp:TextBox ID="txtCurrentDesignation" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Current Employer</td>
                            <td>
                                <asp:TextBox ID="txtCurrentEmployer" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Duration</td>
                            <td>
                                <asp:TextBox ID="txtFromCurrent" runat="server"></asp:TextBox>
                                <cc1:TextBoxWatermarkExtender ID="txtFromCurrent_TextBoxWatermarkExtender" runat="server" BehaviorID="txtFromCurrent_TextBoxWatermarkExtender" TargetControlID="txtFromCurrent" WatermarkText="From" />
                                <cc1:CalendarExtender ID="txtFromCurrent_CalendarExtender" runat="server" BehaviorID="txtFromCurrent_CalendarExtender" TargetControlID="txtFromCurrent" />
                                <asp:TextBox ID="txtTillCurrent" runat="server"></asp:TextBox>
                                <cc1:TextBoxWatermarkExtender ID="txtTillCurrent_TextBoxWatermarkExtender" runat="server" BehaviorID="txtTillCurrent_TextBoxWatermarkExtender" TargetControlID="txtTillCurrent" WatermarkText="Till" />
                                <cc1:CalendarExtender ID="txtTillCurrent_CalendarExtender" runat="server" BehaviorID="txtTillCurrent_CalendarExtender" TargetControlID="txtTillCurrent" />
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
                            <td>Primary Functional Role</td>
                            <td>
                                <asp:DropDownList ID="ddlPrimaryRole" runat="server">
                                    <asp:ListItem>Development</asp:ListItem>
                                    <asp:ListItem>Testing</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                      
                        <tr>
                            <td>Secondary Functional Roles</td>
                            <td>
                                <asp:DropDownList ID="ddlSecRole" runat="server">
                                    <asp:ListItem>Testing</asp:ListItem>
                                    <asp:ListItem>Developement</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Employment status</td>
                            <td>
                                <asp:CheckBoxList ID="CheckBoxList2" runat="server">
                                    <asp:ListItem>Full Time</asp:ListItem>
                                    <asp:ListItem>Part Time</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                        </tr>
                        <tr>
                            <td>Job Type</td>
                            <td>
                                <asp:CheckBoxList ID="CheckBoxList3" runat="server">
                                    <asp:ListItem>Permanent</asp:ListItem>
                                    <asp:ListItem>Temporary</asp:ListItem>
                                    <asp:ListItem>Freelancing</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                        </tr>
                        <tr>
                            <td>Company Type</td>
                            <td>
                                <asp:CheckBoxList ID="CheckBoxList4" runat="server">
                                    <asp:ListItem>Small</asp:ListItem>
                                    <asp:ListItem>Middle</asp:ListItem>
                                    <asp:ListItem>MNC</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:LinkButton ID="lbPastEmployer" runat="server" Text="PastExperience" OnClientClick="AddMorePastJob()" OnClick="lbPastEmployer_Click"></asp:LinkButton>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <div id="TextBoxContainer" runat="server">
    <!--Textboxes will be added here -->
</div>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>

        <tr>
            <td colspan="2">
                <div id="divPastEmloyer" runat="server" visible="false">
                    <table>
                        <tr>
                            <td colspan="2">
                                <h1>Past Experience</h1>
                            </td>
                        </tr>
                        <tr>
                            <td>Past Designation
                            </td>
                            <td>
                                <asp:TextBox ID="txtPastDesignation" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Past Employer</td>
                            <td>
                                <asp:TextBox ID="txtPastEmployer" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Duration</td>
                            <td>
                                <asp:TextBox ID="txtFromDate" runat="server"></asp:TextBox>
                                <cc1:CalendarExtender ID="txtFromDate_CalendarExtender" runat="server" BehaviorID="txtFromDate_CalendarExtender" TargetControlID="txtFromDate" />
                                <cc1:TextBoxWatermarkExtender ID="txtFromDate_TextBoxWatermarkExtender" runat="server" BehaviorID="txtFromDate_TextBoxWatermarkExtender" TargetControlID="txtFromDate" WatermarkText="From" />
                                <asp:TextBox ID="txtTillDate" runat="server"></asp:TextBox>
                                <cc1:CalendarExtender ID="txtTillDate_CalendarExtender" runat="server" BehaviorID="txtTillDate_CalendarExtender" TargetControlID="txtTillDate" />
                                <cc1:TextBoxWatermarkExtender ID="txtTillDate_TextBoxWatermarkExtender" runat="server" BehaviorID="txtTillDate_TextBoxWatermarkExtender" TargetControlID="txtTillDate" WatermarkText="Till" />
                            </td>
                        </tr>
                        <tr>
                            <td>Industry</td>
                            <td>
                                <asp:DropDownList ID="ddlPastIndustry" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Department</td>
                            <td>
                                <asp:DropDownList ID="ddlPastDepartment" runat="server" DataTextField="DepartmentName" DataValueField="DepartmentId">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Primary Functional Role</td>
                            <td>
                                <asp:DropDownList ID="ddlPastPrimaryRole" runat="server">
                                    <asp:ListItem>Development</asp:ListItem>
                                    <asp:ListItem>Testing</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                       
                        <tr>
                            <td>Secondary Functional Roles</td>
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem>Testing</asp:ListItem>
                                    <asp:ListItem>Developement</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>

                      

                        <tr>
                            <td>Reason For JobChange</td>
                            <td>
                                <asp:TextBox ID="txtPastReasonforJobchange" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
            </tr>

            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnSaveCurrentJob" runat="server" Text="Save" />
                    &nbsp;
                <asp:Button ID="btncancelCurrentJob" runat="server" Text=" Cancel" />
                    <asp:Label ID="lblmsgsave" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
    </table>
</div>
<hr />
<div id="divDesireJobDetails" runat="server" visible="false">
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
                    <asp:ListItem>Servicing Notice Period</asp:ListItem>
                    <asp:ListItem>Unemployed</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Job Post Looking For</td>
            <td>
                <asp:TextBox ID="txtJobPostLooking" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Industry</td>
            <td>
                <asp:DropDownList ID="ddlDesiredIndustry" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Department</td>
            <td>
                <asp:DropDownList ID="ddlDesiredDepartment" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Functional Role</td>
            <td>&nbsp;<asp:DropDownList ID="ddlDesiredFunctionalRole" runat="server">
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
            <td colspan="2">
                <asp:LinkButton ID="lbAddMoreJobPost" runat="server" OnClick="lbAddMoreJobPost_Click">Add more Job Post</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <div id="divAddMoreJob" runat="server" visible="false">
                    <table>
                        <tr>
                            <td colspan="2"><h1>Add More Jobs</h1></td>
                        </tr>
                       <tr>
            <td>Job Post Looking For</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Industry</td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Department</td>
            <td>
                <asp:DropDownList ID="DropDownList3" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Functional Role</td>
            <td>&nbsp;<asp:DropDownList ID="DropDownList4" runat="server">
            </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Relevant Experience</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
                    </table>
                    
                </div></td>
        </tr>
        <tr>
            <td>Current Anual Salary(Yearly)</td>
            <td>
                <asp:TextBox ID="txtcurrentannualsalary" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Expected Anual Salary(Yearly)</td>
            <td>
                <asp:TextBox ID="txtexpectedsalary" runat="server"></asp:TextBox>
            </td>
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
            <td>Reason for Job change</td>
            <td>
                <asp:TextBox ID="txtDesiredReasonforJobchange" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Employment status</td>
            <td>
                <asp:CheckBoxList ID="cblEmploymentStatus" runat="server">
                    <asp:ListItem>Full Time</asp:ListItem>
                    <asp:ListItem>Part Time</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td>Job Type</td>
            <td>
                <asp:CheckBoxList ID="cblJobType" runat="server">
                    <asp:ListItem>Permanent</asp:ListItem>
                    <asp:ListItem>Temporary</asp:ListItem>
                    <asp:ListItem>Freelancing</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td>Company Type</td>
            <td>
                <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                    <asp:ListItem>Small</asp:ListItem>
                    <asp:ListItem>Middle</asp:ListItem>
                    <asp:ListItem>MNC</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        Preferred City<asp:DropDownList ID="ddlCity" runat="server" Width="69px">
                        </asp:DropDownList>
                        <br />
                        Preferred Area
                        <asp:DropDownList ID="ddlArea" runat="server">
                        </asp:DropDownList>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
     
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnsaveDesJob" runat="server" Text="Save" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelDesJob" runat="server" Text="Cancel" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
</div>
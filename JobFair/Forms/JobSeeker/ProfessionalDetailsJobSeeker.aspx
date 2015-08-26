<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="ProfessionalDetailsJobSeeker.aspx.cs" Inherits="JobFair.Forms.JobSeeker.ProfessionalDetailsJobSeeker" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td   colspan="2" style="font-weight: 700; font-style: italic; text-decoration: underline">
                <h1>Current Job Details</h1>
            </td>
        </tr>
        <tr>
            <td >Resume Headline</td>
            <td >
                <asp:TextBox ID="txtResumeHead" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Total Experience</td>
            <td >From<asp:TextBox ID="txtFromdate" runat="server"></asp:TextBox>
            To<asp:TextBox ID="txtTill" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Industry</td>
            <td >
                <asp:DropDownList ID="ddlIndustry" runat="server" DataSourceID="SqlDataSource2" DataTextField="Industry_Name" DataValueField="Industry_Name">
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
                <asp:DropDownList ID="ddlCurrentJobRole" runat="server">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >Primary Functional Role</td>
            <td >
                <asp:DropDownList ID="ddlPrimRole" runat="server">
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
                            <asp:TextBox ID="txtJobdescription" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td >Technical Skills</td>
                        <td>
                            <asp:TextBox ID="txtTechnicalskill" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td >Secondary Functional Roles</td>
            <td >
                <asp:DropDownList ID="ddlSecRole" runat="server">
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
                            <asp:TextBox ID="txtjobdescriptionrole" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td >Technical Skills</td>
                        <td>
                            <asp:TextBox ID="txttechnicalskills1" runat="server"></asp:TextBox>
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
            <td >&nbsp;</td>
            <td >&nbsp;</td>
        </tr>
        <tr>
            <td >Current Employer/Last Employer</td>
            <td >
                <asp:TextBox ID="txtemployeer" runat="server"></asp:TextBox>
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
                <asp:Button ID="btnSave" runat="server" Text="Save" />
            &nbsp;
                <asp:Button ID="btncancel" runat="server" Text=" Cancel" />
            </td>
        </tr>
    </table>
    <hr />
    <table>
        <tr>
            <td   colspan="2">
                <h1>Desired Job Details</h1>
            </td>
        </tr>
        <tr>
            <td >Job Post Looking for</td>
            <td >
                <asp:TextBox ID="txtjobpostlookingfor" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Relevant Experience</td>
            <td >
                <asp:TextBox ID="txtreleventexp" runat="server"></asp:TextBox>
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
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >Employment status</td>
            <td >
                <asp:DropDownList ID="ddlEmployementStatus" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >Job Type</td>
            <td >
                <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                </asp:CheckBoxList>
                <asp:CheckBoxList ID="CheckBoxList2" runat="server">
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
                <asp:Button ID="btnsave1" runat="server" Text="Save" />
            &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancel1" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</asp:Content>

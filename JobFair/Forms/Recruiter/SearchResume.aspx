<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchResume.aspx.cs" Inherits="JobFair.Forms.Recruiter.SearchResume" %>

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

            <table>
                <tr>
                    <td colspan="2"><h2>Search Resume</h2></td>
                </tr>
                <tr>
                    <td>Client Name</td>
                    <td>
                        <asp:DropDownList ID="ddlClientName" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlClientName_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Position</td>
                    <td>
                        <asp:DropDownList ID="ddlPosition" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPosition_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Requirement ID</td>
                    <td>
                        <asp:Label ID="lblRequirementId" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    <div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem>Boolean Search</asp:ListItem>
            <asp:ListItem>Keywords</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Panel ID="pnlBooleanSearch" runat="server">
            <div>
                <table>
                    <tr>
                        <td>Any Keywords</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>All Keywords</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Excluding Keywords</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>&nbsp;Work Status</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                    <td>
                       Total Experience
                    </td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                            &nbsp;To
                            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Current Annual Salary</td>
                        <td>
                            <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
                            &nbsp;To
                            <asp:DropDownList ID="DropDownList4" runat="server"></asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Expected Annual Salary</td>
                        <td>
                            <asp:DropDownList ID="DropDownList7" runat="server">
                            </asp:DropDownList>
                            &nbsp;To
                            <asp:DropDownList ID="DropDownList8" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Current Location</td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Preferred Location</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </div>
            <div>
                <table>
                    <tr>
                        <td><h3>Employment Details</h3></td>
                    </tr>
                    <tr>
                        <td>
                            Functional Area
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFunctionalArea" runat="server"></asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Industry</td>
                        <td>
                            <asp:DropDownList ID="ddlIndustry" runat="server"></asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Department</td>
                        <td>
                            <asp:DropDownList ID="ddlDepartment" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Keyword Role Skills</td>
                        <td>
                            <asp:TextBox ID="txtRoleSkills" runat="server"></asp:TextBox>
                            <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtRoleSkills" MinimumPrefixLength="1"
                            EnableCaching="false" CompletionSetCount="1" CompletionInterval="10" ServiceMethod="GetRoles" DelimiterCharacters="," FirstRowSelected="false" ShowOnlyCurrentWordInCompletionListItem="true"></cc1:AutoCompleteExtender>
                        </td>
                    </tr>
                    <tr>
                        <td>Keyword Technical Skills</td>
                        <td>
                            <asp:TextBox ID="txtTechnicalSkills" runat="server"></asp:TextBox>
                            <cc1:AutoCompleteExtender ID="AutoCompleteExtender2" runat="server" TargetControlID="txtTechnicalSkills" MinimumPrefixLength="1" EnableCaching="false"
                            CompletionSetCount="1" CompletionInterval="10" ServiceMethod="GetTechnicalskill" DelimiterCharacters="," FirstRowSelected="false" ShowOnlyCurrentWordInCompletionListItem="true"></cc1:AutoCompleteExtender>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Employers
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Exclude Employers
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Designation
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Notice Period
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
            <div>
                <table>
                    <tr>
                        <td>
                          <h3>Educational Details</h3>
                        </td>
                    </tr>
                    <tr>
                        <td>

                            Highest Qualification</td>
                        <td>

                            <asp:DropDownList ID="DropDownList12" runat="server">
                            </asp:DropDownList>

                        </td>
                    </tr>
                    <tr>
                        <td>

                            Doctorate/ PHD Degree

                        </td>
                        <td>

                        </td>
                    </tr>
                    <tr>
                        <td>Masters Degree</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>PG Diploma</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>Bachelors Degree</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>UG Diploma</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>HSC/12th</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>SSC/10th</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>Certifications</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>Workshops</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>Language Known</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </div>
            <div>
                <table>
                    <tr>
                        <td>
                           <h3>Affirmative Action</h3>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Women Candidates Only
                        </td>
                        <td>
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>Male Candidates Only</td>
                        <td>
                            <asp:CheckBox ID="CheckBox2" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>Candidate with Special Abilities Only</td>
                        <td>
                            <asp:CheckBox ID="CheckBox3" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>Candidate with Sports Abilities</td>
                        <td>
                            <asp:CheckBox ID="CheckBox4" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <div>
                <table>
                    <tr>
                        <td>
                            <h3>Additional Details</h3>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Candidate Age
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList10" runat="server"></asp:DropDownList>
                            To 
                            <asp:DropDownList ID="DropDownList11" runat="server"></asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Employment Status</td>
                        <td>
                            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                            </asp:CheckBoxList>
                        </td>
                    </tr>
                    <tr>
                        <td>Job Type</td>
                        <td>
                            <asp:CheckBoxList ID="CheckBoxList2" runat="server">
                            </asp:CheckBoxList>
                        </td>
                    </tr>
                </table>
            </div>
            <div>
                <asp:Button ID="Button1" runat="server" Text="Find Resume" />
            </div>
        </asp:Panel>
        <asp:Panel ID="pnlKeywords" runat="server"></asp:Panel>
    </div>
    </form>
    </body>
</html>
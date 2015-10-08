<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="PostNewJob.aspx.cs" Inherits="JobFair.Forms.Recruiter.PostNewJob" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="DropDownCheckBoxes" Namespace="Saplin.Controls" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table>
                <tr>
                    <td>
                        <h1>Post New Job</h1>
                    </td>
                </tr>
                <tr>
                    <td>Job Title/Designation</td>
                    <td>
                        <asp:TextBox ID="txtJobtitle" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>

                    <td>Job Locations</td>
                    <td>
                        <asp:TextBox ID="txtJobLocation" runat="server"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>Job Locations Area</td>
                    <td>
                        <asp:TextBox ID="txtJobLocationArea" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Company Level</td>
                    <td>
                        <asp:DropDownList ID="ddlCompanyLevel" runat="server" AutoPostBack="True">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Startup Company</asp:ListItem>
                            <asp:ListItem>Small Scale Company</asp:ListItem>
                            <asp:ListItem>Mid Level Company</asp:ListItem>
                            <asp:ListItem>MNC</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Industry</td>
                    <td>
                        <asp:DropDownList ID="ddlIndustry" runat="server" Height="19px">
                        </asp:DropDownList>
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
                    <td>Functional Area</td>
                    <td>
                        <asp:DropDownList ID="ddlFunArea" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Job Description</td>
                    <td>
                        <asp:TextBox ID="txtJobDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Keywords/Skillsets Roles</td>
                    <td>
                        <asp:TextBox ID="txtKeyRoles" runat="server" Height="26px" Width="292px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Keywords/Skillsets Technical</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtKeyTechnical" runat="server" Height="22px" Width="285px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Work Experience</td>
                    <td>From
                        <asp:TextBox ID="txtFromdate" runat="server"></asp:TextBox>
                        <cc1:CalendarExtender ID="txtFromdate_CalendarExtender" runat="server" BehaviorID="txtFromdate_CalendarExtender" TargetControlID="txtFromdate"></cc1:CalendarExtender>
                        <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender2" runat="server" WatermarkText="From Year" TargetControlID="txtFromdate" WatermarkCssClass="c" />
                        &nbsp;To
                        <asp:TextBox ID="txtTill" runat="server" Height="16px" Width="100px"></asp:TextBox>
                        <cc1:CalendarExtender ID="txtTill_CalendarExtender" runat="server" BehaviorID="txtTill_CalendarExtender" TargetControlID="txtTill"></cc1:CalendarExtender>
                        <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender3" runat="server" WatermarkText="To Year" TargetControlID="txtTill" WatermarkCssClass="c" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td>Gender</td>
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
                    <td>Offered Anual Salary</td>
                    <td>&nbsp;&nbsp;<asp:DropDownList ID="ddlsalarymin" runat="server">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>5000</asp:ListItem>
                        <asp:ListItem>10,000</asp:ListItem>
                        <asp:ListItem>15,000</asp:ListItem>
                        <asp:ListItem>20,000</asp:ListItem>
                        <asp:ListItem>25,000</asp:ListItem>
                        <asp:ListItem>30,000</asp:ListItem>
                        <asp:ListItem>35,000</asp:ListItem>
                        <asp:ListItem>40,000</asp:ListItem>
                        <asp:ListItem>45,000</asp:ListItem>
                        <asp:ListItem>50,000</asp:ListItem>
                    </asp:DropDownList>
                        &nbsp;<asp:Label ID="lblmin" runat="server" Text="Min"></asp:Label>
                        &nbsp;&nbsp;
                <asp:DropDownList ID="ddlsalarymax" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>5000</asp:ListItem>
                    <asp:ListItem>60,000</asp:ListItem>
                    <asp:ListItem>65,000</asp:ListItem>
                    <asp:ListItem>70,000</asp:ListItem>
                    <asp:ListItem>75,000</asp:ListItem>
                    <asp:ListItem>80,000</asp:ListItem>
                    <asp:ListItem>85,000</asp:ListItem>
                    <asp:ListItem>90,000</asp:ListItem>
                    <asp:ListItem>95,000</asp:ListItem>
                </asp:DropDownList>
                        &nbsp;
                <asp:Label ID="lblmin0" runat="server" Text="Max"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;OtherSalaryDetails</td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtsalarydetaills" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td>Number of Vacancies</td>
                    <td>
                        <asp:TextBox ID="txtVacancies" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Posted Date</td>
                    <td>
                        <asp:TextBox ID="txtdate" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" />
                    </td>
                    <td>
                        <asp:Button ID="btnPostJob" runat="server" Text="Post Job" OnClick="btnPostJob_Click" />
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>

            <div id="divMain" runat="server" style="min-height: 500px; padding: 10px">
                <h2>Desired Candidate Profile &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h2>

                <table>
                    <asp:Label ID="lblSSCHead" runat="server" Text="Specify SSC / 10th Qualification"></asp:Label>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblSSCTag" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:RadioButtonList ID="rblSSC" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <table style="width: 358px">
                    <asp:Label ID="lblHSCHead" runat="server" Text="Specify HSC / 12th Qualification"></asp:Label>
                    <tr>

                        <td colspan="2">
                            <asp:DropDownCheckBoxes ID="DropDownCheckBoxes1" runat="server" UseSelectAllNode="false" OnSelectedIndexChanged="DropDownCheckBoxes1_SelectedIndexChanged" AutoPostBack="true">
                                <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                                <Items>
                                    <asp:ListItem Value="0">Select</asp:ListItem>
                                    <asp:ListItem Value="1" Text="Arts"></asp:ListItem>
                                    <asp:ListItem Value="2" Text="Commerce"></asp:ListItem>
                                    <asp:ListItem Value="3" Text="Science"></asp:ListItem>
                                    <asp:ListItem Value="4" Text="Others"></asp:ListItem>
                                </Items>
                            </asp:DropDownCheckBoxes>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblHSCSelect" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbHSC" runat="server">Remove All</asp:LinkButton>
                        </td>
                    </tr>

                    <tr>
                        <td colspan="2">
                            <asp:RadioButtonList ID="rblHSC" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <table>
                    <asp:Label ID="lblUGDHead" runat="server" Text="Specify UG Diploma Qualification"></asp:Label>
                    <tr>
                        <td colspan="2">
                            <asp:DropDownCheckBoxes ID="ddlUGDiploma" runat="server" UseSelectAllNode="false">
                                <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                            </asp:DropDownCheckBoxes>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblUGDSelect" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbUGD" runat="server">Remove All</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblUGDTag" runat="server">Empty</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:RadioButtonList ID="rblUGD" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <table>
                    <asp:Label ID="lblBDHead" runat="server" Text="Specify Bachelors Degree Qualification"></asp:Label>
                    <tr>
                        <td colspan="2">
                            <asp:DropDownCheckBoxes ID="ddlBachelorsDegree" runat="server" UseSelectAllNode="false">
                                <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                            </asp:DropDownCheckBoxes>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblBDSelect" runat="server" Text="Selected Qualifications"></asp:Label>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbBD" runat="server">Remove All</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblBDTag" runat="server" CssClass="label">Empty</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:RadioButtonList ID="rblBD" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <table>
                    <asp:Label ID="lblPGDHead" runat="server" Text="Specify PG Deploma Qualification"></asp:Label>
                    <tr>
                        <td>
                            <asp:DropDownCheckBoxes ID="ddlPGDiploma" runat="server" UseSelectAllNode="false">
                                <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                            </asp:DropDownCheckBoxes>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblPGDSelect" runat="server" Text="Selected Qualifications"></asp:Label>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbPGD" runat="server">Remove All</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblPGDTag" runat="server">Empty</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:RadioButtonList ID="rblPGD" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <table>
                    <asp:Label ID="lblMDHead" runat="server" Text="Specify Master Degree Qualification"></asp:Label>
                    <tr>
                        <td colspan="2">
                            <asp:DropDownCheckBoxes ID="ddlMasterDegree" runat="server" UseSelectAllNode="false">
                                <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                            </asp:DropDownCheckBoxes>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblMDSelect" runat="server" Text="Selected Qualifications"></asp:Label>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbMD" runat="server">Remove All</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblMDTag" runat="server" CssClass="label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:RadioButtonList ID="rblMD" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <table>
                    <asp:Label ID="lblPHDHead" runat="server" Text="Specify Doctorate / PHD Qualification"></asp:Label>
                    <tr>
                        <td colspan="2">
                            <asp:DropDownCheckBoxes ID="ddlPHD" runat="server" UseSelectAllNode="false">
                                <Style SelectBoxWidth="230" DropDownBoxBoxWidth="230" />
                            </asp:DropDownCheckBoxes>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblPHDSelect" runat="server" Text="Selected Qualifications"></asp:Label>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbPHD" runat="server">Remove All</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblPHDTag" runat="server" CssClass="label">Empty</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:RadioButtonList ID="rblPHDHead" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>And</asp:ListItem>
                                <asp:ListItem>Or</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
            </div>
            <div>
                <asp:DropDownList ID="ddlQuestionary" runat="server"></asp:DropDownList>
            </div>
        </div>
    </form>
</body>
</html>
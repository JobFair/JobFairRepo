﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EducationalDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.EducationalDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<%@ Register Src="~/UserControls/JobSeeker/MoreCertifications.ascx" TagName="MoreCertifications" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/JobSeeker/MoreWorkshops.ascx" TagName="MoreWorkshops" TagPrefix="uc3" %>

<link href="../../Css/Style.css" rel="stylesheet" />
<link href="../../Css/Common.css" rel="stylesheet" />


<div id="divMain" runat="server">

    <h2>Highest Qualification&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlHQ" runat="server">
        </asp:DropDownList>
    </h2>
    <p>
        <asp:Label ID="lblInfo" runat="server" Text="Kindly select checkboxes for the Degrees you have completed*" ForeColor="Red"></asp:Label>
    </p>
    <table>
        <tr>
            <td>
                <asp:CheckBoxList ID="chkList" runat="server" RepeatDirection="Horizontal">
                    <%--<asp:ListItem runat="server" Text="  Certifications" Value="8" AutoPostBack="True"></asp:ListItem>
                    <asp:ListItem runat="server" Text="  Workshops" Value="9" AutoPostBack="True"></asp:ListItem>--%>
                </asp:CheckBoxList></td>
            <td style="padding-left: 25px;">
                <asp:Button ID="btnGo" runat="server" Text="Go" OnClick="btnGo_Click" CssClass="button" /></td>
        </tr>
    </table>


    <br />
    <hr />
    <br />

    <asp:Panel ID="pnlCollapsableSSC" runat="server" Visible="False" CssClass="pnlCSS">
        <table>
            <asp:Label ID="lblSSCHead" runat="server" Text=" SSC / 10th Details" CssClass="label"></asp:Label>
            <br />
            <br />
            <tr>
                <td>
                    <asp:Label ID="lblSSCMedium" runat="server" Text="Medium of Education" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSSCMedium" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSSCStat" runat="server" Text="Status" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rblSSCStat" runat="server" RepeatDirection="Horizontal" CssClass="MultipleSelectionDDL" Width="100px">
                        <asp:ListItem>Appeared</asp:ListItem>
                        <asp:ListItem>Completed</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSSCYearFrom" runat="server" Text="From" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlSSCMonthFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlSSCYearFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="lblSSCYearTo" runat="server" Text="To" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlSSCMonthTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlSSCYearTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="lblSSCSchool" runat="server" Text="School" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSSCSchool" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSSCBoard" runat="server" Text="Board" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSSCBoard" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSSCPercentage" runat="server" Text="Percentage" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSSCPercentage" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <br />

    <asp:Panel ID="pnlCollapsableHSC" runat="server" Visible="false" CssClass="pnlCSS">
        <table>
            <asp:Label ID="lblHSCHead" runat="server" Text=" HSC / 12th Details" CssClass="label"></asp:Label>
            <br />
            <br />
            <tr>
                <td>
                    <asp:Label ID="lblHSCMedium" runat="server" CssClass="label" Text="Medium of Education"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHSCMedium" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHSCStat" runat="server" CssClass="label" Text="Status"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rblHSCStat" runat="server" CssClass="MultipleSelectionDDL" RepeatDirection="Horizontal" Width="100px">
                        <asp:ListItem>Appeared</asp:ListItem>
                        <asp:ListItem>Completed</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHSCSpecialization" runat="server" CssClass="label" Text="Specialization"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlHSC" runat="server" AutoPostBack="True" Height="16px" Width="100px">
                        <asp:ListItem Value="0">Select</asp:ListItem>
                        <asp:ListItem Text="Arts" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Commerce" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Science" Value="3"></asp:ListItem>
                        <asp:ListItem Text="Others" Value="4"></asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="txtHSCAdd" runat="server" Height="17px" Visible="False" Width="62px"></asp:TextBox>
                    <asp:Button ID="btnHSCAdd" runat="server" Text="Add" Visible="False" CssClass="button" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHSCYearFrom" runat="server" Text="From" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlHSCMonthFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlHSCYearFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>

                 <td>
                    <asp:Label ID="lblHSCYearTo" runat="server" Text="To" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlHSCMonthTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlHSCYearTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="lblHSCCollege" runat="server" CssClass="label" Text="College"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHSCCollege" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHSCBoard" runat="server" CssClass="label" Text="Board"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHSCBoard" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHSCPercentage" runat="server" CssClass="label" Text="Percentage"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHSCPercentage" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <br />

    <asp:Panel ID="pnlCollapsableDip" runat="server" Visible="false" CssClass="pnlCSS">
        <table>
            <asp:Label ID="lblDipHead" runat="server" Text=" UG Diploma Details" CssClass="label"></asp:Label>
            <br />
            <br />
            <tr>
                <td>
                    <asp:Label ID="lblDipMedium" runat="server" CssClass="label" Text="Medium of Education"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDipMedium" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDipStat" runat="server" CssClass="label" Text="Status"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rblDipStat" runat="server" CssClass="MultipleSelectionDDL" RepeatDirection="Horizontal" Width="100px">
                        <asp:ListItem>Appeared</asp:ListItem>
                        <asp:ListItem>Completed</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDipSpecialization" runat="server" CssClass="label" Text="Specialization"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlDip" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlDip_SelectedIndexChanged" Width="100px">
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="txtDipAdd" runat="server" Height="17px" Visible="False" Width="62px"></asp:TextBox>
                    <asp:Button ID="btnDipAdd" runat="server" OnClick="btnDipAdd_Click" Text="Add" Visible="False" CssClass="button" />
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="lblDipYearFrom" runat="server" Text="From" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlDipMonthFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlDipYearFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>

                 <td>
                    <asp:Label ID="lblDipYearTo" runat="server" Text="To" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlDipMonthTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlDipYearTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="lblDipCollege" runat="server" CssClass="label" Text="College"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDipCollege" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDipUniversity" runat="server" CssClass="label" Text="University"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDipUniversity" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDipPercentage" runat="server" CssClass="label" Text="Percentage"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDipPercentage" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <br />

    <asp:Panel ID="pnlCollapsableBD" runat="server" Visible="false" CssClass="pnlCSS">
        <table>
            <asp:Label ID="lblBDHead" runat="server" Text="Bachelors Degree Details" CssClass="label"></asp:Label>
            <br />
            <br />
            <tr>
                <td>
                    <asp:Label ID="lblBDMedium" runat="server" CssClass="label" Text="Medium of Education"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBDMedium" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBDStat" runat="server" CssClass="label" Text="Status"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rblBDStat" runat="server" CssClass="MultipleSelectionDDL" RepeatDirection="Horizontal" Width="100px">
                        <asp:ListItem>Appeared</asp:ListItem>
                        <asp:ListItem>Completed</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBDSpecialization" runat="server" CssClass="label" Text="Specialization"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlBD" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlBD_SelectedIndexChanged" Width="100px">
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="txtBDAdd" runat="server" Height="17px" Visible="False" Width="62px"></asp:TextBox>
                    <asp:Button ID="btnBDAdd" runat="server" OnClick="btnBDAdd_Click" Text="Add" Visible="False" CssClass="button" />
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="lblBDYearFrom" runat="server" Text="From" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlBDMonthFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlBDYearFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>

                 <td>
                    <asp:Label ID="lblBDYearTo" runat="server" Text="To" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlBDMonthTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlBDYearTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="lblBDCollege" runat="server" CssClass="label" Text="College"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBDCollege" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBDUniversity" runat="server" CssClass="label" Text="University"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBDUniversity" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBDPercentage" runat="server" CssClass="label" Text="Percentage"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBDPercentage" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="btnDualBD" runat="server" Text="Add Dual Bachelors Degree Details" OnClick="btnDualBD_Click" CssClass="button" />
    </asp:Panel>
    <br />

    <asp:Panel ID="pnlCollapsableDualBD" runat="server" Visible="false" CssClass="pnlCSS">
        <table>
            <asp:Label ID="lblDualBDHead" runat="server" Text="Dual Bachelors Degree Details" CssClass="label"></asp:Label>
            <br />
            <br />
            <tr>
                <td>
                    <asp:Label ID="lblDualBDMedium" runat="server" CssClass="label" Text="Medium of Education"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDualBDMedium" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDualBDStat" runat="server" CssClass="label" Text="Status"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rblDualBDStat" runat="server" CssClass="MultipleSelectionDDL" RepeatDirection="Horizontal" Width="100px">
                        <asp:ListItem>Appeared</asp:ListItem>
                        <asp:ListItem>Completed</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDualBDSpecialization" runat="server" CssClass="label" Text="Specialization"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlDualBD" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlBD_SelectedIndexChanged" Width="100px">
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="txtDualBDAdd" runat="server" Height="17px" Visible="False" Width="62px"></asp:TextBox>
                    <asp:Button ID="btnDualBDAdd" runat="server" OnClick="btnBDAdd_Click" Text="Add" Visible="False" CssClass="button" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDualBDYearFrom" runat="server" Text="From" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlDualBDMonthFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlDualBDYearFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>

                 <td>
                    <asp:Label ID="lblDualBDYearTo" runat="server" Text="To" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlDualBDMonthTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlDualBDYearTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDualBDCollege" runat="server" CssClass="label" Text="College"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDualBDCollege" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDualBDUniversity" runat="server" CssClass="label" Text="University"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDualBDUniversity" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDualBDPercentage" runat="server" CssClass="label" Text="Percentage"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDualBDPercentage" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <br />

    <asp:Panel ID="pnlCollapsablePgd" runat="server" Visible="false" CssClass="pnlCSS">
        <table>
            <asp:Label ID="lblPgdHead" runat="server" Text=" PG Diploma Details" CssClass="label"></asp:Label>
            <br />
            <br />
            <tr>
                <td>
                    <asp:Label ID="lblPgdMedium" runat="server" CssClass="label" Text="Medium of Education"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPgdMedium" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPgdStat" runat="server" CssClass="label" Text="Status"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rblPgdStat" runat="server" CssClass="MultipleSelectionDDL" RepeatDirection="Horizontal" Width="100px">
                        <asp:ListItem>Appeared</asp:ListItem>
                        <asp:ListItem>Completed</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPgdSpecialization" runat="server" CssClass="label" Text="Specialization"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPgd" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlPgd_SelectedIndexChanged" Width="100px">
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="txtPgdAdd" runat="server" Height="17px" Visible="False" Width="62px"></asp:TextBox>
                    <asp:Button ID="btnPgdAdd" runat="server" OnClick="btnPgdAdd_Click" Text="Add" Visible="False" CssClass="button" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPgdYearFrom" runat="server" Text="From" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPgdMonthFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlPgdYearFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>

                 <td>
                    <asp:Label ID="lblPgdYearTo" runat="server" Text="To" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPgdMonthTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlPgdYearTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="lblPgdCollege" runat="server" CssClass="label" Text="College"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPgdCollege" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPgdUniversity" runat="server" CssClass="label" Text="University"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPgdUniversity" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPgdPercentage" runat="server" CssClass="label" Text="Percentage"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPgdPercentage" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <br />

    <asp:Panel ID="pnlCollapsableMD" runat="server" Visible="false" CssClass="pnlCSS">
        <table>
            <asp:Label ID="lblMDHead" runat="server" Text=" Masters Degree Details" CssClass="label"></asp:Label>
            <br />
            <br />
            <tr>
                <td>
                    <asp:Label ID="lblMDMedium" runat="server" CssClass="label" Text="Medium of Education"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMDMedium" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMDStat" runat="server" CssClass="label" Text="Status"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rblMDStat" runat="server" CssClass="MultipleSelectionDDL" RepeatDirection="Horizontal" Width="100px">
                        <asp:ListItem>Appeared</asp:ListItem>
                        <asp:ListItem>Completed</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMDSpecialization" runat="server" CssClass="label" Text="Specialization"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlMD" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlMD_SelectedIndexChanged" Width="100px">
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="txtMDAdd" runat="server" Height="17px" Visible="False" Width="62px"></asp:TextBox>
                    <asp:Button ID="btnMDAdd" runat="server" OnClick="btnMDAdd_Click" Text="Add" Visible="False" CssClass="button" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMDYearFrom" runat="server" Text="From" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlMDMonthFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlMDYearFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>

                 <td>
                    <asp:Label ID="lblMDYearTo" runat="server" Text="To" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlMDMonthTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlMDYearTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>
            </tr>
              <tr>
                <td>
                    <asp:Label ID="lblMDCollege" runat="server" CssClass="label" Text="College"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMDCollege" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMDUniversity" runat="server" CssClass="label" Text="University"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMDUniversity" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMDPercentage" runat="server" CssClass="label" Text="Percentage"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMDPercentage" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="btnDualMD" runat="server" Text="Add Dual Masters Degree Details" OnClick="btnDualMD_Click" CssClass="button" />
    </asp:Panel>
    <br />

    <asp:Panel ID="pnlCollapsableDualMD" runat="server" Visible="false" CssClass="pnlCSS">
        <table>
            <asp:Label ID="lblDualMDHead" runat="server" Text=" Dual Masters Degree Details" CssClass="label"></asp:Label>
            <br />
            <br />
            <tr>
                <td>
                    <asp:Label ID="lblDualMDMedium" runat="server" CssClass="label" Text="Medium of Education"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDualMDMedium" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDualMDStat" runat="server" CssClass="label" Text="Status"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rblDualMDStat" runat="server" CssClass="MultipleSelectionDDL" RepeatDirection="Horizontal" Width="100px">
                        <asp:ListItem>Appeared</asp:ListItem>
                        <asp:ListItem>Completed</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDualMDSpecialization" runat="server" CssClass="label" Text="Specialization"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlDualMD" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlMD_SelectedIndexChanged" Width="100px">
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="txtDualMDAdd" runat="server" Height="17px" Visible="False" Width="62px"></asp:TextBox>
                    <asp:Button ID="btnDualMDAdd" runat="server" OnClick="btnMDAdd_Click" Text="Add" Visible="False" CssClass="button" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDualMDYearFrom" runat="server" Text="From" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlDualMDMonthFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlDualMDYearFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>

                 <td>
                    <asp:Label ID="lblDualMDYearTo" runat="server" Text="To" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlDualMDMonthTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlDualMDYearTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDualMDCollege" runat="server" CssClass="label" Text="College"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDualMDCollege" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDualMDUniversity" runat="server" CssClass="label" Text="University"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDualMDUniversity" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDualMDPercentage" runat="server" CssClass="label" Text="Percentage"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDualMDPercentage" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <br />

    <asp:Panel ID="pnlCollapsablePHD" runat="server" Visible="false" CssClass="pnlCSS">
        <table>
            <asp:Label ID="lblPHPHead" runat="server" Text=" Doctorate/ PHD Degree Details" CssClass="label"></asp:Label>
            <br />
            <br />
            <tr>
                <td>
                    <asp:Label ID="lblPHDMedium" runat="server" CssClass="label" Text="Medium of Education"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPHDMedium" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPHDStat" runat="server" CssClass="label" Text="Status"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rblPHDStat" runat="server" CssClass="MultipleSelectionDDL" RepeatDirection="Horizontal" Width="100px">
                        <asp:ListItem>Appeared</asp:ListItem>
                        <asp:ListItem>Completed</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPHDDSpecialization" runat="server" CssClass="label" Text="Specialization"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPHD" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlPHD_SelectedIndexChanged" Width="100px">
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="txtPHDAdd" runat="server" Height="17px" Visible="False" Width="62px"></asp:TextBox>
                    <asp:Button ID="btnPHDAdd" runat="server" OnClick="btnPHDAdd_Click" Text="Add" Visible="False" CssClass="button" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPHDYearFrom" runat="server" Text="From" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPHDMonthFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlPHDYearFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>

                 <td>
                    <asp:Label ID="lblPHDYearTo" runat="server" Text="To" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPHDMonthTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="ddlPHDYearTo" runat="server" AutoPostBack="true"></asp:DropDownList>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="lblPHDCollege" runat="server" CssClass="label" Text="College"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPHDCollege" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPHDUniversity" runat="server" CssClass="label" Text="University"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPHDUniversity" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPHDPercentage" runat="server" CssClass="label" Text="Percentage"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPHDPercentage" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <br />
</div>
<div id="footer" runat="server" visible="true">
     <table style="background-color: #C0C0C0">
        <tr>
            <td style="width:500px">
                <div id="divCertification" runat="server" visible="true">
                    <asp:Panel ID="pnlCollapsableCert" runat="server" CssClass="pnlCSS">
                        <uc2:MoreCertifications ID="MoreCertifications1" runat="server" />
                    </asp:Panel>
                </div>
            </td>
            <td style="width:500px">
                <div id="divWorkshop" runat="server" visible="true">
                    <asp:Panel ID="pnlCollapsableWork" runat="server" CssClass="pnlCSS">
                        <uc3:MoreWorkshops ID="MoreWorkshops1" runat="server" />
                    </asp:Panel>
                </div>
            </td>
        </tr>
    </table>
    <br />
    <br />
    <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" Visible="false" CssClass="button"  style="margin-top: 10px; margin-left: 450px"/>
    <br />
    <br />
    <div>
        <asp:Label ID="lblSuccess" runat="server" Text="" ForeColor="Green" Font-Bold="true" Font-Size="14px" Visible="false"></asp:Label>
        <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Font-Bold="true" Font-Size="14px" Visible="false"></asp:Label>
    </div>
</div>
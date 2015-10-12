<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EducationalDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.EducationalDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<%@ Register Src="~/UserControls/JobSeeker/MoreCertifications.ascx" TagName="MoreCertifications" TagPrefix="uc2" %>
<%@ Register Src="~/UserControls/JobSeeker/MoreWorkshops.ascx" TagName="MoreWorkshops" TagPrefix="uc3" %>

<link href="../../Css/Style.css" rel="stylesheet" />
<link href="../../Css/Common.css" rel="stylesheet" />

<div id="divMain" runat="server" style="min-height: 500px; padding: 10px">

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
                <asp:Button ID="btnGo" runat="server" Text="Go" OnClick="btnGo_Click" CssClass="button"/></td>
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
                    <asp:Label ID="lblSSCYear" runat="server" Text="Year of Completion" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSSCYear" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSSCBoard" runat="server" Text="University/Board" CssClass="label"></asp:Label>
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
            <asp:Label ID="lblHSCHead" runat="server" Text=" HSC / 12th Details"  CssClass="label"></asp:Label>
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
                        <asp:Button ID="btnHSCAdd" runat="server" Text="Add" Visible="False" CssClass="button"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblHSCYear" runat="server" CssClass="label" Text="Year of Completion"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtHSCYear" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblHSCBoard" runat="server" CssClass="label" Text="University/Board"></asp:Label>
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
                        <asp:Button ID="btnDipAdd" runat="server" OnClick="btnDipAdd_Click" Text="Add" Visible="False" CssClass="button"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDipYear" runat="server" CssClass="label" Text="Year of Completion"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDipYear" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDipUniversity" runat="server" CssClass="label" Text="University/Board"></asp:Label>
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
                        <asp:Button ID="btnBDAdd" runat="server" OnClick="btnBDAdd_Click" Text="Add" Visible="False" CssClass="button"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblBDYear" runat="server" CssClass="label" Text="Year of Completion"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtBDYear" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblBDUniversity" runat="server" CssClass="label" Text="University/Board"></asp:Label>
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
        <asp:Button ID="btnDualBD" runat="server" Text="Add Dual Bachelors Degree Details" OnClick="btnDualBD_Click" CssClass="button"/>
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
                        <asp:Button ID="btnDualBDAdd" runat="server" OnClick="btnBDAdd_Click" Text="Add" Visible="False" CssClass="button"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDualBDYear" runat="server" CssClass="label" Text="Year of Completion"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDualBDYear" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDualBDUniversity" runat="server" CssClass="label" Text="University/Board"></asp:Label>
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
            <asp:Label ID="lblPgdHead" runat="server" Text=" PG Diploma Details" CssClass="label" ></asp:Label>
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
                        <asp:Button ID="btnPgdAdd" runat="server" OnClick="btnPgdAdd_Click" Text="Add" Visible="False" CssClass="button"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPgdYear" runat="server" CssClass="label" Text="Year of Completion"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPgdYear" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPgdUniversity" runat="server" CssClass="label" Text="University/Board"></asp:Label>
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
            <asp:Label ID="lblMDHead" runat="server" Text=" Masters Degree Details" CssClass="label" ></asp:Label>
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
                        <asp:Button ID="btnMDAdd" runat="server" OnClick="btnMDAdd_Click" Text="Add" Visible="False" CssClass="button"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMDYear" runat="server" CssClass="label" Text="Year of Completion"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMDYear" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMDUniversity" runat="server" CssClass="label" Text="University/Board"></asp:Label>
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
        <asp:Button ID="btnDualMD" runat="server" Text="Add Dual Masters Degree Details" OnClick="btnDualMD_Click" CssClass="button"/>
    </asp:Panel>
    <br />


        <asp:Panel ID="pnlCollapsableDualMD" runat="server" Visible="false" CssClass="pnlCSS">
        <table>
            <asp:Label ID="lblDualMDHead" runat="server" Text=" Dual Masters Degree Details" CssClass="label" ></asp:Label>
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
                        <asp:Button ID="btnDualMDAdd" runat="server" OnClick="btnMDAdd_Click" Text="Add" Visible="False" CssClass="button"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDualMDYear" runat="server" CssClass="label" Text="Year of Completion"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDualMDYear" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDualMDUniversity" runat="server" CssClass="label" Text="University/Board"></asp:Label>
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
            <asp:Label ID="lblPHPHead" runat="server" Text=" Doctorate/ PHD Degree Details" CssClass="label" ></asp:Label>
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
                        <asp:Button ID="btnPHDAdd" runat="server" OnClick="btnPHDAdd_Click" Text="Add" Visible="False" CssClass="button"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPHDYear" runat="server" CssClass="label" Text="Year of Completion"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPHDYear" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPHDUniversity" runat="server" CssClass="label" Text="University/Board"></asp:Label>
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
<div id="footer" runat="server" visible="true" Style="width:100%">
   <%-- <table style="background-color: #C0C0C0">
        <tr>
            <td>
                <div id="divCertification" runat="server" visible="true" Style="width:50%">
                    <asp:Panel ID="pnlCollapsableCert" runat="server" CssClass="pnlCSS">
                        <uc2:MoreCertifications ID="MoreCertifications1" runat="server" />
                    </asp:Panel>
                </div>
            </td>
            <td>
                <div id="divWorkshop" runat="server" visible="true" Style="width:50%">
                    <asp:Panel ID="pnlCollapsableWork" runat="server" CssClass="pnlCSS">
                        <uc3:MoreWorkshops ID="MoreWorkshops1" runat="server" />
                    </asp:Panel>
                </div>
            </td>
        </tr>
    </table>--%>
    <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" Visible="false" CssClass="button" />
    <br />
    <br />
    <div>
        <asp:Label ID="lblSuccess" runat="server" Text="" ForeColor="Green" Font-Bold="true" Font-Size="14px" Visible="false"></asp:Label>
        <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Font-Bold="true" Font-Size="14px" Visible="false"></asp:Label>
    </div>
</div>
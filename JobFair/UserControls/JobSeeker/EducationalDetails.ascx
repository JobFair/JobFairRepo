﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EducationalDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.EducationalDetails" %>
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
                    <asp:ListItem runat="server" Text="  Certifications" Value="8" AutoPostBack="True"></asp:ListItem>
                    <asp:ListItem runat="server" Text="  Workshops" Value="9" AutoPostBack="True"></asp:ListItem>
                </asp:CheckBoxList></td>
            <td style="padding-left: 25px;">
                <asp:Button ID="btnGo" runat="server" Text="Go" OnClick="btnGo_Click" /></td>
        </tr>
    </table>
    <br />
        <hr />
    <br />
    
    <asp:Panel ID="pnlCollapsableSSC" runat="server" Visible="False">
        <table style="margin-left: 10px">
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
        <hr style="width: 350px" />
    </asp:Panel>
    <br />

    <asp:Panel ID="pnlCollapsableHSC" runat="server" Visible="false">
        <table>
            <asp:Label ID="lblHSCHead" runat="server" Text=" HSC / 12th Details"  CssClass="label"></asp:Label>
            <br />
            <br />
            <tr>
                <td>
                    <asp:Label ID="lblHSCMedium" runat="server" Text="Medium of Education" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHSCMedium" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHSCStat" runat="server" Text="Status" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rblHSCStat" runat="server" RepeatDirection="Horizontal" CssClass="MultipleSelectionDDL" Width="100px">
                        <asp:ListItem>Appeared</asp:ListItem>
                        <asp:ListItem>Completed</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHSCSpecialization" runat="server" Text="Specialization" CssClass="label"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="ddlHSC" runat="server" Height="16px" Width="100px">
                        <asp:ListItem Value="0">Select</asp:ListItem>
                        <asp:ListItem Value="1" Text="Arts"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Commerce"></asp:ListItem>
                        <asp:ListItem Value="3" Text="Science"></asp:ListItem>
                        <asp:ListItem Value="4" Text="Others"></asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="txtHSCAdd" runat="server" Visible="False" Height="17px" Width="62px"></asp:TextBox>
                    <asp:Button ID="btnHSCAdd" runat="server" Text="Add" Visible="False" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHSCYear" runat="server" Text="Year of Completion" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHSCYear" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHSCBoard" runat="server" Text="University/Board" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHSCBoard" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHSCPercentage" runat="server" Text="Percentage" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHSCPercentage" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <hr style="width: 350px" />
    </asp:Panel>
    <br />

    <asp:Panel ID="pnlCollapsableDip" runat="server" Visible="false">
        <table>
            <asp:Label ID="lblDipHead" runat="server" Text=" UG Diploma Details" CssClass="label"></asp:Label>
            <br />
            <br />
            <tr>
                <td>
                    <asp:Label ID="lblDipMedium" runat="server" Text="Medium of Education" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDipMedium" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDipStat" runat="server" Text="Status" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rblDipStat" runat="server" RepeatDirection="Horizontal" CssClass="MultipleSelectionDDL" Width="100px">
                        <asp:ListItem>Appeared</asp:ListItem>
                        <asp:ListItem>Completed</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDipSpecialization" runat="server" Text="Specialization" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlDip" runat="server" Height="16px" Width="100px">
                        <asp:ListItem Value="0">Select</asp:ListItem>
                        <asp:ListItem Value="1" Text="Electronics"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Electronics and Telecommunication"></asp:ListItem>
                        <asp:ListItem Value="3" Text="Computer Science"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDipYear" runat="server" Text="Year of Completion" CssClass="label"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtDipYear" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDipUniversity" runat="server" Text="University/Board" CssClass="label"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtDipUniversity" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDipPercentage" runat="server" Text="Percentage" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDipPercentage" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <hr style="width: 350px" />
    </asp:Panel>
    <br />

    <asp:Panel ID="pnlCollapsableBD" runat="server" Visible="false">
        <table>
            <asp:Label ID="lblBDHead" runat="server" Text="Bachelors Degree Details" CssClass="label"></asp:Label>
            
            <br />
            <br />
            <tr>
                <td>
                    <asp:Label ID="lblBDMedium" runat="server" Text="Medium of Education" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBDMedium" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBDStat" runat="server" Text="Status" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rblBDStat" runat="server" RepeatDirection="Horizontal" CssClass="MultipleSelectionDDL" Width="100px">
                        <asp:ListItem>Appeared</asp:ListItem>
                        <asp:ListItem>Completed</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBDSpecialization" runat="server" Text="Specialization" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlBD" runat="server" Height="16px" Width="100px">
                        <asp:ListItem Value="0">Select</asp:ListItem>
                        <asp:ListItem Value="1" Text="BCOM"></asp:ListItem>
                        <asp:ListItem Value="2" Text="BBA"></asp:ListItem>
                        <asp:ListItem Value="3" Text="BCA"></asp:ListItem>
                        <asp:ListItem Value="4" Text="BCS"></asp:ListItem>
                        <asp:ListItem Value="5" Text="B.Sc"></asp:ListItem>
                        <asp:ListItem Value="6" Text="B PHARM"></asp:ListItem>
                        <asp:ListItem Value="7" Text="B. Arch"></asp:ListItem>
                        <asp:ListItem Value="8" Text="BE"></asp:ListItem>
                        <asp:ListItem Value="9" Text="BA"></asp:ListItem>
                        <asp:ListItem Value="10" Text="BAJM"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBDYear" runat="server" Text="Year of Completion" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBDYear" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBDUniversity" runat="server" Text="University/Board" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBDUniversity" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBDPercentage" runat="server" Text="Percentage" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBDPercentage" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <hr style="width: 350px" />
    </asp:Panel>
    <br />

    <asp:Panel ID="pnlCollapsablePgd" runat="server" Visible="false">
        <table>
            <asp:Label ID="lblPgdHead" runat="server" Text=" PG Diploma Details" CssClass="label" ></asp:Label>
            
            <br />
            <br />
            <tr>
                <td>
                    <asp:Label ID="lblPgdMedium" runat="server" Text="Medium of Education" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPgdMedium" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPgdStat" runat="server" Text="Status" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rblPgdStat" runat="server" RepeatDirection="Horizontal" CssClass="MultipleSelectionDDL" Width="100px">
                        <asp:ListItem>Appeared</asp:ListItem>
                        <asp:ListItem>Completed</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPgdSpecialization" runat="server" Text="Specialization" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPgd" runat="server" Height="16px" Width="100px">
                        <asp:ListItem Value="0">Select</asp:ListItem>
                        <asp:ListItem Value="1" Text="PGDCA"></asp:ListItem>
                        <asp:ListItem Value="2" Text="PGDBA"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPgdYear" runat="server" Text="Year of Completion" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPgdYear" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPgdUniversity" runat="server" Text="University/Board" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPgdUniversity" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPgdPercentage" runat="server" Text="Percentage" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPgdPercentage" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
        </table>
         <hr style="width: 350px;float:left" />
    </asp:Panel>
    <br />
   
    <asp:Panel ID="pnlCollapsableMD" runat="server" Visible="false">
        <table>
            <asp:Label ID="lblMDHead" runat="server" Text=" Masters Degree Details" CssClass="label" ></asp:Label>
            
            <br />
            <br />
            <tr>
                <td>
                    <asp:Label ID="lblMDMedium" runat="server" Text="Medium of Education" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMDMedium" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMDStat" runat="server" Text="Status" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rblMDStat" runat="server" RepeatDirection="Horizontal" CssClass="MultipleSelectionDDL" Width="100px">
                        <asp:ListItem>Appeared</asp:ListItem>
                        <asp:ListItem>Completed</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMDSpecialization" runat="server" Text="Specialization" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlMD" runat="server" Height="16px" Width="100px">
                        <asp:ListItem Value="0">Select</asp:ListItem>
                        <asp:ListItem Value="1" Text="MCOM"></asp:ListItem>
                        <asp:ListItem Value="2" Text="MBA"></asp:ListItem>
                        <asp:ListItem Value="3" Text="MCA"></asp:ListItem>
                        <asp:ListItem Value="4" Text="MCS"></asp:ListItem>
                        <asp:ListItem Value="5" Text="M.Sc"></asp:ListItem>
                        <asp:ListItem Value="6" Text="M PHARM"></asp:ListItem>
                        <asp:ListItem Value="7" Text="M. Arch"></asp:ListItem>
                        <asp:ListItem Value="8" Text="ME"></asp:ListItem>
                        <asp:ListItem Value="9" Text="MA"></asp:ListItem>
                        <asp:ListItem Value="10" Text="MAJM"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMDYear" runat="server" Text="Year of Completion" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMDYear" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMDUniversity" runat="server" Text="University/Board" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMDUniversity" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMDPercentage" runat="server" Text="Percentage" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMDPercentage" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <hr style="width: 350px" />
    </asp:Panel>
    <br />

    <asp:Panel ID="pnlCollapsablePHD" runat="server" Visible="false">
        <table>
            <asp:Label ID="lblPHPHead" runat="server" Text=" Doctorate/ PHD Degree Details" CssClass="label" ></asp:Label>
            
            <br />
            <br />
            <tr>
                <td>
                    <asp:Label ID="lblPHDMedium" runat="server" Text="Medium of Education" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPHDMedium" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPHDStat" runat="server" Text="Status" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rblPHDStat" runat="server" RepeatDirection="Horizontal" CssClass="MultipleSelectionDDL" Width="100px">
                        <asp:ListItem>Appeared</asp:ListItem>
                        <asp:ListItem>Completed</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPHDDSpecialization" runat="server" Text="Specialization" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPHD" runat="server" Height="16px" Width="100px">
                        <asp:ListItem Value="0">Select</asp:ListItem>
                        <asp:ListItem Value="1" Text="MCOM"></asp:ListItem>
                        <asp:ListItem Value="2" Text="MBA"></asp:ListItem>
                        <asp:ListItem Value="3" Text="MCA"></asp:ListItem>
                        <asp:ListItem Value="4" Text="MCS"></asp:ListItem>
                        <asp:ListItem Value="5" Text="M.Sc"></asp:ListItem>
                        <asp:ListItem Value="6" Text="M PHARM"></asp:ListItem>
                        <asp:ListItem Value="7" Text="M. Arch"></asp:ListItem>
                        <asp:ListItem Value="8" Text="ME"></asp:ListItem>
                        <asp:ListItem Value="9" Text="MA"></asp:ListItem>
                        <asp:ListItem Value="10" Text="MAJM"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPHDYear" runat="server" Text="Year of Completion" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPHDYear" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPHDUniversity" runat="server" Text="University/Board" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPHDUniversity" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPHDPercentage" runat="server" Text="Percentage" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPHDPercentage" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <hr style="width: 350px" />
    </asp:Panel>
    <br />
</div>
<div>
    <table style="background-color: #C0C0C0">
        <tr>
            <td>
                <div id="divCertification" runat="server" visible="false">
                    <asp:Panel ID="pnlCollapsableCert" runat="server" Height="0" Width="300px">
                        <uc2:MoreCertifications ID="MoreCertifications1" runat="server" />
                    </asp:Panel>
                    <ajax:CollapsiblePanelExtender ID="colPanelExtenderCert" runat="server"
                        CollapseControlID="cbCertification"
                        Collapsed="true"
                        ExpandControlID="cbCertification"
                        TextLabelID="lblMessage8"
                        ExpandDirection="Vertical"
                        TargetControlID="pnlCollapsableCert"
                        ScrollContents="false"></ajax:CollapsiblePanelExtender>
                </div>
            </td>
            <td>
                <div id="divWorkshop" runat="server" visible="false">
                    <asp:Panel ID="pnlCollapsableWork" runat="server" Height="0" Width="300px">
                        <uc3:MoreWorkshops ID="MoreWorkshops1" runat="server" />
                    </asp:Panel>
                    <ajax:CollapsiblePanelExtender ID="colPanelExtenderWork" runat="server"
                        CollapseControlID="cdWorkshop"
                        Collapsed="true"
                        ExpandControlID="cdWorkshop"
                        TextLabelID="lblMessage9"
                        ExpandDirection="Vertical"
                        TargetControlID="pnlCollapsableWork"
                        ScrollContents="false"></ajax:CollapsiblePanelExtender>
                </div>
            </td>
        </tr>
    </table>
    <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" />
    <br />
    <br />
    <div>
        <asp:Label ID="lblSuccess" runat="server" Text="" ForeColor="Green" Font-Bold="true" Font-Size="14px" Visible="false"></asp:Label>
        <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Font-Bold="true" Font-Size="14px" Visible="false"></asp:Label>
    </div>
</div>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EducationalDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.EducationalDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<link href="../../Css/Style.css" rel="stylesheet" />
<link href="../../Css/Common.css" rel="stylesheet" />
<style type="text/css">
    .auto-style1 {
        width: 96%;
    }
    .pnlCSS {
        font-weight: bold;
        cursor: pointer;
        border: solid 1px #c0c0c0;
        width: 30%;
    }
    .auto-style5 {
        width: 186px;
    }
    .auto-style6 {
        width: 150px;
    }
    #divSSC {
        width: 240px;
    }
    .auto-style7 {
        width: 410px;
    }
    .auto-style8 {
        width: 467px;
    }
</style>

<div id="divMain" runat="server" visible="true" style="background-color: #C0C0C0">

<h2>Highest Qualification&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="ddlHQ" runat="server">
        <asp:ListItem Value="0" Text="Select Your Highest Qualification"></asp:ListItem>
        <asp:ListItem Value="1" Text="Doctorate/ PHD Degree"></asp:ListItem>
        <asp:ListItem Value="2" Text="Masters Degree"></asp:ListItem>
        <asp:ListItem Value="3" Text="PG Diploma"></asp:ListItem>
        <asp:ListItem Value="4" Text="Bachelors Degree"></asp:ListItem>
        <asp:ListItem Value="5" Text="UG Diploma"></asp:ListItem>
        <asp:ListItem Value="6" Text="HSC / 12th"></asp:ListItem>
        <asp:ListItem Value="7" Text="SSC / 10th"></asp:ListItem>
    </asp:DropDownList>
    </h2>
    <p><asp:Label ID="lblInfo" runat="server" Text="Kindly select checkboxes for the Degrees you have completed*" ForeColor="Red"></asp:Label></p>
    <asp:CheckBox ID="cbSSC" runat="server" Text="  SSC / 10th" OnCheckedChanged="cbSSC_CheckedChanged" AutoPostBack="True"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:CheckBox ID="cbHSC" runat="server" Text="  HSC / 12th" OnCheckedChanged="cbHSC_CheckedChanged" AutoPostBack="True"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:CheckBox ID="cbDip" runat="server" Text="  UG Diploma" OnCheckedChanged="cbDip_CheckedChanged" AutoPostBack="True"/>&nbsp;&nbsp;&nbsp;&nbsp;<br />
    <asp:CheckBox ID="cbBD" runat="server" Text="  Bachelors Degree" OnCheckedChanged="cbBD_CheckedChanged" AutoPostBack="True"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:CheckBox ID="cbPGD" runat="server" Text="  PG Diploma" OnCheckedChanged="cbPgd_CheckedChanged" AutoPostBack="True"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:CheckBox ID="cbMD" runat="server" Text="  Masters Degree" OnCheckedChanged="cbMD_CheckedChanged" AutoPostBack="True"/>&nbsp;&nbsp;&nbsp;<br />
    <asp:CheckBox ID="cbPHD" runat="server" Text="  Doctorate/ PHD Degree" OnCheckedChanged="cbPHD_CheckedChanged" AutoPostBack="True"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   <%-- <asp:CheckBox ID="cbCertification" runat="server" Text="  Certifications" OnCheckedChanged="cbCertification_CheckedChanged" AutoPostBack="True"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:CheckBox ID="cdWorkshop" runat="server" Text="  Workshops" OnCheckedChanged="cbWorkshop_CheckedChanged" AutoPostBack="True"/>&nbsp;&nbsp;&nbsp;<br />--%>

&nbsp;<br />
    &nbsp;&nbsp;&nbsp;&nbsp;
<div id="divSSC" runat="server" visible="true">
<asp:Panel ID="pnlCollapsableSSC" runat="server" Height="0" Width="300px">
<table class="auto-style1">
    <center><asp:Label ID="lblSSCHead" runat="server" Text="Enter SSC / 10th Details" CssClass="auto-style6"></asp:Label>
    </center>
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
            <asp:TextBox ID="txtSSCPercentage" runat="server" AutoPostBack="True" OnTextChanged="txtSSCPercentage_TextChanged" Width="100px"></asp:TextBox>
        </td>
    </tr>
</table> <hr style="width: 350px" />
       </asp:Panel>
    <ajax:CollapsiblePanelExtender ID="colPanelExtenderSSC" runat="server"
CollapseControlID="cbSSC"
Collapsed="true"
ExpandControlID="cbSSC"
TextLabelID="lblMessage1"
ExpandDirection="Vertical"
TargetControlID="pnlCollapsableSSC"
ScrollContents="false"></ajax:CollapsiblePanelExtender>
</div>
    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
<div id="divHSC" runat="server" visible="true">
<asp:Panel ID="pnlCollapsableHSC" runat="server" Height="0" Width="300px">
<table class="auto-style1">
    <center><asp:Label ID="lblHSCHead" runat="server" Text="Enter HSC / 12th Details" CssClass="auto-style6"></asp:Label></center>
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
            <asp:DropDownList ID="ddlHSC" runat="server" Height="16px" Width="100px" DataTextField="<--Select-->" DataTextFormatString="<--Select-->" DataValueField="&lt;--Select--&gt;" OnSelectedIndexChanged="ddlHSC_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Value="0">--Select--</asp:ListItem>
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
</table> <hr style="width: 350px" />
 </asp:Panel>
<ajax:CollapsiblePanelExtender ID="colPanelExtenderHSC" runat="server"
CollapseControlID="cbHSC"
Collapsed="true"
ExpandControlID="cbHSC"
TextLabelID="lblMessage2"
ExpandDirection="Vertical"
TargetControlID="pnlCollapsableHSC"
ScrollContents="false"></ajax:CollapsiblePanelExtender>
  </div><br />

<div id="divDip" runat="server" visible="true">
<asp:Panel ID="pnlCollapsableDip" runat="server" Height="0" Width="300px">

<table class="auto-style1">
    <center><asp:Label ID="lblDipHead" runat="server" Text="Enter UG Diploma Details" CssClass="auto-style6"></asp:Label></center>
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
            <asp:DropDownList ID="ddlDip" runat="server" Height="16px" Width="100px" DataTextField="<--Select-->" DataTextFormatString="<--Select-->" DataValueField="&lt;--Select--&gt;">
                <asp:ListItem Value="0">--Select--</asp:ListItem>
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
        <td> <asp:Label ID="lblDipUniversity" runat="server" Text="University/Board" CssClass="label"></asp:Label></td>
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
</table> <hr style="width: 350px" />
</asp:Panel>
<ajax:CollapsiblePanelExtender ID="colPanelExtenderDip" runat="server"
CollapseControlID="cbDip"
Collapsed="true"
ExpandControlID="cbDip"
TextLabelID="lblMessage3"
ExpandDirection="Vertical"
TargetControlID="pnlCollapsableDip"
ScrollContents="false"></ajax:CollapsiblePanelExtender>
      </div><br />
    
<div id="divBD" runat="server" visible="true">
<asp:Panel ID="pnlCollapsableBD" runat="server" Height="0" Width="300px">

<table class="auto-style1">
    <center><asp:Label ID="lblBDHead" runat="server" Text="Enter Bachelors Degree Details" CssClass="auto-style6"></asp:Label></center>
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
            <asp:DropDownList ID="ddlBD" runat="server" Height="16px" Width="100px" DataTextField="<--Select-->" DataTextFormatString="<--Select-->" DataValueField="&lt;--Select--&gt;">
                <asp:ListItem Value="0">--Select--</asp:ListItem>
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
</table> <hr style="width: 350px" />
</asp:Panel>
<ajax:CollapsiblePanelExtender ID="colPanelExtenderBD" runat="server"
CollapseControlID="cbBD"
Collapsed="true"
ExpandControlID="cbBD"
TextLabelID="lblMessage4"
ExpandDirection="Vertical"
TargetControlID="pnlCollapsableBD"
ScrollContents="false"></ajax:CollapsiblePanelExtender>
      </div><br />

<div id="divPgd" runat="server" visible="true">
<asp:Panel ID="pnlCollapsablePgd" runat="server" Height="0" Width="300px">

<table class="auto-style1">
    <center><asp:Label ID="lblPgdHead" runat="server" Text="Enter PG Diploma Details" CssClass="auto-style6"></asp:Label></center>
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
            <asp:DropDownList ID="ddlPgd" runat="server" Height="16px" Width="100px" DataTextField="<--Select-->" DataTextFormatString="<--Select-->" DataValueField="&lt;--Select--&gt;">
                <asp:ListItem Value="0">--Select--</asp:ListItem>
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
</table> <hr style="width: 350px" />
</asp:Panel>
<ajax:CollapsiblePanelExtender ID="colPanelExtenderPgd" runat="server"
CollapseControlID="cbPgd"
Collapsed="true"
ExpandControlID="cbPgd"
TextLabelID="lblMessage5"
ExpandDirection="Vertical"
TargetControlID="pnlCollapsablePgd"
ScrollContents="false"></ajax:CollapsiblePanelExtender>
      </div><br />

<div id="divMD" runat="server" visible="true">
<asp:Panel ID="pnlCollapsableMD" runat="server" Height="0" Width="300px">

<table class="auto-style1">
    <center><asp:Label ID="lblMDHead" runat="server" Text="Enter Masters Degree Details" CssClass="auto-style6"></asp:Label></center>
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
            <asp:DropDownList ID="ddlMD" runat="server" Height="16px" Width="100px" DataTextField="<--Select-->" DataTextFormatString="<--Select-->" DataValueField="&lt;--Select--&gt;">
                <asp:ListItem Value="0">--Select--</asp:ListItem>
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
        <td class="auto-style5">
            <asp:Label ID="lblMDPercentage" runat="server" Text="Percentage" CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMDPercentage" runat="server" Width="100px"></asp:TextBox>
        </td>
    </tr>
</table> <hr style="width: 350px" />
</asp:Panel>
<ajax:CollapsiblePanelExtender ID="colPanelExtenderMD" runat="server"
CollapseControlID="cbMD"
Collapsed="true"
ExpandControlID="cbMD"
TextLabelID="lblMessage6"
ExpandDirection="Vertical"
TargetControlID="pnlCollapsableMD"
ScrollContents="false"></ajax:CollapsiblePanelExtender>
      </div><br />

<div id="divPHD" runat="server" visible="true">
<asp:Panel ID="pnlCollapsablePHD" runat="server" Height="0" Width="300px">

<table class="auto-style1">
    <center><asp:Label ID="lblPHPHead" runat="server" Text="Enter Doctorate/ PHD Degree Details" CssClass="auto-style6"></asp:Label></center>
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
            <asp:DropDownList ID="ddlPHD" runat="server" Height="16px" Width="100px" DataTextField="<--Select-->" DataTextFormatString="<--Select-->" DataValueField="&lt;--Select--&gt;">
                <asp:ListItem Value="0">--Select--</asp:ListItem>
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
</table> <hr style="width: 350px" />
</asp:Panel>
<ajax:CollapsiblePanelExtender ID="colPanelExtenderPHD" runat="server"
CollapseControlID="cbPHD"
Collapsed="true"
ExpandControlID="cbPHD"
TextLabelID="lblMessage7"
ExpandDirection="Vertical"
TargetControlID="pnlCollapsablePHD"
ScrollContents="false"></ajax:CollapsiblePanelExtender>
      </div><br />
    </div>
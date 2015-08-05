<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EducationalDetails.ascx.cs" Inherits="JobSeeker_Forms_EducationalDetails" %>
<%@ Register Src="~/Forms/JobSeeker/MoreCertifications.ascx" TagName="MoreCertification" TagPrefix="Certification" %>
<%@ Register Src="~/Forms/JobSeeker/MoreWorkshops.ascx" TagName="MoreWorkshops" TagPrefix="Workshops" %> 

<link href="../../Style.css" rel="stylesheet" />

<h3>Highest Qualification</h3>
<table >
    <tr>
        <td > <asp:Label ID="lblHQ" runat="server" Text="Qualification"></asp:Label></td>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlHQ" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlHQ_SelectedIndexChanged">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="txtHQAdd" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="btnHQAdd" runat="server" Text="Add" Visible="False" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="lblHQstat" runat="server" Text="Status"></asp:Label></td>
        <td>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Appeared</asp:ListItem>
                <asp:ListItem>Completed</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="lblHQYear" runat="server" Text="Year of Completion"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtHQyear" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="lblHQUniversity" runat="server" Text="University"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtHQUniversity" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label37" runat="server" Text="Percentage"></asp:Label>

        </td>
        <td>
            <asp:TextBox ID="txtHQPercentage" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
<hr />


<h3>2.	Doctorate/ PHD Degree </h3>
<table >
    <tr>
        <td > <asp:Label ID="Label1" runat="server" Text="Qualification"></asp:Label></td>
        <td>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlPHD" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlHQ_SelectedIndexChanged">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="txtPHDAdd" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="btnPHDAdd" runat="server" Text="Add" Visible="False" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label2" runat="server" Text="Status"></asp:Label></td>
        <td>
            <asp:RadioButtonList ID="rblPHDStat" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Appeared</asp:ListItem>
                <asp:ListItem>Completed</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label3" runat="server" Text="Year of Completion"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtPHDYear" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label4" runat="server" Text="University"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtPHDUniversity" runat="server"></asp:TextBox>
        </td>
    </tr><tr>
        <td>
            <asp:Label ID="Label38" runat="server" Text="Percentage"></asp:Label>

        </td>
        <td>
            <asp:TextBox ID="txtPHDPercentage" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
<hr />

<h3>3.	Masters Degree </h3>
<table >
    <tr>
        <td > <asp:Label ID="Label5" runat="server" Text="Qualification"></asp:Label></td>
        <td>
            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlMD" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlHQ_SelectedIndexChanged">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="txtMDAdd" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="btnMDAdd" runat="server" Text="Add" Visible="False" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label6" runat="server" Text="Status"></asp:Label></td>
        <td>
            <asp:RadioButtonList ID="rblMDstat" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Appeared</asp:ListItem>
                <asp:ListItem>Completed</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label7" runat="server" Text="Year of Completion"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtMdYear" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label8" runat="server" Text="University"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtMDUniversity" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label39" runat="server" Text="Percentage"></asp:Label>

        </td>
        <td>
            <asp:TextBox ID="txtMDPercentage" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
<hr />

<h3>4.	PG Diploma </h3>
<table >
    <tr>
        <td > <asp:Label ID="Label9" runat="server" Text="Qualification"></asp:Label></td>
        <td>
            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlPGD" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlHQ_SelectedIndexChanged">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="txtPGDAdd" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="btnPGDAdd" runat="server" Text="Add" Visible="False" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label10" runat="server" Text="Status"></asp:Label></td>
        <td>
            <asp:RadioButtonList ID="rblPGDStat" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Appeared</asp:ListItem>
                <asp:ListItem>Completed</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label11" runat="server" Text="Year of Completion"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtPGDYear" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label12" runat="server" Text="University"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtPGDUniversity" runat="server"></asp:TextBox>
        </td>
    </tr><tr>
        <td>
            <asp:Label ID="Label40" runat="server" Text="Percentage"></asp:Label>

        </td>
        <td>
            <asp:TextBox ID="txtPGDPercentage" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
<hr />

<h3>5.	Bachelors Degree </h3>
<table >
    <tr>
        <td > <asp:Label ID="Label13" runat="server" Text="Qualification"></asp:Label></td>
        <td>
            <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlBD" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlHQ_SelectedIndexChanged">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="txtBDAdd" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="btnBDAdd" runat="server" Text="Add" Visible="False" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label14" runat="server" Text="Status"></asp:Label></td>
        <td>
            <asp:RadioButtonList ID="rblBDStat" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Appeared</asp:ListItem>
                <asp:ListItem>Completed</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label15" runat="server" Text="Year of Completion"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtBDYear" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label16" runat="server" Text="University"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtBDUniversity" runat="server"></asp:TextBox>
        </td>
    </tr><tr>
        <td>
            <asp:Label ID="Label41" runat="server" Text="Percentage"></asp:Label>

        </td>
        <td>
            <asp:TextBox ID="txtBDPercentage" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
<hr />

<h3>6.	UG Diploma </h3>
<table >
    <tr>
        <td > <asp:Label ID="Label17" runat="server" Text="Qualification"></asp:Label></td>
        <td>
            <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlUGD" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlHQ_SelectedIndexChanged">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="txtUGDAdd" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="btnUGDAdd" runat="server" Text="Add" Visible="False" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label18" runat="server" Text="Status"></asp:Label></td>
        <td>
            <asp:RadioButtonList ID="rblUGDStat" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Appeared</asp:ListItem>
                <asp:ListItem>Completed</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label19" runat="server" Text="Year of Completion"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtUGDYear" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label20" runat="server" Text="University"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtUGDUniversity" runat="server"></asp:TextBox>
        </td>
    </tr><tr>
        <td>
            <asp:Label ID="Label42" runat="server" Text="Percentage"></asp:Label>

        </td>
        <td>
            <asp:TextBox ID="txtUgDPercentage" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
<hr />

<h3>7.	HSC / 12th </h3>
<table >
    
    <tr>
        <td > <asp:Label ID="Label22" runat="server" Text="Status"></asp:Label></td>
        <td>
            <asp:RadioButtonList ID="rblHSC" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Appeared</asp:ListItem>
                <asp:ListItem>Completed</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label23" runat="server" Text="Year of Completion"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtHSCYear" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label24" runat="server" Text="University/Board"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtHSCBoard" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label43" runat="server" Text="Percentage"></asp:Label>

        </td>
        <td>
            <asp:TextBox ID="txtHSCPercentage" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
<hr />

<h3>7.	SSC / 10th </h3>
<table >
    
    <tr>
        <td > <asp:Label ID="Label26" runat="server" Text="Status"></asp:Label></td>
        <td>
            <asp:RadioButtonList ID="rblSSC" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Appeared</asp:ListItem>
                <asp:ListItem>Completed</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label27" runat="server" Text="Year of Completion"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtSSCYear" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label28" runat="server" Text="University/Board"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtSSCBoard" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label44" runat="server" Text="Percentage"></asp:Label>

        </td>
        <td>
            <asp:TextBox ID="txtSSCPercentage" runat="server"></asp:TextBox>
        </td>
    </tr>
</table><hr />

<h3>9.	Certifications ></h3>
<table >
    <tr>
        <td > <asp:Label ID="Label29" runat="server" Text="Certificate"></asp:Label></td>
        <td>
            <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlCertification" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlHQ_SelectedIndexChanged">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="TxtCertificationAdd" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="btnCertificationAdd" runat="server" Text="Add" Visible="False" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label30" runat="server" Text="Institute"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtCertificationInstitute" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label31" runat="server" Text="Year of Completion"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtCertificationYear" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label32" runat="server" Text="Grade"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtCertificationGrade" runat="server"></asp:TextBox>
           
                
        </td>
       
    </tr>
    <tr>   <td colspan="2"><asp:UpdatePanel ID="pnlCertificates" runat="server"><ContentTemplate>
            <asp:Button ID="Button1" runat="server" Text="Add More Workshops" OnClick="Button1_Click" />
        <Certification:MoreCertification ID="cert1" runat="server" Visible="false" />
        </ContentTemplate>
        </asp:UpdatePanel></td> </tr>
</table>
<hr />

<h3>10.	Workshops </h3>
<table >
    <tr>
        <td > <asp:Label ID="Label33" runat="server" Text="Workshop Name"></asp:Label></td>
        <td>
            <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlWorkshops" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlHQ_SelectedIndexChanged">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="txtWorkshopsAdd" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="btnWorkshopsAdd" runat="server" Text="Add" Visible="False" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label34" runat="server" Text="Institute"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtWorkshopInstitute" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label35" runat="server" Text="Duration"></asp:Label></td>
        <td>
            <asp:TextBox ID="TxtWrkspDuration" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label36" runat="server" Text="Year of Completion"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtworkshopDuratn" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>

            <asp:Label ID="Label45" runat="server" Text="Grade"></asp:Label>

        </td>
        <td>

            <asp:TextBox ID="txtworkspGrade" runat="server"></asp:TextBox>
            <br />
                

        </td>
    </tr>
    <tr><td colspan="2"><asp:UpdatePanel ID="UpdatePanel7" runat="server">
        <ContentTemplate>
            <asp:Button ID="btnMoreWorkshops" runat="server" Text="Add More Workshops" OnClick="btnMoreWorkshops_Click" />
       <Workshops:MoreWorkshops ID="work1" runat="server" Visible="false"/>
             </ContentTemplate>
        </asp:UpdatePanel>  </td> </tr>
    
</table><hr />


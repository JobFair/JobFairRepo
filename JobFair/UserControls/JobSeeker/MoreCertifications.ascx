<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MoreCertifications.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.MoreCertifications" %>

<link href="../../Style.css" rel="stylesheet" />
<link href="../../Css/Common.css" rel="stylesheet" />

<center>
<asp:Label ID="lblAddCert" runat="server" Text="Add Certifications" Font-Bold="true"></asp:Label>
</center>
<table style="background-color: #C0C0C0">
    <tr>
        <td > <asp:Label ID="lblCert" runat="server" Text="Certification Name"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtCertificationName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="lblIns" runat="server" Text="Institute"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtCertificationInstitute" runat="server"></asp:TextBox>
        </td>
    </tr>
      <tr>
        <td > <asp:Label ID="lblDur" runat="server" Text="Duration"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtCertificationDuration" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="lblYOC" runat="server" Text="Year Of Completion"></asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlMonth" runat="server" AutoPostBack="true"></asp:DropDownList>
            <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="true"></asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="lblGrade" runat="server" Text="Grade"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtCertificationGrade" runat="server"></asp:TextBox>
            <br />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </td>
        <td>
            <asp:Button ID="btnAdd" runat="server" Text="Add More" OnClick="btnAdd_Click"/>
        </td>
    </tr>
    </table>
 <div>
        <asp:Label ID="lblSuccess" runat="server" Text="" ForeColor="Green" Font-Bold="true" Font-Size="14px" Visible="false"></asp:Label>
        <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Font-Bold="true" Font-Size="14px" Visible="false"></asp:Label>
    </div>


<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MoreCertifications.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.MoreCertifications" %>

<link href="../../Style.css" rel="stylesheet" />
<link href="../../Css/Common.css" rel="stylesheet" />

<center>
<asp:Label ID="lblAddCert" runat="server" Text="Add Certifications" Font-Bold="true"></asp:Label>
</center>
<hr />
<table style="background-color: #C0C0C0">
    <tr>
        <td>
            <asp:Label ID="lblCert" runat="server" Text="Certification Name"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtCertificationName" runat="server" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCertificationName" runat="server" ControlToValidate="txtCertificationName" ValidationGroup="vgMoreCertifications" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblIns" runat="server" Text="Institute"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtCertificationInstitute" runat="server" onblur="return CheckOnlyChar(this.id);"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCertificationInstitute" runat="server" ControlToValidate="txtCertificationInstitute" ValidationGroup="vgMoreCertifications" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDur" runat="server" Text="Duration"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtCertificationDuration" runat="server" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCertificationDuration" runat="server" ControlToValidate="txtCertificationDuration" ValidationGroup="vgMoreCertifications" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblYearFrom" runat="server" Text="From" CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlMonthFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvMonthFrom" runat="server" ControlToValidate="ddlMonthFrom" ValidationGroup="vgMoreCertifications" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:DropDownList ID="ddlYearFrom" runat="server" AutoPostBack="true"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvYearFrom" runat="server" ControlToValidate="ddlYearFrom" ValidationGroup="vgMoreCertifications" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblYearTo" runat="server" Text="To" CssClass="label"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlMonthTo" runat="server" AutoPostBack="true"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvMonthTo" runat="server" ControlToValidate="ddlMonthTo" ValidationGroup="vgMoreCertifications" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:DropDownList ID="ddlYearTo" runat="server" AutoPostBack="true"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvYearTo" runat="server" ControlToValidate="ddlYearTo" ValidationGroup="vgMoreCertifications" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblGrade" runat="server" Text="Grade"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtCertificationGrade" runat="server" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCertificationGrade" runat="server" ControlToValidate="txtCertificationGrade" ValidationGroup="vgMoreCertifications" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnAdd" runat="server" Text="Add Certification" ValidationGroup="vgMoreCertifications" OnClick="btnAdd_Click" Style="margin-top: 10px; margin-left: 150px" />
        </td>
    </tr>
</table>
<div style="margin-top: 20px; margin-left: 10px;">
    <asp:HiddenField ID="hfCandidateId" runat="server" />
    <asp:GridView ID="grvAddMore" AutoGenerateColumns="false" runat="server" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField Visible="false" HeaderText="CandidateId" DataField="CandidateId" />
            <asp:BoundField HeaderStyle-Width="120px" HeaderText="Certification Name" DataField="CertificationName" />
            <asp:BoundField HeaderStyle-Width="120px" HeaderText="Certification Institute" DataField="Institute" />
            <asp:BoundField HeaderStyle-Width="120px" HeaderText="Certification Duration" DataField="Duration" />
            <asp:BoundField HeaderStyle-Width="120px" HeaderText="From Year" DataField="FromYear" />
            <asp:BoundField HeaderStyle-Width="120px" HeaderText="To Year" DataField="ToYear" />
            <asp:BoundField HeaderStyle-Width="120px" HeaderText="Certification Grade" DataField="Grade" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</div>
<div style="margin-top: 10px; margin-left: 150px">
    <asp:Button ID="btnsubmitCertifications" runat="server" Style="color: White"
        Text="Save Certifications" BackColor="#999966" OnClick="btnsubmitCertifications_Click" />
</div>

<div>
    <asp:Label ID="lblSuccess" runat="server" Text="" ForeColor="Green" Font-Bold="true" Font-Size="14px" Visible="false"></asp:Label>
    <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Font-Bold="true" Font-Size="14px" Visible="false"></asp:Label>
</div>
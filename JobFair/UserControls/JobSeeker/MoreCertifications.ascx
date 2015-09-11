<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MoreCertifications.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.MoreCertifications1" %>


<link href="../../Style.css" rel="stylesheet" />
<center>
<asp:Label ID="lblAddCert" runat="server" Text="Add Certifications" Font-Bold="true"></asp:Label>
</center>
<table style="background-color: #C0C0C0">
    <tr>
        <td > <asp:Label ID="Label29" runat="server" Text="Certificate"></asp:Label></td>
        <td>
            <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlCertification" runat="server" AutoPostBack="True">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="TxtCertificationAdd" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="btnCertificationAdd" runat="server" Text="Add" Visible="False"/>
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
    </table>



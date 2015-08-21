<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MoreCertifications.ascx.cs" Inherits="JobSeeker_Forms_MoreCertifications" %>

<link href="../../Style.css" rel="stylesheet" />
<table >
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
    </table>
<br />
<hr />
<br />
<table >
    <tr>
        <td > <asp:Label ID="Label1" runat="server" Text="Certificate"></asp:Label></td>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Add" Visible="False" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label2" runat="server" Text="Institute"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label3" runat="server" Text="Year of Completion"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="Label4" runat="server" Text="Grade"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
           
                
        </td>
       
    </tr>
    </table>
<hr />
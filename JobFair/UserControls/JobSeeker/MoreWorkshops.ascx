<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MoreWorkshops.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.MoreWorkshops1" %>

<link href="../../Style.css" rel="stylesheet" />
<center>
<asp:Label ID="lblAddWork" runat="server" Text="Add MoreWorkshops" Font-Bold="true"></asp:Label>
</center>
<table style="background-color: #C0C0C0">
    <tr>
        <td > <asp:Label ID="Label33" runat="server" Text="Workshop Name"></asp:Label></td>
        <td>
            <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlWorkshops" runat="server" AutoPostBack="True" >
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
          <tr>
        <td>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
        </td>
        <td>
            <asp:Button ID="btnAdd" runat="server" Text="Add More" />
        </td>
    </tr>
    </table>

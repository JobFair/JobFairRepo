<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MoreWorkshops.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.MoreWorkshops" %>

<link href="../../Style.css" rel="stylesheet" />
<link href="../../Css/Common.css" rel="stylesheet" />

<center>
<asp:Label ID="lblAddWork" runat="server" Text="Add MoreWorkshops" Font-Bold="true"></asp:Label>
</center>
<table style="background-color: #C0C0C0">
    <tr>
        <td > <asp:Label ID="lblWorkshop" runat="server" Text="Workshop Name"></asp:Label></td>
        <td>
              <asp:TextBox ID="txtWorkshopName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="lblIns" runat="server" Text="Institute"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtWorkshopInstitute" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="lblDur" runat="server" Text="Duration"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtWorkshopDuration" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td > <asp:Label ID="lblYOC" runat="server" Text="Year of Completion"></asp:Label></td>
        <td>
              <asp:DropDownList ID="ddlMonth" runat="server" AutoPostBack="true"></asp:DropDownList>
              <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="true"></asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblGrade" runat="server" Text="Grade"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtworkspGrade" runat="server"></asp:TextBox>
            <br />
        </td>
        </tr>
          <tr>
        <td>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click1" />
        </td>
        <td>
            <asp:Button ID="btnAdd" runat="server" Text="Add More" />
        </td>
    </tr>
    </table>
<div>
        <asp:Label ID="lblSuccess" runat="server" Text="" ForeColor="Green" Font-Bold="true" Font-Size="14px" Visible="false"></asp:Label>
        <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Font-Bold="true" Font-Size="14px" Visible="false"></asp:Label>
    </div>

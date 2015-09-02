<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EducationalDetails.ascx.cs" Inherits="JobFair.UserControls.JobSeeker.EducationalDetails1" %>

<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 164px;
    }
</style>

<div id="divMain" runat="server" visible="true" style="background-color: #C0C0C0">

<h2>Highest Qualification</h2>


<div id="divSSC" runat="server" visible="true">
<h3>1.	SSC / 10th </h3>
<table class="auto-style1">
    <tr>
        <td class="auto-style2"> <asp:Label ID="Label1" runat="server" Text="Year of Completion"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtSSCYear" runat="server" OnTextChanged="txtSSCYear_TextChanged"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2"> <asp:Label ID="Label2" runat="server" Text="University/Board"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtSSCBoard" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Percentage"></asp:Label>

        </td>
        <td>
            <asp:TextBox ID="txtSSCPercentage" runat="server"></asp:TextBox>
        </td>
    </tr>
</table><hr />
</div>

    <% if(txtSSCYear.Text!="" && txtSSCBoard.Text!="" && txtSSCPercentage.Text!="")
       {
           divHSC.Visible = true;
       }
    %>

<div id="divHSC" runat="server" visible="false">
<h3>2.	HSC / 12th </h3>
<table class="auto-style1">
    <tr>
        <td class="auto-style2"> <asp:Label ID="Label4" runat="server" Text="Specialization"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtHSCSpecialization" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2"> <asp:Label ID="Label5" runat="server" Text="Year of Completion"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtHSCYear" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2"> <asp:Label ID="Label6" runat="server" Text="University/Board"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtHSCBoard" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label7" runat="server" Text="Percentage"></asp:Label>

        </td>
        <td>
            <asp:TextBox ID="txtHSCPercentage" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
<hr />
  </div>

</div>
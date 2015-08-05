<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContactPerson.ascx.cs" Inherits="JobFair.Forms.Recruiter.ContactPerson" %>

<link href="../../Style.css" rel="stylesheet" />
<table >
    <tr>
        <td colspan="2" ><h1>Contact Person Details</h1></td>
       
    </tr>
    <tr>
        <td >Name</td>
        <td>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Designation</td>
        <td>
            <asp:TextBox ID="txtDesignation" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Email Id</td>
        <td>
            <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Contact</td>
        <td>
            <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </td>
    </tr>
</table>


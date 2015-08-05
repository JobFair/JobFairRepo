<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EmploymentDetails.ascx.cs" Inherits="JobFair.Forms.Employeer.EmploymentDetails" %>
<link href="../../Style.css" rel="stylesheet" />
<table >
    <tr>
        <td colspan="2"><h1>Employment Details</h1></td>
       
    </tr>
    <tr>
        <td >Functional Area</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td >Industry Type</td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td >Employers</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Height="19px"></asp:TextBox>
            <asp:DropDownList ID="DropDownList3" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList4" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td >Exclude Employer</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Height="19px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <asp:DropDownList ID="DropDownList5" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList6" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td >Designation</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DropDownList7" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList8" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>


<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdvanceSearch.ascx.cs" Inherits="JobFair.Forms.JobSeeker.AdvanceSearch" %>
<style type="text/css">

    .auto-style6 {
        height: 23px;
    }
</style>

<table >
    <tr>
        <td ><strong>Advance Search</strong></td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td >Key Skills</td>
        <td>
            <asp:TextBox ID="txtKeySkills" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Location</td>
        <td>
            <asp:TextBox ID="txtLocation" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Work Experience</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            Years<asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            Months</td>
    </tr>
    <tr>
        <td >Expected Salary</td>
        <td>
            <asp:DropDownList ID="DropDownList3" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList4" runat="server">
            </asp:DropDownList>
            Lakhs</td>
    </tr>
    <tr>
        <td >Industry</td>
        <td >
            <asp:TextBox ID="txtIndustry" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Job Category</td>
        <td>
            <asp:TextBox ID="txtJobCategory" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td >Job Type</td>
        <td>
            <asp:DropDownList ID="DropDownList5" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td >&nbsp;</td>
        <td class="auto-style6">
            <asp:Button ID="btnSearch" runat="server" Text="Search" />
        </td>
    </tr>
    </table>



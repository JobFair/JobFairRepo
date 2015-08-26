<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="EducationalDetailsJobSeeker.aspx.cs" Inherits="JobFair.Forms.JobSeeker.EducationalDetailsJobSeeker" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

table {
    background-color:lightgray;
    color:black;
    table-layout:auto;
    background-color: #CCCCCC;
    }
H1  {
	font-size : 16pt;
	font-family : arial;
	font-weight : bold;
	font-style : normal;
	color : Black;
}


    .auto-style1 {
        width: 264px;
    }


    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table >
        <tr>
            <td colspan="2">
                <h1>Educational Details</h1>
            </td>
        </tr>
        <tr>
            <td >UG Qualification</td>
            <td class="auto-style1">
                <asp:DropDownList ID="DDLUG" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >Institude Name</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtInstituteName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Year of passing</td>
            <td class="auto-style1">
                <asp:DropDownList ID="DDLpassingYear" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >PG Qualification</td>
            <td class="auto-style1">
                <asp:DropDownList ID="DDLPG" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >Institute Name</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtInstituteName1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Year of passing</td>
            <td class="auto-style1">
                <asp:DropDownList ID="DDLpassingyear1" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td class="auto-style1">
                <asp:Button ID="btnsubmiteducationdetails" runat="server" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btncanceleducationaldetails" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>

</asp:Content>

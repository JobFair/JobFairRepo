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
            <td>
                <asp:DropDownList ID="DropDownList5" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >Institude Name</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Year of passing</td>
            <td>
                <asp:DropDownList ID="DropDownList6" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >PG Qualification</td>
            <td>
                <asp:DropDownList ID="DropDownList7" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >Institute Name</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Year of passing</td>
            <td>
                <asp:DropDownList ID="DropDownList8" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
    </table>

</asp:Content>

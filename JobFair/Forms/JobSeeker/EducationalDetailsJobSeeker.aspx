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
            width: 463px;
        }


        .auto-style2 {
            height: 18px;
        }
        .auto-style3 {
            width: 463px;
            height: 18px;
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
                <asp:DropDownList ID="ddlPassingYear" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >PG Qualification</td>
            <td class="auto-style1">
                <asp:DropDownList ID="ddlPG" runat="server">
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
                <asp:DropDownList ID="ddlPassingYear1" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td class="auto-style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" ></td>
            <td class="auto-style3">
                <asp:Button ID="btnSubmitEducationDetails" runat="server" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelEducationalDetails" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>

</asp:Content>

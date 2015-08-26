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
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            width: 463px;
            height: 26px;
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
                <asp:DropDownList ID="ddlUG" runat="server">
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
            <td >Percentage</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtPercentage" runat="server"></asp:TextBox>
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
            <td >Percentage</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtPercentagePg" runat="server"></asp:TextBox>
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
            <td >HSC/12th</td>
            <td class="auto-style1">
                &nbsp;&nbsp;<asp:DropDownList ID="ddlHSC" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >&nbsp;Institute Name&nbsp;</td>
            <td class="auto-style1">
                &nbsp;&nbsp;<asp:TextBox ID="txtInstituteNameHsc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Percentage</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtPersantageHsc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Year Of Passing</td>
            <td class="auto-style1">
                <asp:DropDownList ID="ddlPassingYearHsc" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" >SSC/10th</td>
            <td class="auto-style5">
                <asp:DropDownList ID="ddlSSC" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >Institute Name</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtInstituteNameSsc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Percantage</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtPersantageSsc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" >Certifications</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtCertfications" runat="server" TextMode="MultiLine" Width="221px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Institute Name</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtInstituteNameCertification" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Grade</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtGrade" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >WorkShop</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtWorkshop" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Topic</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtTopic" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Institute Name</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtWorkshopInstituteName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Days</td>
            <td class="auto-style1">
                <asp:DropDownList ID="ddlDays" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >Year</td>
            <td class="auto-style1">
                <asp:DropDownList ID="ddlYear" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >Grade</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtGradeOfWorkShop" runat="server"></asp:TextBox>
            </td>
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

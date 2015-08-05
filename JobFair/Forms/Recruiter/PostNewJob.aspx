<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Recruiter/ProfilePage.Master" AutoEventWireup="true" CodeBehind="PostNewJob.aspx.cs" Inherits="JobFair.Forms.Recruiter.PostNewJob1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style7 {
            width: 214px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style6">
        <tr>
            <td colspan="2">
                <h1>Post New Job</h1>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Job Title/Designation</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Job Locations</td>
            <td>
                <div id="divDDL" class="divDDL" runat="server">
        Please Select…
                </div>
                <asp:Panel ID="pnlCustomers" runat="server" CssClass="MultipleSelectionDDL" Height="49px" Width="85px">
                    <asp:CheckBoxList ID="cblCustomerList" runat="server" onclick="readCheckBoxList()" Width="75px" >
                        <asp:ListItem>Pune</asp:ListItem>
                        <asp:ListItem>Mumbai</asp:ListItem>
                    </asp:CheckBoxList>
                </asp:Panel>
                <br /></td>
        </tr>
        <tr>
            <td class="auto-style7">Company Level</td>
            <td>
                <asp:DropDownList ID="ddlCompanyLevel" runat="server" AutoPostBack="True">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>Startup Company</asp:ListItem>
                    <asp:ListItem>Small Scale Company</asp:ListItem>
                    <asp:ListItem>Mid Level Company</asp:ListItem>
                    <asp:ListItem>MNC</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Industry</td>
            <td>
                <asp:DropDownList ID="ddlIndustry" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Department</td>
            <td>
                <asp:DropDownList ID="ddlDept" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Functional Area</td>
            <td>
                <asp:DropDownList ID="ddlFunArea" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Job Description</td>
            <td>
                <asp:TextBox ID="txtJobDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Keywords/Skillsets Roles</td>
            <td>
                <asp:TextBox ID="txtKeyRoles" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Keywords/Skillsets Technical</td>
            <td>
                <asp:TextBox ID="txtKeyTechnical" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Work Experience</td>
            <td><asp:TextBox ID="txtWorkExp" runat="server"></asp:TextBox>
                <cc1:CalendarExtender ID="txtWorkExp_CalendarExtender" runat="server" BehaviorID="txtWorkExp_CalendarExtender" TargetControlID="txtWorkExp">
                </cc1:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Gender</td>
            <td>
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Offered Anual Salary</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">Other Salary Details</td>
            <td>
                <asp:TextBox ID="txtSalaryDetails" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Number of Vacancies</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>
                <asp:Button ID="btnPostJob" runat="server" Text="Post Job" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</asp:Content>

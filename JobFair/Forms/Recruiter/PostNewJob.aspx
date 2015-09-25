<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Recruiter/RecruiterHome.Master" AutoEventWireup="true" CodeBehind="PostNewJob.aspx.cs" Inherits="JobFair.Forms.Recruiter.PostNewJob1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 
    <style type="text/css">
        .auto-style1 {
            height: 33px;
        }
    </style>
 
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <table>
        <tr>
            <td>
                <h1>Post New Job</h1>
            </td>
        </tr>
        <tr>
            <td>Job Title/Designation</td>
            <td>
                <asp:TextBox ID="txtJobtitle" runat="server" TextMode="MultiLine" Width="301px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Job Locations</td>
            <td>
                <asp:TextBox ID="txtJobLocation" runat="server"></asp:TextBox>
                <br /></td>
        </tr>
        <tr>
            <td>Job Locations Area</td>
            <td>
                <asp:TextBox ID="txtJobLocationArea" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Company Level</td>
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
            <td>Industry</td>
            <td>
                <asp:DropDownList ID="ddlIndustry" runat="server" Height="19px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Department</td>
            <td>
                <asp:DropDownList ID="ddlDepartment" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Functional Area</td>
            <td>
                <asp:DropDownList ID="ddlFunArea" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Job Description</td>
            <td>
                <asp:TextBox ID="txtJobDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Keywords/Skillsets Roles</td>
            <td>
                <asp:TextBox ID="txtKeyRoles" runat="server" Height="26px" Width="292px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Keywords/Skillsets Technical</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtKeyTechnical" runat="server" Height="22px" Width="285px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Work Experience</td>
            <td>From <asp:TextBox ID="txtFromdate" runat="server"></asp:TextBox>
                <cc1:CalendarExtender ID="txtFromdate_CalendarExtender" runat="server" BehaviorID="txtFromdate_CalendarExtender" TargetControlID="txtFromdate"></cc1:CalendarExtender>
                <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender2" runat="server" WatermarkText="From Year" TargetControlID="txtFromdate" WatermarkCssClass="c" />
                &nbsp;To <asp:TextBox ID="txtTill" runat="server" Height="16px" Width="100px"></asp:TextBox>
                <cc1:CalendarExtender ID="txtTill_CalendarExtender" runat="server" BehaviorID="txtTill_CalendarExtender" TargetControlID="txtTill"></cc1:CalendarExtender>
                <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender3" runat="server" WatermarkText="To Year" TargetControlID="txtTill" WatermarkCssClass="c" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp; 
            </td>
        </tr>
        <tr>
            <td>Gender</td>
            <td>
                <asp:DropDownList ID="ddlgender" runat="server" AutoPostBack="True">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Both</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Offered Anual Salary</td>
            <td>
                &nbsp;&nbsp;<asp:DropDownList ID="ddlsalarymin" runat="server">
                      <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>5000</asp:ListItem>
                    <asp:ListItem>10,000</asp:ListItem>
                    <asp:ListItem>15,000</asp:ListItem>
                    <asp:ListItem>20,000</asp:ListItem>
                    <asp:ListItem>25,000</asp:ListItem>
                    <asp:ListItem>30,000</asp:ListItem>
                    <asp:ListItem>35,000</asp:ListItem>
                    <asp:ListItem>40,000</asp:ListItem>
                    <asp:ListItem>45,000</asp:ListItem>
                     <asp:ListItem>50,000</asp:ListItem>
                </asp:DropDownList>
&nbsp;<asp:Label ID="lblmin" runat="server" Text="Min"></asp:Label>
&nbsp;&nbsp;
                <asp:DropDownList ID="ddlsalarymax" runat="server">
                     <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>5000</asp:ListItem>
                    <asp:ListItem>60,000</asp:ListItem>
                    <asp:ListItem>65,000</asp:ListItem>
                    <asp:ListItem>70,000</asp:ListItem>
                    <asp:ListItem>75,000</asp:ListItem>
                    <asp:ListItem>80,000</asp:ListItem>
                    <asp:ListItem>85,000</asp:ListItem>
                    <asp:ListItem>90,000</asp:ListItem>
                    <asp:ListItem>95,000</asp:ListItem>
                </asp:DropDownList>
&nbsp;
                <asp:Label ID="lblmin0" runat="server" Text="Max"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;OtherSalaryDetails</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtsalarydetaills" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Number of Vacancies</td>
            <td>
                <asp:TextBox ID="txtVacancies" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" />
             </td>
            <td>
                <asp:Button ID="btnPostJob" runat="server" Text="Post Job" OnClick="btnPostJob_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

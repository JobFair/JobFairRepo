<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/JobSeeker/JobSeekerHome.Master" AutoEventWireup="true" CodeBehind="AdvanceSearch.aspx.cs" Inherits="JobFair.Forms.JobSeeker.AdvanceSearch" %>
 <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp"%>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
 </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbladvancesearch" runat="server" Text="AdvanceSearch"></asp:Label>

    &nbsp;
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <br />
    <table>
        <tr>
            <td>
                <asp:Label ID="lblkeyskill" runat="server" Text="KeySkill"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtkeyskill" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbllocation" runat="server" Text="Location"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtlocation" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblworkexprience" runat="server" Text="Work Exprience"></asp:Label>
            </td>
            <td><asp:TextBox ID="txtFromdate" runat="server"></asp:TextBox>
                <cc1:CalendarExtender ID="txtFromdate_CalendarExtender" runat="server" BehaviorID="txtFromdate_CalendarExtender" TargetControlID="txtFromdate"></cc1:CalendarExtender>
                <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender2" runat="server" WatermarkText="From Year" TargetControlID="txtFromdate" WatermarkCssClass="c" />
                &nbsp;&nbsp;&nbsp; To <asp:TextBox ID="txtTill" runat="server"></asp:TextBox>
                <cc1:CalendarExtender ID="txtTill_CalendarExtender" runat="server" BehaviorID="txtTill_CalendarExtender" TargetControlID="txtTill"></cc1:CalendarExtender>
                <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender3" runat="server" WatermarkText="To Year" TargetControlID="txtTill" WatermarkCssClass="c" />
                &nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbsalary" runat="server" Text="Expected Salary"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtexpectedsalary" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblindustry" runat="server" Text="Industry"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlIndustry" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbljobcategory" runat="server" Text="JobCategory"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtjobcategory" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" Width="97px" />
            </td>
        </tr>
    </table>

    <br />
</asp:Content>

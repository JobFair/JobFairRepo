﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientRequirements.aspx.cs" Inherits="JobFair.Forms.HR.ClientRequirements" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Css/Style.css" rel="stylesheet" />
    <link href="../../Css/Common.css" rel="stylesheet" />
</head>
<body>
    < <form id="ClientRequirements" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div id="divMain" runat="server" style="min-height: 500px; padding: 10px">

    <center><h2>
        Client Requirements
    </h2></center>
        <table style="margin-left: 10px">
            <tr>
                <td><asp:Label ID="lblClientName" runat="server" Text=" Client Name " CssClass="label"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="ddlClientName" runat="server" AutoPostBack="True" AppendDataBoundItems="true">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblClientProfile" runat="server" Text=" Client Profile " CssClass="label"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtClientProfile" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblPosition" runat="server" Text=" Position " CssClass="label"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtPosition" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td><asp:Label ID="lblIndustry" runat="server" Text=" Industry " CssClass="label"></asp:Label></td>
                <td>
                   <asp:DropDownList ID="ddlIndustry" runat="server" AutoPostBack="True"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblFunctionalArea" runat="server" Text=" Functional Area " CssClass="label"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="ddlFunctionalArea" runat="server" AutoPostBack="True" AppendDataBoundItems="true">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblAddress" runat="server" Text=" Address " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </td>
            </tr>           
            <tr>
                <td><asp:Label ID="lblCountry" runat="server" Text=" Country " CssClass="label"></asp:Label></td>
                <td>
                   <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblState" runat="server" Text=" State " CssClass="label"></asp:Label></td>
                <td>
                   <asp:DropDownList ID="ddlState" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" ></asp:DropDownList>
                </td>
            </tr>            
            <tr>
                <td><asp:Label ID="lblCity" runat="server" Text=" City " CssClass="label"></asp:Label></td>
                <td>
                   <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblArea" runat="server" Text=" Area " CssClass="label"></asp:Label></td>
                <td>
                   <asp:DropDownList ID="ddlArea" runat="server" AutoPostBack="True"></asp:DropDownList>
                </td>
            </tr> 
            <tr>
                <td><asp:Label ID="lblPincode" runat="server" Text=" Pincode " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtPincode" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblSkillsets" runat="server" Text=" Skillsets " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtSkillsets" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td><asp:Label ID="lblContents" runat="server" Text=" Contents " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtContents" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblDateofRequirementSent" runat="server" Text=" Date of Requirement Sent " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtDateofRequirementSent" runat="server"></asp:TextBox>
                   <ajax:CalendarExtender ID="caltxtDateofRequirementSent" runat="server" PopupButtonID="txtDateofRequirementSent" TargetControlID="txtDateofRequirementSent" Format="dd/MM/yyyy" />
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblDueDate" runat="server" Text=" Due Date " CssClass="label"></asp:Label></td>
                <td>
                   <asp:TextBox ID="txtDueDate" runat="server"></asp:TextBox>
                   <ajax:CalendarExtender ID="caltxtDueDate" runat="server" PopupButtonID="txtDueDate" TargetControlID="txtDueDate" Format="dd/MM/yyyy" />
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblStatus" runat="server" Text=" Client Profile " CssClass="label"></asp:Label></td>
                <td>
                    <asp:RadioButtonList ID="rbtlistStatus" runat="server"></asp:RadioButtonList>
                </td>
            </tr>

        </table>
    </div>
    </form>
</body>
</html>

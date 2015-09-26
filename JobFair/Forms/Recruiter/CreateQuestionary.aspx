<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Recruiter/RecruiterHome.Master" AutoEventWireup="true" CodeBehind="CreateQuestionary.aspx.cs" Inherits="JobFair.Forms.Recruiter.CreateQuestionary" %>
<%@ Register src="../../UserControls/Recruiter/ClientDetails.ascx" tagname="ClientDetails" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <uc1:ClientDetails ID="ClientDetails1" runat="server" />
    
</asp:Content>

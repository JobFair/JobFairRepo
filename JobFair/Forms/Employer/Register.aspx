<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Employer/HomePageEmployer.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="JobFair.Forms.Employer.Register" %>
<%@ Register src="../../UserControls/Recruiter/ClientDetails.ascx" tagname="ClientDetails" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ClientDetails ID="ClientDetails1" runat="server" />
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Recruiter/RecruiterHome.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="JobFair.Forms.Recruiter.LogIn" %>

<%@ Register Src="~/UserControls/Recruiter/RecruiterRegistration.ascx" TagPrefix="uc1" TagName="RecruiterRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:RecruiterRegistration runat="server" ID="RecruiterRegistration" />
</asp:Content>

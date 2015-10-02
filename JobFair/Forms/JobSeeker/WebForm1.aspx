<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webform1.aspx.cs" Inherits="JobFair.Forms.JobSeeker.WebForm1" %>

<%@ Register Src="~/UserControls/JobSeeker/TechnicalSkillsDetails.ascx" TagPrefix="uc1" TagName="TechnicalSkillsDetails" %>


<%--<%@ Register Src="~/UserControls/JobSeeker/ProfessionalDetails.ascx" TagPrefix="uc1" TagName="ProfessionalDetails" %>
<%@ Register Src="~/UserControls/Recruiter/RecruiterRegistration.ascx" TagPrefix="uc1" TagName="RecruiterRegistration" %>--%>
<%--<%@ Register Src="~/UserControls/JobSeeker/AffirmativeDetails.ascx" TagPrefix="uc1" TagName="AffirmativeDetails" %>--%>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:TechnicalSkillsDetails runat="server" id="TechnicalSkillsDetails" />
       <%-- <uc1:ProfessionalDetails runat="server" id="ProfessionalDetails" />
        <uc1:RecruiterRegistration runat="server" ID="RecruiterRegistration" />
        <uc1:AffirmativeDetails runat="server" ID="AffirmativeDetails" />--%>
    </div>
    </form>
</body>
</html>

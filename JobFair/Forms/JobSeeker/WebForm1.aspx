<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="JobFair.Forms.JobSeeker.WebForm1" %>

<%@ Register Src="~/UserControls/Recruiter/RecruiterRegistration.ascx" TagPrefix="uc1" TagName="RecruiterRegistration" %>







<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:RecruiterRegistration runat="server" ID="RecruiterRegistration" />
    </div>
    </form>
</body>
</html>

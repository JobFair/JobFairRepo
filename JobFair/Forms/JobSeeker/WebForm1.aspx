<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webform1.aspx.cs" Inherits="JobFair.Forms.JobSeeker.WebForm1" %>

<%@ Register Src="~/UserControls/JobSeeker/ResumeFormating.ascx" TagPrefix="uc1" TagName="ResumeFormating" %>












<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:ResumeFormating runat="server" ID="ResumeFormating" />
    </div>
    </form>
</body>
</html>

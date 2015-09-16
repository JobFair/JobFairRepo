<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="JobFair.Forms.JobSeeker.WebForm1" %>

<%@ Register Src="~/UserControls/JobSeeker/LiveProjectDetails.ascx" TagPrefix="uc1" TagName="LiveProjectDetails" %>





<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:LiveProjectDetails runat="server" id="LiveProjectDetails" />
    </div>
    </form>
</body>
</html>

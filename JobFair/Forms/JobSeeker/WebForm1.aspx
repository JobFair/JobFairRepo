<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="JobFair.Forms.JobSeeker.WebForm1" %>

<%@ Register Src="~/UserControls/JobSeeker/PersonalDetails.ascx" TagPrefix="uc1" TagName="PersonalDetails" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:PersonalDetails runat="server" id="PersonalDetails" />
       
    </div>
    </form>
</body>
</html>

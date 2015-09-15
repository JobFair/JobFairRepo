<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="JobFair.Forms.JobSeeker.WebForm1" %>

<%@ Register Src="~/UserControls/JobSeeker/AffirmativeDetails.ascx" TagPrefix="uc1" TagName="AffirmativeDetails" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:AffirmativeDetails runat="server" ID="AffirmativeDetails" />
    </div>
    </form>
</body>
</html>

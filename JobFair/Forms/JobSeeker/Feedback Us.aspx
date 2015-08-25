<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback Us.aspx.cs" Inherits="JobFair.Forms.JobSeeker.Feedback_Us" %>



<%@ Register src="../../UserControls/JobSeeker/ChangePassword.ascx" tagname="ChangePassword" tagprefix="uc1" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:ChangePassword ID="ChangePassword1" runat="server" />

    
    </div>
    </form>
</body>
</html>

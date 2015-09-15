   <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DemoEducationalDetails.aspx.cs" Inherits="JobFair.UserControls.JobSeeker.DemoEducationalDetails" %>


<%@ Register src="~/UserControls/JobSeeker/EducationalDetails.ascx" tagname="EducationalDetails" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style10 {
            width: 377px;
        }
        .auto-style11 {
            width: 500px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
       <div>
              <uc1:EducationalDetails ID="EducationalDetails1" runat="server" />    
       </div>
    </form>
</body>
</html>

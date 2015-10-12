<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webform1.aspx.cs" Inherits="JobFair.Forms.JobSeeker.WebForm1" %>

<%@ Register Src="~/UserControls/JobSeeker/ProfessionalDetails.ascx" TagPrefix="uc1" TagName="ProfessionalDetails" %>








<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
     
</head>
<body>
   <form id="form1" runat="server">
       
       <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
       <uc1:ProfessionalDetails runat="server" id="ProfessionalDetails" />
       
    </form>
</body>
</html>
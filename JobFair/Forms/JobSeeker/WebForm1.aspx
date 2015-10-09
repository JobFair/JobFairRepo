<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webform1.aspx.cs" Inherits="JobFair.Forms.JobSeeker.WebForm1" %>

<%@ Register Src="~/UserControls/JobSeeker/TechnicalSkillsDetails.ascx" TagPrefix="uc1" TagName="TechnicalSkillsDetails" %>





<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
</head>
<body>
   
    <form id="form1" runat="server">
         <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <uc1:TechnicalSkillsDetails runat="server" ID="TechnicalSkillsDetails" />
        </div>
    </form>
</body>
</html>
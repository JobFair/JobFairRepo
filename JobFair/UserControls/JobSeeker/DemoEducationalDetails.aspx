   <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DemoEducationalDetails.aspx.cs" Inherits="JobFair.UserControls.JobSeeker.DemoEducationalDetails" %>

<%@ Register Src="~/UserControls/JobSeeker/EducationalDetails.ascx" TagPrefix="uc1" TagName="EducationalDetails" %>



<%--<%@ Register src="~/UserControls/JobSeeker/EducationalDetails.ascx" tagname="EducationalDetails" tagprefix="uc1" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
       <div>
           <uc1:EducationalDetails runat="server" ID="EducationalDetails" />
       </div>
    </form>
</body>
</html>

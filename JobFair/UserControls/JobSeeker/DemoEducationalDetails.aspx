   <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DemoEducationalDetails.aspx.cs" Inherits="JobFair.UserControls.JobSeeker.DemoEducationalDetails" %>


<%@ Register src="~/UserControls/JobSeeker/EducationalDetails.ascx" tagname="EducationalDetails" tagprefix="uc1" %>
<%@ Register src="~/UserControls/JobSeeker/MoreCertifications.ascx" tagname="MoreCertifications" tagprefix="uc2" %>
<%@ Register src="~/UserControls/JobSeeker/MoreWorkshops.ascx" tagname="MoreWorkshops" tagprefix="uc3" %>

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
       <table style="background-color: #C0C0C0"">
        <tr>
            <td class="auto-style11">
                <uc2:MoreCertifications ID="MoreCertifications1" runat="server" />
            </td>
            <td class="auto-style11">
                <uc3:MoreWorkshops ID="MoreWorkshops1" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>

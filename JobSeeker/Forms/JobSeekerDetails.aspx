<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JobSeekerDetails.aspx.cs" Inherits="JobSeeker_Forms_JobSeekerDetails" %>
<%@ Register Src="~/JobSeeker/Forms/EducationalDetails.ascx" TagName="EducationDetail" TagPrefix="edu" %>
<%@ Register Src="~/JobSeeker/Forms/PersonalDetails.ascx" TagName="PersonalInfo" TagPrefix="Person" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
   
    <form id="form1" runat="server">
    <div>
     <asp:ScriptManager runat="server"></asp:ScriptManager>
    <asp:Button ID="btnEducatn" runat="server" OnClick="btnEducatn_Click" Text="Educational Details" />
    
    <asp:Button ID="btnPersonalDetails" runat="server" Text="Personal Details" OnClick="btnPersonalDetails_Click" />
    <edu:EducationDetail ID="educationDetail" runat="server" visible="false"/>
    <Person:PersonalInfo id="person1" runat="server" visible="false"></Person:PersonalInfo>
    </div>
    </form>
</body>
</html>

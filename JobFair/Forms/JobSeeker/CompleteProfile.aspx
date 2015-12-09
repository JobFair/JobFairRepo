<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompleteProfile.aspx.cs" Inherits="JobFair.Forms.JobSeeker.CompleteProfile" %>

<%@ Register Src="~/UserControls/JobSeeker/PersonalDetails.ascx" TagPrefix="uc1" TagName="PersonalDetails" %>
<%@ Register Src="~/UserControls/JobSeeker/ContactDetails.ascx" TagPrefix="uc1" TagName="ContactDetails" %>
<%@ Register Src="~/UserControls/JobSeeker/AffirmativeDetails.ascx" TagPrefix="uc1" TagName="AffirmativeDetails" %>
<%@ Register Src="~/UserControls/JobSeeker/TechnicalSkillsDetails.ascx" TagPrefix="uc1" TagName="TechnicalSkillsDetails" %>
<%@ Register Src="~/UserControls/JobSeeker/RoleSkillsDetails.ascx" TagPrefix="uc1" TagName="RoleSkillsDetails" %>
<%@ Register Src="~/UserControls/JobSeeker/ProfessionalDetails.ascx" TagPrefix="uc1" TagName="ProfessionalDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../Css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="container">
            <h2>Complete Your Profile</h2>
            <ul class="nav nav-tabs">
                <li class="active"><a data-toggle="tab" href="#menu0">Affirmative Info</a></li>
                <li><a data-toggle="tab" href="#menu1">Contact Info</a></li>
                <li><a data-toggle="tab" href="#menu2">Technical Info</a></li>
                <li><a data-toggle="tab" href="#menu3">Personal Info</a></li>
                <li><a data-toggle="tab" href="#menu4">Roles Skills</a></li>
                <li><a data-toggle="tab" href="#menu5">Professional Info</a></li>
            </ul>

            <div class="tab-content">
                <div id="menu0" class="tab-pane fade in active">
                    <h3>Affirmative Details</h3>

                    <uc1:AffirmativeDetails runat="server" ID="AffirmativeDetails" />
                </div>
                <div id="menu1" class="tab-pane fade">
                    <h3>Contact Details</h3>

                    <uc1:ContactDetails runat="server" ID="ContactDetails" />
                </div>
                <div id="menu2" class="tab-pane fade">
                    <h3>Technical Skills</h3>

                    <uc1:TechnicalSkillsDetails runat="server" ID="TechnicalSkillsDetails" />
                </div>
                <div id="menu3" class="tab-pane fade">
                    <h3>Personal Details</h3>

                    <uc1:PersonalDetails runat="server" ID="PersonalDetails" />
                </div>
                <div id="menu4" class="tab-pane fade">
                    <h3>Roles Skills</h3>
                    <uc1:RoleSkillsDetails runat="server" ID="RoleSkillsDetails" />
                </div>
                <div id="menu5" class="tab-pane fade">
                    <h3>Professional Details</h3>
                    <uc1:ProfessionalDetails runat="server" ID="ProfessionalDetails" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
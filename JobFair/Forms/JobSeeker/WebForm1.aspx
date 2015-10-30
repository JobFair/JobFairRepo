<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webform1.aspx.cs" Inherits="JobFair.Forms.JobSeeker.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="~/UserControls/JobSeeker/ProfessionalDetails.ascx" TagPrefix="uc1" TagName="ProfessionalDetails" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <script src="../../Scripts/jquery-2.1.4.min.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="TextBox1"  MinimumPrefixLength="1"
           EnableCaching="true" CompletionSetCount="1" CompletionInterval="1000" ServiceMethod="Getcity"></cc1:AutoCompleteExtender>
        <%-- <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtkeyskill" MinimumPrefixLength="1"
                                    EnableCaching="true" CompletionSetCount="1" CompletionInterval="1000" ServiceMethod="GetKeySkills">
                                </cc1:AutoCompleteExtender>--%>
        <uc1:ProfessionalDetails runat="server" ID="ProfessionalDetails" />
    </form>
</body>
</html>
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
    <script src="../../Scripts/ValidationAll.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:TextBox ID="txtUserName" runat="server" onchange="return CharOnly(evt);" ></asp:TextBox>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </form>
</body>
</html>
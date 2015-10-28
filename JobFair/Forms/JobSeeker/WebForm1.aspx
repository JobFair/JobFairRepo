<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webform1.aspx.cs" Inherits="JobFair.Forms.JobSeeker.WebForm1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>





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



     <%--   <cc1:AutoCompleteExtender ID="TextBox1_AutoCompleteExtender" runat="server" TargetControlID="TextBox1"
            EnableCaching="true" CompletionSetCount="1" CompletionInterval="1000"
            MinimumPrefixLength="1" ServiceMethod="GetCity">
        </cc1:AutoCompleteExtender>--%>

        <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="TextBox1"
            EnableCaching="true" CompletionSetCount="1" CompletionInterval="1000"
            MinimumPrefixLength="1" ServiceMethod="GetCity"></cc1:AutoCompleteExtender>

       
    </form>
</body>
</html>
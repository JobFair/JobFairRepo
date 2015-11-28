<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequestEmail.aspx.cs" Inherits="JobFair.Forms.JobSeeker.RequestEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <%--  <link href="../../Css/bootstrap.min.css" rel="stylesheet" />
      <script src="../../Scripts/bootstrap.min.js"></script>
      <script src="../../Scripts/jquery.min.js"></script>--%>
</head>
<body>
    <form id="form1" runat="server">
        <table class="nav-justified">
            <tr>
                <td colspan="2"><h2>Email Request</h2></td>
            </tr>
            <tr>
                <td>From</td>
                <td>
                    <asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Subject</td>
                <td>
                    <asp:DropDownList ID="ddlSubject" runat="server">
                        <asp:ListItem>Career Counseling</asp:ListItem>
                        <asp:ListItem>Resume Guideline</asp:ListItem>
                        <asp:ListItem>Aptitude Test</asp:ListItem>
                        <asp:ListItem>Other Help</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Email Content/Matter</td>
                <td>
                    <asp:TextBox ID="txtEmailContent" runat="server" TextMode="MultiLine" Height="178px" Width="382px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Topic</td>
                <td>
                    <asp:TextBox ID="txtTopic" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>

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
                    <asp:DropDownList ID="ddlSubject" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSubject_SelectedIndexChanged">
                        <asp:ListItem Value="Career Counseling">Career Counseling</asp:ListItem>
                        <asp:ListItem Value="Resume Guideline">Resume Guideline</asp:ListItem>
                        <asp:ListItem Value="Aptitude Test">Aptitude Test</asp:ListItem>
                        <asp:ListItem Value="Other Help">Other Help</asp:ListItem>
                    </asp:DropDownList><br />
                    <asp:TextBox ID="txtSubject" runat="server" Visible="false" placeholder="Your Subject" Height="25px" Width="382px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Email Content/Matter</td>
                <td>
                    <asp:TextBox ID="txtEmailContent" runat="server" TextMode="MultiLine" Height="178px" Width="382px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click" />
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" Visible="False"></asp:TextBox>
                    <asp:TextBox ID="txtMobNo" runat="server" Visible="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>

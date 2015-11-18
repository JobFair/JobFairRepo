<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="JobFair.Forms.JobSeeker.Feedback" %>

<script  type="text/javascript" src="../../Scripts/ValidationAll.js"></script>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Feedback Form</h2>
<br />
<table>
    <tr>
        <td>
            Name:</td>
        <td>
            <asp:TextBox ID="txtName" runat="server" Columns="50" onkeypress="return CheckOnlyChar(this.id);"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Subject:
        </td>
        <td>
            <asp:DropDownList ID="ddlSubject" runat="server">
                <asp:ListItem>Ask a question</asp:ListItem>
                <asp:ListItem>Report a bug</asp:ListItem>
                <asp:ListItem>Customer support ticket</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            Feedback:
        </td>
        <td>
            <asp:TextBox ID="txtMessage" runat="server" Columns="40" Rows="6" TextMode="MultiLine" onkeypress="return CheckAlphaNumeric(this.id);"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                onclick="btnSubmit_Click" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </td>
    </tr>
</table>
    </div>
    </form>
</body>
</html>

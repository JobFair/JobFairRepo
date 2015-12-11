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
            <asp:TextBox ID="txtName" runat="server" Columns="50" onblur="return CheckOnlyChar(this.id);"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtName" ValidationGroup="vgFeedback"></asp:RequiredFieldValidator>
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
                <asp:ListItem>Forgot username and password</asp:ListItem>
                <asp:ListItem>How To Block Companies</asp:ListItem>
                <asp:ListItem>How To Create and Edit Job messenger</asp:ListItem>
                <asp:ListItem>How To Create Cover Letter</asp:ListItem>
                <asp:ListItem>How to create edit and delete search agents</asp:ListItem>
                <asp:ListItem>How to change password</asp:ListItem>
                <asp:ListItem>How to register as a fresher</asp:ListItem>
                <asp:ListItem>How to mark your CV as not searchable</asp:ListItem>
                <asp:ListItem>How to search and apply</asp:ListItem>
                <asp:ListItem>Unable to Login</asp:ListItem>
                <asp:ListItem>How to create new profile</asp:ListItem>
                <asp:ListItem>Problem in Recruiters Preview</asp:ListItem>
                <asp:ListItem>Unable to attach resume</asp:ListItem>
                <asp:ListItem>Getting run time/java script error</asp:ListItem>
                <asp:ListItem>Suggestions</asp:ListItem>
                <asp:ListItem>How to delete my account</asp:ListItem>
                <asp:ListItem>Not getting job alerts</asp:ListItem>
                <asp:ListItem>Mobile/email verification</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvSubject" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="ddlSubject" ValidationGroup="vgFeedback"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Feedback:
        </td>
        <td>
            <asp:TextBox ID="txtMessage" runat="server" Columns="40" Rows="6" TextMode="MultiLine" onblur="return CheckAlphaNumeric(this.id);"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvMessage" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtMessage" ValidationGroup="vgFeedback"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" onclick="btnSubmit_Click"  ValidationGroup="vgFeedback"/>
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

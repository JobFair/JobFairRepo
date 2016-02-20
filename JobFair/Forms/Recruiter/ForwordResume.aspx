<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForwordResume.aspx.cs" Inherits="JobFair.Forms.Recruiter.ForwordResume" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
    <div style="height: 406px">
    <table border="0" cellpadding="0" cellspacing="0">
    <tr>
        <td style="width: 80px">
            To:
        </td>
        <td>
            <asp:DropDownList ID="ddlclientlist" runat="server" OnSelectedIndexChanged="ddlclientlist_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <asp:TextBox runat="server" ID="txtTo" ReadOnly="true"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
    </tr>
        <tr>
            <td>
                from
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtfrom"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
    <tr>
        <td>
            Subject:
        </td>
        <td>
            <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td valign = "top">
            Body:</td>
        <td>
            <asp:TextBox ID="txtBody" runat="server" TextMode = "MultiLine" Height = "150" Width = "200"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            File Attachment:
        </td>
        <td>
            <asp:FileUpload ID="fuAttachment" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
    </tr>
    
    <tr>
        <td>
        </td>
        <td>
            <asp:Button Text="Send" OnClick="SendEmail" runat="server" />
        </td>
    </tr>
</table>

    </div>
    </form>
</body>
</html>

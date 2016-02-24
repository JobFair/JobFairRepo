<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchResume.aspx.cs" Inherits="JobFair.Forms.Recruiter.SearchResume" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table>
                <tr>
                    <td colspan="2"><h2>Search Resume</h2></td>
                </tr>
                <tr>
                    <td>Client Name</td>
                    <td>
                        <asp:DropDownList ID="ddlClientName" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlClientName_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Position</td>
                    <td>
                        <asp:DropDownList ID="ddlPosition" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPosition_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Requirement ID</td>
                    <td>
                        <asp:Label ID="lblRequirementId" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
    <div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem>Boolean Search</asp:ListItem>
            <asp:ListItem>Keywords</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Panel ID="pnlBooleanSearch" runat="server">
            <div>
                <table>
                    <tr>
                        <td>Any Keywords</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>All Keywords</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Excluding Keywords</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                    <td>

                    </td></tr>
                </table>
            </div>
        </asp:Panel>
        <asp:Panel ID="pnlKeywords" runat="server"></asp:Panel>
    </div>
</body>
</html>
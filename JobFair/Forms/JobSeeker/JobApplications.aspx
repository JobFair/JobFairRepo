<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobApplications.aspx.cs" Inherits="JobFair.Forms.JobSeeker.JobApplications" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Repeater ID="jobapplicationrptr" runat="server">
        <HeaderTemplate>
            <tr>
                <td>
                    <table style="border: 1px solid #0000FF">
                        <tr style="font-size: large; font-weight: bold; margin-bottom: 5px">
                            <td>
                            JobPost
                            </td>
                        </tr>
                    </table>
                </td>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <table>
                        <tr>
                            <td>
                                 <asp:Label ID="lblid" runat="server" Text='<%#Eval("JobTitle")%>'></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
        </ItemTemplate>
    </asp:Repeater>
    </div>
    </form>
</body>
</html>

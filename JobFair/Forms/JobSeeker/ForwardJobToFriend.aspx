<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForwardJobToFriend.aspx.cs" Inherits="JobFair.Forms.JobSeeker.ForwardJobToFriend" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table  border="1">
                <tr>
                    <td colspan="2">
                        <h3>Forward Job To Friend</h3>
                    </td>
                </tr>
                <tr>
                    <td >Your Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter Email"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td >Your Name</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td >Friend&#39;s Email</td>
                    <td>
                        <asp:TextBox ID="txtFriendEmail" runat="server" placeholder="Enter Friend's Email"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td >Message</td>
                    <td>
                        <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" placeholder="Enter Message"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
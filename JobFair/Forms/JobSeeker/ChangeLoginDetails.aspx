<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangeLoginDetails.aspx.cs" Inherits="JobFair.Forms.JobSeeker.ChangeLoginDetails" %>

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
            <td colspan="2">
                <h1>Login Details</h1>
            </td>
        </tr>
        <tr>
            <td>
                Login Email ID
            </td>
            <td>
                <asp:Label ID="lblLoginMailId" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Alternate Email ID
            </td>
            <td>
                <asp:Label ID="lblAlternateMailId" runat="server"></asp:Label>
                <br />
              <asp:LinkButton ID="lnkbtnMakeLoginId" runat="server" OnClick="lnkbtnMakeLoginId_Click" Text="Make Alternate Email ID as Login ID?"></asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                Add Email ID</td>
            <td>
                <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
                <asp:Button ID="btnAddMailId" runat="server" Text="Add New Mail Id" OnClick="btnAddMailId_Click" />
            </td>
        </tr>
        <tr>
          <td colspan="2">
              &nbsp;</td>
        </tr>
        <tr>
            <td>
                Primary Mobile Number
            </td>
            <td>
                <asp:Label ID="lblPrimaryMobNo" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Alternate Mobile Number
            </td>
            <td>
                <asp:Label ID="lblAlternateMobNo" runat="server"></asp:Label>
                 <br />
                 <asp:LinkButton ID="lnkbtnAlternateMobNo" runat="server" OnClick="lnkbtnAlternateMobNo_Click" Text="Make Alternate Mobile No. as Primary Mobile No.?"></asp:LinkButton>
            </td>
        </tr>

        <tr>
            <td>
                Add Mobile Number</td>
            <td>
                <asp:TextBox ID="txtMobileNumber" runat="server"></asp:TextBox>
                <asp:Button ID="btnAddMobileNo" runat="server" Text="Add New Mobile No" OnClick="btnAddMobileNo_Click" />
            </td>
        </tr>

    </table>
    </div>
    </form>
</body>
</html>

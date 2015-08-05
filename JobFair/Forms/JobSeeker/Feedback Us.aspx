<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback Us.aspx.cs" Inherits="JobFair.Forms.JobSeeker.Feedback_Us" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table >
            <tr>
                <td colspan="2"  ><strong><h1>FeedBack</h1></strong></td>
                
            </tr>
            <tr>
                <td >User Name</td>
                <td>
                    <asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >Email Id</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >Feedback</td>
                <td>
                    <asp:TextBox ID="txtFeedback" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >&nbsp;</td>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
                </td>
            </tr>
            <tr>
                <td >&nbsp;</td>
                <td>
                    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td >&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback Us.aspx.cs" Inherits="JobFair.Forms.JobSeeker.Feedback_Us" %>

<%@ Register Src="~/UserControls/JobSeeker/PersonalDetails.ascx" TagPrefix="uc1" TagName="PersonalDetails" %>









<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       
        <uc1:PersonalDetails runat="server" ID="PersonalDetails" />
    
    </div>

        <table >
            <tr>
                <td colspan="2"  ><h1>FeedBack</h1></td>
                
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
                &nbsp;&nbsp;
                    <asp:Button ID="btnCancelfeedback" runat="server" Text="Cancel" />
                </td>
            </tr>
            <tr>
                <td >&nbsp;</td>
                <td>
                    <asp:Label ID="lblMsg0" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td >&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>

        
    </form>
</body>
</html>

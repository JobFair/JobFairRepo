  
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webform1.aspx.cs" Inherits="JobFair.Forms.JobSeeker.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="~/UserControls/JobSeeker/ProfessionalDetails.ascx" TagPrefix="uc1" TagName="ProfessionalDetails" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:ProfessionalDetails runat="server" id="ProfessionalDetails" />
          <%--  <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table class="auto-style1">
                <tr>
                    <td>From Date</td>
                    <td>
                        <asp:TextBox ID="FromYearTxt" runat="server"></asp:TextBox>
                        <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Enabled="True"
                    TargetControlID="FromYearTxt" Format="MM/yyyy"/>
                    </td>
                    <td>To Date</td>
                    <td>
                        <asp:TextBox ID="ToYearTxt" runat="server"></asp:TextBox>
                        <cc1:CalendarExtender ID="CalendarExtender2" runat="server" Enabled="True"
                    TargetControlID="ToYearTxt" Format="MM/yyyy" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                    </td>
                    <td colspan="2">&nbsp;</td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                         <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>--%>

            </div>
        </form>
    </body>
    </html>



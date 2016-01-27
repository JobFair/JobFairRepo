<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfessionalDetails.aspx.cs" Inherits="JobFair.Forms.Recruiter.ProfessionalDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 147px;
        }
        .auto-style3 {
            width: 147px;
            height: 25px;
        }
        .auto-style4 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblProfessionalDetails" runat="server" Text="Professional Details" style="font-weight: 700"></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbltotalexprience" runat="server" Text="Total  Experience"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txttotalexprience" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"> <asp:Label ID="lblDesiganation" runat="server" Text="Designation"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtdesignation" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><asp:Label ID="lblFreelancer" runat="server" Text="Freelancer"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtfreelancer" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><asp:Label ID="lblemploymentstatus" runat="server" Text="Employment  Status"></asp:Label></td>
                <td>
&nbsp;&nbsp;&nbsp;
                    <asp:RadioButtonList ID="rbtemploymentstatus" runat="server">
                        <asp:ListItem>PartTime</asp:ListItem>
                        <asp:ListItem>Full Time</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><asp:Label ID="lbljobtype" runat="server" Text="Job Type"></asp:Label></td>
                <td class="auto-style4">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButtonList ID="rbtjobtype" runat="server">
                        <asp:ListItem>Peranant</asp:ListItem>
                        <asp:ListItem>Temporary</asp:ListItem>
                        <asp:ListItem>Freelancing</asp:ListItem>
                    </asp:RadioButtonList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

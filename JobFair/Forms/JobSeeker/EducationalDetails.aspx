<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EducationalDetails.aspx.cs" Inherits="JobFair.Forms.JobSeeker.EducationalDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 72%;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 324px;
        }
        .auto-style4 {
            width: 324px;
            height: 27px;
        }
        .auto-style5 {
            height: 27px;
        }
        #form1 {
            height: 450px;
        }
        .auto-style6 {
            width: 324px;
            height: 22px;
        }
        .auto-style7 {
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 433px">
    
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
        <table class="auto-style1">
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblEducationalDetails" runat="server" style="font-size: xx-large" Text="Educational Details"></asp:Label>
                </td>
            </tr>
        </table>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblHigestQualification" runat="server" Text="Highest Qualification"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lbldegree" runat="server" Text="Degree Type"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:DropDownList ID="ddlQualification" runat="server">
                      
                        <asp:ListItem >BA</asp:ListItem>
                        <asp:ListItem >BCA</asp:ListItem>
                        <asp:ListItem >BBA</asp:ListItem>
                        <asp:ListItem >BCom</asp:ListItem>

                    </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lblspecialization" runat="server" Text="Specialization"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtspecialization" runat="server"></asp:TextBox>
                &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblInstitute" runat="server" Text="Institute Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtInstituteName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblPassingYear" runat="server" Text="Year of Passing From"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPassingyear1" runat="server">
                      
                        <asp:ListItem >2010</asp:ListItem>
                        <asp:ListItem >2011</asp:ListItem> 
                        <asp:ListItem >2012</asp:ListItem>
                        <asp:ListItem >2013</asp:ListItem>
                        <asp:ListItem >2014</asp:ListItem>
                        <asp:ListItem >2015</asp:ListItem>
                            </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lblPassingYear0" runat="server" Text="Year of Passing To"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:DropDownList ID="ddlPassingyear2" runat="server">
                      
                        <asp:ListItem >2010</asp:ListItem>
                        <asp:ListItem >2011</asp:ListItem> 
                        <asp:ListItem >2012</asp:ListItem>
                        <asp:ListItem >2013</asp:ListItem>
                        <asp:ListItem >2014</asp:ListItem>
                        <asp:ListItem >2015</asp:ListItem>
                            </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lblemptype" runat="server" Text="Employement Type"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem >Parttime</asp:ListItem>
                        <asp:ListItem >Fulltime</asp:ListItem>
                    </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblStatus" runat="server" Text="Status"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem>Appeared</asp:ListItem>
                        <asp:ListItem>Completed</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnsubmit" runat="server" Text="submit" OnClick="btnsubmit_Click" style="height: 26px" />
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnclear" runat="server" Text="Clear" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

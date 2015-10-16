<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="JobFair.Forms.Recruiter.ViewProfile" %>

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
                    <asp:Image ID="Image1" runat="server" Height="100px" Width="100px" />
                </tr>
                <tr>
                    <td>
                        <span>Name </span></td>
                    <td>
                        <asp:Label ID="lblRecruiterName" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <span>Company Name </span></td>
                    <td>
                        <asp:Label ID="lblCompanyName" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <span>Mobile</span></td>
                    <td>
                        <asp:Label ID="lblMobile" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <span>E-Mail</span></td>
                    <td>
                        <asp:Label ID="lblEmail" runat="server">
                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span>City</span></td>
                    <td>
                        <asp:Label ID="lblCity" runat="server"></asp:Label></td>
                </tr>
            </table>
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table style="border: 1px solid #0000FF; width: 500px">
                        <tr style="background-color: #FF6600; color: #000000; font-size: large; font-weight: bold;">
                            <td colspan="2">
                                <b>Job Post</b>
                            </td>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr style="background-color: #EBEFF0">
                        <td>
                            <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; width: 500px">
                                <tr>
                                    <td>Job Title:
                                 <asp:Label ID="lblSubject" runat="server" Text='<%#Eval("JobTitle") %>' Font-Bold="true" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblComment" runat="server" Text='<%#Eval("JobLocationCity") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("KeywordsTechnical") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; border-bottom: 1px solid #df5015; width: 500px">
                                <tr>
                                    <td>Post By:
                                        <asp:Label ID="lblUser" runat="server" Font-Bold="true" Text='<%#Eval("NumberOfVacancies") %>' /></td>
                                    <td>Created Date:<asp:Label ID="lblDate" runat="server" Font-Bold="true" Text='<%#Eval("PostedDate") %>' /></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
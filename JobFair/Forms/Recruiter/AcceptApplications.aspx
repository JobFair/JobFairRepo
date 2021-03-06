﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AcceptApplications.aspx.cs" Inherits="JobFair.Forms.Recruiter.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Repeater ID="rptrAcceptApplication" runat="server" >
                <HeaderTemplate>
                    <table style="background-color: #f9f9f9; border-top: 1px dotted; border-bottom: 1px solid; width: 500px">
                        <tr>
                            <td>
                        View Applications
                                </td>
                            </tr>
                    </table>
                </HeaderTemplate>
                <ItemTemplate>
                    <table>
                      <tr>
                         
                          <td>Candidate First  Name:
                           <asp:Label ID="Label1" runat="server" Text='<%#Eval("FirstName")%>'  ></asp:Label>&nbsp;&nbsp;&nbsp;
                          </td>
                      </tr>
                    </table>
                    <table>
                        <tr>
                            <td>Candidate  Last  Name:
                           <asp:Label ID="Label2" runat="server" Text='<%#Eval("LastName")%>'  ></asp:Label>&nbsp;&nbsp;&nbsp;
                            </td>
                            <td> EmailId:
                          <asp:Label ID="Label3" runat="server" Text='<%#Eval("EmailId")%>'  ></asp:Label>&nbsp;&nbsp;&nbsp;
                            </td>
                        </tr>
                    </table>
                    <table>
                        <tr>
                            <td> Gender:
                             <asp:Label ID="Label4" runat="server" Text='<%#Eval("Gender")%>'  ></asp:Label>&nbsp;&nbsp;&nbsp;
                            </td>
                            <td>Mob No:
                             <asp:Label ID="Label5" runat="server" Text='<%#Eval("MobileNo")%>'  ></asp:Label>&nbsp;&nbsp;&nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>Status
                            <asp:Label ID="Label6" runat="server" Text='<%#Eval("Status")%>'  ></asp:Label>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:Repeater>
    </div>
    </form>
</body>
</html>

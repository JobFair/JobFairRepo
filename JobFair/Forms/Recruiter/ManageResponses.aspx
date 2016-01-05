<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageResponses.aspx.cs" Inherits="JobFair.Forms.Recruiter.ManageResponses" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>  
        <asp:Repeater ID="rptrmanageresponses" runat="server">
                    <HeaderTemplate>
                    <table style="border: 1px solid #0000FF">
                            <tr style="font-size: large; font-weight: bold; margin-bottom: 5px">
                                <td>
                                    <b>Job Post</b>
                                </td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                     <ItemTemplate>   <tr>
                            <td>
                                <table>
                                    <tr>
                                        <td>
                                           <asp:Label ID="lbljobtittle" runat="server" Text='<%#Eval("JobTitle")%>'></asp:Label>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>  <tr>
                                               <td>
                                            Work Experience&nbsp;&nbsp;
                                        <asp:Label ID="lblworkexprience" runat="server" Text='<%#Eval("WorkExperience")%>'></asp:Label>
                                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                      
                                               </td>
                                                </tr>
                                            </table>
                                        </td>
                                         </tr>                     
                    </table>
                        <tr>
                            <td>
                                <table>
                                    <tr>
                                        <td>Company Name:
                                            <asp:Label ID="lblcompanyname" runat="server" Text='<%#Eval("CompanyName")%>'></asp:Label>
                                        </td>&nbsp;&nbsp;&nbsp;
                                       <td>Posted Date:<asp:Label ID="lblDate" runat="server" Font-Bold="true" Text='<%#Eval("PostedDate","{0:dd MMM yyyy}")%>' /></td>
                                    </tr>
                                </table>
                            </td>
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

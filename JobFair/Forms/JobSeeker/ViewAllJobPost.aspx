<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAllJobPost.aspx.cs" Inherits="JobFair.Forms.JobSeeker.ViewAllJobPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div class="col-md-10">
                <asp:Repeater ID="rptrviewpost" runat="server">
                    <HeaderTemplate>
                    <table style="border: 1px solid #0000FF">
                            <tr style="font-size: large; font-weight: bold; margin-bottom: 5px">
                                <td>
                                    <b>Job Post</b>
                                </td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                     <ItemTemplate>
                        <tr>
                            <td>
                                <table>
                                    <tr>
                                       <td><asp:Label ID="lbljobtitle" runat="server" Text='<%#Eval("JobTitle")%>'></asp:Label>
                                    </table>
                                </td>
                            </tr> 
                          <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td>
                                             <asp:Label ID="lbljobdescription" runat="server" Text='<%#Eval("JobDescription")%>'></asp:Label>
                                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                 </td>
                                        </tr>
                                    </table>
                                    </tr>
                         </td>
                                   <tr>
                            <td>
                                <table>
                                    <tr>
                                        <td>$
                                           [<asp:Label ID="lblMinSalary" runat="server" Text='<%#Eval("OfferedAnnualSalaryMin") %>' />/
                                        <asp:Label ID="lblMaxSalary" runat="server" Text='<%#Eval("OfferedAnnualSalaryMax")%>'></asp:Label>]
                                       

                                        </td>
                                        </tr>
                                </table>
                            </td>
                        </tr>
                         <tr>  
                             <td>  
                                  <table>
                                                
                                      <tr>
                                                  
                                           <td> 
                                                   Key Skill &nbsp;&nbsp;&nbsp;
                                   <asp:Label ID="lblkeywordstechnical" runat="server" Text='<%#Eval("KeywordsTechnical")%>'></asp:Label>
                                                       </td>
                                                </tr>
                                            </table>
                                            </td>
                                        </tr>
                                    <tr>
                            <td>
                                <table >
                                    <tr>
                                        <td>
                                       Company Profile&nbsp;&nbsp;&nbsp;
                             <asp:Label ID="lblvacancies" runat="server" Text='<%#Eval("CompanyName")%>'></asp:Label> </td>
                            </tr>
                        </tr>
                       </td>
                    </table style="background-color: #f9f9f9; border-top: 1px dotted; border-bottom: 1px solid; width: 500px">
                         <tr>
                             <td>
                                 <table>
                                     <tr>
                                         <td>
                                             <asp:Button ID="btnapply" runat="server" Text="Login/Apply"  PostBackUrl="~/Forms/JobSeeker/LogIn.aspx" />
                                         </td>
                                         <td>
                                             <asp:Button ID="btnregister" runat="server" Text="Register/Apply"  />
                                         </td>
                                     </tr>
                                 </table>
                             </td>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
    </form>
</body>
</html>

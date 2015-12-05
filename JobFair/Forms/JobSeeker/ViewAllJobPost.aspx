<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAllJobPost.aspx.cs" Inherits="JobFair.Forms.JobSeeker.ViewAllJobPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
     <div class="col-md-10">
                <asp:Repeater ID="rptrviewpost" runat="server" OnItemCommand="rptrviewpost_ItemCommand">
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
                                        <td>     <asp:Label ID="lblid" runat="server" Text='<%#Eval("JobId")%>' Visible="false"></asp:Label>,
                                          <asp:Label ID="Label2" runat="server" Text='<%#Eval("JobTitle")%>' Visible="false"></asp:Label>
                                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                           <%-- <asp:Label ID="lblareaname" runat="server" Text='<%#Eval("AreaName")%>'></asp:Label>,
                                         <asp:Label ID="lblcityname" runat="server" Text='<%#Eval("CityName")%>'></asp:Label>/
                                             <asp:Label ID="lblstatename" runat="server" Text='<%#Eval("StateName")%>'></asp:Label>--%>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>  <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td>
                                             <asp:Label ID="lblcompanyname" runat="server" Text='<%#Eval("CompanyName")%>'></asp:Label>
                                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                 </td>
                                            <td>
                                                <%--<asp:Label ID="Label3" runat="server" Text='<%#Eval("IndustryName")%>'></asp:Label>--%>

                                            </td>
                                        </tr>
                                    </table>
                                    <tr>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td>
                                                          <%--<asp:Label ID="Label4" runat="server" Text='<%#Eval("DepartmentName")%>'></asp:Label>--%>
                                                    </td>

                                                    <td>
                                                         <td>Functional Area &nbsp;&nbsp;&nbsp;
                                                                 <%--<asp:Label ID="lblfunctionalarea" runat="server" Text='<%#Eval("FunctionalArea") %>' ></asp:Label>--%>
                                                         </td>
                                                    </td>
                                               <td>
                                            Work Experience&nbsp;&nbsp;
                                        <%--<asp:Label ID="lblJobDescription" runat="server" Text='<%#Eval("WorkExperience")%>'></asp:Label>--%>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                      
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
                                                         <%--<asp:Label ID="Label5" runat="server" Text='<%#Eval("Gender")%>'></asp:Label>--%>
                                                    </td>
                                                   <td> 
                                                         Key Skill &nbsp;&nbsp;&nbsp;
                                   <asp:Label ID="lblkeywordstechnical" runat="server" Text='<%#Eval("KeywordsTechnical")%>'></asp:Label>
                                                       </td>
                                                </tr>
                                                   </table>
                        <tr>
                            <td>
                                <table >
                                    <tr>
                                        <td>$
                                           [<asp:Label ID="lblMinSalary" runat="server" Text='<%#Eval("OfferedAnnualSalaryMin") %>' />/
                                        <asp:Label ID="lblMaxSalary" runat="server" Text='<%#Eval("OfferedAnnualSalaryMax")%>'></asp:Label>]
                                            </tr>
                                    </td>
                            </table>
                            </tr>
                                 <td>
                                <table>
                                    <tr>
                                        <td>
                                       Number of Vacancies&nbsp;&nbsp;&nbsp;
                             <%--<asp:Label ID="lblvacancies" runat="server" Text='<%#Eval("JobType")%>'></asp:Label> </td>--%>
                                        <td>
                               <%-- <asp:Label ID="Label6" runat="server" Text='<%#Eval("EmploymentStatus")%>'></asp:Label> </td>--%>
                                        </td>
                            </tr>
                        </tr>
                       </td>
                                            </table>
                                            </td>
                                        </tr>
                                            <tr>
                                                <td>
                                                    <table>
                                                        <tr>
                                                            <td>
                                                              <%--<asp:Label ID="Label7" runat="server" Text='<%#Eval("CompanyName")%>'></asp:Label> </td>--%>
                                                            <td>

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
                                             <asp:Button ID="btnapply" runat="server" Text="Apply" OnClick="btnapply_Click" CommandName="apply"/>
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

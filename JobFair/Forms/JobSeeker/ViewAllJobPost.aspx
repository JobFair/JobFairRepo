<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAllJobPost.aspx.cs" Inherits="JobFair.Forms.JobSeeker.ViewAllJobPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div class="col-md-10">
                <asp:Repeater ID="rptrJobPost" runat="server">
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
                                        <td> <asp:Label ID="lbljobtitle" runat="server" Text='<%#Eval("JobTitle")%>'></asp:Label>
                                            
                                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Label ID="lblareaname" runat="server" Text='<%#Eval("AreaName")%>'></asp:Label>,
                                         <asp:Label ID="lblcityname" runat="server" Text='<%#Eval("CityName")%>'></asp:Label>/
                                             <asp:Label ID="lblstatename" runat="server" Text='<%#Eval("StateName")%>'></asp:Label>
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
                                        </tr>
                                    </table>
                                    <tr>
                                        <td>
                                            <table>
                                                <tr>
                                               <td>
                                            Work Experience&nbsp;&nbsp;
                                        <asp:Label ID="lblJobDescription" runat="server" Text='<%#Eval("WorkExperience")%>'></asp:Label>
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
                                                         Key Skill &nbsp;&nbsp;&nbsp;
                                   <asp:Label ID="lblkeywordstechnical" runat="server" Text='<%#Eval("KeywordsTechnical")%>'></asp:Label>
                                                       </td>
                                                </tr>
                                            </table>
                                            </td>
                                        </tr>
                                            <tr>
                                                <td>
                                                    <table>
                                                        <tr>
                                                            <td>Functional Area &nbsp;&nbsp;&nbsp;
                                                                 <asp:Label ID="lblfunctionalarea" runat="server" Text='<%#Eval("FunctionalArea") %>' ></asp:Label>
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
                                       Number of Vacancies&nbsp;&nbsp;&nbsp;
                             <asp:Label ID="lblvacancies" runat="server" Text='<%#Eval("NumberOfVacancies")%>'></asp:Label> </td>
                            </tr>
                        </tr>
                       </td>
                    </table>
                        <tr>
                            <td>
                                <table style="background-color: #f9f9f9; border-top: 1px dotted; border-bottom: 1px solid; width: 500px">
                                    <tr>
                                        <td>$
                                           [<asp:Label ID="lblMinSalary" runat="server" Text='<%#Eval("OfferedAnnualSalaryMin") %>' />/
                                        <asp:Label ID="lblMaxSalary" runat="server" Text='<%#Eval("OfferedAnnualSalaryMax")%>'></asp:Label>]
                                       

                                        </td>
                                       <td>Posted Date:<asp:Label ID="lblDate" runat="server" Font-Bold="true" Text='<%#Eval("PostedDate","{0:dd MMM yyyy}")%>' /></td>
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

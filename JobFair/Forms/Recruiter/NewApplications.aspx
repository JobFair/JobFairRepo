<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewApplications.aspx.cs" Inherits="JobFair.Forms.Recruiter.NewApplications" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Repeater ID="rptrcandidatedetails" runat="server">
                    <HeaderTemplate>
                    <table style="border: 1px solid #0000FF">
                            <tr style="font-size: large; font-weight: bold; margin-bottom: 5px">
                                <td>
                                    <b> Apply Candidate</b>
                                </td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                     <ItemTemplate>   <tr>
                            <td>
                                <table>
                                    <tr>
                                        <td>Resume HeadLine
                                           <div class="divjobtitle"> <asp:HyperLink ID="HyperLink1"  runat="server" Text='<%#Eval("ResumeHeadline")%>' NavigateUrl="ViewAllJobPost.aspx"></asp:HyperLink></div>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            CurrentWorkingStatus:
                                            <asp:Label ID="lbli" runat="server" Text='<%#Eval("CurrentWorkingStatus")%>'></asp:Label>
                                            &nbsp;&nbsp;TotalExpriance:
                                            <asp:Label ID="lbltotalexp" runat="server" Text='<%#Eval("TotalExpriance")%>'></asp:Label>
                                            CurrentAnualSalary &nbsp;$
                                         [<asp:Label ID="lblcurrentannualsalary" runat="server" Text='<%#Eval("CurrentAnualSalary")%>'></asp:Label>
                                           ExpectedAnualSalary &nbsp; $
                                             <asp:Label ID="lblannualsalary" runat="server" Text='<%#Eval("ExpectedAnualSalary")%>'></asp:Label>]
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>  <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td>NoticePeriod:
                                             <asp:Label ID="lblnoticeperiod" runat="server" Text='<%#Eval("NoticePeriod")%>'></asp:Label>
                                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                 </td>
                                        </tr>
                                    </table>
                                    <tr>
                                        <td>
                                            <table>
                                                <tr>
                                               <td>
                                               Date Of Birth:&nbsp;&nbsp;
                                        <asp:Label ID="lbldateofBirth" runat="server" Text='<%#Eval("DateOfBirth")%>'></asp:Label>
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
                                           Gender: &nbsp;&nbsp;&nbsp;
                                   <asp:Label ID="lblgender" runat="server" Text='<%#Eval("Gender")%>'></asp:Label>
                                                       </td>
                                                </tr>
                                            </table>
                                            </td>
                                        </tr>
                                            <tr>
                                                <td>
                                                    <table>
                                                        <tr>
                                                            <td>MaritalStatus &nbsp;&nbsp;&nbsp;
                                                                 <asp:Label ID="lblmaritalstaus" runat="server" Text='<%#Eval("MaritalStatus") %>' ></asp:Label>
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
                                       Location &nbsp;&nbsp;&nbsp;
                             <asp:Label ID="lblcountry" runat="server" Text='<%#Eval("PreferredCountry")%>'></asp:Label> ,</td>
                                 <asp:Label ID="lblstate" runat="server" Text='<%#Eval("PreferredState")%>'></asp:Label>/ </td>
                                 <asp:Label ID="lblcity" runat="server" Text='<%#Eval("PreferredCity")%>'></asp:Label> </td>
                            </tr>
                        </tr>
                       </td>
                    </table>
                        <tr>
                            <td>
                                <table>
                                    <tr>
                                        <td>RelevantExperience
                                           <asp:Label ID="lblrelevantExperience" runat="server" Text='<%#Eval("RelevantExperience") %>' />&nbsp;&nbsp;&nbsp;
                                            RelevantExperience:
                                        <asp:Label ID="lblDepartment" runat="server" Text='<%#Eval("Department")%>'></asp:Label>&nbsp;&nbsp;&nbsp;
                                            JobPostLookingFor
                                            <asp:Label ID="lbljobpostlookingfor" runat="server" Text='<%#Eval("JobPostLookingFor") %>'></asp:Label> 
                                            &nbsp;&nbsp;&nbsp;

                                       

                                        </td>Designation:
                                       <td> <asp:Label ID="lbldesignation" runat="server" Text='<%#Eval("Designation") %>'></asp:Label> 

                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">&nbsp;</td>
                        </tr>
                   <tr>
                       <td>
                           <table style="background-color: #f9f9f9; border-top: 1px dotted; border-bottom: 1px solid; width: 500px">
                               <tr>
                                   <td>
                                       <asp:Button ID="btnaccept" runat="server" Text="Accept" />
                                   </td>
                                   <td>
                                       <asp:Button ID="Btnreject" runat="server" Text="Reject" />
                                   </td>
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

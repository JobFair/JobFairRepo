<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageResponses.aspx.cs" Inherits="JobFair.Forms.Recruiter.ManageResponses" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> </title>
</head>
<body>
    <form id="form1" runat="server">
       
    <div>  
        <asp:Label ID="lblmanageresponses" runat="server" Text="Manage Responses"></asp:Label>
     <asp:ScriptManager  runat="server"></asp:ScriptManager> 
        <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Width="516px" Height="580px">
            <cc1:TabPanel runat="server" HeaderText="ActiveJobs" ID="TabPanel1" ScrollBars="Vertical"> 
                <ContentTemplate>
                    <asp:Repeater id ="rptractivejobs" runat="server">
                   <ItemTemplate>
                        
                     <tr>
                            <td><table style="background-color: #f9f9f9; border-top: 1px dotted; border-bottom: 1px solid; width: 500px">
                           <asp:Button ID="btnnewapllications" runat="server" Text="New Applications" PostBackUrl="~/Forms/Recruiter/NewApplications.aspx"/>
                           <asp:Button ID="btnviewapplications" runat="server" Text="View Applications" />
                           <asp:Button ID="btnrejet" runat="server" Text="Accepted" />
                           <asp:Button ID="btnreject" runat="server" Text="Rejected" />
                           <tr>
                               <td>

                               </td>
                           </tr>
                       </table>
                                <table>
                                    <tr>
                                        <td>
                                           <asp:Label ID="lbljobid" runat="server" Text='<%#Eval("JobId")%>' Visible="false"></asp:Label>               
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Label ID="lblrecruiterid" runat="server" Text='<%#Eval("RecruiterID")%>' Visible="false"></asp:Label>
                                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            JobTitle:
                                                <asp:Label ID="lbljobtitle" runat="server" Text='<%#Eval("JobTitle")%>'></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>  <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td>
                                            Location:
                                            <asp:Label ID="lblareaname" runat="server" Text='<%#Eval("AreaName")%>'></asp:Label>,
                                         <asp:Label ID="lblcityname" runat="server" Text='<%#Eval("CityName")%>'></asp:Label>
                                                </td> 
                                            <td>&nbsp;&nbsp;&nbsp;&nbsp; WorkExperience:
                                             <asp:Label ID="lblworkexprience" runat="server" Text='<%#Eval("WorkExperience")%>'></asp:Label>
                                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                 </td>
                                        </tr>
                                    </table>
                                    <tr>
                                        <td>
                                            <table>
                                                <tr>
                                               <td>
                                            CompanyName:&nbsp;&nbsp;
                                        <asp:Label ID="lblcompanyname" runat="server" Text='<%#Eval("CompanyName")%>'></asp:Label>
                                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                      
                                               </td>
                                                </tr>
                                            </table>
                                        </td>
                                        </tr>
                            <td>
                                <table>
                                    <tr>
                                       <td>Posted Date:<asp:Label ID="lblDate" runat="server" Font-Bold="true" Text='<%#Eval("PostedDate","{0:dd MMM yyyy}")%>' /></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                      
                      </ItemTemplate>
                        </asp:Repeater>
                 </ContentTemplate>
            </cc1:TabPanel>
            <cc1:TabPanel runat="server" HeaderText="InActiveJobs" ID="TabPanel2">
                <ContentTemplate>
                <asp:Repeater id ="rptrinactivejobs" runat="server" >
                   <ItemTemplate>
                     <tr>
                            <td>
                                <table>
                                    <tr>
                                        <td>
                                           <asp:Label ID="lbljobid" runat="server" Text='<%#Eval("JobId")%>' Visible="false"></asp:Label>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Label ID="lblrecruiterid" runat="server" Text='<%#Eval("RecruiterID")%>' Visible="false"></asp:Label>
                                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            JobTitle:
                                                <asp:Label ID="lbljobtitle" runat="server" Text='<%#Eval("JobTitle")%>'></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>  <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td>
                                            Location:
                                            <asp:Label ID="lblareaname" runat="server" Text='<%#Eval("AreaName")%>'></asp:Label>,
                                         <asp:Label ID="lblcityname" runat="server" Text='<%#Eval("CityName")%>'></asp:Label>
                                                </td> 
                                            <td>&nbsp;&nbsp;&nbsp;&nbsp; WorkExperience:
                                             <asp:Label ID="lblworkexprience" runat="server" Text='<%#Eval("WorkExperience")%>'></asp:Label>
                                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                 </td>
                                        </tr>
                                    </table>
                                    <tr>
                                        <td>
                                            <table>
                                                <tr>
                                               <td>
                                            CompanyName:&nbsp;&nbsp;
                                        <asp:Label ID="lblcompanyname" runat="server" Text='<%#Eval("CompanyName")%>'></asp:Label>
                                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                      
                                               </td>
                                                </tr>
                                            </table>
                                        </td>
                                        </tr>
                            <td>
                                <table style="background-color: #f9f9f9; border-top: 1px dotted; border-bottom: 1px solid; width: 500px">
                                    <tr>
                                       <td>Posted Date:<asp:Label ID="lblDate" runat="server" Font-Bold="true" Text='<%#Eval("PostedDate","{0:dd MMM yyyy}")%>' /></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                      </ItemTemplate>
                        </asp:Repeater>
                 </ContentTemplate>
            </cc1:TabPanel>
        </cc1:TabContainer>
        </div>

    </form>
                    </body>
                    </html>

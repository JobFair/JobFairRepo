<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageJobs.aspx.cs" Inherits="JobFair.Forms.Recruiter.ManageJobs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div id="divMain" runat="server" style="min-height: 500px; width: 100%; padding: 10px">
            <h2> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Manage Jobs </h2>
       
         <asp:Repeater ID="repJobsDetails" runat="server">
                <HeaderTemplate>
                    <table style="border: 1px solid #0000FF; width:100%">
                        <tr style="background-color: #FF6600; color: #000000; font-size: large; font-weight: bold;">
                            <td style="float:left; width:70%">
                               <center><b>Jobs Details</b></center>
                            </td>
                            <td Style="float:right; width:20%">
                                <center><b>Manage Profile</b></center>
                            </td>
                        </tr>
                     </table>
                </HeaderTemplate>
                <ItemTemplate>
                            <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; border-bottom: 1px solid #df5015; float:left; width:80%">
                              <tr>
                                    <td>Job Title:
                                        <asp:Label ID="lblJobID" runat="server" Text='<%#Eval("JobId") %>' Visible="false"/>
                                        <asp:Label ID="lblSubject" runat="server" Text='<%#Eval("JobTitle") %>' Font-Bold="true" /></td>
                                    <td>Location:
                                        <asp:Label ID="lblLocation" runat="server" Font-Bold="true" Text='<%#Eval("JobLocationCity") %>' /></td>
                               </tr>
                               <tr>
                                    <td>Functional Area:
                                        <asp:Label ID="lblFunctionalArea" runat="server" Font-Bold="true" Text='<%#Eval("FunctionalAreaId") %>' /></td>
                                    <td>Experience:
                                        <asp:Label ID="lblExperience" runat="server" Font-Bold="true" Text='<%#Eval("WorkExprience") %>' /></td>
                               </tr>
                               <tr> 
                                    <td>Gender:
                                        <asp:Label ID="lblGender" runat="server" Font-Bold="true" Text='<%#Eval("Gender") %>' /></td>
                                    <td>No Of Vacancy:
                                        <asp:Label ID="lblNoOfVacancy" runat="server" Font-Bold="true" Text='<%#Eval("NumberOfVacancies") %>' /></td>
                               </tr>
                               <tr>
                                    <td>Salary(Per Anum):
                                        <asp:Label ID="lblSalaryMin" runat="server" Font-Bold="true" Text='<%#Eval("OfferedAnnualSalaryMin") %>' /> - 
                                        <asp:Label ID="lblSalaryMax" runat="server" Font-Bold="true" Text='<%#Eval("OfferedAnnualSalaryMax") %>' /></td>
                                    <td>Posted Date:
                                        <asp:Label ID="lblPostedDate" runat="server" Font-Bold="true" Text='<%#Eval("PostedDate") %>' /></td>
                                </tr>
                            </table>
                <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; border-bottom: 1px solid #df5015; float:right; width:20%">
                             <tr></tr>  
                             <tr>
                                  <td>
                                     <asp:HyperLink ID="hyperlnkViewDeatils" runat="server">View Details</asp:HyperLink>
                                 </td>
                             </tr>
                             <tr>
                                 <td>
                                     <asp:HyperLink ID="hyperlnkEdit" runat="server">Edit/Modify</asp:HyperLink>
                                 </td>
                             </tr>
                             <tr>
                                 <td>
                                     <asp:HyperLink ID="hyperlnkDelete" runat="server">Delete</asp:HyperLink>
                                 </td>
                             </tr>
                 </table>
                     </ItemTemplate>
                <FooterTemplate>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
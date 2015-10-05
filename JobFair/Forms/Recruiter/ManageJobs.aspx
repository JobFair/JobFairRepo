<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageJobs.aspx.cs" Inherits="JobFair.Forms.Recruiter.ManageJobs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div id="divMain" runat="server" style="min-height: 500px; width: 100%; padding: 10px">
            <h2>Manage Jobs &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </h2>
        <div id="divJobDetails" runat="server" style="float:left; width: 70%">

         <asp:Repeater ID="repJobsDetails" runat="server">
                <HeaderTemplate>
                    <table style="border: 1px solid #0000FF; width:100%">
                        <tr style="background-color: #FF6600; color: #000000; font-size: large; font-weight: bold;">
                            <td colspan="2">
                               <center><b>Jobs Details</b></center>
                            </td>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr style="background-color: #EBEFF0">
                        <td>
                            <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; width:100%">
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
                            <table style="background-color: #EBEFF0; border-top: 1px dotted #df5015; border-bottom: 1px solid #df5015; width:100%">
                                 <tr>
                                    <td>Location:
                                        <asp:Label ID="lblLocation" runat="server" Font-Bold="true" Text='<%#Eval("JobLocationCity") %>' /></td>
                                    <td>Functional Area:
                                        <asp:Label ID="lblFunctionalArea" runat="server" Font-Bold="true" Text='<%#Eval("FunctionalAreaId") %>' /></td>
                                </tr>
                                <tr>
                                    <td>Experience:
                                        <asp:Label ID="lblExperience" runat="server" Font-Bold="true" Text='<%#Eval("WorkExprience") %>' /></td>
                                    <td>Gender:
                                        <asp:Label ID="lblGender" runat="server" Font-Bold="true" Text='<%#Eval("Gender") %>' /></td>
                                </tr>
                                <tr>
                                    <td>No Of Vacancy:
                                        <asp:Label ID="lblNoOfVacancy" runat="server" Font-Bold="true" Text='<%#Eval("NumberOfVacancies") %>' /></td>
                                    <td>Salary(Per Anum):
                                        <asp:Label ID="lblSalaryMin" runat="server" Font-Bold="true" Text='<%#Eval("OfferedAnnualSalaryMin") %>' /> - 
                                        <asp:Label ID="lblSalaryMax" runat="server" Font-Bold="true" Text='<%#Eval("OfferedAnnualSalaryMax") %>' /></td>
                                </tr>
                                <tr>
                                    <td>Posted Date:
                                        <asp:Label ID="lblPostedDate" runat="server" Font-Bold="true" Text='<%#Eval("PostedDate") %>' /></td>
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
       
        <div id="divManageProfile" runat="server" style="float:right; width: 30%">
              <table style="border: 1px solid #0000FF; width:100%">
                        <tr style="background-color: #FF6600; color: #000000; font-size: large; font-weight: bold;">
                            <td colspan="2">
                               <center><b>Manage Profile</b></center>
                            </td>
                        </tr>
                        <tr style="font-size: large; font-weight: bold; line-height:250%">
                            <td colspan="3">
                                <asp:HyperLink ID="hyperlnkViewDeatils" runat="server"><b>View Details</b></asp:HyperLink>
                            </td>
                        </tr>
                        <tr style="font-size: large; font-weight: bold; line-height:250%">
                            <td colspan="3">
                                <asp:HyperLink ID="hyperlnkEdit" runat="server"><b>Edit/Modify</b></asp:HyperLink>
                            </td>
                        </tr>
                        <tr style="font-size: large; font-weight: bold; line-height:250%">
                            <td colspan="3">
                                <asp:HyperLink ID="hyperlnkDelete" runat="server"><b>Delete</b></asp:HyperLink>
                            </td>
                        </tr>
                  <tr></tr>
              </table>
        </div>
        </div>
    </form>
</body>
</html>
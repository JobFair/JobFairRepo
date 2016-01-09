<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewJobPost.aspx.cs" Inherits="JobFair.Forms.JobSeeker.ViewJobPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="rptrJobPost" runat="server" OnItemCommand="rptrJobPost_ItemCommand">
                <HeaderTemplate>
                    <table style="border: 1px solid #0000FF; width: 500px">
                        <tr style="background-color: #349213; color: #000000; font-size: large; font-weight: bold;">
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
                                    <td>
                                        <div class="divjobtitle">
                                            <asp:HyperLink ID="HyperLink1" runat="server" Text='<%#Eval("JobTitle")%>' NavigateUrl="ViewAllJobPost.aspx"></asp:HyperLink></div>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Label ID="lblid" runat="server" Text='<%#Eval("JobId")%>' Visible="false"></asp:Label>
                                        <asp:Label ID="lblareaname" runat="server" Text='<%#Eval("AreaName")%>'></asp:Label>,
                                         <asp:Label ID="lblcityname" runat="server" Text='<%#Eval("CityName")%>'></asp:Label>,
                                             <asp:Label ID="lblstatename" runat="server" Text='<%#Eval("StateName")%>'></asp:Label>
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
                                        <asp:Label ID="lblcompanyname" runat="server" Text='<%#Eval("CompanyName")%>'></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    </td>
                                </tr>
                            </table>
                            <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td>Work Experience&nbsp;&nbsp;
                                        <asp:Label ID="lblworkexprience" runat="server" Text='<%#Eval("WorkExperience")%>'></asp:Label>
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
                                            <td>Key Skill &nbsp;&nbsp;&nbsp;
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
                                                                 <asp:Label ID="lblfunctionalarea" runat="server" Text='<%#Eval("FunctionalArea") %>'></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td>Number of Vacancies&nbsp;&nbsp;&nbsp;
                             <asp:Label ID="lblvacancies" runat="server" Text='<%#Eval("NumberOfVacancies")%>'></asp:Label>
                                            </td>
                                        </tr>
                            </tr>
                        </td>
                        </table>
                        <tr>
                            <td>
                                <table>
                                    <tr>
                                        <td>$
                                           [<asp:Label ID="lblMinSalary" runat="server" Text='<%#Eval("OfferedAnnualSalaryMin") %>' />-
                                        <asp:Label ID="lblMaxSalary" runat="server" Text='<%#Eval("OfferedAnnualSalaryMax")%>'></asp:Label>]
                                        </td>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                       <td>Posted Date:<asp:Label ID="lblDate" runat="server" Font-Bold="true" Text='<%#Eval("PostedDate","{0:dd MMM yyyy}")%>' /></td>
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
                                            <asp:Button ID="btnapply" OnClientClick="document.forms[0].target='_blank';" runat="server" Text="Apply" CommandName="Contact" UseSubmitBehavior="false" />
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
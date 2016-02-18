<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="JobFair.Forms.JobSeeker.Search" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>

            <table border="1">
                <tr>
                  
                        <h3>Search Job</h3>
                   
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtKeywords" runat="server" placeholder="Skills"></asp:TextBox>
                        <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="txtKeywords" MinimumPrefixLength="1"
                            EnableCaching="false" CompletionSetCount="1" CompletionInterval="10" ServiceMethod="GetKeywords" DelimiterCharacters="," FirstRowSelected="false" ShowOnlyCurrentWordInCompletionListItem="true">
                        </cc1:AutoCompleteExtender>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLocation" runat="server" placeholder="Location"></asp:TextBox>
                        <cc1:AutoCompleteExtender ID="AutoCompleteExtender2" runat="server" TargetControlID="txtLocation" MinimumPrefixLength="1"
                            EnableCaching="false" CompletionSetCount="1" CompletionInterval="10" ServiceMethod="GetCity" DelimiterCharacters="," FirstRowSelected="false" ShowOnlyCurrentWordInCompletionListItem="true">
                        </cc1:AutoCompleteExtender>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlExperience" runat="server">
                            <asp:ListItem>Experience</asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>0.5</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>1.5</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>2.5</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>3.5</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>4.5</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>5.5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>6.5</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>7.5</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>8.5</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>9.5</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                            <asp:ListItem>13</asp:ListItem>
                            <asp:ListItem>14</asp:ListItem>
                            <asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>16</asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                            <asp:ListItem>19</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlSalary" runat="server">
                            <asp:ListItem>Salary</asp:ListItem>
                            <asp:ListItem>50,000</asp:ListItem>
                            <asp:ListItem>1,00,000</asp:ListItem>
                            <asp:ListItem>2,00,000</asp:ListItem>
                            <asp:ListItem>3,00,000</asp:ListItem>
                            <asp:ListItem>4,00,000</asp:ListItem>
                            <asp:ListItem>5,00,000</asp:ListItem>
                            <asp:ListItem>6,00,000</asp:ListItem>
                            <asp:ListItem>7,00,000</asp:ListItem>
                            <asp:ListItem>8,00,000</asp:ListItem>
                            <asp:ListItem>9,00,000</asp:ListItem>
                            <asp:ListItem>10,00,000</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="btnSearchJob" runat="server" Text="Search Job" OnClick="btnSearchJob_Click" />
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />

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
                                         <h3> <asp:HyperLink ID="HyperLink1" runat="server" Text='<%#Eval("JobTitle")%>' NavigateUrl="ViewAllJobPost.aspx"></asp:HyperLink></h3>
                                        </div>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Label ID="lblid" runat="server" Text='<%#Eval("JobId")%>' Visible="false"></asp:Label>

                                        <asp:Label ID="lblcityname" runat="server" Text='<%#Eval("CityName")%>'></asp:Label>
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
                                        <asp:Label ID="lblworkexprience" runat="server" Text='<%#Eval("WorkExperienceMin")%>'></asp:Label>-
                                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("WorkExperienceMax")%>'></asp:Label>&nbsp;Years
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
                                                                <%-- <asp:Label ID="lblfunctionalarea" runat="server" Text='<%#Eval("FunctionalArea") %>'></asp:Label>--%>
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
                                        <td>[<asp:Label ID="lblMinSalary" runat="server" Text='<%#Eval("OfferedAnnualSalaryMin") %>' />-
                                        <asp:Label ID="lblMaxSalary" runat="server" Text='<%#Eval("OfferedAnnualSalaryMax")%>'></asp:Label>]
                                        </td>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                       <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Posted Date:<asp:Label ID="lblDate" runat="server" Font-Bold="true" Text='<%#Eval("PostedDate","{0:dd MMM yyyy}")%>' /></td>
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

             <div style="overflow: hidden;">
        <asp:Repeater ID="rptPaging" runat="server" onitemcommand="rptPaging_ItemCommand">
            <ItemTemplate>
                                <asp:LinkButton ID="btnPage"
                 style="padding:8px; margin:2px; background:#ffa100; border:solid 1px #666; font:8pt tahoma;"
                CommandName="Page" CommandArgument="<%# Container.DataItem %>"
                 runat="server" ForeColor="White" Font-Bold="True"><%# Container.DataItem %>
                                </asp:LinkButton>
           </ItemTemplate>
        </asp:Repeater>
        </div>
        </div>
    </form>
</body>
</html>
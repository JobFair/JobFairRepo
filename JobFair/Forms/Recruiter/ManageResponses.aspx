<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageResponses.aspx.cs" Inherits="JobFair.Forms.Recruiter.ManageResponses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>  
   <table>
       <tr>
           <td>
               Job Post ID
           </td>
           <td>
               <asp:TextBox ID="txtJobPostId" runat="server"></asp:TextBox>
           </td>
       </tr>
       <tr>
           <td>
               Job Post
           </td>
           <td>
               <asp:TextBox ID="txtJobPost" runat="server"></asp:TextBox>
           </td>
       </tr>
       <tr>
           <td>
               Client Name
           </td>
           <td>
               <asp:DropDownList ID="ddlClientName" runat="server"></asp:DropDownList>
           </td>
       </tr>
       <tr>
           <td>
               Duration
           </td>
           <td>
                <asp:DropDownList ID="ddlFromMonth" runat="server">
                                </asp:DropDownList>
                                <asp:DropDownList ID="ddlFromYear" runat="server">
                                </asp:DropDownList>
                                &nbsp;Till<asp:DropDownList ID="ddlTillMonth" runat="server">
                                </asp:DropDownList>
                                <asp:DropDownList ID="ddlTillYear" runat="server">
                                </asp:DropDownList>
           </td>
       </tr>
       <tr>
           <td colspan="2">
               <asp:Repeater ID="rptrManageJobs" runat="server">
                    <HeaderTemplate>
                                            <table>
                                                <tr>
                                                    <td colspan="2">
                                                        <h1>Your Technical Skills</h1>
                                                    </td>
                                                </tr>
                                        </HeaderTemplate>
                                        <ItemTemplate>

                                            <tr style="background-color: #EBEFF0">
                                                <td>
                                                    <table style="background-color: #EBEFF0; border-top: 1px dotted #c1650f; width: 300px">
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="lblJobPostName" runat="server" Text='<%#Eval("TechnicalSkillName") %>' />
                                                                
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                
                                                                <asp:Label ID="lblJobPostId" runat="server" Text='<%#Eval("FromDate") %>' />
                                                               
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                
                                                                <asp:Label ID="lblLocation" runat="server" Text='<%#Eval("TillDate") %>' />
                                                               
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>                                                                
                                                                <asp:Label ID="lblClientName" runat="server" Text='<%#Eval("Proficiency") %>' />                                                               
                                                            </td>
                                                        </tr>
                                                         <tr>
                                                            <td>
                                                                
                                                                <asp:Label ID="lblJobPostedDate" runat="server" Text='<%#Eval("Proficiency") %>' />                                                               
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="lblPositionClosed" runat="server"></asp:Label>
                                                            </td>
                                                        </tr>
                                                       
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <table style="background-color: #EBEFF0; border-top: 1px dotted #c1650f; border-bottom: 1px solid #c1650f; width: 300px">
                                                        <tr>
                                                            <td>
                                                                <asp:LinkButton ID="lnkEdit" runat="server" CommandArgument='<%#Eval("SkillId") %>' CommandName="edit">Edit</asp:LinkButton>
                                                                <asp:LinkButton ID="lnkDelete" runat="server" CommandArgument='<%#Eval("SkillId") %>' CommandName="delete" OnClientClick="return confirm('Are you sure you want to delete?')">Delete</asp:LinkButton>
                                                                <asp:LinkButton ID="lnkUpdate" runat="server" CommandArgument='<%#Eval("SkillId") %>' CommandName="update" Visible="false">Update</asp:LinkButton>
                                                                <asp:LinkButton ID="lnkCancel" runat="server" CommandArgument='<%#Eval("SkillId") %>' CommandName="cancel" Visible="false">Cancel</asp:LinkButton>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">&nbsp;</td>
                                            </tr>
                                            </table>
                                        </ItemTemplate>
               </asp:Repeater>
           </td>
          
       </tr>
   </table>    
    </div>
    </form>
</body>
</html>

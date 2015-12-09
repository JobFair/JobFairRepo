<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageResponses.aspx.cs" Inherits="JobFair.Forms.Recruiter.ManageResponses" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

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
                                &nbsp;<asp:TextBox ID="txtFromDate" runat="server"></asp:TextBox>
                                <cc1:CalendarExtender ID="txtFromDate_CalendarExtender" runat="server" BehaviorID="txtFromDate_CalendarExtender" TargetControlID="txtFromDate">
                                </cc1:CalendarExtender>
                Till<asp:TextBox ID="txtTillDate" runat="server"></asp:TextBox>
                                <cc1:CalendarExtender ID="txtTillDate_CalendarExtender" runat="server" BehaviorID="txtTillDate_CalendarExtender" TargetControlID="txtTillDate">
                                </cc1:CalendarExtender>
           </td>
       </tr>
       <tr>
           <td colspan="2">
               <asp:Repeater ID="rptrManageJobs" runat="server">
                    <HeaderTemplate>
                                            <table>
                                                <tr>
                                                    <td colspan="2">
                                                        <h1></h1>
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

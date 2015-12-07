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
                   
               </asp:Repeater>
           </td>
          
       </tr>
   </table>    
    </div>
    </form>
</body>
</html>
